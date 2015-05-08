using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using UI.App_Start;
using System.Web.Optimization;

[assembly: OwinStartup(typeof(UI.Startup))]

namespace UI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
