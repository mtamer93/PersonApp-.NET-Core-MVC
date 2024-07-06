using Microsoft.EntityFrameworkCore;
using PersonApp.Core.Entities.Concrete;
using PersonApp.DataAccess.Config;
using PersonApp.DataAccess.SeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> Person {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonSeedData());

            modelBuilder.ApplyConfiguration(new PersonConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
