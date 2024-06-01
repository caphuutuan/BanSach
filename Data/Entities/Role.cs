using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string RoleName { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }

        public virtual List<User> Users { get; set; } = new List<User>();
        public virtual List<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
