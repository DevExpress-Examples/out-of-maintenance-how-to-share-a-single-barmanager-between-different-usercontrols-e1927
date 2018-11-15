<!-- default file list -->
*Files to look at*:

* [ExplorerUserControl.cs](./CS/B143239/ExplorerUserControl.cs) (VB: [ExplorerUserControl.vb](./VB/B143239/ExplorerUserControl.vb))
* [MainForm.cs](./CS/B143239/MainForm.cs) (VB: [MainForm.vb](./VB/B143239/MainForm.vb))
* [PropertiesUserControl.cs](./CS/B143239/PropertiesUserControl.cs) (VB: [PropertiesUserControl.vb](./VB/B143239/PropertiesUserControl.vb))
<!-- default file list end -->
# How to share a single BarManager between different UserControls


<p>When you need to embed a Bar into a UserControl, an obvious solution is to add the BarManager component to the UserControl. However, this approach is quite dangerous, because each BarManager will hook messages sent to the Form owning UserControl. This may cause a conflict between BarManagers. Also, keeping multiple instances of the BarManager component in memory will cause a performance penalty, because windows messages will be processed slower.</p><p>The best way to accomplish this task is to share a single BarManager between UserControls, and create menus and bar items dynamically. The <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraBarsStandaloneBarDockControltopic">StandaloneBarDockControl</a> component will help you embed Bars into the UserControl.</p>


<h3>Description</h3>

<p>Bars and BarItems are created at runtime, when the UserControl is initialized. Bars are docked within the StandaloneBarDockControls.</p>

<br/>


