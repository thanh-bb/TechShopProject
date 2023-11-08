
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using TechShop.Models.Dtos;
using TechShop.Web.Services.Contracts;
using TechShop.Web;
using TechShop.Web.Services;

namespace TechShop.Web.Pages
{
    public class CheckoutBase : ComponentBase
    {
        [Inject]
        public IUserService UserService { get; set; }

        public List<UserDto> Users;

        [Inject]
        public IJSRuntime Js { get; set; }

        protected IEnumerable<CartItemDto> ShoppingCartItems { get; set; }

        protected int TotalQty { get; set; }

        protected string PaymentDescription { get; set; }

        protected decimal PaymentAmount { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        [Inject]
        public IManageCartItemsLocalStorageService ManageCartItemsLocalStorageService { get; set; }

        protected string DisplayButtons { get; set; } = "block";

        protected override async Task OnInitializedAsync()
        {
            try
            {
                //ShoppingCartItems = await ManageCartItemsLocalStorageService.GetCollection();
                Users = await UserService.GetUsers();
                ShoppingCartItems = await ShoppingCartService.GetItems(Users.First().Id);

                if (ShoppingCartItems != null && ShoppingCartItems.Count() > 0)
                {
                    Guid orderGuid = Guid.NewGuid();

                    PaymentAmount = ShoppingCartItems.Sum(p => p.TotalPrice);
                    TotalQty = ShoppingCartItems.Sum(p => p.Qty);
                    PaymentDescription = $"O_{Users.First().Id}_{orderGuid}";

                }
                else
                {
                    DisplayButtons = "none";

                }

            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            try
            {
                if (firstRender)
                {
                    await Js.InvokeVoidAsync("initPayPalButton");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}