using Microsoft.AspNetCore.Components;
using TechShop.Models.Dtos;
using TechShop.Web.Services;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Pages
{
    public class SearchFormBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public ITinhTrangService TinhTrangService { get; set; }
      
        [Inject]
        public ICategoryService CategoryService { get; set; }
        
        
        public List<ProductDto> Products;

        public List<LoaiDto> Loais;

        public List<TinhTrangDto> TinhTrangs;

        public ProductListSearch productListSearch = new ProductListSearch();

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetAll();
            TinhTrangs = await TinhTrangService.GetTinhTrangs(); 
            Loais = await CategoryService.GetAll();
        }

        // search form
        public class ProductListSearch
        {
            public string TenSP { get; set; }

            public string LoaiSP { get; set; }

            public string TinhTrang { get; set; }
        }
    }
}
