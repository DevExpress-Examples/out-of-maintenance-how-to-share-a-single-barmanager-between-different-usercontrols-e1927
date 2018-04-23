Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports System.IO
Imports System
Imports DevExpress.XtraTreeList
Imports System.Drawing

Namespace B143239
	Partial Public Class ExplorerUserControl
		Inherits XtraUserControl
		Private loadDrives As Boolean
		Private Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal manager As BarManager)
			Me.New()
			CreateMenu(manager)
			treeList.DataSource = New Object()
		End Sub

		Private Sub CreateMenu(ByVal manager As BarManager)
			dockControl.BeginUpdate()
			manager.DockControls.Add(dockControl)

			Dim bar As New Bar(manager, "explorerBar")
			bar.BeginUpdate()
			bar.StandaloneBarDockControl = dockControl
			bar.DockStyle = BarDockStyle.Standalone
			bar.CanDockStyle = BarCanDockStyle.Standalone
			bar.OptionsBar.DisableCustomization = True

			Dim item As New BarButtonItem(manager, "View properties")
			AddHandler item.ItemClick, AddressOf OnViewPropertiesItemClick
			bar.ItemLinks.Add(item)

			bar.EndUpdate()
			dockControl.EndUpdate()
		End Sub

		Private Sub OnViewPropertiesItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			If treeList.FocusedNode Is Nothing Then
				Return
			End If
			RaiseNeedDisplayProperty(New DirectoryInfo(CStr(treeList.FocusedNode(colFullName))))
		End Sub

		Private Shared fNeedDisplayProperty As Object = New Object()
		Public Custom Event NeedDisplayProperty As NeedDisplayPropertyEventHandler
			AddHandler(ByVal value As NeedDisplayPropertyEventHandler)
				Events.AddHandler(fNeedDisplayProperty, value)
			End AddHandler
			RemoveHandler(ByVal value As NeedDisplayPropertyEventHandler)
				Events.RemoveHandler(fNeedDisplayProperty, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As NeedDisplayPropertyEventArgs)
			End RaiseEvent
		End Event
		Public Sub RaiseNeedDisplayProperty(ByVal directory As DirectoryInfo)
			Dim handler As NeedDisplayPropertyEventHandler = TryCast(Events(fNeedDisplayProperty), NeedDisplayPropertyEventHandler)
			If handler IsNot Nothing Then
				handler(Me, New NeedDisplayPropertyEventArgs(directory))
			End If
		End Sub

		Private Function IsFile(ByVal info As DirectoryInfo) As Boolean
			Return (info.Attributes And FileAttributes.Directory) = 0
		End Function

		Private Sub OnTreeListVirtualTreeGetCellValue(ByVal sender As Object, ByVal e As VirtualTreeGetCellValueInfo) Handles treeList.VirtualTreeGetCellValue
			Dim di As New DirectoryInfo(CStr(e.Node))
			If e.Column Is colName Then
				e.CellData = di.Name
			End If
			If e.Column Is colType Then
				If (Not IsFile(di)) Then
					e.CellData = "Folder"
				Else
					e.CellData = "File"
				End If
			End If
			If e.Column Is colFullName Then
				e.CellData = di.FullName
			End If
		End Sub

		Private Sub OnTreeListVirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As VirtualTreeGetChildNodesInfo) Handles treeList.VirtualTreeGetChildNodes
			If (Not loadDrives) Then ' create drives
				Dim root() As String = Directory.GetLogicalDrives()
				e.Children = root
				loadDrives = True
			Else
				Try
					Dim path As String = CStr(e.Node)
					If Directory.Exists(path) Then
						Dim dirs() As String = Directory.GetDirectories(path)
						Dim files() As String = Directory.GetFiles(path)
						Dim arr(dirs.Length + files.Length - 1) As String
						dirs.CopyTo(arr, 0)
						files.CopyTo(arr, dirs.Length)
						e.Children = arr
					Else
						e.Children = New Object() { }
					End If
				Catch
					e.Children = New Object() { }
				End Try
			End If
		End Sub
	End Class

	Public Delegate Sub NeedDisplayPropertyEventHandler(ByVal sender As Object, ByVal e As NeedDisplayPropertyEventArgs)
	Public Class NeedDisplayPropertyEventArgs
		Inherits EventArgs
		Public Sub New(ByVal directory As DirectoryInfo)
			fDirectory = directory
		End Sub
		Private fDirectory As DirectoryInfo
		Public ReadOnly Property Directory() As DirectoryInfo
			Get
				Return fDirectory
			End Get
		End Property
	End Class
End Namespace
