using Cinego.Data;
using Cinego.Data.Services;
using Cinego.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinego.Controllers
{
	public class ActorsController : Controller
	{
		private readonly IActorsService _service;

		public ActorsController(IActorsService service)
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
		public async Task<IActionResult> Create([Bind("FullName,PpURL,Bio")] Actor actor)
		{
			if (!ModelState.IsValid)
			{
				return View(actor);
			}
			await _service.AddAsync(actor);
			TempData["Message"] = "Actor Saved Successfully ";
			return RedirectToAction(nameof(Index));
		}

		//Actors/Details/1
		public async Task<IActionResult> Details(int id)
		{
			var actorDetail = await _service.GetByIdAsync(id);
			if (actorDetail == null)
			{
				return View("NotFound");
			}
			return View(actorDetail);
		}

		public async Task<IActionResult> Edit(int id)
		{
			var actorDetail = await _service.GetByIdAsync(id);
			if (actorDetail == null) return View("NotFound");
			return View(actorDetail);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id,[Bind("Id,FullName,PpURL,Bio")] Actor actor)
		{
			if (!ModelState.IsValid)
			{
				return View(actor);
			}
			await _service.UpdateAsync(id,actor);
			TempData["Message"] = "Actor Edited Successfully ";
			return RedirectToAction(nameof(Index));
		}
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetail = await _service.GetByIdAsync(id);
            if (actorDetail == null) return View("NotFound");
            return View(actorDetail);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetail = await _service.GetByIdAsync(id);
            if (actorDetail == null) return View("NotFound");

			await _service.DeleteAsync(id);
            TempData["Message"] = "Actor Deleted Successfully ";
            return RedirectToAction(nameof(Index));
        }
    }
}