using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int? PromotionId { get; set; }

        public decimal LateFee { get; set; }
        public decimal TotalPrice { get; set; }
        public int Status { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public Promotion? Promotions { get; set; }

        public User User { get; set; }
    }
}
