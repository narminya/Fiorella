using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.Entity
{
    public class LayoutInfo : BaseEntity
    {
        public string Logo { get; set; }
        [Required]
        public string LinkedId { get; set; }
        [Required]
        public string Facebook { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
