using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars;

namespace B143239 {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private PropertiesUserControl propertiesControl;
        private void MainForm_Load(object sender, System.EventArgs e) {
            barManager.ForceInitialize();
            barManager.BeginUpdate();
            ExplorerUserControl explorerControl = new ExplorerUserControl(barManager);
            explorerControl.Dock = DockStyle.Fill;
            explorerControl.NeedDisplayProperty += new NeedDisplayPropertyEventHandler(OnNeedDisplayProperty);
            propertiesControl = new PropertiesUserControl(barManager);
            propertiesControl.Dock = DockStyle.Fill;
            barManager.EndUpdate();
            propertyGridPanel.Controls.Add(propertiesControl);
            explorerPanel.Controls.Add(explorerControl);
        }

        private void OnNeedDisplayProperty(object sender, NeedDisplayPropertyEventArgs e) {
            propertiesControl.SetSelectedObject(e.Directory);
        }

        private void OnBarCheckItemExplorerItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            explorerPanel.Visibility = 
                (((BarCheckItem)e.Item).Checked) ? DockVisibility.Visible :DockVisibility.Hidden;
        }

        private void OnBarCheckItemPropertyGridCheckedChanged(object sender, ItemClickEventArgs e) {
            propertyGridPanel.Visibility = 
                ((BarCheckItem)e.Item).Checked ? DockVisibility.Visible : DockVisibility.Hidden;
        }
    }
}
