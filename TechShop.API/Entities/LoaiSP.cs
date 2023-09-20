﻿using System.ComponentModel.DataAnnotations;

namespace TechShop.API.Entities
{
    public class LoaiSP
    {
        [Key]
        public string MaLoai {  get; set; }

        public string TenLoai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }

    }
}
