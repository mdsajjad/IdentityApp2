using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp2.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the IdentityApp2User class
    public class IdentityApp2User : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }

        public bool IsAdmin { get; set; }
    }
}
