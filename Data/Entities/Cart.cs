using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
	public class Cart
	{
		public int CartId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public DateTime CreatedDate { get; set; }
		public Guid UserId { get; set; }
		public Product Product { get; set; }

		//public User User { get; set; }
	}
}
