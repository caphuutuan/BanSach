using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.HasOne(x => x.Author).WithMany(x => x.Products).HasForeignKey(x => x.AuthorId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Publisher).WithMany(x => x.Products).HasForeignKey(x => x.PublisherId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
