using Microsoft.EntityFrameworkCore;
using TechShop.API.Data;
using TechShop.API.Entities;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;
namespace TechShop.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TechShopDbContext _context;
        public ProductRepository(TechShopDbContext context)
        {
            _context = context;
        }
      
        public async Task<IEnumerable<SanPham>> GetAll()
        {
            var productList = await _context.SanPham.ToListAsync();
            return productList;
        }

		public async Task<IEnumerable<LoaiSP>> GetCategories()
		{
			var categories = await _context.LoaiSP.ToListAsync();

			return categories;
		}

		public async Task<LoaiSP> GetCategory(string id)
		{
			var category = await _context.LoaiSP.SingleOrDefaultAsync(c => c.MaLoai == id);
			return category;
		}

		public async Task<SanPham> GetItem(string id)
		{
			var product_item = await _context.SanPham.FindAsync(id);
			return product_item;
			//var product = await _context.SanPham
			//				   .Include(p => p.LoaiSP)
			//				   .SingleOrDefaultAsync(p => p.MaSP == id);
			//return product;
		}

		public async Task<IEnumerable<SanPham>> GetItemsByCategory(string id)
		{
			var products = await _context.SanPham
								  .Include(p => p.LoaiSP)
								  .Where(p => p.MaLoai == id).ToListAsync();
			return products;
		}

        public async Task<IEnumerable<SanPham>> GetList(ProductListSearch productListSearch)
        {
			var query = _context.SanPham.AsQueryable();

			if (!string.IsNullOrEmpty(productListSearch.TenSP))
			{
				query = query.Where(x => x.TenSP.Contains(productListSearch.TenSP));
			}

			if (!string.IsNullOrEmpty(productListSearch.LoaiSP))
			{
				query = query.Where(x => x.MaLoai == productListSearch.LoaiSP);
			}

			if (!string.IsNullOrEmpty(productListSearch.MaTinhTrang))
			{
				query = query.Where(x => x.MaTinhTrang == productListSearch.MaTinhTrang);
			}

			return await query.ToListAsync();
        }
    }
}
