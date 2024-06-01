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
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoleId });
            builder.HasOne(x=>x.User).WithMany(x=>x.UserRoles).HasForeignKey(x=>x.UserId);
            builder.HasOne(x=>x.Role).WithMany(x=>x.UserRoles).HasForeignKey(x=>x.RoleId);

        }
    }
}
