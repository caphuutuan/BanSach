using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Detail { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Status { get; set; }
    }
}
