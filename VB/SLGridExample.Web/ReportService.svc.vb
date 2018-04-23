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

' Developer Express Code Central Example:
' How to use the PrintCellStyle property to customize cell's printing appearance
' 
' This example shows how to create custom PrintCellStyle for grid columns to bring
' a custom printing appearance for PopupImageEdit, CheckBoxEdit and MemoEdit.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3227

Imports System
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.Xpf.Printing.Service
Imports DevExpress.XtraReports.Service
Imports DevExpress.XtraReports.UI

Namespace SLGridExample.Web
    ' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService" in code, svc and config file together.
    <SilverlightFaultBehavior> _
    Public Class ReportService
        Inherits DevExpress.XtraReports.Service.ReportService

        Protected Overrides Sub FillDataSources(ByVal report As XtraReport, ByVal reportName As String, ByVal isDesignActive As Boolean)
        End Sub

        Protected Overrides Sub SaveReportLayout(ByVal reportName As String, ByVal layoutData() As Byte)
            Throw New FaultException("This method is not implemented. Implement the SaveReportLayout method on the server-side, in the report service code-behind.")
        End Sub
    End Class
End Namespace
