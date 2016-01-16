using System.Web;
using System.Web.Optimization;

namespace mustafabuyukcelebi.net
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/plugins/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/plugins/jquery/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/plugins/jquery/jquery-ui/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/Scripts/plugins/jquery-ui/jqueryuiStyles").Include(
                        "~/Scripts/plugins/jquery/jquery-ui/jquery-ui.css"));

            bundles.Add(new ScriptBundle("~/plugins/slimScroll").Include(
                      "~/Scripts/plugins/slimscroll/jquery.slimscroll.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/plugins/angularjs/angular.min.js",
                      "~/Scripts/plugins/angularjs/angular-resource.min.js",
                      "~/Scripts/plugins/angularjs/angular-route.min.js",
                      "~/Scripts/Angular/*.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                      "~/fonts/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            // Inspinia skin config script
            bundles.Add(new ScriptBundle("~/bundles/skinConfig").Include(
                      "~/Scripts/app/skin.config.min.js"));

            // Inspinia script
            bundles.Add(new ScriptBundle("~/bundles/inspinia").Include(
                      "~/Scripts/plugins/metisMenu/metisMenu.min.js",
                      "~/Scripts/plugins/pace/pace.min.js",
                      "~/Scripts/app/inspinia.min.js"));

            // CSS style (bootstrap/inspinia)
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/animate.css",
                      "~/Content/style.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
