﻿' Developer Express Code Central Example:
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
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace SLGridExample
    Partial Public Class App
        Inherits Application

        Public Sub New()
            AddHandler Me.Startup, AddressOf Me.Application_Startup
            AddHandler Me.Exit, AddressOf Me.Application_Exit
            AddHandler Me.UnhandledException, AddressOf Me.Application_UnhandledException

            InitializeComponent()
        End Sub

        Private Sub Application_Startup(ByVal sender As Object, ByVal e As StartupEventArgs)
            If String.Compare("file", Host.Source.Scheme, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                Const message As String = "Please set the Web project of this solution as the starting project."
                MessageBox.Show(message)
                Return
            End If
            Me.RootVisual = New MainPage()
        End Sub

        Private Sub Application_Exit(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub Application_UnhandledException(ByVal sender As Object, ByVal e As ApplicationUnhandledExceptionEventArgs)
            ' If the app is running outside of the debugger then report the exception using
            ' the browser's exception mechanism. On IE this will display it a yellow alert 
            ' icon in the status bar and Firefox will display a script error.
            If Not System.Diagnostics.Debugger.IsAttached Then

                ' NOTE: This will allow the application to continue running after an exception has been thrown
                ' but not handled. 
                ' For production applications this error handling should be replaced with something that will 
                ' report the error to the website and stop the application.
                e.Handled = True
                Deployment.Current.Dispatcher.BeginInvoke(Sub() ReportErrorToDOM(e))
            End If
        End Sub

        Private Sub ReportErrorToDOM(ByVal e As ApplicationUnhandledExceptionEventArgs)
            Try
                Dim errorMsg As String = e.ExceptionObject.Message + e.ExceptionObject.StackTrace
                errorMsg = errorMsg.Replace(""""c, "'"c).Replace(ControlChars.CrLf, ControlChars.Lf)

                System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(""Unhandled Error in Silverlight Application " & errorMsg & """);")
            Catch e1 As Exception
            End Try
        End Sub
    End Class
End Namespace
