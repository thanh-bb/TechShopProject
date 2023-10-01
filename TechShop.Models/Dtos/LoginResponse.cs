using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
    public class LoginResponse
    {
        public bool Successful { get; set; }

        public string Error { get; set; }

        public string Token { get; set; }

    }
}
