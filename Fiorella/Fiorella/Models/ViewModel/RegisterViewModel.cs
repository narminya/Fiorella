using System.ComponentModel.DataAnnotations;

namespace Fiorella.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required, MaxLength(100), MinLength(6)]
        public string FullName { get; set; }

        [Required, MaxLength(100), MinLength(6)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
