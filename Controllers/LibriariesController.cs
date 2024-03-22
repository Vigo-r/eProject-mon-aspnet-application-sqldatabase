using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class LibriariesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
