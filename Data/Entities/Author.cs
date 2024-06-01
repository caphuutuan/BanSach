using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required, MaxLength(255)]
        public string AuthorName { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
