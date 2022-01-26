using System;
using Microsoft.EntityFrameworkCore;

namespace mission4.Models
{
    public class MovieResponseContext : DbContext
    {
        public MovieResponseContext(DbContextOptions<MovieResponseContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<MovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Back to the Future",
                    Year = 1985,
                    Director = "Robert Zemeckis",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new MovieResponse
                {
                    MovieID = 2,
                    Category = "Comedy",
                    Title = "Hot Rod",
                    Year = 2007,
                    Director = "Akiva Schaffer",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new MovieResponse
                {
                    MovieID = 3,
                    Category = "Comedy",
                    Title = "Hoodwinked!",
                    Year = 2005,
                    Director = "Cory Edwards",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }


                );
            ;
        }

    }
}



