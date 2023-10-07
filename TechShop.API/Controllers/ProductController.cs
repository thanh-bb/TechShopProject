using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechShop.API.Entities;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;

namespace TechShop.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepository _productRepository;

		public ProductController(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{

			var post = await _productRepository.GetAll();
			return Ok(post);
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

		[HttpGet("{id}")]
		public async Task<ActionResult<ProductDto>> GetItems(string id)
		{
			var product = await _productRepository.GetItem(id);
			return Ok(product);

		}



		[HttpPost]
		public IActionResult Add(SanPham sp)
		{
			try
			{

				return Ok(_productRepository.Add(sp));

			}
			catch
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

		}

	}
}
