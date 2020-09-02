using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Widgets.MyCustomPlugin.Infrastructure
{
    /// <summary>
    /// Represents plugin route provider
    /// </summary>
    class RouteProvider : IRouteProvider
    {


        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapControllerRoute("MyCustomPluginRoute", "Plugins/TestMyCustomPlugin/Index",
                new { controller = "TestMyCustomPlugin", action = "Index" });
        }

        public int Priority => 0;
    }
}
