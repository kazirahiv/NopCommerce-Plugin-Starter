using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Widgets.MyCustomPlugin.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        [NopResourceDisplayName("Plugin.Widgets.MyCustomPlugin.UseSandbox")]
        public bool UseSandbox { get; set; }
        [NopResourceDisplayName("Plugin.Widgets.MyCustomPlugin.Message")]
        public string Message { get; set; }
    }
}
