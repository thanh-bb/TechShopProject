using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models.Dtos
{
    public class ProductCreate
    {
        public int MaSP { get; set; }


        [Required(ErrorMessage = "Trường này bắt buộc")]
        [MaxLength(50, ErrorMessage = "Nhập tên sản phẩm dưới 50 kí tự")]
        public string TenSP { get; set; }


        [Required(ErrorMessage = "Trường này bắt buộc")]
        [Range(minimum: 10000, maximum: 50000000, ErrorMessage = "Please enter a valid no between 10.000 & 50.000.000")]
        public long GiaSP { get; set; }


        [Required(ErrorMessage = "Trường này bắt buộc")]
        [Range(1,10)]
        public int SoLuong { get; set; }


        [Required]
        [MaxLength(100, ErrorMessage = "Nhập mô tả sản phẩm dưới 100 kí tự")]
        public string MoTa { get; set; }



        [Required(ErrorMessage = "Trường này bắt buộc")]
        public string MaLoai { get; set; }
      
        public DateTime NgayDang { get; set; }


        [Required(ErrorMessage = "Trường này bắt buộc")]
        public Guid NgDang { get; set; }

    }
}
