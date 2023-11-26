using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
	public class BangTin
	{

		[Key]
		public int MaBangTin { get; set; }

		//public string NoiDung { get; set; }

		//public DateTime NgayDang { get; set; }

		//public Guid? Id { get; set; }

		//[ForeignKey("Id")]
		//public KhachHang KhachHang { get; set; }

		//      public virtual SanPham SanPham { get; set; }

		//      public string? MaNV { get; set; }

		//[ForeignKey("MaNV")]
		//public NhanVien NhanVien { get; set; }

		//public string? MaTT_BT { get; set; }

		//[ForeignKey("MaTT_BT")]
		//public TrangThaiDuyet TrangThaiBT { get; set; }
	}
}
