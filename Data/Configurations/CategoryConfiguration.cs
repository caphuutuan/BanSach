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
            builder.Property(x => x.CategoryId).UseIdentityColumn();
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Image);
            builder.Property(x => x.SeoDescription).IsRequired();
            builder.Property(x => x.SeoTitle).IsRequired();
            builder.Property(x => x.SeoAlias).IsRequired();
            builder.Property(x => x.ParentId);
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.Status).HasDefaultValue(CategoryStatus.Active);

        }
    }
}
