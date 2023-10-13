using TechShop.Models.Dtos;
using TechShop.Web.Pages;

namespace TechShop.Web.Services.Contracts
{
    public interface IProductService
    {
		Task <List<ProductDto>> GetProductList ( ProductListSearch productListSearch );
       
		Task<List<ProductDto>> GetAll();

        Task<ProductDto> GetProductDetail(string id);

		//Task<IEnumerable<ProductDto>> GetItems();
		
		Task<IEnumerable<LoaiDto>> GetProductCategories();
		Task<IEnumerable<ProductDto>> GetItemsByCategory(string categoryId);
	}
}
