using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Blog> posts { get; set; }
        public int? RoleId { get; set; }

       
        public Role Role { get; set; }
        

    }
}
