using Microsoft.Extensions.Hosting;
using TechShop.API.Entities;
using TechShop.Models.Dtos;

namespace TechShop.API.Repositories.Contracts
{
    public interface ILoaiRepository
    {
        Task<IEnumerable<LoaiSP>> GetItems();
        List<LoaiSP> GetAll();
        Task<LoaiSP> GetById(string id);
        
        LoaiSP Add(LoaiSP sp);
        void Update (LoaiSP sp);

        void Delete (LoaiSP sp);
       
    }
}
