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
		public DateTime OrderDate { get; set; }
		public int UserId {  get; set; }
		public string ShipName { get; set; }
		public string ShipAddress { get; set; }
		public string ShipEmail { get; set; }
		public string ShipPhone { get; set; }
		public decimal TotalPrice { get; set; }
		public int Status { get; set; }
	}
}
