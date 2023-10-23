using TechShop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using TechShop.Models.Dtos;


namespace TechShop.Web.Pages
{
    public class LoaiBase : ComponentBase
    {
        [Inject]
        public IUserService UserService { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        [Inject]
        public ICategoryService CategoryService { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        //public IEnumerable<LoaiDto> Loais { get; set; }

        public List<LoaiDto> Loais;
       
        public IEnumerable<ProductDto> Products { get; set; }

        public List<UserDto> Users;
        protected override async Task OnInitializedAsync()
        {
            Loais = await CategoryService.GetAll();
            Products = await ProductService.GetAll();

            Users = await UserService.GetUsers();
            var shoppingCartItems = await ShoppingCartService.GetItems(Users.First().Id);
            var totalQty = shoppingCartItems.Sum(i => i.Qty);

            ShoppingCartService.RaiseEventOnShoppingCartChanged(totalQty);
        }
        protected IOrderedEnumerable<IGrouping<string, ProductDto>> GetGroupedProductsByCategory()
        {
            // cut từ file Products.razor , khúc hiển thị phân loại sản phẩm 
            return from product in Products
                   group product by product.MaLoai into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }

        // này là khúc lấy tên phân loại sản phẩm 
        protected string GetCategoryName(IGrouping<string, ProductDto> groupedProductDtos)
        {
            return groupedProductDtos.FirstOrDefault(p => p.MaLoai == groupedProductDtos.Key).TenLoai;
        }
    }
}
