using Fiorella.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.ViewModel
{
    public class HomeViewModel
    {
        public Slider Slider { get; set; }
        public ContactSection ContactSection { get; set; }

        public List<SliderImage> SliderImage { get; set; }
        public About About { get; set; }
        public List<AboutDetails> AboutDetails { get; set; }
        public List<Product> Products { get; set; }
        public List<Experts> Experts { get; set; }
        public List<MiniSlider> MiniSliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<SliderImage> InstaSlides { get; set; }

    }
}
