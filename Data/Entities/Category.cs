using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
        public int? ParentId { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public DateTime CreatedDate { get; set; }
        public CategoryStatus Status { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
        public List<Product> Products { get; set; }
    }
}
