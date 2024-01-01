using Cinego.Data;
using Cinego.Data.ViewModel;
using Cinego.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cinego.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly CinegoDbContext _context;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, CinegoDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()=> View(new LoginViewModel());

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(!ModelState.IsValid) { return View(loginViewModel); }

            var user = await _userManager.FindByEmailAsync(loginViewModel.EmailAddress);
            if(user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                if (passwordCheck)
                {
                    var res = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                    if(res.Succeeded)
                    {
                        TempData["Success"] = "Welcome " + user.UserName;
                        return RedirectToAction("Index", "Movies");
                        
                    }
                }
                TempData["Error"] = "Wrong Emial or Password, please try again !";
                return View(loginViewModel);
            }
            TempData["Error"] = "Wrong Email or Password, please try again !";
            return View(loginViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Movies");
        }
            
        
    }
}
