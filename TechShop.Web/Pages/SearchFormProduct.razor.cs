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
        public IUserService UserService { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

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

        public List<UserDto> Users;

        private ProductListSearch productListSearch = new ProductListSearch();

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetProductList(productListSearch);
            TinhTrangs = await TinhTrangService.GetTinhTrangs();
            Loais = await CategoryService.GetAll();

            Users = await UserService.GetUsers();
            var shoppingCartItems = await ShoppingCartService.GetItems(Users.First().Id);
            var totalQty = shoppingCartItems.Sum(i => i.Qty);

            ShoppingCartService.RaiseEventOnShoppingCartChanged(totalQty);
        
        }

        public async Task SearchForm(EditContext context)
        {
            Products = await ProductService.GetProductList(productListSearch);
            
        }
    }
    // search form
   

}
