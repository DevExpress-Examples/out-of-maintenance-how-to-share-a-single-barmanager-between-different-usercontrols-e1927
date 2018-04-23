namespace B143239 {
    partial class PropertiesUserControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dockControl = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.propertyView = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.propertyDescriptionView = new DevExpress.XtraVerticalGrid.PropertyDescriptionControl();
            ((System.ComponentModel.ISupportInitialize)(this.propertyView)).BeginInit();
            this.SuspendLayout();
            // 
            // dockControl
            // 
            this.dockControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockControl.Location = new System.Drawing.Point(0, 0);
            this.dockControl.Name = "dockControl";
            this.dockControl.Size = new System.Drawing.Size(423, 23);
            this.dockControl.Text = "standaloneBarDockControl1";
            // 
            // propertyView
            // 
            this.propertyView.AutoGenerateRows = true;
            this.propertyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyView.Location = new System.Drawing.Point(0, 23);
            this.propertyView.Name = "propertyView";
            this.propertyView.OptionsBehavior.Editable = false;
            this.propertyView.Size = new System.Drawing.Size(423, 222);
            this.propertyView.TabIndex = 1;
            // 
            // propertyDescriptionView
            // 
            this.propertyDescriptionView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyDescriptionView.Location = new System.Drawing.Point(0, 245);
            this.propertyDescriptionView.Name = "propertyDescriptionView";
            this.propertyDescriptionView.Size = new System.Drawing.Size(423, 100);
            this.propertyDescriptionView.TabIndex = 2;
            this.propertyDescriptionView.TabStop = false;
            // 
            // PropertiesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.propertyView);
            this.Controls.Add(this.propertyDescriptionView);
            this.Controls.Add(this.dockControl);
            this.Name = "PropertiesUserControl";
            this.Size = new System.Drawing.Size(423, 345);
            ((System.ComponentModel.ISupportInitialize)(this.propertyView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.StandaloneBarDockControl dockControl;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyView;
        private DevExpress.XtraVerticalGrid.PropertyDescriptionControl propertyDescriptionView;
    }
}
