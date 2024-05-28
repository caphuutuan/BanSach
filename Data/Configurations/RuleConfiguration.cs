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
    public class RuleConfiguration : IEntityTypeConfiguration<Rule>
    {
        public void Configure(EntityTypeBuilder<Rule> builder)
        {
            builder.ToTable("Rules");
            builder.HasKey(x => x.RuleId);
            builder.Property(x => x.RuleId).UseIdentityColumn();
            builder.Property(x => x.RuleName).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x=>x.Fines).IsRequired();
        }
    }
}
