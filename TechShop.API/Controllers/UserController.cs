﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechShop.API.Entities;
using TechShop.API.Extensions;
using TechShop.API.Repositories;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;
using TechShop.Models.Enums;

namespace TechShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]


    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public UserController(IUserRepository userRepository,
                             IShoppingCartRepository shoppingCartRepository)
        {
            _userRepository = userRepository;
            _shoppingCartRepository = shoppingCartRepository;
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


        
        [HttpPost]
        [AllowAnonymous]
        [Route(nameof(CreateUser))]
        public async Task<IActionResult> CreateUser([FromBody] UserCreate kh)
        {
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var task = await _userRepository.Create(new KhachHang()
            {
                Id = Guid.NewGuid(),
                TenKH = kh.TenKH,
                NgaySinh = kh.NgaySinh,
                Gender = kh.Gender.HasValue ? kh.Gender.Value : Gender.Male,                
                Email = kh.Email,
                NormalizedEmail = kh.Email,
                DienThoai = kh.DienThoai,
                PhoneNumber = kh.DienThoai,
                UserName = kh.UserName,
                NormalizedUserName =kh.UserName,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = kh.PasswordHash

            });
            var cart = await _shoppingCartRepository.CreateCart(new GioHang()
            {
                Id= task.Id
            });

            return CreatedAtAction(nameof(CreateUser), new { id = task.Id }, task);
        }

    }
}
