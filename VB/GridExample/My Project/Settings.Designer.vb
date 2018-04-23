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

' Developer Express Code Central Example:
' How to use the PrintCellStyle property to customize cell's printing appearance
' 
' This example shows how to create custom PrintCellStyle for grid columns to bring
' a custom printing appearance for PopupImageEdit, CheckBoxEdit and MemoEdit.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3227

' Developer Express Code Central Example:
' How to use the PrintCellStyle property to customize cell's printing appearance
' 
' This example shows how to create custom PrintCellStyle for grid columns to bring
' a custom printing appearance for PopupImageEdit, CheckBoxEdit and MemoEdit.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3227

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
