using Cinego.Data;
using Cinego.Data.Services;
using Cinego.Data.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cinego.Controllers
{
    public class MoviesController : Controller
    {
        IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service= service;
        }
        public async Task<IActionResult> Index()
        {
          var data = await _service.GetAllAsync();
            return View(data);

        }

        public async Task<IActionResult> Details (int id)
        {
            var detail = await _service.GetByIdAsync(id);
            return View(detail);
        }

        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _service.GetMovieDropdownsValues();
            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Directors = new SelectList(movieDropdownsData.Directors, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(FreshMovie movie)
        {
            if(!ModelState.IsValid)
            {
                var movieDropdownsData = await _service.GetMovieDropdownsValues();
                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Directors = new SelectList(movieDropdownsData.Directors, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
                return View(movie);
            }
            await _service.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));   
        }
    }
}
