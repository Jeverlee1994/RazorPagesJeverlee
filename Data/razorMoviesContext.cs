#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorMovies.Models;

namespace razorMovies.Data
{
    public class razorMoviesContext : DbContext
    {
        public razorMoviesContext (DbContextOptions<razorMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<razorMovies.Models.Movie> Movie { get; set; }
    }
}
