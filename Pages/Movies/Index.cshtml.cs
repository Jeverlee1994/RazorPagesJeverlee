#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorMovies.Data;
using razorMovies.Models;

namespace razorMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly razorMovies.Data.razorMoviesContext _context;

        public IndexModel(razorMovies.Data.razorMoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
