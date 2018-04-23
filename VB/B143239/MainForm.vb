Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars

Namespace B143239
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private propertiesControl As PropertiesUserControl
		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			barManager.ForceInitialize()
			barManager.BeginUpdate()
			Dim explorerControl As New ExplorerUserControl(barManager)
			explorerControl.Dock = DockStyle.Fill
			AddHandler explorerControl.NeedDisplayProperty, AddressOf OnNeedDisplayProperty
			propertiesControl = New PropertiesUserControl(barManager)
			propertiesControl.Dock = DockStyle.Fill
			barManager.EndUpdate()
			propertyGridPanel.Controls.Add(propertiesControl)
			explorerPanel.Controls.Add(explorerControl)
		End Sub

		Private Sub OnNeedDisplayProperty(ByVal sender As Object, ByVal e As NeedDisplayPropertyEventArgs)
			propertiesControl.SetSelectedObject(e.Directory)
		End Sub

		Private Sub OnBarCheckItemExplorerItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles checkItemExplorer.ItemClick
            If CType(e.Item, BarCheckItem).Checked Then
                explorerPanel.Visibility = DockVisibility.Visible
            Else
                explorerPanel.Visibility = DockVisibility.Hidden
            End If
		End Sub

		Private Sub OnBarCheckItemPropertyGridCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles checkItemPropertyGrid.ItemClick
            If CType(e.Item, BarCheckItem).Checked Then
                propertyGridPanel.Visibility = DockVisibility.Visible
            Else
                propertyGridPanel.Visibility = DockVisibility.Hidden
            End If
        End Sub
	End Class
End Namespace
