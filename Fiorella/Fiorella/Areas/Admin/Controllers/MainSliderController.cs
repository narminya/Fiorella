using Fiorella.Areas.Admin.Utils;
using Fiorella.Areas.Admin.ViewModel;
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
    public class MainSliderController : Controller
    {
        private readonly FiorellaDataContext _dt;
        public MainSliderController(FiorellaDataContext dt)
        {
            _dt = dt;
        }
        public async Task<IActionResult> Index()
        {
            var slider = await _dt.slider.FirstOrDefaultAsync();
            var sliderImages = await _dt.sliderImage.Where(s => s.SliderId == slider.Id).ToListAsync();
    
            SliderViewModel svm = new SliderViewModel()
            {
                Slider = slider,
                Images = sliderImages
            };
            return View(svm);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<IActionResult> CreateSlider(SliderViewModel svm)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            if (!svm.Slider.File.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(svm.Slider.File), "File is not supported");
                return View();
            }
            if (svm.Slider.File.Length > 1000 * 1024)
            {
                ModelState.AddModelError(nameof(svm.Slider.File), "File is not supported");
                return View();
            }

            svm.Slider.Signature = FileUtil.FileCreate(svm.Slider.File);
            svm.Images = new List<SliderImage>(); 
            await _dt.slider.AddAsync(svm.Slider);
            await _dt.SaveChangesAsync();
            foreach (var item in svm.File)
            {
                if (!item.ContentType.Contains("image"))
                {
                    ModelState.AddModelError(nameof(svm.File), "File is not supported");
                    return View();
                }
                if (item.Length > 1000 * 1024)
                {
                    ModelState.AddModelError(nameof(svm.File), "File is not supported");
                    return View();
                }

                svm.Images.Add(new SliderImage { Image = FileUtil.FileCreate(item), SliderId = svm.Slider.Id });

            }

            await _dt.sliderImage.AddRangeAsync(svm.Images);

            await _dt.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
