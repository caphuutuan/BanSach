using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.UserId).UseIdentityColumn();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Sdt).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.Image);
            builder.Property(x => x.Username).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Dob).IsRequired();
            builder.Property(x => x.AmountBorrowed).HasDefaultValue(0);
            builder.Property(x => x.LastLogin);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.RoleId);
            builder.Property(x => x.Status);
        }
    }
}
