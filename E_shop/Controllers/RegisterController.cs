using E_shop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_shop.Controllers
{
    interface User_regi
    {
        internal ActionResult RegisterUser();
    }
    public class RegisterController : Controller, User_regi
    {
        private UserManager<IdentityUser> usermanager;
        private SignInManager<IdentityUser> signinmanager;

        public RegisterController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) {
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
            try
            {
                if (ModelState.IsValid)
                {

                    var MUser = new IdentityUser()
                    {
                        UserName = rst.FirstName,
                        Email = rst.Email
                    };

                    var result = await this.usermanager.CreateAsync(MUser, rst.Password);

                    if (result.Succeeded)
                    {
                        await signinmanager.SignInAsync(MUser, true);
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
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return View();

        }
    
   
    

           
         
    }
}
