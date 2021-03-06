﻿using System.Web;
using System.Web.Optimization;
using System.Web.Razor.Parser;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/datatables/jquery.datatables.js",
                        "~/Scripts/datatables/datatables.bootstrap.js",
                       
                      "~/Scripts/respond.js"
                       
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //           "~/Scripts/bootbox.js"
            //          ));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap-luman.css",
            //            //  "~/Content/bootstrap.css",
            //          "~/Content/bootstrap-theme.css",
            //          "~/Content/datatables/css/datatables.bootstrap.css",

            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap-lumen.css",
                    // "~/Content/bootstrap-theme.css",
                     "~/content/datatables/css/datatables.bootstrap.css",
                     //"~/content/typeahead.css",
                     //"~/content/toastr.css",
                     "~/Content/site.css"));
        }
    }
}
