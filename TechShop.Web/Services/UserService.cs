using System.Net.Http.Json;
using TechShop.Models.Dtos;
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
        public async Task<List<UserDto>> GetUsers()
        {

			return await _httpClient.GetFromJsonAsync<List<UserDto>>(requestUri: "/api/User/me");

        }
    }


}
