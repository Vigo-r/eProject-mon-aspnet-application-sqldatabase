using eTickets.Data;
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
        //vzima Author/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Author author)
        {
            if(ModelState.IsValid) 
            { 
                return View(author);
            }
            await _service.AddAsync(author);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);

            if (authorDetails == null) return View("Empty");
            return View(authorDetails);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("AuthorId,FullName,ProfilePictureURL,Bio")] Author author)
        {
            if (ModelState.IsValid)
            {
                return View(author);
            }
            await _service.UpdateAsync(id, author);
            return RedirectToAction(nameof(Index));
        }
    }
}
