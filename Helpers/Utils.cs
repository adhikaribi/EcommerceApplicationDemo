using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using Service.Interfaces;
using Services;
using System.Web.Mvc;

namespace Helpers
{
    public static class Utils
    {
        public static void BindInSingletonScope<T1, T2>(this IUnityContainer container) where T2 : T1
        {
            container.RegisterType<T1, T2>(new ContainerControlledLifetimeManager());
        }
    }

    public class UnityMvc
    {
        public static void Start()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.BindInSingletonScope<ICategoryRepository, CategoryRepository>();
            container.BindInSingletonScope<IProductRepository, ProductRepository>();
            container.BindInSingletonScope<ICartRepository, CartRepository>();
            container.BindInSingletonScope<ICategoryService, CategoryService>();
            container.BindInSingletonScope<IProductService, ProductService>();
            container.BindInSingletonScope<ICartService, CartService>();
            return container;
        }
    }
}
