using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using Persistence.Interfaces;
using Persistence.Repositories;

namespace WebShopSite
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new
            UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IProductRepository, ProductMemoryRepository>("ProductMemoryRepository");
            container.RegisterType<IProductRepository, ProductRepository>("ProductRepository");
        }
    }
}