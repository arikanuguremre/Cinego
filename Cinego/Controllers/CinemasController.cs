using Cinego.Data;
using Cinego.Data.Services;
using Cinego.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinego.Controllers
{
    public class CinemasController : Controller
    {

       
        private readonly ICinemasService _service;

        public CinemasController( ICinemasService service)
        {
            
            _service = service;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Name,Brandlogo,CinemaInfo")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            TempData["Message"] = "Cinema Saved Successfully ";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);



        }
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null) return View("NotFound");
            return View(cinemaDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Brandlogo,CinemaInfo")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.UpdateAsync(id, cinema);
            TempData["Message"] = "Cinema Edited Successfully ";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null) return View("NotFound");
            return View(cinemaDetail);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null) return View("NotFound");

            await _service.DeleteAsync(id);
            TempData["Message"] = cinemaDetail.Name +" Deleted Successfully ";
            return RedirectToAction(nameof(Index));
        }




    }
}
