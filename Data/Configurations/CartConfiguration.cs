using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(t => new { t.ProductId, t.UserId });
            builder.HasOne(x => x.User).WithMany(x=>x.Carts).HasForeignKey(x=>x.UserId);
            builder.HasOne(e => e.Product).WithMany(e=> e.Carts).HasForeignKey(e=>e.ProductId);
            builder.Property(e => e.Quantity);
        }
    }
}
