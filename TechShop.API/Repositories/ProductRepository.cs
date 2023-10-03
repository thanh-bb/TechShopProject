using System.Data.Entity;
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
        public async Task<IEnumerable<SanPham>> GetItems()
        {
            return await _context.SanPham.ToListAsync();
        }

        public  List<SanPham> GetAll()
        {
            var sp = _context.SanPham.Select(s => new SanPham
            {
                MaSP = s.MaSP,
                TenSP = s.TenSP,
                GiaSP = s.GiaSP,
                SoLuong = s.SoLuong,
                MoTa = s.MoTa,
            });
            return sp.ToList();
        }

   
        public SanPham Add(SanPham sp)
        {
            var spnew = new ProductDto
            {
                TenSP = sp.TenSP
            };
            _context.Add(spnew);
            _context.SaveChanges();
            return new SanPham
            {
                MaSP = spnew.MaSP,
                TenSP = spnew.TenSP

            };
        }

        public void Delete(SanPham sp)
        {
            throw new NotImplementedException();
        }

      

        public SanPham GetById(string id)
        {
            throw new NotImplementedException();
        }

      
        public void Update(SanPham sp)
        {
            throw new NotImplementedException();
        }

        
    }
}
