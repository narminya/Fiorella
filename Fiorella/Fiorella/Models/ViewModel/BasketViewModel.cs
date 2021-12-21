using Fiorella.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.ViewModel
{
    public class BasketViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Desc { get; set; }
        public int? CategoryId { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        public int Count { get; set; } = 1;
    }
}
