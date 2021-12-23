using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.Entity
{
    public class SliderImage : BaseEntity
    {
        public string Image { get; set; }
        public bool IsChosen { get; set; }
        [NotMapped]
        [DisplayName("Images")]
        public IFormFile File { get; set; }
        public int SliderId { get; set; }
        public Slider Slider { get; set; }
    }
}
