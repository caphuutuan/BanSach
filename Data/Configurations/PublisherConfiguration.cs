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
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.ToTable("Publishers");
            builder.HasKey(x => x.PublisherId);
            builder.Property(x => x.PublisherId).UseIdentityColumn();
            builder.Property(x => x.PublisherName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Image).HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(300);
        }
    }
}
