﻿using Data.Entities;
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
            builder.HasOne(x => x.User).WithMany(x=>x.Orders).HasForeignKey(x=>x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x=>x.OrderDate).HasDefaultValue(DateTime.Now);
        }
    }
}
