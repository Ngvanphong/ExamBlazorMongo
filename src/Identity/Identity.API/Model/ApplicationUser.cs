
using Microsoft.AspNetCore.Identity;

namespace Identity.API.Model
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName{set;get;}
        public string LastName{set;get;}
        
    }
}