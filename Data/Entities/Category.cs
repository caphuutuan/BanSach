﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Enums;

namespace Data.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }
		public bool IsShowOnHome { get; set; }
		public int? ParentId { get; set; }
		public DateTime CreatedDate { get; set; }
		public CategoryStatus Status { get; set; }


	}
}
