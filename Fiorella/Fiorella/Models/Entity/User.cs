using Microsoft.AspNetCore.Identity;

namespace Fiorella.Models.Entity
{
    public class User :BaseEntity
    {
        public string FullName { get; set; }
    }
}
