using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Widgets.MyCustomPlugin.Controllers
{
    public class TestMyCustomPluginController : BasePluginController
    {
        public TestMyCustomPluginController()
        {

        }


        public IActionResult Index()
        {
            return View("~/Plugins/Widgets.MyCustomPlugin/Views/Index.cshtml");
        }

    }
}
