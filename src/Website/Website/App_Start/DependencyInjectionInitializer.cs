using System.Collections.Generic;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Data;
using Data.Dto;
using Data.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace Website
{
    public class DependencyInjectionInitializer
    {
        public static void ConfigureDependencyInjection()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register<IWriteStoreDataContext, WriteStoreDataContext>(Lifestyle.Scoped);
            container.Register<IWriteStore, WriteStore>(Lifestyle.Scoped);
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(), Lifestyle.Scoped);
            container.Register(() =>
                container.IsVerifying()
                    ? new OwinContext(new Dictionary<string, object>()).Authentication
                    : HttpContext.Current.GetOwinContext().Authentication, Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();


            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}