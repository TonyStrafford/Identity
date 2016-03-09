using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Identity.Models
{
    // The Entity Framework uses a class called IdentityRole to implement the IRole interface,
    // we create an application-specific role class that is derived from IdentityRole to provide an abstraction.
    public class AppRole : IdentityRole
    {
        public AppRole() : base()
        {

        }

        public AppRole(string name) : base(name)
        {
            
        }
    }
}
