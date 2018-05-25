using System.Reflection;
using System.Web.Mvc;
using Data;
using Data.Interfaces;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace Website
{
    public class DependencyInjection
    {
        public static void ConfigureDependencyInjection()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register<IWriteStoreDataContext, WriteStoreDataContext>(Lifestyle.Scoped);
            container.Register<IWriteStore, WriteStore>(Lifestyle.Scoped);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();


            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}