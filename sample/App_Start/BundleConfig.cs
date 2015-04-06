using System.Web.Optimization;

namespace sample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        , "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.js",
                      //"~/Scripts/angular-animate.js",
                      //"~/Scripts/textAngular-sanitize.js",
                      "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                      "~/Scripts/angular-ui-router.js",
                      //"~/Scripts/jasny-bootstrap.js",
                      //"~/Scripts/textAngular.js",
                      //"~/Scripts/textAngularSetup.js",
                      //"~/Scripts/rangy-core.js",
                      //"~/Scripts/rangy-selectionsaverestore.js"
                      "~/Scripts/lodash.js"
                      ));


            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Src/app.module.js",
                        "~/Src/app.controller.js",
                        "~/Src/home/home.module.js",
                        "~/Src/home/home.service.js",
                        "~/Src/home/home.controller.js"
                        ));

            bundles.Add(new LessBundle("~/Content/less").Include(
                      "~/Content/bootstrap/bootstrap.less"
                      ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
