using System.ComponentModel.DataAnnotations;

namespace E_shop.Models
{
    public class Login
    {
        [Required]
       // [DataType(DataType.EmailAddress)]
        public String FirstName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
