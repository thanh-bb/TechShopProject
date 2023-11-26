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
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<SanPham> products
                                                           /* ,IEnumerable<LoaiSP> productCategories*/)
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
                        TenLoai = product.LoaiSP.TenLoai,
                        Id = product.Id,
                        ImageURL = product.ImageURL,
                        Status = product.Status,
                        NgayDang = product.NgayDang,
                        //MaLoai = product.MaLoai,
                        //TenLoai = productCategory.TenLoai


                    }).ToList();

        }
        public static ProductDto ConvertToDto(this SanPham product
                                               /*, LoaiSP productCategory*/)

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
                Id = product.Id,
                ImageURL = product.ImageURL,
                Status = product.Status,
                NgayDang = product.NgayDang
                //MaLoai = product.MaLoai,
                //TenLoai = productCategory.TenLoai
            };

        }

        public static IEnumerable<ProductDto> ConvertToDtoUser(this IEnumerable<SanPham> products,
                                                              IEnumerable<KhachHang> users
                                                           /* ,IEnumerable<LoaiSP> productCategories*/)
        {
            return (from product in products
                    join user in users
                    on product.Id equals user.Id
                    select new ProductDto
                    {
                        MaSP = product.MaSP,
                        TenSP = product.TenSP,
                        MoTa = product.MoTa,
                        GiaSP = product.GiaSP,
                        SoLuong = product.SoLuong,
                        MaLoai = product.LoaiSP.MaLoai,
                        TenLoai = product.LoaiSP.TenLoai,
                        Id = product.Id,
                        ImageURL = product.ImageURL,
                        Status = product.Status,
                        NgayDang = product.NgayDang,
                        //MaLoai = product.MaLoai,
                        //TenLoai = productCategory.TenLoai
                        TenNguoiDang = user.TenKH


                    }).ToList();

        }

		public static IEnumerable<CartItemDto> ConvertToDto(this IEnumerable<ChiTietGioHang> cartItems,
															IEnumerable<SanPham> products)
		{
			return (from cartItem in cartItems
					join product in products
					on cartItem.MaSP equals product.MaSP
					select new CartItemDto
					{
						Id = cartItem.Id_CTCart,
						ProductId = cartItem.MaSP,
						ProductName = product.TenSP,
						ProductDescription = product.MoTa,
						ProductImageURL = product.ImageURL,
						Price = product.GiaSP,
						CartId = cartItem.ID_Cart,
						Qty = cartItem.SoLuong,
						TotalPrice = product.GiaSP * cartItem.SoLuong
					}).ToList();
		}
		public static CartItemDto ConvertToDto(this ChiTietGioHang cartItem,
													SanPham product)
		{
			return new CartItemDto
			{
				Id = cartItem.Id_CTCart,
				ProductId = cartItem.MaSP,
				ProductName = product.TenSP,
				ProductDescription = product.MoTa,
				ProductImageURL = product.ImageURL,
				Price = product.GiaSP,
				CartId = cartItem.ID_Cart,
				Qty = cartItem.SoLuong,
				TotalPrice = product.GiaSP * cartItem.SoLuong
			};
		}


	}
}