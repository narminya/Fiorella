using Fiorella.Areas.Admin.ViewModel;
using Fiorella.Models.Data;
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
       private readonly RoleManager<IdentityRole> _role;

        public UserController(FiorellaDataContext db, UserManager<User> user, RoleManager<IdentityRole> role)
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
            ViewData["Roles"] = new SelectList(_db.Roles);


            return View(userList);
        }
        public async Task<IActionResult> ChangePassword(string Id)
        {

            var user = await _db.Users.FindAsync(Id);
            if (user == null)
            {
                return NotFound();
            }
            var changePasswordViewModel = new ChangePasswordViewModel()
            {
                Id = user.Id,
                Username = user.UserName 
            };
            return View(changePasswordViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string Id,ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await _user.FindByIdAsync(model.Id);
            if (user == null)
            {
                ModelState.AddModelError("", "User is not found");
                return View();
            }


            ChangePasswordViewModel viewModel = new ChangePasswordViewModel()
            {
                Id = model.Id,
                Username = model.Username
            };

            var passwordcheck = await _user.CheckPasswordAsync(user, model.OldPassword);
            if (!passwordcheck)
            {
                ModelState.AddModelError("", "Old password is wrong");
                return View(viewModel);
            }

            var passwordChangeResult = await _user.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (!passwordChangeResult.Succeeded)
            {
                ModelState.AddModelError("", "Something went wrong,try again");
                return View();
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> ChangeRole(string id,string role)
        {            
            var user = await _db.Users.FindAsync(id);
           await _user.AddToRoleAsync(user, role);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DisableUser(string id)
        {
            var user = await _db.Users.FindAsync(id);
            await _user.SetLockoutEnabledAsync(user, true);
            await _user.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.MaxValue));
         //  await _user.UpdateSecurityStampAsync(user);
            return RedirectToAction(nameof(Index));

        }
    }
}
