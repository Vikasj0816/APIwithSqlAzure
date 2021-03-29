using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDatabase1Project.Models
{
    public class ShowContext:DbContext
    {
        public ShowContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie()
            {
                Id=1,
                Name="Robert",
                Description="Drama",
                Duration=135
            });
        }
    }
}
