using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TechShop.API.Data;
using TechShop.API.Entities;
using TechShop.Models.Dtos;

namespace TechShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SignInManager<KhachHang> _signInManager;
        private readonly UserManager<KhachHang> _userManager;
        private readonly TechShopDbContext _context;
        public LoginController(IConfiguration configuration,
                               UserManager<KhachHang> userManager,
                               SignInManager<KhachHang> signInManager,
                               TechShopDbContext context)
        {
            _configuration = configuration;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

     
        // tedu - token

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
             var user = await _userManager.FindByNameAsync(login.UserName);
             if (user == null) return BadRequest(new LoginResponse { Successful = false, Error = "Username are invalid." });

            //  var result = await _signInManager.PasswordSignInAsync(login.UserName, login.PasswordHash, false, false);         

            //  if (!result.Succeeded) return BadRequest(new LoginResponse { Successful = false, Error = "Password are invalid." });

            var result = _context.KhachHang.SingleOrDefault(p => p.UserName == login.UserName && login.PasswordHash == p.PasswordHash);
            if (result == null)
            {
                return BadRequest(new LoginResponse
                {
                    Successful = false,
                    Error = "Username and Password are invalid."
                });
            }
            
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, login.UserName),
                new Claim("UserId", user.Id.ToString() )
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return Ok(new LoginResponse { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
        }


        // Hien - token

    }

}
