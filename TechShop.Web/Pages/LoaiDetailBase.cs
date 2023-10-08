using Microsoft.AspNetCore.Components;
using TechShop.Models.Dtos;
using TechShop.Web.Services;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Pages
{
	public class LoaiDetailBase : ComponentBase
	{
		[Inject]
		public ICategoryService CategoryService { get; set; }

		[Parameter]
		public string MaLoai { get; set; }
		[Parameter]
		public string Tenloai { get; set; }

		public LoaiDto LoaiDetails { get; set; }


		protected async override Task OnInitializedAsync()
		{

			LoaiDetails = await CategoryService.GetLoaiDetail(MaLoai);
		}
	
}
}
