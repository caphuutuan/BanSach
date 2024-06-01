using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required, MaxLength(200)]
        public string CategoryName { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        public int? ParentId { get; set; }

        [MaxLength(300)]
        public string SeoDescription { get; set; }

        [MaxLength(300)]
        public string SeoTitle { get; set; }

        [MaxLength(50)]
        public string SeoAlias { get; set; }

        public DateTime CreatedDate { get; set; }

        public CategoryStatus Status { get; set; }

        public virtual List<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
        public virtual List<Product> Products { get; set; } = new List<Product>();

        [ForeignKey("ParentId")]
        public virtual Category ParentCategory { get; set; }
    }
}
