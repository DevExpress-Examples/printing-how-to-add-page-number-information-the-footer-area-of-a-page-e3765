<!-- default file list -->
*Files to look at*:

* [View.xaml](./CS/GridExample/View/View.xaml) (VB: [View.xaml](./VB/GridExample/View/View.xaml))
* [View.xaml.cs](./CS/GridExample/View/View.xaml.cs) (VB: [View.xaml.vb](./VB/GridExample/View/View.xaml.vb))
<!-- default file list end -->
# Printing: How to add page number information the footer area of a page


<p>This example shows how to add a page number to every page when printing a DXGrid. You'll need to prepare a custom page footer template and place a TextEdit control that will display the current page number within it. Note that the TextEdit should be properly adjusted by setting required <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingExportSettingsMembersTopicAll"><u>dxp:ExportSettings</u></a>, <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingPageNumberExportSettings_Kindtopic"><u>dxp:PageNumberExportSettings.Kind</u></a> and <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingPageNumberExportSettings_Formattopic"><u>dxp:PageNumberExportSettings.Format</u></a> properties. Next, assign this custom page footer template to the PrintableControlLink.PageFooterTemplate property during export.</p>

<br/>


