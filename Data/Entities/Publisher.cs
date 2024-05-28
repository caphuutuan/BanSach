using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        public string PublisherName { get; set; } = null!;

        public string? Image { get; set; }

        public string? Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
