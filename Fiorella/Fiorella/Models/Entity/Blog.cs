using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.Entity
{
    public class Blog : BaseEntity
    {
        [Required(ErrorMessage ="Must be filled")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Must be filled")]
        public string Description { get; set; }
        public string Image { get; set; }

        
        public int? UserId { get; set; }


   


    }
}
