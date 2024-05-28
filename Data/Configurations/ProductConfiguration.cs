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
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.ProductName).IsRequired();
            builder.Property(x => x.Image);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Detail).IsRequired();
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.AuthorId).IsRequired();
            builder.Property(x => x.PublisherId).IsRequired();
            builder.Property(x => x.SeoTitle).IsRequired();
            builder.Property(x => x.SeoDescription).IsRequired();
            builder.Property(x => x.SeoAlias).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.UpdateDate).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
