using System.Web.Optimization;

namespace ProjectManageAssistant.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-ui/jquery-1.6.4.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //            "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendo/jquery.min.js",
                "~/Scripts/kendo/kendo.all.min.js",
                "~/Scripts/kendo/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                "~/Content/kendo/kendo.common.min.css",
                "~/Content/kendo/kendo.default.min.css",
                "~/Content/kendo/kendo.bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                "~/Scripts/jquery-ui/jquery-1.6.4.min.js",
                "~/Scripts/jquery-ui/jquery.ui.core.min.js",
                "~/Scripts/jquery-ui/jquery.ui.widget.min.js",
                "~/Scripts/jquery-ui/jquery.ui.accordion.min.js",
                "~/Scripts/jquery-ui/jquery.effects.core.min.js",
                "~/Scripts/jquery-ui/jquery.effects.slide.min.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}