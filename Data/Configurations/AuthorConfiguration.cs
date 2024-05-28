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
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(x => x.AuthorId);
            builder.Property(x => x.AuthorId).UseIdentityColumn();
            builder.Property(x => x.AuthorName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Image);
            builder.Property(x => x.Description);
        }
    }
}
