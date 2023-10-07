using TechShop.Models.Dtos;

namespace TechShop.Web.Services.Contracts
{
	public interface IManageProductsLocalStorageService
	{
		Task<IEnumerable<ProductDto>> GetCollection();
		Task RemoveCollection();
	}
}
