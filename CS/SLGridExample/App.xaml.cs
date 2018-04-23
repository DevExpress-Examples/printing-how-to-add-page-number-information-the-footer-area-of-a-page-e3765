// Developer Express Code Central Example:
// Printing: How to add page number information the footer area of a page
// 
// This example shows how to add a page number to every page when printing a
// DXGrid. You'll need to prepare a custom page footer template and place a
// TextEdit control that will display the current page number within it. Note that
// the TextEdit should be properly adjusted by setting required dxp:ExportSettings
// (http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingExportSettingsMembersTopicAll),
// dxp:PageNumberExportSettings.Kind
// (http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingPageNumberExportSettings_Kindtopic)
// and dxp:PageNumberExportSettings.Format
// (http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingPageNumberExportSettings_Formattopic)
// properties. Next, assign this custom page footer template to the
// PrintableControlLink.PageFooterTemplate property during export.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3765

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SLGridExample {
    public partial class App : Application {

        public App() {
            this.Startup += this.Application_Startup;
            this.Exit += this.Application_Exit;
            this.UnhandledException += this.Application_UnhandledException;

            InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e) {
            if (string.Compare("file", Host.Source.Scheme, StringComparison.InvariantCultureIgnoreCase) == 0) {
                const string message = "Please set the Web project of this solution as the starting project.";
                MessageBox.Show(message);
                return;
            }
            this.RootVisual = new MainPage();
        }

        private void Application_Exit(object sender, EventArgs e) {

        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e) {
            // If the app is running outside of the debugger then report the exception using
            // the browser's exception mechanism. On IE this will display it a yellow alert 
            // icon in the status bar and Firefox will display a script error.
            if (!System.Diagnostics.Debugger.IsAttached) {

                // NOTE: This will allow the application to continue running after an exception has been thrown
                // but not handled. 
                // For production applications this error handling should be replaced with something that will 
                // report the error to the website and stop the application.
                e.Handled = true;
                Deployment.Current.Dispatcher.BeginInvoke(delegate { ReportErrorToDOM(e); });
            }
        }

        private void ReportErrorToDOM(ApplicationUnhandledExceptionEventArgs e) {
            try {
                string errorMsg = e.ExceptionObject.Message + e.ExceptionObject.StackTrace;
                errorMsg = errorMsg.Replace('"', '\'').Replace("\r\n", @"\n");

                System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(\"Unhandled Error in Silverlight Application " + errorMsg + "\");");
            } catch (Exception) {
            }
        }
    }
}
