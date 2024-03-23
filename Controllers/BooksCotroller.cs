using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;
        public BooksController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allBooks = await _context.Books.Include(n => n.Library).OrderBy(n => n.Name).ToListAsync();
            return View(allBooks);
        }
    }
}
