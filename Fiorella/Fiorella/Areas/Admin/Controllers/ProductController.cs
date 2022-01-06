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
    public class ProductController : Controller
    {
        private FiorellaDataContext _dt;
        public ProductController(FiorellaDataContext dt)
        {
            _dt = dt;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _dt.products.Include(p=>p.Category).ToListAsync();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                await _dt.products.AddAsync(product);
                await _dt.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();

        }
    }
}
