using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly AppDbContext _cotext;
        public AuthorsController(AppDbContext context)
        {
            _cotext = context;
        }
        public IActionResult Index()
        {
            var data = _cotext.Authors.ToList();

            return View(data);
        }
    }
}
