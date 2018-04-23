Imports Microsoft.VisualBasic
Imports System
Namespace B143239
	Partial Public Class ExplorerUserControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dockControl = New DevExpress.XtraBars.StandaloneBarDockControl()
			Me.treeList = New DevExpress.XtraTreeList.TreeList()
			Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colType = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colFullName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dockControl
			' 
			Me.dockControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.dockControl.Location = New System.Drawing.Point(0, 0)
			Me.dockControl.Name = "dockControl"
			Me.dockControl.Size = New System.Drawing.Size(419, 23)
			Me.dockControl.Text = "standaloneBarDockControl1"
			' 
			' treeList
			' 
			Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colName, Me.colType, Me.colFullName})
			Me.treeList.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList.Location = New System.Drawing.Point(0, 23)
			Me.treeList.Name = "treeList"
			Me.treeList.OptionsBehavior.Editable = False
			Me.treeList.Size = New System.Drawing.Size(419, 212)
			Me.treeList.TabIndex = 1
'			Me.treeList.VirtualTreeGetChildNodes += New DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(Me.OnTreeListVirtualTreeGetChildNodes);
'			Me.treeList.VirtualTreeGetCellValue += New DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(Me.OnTreeListVirtualTreeGetCellValue);
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colType
			' 
			Me.colType.Caption = "Type"
			Me.colType.FieldName = "Type"
			Me.colType.Name = "colType"
			Me.colType.Visible = True
			Me.colType.VisibleIndex = 1
			' 
			' colFullName
			' 
			Me.colFullName.Caption = "FillName"
			Me.colFullName.FieldName = "FillName"
			Me.colFullName.Name = "colFullName"
			' 
			' ExplorerUserControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList)
			Me.Controls.Add(Me.dockControl)
			Me.Name = "ExplorerUserControl"
			Me.Size = New System.Drawing.Size(419, 235)
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dockControl As DevExpress.XtraBars.StandaloneBarDockControl
		Private WithEvents treeList As DevExpress.XtraTreeList.TreeList
		Private colName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colType As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colFullName As DevExpress.XtraTreeList.Columns.TreeListColumn
	End Class
End Namespace
