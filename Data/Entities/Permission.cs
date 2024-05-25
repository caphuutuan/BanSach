using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
	public class Permission
	{
		public int RoleId { get; set; }
		public int FunctionId { get; set; }
		public int ActionId { get; set; }

	}
}
