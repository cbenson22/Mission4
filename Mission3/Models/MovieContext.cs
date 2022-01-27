using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3.Models
{
    public class MovieContext : DbContext
    {
        //consturctor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {// This seeds in Database Entries
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse { 
                    MovieName = "Ferris Bueller's Day Off",
                    Category = "Comedy",
                    Year = 1986,
                    Rating = "PG-13",
                    Director = "John Hughes",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                    },
                new ApplicationResponse
                {
                    MovieName = "The Dark Knight",
                    Category = "Action/Adventure",
                    Year = 2008,
                    Rating = "PG-13",
                    Director = "Christopher Nolan",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new ApplicationResponse
                {
                    MovieName = "Thor Ragnarok",
                    Category = "Action/Adventure",
                    Year = 2017,
                    Rating = "PG-13",
                    Director = "Taika Waititi",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                }
                );
        }
    }
}
