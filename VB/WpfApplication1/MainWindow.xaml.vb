Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace WpfApplication1
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = Stuff.GetStuff()
		End Sub

		Private Sub SmartExpandNodes(ByVal minChildCount As Integer)
			Dim nodeIterator As New TreeListNodeIterator(treeListView.Nodes, True)
			Do While nodeIterator.MoveNext()
				nodeIterator.Current.IsExpanded = nodeIterator.Current.Nodes.Count >= minChildCount
			Loop
		End Sub

		Private Sub grid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			SmartExpandNodes(4)
		End Sub
	End Class
End Namespace
