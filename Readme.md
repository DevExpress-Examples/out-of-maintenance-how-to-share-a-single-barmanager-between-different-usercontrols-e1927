<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617564/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1927)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ExplorerUserControl.cs](./CS/B143239/ExplorerUserControl.cs) (VB: [ExplorerUserControl.vb](./VB/B143239/ExplorerUserControl.vb))
* [MainForm.cs](./CS/B143239/MainForm.cs) (VB: [MainForm.vb](./VB/B143239/MainForm.vb))
* [PropertiesUserControl.cs](./CS/B143239/PropertiesUserControl.cs) (VB: [PropertiesUserControl.vb](./VB/B143239/PropertiesUserControl.vb))
<!-- default file list end -->
# How to share a single BarManager between different UserControls


<p>When you need to embed a Bar into a UserControl, an obvious solution is to add the BarManager component to the UserControl. However, this approach is quite dangerous, because each BarManager will hook messages sent to the Form owning UserControl. This may cause a conflict between BarManagers. Also, keeping multiple instances of the BarManager component in memory will cause a performance penalty, because windows messages will be processed slower.</p><p>The best way to accomplish this task is to share a single BarManager between UserControls, and create menus and bar items dynamically. The <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraBarsStandaloneBarDockControltopic">StandaloneBarDockControl</a> component will help you embed Bars into the UserControl.</p>

<br/>


