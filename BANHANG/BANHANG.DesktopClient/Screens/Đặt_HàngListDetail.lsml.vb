
Namespace LightSwitchApplication

    Public Class Đặt_HàngListDetail
        Dim flagEdit As Boolean

        Private Sub Đặt_HàngItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Đặt_HàngItemListAddAndEditNew_Execute()
            Me.Đặt_Hàng.AddNew()
            Me.FindControl("Đối_TượngItem1").Focus() ' Write your code here.

        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Đặt_Hàng_Chi_Tiết.SelectedItem, DatHangChiTiet).Details.DiscardChanges()
            Else
                Me.Đặt_Hàng_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Đặt_Hàng_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Đặt_Hàng_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Đặt_Hàng_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Đặt_Hàng_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Đặt_Hàng_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub
        Private Sub Sản_Phẩm_Validate(results As ScreenValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            Try
                Dim sanpham As SanPham = Me.DataWorkspace.BanHangData.SanPham_Single(Me.Sản_Phẩm.Id)
                Me.Đặt_Hàng_Chi_Tiết.SelectedItem.SanPham = sanpham
                Dim donvitinh As Đơn_Vị_TínhItem = Me.DataWorkspace.BanHangData.DonViTinh_Single(Me.Sản_Phẩm.Đơn_Vị_TínhItem.Id)
                Me.Đặt_Hàng_Chi_Tiết.SelectedItem.Đơn_Vị_TínhItem = donvitinh
            Catch ex As Exception

            End Try
        End Sub
    End Class

End Namespace
