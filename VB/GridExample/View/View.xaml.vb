Imports Microsoft.VisualBasic
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
			link.PageFooterTemplate = CType(Me.Resources("pageFooterTemplate"), DataTemplate)

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
