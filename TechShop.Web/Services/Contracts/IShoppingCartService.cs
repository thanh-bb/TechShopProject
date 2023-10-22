using System.Net.Http;
using TechShop.Models.Dtos;

namespace TechShop.Web.Services.Contracts
{
	public interface IShoppingCartService
	{
		Task<List<CartItemDto>> GetItems(Guid userId);

		Task<CartItemDto> AddItem(CartItemToAddDto cartItemToAddDto);
        Task<bool> CreateCart(CartCreate cart);

		Task<CartItemDto> DeleteItem(int id);

        Task<CartItemDto> UpdateQty(CartItemQtyUpdateDto cartItemQtyUpdateDto);

        event Action<int> OnShoppingCartChanged;
        void RaiseEventOnShoppingCartChanged(int totalQty);

    }

}
