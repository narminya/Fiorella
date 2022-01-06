using Fiorella.Areas.Admin.ViewModel;
using Fiorella.Models.DataAccessLayer;
using Fiorella.Models.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly FiorellaDataContext _db;
        private readonly UserManager<User> _user;
        private readonly RoleManager<User> _role;

        public UserController(FiorellaDataContext db, UserManager<User> user, RoleManager<User> role)
        {
            _db = db;
            _role = role;
            _user = user;
        }


        public async Task<IActionResult> Index()
        {
            // var users = await _db.Users.Select(x =>
            //new UserViewModel
            //{
            //    Id = x.Id,
            //    FullName = x.Fullname,
            //    Username = x.UserName,
            //    Email = x.Email
            //}
            // ).ToListAsync();


            var users = await _db.Users.ToListAsync();
            var userList = new List<UserViewModel>();

            foreach (var item in users)
            {
                userList.Add(new UserViewModel
                {
                    Id = item.Id,
                    FullName = item.Fullname,
                    Username = item.UserName,
                    Email = item.Email,
                    Role = (await _user.GetRolesAsync(item))[0] 
                });
            }

         
            return View();
        }

        [HttpPost]
        public IActionResult AddRole()
        {
            TempData["Roles"] = new SelectList(_db.Roles, "Id", "Name");
            return View();
        }
    }
}
