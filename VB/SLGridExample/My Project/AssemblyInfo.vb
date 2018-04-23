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

Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("SLGridExample")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("Microsoft")>
<Assembly: AssemblyProduct("SLGridExample")>
<Assembly: AssemblyCopyright("Copyright © Microsoft 2011")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("c3b0bd49-3c92-4892-85b7-3c7b20c39450")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Revision and Build Numbers 
' by using the '*' as shown below:
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
