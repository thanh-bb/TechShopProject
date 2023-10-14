using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string TenKH { get; set; }
        public DateTime NgaySinh { get; set; }
        public Boolean GioiTinh { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }

    }
}
