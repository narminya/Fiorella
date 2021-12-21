using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiorella.Models.Entity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }


        [Display(Name = "Created At")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Updated At")]
        public DateTime? UpdatedDate { get; set; }

        [Display(Name = "Deleted At")]
        public DateTime? DeletedDate { get; set; }
    }
}
