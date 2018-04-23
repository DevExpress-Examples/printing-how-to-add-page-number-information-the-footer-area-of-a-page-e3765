' Developer Express Code Central Example:
' Printing: How to add page number information the footer area of a page
' 
' This example shows how to add a page number to every page when printing a
' DXGrid. You'll need to prepare a custom page footer template and place a
' TextEdit control that will display the current page number within it. Note that
' the TextEdit should be properly adjusted by setting required dxp:ExportSettings
' (http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingExportSettingsMembersTopicAll),
' dxp:PageNumberExportSettings.Kind
' (http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingPageNumberExportSettings_Kindtopic)
' and dxp:PageNumberExportSettings.Format
' (http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingPageNumberExportSettings_Formattopic)
' properties. Next, assign this custom page footer template to the
' PrintableControlLink.PageFooterTemplate property during export.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3765

Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Core
Imports System.Diagnostics


Namespace GridExample
    Partial Public Class View
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ShowPrintPreviewButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim preview As New DocumentPreview()
            Dim link As New PrintableControlLink(TryCast(grid.View, IPrintableControl))
            link.PageFooterTemplate = DirectCast(Me.Resources("pageFooterTemplate"), DataTemplate)

#If SILVERLIGHT Then
            link.ExportServiceUri = "../ExportService.svc"
#End If
            Dim model As New LinkPreviewModel(link)
            preview.Model = model

            link.CreateDocument(True)
            Dim dlg As New DXDialog()
            dlg.Content = preview
            dlg.Height = 640
            dlg.Left = 150
            dlg.Top = 150
            dlg.ShowDialog()
        End Sub
    End Class
End Namespace
