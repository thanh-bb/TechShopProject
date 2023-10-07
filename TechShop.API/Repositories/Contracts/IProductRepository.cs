using TechShop.API.Entities;

namespace TechShop.API.Repositories.Contracts
{
    public interface IProductRepository
    {
       // Task<IEnumerable<SanPham>> GetItems();

       Task<IEnumerable<SanPham>> GetAll();
		Task<SanPham> GetItem(string id);
		SanPham GetById(string id);
        SanPham Add(SanPham sp);
        void Update(SanPham sp);

        void Delete(SanPham sp);
    }
}
