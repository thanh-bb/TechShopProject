﻿using Azure.Core;
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
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {

            try
            {
                var products = await _productRepository.GetAll();


                if (products == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = products.ConvertToDto();

                    return Ok(productDtos);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }


        //api/product?name=
        [HttpGet]
        [Route(nameof(ProductListSearch))]
        public async Task<IActionResult> GetList([FromQuery] ProductListSearch productListSearch)
        {

            var post = await _productRepository.GetList(productListSearch);
            return Ok(post);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetItems(int id)
        {
            var product = await _productRepository.GetItem(id);
            return Ok(product);

        }
        [HttpGet]
        [Route("/GetCategory/{id}")]
        public async Task<ActionResult<LoaiDto>> GetCategory(string id)
        {
            var category = await _productRepository.GetCategory(id);
            return Ok(category);
        }

        [HttpGet]
        [Route(nameof(GetProductCategories))]
        public async Task<ActionResult<IEnumerable<LoaiDto>>> GetProductCategories()
        {
            var productCategories = await _productRepository.GetCategories();

            var productCategoryDtos = productCategories.ConvertToDto();

            return Ok(productCategoryDtos);

        }


        [HttpGet]
        [Route("{categoryId}/GetItemsByCategory")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItemsByCategory(string categoryId)
        {

            var products = await _productRepository.GetItemsByCategory(categoryId);

            var productDtos = products.ConvertToDto();

            return Ok(productDtos);

        }




        [HttpPost]
        [Route(nameof(CreateProduct))]
        public async Task<IActionResult> CreateProduct([FromBody] ProductCreate product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
          
            var task = await _productRepository.Create(new SanPham()
            {
                TenSP = product.TenSP,
                MaLoai = product.MaLoai,
                MoTa = product.MoTa,
                Id = product.Id,
                GiaSP = product.GiaSP,
                SoLuong = product.SoLuong,
                NgayDang = DateTime.Now,
               Image = product.Image,
               MaTinhTrang = product.MaTinhTrang

            });
            return CreatedAtAction(nameof(CreateProduct), new {id = task.MaSP }, task);
        }

    }
}
