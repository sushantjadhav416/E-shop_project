using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_shop.Models
{
    public class Register
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
       public string Email { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [Compare(nameof(Password),ErrorMessage ="Password and confirmation password did not Match!")]
        public string Checkpassword { get; set; }

      
    }
}
