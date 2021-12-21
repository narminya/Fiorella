using Fiorella.Models.DataAccessLayer;
using Fiorella.Models.Entity;
using Fiorella.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        private FiorellaDataContext _dt;
        public HomeController(FiorellaDataContext dt)
        {
            _dt = dt;
        }

        public async Task<IActionResult> Index()
        {

            var slider = await _dt.slider.FirstOrDefaultAsync();
            var sliderImages = await _dt.sliderImage.ToListAsync();
            var aboutDetails = await _dt.aboutDetails.ToListAsync();
            var about = await _dt.about.FirstOrDefaultAsync();
            var categories = await _dt.categories.ToListAsync();
            var products = await _dt.products.Include(c => c.Category).ToListAsync();
            var experts = await _dt.experts.ToListAsync();
            var contactSection = await _dt.contactSection.FirstOrDefaultAsync();
            var miniSlider = await _dt.miniSliders.Include(e => e.Expert).ToListAsync();
            var instaSlider = await _dt.instaSlider.ToListAsync();
            return View(new HomeViewModel
            {
                Slider = slider,
                SliderImage = sliderImages,
                About = about,
                AboutDetails = aboutDetails,
                Categories = categories,
                Products = products,
                Experts = experts,
                ContactSection = contactSection,
                MiniSliders = miniSlider,
                InstaSlides = instaSlider

            }); ;
        }
    }
}
