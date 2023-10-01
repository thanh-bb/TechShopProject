using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
	public class BangTin
	{

		[Key]
		public string MaBangTin { get; set; }

		public string NoiDung { get; set; }

		public DateTime NgayDang { get; set; }

		public Guid? MaKH { get; set; }

		[ForeignKey("Id")]
		public KhachHang KhachHang { get; set; }

		public string? MaSP { get; set; }

		[ForeignKey("MaSP")]
		public SanPham SanPham { get; set; }

		public string? MaNV { get; set; }

		[ForeignKey("MaNV")]
		public NhanVien NhanVien { get; set; }

		public string? MaTT_BT { get; set; }

		[ForeignKey("MaTT_BT")]
		public TrangThaiBT TrangThaiBT { get; set; }
	}
}
