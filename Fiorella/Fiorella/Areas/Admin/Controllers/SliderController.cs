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
    public class SliderController : Controller
    {
        private readonly FiorellaDataContext _dt;
        private readonly IWebHostEnvironment _env;
        public SliderController(FiorellaDataContext dt, IWebHostEnvironment env)
        {
            _dt = dt;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<SliderImage> result = await _dt.sliderImage.ToListAsync();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<IActionResult> CreateSlider(SliderImage sliderImage)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!sliderImage.File.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(SliderImage), "File is not supported");
                return View();
            }
            if (sliderImage.File.Length > 1000 * 1024)
            {
                ModelState.AddModelError(nameof(SliderImage), "File`s size can not be greater than 1mb");

            }

            string wwwroot = _env.WebRootPath;
            string file = Guid.NewGuid() + sliderImage.File.FileName;
            string path = Path.Combine(wwwroot, "img", file);
            using (FileStream fs = new FileStream(path,FileMode.Create))
            {
                sliderImage.Image = file;
                await sliderImage.File.CopyToAsync(fs);
                await _dt.sliderImage.AddAsync(sliderImage);
                await _dt.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (!id.HasValue || id.Value<1)
            {
                return BadRequest();
            }

            SliderImage slider = await _dt.sliderImage.FindAsync(id);
            if (slider==null)
            {
                return BadRequest();
            }
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Update")]
        public async Task<IActionResult> UpdateSlider(int? id, SliderImage sliderImage)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id != sliderImage.Id)
            {
                return NotFound();
            }

            if (!sliderImage.File.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(SliderImage), "File is not supported");
                return View();
            }
            if (sliderImage.File.Length > 1000 * 1024)
            {
                ModelState.AddModelError(nameof(SliderImage), "File`s size can not be greater than 1mb");

            }

            string wwwroot = _env.WebRootPath;
            string file = Guid.NewGuid() + sliderImage.File.FileName;
            string path = Path.Combine(wwwroot, "img", file);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                sliderImage.Image = file;
                await sliderImage.File.CopyToAsync(fs);
                _dt.sliderImage.Update(sliderImage);
                await _dt.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));

        }
    }
}
