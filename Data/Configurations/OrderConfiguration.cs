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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.OrderId);
            builder.Property(x=>x.OrderId).UseIdentityColumn();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.OrderDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.ReturnDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.PromotionId);
            builder.Property(x => x.LateFee).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x=>x.Status).IsRequired();
        }
    }
}
