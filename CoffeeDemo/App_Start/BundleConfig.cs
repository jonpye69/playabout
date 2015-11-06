﻿using System.Web;
using System.Web.Optimization;

namespace CoffeeDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.signalR-2.2.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // Bundle up angular
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.min.js"));

            // Bundle up all our custom angular scripts
            bundles.Add(new ScriptBundle("~/bundles/angular-custom").IncludeDirectory(
                "~/app", "*.js", true));

            // Any new css created, bundle here **************
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/CoffeeDemo.css"));

            // Bundle up any of our custom js scripts
            bundles.Add(new ScriptBundle("~/bundles/custom-scripts").Include(
          "~/Scripts/Custom/CoffeeDemo.js",
          "~/Scripts/SignalR/HospitalData.js"));        
        }
    }
}
