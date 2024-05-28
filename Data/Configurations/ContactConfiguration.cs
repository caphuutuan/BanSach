using Data.Entities;
using Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.ContactId);
            builder.Property(x => x.ContactId).UseIdentityColumn();
            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Message).IsRequired();
            builder.Property(x => x.Status);
        }
    }
}
