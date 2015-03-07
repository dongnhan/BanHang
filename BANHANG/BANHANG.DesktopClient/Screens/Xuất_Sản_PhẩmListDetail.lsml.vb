
Namespace LightSwitchApplication

    Public Class Xuất_Sản_PhẩmListDetail
        Dim flagEdit As Boolean
        Private Sub Xuất_Sản_PhẩmItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Xuất_Sản_PhẩmItemListAddAndEditNew_Execute()
            ' Write your code here.
            Me.Xuất_Sản_Phẩm.AddNew()
            Me.FindControl("Đối_TượngItem1").Focus()
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem, XuatSanPhamChiTiet).Details.DiscardChanges()
            Else
                Me.Xuất_Sản_Phẩm_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Xuất_Sản_Phẩm_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Xuất_Sản_Phẩm_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Xuất_Sản_Phẩm_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Xuất_Sản_Phẩm_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Xuất_Sản_Phẩm_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub

        Private Sub Xuất_Sản_PhẩmListDetail_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Me.Thang = Today.Month
            Me.Nam = Today.Year ' Write your code here.

        End Sub

        Private Sub Xuất_Sản_Phẩm_SelectionChanged()
            'Me.Thang = Today.Month
            'Me.Nam = Today.Year
        End Sub

        Private Sub Tồn_Thực_Validate(results As ScreenValidationResultsBuilder)
            Try
                Dim sanpham = DataWorkspace.BanHangData.SanPham_Single(Tồn_Thực.Mã_Sản_Phẩm)
                Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.SanPham = sanpham
                Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.TonThuc = Tồn_Thực.Tồn
                Me.Tồn = Tồn_Thực.Tồn
                Dim donvitinh = DataWorkspace.BanHangData.DonViTinh_Single(DataWorkspace.BanHangData.SanPham_Single(Tồn_Thực.Mã_Sản_Phẩm).Đơn_Vị_TínhItem.Id)
                Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Đơn_Vị_TínhItem = donvitinh

                'Me.Tồn = Tồn_Thực.Tồn
                'If Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Giá_bán = 0 Then
                '    Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Giá_bán = Me.Tồn_Kho.Giá
                'End If
                'Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Giá_vốn = Me.Tồn_Kho.Giá_nhập
            Catch ex As Exception

            End Try ' re' results.AddPropertyError("<Error-Message>")

        End Sub

        Private Sub Xuất_Sản_Phẩm_Validate(results As ScreenValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            Try
                Me.Thang = Me.Xuất_Sản_Phẩm.SelectedItem.Ngày_xuất.Month
                Me.Nam = Xuất_Sản_Phẩm.SelectedItem.Ngày_xuất.Year
            Catch ex As Exception

            End Try
            
        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowXuatSanPhamReportPreviewScreen(Me.Xuất_Sản_Phẩm.SelectedItem.Id, NumToText(Me.Xuất_Sản_Phẩm.SelectedItem.Tổng_tiền)) ' Write your code here.

        End Sub
    End Class

End Namespace
