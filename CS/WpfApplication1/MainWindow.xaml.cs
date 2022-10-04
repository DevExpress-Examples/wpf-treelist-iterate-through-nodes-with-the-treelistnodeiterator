using System.Windows;
using DevExpress.Xpf.Grid;

namespace WpfApplication1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = Staff.GetStaff();
        }

        void SmartExpandNodes(int minChildCount) {
            TreeListNodeIterator nodeIterator = new TreeListNodeIterator(view.Nodes, true);
            while (nodeIterator.MoveNext())
                nodeIterator.Current.IsExpanded = nodeIterator.Current.Nodes.Count >= minChildCount;
        }

        void OnGridLoaded(object sender, RoutedEventArgs e) {
            SmartExpandNodes(4);
        }
    }
}
