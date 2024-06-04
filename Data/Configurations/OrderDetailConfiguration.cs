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
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasOne(x=>x.Order).WithMany(x=>x.OrderDetails).HasForeignKey(x=>x.OrderId).OnDelete(DeleteBehavior.NoAction); ;
            builder.HasOne(x=>x.Product).WithMany(x=>x.OrderDetails).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.NoAction); ;
        }
    }
}
