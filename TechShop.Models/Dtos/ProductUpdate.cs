using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Models.Enums;

namespace TechShop.Models.Dtos
{
    public class ProductUpdate
    {
        public string TenSP { get; set; }

        public Status Status { get; set; }
    }
}
