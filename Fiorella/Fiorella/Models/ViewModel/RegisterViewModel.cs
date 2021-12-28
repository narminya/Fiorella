using System.ComponentModel.DataAnnotations;

namespace Fiorella.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required, MaxLength(100)]
        public string FullName { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
    }
}
