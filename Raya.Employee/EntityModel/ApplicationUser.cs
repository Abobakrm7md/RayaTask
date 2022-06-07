using Microsoft.AspNet.Identity.EntityFramework;

namespace Raya.Employee.EntityModel
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
    }
}