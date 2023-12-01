using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    [Table("Quyen")]
    public class Quyen : IdentityRole<Guid>
    {
        [Key]
        public Guid Id { get; set; }
              


    }
}
