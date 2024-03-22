using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class LibrariesController : Controller
    {
        private readonly AppDbContext _cotext;
        public LibrariesController(AppDbContext context)
        {
            _cotext = context;
        }
        public async Task<IActionResult> Index()
        {
            var allLibraries = await _cotext.Libraries.ToListAsync();

            return View();
        }
    }
}
