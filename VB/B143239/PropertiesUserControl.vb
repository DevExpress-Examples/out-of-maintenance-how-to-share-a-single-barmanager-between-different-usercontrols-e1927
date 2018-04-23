Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars

Namespace B143239
	Partial Public Class PropertiesUserControl
		Inherits XtraUserControl
		Private Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal manager As BarManager)
			Me.New()
			CreateMenu(manager)
		End Sub

		Private categoriesItem As BarCheckItem
		Private alphabeticalItem As BarCheckItem
		Private Sub CreateMenu(ByVal manager As BarManager)
			manager.DockControls.Add(dockControl)
			dockControl.BeginUpdate()

			Dim bar As New Bar(manager, "propertiesControlBar")
			bar.BeginUpdate()
			bar.StandaloneBarDockControl = dockControl
			bar.DockStyle = BarDockStyle.Standalone
			bar.CanDockStyle = BarCanDockStyle.Standalone
			bar.OptionsBar.DisableCustomization = True

			categoriesItem = New BarCheckItem(manager, True)
			categoriesItem.Caption = "By category"
			AddHandler categoriesItem.CheckedChanged, AddressOf OnBarCheckItemCheckedChanged
			bar.ItemLinks.Add(categoriesItem)

			alphabeticalItem = New BarCheckItem(manager, False)
			alphabeticalItem.Caption = "Alphabetically"
			AddHandler alphabeticalItem.CheckedChanged, AddressOf OnBarCheckItemCheckedChanged
			bar.ItemLinks.Add(alphabeticalItem)

			bar.EndUpdate()
			dockControl.EndUpdate()
		End Sub

		Private processingCheckedChanged As Boolean
		Private Sub OnBarCheckItemCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			If processingCheckedChanged Then
				Return
			End If
			processingCheckedChanged = True
			If sender Is categoriesItem Then
				alphabeticalItem.Checked = False
				propertyView.OptionsView.ShowRootCategories = True
			ElseIf sender Is alphabeticalItem Then
				categoriesItem.Checked = False
				propertyView.OptionsView.ShowRootCategories = False
			End If
			processingCheckedChanged = False
		End Sub

		Public Sub SetSelectedObject(ByVal selectedObject As Object)
			propertyView.SelectedObject = selectedObject
		End Sub
	End Class
End Namespace
