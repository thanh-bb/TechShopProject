using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
    public class DetailsBillCreate
    {
        public int MaHD { get; set; }
     
        public int MaSP { get; set; }

        public long? GiaBan { get; set; }
    }
}
