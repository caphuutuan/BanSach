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
    public class MemberTierConfiguration :IEntityTypeConfiguration<MemberTier>
    {
        public void Configure(EntityTypeBuilder<MemberTier> builder)
        {
            builder.ToTable("MemberTiers");
            builder.HasKey(x => x.MemberTierId);
            builder.Property(x => x.MemberTierId).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(150);
        }
    }
}
