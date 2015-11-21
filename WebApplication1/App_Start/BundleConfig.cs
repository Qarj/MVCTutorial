using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jqueryValidation").Include(
                        "~/Scripts/jquery-1.8.0.js").Include(
                        "~/Scripts/jquery.validate.js").Include(
                        "~/Scripts/jquery.validate.unobtrusive.js"));
        }
    }
}
