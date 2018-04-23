using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace B143239 {
    public partial class PropertiesUserControl :XtraUserControl {
        private PropertiesUserControl() {
            InitializeComponent();
        }

        public PropertiesUserControl(BarManager manager) : this() {
            CreateMenu(manager);
        }

        private BarCheckItem categoriesItem;
        private BarCheckItem alphabeticalItem;
        private void CreateMenu(BarManager manager) {
            manager.DockControls.Add(dockControl);
            dockControl.BeginUpdate();

            Bar bar = new Bar(manager, "propertiesControlBar");
            bar.BeginUpdate();
            bar.StandaloneBarDockControl = dockControl;
            bar.DockStyle = BarDockStyle.Standalone;
            bar.CanDockStyle = BarCanDockStyle.Standalone;
            bar.OptionsBar.DisableCustomization = true;

            categoriesItem = new BarCheckItem(manager, true);
            categoriesItem.Caption = "By category";
            categoriesItem.CheckedChanged += new ItemClickEventHandler(OnBarCheckItemCheckedChanged);
            bar.ItemLinks.Add(categoriesItem);

            alphabeticalItem = new BarCheckItem(manager, false);
            alphabeticalItem.Caption = "Alphabetically";
            alphabeticalItem.CheckedChanged += new ItemClickEventHandler(OnBarCheckItemCheckedChanged);
            bar.ItemLinks.Add(alphabeticalItem);

            bar.EndUpdate();
            dockControl.EndUpdate();
        }

        private bool processingCheckedChanged;
        private void OnBarCheckItemCheckedChanged(object sender, ItemClickEventArgs e) {
            if (processingCheckedChanged) return;
            processingCheckedChanged = true;
            if (sender == categoriesItem) {
                alphabeticalItem.Checked = false;
                propertyView.OptionsView.ShowRootCategories = true;
            } else if (sender == alphabeticalItem) {
                categoriesItem.Checked = false;
                propertyView.OptionsView.ShowRootCategories = false;
            }
            processingCheckedChanged = false;
        }

        public void SetSelectedObject(object selectedObject) {
            propertyView.SelectedObject = selectedObject;
        }
    }
}
