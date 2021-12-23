using Fiorella.Models.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Areas.Admin.ViewModel
{
    public class SliderViewModel
    {
        public int Id { get; set; }
        public Slider Slider { get; set; }
        public List<SliderImage> Images { get; set; }
        [NotMapped]
        [DisplayName("Images")]
        public IFormFile[] File { get; set; }


    }
}
