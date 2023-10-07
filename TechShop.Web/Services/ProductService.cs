using System.Net.Http.Json;
using TechShop.Models.Dtos;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Services
{
    public class ProductService : IProductService
    {
        public HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public async Task<List<ProductDto>> GetAll()
        {
            var kq = await _httpClient.GetFromJsonAsync<List<ProductDto>>(requestUri: "/api/Product");
            return kq;
        }

      

        public async Task<ProductDto> GetProductDetail(string id)
        {
			var result = await _httpClient.GetFromJsonAsync<ProductDto>($"/api/Product/{id}");
			return result;
		}

     
    }
}
