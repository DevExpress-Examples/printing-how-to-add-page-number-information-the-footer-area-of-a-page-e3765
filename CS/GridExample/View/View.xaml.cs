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
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Core;
using System.Diagnostics;


namespace GridExample {
    public partial class View : UserControl {
        public View() {
            InitializeComponent();
        }

        private void ShowPrintPreviewButton_Click(object sender, RoutedEventArgs e) {
            DocumentPreview preview = new DocumentPreview();
            PrintableControlLink link = new PrintableControlLink(grid.View as IPrintableControl);
            link.PageFooterTemplate = (DataTemplate)this.Resources["pageFooterTemplate"];

#if SILVERLIGHT
            link.ExportServiceUri = "../ExportService.svc";
#endif
            LinkPreviewModel model = new LinkPreviewModel(link);
            preview.Model = model;

            link.CreateDocument(true);
            DXDialog dlg = new DXDialog();
            dlg.Content = preview;
            dlg.Height = 640;
            dlg.Left = 150;
            dlg.Top = 150;
            dlg.ShowDialog();
        }
    }
}
