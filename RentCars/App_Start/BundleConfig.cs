using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Web;
using System.Web.Optimization;

namespace RentCars.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)



        {

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker/js").Include("~/Vendors/bootstrap-datepicker.js"));
            bundles.Add(new ScriptBundle("~/bundles/google-map/js").Include("~/Vendors/google-map.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-3.2.1.min/js").Include("~/Vendors/jquery-3.2.1.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-migrate-3.0.1.min/js").Include("~/Vendors/jquery-migrate-3.0.1.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.animateNumber.min/js").Include("~/Vendors/jquery.animateNumber.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.easing.1.3/js").Include("~/Vendors/jquery.easing.1.3.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.magnific-popup.min/js").Include("~/Vendors/jquery.magnific-popup.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.min/js").Include("~/Vendors/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.stellar.min/js").Include("~/Vendors/jquery.stellar.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.timepicker.min/js").Include("~/Vendors/jquery.timepicker.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.waypionts.min/js").Include("~/Vendors/jquery.waypoints.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include("~/Vendors/main.js"));
            bundles.Add(new ScriptBundle("~/bundles/owl.carousel.min/js").Include("~/Vendors/owl.carousel.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/popper.min/js").Include("~/Vendors/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/range/js").Include("~/Vendors/range.js"));
            bundles.Add(new ScriptBundle("~/bundles/scrollax.min/js").Include("~/Vendors/scrollax.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap.min/js").Include("~/Vendors/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/aos/js").Include("~/Vendors/aos.js"));


            bundles.Add(new StyleBundle("~/bundles/_text-hide/css").Include("~/Vendors/_text-hide.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/animate/css").Include("~/Vendors/animate.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/aos/css").Include("~/Vendors/aos.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap-datepicker/css").Include("~/Vendors/bootstrap-datepicker.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap-grid/css").Include("~/Vendors/bootstrap-grid.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap-reboot/css").Include("~/Vendors/bootstrap-reboot.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Vendors/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/flaticon/css").Include("~/Vendors/flaticon.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/icomoon/css").Include("~/Vendors/isomoon.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/ionicons/css").Include("~/Vendors/ionicons.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/jquery.timepicker/css").Include("~/Vendors/jquery.timepicker.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/magnific-popup/css").Include("~/Vendors/magnific-popup.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/open-iconic-bootstrap/css").Include("~/Vendors/open-iconic-bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/owl.carousel/css").Include("~/Vendors/owl.carousel.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/owl.theme.default/css").Include("~/Vendors/owl.theme.default.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Vendors/style.css", new CssRewriteUrlTransform()));




        }



    }
}