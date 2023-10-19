using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
    public class LoginRequest
    {
		[Required(ErrorMessage = "Hãy nhập username của bạn")]
		public string UserName {  get; set; }

		[Required(ErrorMessage = "Hãy nhập mật khẩu của bạn")]
		public string PasswordHash { get; set; }

        public Guid Id { get; set; }
    }
}
