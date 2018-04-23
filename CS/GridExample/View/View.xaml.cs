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
