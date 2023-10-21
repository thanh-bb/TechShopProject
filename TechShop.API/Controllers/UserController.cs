using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechShop.API.Extensions;
using TechShop.API.Repositories;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;

namespace TechShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]


    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("me")]
        public async Task<IActionResult> GetAllUser()
        {
            var userId = User.GetUserId();

            var post = await _userRepository.GetUserByUserId(Guid.Parse(userId));
            return Ok(post);
        }

        [HttpGet]
        [Route(nameof(GetProductOfUser))]
        public async Task<IActionResult> GetProductOfUser()
        {
            var userId = User.GetUserId();

            var post = await _userRepository.GetProductByUserId(Guid.Parse(userId));
            return Ok(post);
        }

        [HttpGet]
        [Route(nameof(GetCartOfUser))]
        public async Task<IActionResult> GetCartOfUser()
        {
            var userId = User.GetUserId();

            var post = await _userRepository.GetCartByUserId(Guid.Parse(userId));
            return Ok(post);
        }
    }
}
