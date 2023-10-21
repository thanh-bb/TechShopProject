using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    public class HinhAnh
    {
        public int Id { get; set; }
       
        public string ImagePath { get; set; }

        public bool IsDefault { get; set; }

        public DateTime DateCreated { get; set; }

        public int SortOrder { get; set; }

        public int FileSize { get; set; }

        public int? MaSP { get; set; }

        [ForeignKey("MaSP")]
        public SanPham SanPham { get; set; }
    }
}
