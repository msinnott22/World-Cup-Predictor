using System.Web;
using System.Web.Optimization;

namespace Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.0.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/popper.js",
                      "~/Scripts/respond.js",
                      "~/node_modules/metismenu/dist/metisMenu.min.js",
                      "~/node_modules/datatables/media/js/jquery.dataTables.min.js",
                      "~/Scripts/sb-admin-2.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/node_modules/metismenu/dist/metisMenu.min.css",      
                      "~/Content/sb-admin-2.min.css",
                      "~/Content/site.css",
                      "~/node_modules/flag-icon-css/css/flag-icon.min.css",
                      "~/node_modules/font-awesome/css/font-awesome.min.css",
                      "~/node_modules/datatables/media/css/jquery.dataTables.min.css"));
        }
    }
}
