using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
    public class ProductDto
    {
        public string MaSP { get; set; }

        public string TenSP { get; set; }

        public long GiaSP { get; set; }

        public int SoLuong { get; set; }

        public string MoTa { get; set; }


		public string MaLoai { get; set; }






	}
}
