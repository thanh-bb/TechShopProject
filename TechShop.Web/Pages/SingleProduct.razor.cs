using Microsoft.AspNetCore.Components;
using TechShop.Models.Dtos;
using TechShop.Web.Services;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Pages
{
    public partial class SingleProduct
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IUserService UserService { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public IShoppingCartService shoppingCartService { get; set; }

        [Inject]

        public NavigationManager NavigationManager { get; set; }

        public List<UserDto> Users;

        public List<CartDto> Carts;
        public ProductDto Products { get; set; }

        public string ErrorMessage { get; set; }

        private List<CartItemDto> ShoppingCartItems { get; set; }

        protected override async Task OnInitializedAsync()
        {

            try
            {
                //Users = await UserService.GetUsers();
                Carts = await UserService.GetCartOfUser();
                Products = await ProductService.GetProductDetail(Id);

            }

            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        protected async Task AddToCart_Click(CartItemToAddDto cartItemToAddDto)
        {
            try
            {
                var cartItemDto = await shoppingCartService.AddItem(cartItemToAddDto);
                NavigationManager.NavigateTo("/ShoppingCart");

            }
            catch (Exception)
            {

                //Log Exception
            }
        }
    }
}
