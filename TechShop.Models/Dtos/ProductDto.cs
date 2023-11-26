using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Models.Enums;

namespace TechShop.Models.Dtos
{
    public class ProductDto
    {
        public int MaSP { get; set; }

        public string? TenSP { get; set; }

        public long GiaSP { get; set; }

        public int SoLuong { get; set; }

        public string? MoTa { get; set; }

        public DateTime NgayDang { get; set; }
        public string? LoaiSP { get; set; }

        public string MaLoai { get; set; }

        public string? TenLoai { get; set; }

        public Guid Id {  get; set; }

        public string ImageURL {  get; set; }

        public string MaTinhTrang { get; set; }

        public string TenNguoiDang { get; set; }

        public Status Status { get; set; }

    }
}
