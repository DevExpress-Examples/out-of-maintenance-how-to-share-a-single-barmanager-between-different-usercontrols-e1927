Imports Microsoft.VisualBasic
Imports System
Namespace B143239
	Partial Public Class MainForm
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.MainMenu = New DevExpress.XtraBars.Bar()
			Me.menuView = New DevExpress.XtraBars.BarSubItem()
			Me.checkItemExplorer = New DevExpress.XtraBars.BarCheckItem()
			Me.checkItemPropertyGrid = New DevExpress.XtraBars.BarCheckItem()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.propertyGridPanel = New DevExpress.XtraBars.Docking.DockPanel()
			Me.controlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.explorerPanel = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.propertyGridPanel.SuspendLayout()
			Me.explorerPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' barManager
			' 
			Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.MainMenu, Me.bar3})
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.DockManager = Me.dockManager
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.menuView, Me.checkItemPropertyGrid, Me.checkItemExplorer})
			Me.barManager.MainMenu = Me.MainMenu
			Me.barManager.MaxItemId = 7
			Me.barManager.StatusBar = Me.bar3
			' 
			' MainMenu
			' 
			Me.MainMenu.BarName = "Main menu"
			Me.MainMenu.DockCol = 0
			Me.MainMenu.DockRow = 0
			Me.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.MainMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.menuView)})
			Me.MainMenu.OptionsBar.MultiLine = True
			Me.MainMenu.OptionsBar.UseWholeRow = True
			Me.MainMenu.Text = "Main menu"
			' 
			' menuView
			' 
			Me.menuView.Caption = "View"
			Me.menuView.Id = 0
			Me.menuView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.checkItemExplorer), New DevExpress.XtraBars.LinkPersistInfo(Me.checkItemPropertyGrid)})
			Me.menuView.Name = "menuView"
			' 
			' checkItemExplorer
			' 
			Me.checkItemExplorer.Caption = "Explorer"
			Me.checkItemExplorer.Checked = True
			Me.checkItemExplorer.Id = 5
			Me.checkItemExplorer.Name = "checkItemExplorer"
'			Me.checkItemExplorer.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnBarCheckItemExplorerItemClick);
			' 
			' checkItemPropertyGrid
			' 
			Me.checkItemPropertyGrid.Caption = "Property Grid"
			Me.checkItemPropertyGrid.Checked = True
			Me.checkItemPropertyGrid.Id = 3
			Me.checkItemPropertyGrid.Name = "checkItemPropertyGrid"
'			Me.checkItemPropertyGrid.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnBarCheckItemPropertyGridCheckedChanged);
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' dockManager
			' 
			Me.dockManager.Form = Me
			Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.propertyGridPanel, Me.explorerPanel})
			Me.dockManager.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' propertyGridPanel
			' 
			Me.propertyGridPanel.Controls.Add(Me.controlContainer1)
			Me.propertyGridPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.propertyGridPanel.ID = New System.Guid("df095e39-b736-4447-b7f2-4dcf0edb81de")
			Me.propertyGridPanel.Location = New System.Drawing.Point(500, 24)
			Me.propertyGridPanel.Name = "propertyGridPanel"
			Me.propertyGridPanel.Options.ShowAutoHideButton = False
			Me.propertyGridPanel.Options.ShowCloseButton = False
			Me.propertyGridPanel.Size = New System.Drawing.Size(200, 460)
			Me.propertyGridPanel.Text = "Properties"
			' 
			' controlContainer1
			' 
			Me.controlContainer1.Location = New System.Drawing.Point(3, 25)
			Me.controlContainer1.Name = "controlContainer1"
			Me.controlContainer1.Size = New System.Drawing.Size(194, 432)
			Me.controlContainer1.TabIndex = 0
			' 
			' explorerPanel
			' 
			Me.explorerPanel.Controls.Add(Me.dockPanel1_Container)
			Me.explorerPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
			Me.explorerPanel.FloatSize = New System.Drawing.Size(200, 197)
			Me.explorerPanel.ID = New System.Guid("0f304fb1-f579-4527-b8b6-8ee8e09b17e2")
			Me.explorerPanel.Location = New System.Drawing.Point(0, 24)
			Me.explorerPanel.Name = "explorerPanel"
			Me.explorerPanel.Options.ShowAutoHideButton = False
			Me.explorerPanel.Options.ShowCloseButton = False
			Me.explorerPanel.Size = New System.Drawing.Size(200, 460)
			Me.explorerPanel.Text = "Explorer"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(194, 432)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(700, 507)
			Me.Controls.Add(Me.explorerPanel)
			Me.Controls.Add(Me.propertyGridPanel)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "MainForm"
			Me.Text = "DXSample"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
			Me.propertyGridPanel.ResumeLayout(False)
			Me.explorerPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager As DevExpress.XtraBars.BarManager
		Private MainMenu As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private menuView As DevExpress.XtraBars.BarSubItem
		Private WithEvents checkItemExplorer As DevExpress.XtraBars.BarCheckItem
		Private WithEvents checkItemPropertyGrid As DevExpress.XtraBars.BarCheckItem
		Private dockManager As DevExpress.XtraBars.Docking.DockManager
		Private explorerPanel As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private propertyGridPanel As DevExpress.XtraBars.Docking.DockPanel
		Private controlContainer1 As DevExpress.XtraBars.Docking.ControlContainer

	End Class
End Namespace

