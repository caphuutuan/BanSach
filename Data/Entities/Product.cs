using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, MaxLength(150)]
        public string ProductName { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [MaxLength(300)]
        public string Detail { get; set; }
        public int Stock { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int PublisherId { get; set; }

        [MaxLength(300)]
        public string SeoTitle { get; set; }

        [MaxLength(300)]
        public string SeoDescription { get; set; }

        [MaxLength(300)]
        public string SeoAlias { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Status { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; } 
        
        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }

        public List<Cart> Carts { get; set; } = new List<Cart>();

        public virtual List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        public virtual List<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    }
}
