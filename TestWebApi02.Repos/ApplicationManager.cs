using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TestWebApi02.Entities;

namespace TestWebApi02.Repos
{
    public class ApplicationUserStore : IUserStore<ApplicationUser>
    {
        private ApplicationDbContext _ctx;

        public ApplicationUserStore(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public Task CreateAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
                }

                // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // TODO: große Felder auf Null setzen.

                disposedValue = true;
            }
        }

        // TODO: Finalizer nur überschreiben, wenn Dispose(bool disposing) weiter oben Code für die Freigabe nicht verwalteter Ressourcen enthält.
        // ~ApplicationUserStore() {
        //   // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
        //   Dispose(false);
        // }

        // Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
            Dispose(true);
            // TODO: Auskommentierung der folgenden Zeile aufheben, wenn der Finalizer weiter oben überschrieben wird.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }



    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store): base(store)
        {
        }
        
        public ApplicationUserManager GetUserManager(ApplicationDbContext ctx)
        {
            var manager = new ApplicationUserManager(new ApplicationUserStore(ctx));

            manager.UserValidator = new UserValidator<ApplicationUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };
            
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };

            // Durch das Ausblenden wird wahrscheinlich kein Password-Recovery möglich sein :(
            //var dataProtectionProvider = options.DataProtectionProvider;
            //if (dataProtectionProvider != null)
            //{
            //    manager.UserTokenProvider = new DataProtectorTokenProvider<ApplicationUser>(dataProtectionProvider.Create("ASP.NET Identity"));
            //}

            return manager;
        }
    }
    


    ////public UserStore 
    //public class UserStore : IUserStore<IdentityUser>
    //{
    //    private ApplicationDbContext _ctx;

    //    public UserStore(ApplicationDbContext ctx)
    //    {
    //        _ctx = ctx;
    //    }

    //    public Task CreateAsync(IdentityUser user)
    //    {
    //        _ctx.Users.Add(user);
    //        return _ctx.SaveChangesAsync();
    //    }

    //    public Task DeleteAsync(IdentityUser user)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<IdentityUser> FindByIdAsync(string userId)
    //    {
    //        return _ctx.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
    //    }

    //    public Task<IdentityUser> FindByNameAsync(string userName)
    //    {
    //        return _ctx.Users.Where(u => u.UserName == userName).FirstOrDefaultAsync();
    //    }

    //    public Task UpdateAsync(IdentityUser user)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #region IDisposable Support
    //    private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!disposedValue)
    //        {
    //            if (disposing)
    //            {
    //                // TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
    //            }

    //            // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
    //            // TODO: große Felder auf Null setzen.

    //            disposedValue = true;
    //        }
    //    }

    //    // TODO: Finalizer nur überschreiben, wenn Dispose(bool disposing) weiter oben Code für die Freigabe nicht verwalteter Ressourcen enthält.
    //    // ~UserStore() {
    //    //   // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
    //    //   Dispose(false);
    //    // }

    //    // Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
    //    public void Dispose()
    //    {
    //        // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
    //        Dispose(true);
    //        // TODO: Auskommentierung der folgenden Zeile aufheben, wenn der Finalizer weiter oben überschrieben wird.
    //        // GC.SuppressFinalize(this);
    //    }
        

    //}
}
