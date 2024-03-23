using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly AppDbContext _context;
        public AuthorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Authors.ToList();

            return View(data);
        }
    }
}
