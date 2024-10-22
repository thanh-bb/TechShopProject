﻿using TechShop.Models.Dtos;
using TechShop.Web.Pages;

namespace TechShop.Web.Services.Contracts
{
    public interface IProductService
    {
		Task <List<ProductDto>> GetProductList ( ProductListSearch productListSearch );

        Task<IEnumerable<ProductDto>> GetAll();

        Task<ProductDto> GetProductDetail(int id);

		//Task<IEnumerable<ProductDto>> GetItems();
		
		Task<IEnumerable<LoaiDto>> GetProductCategories();
		Task<IEnumerable<ProductDto>> GetItemsByCategory(string categoryId);
	
		Task<bool> CreateProduct (ProductCreate product);

		Task<bool> UpdateProduct (int id, ProductUpdate product);
	
		Task<bool> DeleteProduct (int id);
	}
}
