using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using TechShop.Models.Dtos;
using TechShop.Web.Services;
using TechShop.Web.Services.Contracts;


namespace TechShop.Web.Pages
{
	public partial class Profile
	{
		[Inject]
		public IUserService UserService { get; set; }

		public List<UserDto> Users;

		public List<ProductDto> ProductOfUser;

        public List<LoaiDto> Loais;

        protected override async Task OnInitializedAsync()
		{
            Loais = await CategoryService.GetAll();
            Users = await UserService.GetUsers();
			ProductOfUser = await UserService.GetProductOfUser();
		}

		private async Task GetUser()
		{

			var user = await UserService.GetUsers();

		}

	}
}
