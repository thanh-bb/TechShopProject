using System.Net.Http;
using System.Net.Http.Json;
using TechShop.Models.Dtos;
using TechShop.Web.Pages;
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

		public async Task<IEnumerable<ProductDto>> GetItemsByCategory(string categoryId)
		{
			try
			{
				var response = await _httpClient.GetAsync($"api/Product/{categoryId}/GetItemsByCategory");

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<ProductDto>();
					}
					return await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>();
				}
				else
				{
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http Status Code - {response.StatusCode} Message - {message}");
				}
			}
			catch (Exception)
			{
				//Log exception
				throw;
			}
		}

		public async Task<IEnumerable<LoaiDto>> GetProductCategories()
		{
			try
			{
				var response = await _httpClient.GetAsync("api/Product/GetProductCategories");

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<LoaiDto>();
					}
					return await response.Content.ReadFromJsonAsync<IEnumerable<LoaiDto>>();
				}
				else
				{
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http Status Code - {response.StatusCode} Message - {message}");
				}
			}
			catch (Exception)
			{
				//Log exception
				throw;
			}
		}




		public async Task<ProductDto> GetProductDetail(string id)
		{
			var result = await _httpClient.GetFromJsonAsync<ProductDto>($"/api/Product/{id}");
			return result;
		}

        public async Task<List<ProductDto>> GetProductList(ProductListSearch productListSearch)
        {
      
            string url = $"/api/Product/ProductListSearch?TenSP={productListSearch.TenSP}&LoaiSP={productListSearch.LoaiSP}&MaTinhTrang={productListSearch.MaTinhTrang}";
            var kq = await _httpClient.GetFromJsonAsync<List<ProductDto>>(url);
            return kq;
        }
    }

}

