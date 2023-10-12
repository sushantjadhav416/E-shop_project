using E_shop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_shop.Controllers
{
    public class RegisterController : Controller
    {
        private  UserManager<IdentityUser> usermanager;
        private  SignInManager<IdentityUser> signinmanager;

        
        private User model;

        public RegisterController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager){ 
            this.usermanager = userManager;
            this.signinmanager = signInManager;
        }

        // GET: RegisterController
        [HttpGet]
        public ActionResult RegisterUser()
        {
         return View();
        }

        [HttpPost]
        [ActionName("RegisterUser")]
        public async Task<ActionResult> RegisterUser(User rst)
        {
            if (ModelState.IsValid)
            {

                var User = new IdentityUser()
                {
                    UserName = rst.FirstName,
                    Email = rst.Email
                };

                var result = await this.usermanager.CreateAsync(User, rst.Password);

                if (result.Succeeded)
                {
                    await signinmanager.SignInAsync(User, true);
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return RedirectToAction("RegisterUser", "Register", new { area = "" });
                }
              
            }

            return View();
        }
           
         
    }
}
