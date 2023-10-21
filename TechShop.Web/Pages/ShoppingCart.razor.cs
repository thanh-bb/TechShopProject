using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using TechShop.Models.Dtos;
using TechShop.Web.Services;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Pages
{
    public partial class ShoppingCart : ComponentBase
    {
        [Inject]
        public IUserService UserService { get; set; }

        [Inject]
        public IJSRuntime Js { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        public List<CartItemDto> ShoppingCartItems { get; set; }
        
        public List<UserDto> Users;
        public string ErrorMessage { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                Users = await UserService.GetUsers();
                ShoppingCartItems = await ShoppingCartService.GetItems(Users.First().Id);
               
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }

        protected async Task DeleteCartItem_Click(int id)
        {
            var cartItemDto = await ShoppingCartService.DeleteItem(id);

            /*await*/ RemoveCartItem(id);
            //CartChanged();

        }
        private CartItemDto GetCartItem(int id)
        {
            return ShoppingCartItems.FirstOrDefault(i => i.Id == id);
        }
        private async Task RemoveCartItem(int id)
        {
            var cartItemDto = GetCartItem(id);

            ShoppingCartItems.Remove(cartItemDto);

            //await ManageCartItemsLocalStorageService.SaveCollection(ShoppingCartItems);

        }
    }
}
