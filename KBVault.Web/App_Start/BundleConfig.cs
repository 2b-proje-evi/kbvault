﻿using System.Web;
using System.Web.Optimization;

namespace KBVault.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            BundleTable.EnableOptimizations = false;
            
            bundles.Add(new ScriptBundle("~/public/js").Include(
                "~/Assets/js/jquery/jquery-2-0-2.js",
                "~/Assets/js/jquery/jquery-ui-1-10-4.js",
                "~/Assets/js/bootstrap/bootstrap.js",
                "~/Assets/js/plugins/cookie/jquery.cookie.js",
                "~/Assets/js/frontend.js",
                "~/Assets/js/smartmenus/jquery.smartmenus.js", 
                "~/Assets/js/smartmenus/jquery.smartmenus.bootstrap.js",                
                "~/Assets/js/smartmenus/jquery.smartmenus.keyboard.js"
            ));
                       
            bundles.Add( new StyleBundle("~/public/css").Include(
                "~/Assets/css/plugins.css", 
                "~/Assets/css/site.css",                 
                "~/Assets/css/jquery-ui/jquery-ui-redmond.css"              
                ));                                               

            bundles.Add(new ScriptBundle("~/admin/js").Include(
                "~/Assets/js/jquery/jquery-2-0-2.js",
                "~/Assets/js/jquery/jquery-ui-1-10-4.js",
                "~/Assets/js/bootstrap/bootstrap.js",
                "~/Assets/js/plugins/x-editable/xeditable.js",
                "~/Assets/js/plugins/slug-it/jquery.slugit.js",                                
                "~/Assets/js/plugins/tag-it/tag-it.js",
                "~/Assets/datatables/js/jquery.dataTables.js",
                "~/Assets/js/plugins/uploader/jquery.uploadfile.js",
                "~/Assets/js/AdminLTE/app.js",
                "~/Assets/ckeditor/ckeditor.js",
                "~/Assets/js/kbvault.js"
                ));
            
            bundles.Add(new StyleBundle("~/admin/css").Include(
                "~/Assets/css//plugins.css", 
                "~/Assets/css/jquery-ui/jquery-ui-redmond.css", 
                "~/Assets/css/AdminLTE.css",
                "~/Assets/css/uploadfile.css",                
                "~/Assets/datatables/css/jquery.dataTables.css",
                "~/Assets/datatables/css/jquery.dataTables_themeroller.css",
                "~/Assets/datatables/css/jquery.datatables.bootstrap.css"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            /*
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            */
            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            
        }
    }
}