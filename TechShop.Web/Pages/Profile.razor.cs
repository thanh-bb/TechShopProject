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

		protected override async Task OnInitializedAsync()
		{

			Users = await UserService.GetUsers();
		}

		private async Task GetUser()
		{

			var user = await UserService.GetUsers();

		}

	}
}
