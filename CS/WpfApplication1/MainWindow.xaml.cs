using System.Windows;
using DevExpress.Xpf.Grid;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = Stuff.GetStuff();
        }

        private void SmartExpandNodes(int minChildCount) {
            TreeListNodeIterator nodeIterator = new TreeListNodeIterator(treeListView.Nodes, true);
            while (nodeIterator.MoveNext())
                nodeIterator.Current.IsExpanded = nodeIterator.Current.Nodes.Count >= minChildCount;
        }

        private void grid_Loaded(object sender, RoutedEventArgs e) {
            SmartExpandNodes(4);
        }
    }
}
