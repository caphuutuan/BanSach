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
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");
            builder.HasKey(x=>x.PromotionId);
            builder.Property(x=>x.PromotionId).UseIdentityColumn();
            builder.Property(x=>x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.FromDate).IsRequired().HasColumnType("datetime");
            builder.Property(x=>x.ToDate).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.ApplyForAll).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.MemberTierId);
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(PromotionStatus.InActive);
        }
    }
}
