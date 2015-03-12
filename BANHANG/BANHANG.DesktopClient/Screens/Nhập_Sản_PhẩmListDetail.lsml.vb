﻿
Namespace LightSwitchApplication

    Public Class Nhập_Sản_PhẩmListDetail
        Dim flagEdit As Boolean
        Private Sub Nhập_Sản_PhẩmItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhập_Sản_PhẩmItemListAddAndEditNew_Execute()
            Me.Nhập_Sản_Phẩm.AddNew()
            Me.FindControl("Đối_TượngItem1").Focus() ' Write your code here.
            Me.Nhập_Sản_Phẩm.SelectedItem.Thanh_toán = 1 'ghi nợ
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
            'Me.FindControl("Chi_Chi_TiếtAddAndEditNew").Focus()
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Nhập_Sản_Phẩm_Chi_Tiết.SelectedItem, NhapSanPhamChiTiet).Details.DiscardChanges()
            Else
                Me.Nhập_Sản_Phẩm_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Nhập_Sản_Phẩm_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhập_Sản_Phẩm_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Nhập_Sản_Phẩm_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Nhập_Sản_Phẩm_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhập_Sản_Phẩm_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowNhapSanPhamReportPreviewScreen(Me.Nhập_Sản_Phẩm.SelectedItem.Id, NumToText(Me.Nhập_Sản_Phẩm.SelectedItem.Tổng_tiền)) ' Write your code here.

        End Sub

        Private Sub Nhập_Sản_PhẩmListDetail_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            ' Write your code here.

        End Sub
    End Class

End Namespace
