using System.Web.Mvc;
using Taif.Services.ProductService;
using Unity;
using Unity.Mvc5;

namespace Taif.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
               
           container.RegisterType<IproductService, ProductService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}