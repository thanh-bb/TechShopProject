using System.Net.Http.Json;
using TechShop.Models.Dtos;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Services
{
    public class TinhTrangService : ITinhTrangService
    {
        public HttpClient _httpClient;
        public TinhTrangService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public async Task<List<TinhTrangDto>> GetTinhTrangs()
        {
            var kq = await _httpClient.GetFromJsonAsync<List<TinhTrangDto>>(requestUri: "/api/TinhTrang");
            return kq;
        }
    }
}
