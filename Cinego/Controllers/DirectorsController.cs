using Cinego.Data;
using Cinego.Data.Services;
using Cinego.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinego.Controllers
{
    public class DirectorsController : Controller
    {

        private readonly IDirectorsService _service;

        public DirectorsController(IDirectorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);



        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,PpURL,Bio")] Director director)
        {
            if (!ModelState.IsValid)
            {
                return View(director);
            }
            await _service.AddAsync(director);
            TempData["Message"] = "Actor Saved Successfully ";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var directorDetail = await _service.GetByIdAsync(id);
            if (directorDetail == null)
            {
                return View("NotFound");
            }
            return View(directorDetail);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var directorDetail = await _service.GetByIdAsync(id);
            if (directorDetail == null) return View("NotFound");
            return View(directorDetail);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,PpURL,Bio")] Director director)
        {
            if (!ModelState.IsValid)
            {
                return View(director);
            }
            await _service.UpdateAsync(id, director);
            TempData["Message"] = "Director Edited Successfully ";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var directorDetail = await _service.GetByIdAsync(id);
            if (directorDetail == null) return View("NotFound");
            return View(directorDetail);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var directorDetail = await _service.GetByIdAsync(id);
            if (directorDetail == null) return View("NotFound");

            await _service.DeleteAsync(id);
            TempData["Message"] = "Director Deleted Successfully ";
            return RedirectToAction(nameof(Index));
        }
    }
}
