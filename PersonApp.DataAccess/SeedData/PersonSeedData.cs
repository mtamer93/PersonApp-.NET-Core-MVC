using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.DataAccess.SeedData
{
    public class PersonSeedData : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person
                {
                    Id = 1,
                    FirstName = "Mehmet",
                    LastName = "Yılmaz",
                    DateOfBirth = new DateTime(1993, 11, 12),
                    Email = "mehmet.yilmaz@deneme.com"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Ahmet",
                    LastName = "Erdoğan",
                    DateOfBirth = new DateTime(1986, 6, 5),
                    Email = "ahmet.erdogan@deneme.com"
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Sevinç",
                    LastName = "Tamer",
                    DateOfBirth = new DateTime(1960, 9, 16),
                    Email = "sevinc.tamer@deneme.com"
                },
                new Person
                {
                    Id = 4,
                    FirstName = "Fatih",
                    LastName = "Öztürk",
                    DateOfBirth = new DateTime(2000, 4, 27),
                    Email = "fatih.ozturk@deneme.com"
                },
                new Person
                {
                    Id = 5,
                    FirstName = "Merve",
                    LastName = "Doğan",
                    DateOfBirth = new DateTime(2004, 6, 12),
                    Email = "merve.dogan@deneme.com"
                }
            );
        }
    }
}
