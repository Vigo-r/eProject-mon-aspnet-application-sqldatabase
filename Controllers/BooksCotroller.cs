using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class BooksCotroller : Controller
    {
        private readonly AppDbContext _context;

        public BooksCotroller (AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allBooks = await _context.Books.ToListAsync();
            return View();
        }
    }
}
