using TechShop.API.Entities;
using TechShop.Models.Dtos;

namespace TechShop.API.Repositories.Contracts
{
    public interface IProductRepository
    {

        Task<IEnumerable<SanPham>> GetList(ProductListSearch productListSearch);

        Task<IEnumerable<SanPham>> GetAll();

        Task<SanPham> GetItem(int id);

        Task<IEnumerable<LoaiSP>> GetCategories();


        Task<LoaiSP> GetCategory(string id);


        Task<IEnumerable<SanPham>> GetItemsByCategory(string id);

        Task<SanPham> Create(SanPham sanpham);

        Task<SanPham> Update(SanPham sanpham);



    }
}
