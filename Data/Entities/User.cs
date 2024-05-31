using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public int? AmountBorrowed { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime CreatedDate { get; set; }
        public int RoleId { get; set; }
        public int Status { get; set; }

        public List<Cart> Carts { get; set; }
        public Role Role { get; set; }
        public List<Order> Orders { get; set; }
        public List<UserRole> UserRoles { get; set; }

    }
}
