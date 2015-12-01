using System.Web;
using System.Web.Optimization;

namespace mywebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js/jquery").Include(
                        "~/Content/js/jquery-1.11.3.min.js",
                        "~/Content/js/jquery-migrate-1.2.1.js",
                        "~/Content/js/jquery.easytabs.min.js",
                        "~/Content/js/jquery.easing.1.3.js",
                        "~/Content/js/placeholders.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/js/owl").Include(
                "~/Content/js/owl.carousel.js"));

            bundles.Add(new ScriptBundle("~/bundles/js/main").Include(
                "~/Content/js/script.js"));

            bundles.Add(new ScriptBundle("~/bundles/js/modernizr").Include(
                        "~/Content/js/modernizr.js"));

            bundles.Add(new StyleBundle("~/bundles/css/owl").Include(
                "~/Content/css/owl-carousel/owl.carousel.css",
                "~/Content/css/owl-carousel/owl.theme.css"
            ));

            bundles.Add(new StyleBundle("~/bundles/css/magnific-popup").Include(
                "~/Content/css/magnific-popup.css"
                ));

            bundles.Add(new StyleBundle("~/bundles/css/fonts").Include(
                "~/Content/css/font.css",
                "~/Content/css/fontello.css"
                ));

            bundles.Add(new StyleBundle("~/bundles/css/main").Include(
                "~/Content/css/base.css",
                "~/Content/css/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap").Include(
                      "~/Content/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/bundles/css/bootstrap").Include(
                      "~/Content/css/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/js/magnific-popup").Include(
                "~/Content/js/jquery.magnific-popup.js"));

            bundles.Add(new StyleBundle("~/bundles/css/home/index").Include(
                "~/Content/css/pages/home/index.css"
                ));

            BundleTable.EnableOptimizations = false;
        }
    }
}
