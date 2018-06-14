using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using ProjetoModeloDDD.Infra.CrossCulting.IoC;
using ProjetoModeloDDD.MVC.App_Start;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using WebActivator;

[assembly: PostApplicationStartMethod(typeof(SingleInjectorInitializer), "Initialize")]
namespace ProjetoModeloDDD.MVC.App_Start
{
    /// <summary>
    /// Install-Package SimpleInjector
    /// Install-Package SimpleInjector.Integration.Web
    /// Install-Package SimpleInjector.Integration.Web.MVC
    /// Install-Package WebActivator -Version 1.5.3
    /// </summary>
    public static class SingleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            //Chamadas para os modulos Simple Injector
            InitializeContainer(container);
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.IsVerifying();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
        }
    }
}