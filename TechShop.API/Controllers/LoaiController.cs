using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechShop.API.Entities;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;

namespace TechShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiController : ControllerBase
    {
        private readonly ILoaiRepository _loaiRepository;

        public LoaiController(ILoaiRepository loaiRepository)
        {
            _loaiRepository = loaiRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var post = await _loaiRepository.GetItems();
            return Ok(post);

        }
        //api/posts/id....
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            var posts = await _loaiRepository.GetById(id);
            if (posts == null)
            {
                return NotFound($"{id} is not found");
            }
            return Ok(new LoaiDto()
            {
                MaLoai= posts.MaLoai,   
                TenLoai= posts.TenLoai
            });

        
        }

        /* [HttpGet]
         public IActionResult GetAll()
         {
             try
             {
                 return Ok(_loaiRepository.GetAll());
             }
             catch
             {
                 return StatusCode(StatusCodes.Status500InternalServerError);
             }
         }
        */
        [HttpPost]
        public IActionResult Add(LoaiSP loai)
        {
            try
            {

                return Ok(_loaiRepository.Add(loai));

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


     
    }
}
