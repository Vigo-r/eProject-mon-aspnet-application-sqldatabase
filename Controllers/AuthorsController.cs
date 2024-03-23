using System.Threading.Tasks;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
 
namespace eTickets.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorsService _service;
 
        public AuthorsController(IAuthorsService service)
        {
            _service = service;
        }
 
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
 
        // GET: Authors/Create
        public IActionResult Create()
        {
            return View();
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
 
            await _service.AddAsync(author);
            return RedirectToAction(nameof(Index));
        }
 
        // GET: Authors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
 
            if (authorDetails == null)
            {
                return NotFound();
            }
 
            return View(authorDetails);
        }
 
        // GET: Authors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
 
            if (authorDetails == null)
            {
                return NotFound();
            }
 
            return View(authorDetails);
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Author author)
        {
            if (id != author.Id || !ModelState.IsValid)
            {
                return View(author);
            }
 
            await _service.UpdateAsync(id, author);
            return RedirectToAction(nameof(Index));
        }
 
        // GET: Authors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
 
            if (authorDetails == null)
            {
                return NotFound();
            }
 
            return View(authorDetails);
        }
 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
 
            if (authorDetails == null)
            {
                return NotFound();
            }
 
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
 