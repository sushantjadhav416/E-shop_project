using System.ComponentModel.DataAnnotations;

namespace E_shop.Models
{
    public class Forgotpassword
    {
        [Required,EmailAddress,Display(Name ="Forgot password")]
        public string Email { get; set; }

        public bool Emailsent { get; set; }

    }
}
