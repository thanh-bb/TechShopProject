using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
    public class UserCreate
    {

        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenKH { get; set; }

        //[Required]
        //public DateTime NgaySinh { get; set; }

        //public Boolean GioiTinh { get; set; }

        public string? Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string? DienThoai { get; set; }

        [Required]
        [MaxLength(100)]
        public string? PasswordHash { get; set; }

        [Required]
        public string? UserName { get; set; }





    }
}
