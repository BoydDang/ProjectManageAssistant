using System.Web.Optimization;

namespace ProjectManageAssistant.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendo/2012.3.1315/jquery.min.js",
                "~/Scripts/kendo/2012.3.1315/kendo.all.min.js",
                "~/Scripts/kendo/2012.3.1315/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                "~/Content/kendo/2012.3.1315/kendo.common.min.css",
                "~/Content/kendo/2012.3.1315/kendo.default.min.css",
                "~/Content/kendo/2012.3.1315/kendo.bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}