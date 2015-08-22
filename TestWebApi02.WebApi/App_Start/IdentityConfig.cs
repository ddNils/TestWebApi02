using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using TestWebApi02.Entities;

namespace TestWebApi02.WebApi
{
    // Konfigurieren des in dieser Anwendung verwendeten Anwendungsbenutzer-Managers. UserManager wird in ASP.NET Identity definiert und von der Anwendung verwendet.

    //public class ApplicationUserManager : UserManager<ApplicationUser>
    //{
    //    public ApplicationUserManager(IUserStore<ApplicationUser> store)
    //        : base(store)
    //    {
    //        this.u
    //    }

    //    public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
    //    {
    //        Repos.IdentityRepository ctx = context.Get<Repos.IdentityRepository>();

    //        var manager = ctx.GetUserManager();


    //        // Konfigurieren der Überprüfungslogik für Kennwörter.

    //        return manager;
    //    }
    //}
}
