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
    public class LayoutController : Controller
    {
        private FiorellaDataContext _dt;
        public LayoutController(FiorellaDataContext dt)
        {
            _dt = dt;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _dt.layouts.ToListAsync();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LayoutInfo layout)
        {
            if (ModelState.IsValid)
            {
                await _dt.layouts.AddAsync(layout);
                await _dt.SaveChangesAsync();
                return View(nameof(Index));

            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (!id.HasValue || id.Value < 1)
            {
                return NotFound();
            }

            var layout = await _dt.layouts.FirstOrDefaultAsync(p => p.Id == id);
            if (layout==null)
            {
                return NotFound();
            }
            return View(layout);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, LayoutInfo layout)
        {
            if (id != layout.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _dt.layouts.Update(layout);
                await _dt.SaveChangesAsync();

                return View(nameof(Index));
            }


            return View(layout);
        }
    }
}
