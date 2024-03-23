using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class PublishersController : Controller
    {
        private readonly AppDbContext _cotext;
        public PublishersController(AppDbContext context)
        {
            _cotext = context;
        }
        public async Task<IActionResult> Index()
        {
            var allPublishers= await _cotext.Publishers.ToListAsync();

            return View(allPublishers);
        }
    }
}
