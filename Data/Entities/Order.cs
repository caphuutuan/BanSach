using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        public decimal LateFee { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
