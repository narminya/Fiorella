﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Desc { get; set; }
        public int? CategoryId { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }


    }
}
