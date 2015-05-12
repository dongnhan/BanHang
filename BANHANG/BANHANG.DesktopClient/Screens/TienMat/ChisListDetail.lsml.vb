Imports System.Collections.ObjectModel
Namespace LightSwitchApplication

    Public Class ChisListDetail
        Private Selected As New ObservableCollection(Of NhapSanPham)()
        Dim flagEdit As Boolean
        Private Sub ChiListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub ChiListAddAndEditNew_Execute()
            ' Write your code here.
            Me.Chis.AddNew()
            Me.FindControl("Đối_TượngItem1").Focus()
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
            Me.FindControl("Chi_Chi_TiếtAddAndEditNew").Focus()
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Chi_Chi_Tiết.SelectedItem, ChiChiTiet).Details.DiscardChanges()
            Else
                Me.Chi_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Chi_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Chi_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Chi_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Chi_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Chi_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowChiReportPreviewScreen(Me.Chis.SelectedItem.Id, NumToText(Me.Chis.SelectedItem.Số_tiền)) ' Write your code here.

        End Sub

        Private Sub Chọn_tất_cả_Execute()
            ' Write your code here.
            Dim pageCount As Integer = Me.Details.Properties.Nhập_Sản_Phẩm.PageCount
            Dim CurrentPageNumber As Integer = 1
            For i As Integer = 0 To pageCount
                Me.Details.Properties.Nhập_Sản_Phẩm.PageNumber = CurrentPageNumber
                CurrentPageNumber = CurrentPageNumber + 1
                '=====DO WORKS HERE======//
                For Each p As NhapSanPham In Nhập_Sản_Phẩm
                    Selected.Add(p)
                Next
            Next
            Nhập_Sản_Phẩm.Refresh()
            Me.Details.Properties.Nhập_Sản_Phẩm.PageNumber = 1
        End Sub

        Private Sub Bỏ_tất_cả_Execute()
            ' Write your code here.
            Dim pageCount As Integer = Me.Details.Properties.Nhập_Sản_Phẩm.PageCount
            Dim CurrentPageNumber As Integer = 1
            For i As Integer = 0 To pageCount
                Me.Details.Properties.Nhập_Sản_Phẩm.PageNumber = CurrentPageNumber
                CurrentPageNumber = CurrentPageNumber + 1
                '=====DO WORKS HERE======//
                For Each p As NhapSanPham In Nhập_Sản_Phẩm
                    Selected.Remove(p)
                Next
            Next
            Nhập_Sản_Phẩm.Refresh()
            Me.Details.Properties.Nhập_Sản_Phẩm.PageNumber = 1
        End Sub

        Private Sub Chuyển_Execute()
            ' Write your code here.
            For Each item In Selected
                Dim chitiet As ChiChiTiet = Chi_Chi_Tiết.AddNew
                chitiet.Ngày = item.Ngày_nhập
                chitiet.Ngày_hóa_đơn = item.Ngày_hóa_đơn
                chitiet.Số_hóa_đơn = item.Số_hóa_đơn
                chitiet.Đối_TượngItem = item.Đối_TượngItem
                chitiet.Số_tiền = item.Tổng_tiền
            Next
        End Sub

        Private Sub ChisListDetail_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Me.FindControl("Nhập_Sản_Phẩm").AddCheckBoxColumnForMultiSelection(Of NhapSanPham)(Selected) ' Write your code here.

        End Sub
    End Class

End Namespace
