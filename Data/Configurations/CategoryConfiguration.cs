using Data.Entities;
using Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryId).IsRequired().UseIdentityColumn();
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Image).HasMaxLength(255);
            builder.Property(x => x.SeoDescription).HasMaxLength(500);
            builder.Property(x => x.SeoTitle).HasMaxLength(150);
            builder.Property(x => x.SeoAlias).HasMaxLength(150);
            builder.Property(x => x.ParentId);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.Status);

        }
    }
}
