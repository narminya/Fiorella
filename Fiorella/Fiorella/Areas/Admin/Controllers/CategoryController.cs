using Fiorella.Models.DataAccessLayer;
using Fiorella.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private FiorellaDataContext _dt;
        public CategoryController(FiorellaDataContext dt)
        {
            _dt = dt;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _dt.categories.ToListAsync();
            return View(result);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var result = await _dt.categories.FindAsync(id);
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                await _dt.categories.AddAsync(category);
                await _dt.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();

        }

        public async Task<IActionResult> Update(int? id)
        {
            if (!id.HasValue || id.Value < 1)
            {
                return BadRequest();
            }
            var category = await _dt.categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _dt.categories.Update(category);
                await _dt.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            return View(category);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            Category category = await _dt.categories.FindAsync(id);

            return View(category);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            Category category = await _dt.categories.FindAsync(id);

            if (category==null)
            {
                return NotFound();
            }

            _dt.categories.Remove(category);
            await _dt.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<PartialViewResult> Search(string searchFor)
        {
            if (string.IsNullOrWhiteSpace(searchFor))
            {
                return PartialView("_SearchCategoryPartial", new List<Category>());
            }

            var result = await _dt.categories.Where(p => p.Name.ToLower().Contains(searchFor.ToLower())).ToListAsync();
            return PartialView("_SearchCategoryPartial", result); 
        }

    }
}
