using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
	public class ChiTietGioHang
	{
		[Key]
		public int Id_CTCart { get; set; }

		public int ID_Cart { get; set; }

		[ForeignKey("ID_Cart")]
		public GioHang GioHang { get; set; }

		public int MaSP { get; set; }

		[ForeignKey("MaSP")]
		public SanPham SanPham { get; set; }

		public int SoLuong { get; set; }

		public long GiaBan { get; set; }
	}
}
