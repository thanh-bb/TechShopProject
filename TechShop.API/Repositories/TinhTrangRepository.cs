using Microsoft.EntityFrameworkCore;
using TechShop.API.Data;
using TechShop.API.Entities;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;


namespace TechShop.API.Repositories
{
    public class TinhTrangRepository : ITinhTrangRepository
    {
        private readonly TechShopDbContext _context;

        public TinhTrangRepository(TechShopDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TinhTrangHang>> GetTinhTrangList()
        {
            var ttList = await _context.TinhTrangHang.ToListAsync();
            return ttList;
        }
    

    }
}
