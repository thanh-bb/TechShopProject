using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Models.Enums;

namespace TechShop.Models.Dtos
{
    public class UserCreate
    {

        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenKH { get; set; }

        [Required]
        public DateTime NgaySinh { get; set; }


        [Required(ErrorMessage = "Please select gender")]
        public Gender? Gender { get; set; }


        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage ="Incorrect Email Format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phonenumber is Required")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        public string DienThoai { get; set; }


        [Required]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$",
        ErrorMessage = "Password should have minimum 8 characters, at least 1 uppercase letter, 1 lowercase letter and 1 number.")]
        public string PasswordHash { get; set; }


        [Required]
        public string? UserName { get; set; }





    }
}
