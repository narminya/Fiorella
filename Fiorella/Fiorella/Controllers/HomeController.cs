using Fiorella.Models.DataAccessLayer;
using Fiorella.Models.Entity;
using Fiorella.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            var sliderImages = await _dt.sliderImage.Where(s => s.IsChosen == true).ToListAsync();
            var aboutDetails = await _dt.aboutDetails.ToListAsync();
            var about = await _dt.about.FirstOrDefaultAsync();
            var categories = await _dt.categories.ToListAsync();
            var products = await _dt.products.Include(c => c.Category).ToListAsync();
            var experts = await _dt.experts.ToListAsync();
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
                MiniSliders = miniSlider,
                InstaSlides = instaSlider

            }); ;
        }


        public async Task<IActionResult> Subscribe(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return Json(new { result = "error", message = "Can not be empty" });
            }
            if (_dt.subscribers.Any(s => s.Email == email))
            {
                return Json(new { result = "error", message = "You have already subscribed" });

            }

            Subscriber subscriber = new Subscriber()
            {
                Email = email
            };
            await _dt.subscribers.AddAsync(subscriber);
            await _dt.SaveChangesAsync();


            //SmtpClient smtp = new SmtpClient("smtp.google.com", 587)
            //{
            //    EnableSsl = true,
            //    Credentials = new NetworkCredential("email", "password")
            //};

            //MailMessage mail = new MailMessage("email",email);
            //mail.Subject
            //mail.Body

            return Json(new { result = "success", message = "You have subscribed for news" });

        }
    }
}
