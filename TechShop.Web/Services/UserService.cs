using System.Net.Http.Json;
using TechShop.Models.Dtos;
using TechShop.Web.Pages;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Services
{
    public class UserService : IUserService
    {
        public HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<bool> CreateProduct(UserCreate user)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/User/CreateUser", user);
            return result.IsSuccessStatusCode;
        }

        public async Task<List<CartDto>> GetCartOfUser()
        {
            return await _httpClient.GetFromJsonAsync<List<CartDto>>(requestUri: "/api/User/GetCartOfUser");
        }

        public async Task<List<ProductDto>> GetProductOfUser()
        {
            return await _httpClient.GetFromJsonAsync<List<ProductDto>>(requestUri: "/api/User/GetProductOfUser");
        }
        public async Task<List<UserDto>> GetUsers()
        {

            return await _httpClient.GetFromJsonAsync<List<UserDto>>(requestUri: "/api/User/me");

        }
    }


}
