using System.ComponentModel.DataAnnotations;

namespace TechShop.API.Entities
{
	public class TrangThaiDuyet
	{
		[Key]
		public int MaTT_Duyet { get; set; }

        [MaxLength(100)]
        public string TenTT_Duyet { get; set; }

		public virtual ICollection<SanPham> SanPhams { get; set; }
	}
}
