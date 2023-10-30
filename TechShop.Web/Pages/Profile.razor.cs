using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using TechShop.Models.Dtos;
using TechShop.Web.Components;
using TechShop.Web.Services;
using TechShop.Web.Services.Contracts;


namespace TechShop.Web.Pages
{
    public partial class Profile
    {
        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        [Inject]
        public IUserService UserService { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        public List<UserDto> Users;

        public List<ProductDto> ProductOfUser;

        public List<LoaiDto> Loais;

        //confirm delete
        protected Confirmation DeleteConfirmation { get; set; }

        private int DeleteId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Loais = await CategoryService.GetAll();
            Users = await UserService.GetUsers();
            ProductOfUser = await UserService.GetProductOfUser();

            Users = await UserService.GetUsers();
            var shoppingCartItems = await ShoppingCartService.GetItems(Users.First().Id);
            var totalQty = shoppingCartItems.Sum(i => i.Qty);
            ShoppingCartService.RaiseEventOnShoppingCartChanged(totalQty);
        }

        private async Task GetUser()
        {

            var user = await UserService.GetUsers();

        }

        //confirmation delete
        public async Task OnDeleteProduct(int deleteId)
        {
            DeleteId = deleteId;
            DeleteConfirmation.Show();
        }

        public async Task OnConfirmDeleteProduct(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await ProductService.DeleteProduct(DeleteId);
                ProductOfUser = await UserService.GetProductOfUser();
            }
        }
    }
}
