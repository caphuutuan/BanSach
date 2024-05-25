using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
	public class Blog
	{
		public int BlogId { get; set; }
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public string Description { get; set; } 
		public string Detail {  get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
		public BlogStatus Status { get; set; }
	}
}
