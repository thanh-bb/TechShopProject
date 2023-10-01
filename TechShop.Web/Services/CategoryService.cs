using System.Net.Http.Json;
using TechShop.Models.Dtos;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Services
{
    public class CategoryService : ICategoryService
    {
        public HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public async Task<List<LoaiDto>> GetAll()
        {
            var kq = await _httpClient.GetFromJsonAsync<List<LoaiDto>>(requestUri: "/api/Loai");
            return kq;


        }

		public async Task<LoaiDto> GetLoaiDetail(string id)
		{
			/*var kq = await _httpClient.GetFromJsonAsync<LoaiDto>(requestUri: "/api/Loai/{id}");
            return kq;*/
            var result = await _httpClient.GetFromJsonAsync<LoaiDto>($"/api/Loai/{id}");
            return result;


        }

      
    }
}
