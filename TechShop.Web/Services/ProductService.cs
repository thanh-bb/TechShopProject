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

    

        public async Task<bool> CreateProduct(ProductCreate product)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/Product/CreateProduct", product);
            return result.IsSuccessStatusCode;

        }
        public async Task<IEnumerable<ProductDto>> GetAll()
		{
            try
            {
                var response = await _httpClient.GetAsync("api/Product");

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
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }

            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
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




		public async Task<ProductDto> GetProductDetail(int id)
		{
            try
            {
                var response = await _httpClient.GetAsync($"api/Product/{id}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(ProductDto);
                    }
                    return await response.Content.ReadFromJsonAsync<ProductDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {

                //Log exception
                throw;

            }
        }

        public async Task<List<ProductDto>> GetProductList(ProductListSearch productListSearch)
        {
      
            string url = $"/api/Product/ProductListSearch?TenSP={productListSearch.TenSP}&LoaiSP={productListSearch.LoaiSP}&Status={productListSearch.Status}";
            var kq = await _httpClient.GetFromJsonAsync<List<ProductDto>>(url);
            return kq;
        }
    }

}

