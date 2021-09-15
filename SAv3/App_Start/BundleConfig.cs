﻿using System.Web;
using System.Web.Optimization;

namespace SAv3
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/css/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/cubeportfolio.min.css",
                      "~/css/font-awesome.css",
                      "~/css/jquery.fancybox.min.css",
                      "~/css/magnific-popup.min.css",
                      "~/css/owl-carousel.min.css",
                      "~/css/slicknav.min.css",
                      "~/css/responsive.css",
                      "~/css/reset.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css"));
        }
    }
}
