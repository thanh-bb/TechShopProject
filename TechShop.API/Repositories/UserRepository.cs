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


		public async Task<IEnumerable<KhachHang>> GetUserByUserId(Guid userId)
		{
			var query = _context.KhachHang.Where(x => x.Id == userId).AsQueryable();

			return await query.ToListAsync();

		}
	}
}
