using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using TechShop.Models.Dtos;
using TechShop.Web.Services;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Pages
{
    public partial class SearchFormProduct
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public ITinhTrangService TinhTrangService { get; set; }

        [Inject]
        private ICategoryService CategoryService { get; set; }


        private List<ProductDto> Products;

        private List<ProductDto> ProductList;

        private List<LoaiDto> Loais;

        private List<TinhTrangDto> TinhTrangs;

        private ProductListSearch productListSearch = new ProductListSearch();

        protected override async Task OnInitializedAsync()
        {
            // Products = await ProductService.GetProductList(productListSearch);
            Products = await ProductService.GetProductList(productListSearch);
            TinhTrangs = await TinhTrangService.GetTinhTrangs();
            Loais = await CategoryService.GetAll();
        }

        public async Task SearchForm(EditContext context)
        {
            Products = await ProductService.GetProductList(productListSearch);
            
        }
    }
    // search form
   

}
