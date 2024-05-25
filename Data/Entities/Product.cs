using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
	public class Product
	{
		public int ProductId { get; set; }
		public decimal Price { get; set; }
		public decimal OriginalPrice { get; set; }
		public int Stock { get; set; }
		public string Image { get; set; }
		public int ViewCount { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set;}

	}
}
