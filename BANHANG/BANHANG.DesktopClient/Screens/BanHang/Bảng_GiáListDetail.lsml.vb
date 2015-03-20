
Namespace LightSwitchApplication

    Public Class Bảng_GiáListDetail
        Dim flagEdit As Boolean
        Private Sub Bảng_GiáItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Bảng_GiáItemListAddAndEditNew_Execute()
            ' Write your code here.
            Me.Bảng_Giá.AddNew()
            Me.FindControl("Tên1").Focus()
        End Sub
        Private Sub OK_Execute()
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Bảng_Giá_Chi_Tiết.SelectedItem, BangGiaChiTiet).Details.DiscardChanges()
            Else
                Me.Bảng_Giá_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Bảng_Giá_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Bảng_Giá_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Bảng_Giá_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Bảng_Giá_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Bảng_Giá_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub

        Private Sub Bảng_GiáListDetail_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))

        End Sub

 
        Private Sub Sản_Phẩm_Validate(results As ScreenValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            Try
                Dim sanpham As SanPham = Me.DataWorkspace.BanHangData.SanPham_Single(Me.Sản_Phẩm.Id)
                Me.Bảng_Giá_Chi_Tiết.SelectedItem.SanPham = sanpham
                Dim donvitinh As Đơn_Vị_TínhItem = Me.DataWorkspace.BanHangData.DonViTinh_Single(Me.Sản_Phẩm.Đơn_Vị_TínhItem.Id)
                Me.Bảng_Giá_Chi_Tiết.SelectedItem.Đơn_Vị_TínhItem = donvitinh
            Catch ex As Exception

            End Try
            
        End Sub
    End Class

End Namespace
