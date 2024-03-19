using E_shop.Models;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;


namespace E_shop.Controllers
{
    interface User_Login {

        public  ActionResult Loginpage();

    }
    public class LoginUController : Controller,User_Login
    {
      
        private readonly SignInManager<IdentityUser> signinmanager;
        
        private readonly ILogger<LoginUController> _logger;


       // private const string _clientId = "e1fdb5eb-6bd3-4bfb-bc5b-7f27ded1e0dc";
       // private const string _tenantId = "2dc3504f-2cc8-4780-b87d-bcc5f892d9d9";



        public LoginUController(SignInManager<IdentityUser> signInManager,ILogger<LoginUController> logger)
        {
           
            this.signinmanager = signInManager;
           
            this._logger = logger;

        }

        [HttpGet]
        public ActionResult Loginpage()
        {
           
          return View();
        }

        [HttpPost]
        [ActionName("Loginpage")]
      /* public async Task<ActionResult> Loginpage(Login ln, string returnUrl = null)
        {

            var app = PublicClientApplicationBuilder
                .Create(_clientId)
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
                .WithRedirectUri("https://localhost:7011/Home")
                .Build();
            string[] scopes = { "user.read" };
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

            Console.WriteLine($"Token:\t{result.AccessToken}");

            return View(result);*/

         



              public  async Task<ActionResult> Loginpage(Login ln,string returnUrl= null)
              {
                  try
                  {
                      returnUrl = returnUrl ?? Url.Content("~/");
                      ln.done = false;

                      if (!ModelState.IsValid)// && ln.Password != null && ln.FirstName != null)
                      {
                          var result = await this.signinmanager.PasswordSignInAsync(ln.FirstName, ln.Password, ln.RememberMe, false);

                          if (result.Succeeded)
                          {
                              if (returnUrl == null || returnUrl == "/")
                              {
                                  _logger.LogInformation("User logged in.");
                                  return RedirectToAction("Index", "Home", new { area = "" });
                              }
                              else
                              {
                                  _logger.LogInformation("Incorrect Username or Password!");
                                  ModelState.AddModelError("", "The user name or password provided is incorrect.");
                                  return RedirectToAction("Loginpage", "LoginU", new { area = "" });
                              }
                          }
                          else
                          {
                              ModelState.AddModelError("", "The user name or password provided is incorrect.");
                              return RedirectToAction("Loginpage", "LoginU", new { area = "" });

                          }
                      }
                      else
                      {
                          ln.done = true;
                          return RedirectToAction("Loginpage", "LoginU", new { area = "" });

                      }

                  }
                  catch (Exception ex)
                  {
                      Console.WriteLine(ex.ToString());
                  }

                  return View();

              }

              public ActionResult Forgotpassword(Forgotpassword model)
             {
            
                  if (ModelState.IsValid)
                 {
                     ModelState.Clear();

                      model.Emailsent = true;
                 }
              return View(model);
    
             }

    }
}
