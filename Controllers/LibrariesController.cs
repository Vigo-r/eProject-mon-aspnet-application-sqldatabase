using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class LibrariesController : Controller
    {
        private readonly AppDbContext _context;
        public LibrariesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allLibraries = await _context.Libraries.ToListAsync();

            return View(allLibraries);
        }
    }
}
