using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public string? Image { get; set; }

        public string? Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
