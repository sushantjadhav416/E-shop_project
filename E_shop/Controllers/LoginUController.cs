using E_shop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_shop.Controllers
{
    public class LoginUController : Controller
    {
       
        private readonly SignInManager<IdentityUser> signinmanager;

        public LoginUController(SignInManager<IdentityUser> signinManager)
        {
            this.signinmanager = signinManager;
        }

        // GET: LoginUController
        public ActionResult Loginpage()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Loginpage")]
        public async Task<ActionResult> Loginpage(Login ln, string returnurl=null)
        {
            if (ModelState.IsValid)
            {
                var result = await signinmanager.PasswordSignInAsync(ln.Email, ln.Password, ln.RememberMe, false);

                if (result.Succeeded)
                {
                    if (returnurl == null || returnurl == "/")
                    {
                        return RedirectToAction("Index", "Home", new { area = "" });
                    }
                    else
                    {
                        return RedirectToPage(returnurl);
                    }
                }

                ModelState.AddModelError("", "Username or Password Incorrect !!!!!!");
            }

            return View();
        }


    }
}
