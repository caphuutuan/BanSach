using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Promotion
    {
        public int PromotionId { get; set; }

        public string Title { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public bool ApplyForAll { get; set; }

        public int? MemberTierId { get; set; }

        public int Status { get; set; }

        public List<Order> Orders { get; set; }
    }
}
