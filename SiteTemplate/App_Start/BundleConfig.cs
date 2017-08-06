using System.Web;
using System.Web.Optimization;

namespace SiteTemplate
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js","~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css","~/Content/site.css"));

            //Add Material-Kit Files
            // /assets/material-kit-scripts
            bundles.Add(new ScriptBundle("~/assets/material-kit-scripts").Include(
                            "~/assets/js/jquery.min.js", 
                            "~/assets/js/bootstrap.min.js", 
                            "~/assets/js/material.min.js", 
                            "~/assets/js/bootstrap-datepicker.js", 
                            "~/assets/js/nouislider.js", 
                            "~/assets/js/material-kit.js"
                       ));
            // /assets/material-kit-styles
            bundles.Add(new StyleBundle("~/assets/material-kit-styles").Include(
                            "~/assets/css/bootstrap.min.css",
                            "~/assets/css/material-kit.css", 
                            "~/assets/css/demo-kit.css",
                            "~/assets/css/styles.css"
                       ));
        }
    }
}
