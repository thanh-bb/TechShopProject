using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
	public class CartItemToAddDto
	{
        public int Id_CTCart { get; set; }
        public int CartId { get; set; }
		public int ProductId { get; set; }
		public int Qty { get; set; }

		public long Price { get; set; }
	}
}
