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

       

        public RegisterController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager) { 
            this.usermanager = userManager;
            this.signinmanager = signInManager;
        }

        // GET: RegisterController
       public ActionResult RegisterUser()
        {
         return View();
        }

        [HttpPost]
        [ActionName("RegisterUser")]
        public async Task<ActionResult> RegisterUser(Register rst)
        {
           

            if (ModelState.IsValid)
            {

                var User = new IdentityUser()
                {
                    UserName = rst.Name,
                    Email = rst.Email
                };

                var result = await usermanager.CreateAsync(User, rst.Password);

                if (result.Succeeded)
                {
                    await signinmanager.SignInAsync(User, false);
                    return RedirectToAction("Index", "Home", new { area = "" });
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View();
        }
           
         
    }
}
