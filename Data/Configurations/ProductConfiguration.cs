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
            builder.ToTable("Products");
            builder.HasKey(x => x.ProductId);
            builder.Property(x => x.ProductId).UseIdentityColumn();
            builder.HasOne(x => x.Categories).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.Property(x => x.ProductName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Image).HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(300);
            builder.Property(x => x.Detail).HasMaxLength(300);
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.HasOne(x => x.Author).WithMany(x => x.Products).HasForeignKey(x => x.AuthorId);
            builder.HasOne(x => x.Publisher).WithMany(x => x.Products).HasForeignKey(x => x.PublisherId);
            builder.Property(x => x.SeoTitle).HasMaxLength(300);
            builder.Property(x => x.SeoDescription).HasMaxLength(300);
            builder.Property(x => x.SeoAlias).HasMaxLength(300);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.UpdateDate);
            builder.Property(x => x.Status);
        }
    }
}
