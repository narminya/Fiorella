using Fiorella.Models.DataAccessLayer;
using Fiorella.Models.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LayoutController : Controller
    {
        private readonly FiorellaDataContext _dt;
        private readonly IWebHostEnvironment _env;
        public LayoutController(FiorellaDataContext dt, IWebHostEnvironment env)
        {
            _dt = dt;
            _env = env;
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
        [ActionName("Create")]
        public async Task<IActionResult> CreateSlider(LayoutInfo layoutInfo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!layoutInfo.File.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(SliderImage), "File is not supported");
                return View();
            }
            if (layoutInfo.File.Length > 1000 * 1024)
            {
                ModelState.AddModelError(nameof(SliderImage), "File`s size can not be greater than 1mb");

            }

            string wwwroot = _env.WebRootPath;
            string file = Guid.NewGuid() + layoutInfo.File.FileName;
            string path = Path.Combine(wwwroot, "img", file);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                layoutInfo.Logo = file;
                await layoutInfo.File.CopyToAsync(fs);
                await _dt.layouts.AddAsync(layoutInfo);
                await _dt.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
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
