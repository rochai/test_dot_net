using DBProject;
using DBProject.DAL;
using System.Web.Http;
using TestDotNet.Services;
using Unity;
using Unity.WebApi;

namespace TestDotNet
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUnitOfWork<RozTestEntities>, UnitOfWork<RozTestEntities>>();
            container.RegisterType<IRozTestService, RozTestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}