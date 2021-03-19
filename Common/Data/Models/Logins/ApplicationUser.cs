using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;


namespace Common.Data.Models.Logins
{
    public class ApplicationUser : IdentityUser
    {
        public string FormalName { get; set; }
    }
}
