using TechShop.API.Entities;
using TechShop.Models.Dtos;

namespace ShopOnline.Api.Extensions
{
	public static class DtoConversions
	{
		public static IEnumerable<LoaiDto> ConvertToDto(this IEnumerable<LoaiSP> productCategories)
		{
			return (from productCategory in productCategories
					select new LoaiDto
					{
						MaLoai = productCategory.MaLoai,
						TenLoai = productCategory.TenLoai

					}).ToList();
		}
		public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<SanPham> products)
		{
			return (from product in products
					select new ProductDto
					{
						MaSP = product.MaSP,
						TenSP = product.TenSP,
						MoTa = product.MoTa,
						GiaSP = product.GiaSP,
						SoLuong = product.SoLuong,
						MaLoai = product.LoaiSP.MaLoai,
						TenLoai= product.LoaiSP.TenLoai,
						NgDang=product.NgDang,
						Image = product.Image,
						MaTinhTrang = product.MaTinhTrang
					

					}).ToList();

		}
		public static ProductDto ConvertToDto(this SanPham product)

		{
			return new ProductDto
			{
				MaSP = product.MaSP,
				TenSP = product.TenSP,
				MoTa = product.MoTa,
				GiaSP = product.GiaSP,
				SoLuong = product.SoLuong,
				MaLoai = product.LoaiSP.MaLoai,
                TenLoai = product.LoaiSP.TenLoai,
                NgDang = product.NgDang,
                Image = product.Image,
                MaTinhTrang = product.MaTinhTrang
            };

		}

		

	}
}