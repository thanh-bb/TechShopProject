using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.Api.Extensions;
using TechShop.API.Entities;
using TechShop.API.Repositories;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;


namespace TechShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinhTrangController : ControllerBase
    {

        private readonly ITinhTrangRepository _tinhTrangRepository;

        public TinhTrangController(ITinhTrangRepository tinhTrangRepository)
        {
            _tinhTrangRepository = tinhTrangRepository;

        }
     

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var post = await _tinhTrangRepository.GetTinhTrangList();
            return Ok(post);

        }

    }
}
