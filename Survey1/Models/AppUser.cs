using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey1.Models
{
    public class AppUser : IdentityUser
    {
        public override string UserName { get => base.UserName; set => base.UserName = value; }

    }
}
