using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
    public class BillCreate
    {
         public int MaHD { get; set; }

        public Guid Id { get; set; }        

        public DateTime NgayDat { get; set; }

        public string? MaTT { get; set; }

        public long? TongTien { get; set; }

    }
}
