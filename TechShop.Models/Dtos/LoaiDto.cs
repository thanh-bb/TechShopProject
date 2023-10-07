using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
    public class LoaiDto
    {
       
        public string MaLoai { get; set; }

        public string TenLoai { get; set; }

        public static implicit operator string(LoaiDto v)
        {
            throw new NotImplementedException();
        }
    }
}
