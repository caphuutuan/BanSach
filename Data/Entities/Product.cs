﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public int Stock { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoAlias { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Status { get; set; }

        public Author Author { get; set; }
        public List<Cart> Carts { get; set; }
        public Category Categories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public Publisher Publisher { get; set; }
    }
}
