using TechShop.Models.Dtos;

namespace TechShop.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAll();

        Task<ProductDto> GetProductDetail(string id);

		//Task<IEnumerable<ProductDto>> GetItems();
		
		Task<IEnumerable<LoaiDto>> GetProductCategories();
		Task<IEnumerable<ProductDto>> GetItemsByCategory(string categoryId);
	}
}
