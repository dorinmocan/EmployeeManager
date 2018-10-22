using Autofac;
using Autofac.Integration.WebApi;
using EmployeeManager.Controllers;
using EmployeeManager.Databases;
using EmployeeManager.Repositories;
using EmployeeManager.Services;
using System.Reflection;
using System.Web.Http;

namespace EmployeeManager.IoCContainerConfig
{
    public static class IoCContainer
    {
        public static IContainer Container;
            
        public static void Config()
        {
            ContainerBuilder builder = new ContainerBuilder();
            HttpConfiguration config = GlobalConfiguration.Configuration;

            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<EmployeesController>();
            builder.RegisterType<EmployeesService>();
            builder.RegisterType<EmployeesRepository>();
            builder.RegisterType<EmployeeDbContext>();

            Container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);
        }
    }
}