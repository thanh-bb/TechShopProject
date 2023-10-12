using TechShop.Models.Dtos;

namespace TechShop.Web.Services.Contracts
{
    public interface ITinhTrangService
    {
        Task<List<TinhTrangDto>> GetTinhTrangs();
    }
}
