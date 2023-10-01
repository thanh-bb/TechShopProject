using TechShop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using TechShop.Models.Dtos;


namespace TechShop.Web.Pages
{
    public class LoaiBase : ComponentBase
    {
        [Inject]
        public ICategoryService CategoryService { get; set; }

        //public IEnumerable<LoaiDto> Loais { get; set; }

        public List<LoaiDto> Loais;
        protected override async Task OnInitializedAsync()
        {
            Loais = await CategoryService.GetAll();
        }
    }
}
