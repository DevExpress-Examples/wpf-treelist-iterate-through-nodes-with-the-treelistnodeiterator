Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace WpfApplication1

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GetStaff()
        End Sub

        Private Sub SmartExpandNodes(ByVal minChildCount As Integer)
            Dim nodeIterator As TreeListNodeIterator = New TreeListNodeIterator(Me.view.Nodes, True)
            While nodeIterator.MoveNext()
                nodeIterator.Current.IsExpanded = nodeIterator.Current.Nodes.Count >= minChildCount
            End While
        End Sub

        Private Sub OnGridLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SmartExpandNodes(4)
        End Sub
    End Class
End Namespace
