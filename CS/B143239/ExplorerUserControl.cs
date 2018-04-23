using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.IO;
using System;
using DevExpress.XtraTreeList;
using System.Drawing;

namespace B143239 {
    public partial class ExplorerUserControl :XtraUserControl {
        private bool loadDrives;
        private ExplorerUserControl() {
            InitializeComponent();
        }

        public ExplorerUserControl(BarManager manager)
            : this() {
            CreateMenu(manager);
            treeList.DataSource = new object();
        }

        private void CreateMenu(BarManager manager) {
            dockControl.BeginUpdate();
            manager.DockControls.Add(dockControl);

            Bar bar = new Bar(manager, "explorerBar");
            bar.BeginUpdate();
            bar.StandaloneBarDockControl = dockControl;
            bar.DockStyle = BarDockStyle.Standalone;
            bar.CanDockStyle = BarCanDockStyle.Standalone;
            bar.OptionsBar.DisableCustomization = true;

            BarButtonItem item = new BarButtonItem(manager, "View properties");
            item.ItemClick += new ItemClickEventHandler(OnViewPropertiesItemClick);
            bar.ItemLinks.Add(item);

            bar.EndUpdate();
            dockControl.EndUpdate();
        }

        private void OnViewPropertiesItemClick(object sender, ItemClickEventArgs e) {
            if (treeList.FocusedNode == null) return;
            RaiseNeedDisplayProperty(new DirectoryInfo((string)treeList.FocusedNode[colFullName]));
        }

        private static object fNeedDisplayProperty = new object();
        public event NeedDisplayPropertyEventHandler NeedDisplayProperty {
            add { Events.AddHandler(fNeedDisplayProperty, value); }
            remove { Events.RemoveHandler(fNeedDisplayProperty, value); }
        }
        public void RaiseNeedDisplayProperty(DirectoryInfo directory) {
            NeedDisplayPropertyEventHandler handler =
                Events[fNeedDisplayProperty] as NeedDisplayPropertyEventHandler;
            if (handler != null) handler(this, new NeedDisplayPropertyEventArgs(directory));
        }

        bool IsFile(DirectoryInfo info) {
            return (info.Attributes & FileAttributes.Directory) == 0;
        }

        private void OnTreeListVirtualTreeGetCellValue(object sender, VirtualTreeGetCellValueInfo e) {
            DirectoryInfo di = new DirectoryInfo((string)e.Node);
            if (e.Column == colName)
                e.CellData = di.Name;
            if (e.Column == colType) {
                if (!IsFile(di))
                    e.CellData = "Folder";
                else
                    e.CellData = "File";
            } if (e.Column == colFullName)
                e.CellData = di.FullName;
        }

        private void OnTreeListVirtualTreeGetChildNodes(object sender, VirtualTreeGetChildNodesInfo e) {
            if (!loadDrives) { // create drives
                string[] root = Directory.GetLogicalDrives();
                e.Children = root;
                loadDrives = true;
            } else {
                try {
                    string path = (string)e.Node;
                    if (Directory.Exists(path)) {
                        string[] dirs = Directory.GetDirectories(path);
                        string[] files = Directory.GetFiles(path);
                        string[] arr = new string[dirs.Length + files.Length];
                        dirs.CopyTo(arr, 0);
                        files.CopyTo(arr, dirs.Length);
                        e.Children = arr;
                    } else e.Children = new object[] { };
                } catch { e.Children = new object[] { }; }
            }
        }
    }

    public delegate void NeedDisplayPropertyEventHandler(object sender, NeedDisplayPropertyEventArgs e);
    public class NeedDisplayPropertyEventArgs :EventArgs {
        public NeedDisplayPropertyEventArgs(DirectoryInfo directory) {
            fDirectory = directory;
        }
        private DirectoryInfo fDirectory;
        public DirectoryInfo Directory { get { return fDirectory; } }
    }
}
