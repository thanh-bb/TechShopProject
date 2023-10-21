using Microsoft.EntityFrameworkCore;
using TechShop.API.Data;
using TechShop.API.Entities;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;
namespace TechShop.API.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly TechShopDbContext _context;
		public UserRepository(TechShopDbContext context)
		{
			_context = context;
		}

        public async Task<IEnumerable<SanPham>> GetProductByUserId(Guid userId)
        {
            var query = _context.SanPham.Where(x => x.Id == userId).AsQueryable();

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<KhachHang>> GetUserByUserId(Guid userId)
		{
			var query = _context.KhachHang.Where(x => x.Id == userId).AsQueryable();

			return await query.ToListAsync();

		}

        public async Task<IEnumerable<GioHang>> GetCartByUserId(Guid userId)
        {
            var query = _context.GioHang.Where(x => x.Id == userId).AsQueryable();

            return await query.ToListAsync();
        }
    }
}
