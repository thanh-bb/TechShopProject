﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Models.Enums;

namespace TechShop.Models.Dtos
{
    public class ProductListSearch
    {
        public string? TenSP { get; set; }

        public string? LoaiSP { get; set; }

        public Status? Status { get; set; }

    }
}
