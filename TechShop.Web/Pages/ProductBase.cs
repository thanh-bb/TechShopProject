﻿using Microsoft.AspNetCore.Components;
using TechShop.Models.Dtos;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Pages
{
    public class ProductBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public List<ProductDto> Products;
        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetAll();
        }
    }
}