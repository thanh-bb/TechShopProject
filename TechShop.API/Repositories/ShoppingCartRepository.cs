using Microsoft.EntityFrameworkCore;
using TechShop.API.Data;
using TechShop.API.Entities;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;

namespace TechShop.API.Repositories
{
	public class ShoppingCartRepository : IShoppingCartRepository
	{
		private readonly TechShopDbContext _context;

		public ShoppingCartRepository(TechShopDbContext context)
		{
			_context = context;
		}

		private async Task<bool> CartItemExists(int cartId, int productId)
		{
			return await _context.ChiTietGioHang.AnyAsync(c => c.ID_Cart == cartId &&
														  c.MaSP == productId);

		}

		public async Task<ChiTietGioHang> AddItem(CartItemToAddDto cartItemToAddDto)
		{
			if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
			{
				var item = await (from product in _context.SanPham
								  where product.MaSP == cartItemToAddDto.ProductId
								  select new ChiTietGioHang
								  {
									  ID_Cart = cartItemToAddDto.CartId,
									  MaSP = product.MaSP,
									  SoLuong = cartItemToAddDto.Qty
								  }).SingleOrDefaultAsync();

				if (item != null)
				{
					var result = await _context.ChiTietGioHang.AddAsync(item);
					await _context.SaveChangesAsync();
					return result.Entity;
				}
			}
			

			return null;
		}

		public async Task<ChiTietGioHang> DeleteItem(int id)
		{
            var item = await _context.ChiTietGioHang.FindAsync(id);

            if (item != null)
            {
               _context.ChiTietGioHang.Remove(item);
                await _context.SaveChangesAsync();
            }

            return item;
        }

		public async Task<ChiTietGioHang> GetItem(int id)
		{
			return await(from cart in _context.GioHang
						 join cartItem in _context.ChiTietGioHang
						 on cart.ID_Cart equals cartItem.ID_Cart
						 where cartItem.Id_CTCart == id
						 select new ChiTietGioHang
						 {
							 Id_CTCart = cartItem.Id_CTCart,
							 MaSP = cartItem.MaSP,
							 SoLuong = cartItem.SoLuong,
							 ID_Cart = cartItem.ID_Cart
						 })
						 .SingleOrDefaultAsync();
		}

		public async Task<IEnumerable<ChiTietGioHang>> GetItems(Guid userId)
		{
			return await(from cart in _context.GioHang
						 join cartItem in _context.ChiTietGioHang
						 on cart.ID_Cart equals cartItem.ID_Cart
						 where cart.Id == userId
						 select new ChiTietGioHang
						 {
							 Id_CTCart = cartItem.Id_CTCart,
							 MaSP = cartItem.MaSP,
							 SoLuong = cartItem.SoLuong,
							 ID_Cart = cartItem.ID_Cart
						 }).ToListAsync();
		}

		public async Task<ChiTietGioHang> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
		{
            var item = await _context.ChiTietGioHang.FindAsync(id);

            if (item != null)
            {
                item.SoLuong = cartItemQtyUpdateDto.Qty;
                await _context.SaveChangesAsync();
                return item;
            }

            return null;
        }

        public async Task<GioHang> CreateCart(GioHang gioHang)
        {
            await _context.GioHang.AddAsync(gioHang);
            await _context.SaveChangesAsync();
            return gioHang;
        }

        public async Task<DonHang> CreateBill(DonHang donhang)
        {
            await _context.DonHang.AddAsync(donhang);
            await _context.SaveChangesAsync();
            return donhang;
        }

     

        public async Task<ChiTietDonHang> CreateDetailsBill(ChiTietDonHang cthoadon)
        {
            await _context.ChiTietDonHang.AddAsync(cthoadon);
            await _context.SaveChangesAsync();
            return cthoadon;
        }
    }
}
