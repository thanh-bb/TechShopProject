using TechShop.API.Entities;

namespace TechShop.API.Repositories.Contracts
{
    public interface IProductRepository
    {
       // Task<IEnumerable<SanPham>> GetItems();

       Task<IEnumerable<SanPham>> GetAll();
		Task<SanPham> GetItem(string id);
		//////////////////
		///


		
		Task<IEnumerable<LoaiSP>> GetCategories();
	
		Task<LoaiSP> GetCategory(string id);

		Task<IEnumerable<SanPham>> GetItemsByCategory(string id);


	}
}
