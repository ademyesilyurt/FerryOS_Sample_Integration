using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/assets/bundlecss").Include(
                                       "~/assets/css/bootstrap.min.css",
                                       "~/assets/css/font-awesome.min.css",
                                       "~/assets/css/style.css",
                                       "~/assets/css/lightblue.css",
                                       "~/assets/css/responsive.css",
                                       "~/assets/css/flexslider.css",
                                       "~/assets/css/magnific-popup.css"));

            bundles.Add(new ScriptBundle("~/assets/bundlejs").Include(
                                        "~/assets/js/jquery.min.js",
                                        "~/assets/js/jquery.mask.js",
                                        "~/assets/js/bootstrap.min.js",
                                        "~/assets/js/jquery.flexslider.js",
                                        "~/assets/js/custom-navigation.js",
                                        "~/assets/js/custom-flex.js",
                                        "~/assets/js/AjaxBuilder.js",
                                        "~/assets/js/Script.js",
                                        "~/assets/js/View/Common.js",
                                          "~/assets/js/jquery.datetimepicker.js"
                             ));
            BundleTable.EnableOptimizations = true;

        }
    }
}
