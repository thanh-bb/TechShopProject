using TechShop.Models.Dtos;

namespace TechShop.Web.Services.Contracts
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUsers();
    }
}
