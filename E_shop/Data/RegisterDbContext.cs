using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace E_shop.Data
{
    public class RegisterDbcontext: IdentityDbContext
    {
        public RegisterDbcontext(DbContextOptions options) : base(options) {

        }

    }
}
