namespace B143239 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.MainMenu = new DevExpress.XtraBars.Bar();
            this.menuView = new DevExpress.XtraBars.BarSubItem();
            this.checkItemExplorer = new DevExpress.XtraBars.BarCheckItem();
            this.checkItemPropertyGrid = new DevExpress.XtraBars.BarCheckItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.propertyGridPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.explorerPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.propertyGridPanel.SuspendLayout();
            this.explorerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MainMenu,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockManager = this.dockManager;
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menuView,
            this.checkItemPropertyGrid,
            this.checkItemExplorer});
            this.barManager.MainMenu = this.MainMenu;
            this.barManager.MaxItemId = 7;
            this.barManager.StatusBar = this.bar3;
            // 
            // MainMenu
            // 
            this.MainMenu.BarName = "Main menu";
            this.MainMenu.DockCol = 0;
            this.MainMenu.DockRow = 0;
            this.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuView)});
            this.MainMenu.OptionsBar.MultiLine = true;
            this.MainMenu.OptionsBar.UseWholeRow = true;
            this.MainMenu.Text = "Main menu";
            // 
            // menuView
            // 
            this.menuView.Caption = "View";
            this.menuView.Id = 0;
            this.menuView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.checkItemExplorer),
            new DevExpress.XtraBars.LinkPersistInfo(this.checkItemPropertyGrid)});
            this.menuView.Name = "menuView";
            // 
            // checkItemExplorer
            // 
            this.checkItemExplorer.Caption = "Explorer";
            this.checkItemExplorer.Checked = true;
            this.checkItemExplorer.Id = 5;
            this.checkItemExplorer.Name = "checkItemExplorer";
            this.checkItemExplorer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnBarCheckItemExplorerItemClick);
            // 
            // checkItemPropertyGrid
            // 
            this.checkItemPropertyGrid.Caption = "Property Grid";
            this.checkItemPropertyGrid.Checked = true;
            this.checkItemPropertyGrid.Id = 3;
            this.checkItemPropertyGrid.Name = "checkItemPropertyGrid";
            this.checkItemPropertyGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnBarCheckItemPropertyGridCheckedChanged);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.propertyGridPanel,
            this.explorerPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // propertyGridPanel
            // 
            this.propertyGridPanel.Controls.Add(this.controlContainer1);
            this.propertyGridPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.propertyGridPanel.ID = new System.Guid("df095e39-b736-4447-b7f2-4dcf0edb81de");
            this.propertyGridPanel.Location = new System.Drawing.Point(500, 24);
            this.propertyGridPanel.Name = "propertyGridPanel";
            this.propertyGridPanel.Options.ShowAutoHideButton = false;
            this.propertyGridPanel.Options.ShowCloseButton = false;
            this.propertyGridPanel.Size = new System.Drawing.Size(200, 460);
            this.propertyGridPanel.Text = "Properties";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Location = new System.Drawing.Point(3, 25);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(194, 432);
            this.controlContainer1.TabIndex = 0;
            // 
            // explorerPanel
            // 
            this.explorerPanel.Controls.Add(this.dockPanel1_Container);
            this.explorerPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.explorerPanel.FloatSize = new System.Drawing.Size(200, 197);
            this.explorerPanel.ID = new System.Guid("0f304fb1-f579-4527-b8b6-8ee8e09b17e2");
            this.explorerPanel.Location = new System.Drawing.Point(0, 24);
            this.explorerPanel.Name = "explorerPanel";
            this.explorerPanel.Options.ShowAutoHideButton = false;
            this.explorerPanel.Options.ShowCloseButton = false;
            this.explorerPanel.Size = new System.Drawing.Size(200, 460);
            this.explorerPanel.Text = "Explorer";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(194, 432);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 507);
            this.Controls.Add(this.explorerPanel);
            this.Controls.Add(this.propertyGridPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainForm";
            this.Text = "DXSample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.propertyGridPanel.ResumeLayout(false);
            this.explorerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar MainMenu;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem menuView;
        private DevExpress.XtraBars.BarCheckItem checkItemExplorer;
        private DevExpress.XtraBars.BarCheckItem checkItemPropertyGrid;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel explorerPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel propertyGridPanel;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;

    }
}

