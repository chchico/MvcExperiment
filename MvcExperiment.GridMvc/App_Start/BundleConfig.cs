using System.Web;
using System.Web.Optimization;

namespace MvcExperiment.GridMvc
{
    public class BundleConfig
    {
        // バンドルの詳細については、http://go.microsoft.com/fwlink/?LinkId=301862  を参照してください
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.ui.*"));

            // 開発と学習には、Modernizr の開発バージョンを使用します。次に、実稼働の準備が
            // できたら、http://modernizr.com にあるビルド ツールを使用して、必要なテストのみを選択します。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/gridmvc").Include(
                      "~/Scripts/gridmvc.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/mycommon").Include(
                      "~/Scripts/my-common.js"));

            bundles.Add(new StyleBundle("~/Content/themes/base/ui").Include(
                    "~/Content/themes/base/core.css",
                    "~/Content/themes/base/accordion.css",
                    "~/Content/themes/base/autocomplete.css",
                    "~/Content/themes/base/button.css",
                    "~/Content/themes/base/datepicker.css",
                    "~/Content/themes/base/dialog.css",
                    "~/Content/themes/base/draggable.css",
                    "~/Content/themes/base/menu.css",
                    "~/Content/themes/base/progressbar.css",
                    "~/Content/themes/base/resizable.css",
                    "~/Content/themes/base/selectable.css",
                    "~/Content/themes/base/selectmenu.css",
                    "~/Content/themes/base/sortable.css",
                    "~/Content/themes/base/slider.css",
                    "~/Content/themes/base/spinner.css",
                    "~/Content/themes/base/tabs.css",
                    "~/Content/themes/base/tooltip.css",
                    "~/Content/themes/base/theme.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/site.css",
                    "~/Content/Gridmvc.css"));
        }
    }
}
