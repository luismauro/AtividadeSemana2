using System.Diagnostics;
using System.Web;
using System.Web.Optimization;

namespace GestãoComercial.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/js/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/js/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            #region [ Bootstrap ]
            bundles.Add(new ScriptBundle("~/js/bootstrap")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/respond.js")
                );

            bundles.Add(new StyleBundle("~/css/bootstrap")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css")
                );
            #endregion

            bundles.Add(new StyleBundle("~/css/site")
                .Include("~/Content/site.css")
                );

            //BundleTable.EnableOptimizations = !Debugger.IsAttached;
        }
    }
}
