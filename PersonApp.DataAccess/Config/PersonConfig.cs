using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.DataAccess.Config
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(250).IsRequired(true);
        }
    }
}
