using TechShop.API.Entities;

namespace TechShop.API.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<SanPham>> GetItems();
        List<SanPham> GetAll();

        SanPham GetById(string id);
        SanPham Add(SanPham sp);
        void Update(SanPham sp);

        void Delete(SanPham sp);
    }
}
