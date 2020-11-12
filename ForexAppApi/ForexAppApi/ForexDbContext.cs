using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForexAppApi.Model;
using Microsoft.EntityFrameworkCore;


namespace ForexAppApi
{
    public class ForexDbContext: DbContext
    {
        public ForexDbContext(DbContextOptions<ForexDbContext> options) : base(options)
        {

        }

        public DbSet<ForexDetail> ForexDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForexDetail>().ToTable("ForexDetail");

            modelBuilder.Entity<ForexDetail>().HasKey(s => s.Id);

        }
    }
}
