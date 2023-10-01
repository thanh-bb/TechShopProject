using System.ComponentModel.DataAnnotations;

namespace TechShop.API.Entities
{
	public class TrangThaiBT
	{
		[Key]
		public string MaTT_BT { get; set; }

		public string TenTT_BT { get; set; }

		public virtual ICollection<BangTin> BangTins { get; set; }
	}
}
