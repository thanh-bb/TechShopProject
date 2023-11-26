using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    public class QuanTriVien
    {
        [Key]
        public int MaQTV { get; set; }


        [MaxLength(100)]
        public string TenQTV { get; set; }

        [MaxLength(150)]
        public string EmailQTV { get; set; }


        [MaxLength(500)]
        public string DiaChiQTV { get; set; }


        [MaxLength(10)]
        public string DienThoaiQTV { get; set; }

        [MaxLength(20)]
        public string HashPasswdQTV { get; set; }

        public Guid Id { get; set; }

        [ForeignKey("Id")] 
        public Quyen Quyen { get; set; }        

    }
}
