using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string Sdt { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(250)]
        public string Address { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [Required, MaxLength(20)]
        public string Username { get; set; }

        [Required, MaxLength(20)]
        public string Password { get; set; }

        public DateTime Dob { get; set; }
        public int? AmountBorrowed { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        public int RoleId { get; set; }

        public int Status { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public virtual List<Cart> Carts { get; set; } = new List<Cart>();
        public virtual List<Order> Orders { get; set; } = new List<Order>();
        public virtual List<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
