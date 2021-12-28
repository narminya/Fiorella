using Fiorella.Models.Entity;
using Fiorella.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Fiorella.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Register")]
        public async Task<IActionResult> RegisterNew(RegisterViewModel rvm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbUser = _userManager.FindByNameAsync(rvm.Username);

            if (dbUser != null)
            {
                ModelState.AddModelError(nameof(RegisterViewModel.Username), "Already Exists in database");
                return View();
            }

            User user = new User()
            {
                FullName = rvm.FullName,
                Email = rvm.Email,
                Password = rvm.Password,
                UserName = rvm.Username
            };

            IdentityResult identityResult = await _userManager.CreateAsync(user, rvm.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                    return View();
                }
            }

            return View(nameof(HomeController.Index), "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(lvm.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Not found");
                return View();
            }

          var signin = await _signInManager.PasswordSignInAsync(lvm.Username, lvm.Password, true, true);
            if (!signin.Succeeded)
            {
                ModelState.AddModelError("", "Not found");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
