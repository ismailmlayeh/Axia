using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiworkflow.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string role { get; set; }

        public int? idrole { get; set; }


    }
}
