using TechShop.API.Entities;

namespace TechShop.API.Repositories.Contracts
{
    public interface IUserRepository
    {

        Task<IEnumerable<KhachHang>> GetUserByUserId(Guid userId);

        Task<IEnumerable<SanPham>> GetProductByUserId(Guid userId);

        Task<IEnumerable<GioHang>> GetCartByUserId(Guid userId);
    }
}
