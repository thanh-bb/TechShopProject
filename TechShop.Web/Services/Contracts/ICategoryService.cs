using TechShop.Models.Dtos;

namespace TechShop.Web.Services.Contracts
{
    public interface ICategoryService
    {
        Task<List<LoaiDto>> GetAll();

        Task<LoaiDto> GetLoaiDetail(string id);

    }
}
