using TechShop.Models.Dtos;

namespace TechShop.Web.Services.Contracts
{
    public interface IAuthService
    {
        Task<LoginResponse>Login (LoginRequest loginRequest);
        Task Logout();
    }
}
