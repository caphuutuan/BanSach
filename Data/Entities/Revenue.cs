using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
	public class Revenue
	{
		public int RevenueId { get; set; }
		public DateTime StaticsDate { get; set; }
		public decimal TotalProceed { get; set; }
		public decimal TotalExpenditure { get; set; }
		public decimal TotalRevenue {  get; set; }
	}
}
