Imports System.Collections.ObjectModel
Namespace LightSwitchApplication

    Public Class ThusListDetail
        Private Selected As New ObservableCollection(Of Xuất_Sản_PhẩmItem)()
        Dim flagEdit As Boolean
        Private Sub ThuListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub ThuListAddAndEditNew_Execute()
            ' Write your code here.
            Me.Thus.AddNew()
            Me.FindControl("Đối_TượngItem1").Focus()
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
            Me.FindControl("Thu_Chi_TiếtAddAndEditNew").Focus()
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Thu_Chi_Tiết.SelectedItem, ThuChiTiet).Details.DiscardChanges()
            Else
                Me.Thu_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Thu_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Thu_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Thu_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Thu_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Thu_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub

        Private Sub Báo_cáo_Execute()
            ' Write your code here.
            Me.Application.ShowThuReportPreviewScreen(Me.Thus.SelectedItem.Id, NumToText(Me.Thus.SelectedItem.Số_tiền))
        End Sub

        Private Sub Chọn_tất_cả_Execute()
            ' Write your code here.
            Dim pageCount As Integer = Me.Details.Properties.Xuất_Sản_Phẩm.PageCount
            Dim CurrentPageNumber As Integer = 1
            For i As Integer = 0 To pageCount
                Me.Details.Properties.Xuất_Sản_Phẩm.PageNumber = CurrentPageNumber
                CurrentPageNumber = CurrentPageNumber + 1
                '=====DO WORKS HERE======//
                For Each p As Xuất_Sản_PhẩmItem In Xuất_Sản_Phẩm
                    Selected.Add(p)
                Next
            Next
            Xuất_Sản_Phẩm.Refresh()
            Me.Details.Properties.Xuất_Sản_Phẩm.PageNumber = 1
        End Sub

        Private Sub Bỏ_tất_cả_Execute()
            ' Write your code here.
            Dim pageCount As Integer = Me.Details.Properties.Xuất_Sản_Phẩm.PageCount
            Dim CurrentPageNumber As Integer = 1
            For i As Integer = 0 To pageCount
                Me.Details.Properties.Xuất_Sản_Phẩm.PageNumber = CurrentPageNumber
                CurrentPageNumber = CurrentPageNumber + 1
                '=====DO WORKS HERE======//
                For Each p As Xuất_Sản_PhẩmItem In Xuất_Sản_Phẩm
                    Selected.Remove(p)
                Next
            Next
            Xuất_Sản_Phẩm.Refresh()
            Me.Details.Properties.Xuất_Sản_Phẩm.PageNumber = 1
        End Sub

        Private Sub Chuyển_Execute()
            ' Write your code here.
            For Each item In Selected
                Dim chitiet As ThuChiTiet = Thu_Chi_Tiết.AddNew
                chitiet.Ngày = item.Ngày_xuất
                chitiet.Đối_TượngItem = Me.DataWorkspace.BanHangData.DoiTuong_Single(item.Đối_TượngItem.Id)
                chitiet.Số_tiền = item.Tổng_tiền
            Next
        End Sub

        Private Sub ThusListDetail_InitializeDataWorkspace(saveChangesTo As List(Of IDataService))
            Me.FindControl("Xuất_Sản_Phẩm").AddCheckBoxColumnForMultiSelection(Of Xuất_Sản_PhẩmItem)(Selected) ' Write your code here.
        End Sub
    End Class

End Namespace
