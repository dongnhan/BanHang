Imports Microsoft.LightSwitch
Imports Microsoft.LightSwitch.Client
Imports Microsoft.LightSwitch.Presentation
Imports System
Imports System.Linq
Imports System.Collections.ObjectModel
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports Microsoft.LightSwitch.Framework.Client
Imports Microsoft.LightSwitch.Presentation.Extensions
Imports System.Diagnostics
Imports Microsoft.LightSwitch.Presentation.Implementation
Imports System.Collections.Generic

Public Module MultiSelectGridExtensions
    <System.Runtime.CompilerServices.Extension> _
    Public Sub AddCheckBoxColumnForMultiSelection(Of T As {Class, IEntityObject})(gridProxy As IContentItemProxy, selectedItems As ObservableCollection(Of T))
        Dim gridProxy_ControlAvailable As EventHandler(Of ControlAvailableEventArgs) = Nothing
        gridProxy_ControlAvailable =
            Sub(s1, e1)
                Dim dataGrid As DataGrid = TryCast(e1.Control, DataGrid)
                Dim contentItem = TryCast(dataGrid.DataContext, IContentItem)
                Dim visualCollection = TryCast(contentItem.Value, IVisualCollection)
                AddHandler dataGrid.LoadingRow,
                    Sub(s2, e2)
                        Dim column As DataGridColumn = dataGrid.Columns(0)
                        Dim checkBox = TryCast(column.GetCellContent(e2.Row), CheckBox)
                        Dim currentRowItem As T = TryCast(e2.Row.DataContext, T)
                        If currentRowItem IsNot Nothing Then
                            checkBox.IsChecked = selectedItems.Contains(currentRowItem)
                        End If
                        Dim checkboxClick As RoutedEventHandler = Nothing
                        checkboxClick =
                            Sub()
                                Dim selectedItem = TryCast(dataGrid.SelectedItem, T)
                                If selectedItem Is Nothing Then
                                    Return
                                End If
                                If If(checkBox.IsChecked, False) Then
                                    'If If(checkBox.IsChecked, True) Then
                                    If Not selectedItems.Contains(selectedItem) Then
                                        selectedItems.Add(selectedItem)
                                    End If
                                Else
                                    selectedItems.Remove(selectedItem)
                                End If
                                TriggerCanExecute(visualCollection)
                            End Sub
                        AddHandler checkBox.Click, checkboxClick
                    End Sub
                Dim col = New DataGridTemplateColumn()
                Dim xaml = "<DataTemplate xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">" & vbCrLf & " <CheckBox/>" & vbCrLf & " </DataTemplate>"
                Dim dataTemplate = TryCast(XamlReader.Load(xaml), DataTemplate)
                col.CellTemplate = dataTemplate
                dataGrid.Columns.Insert(0, col)
                RemoveHandler gridProxy.ControlAvailable, gridProxy_ControlAvailable
            End Sub
        AddHandler gridProxy.ControlAvailable, gridProxy_ControlAvailable
    End Sub
    Private Sub TriggerCanExecute(visualCollection As IVisualCollection)
        Dim currentItem = visualCollection.SelectedItem
        Dim collection = TryCast(visualCollection, IEnumerable(Of IEntityObject))
        If Not visualCollection.SelectedItem.Equals(collection.Last()) Then
            visualCollection.SelectedItem = collection.Last()
        Else
            visualCollection.SelectedItem = collection.First()
        End If
        visualCollection.SelectedItem = currentItem
    End Sub
End Module