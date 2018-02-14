using System.Web;
using System.Web.Optimization;

namespace Axessories
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/js/vendors/modernizr.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/css-contents").Include(

                "~/Content/css/bootstrap.min.css",
                "~/Content/css/ionicons.min.css",
                "~/Content/css/main.css",
                "~/Content/css/style.css",
                "~/Content/css/responsive.css"
                ));
            bundles.Add(new ScriptBundle("~/Contents/js").Include(
                "~/Content/js/vendors/jquery/jquery.min.js",
                "~/Content/js/vendors/wow.min.js",
                "~/Content/js/vendors/bootstrap.min.js",
                "~/Content/js/vendors/own-menu.js",
                "~/Content/js/vendors/jquery.sticky.js",
                "~/Content/js/vendors/owl.carousel.min.js",
                "~/Content/rs-plugin/js/jquery.tp.t.min.js",
                "~/Content/rs-plugin/js/jquery.tp.min.js",
                "~/Content/js/main.js"
                ));

            bundles.Add(new StyleBundle("~/Index/css").Include(
                "~/Content/css/font-awesome.min.css"
                ));
        }
    }
}
