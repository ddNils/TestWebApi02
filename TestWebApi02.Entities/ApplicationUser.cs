using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using TestWebApi02.DataContracts;

namespace TestWebApi02.Entities
{

    public class ApplicationUser : IdentityUser<string, IdentityUserLogin<string>, IdentityUserRole<string>, IdentityUserClaim<string>>, IApplicationUser
    {
        public ApplicationUser()
        {
            this.preferredColor = "#66CC33"; // schickes grün
        }

        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        //{
        //    // Beachten Sie, dass der "authenticationType" mit dem in "CookieAuthenticationOptions.AuthenticationType" definierten Typ übereinstimmen muss.
        //    var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
        //    // Benutzerdefinierte Benutzeransprüche hier hinzufügen
        //    return userIdentity;
        //}

        [System.ComponentModel.DataAnnotations.MaxLength(12)]
        public string preferredColor { get; set; }
    }
}
