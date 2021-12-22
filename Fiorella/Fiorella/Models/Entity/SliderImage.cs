using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.Entity
{
    public class SliderImage : BaseEntity
    {
        public string Image { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
