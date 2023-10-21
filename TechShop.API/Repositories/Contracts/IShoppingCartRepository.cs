using TechShop.API.Entities;
using TechShop.Models.Dtos;

namespace TechShop.API.Repositories.Contracts
{
	public interface IShoppingCartRepository
	{
		Task<ChiTietGioHang> AddItem(CartItemToAddDto cartItemToAddDto);
		Task<ChiTietGioHang> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto);
		Task<ChiTietGioHang> DeleteItem(int id);
		Task<ChiTietGioHang> GetItem(int id);
		Task<IEnumerable<ChiTietGioHang>> GetItems(Guid userId);

        Task<GioHang> CreateCart(GioHang gioHang);

       
    }
}
