using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace UI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular")
                .IncludeDirectory("~/Scripts", ".js", true));

            bundles.Add(new ScriptBundle("~/bundles/blogApp")
               .IncludeDirectory("~/app", ".js", true));
        }
    }
}