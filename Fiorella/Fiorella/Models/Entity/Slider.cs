using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.Entity
{
    public class Slider : BaseEntity 
    { 
    
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Signature { get; set; }
        [NotMapped]
        [DisplayName("Signature")]
        public IFormFile File { get; set; }
       

    }
}
