using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AngularMVC {

    public class BundleConfig {

        public static void RegisterBundles(BundleCollection bundles) {
            // setup some variables
            const string STYLES_ROOT = "~/Content/";
            const string SCRIPTS_ROOT = "~/Scripts/";
            const string ANGULAR_APP_ROOT = "~/App/";

            // register the core styles bundle
            var coreStyles = new Bundle(STYLES_ROOT + "core")
                .Include(STYLES_ROOT + "bulma.css")
                .Include(STYLES_ROOT + "site.css");

            // register the core scripts bundle
            // note; using min version of popper prevents an exception in the console!
            var coreScripts = new Bundle(SCRIPTS_ROOT + "core")
                .Include(SCRIPTS_ROOT + "jquery.js")
                .Include(SCRIPTS_ROOT + "popper.min.js")
                .Include(SCRIPTS_ROOT + "moment.js")
                .Include(SCRIPTS_ROOT + "master.js")
                .Include(SCRIPTS_ROOT + "angular.js")
                .Include(SCRIPTS_ROOT + "ui-router.js")
                .Include(SCRIPTS_ROOT + "angular-animate.js")
                .Include(SCRIPTS_ROOT + "angular-aria.js")
                .Include(SCRIPTS_ROOT + "angular-sanatize.js")
                .Include(SCRIPTS_ROOT + "angular-messages.js")
                .Include(SCRIPTS_ROOT + "angular-cookies.js")
                .Include(SCRIPTS_ROOT + "angular-filter.js")
                .Include(SCRIPTS_ROOT + "angular-moment-picker.js");
            
            // render our custom scripts
            var scripts = new ScriptBundle(ANGULAR_APP_ROOT + "main")
                .Include(ANGULAR_APP_ROOT + "app.js")
                .Include(ANGULAR_APP_ROOT + "http.js")
                .Include(ANGULAR_APP_ROOT + "routes.js")
                .IncludeDirectory(ANGULAR_APP_ROOT, "*.js", searchSubdirectories: true);

            // include the bundles
            bundles.Add(coreStyles);
            bundles.Add(coreScripts);
            bundles.Add(scripts);

            // note; you want to change this to true, if you want your files to minify
            BundleTable.EnableOptimizations = false;
        }
    }
}