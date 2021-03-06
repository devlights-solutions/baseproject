﻿using System.Web;
using System.Web.Optimization;

namespace BaseProject.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-locale_es-ar.js",
                "~/Scripts/angular-sanitize.min.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                "~/Scripts/smart-table.min.js",
                "~/Scripts/select.js",
                "~/Scripts/spin.js",
                "~/Scripts/angular-spinner.js",
                "~/Scripts/json-format-date-fix.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/globalize")
                .Include("~/Scripts/globalize.js",
                    "~/Scripts/globalize.culture.es-AR.js",
                    "~/Scripts/globalize.init.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/jquery.validate.unobtrusive.extensions.js",
                "~/Scripts/jquery.validate.unobtrusive.custom.js",
                "~/Scripts/jquery.validate.fixes.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                 "~/Scripts/bootstrap.js",
                 "~/Scripts/bootstrap-datepicker.js",
                 "~/Scripts/bootstrap-datepicker.es.js",
                 "~/Scripts/fileinput.js",
                 "~/Scripts/fileinput_locale_es.js",
                 "~/Scripts/spin.min.js",
                 "~/Scripts/ImageUploadValidation.js",
                 "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/lib")
                .Include("~/Scripts/underscore.js")
                .Include("~/Scripts/select2.js")
                .Include("~/Scripts/autoNumeric-{version}.js")
                .Include("~/Scripts/jquery.sortable.js")
                .Include("~/Scripts/moment-with-locales.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular/app")
                .IncludeDirectory("~/app/", "*.module.js", true)
                .IncludeDirectory("~/app/", "*.filter.js", true)
                .IncludeDirectory("~/app/", "*.directive.js", true)
                .IncludeDirectory("~/app/", "*.service.js", true)
                .IncludeDirectory("~/app/", "*.controller.js", true)
                .Include("~/app/app.js")
                );

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/font-awesome.min.css",
                "~/Content/bootstrap-datepicker.css",
                "~/Content/ui-grid.min.css",
                "~/Content/select.min.css",
                "~/Content/site.css"));
        }
    }
}
