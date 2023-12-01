using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Models.Enums;

namespace TechShop.Models.Dtos
{
    public class ProductCreate
    {
        public int MaSP { get; set; }


        [Required(ErrorMessage = "Trường này bắt buộc")]
        [MaxLength(100, ErrorMessage = "Nhập tên sản phẩm dưới 100 kí tự")]
        public string TenSP { get; set; }


        [Required(ErrorMessage = "Trường này bắt buộc")]
        [Range(minimum: 10000, maximum: 50000000, ErrorMessage = "Nhập giá tiền từ 10.000đ đến 50.000.000đ")]
        public long GiaSP { get; set; }


        [Required(ErrorMessage = "Trường này bắt buộc")]
        [Range(1,10, ErrorMessage = "Nhập số lượng từ 1 đến 10")]
        public int SoLuong { get; set; }


        [Required(ErrorMessage = "Trường này bắt buộc")]
        [MaxLength(1000, ErrorMessage = "Nhập mô tả sản phẩm dưới 1000 kí tự")]
        public string MoTa { get; set; }



        [Required(ErrorMessage = "Trường này bắt buộc")]
        public string MaLoai { get; set; }
      
        public DateTime NgayDang { get; set; }


        [Required(ErrorMessage = "Trường này bắt buộc")]
        public Guid Id { get; set; }



        [Required(ErrorMessage = "Hãy chọn tình trạng hàng")]
        public Status? Status { get; set; }


        [Required(ErrorMessage = "Vui lòng chọn 1 hình ảnh")]
        public string ImageURL {  get; set; }

       

        
    }
}
