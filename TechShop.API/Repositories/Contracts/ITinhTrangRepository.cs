using TechShop.API.Entities;
using TechShop.Models.Dtos;

namespace TechShop.API.Repositories.Contracts
{
    public interface ITinhTrangRepository
    {
        Task<IEnumerable<TinhTrangHang>> GetTinhTrangList();
        
    }
}
