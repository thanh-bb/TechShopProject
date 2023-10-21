using System.Net.Http;
using System.Net.Http.Json;
using TechShop.Models.Dtos;
using TechShop.Web.Pages;
using TechShop.Web.Services.Contracts;

namespace TechShop.Web.Services
{
	public class ShoppingCartService : IShoppingCartService
	{

		private readonly HttpClient _httpClient;

		public event Action<int> OnShoppingCartChanged;

		public ShoppingCartService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<CartItemDto> AddItem(CartItemToAddDto cartItemToAddDto)
		{
			try
			{
				var response = await _httpClient.PostAsJsonAsync<CartItemToAddDto>("api/ShoppingCart", cartItemToAddDto);

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
					{
						return default(CartItemDto);
					}

					return await response.Content.ReadFromJsonAsync<CartItemDto>();

				}
				else
				{
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http status:{response.StatusCode} Message -{message}");
				}

			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<List<CartItemDto>> GetItems(Guid userId)
		{
			try
			{
				var response = await _httpClient.GetAsync($"api/ShoppingCart/{userId}/GetItems");

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<CartItemDto>().ToList();
					}
					return await response.Content.ReadFromJsonAsync<List<CartItemDto>>();
				}
				else
				{
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http status code: {response.StatusCode} Message: {message}");
				}

			}
			catch (Exception)
			{

				throw;
			}
		}

        public async Task<bool> CreateCart(CartCreate cart)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/ShoppingCart/CreateCart", cart);
            return result.IsSuccessStatusCode;
        }

        public async Task<CartItemDto> DeleteItem(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"api/ShoppingCart/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CartItemDto>();
                }
                return default(CartItemDto);
            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }
    }
}
