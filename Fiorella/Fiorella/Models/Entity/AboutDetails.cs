﻿namespace Fiorella.Models.Entity
{
    public class AboutDetails : BaseEntity
    {
        public string Name { get; set; }
        public int? AboutId { get; set; }
        public About About { get; set; }


    }
}
