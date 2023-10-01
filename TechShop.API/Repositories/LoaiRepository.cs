using Microsoft.EntityFrameworkCore;
using TechShop.API.Data;
using TechShop.API.Entities;
using TechShop.API.Repositories.Contracts;
using TechShop.Models.Dtos;

namespace TechShop.API.Repositories
{
    public class LoaiRepository : ILoaiRepository
    {
        private readonly TechShopDbContext _context;

        public LoaiRepository(TechShopDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<LoaiSP>> GetItems()
        {
           return await _context.LoaiSP.ToListAsync();

           
        }

        public async Task<List<LoaiSP>> GetAll()
        {
            /*var sp = _context.LoaiSP.Select(s => new LoaiSP
            {
                MaLoai = s.MaLoai,
                TenLoai = s.TenLoai
            });
            return sp.ToList(); */
            var loai = await _context.LoaiSP.ToListAsync();
            return loai;
        }

       
        public async Task<LoaiSP> GetById(string id)
        {
            return await _context.LoaiSP.FirstAsync(p => p.MaLoai == id);
        }

        public LoaiSP Add(LoaiSP loai)
        {
            var spnew = new LoaiDto
            {
                TenLoai = loai.TenLoai
            };
            _context.Add(spnew);
            _context.SaveChanges();
            return new LoaiSP
            {
                MaLoai = spnew.MaLoai,
                TenLoai = spnew.TenLoai
             
            };
        }

        public void Update(LoaiSP sp)
        {
            throw new NotImplementedException();
        }

        public void Delete(LoaiSP sp)
        {
            throw new NotImplementedException();
        }

        List<LoaiSP> ILoaiRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
