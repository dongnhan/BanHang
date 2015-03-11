Imports System.Collections.ObjectModel
Namespace LightSwitchApplication

    Public Class Xuất_Sản_PhẩmListDetail
        Public dathangchitiet As New ObservableCollection(Of DatHangChiTiet)()
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
            'ẩn sản phẩm nếu KiemTraTonKho = 0
            If Me.Application.KiemTraTonKho = 0 Then
                'FindControl("Tồn_Thực").SetProperty("IsReadOnly", False)
                'FindControl("Sản_Phẩm").SetProperty("IsReadOnly", True)
                FindControl("Tồn_Thực").IsVisible = True
                FindControl("Sản_Phẩm").IsVisible = False
            End If
            'ẩn tồn_thực nếu KiemTraTonKho = 2
            If Me.Application.KiemTraTonKho = 2 Then
                'FindControl("Tồn_Thực").SetProperty("IsReadOnly", False)
                'FindControl("Sản_Phẩm").SetProperty("IsReadOnly", True)
                FindControl("Tồn_Thực").IsVisible = False
                FindControl("Sản_Phẩm").IsVisible = True
            End If
            Me.FindControl("Đặt_Hàng_Chi_Tiết").AddCheckBoxColumnForMultiSelection(Of DatHangChiTiet)(dathangchitiet)
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
                Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.KiemTraTonKho = Me.Application.KiemTraTonKho
                Dim donvitinh = DataWorkspace.BanHangData.DonViTinh_Single(DataWorkspace.BanHangData.SanPham_Single(Tồn_Thực.Mã_Sản_Phẩm).Đơn_Vị_TínhItem.Id)
                Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Đơn_Vị_TínhItem = donvitinh
                If IsNothing(Me.Xuất_Sản_Phẩm.SelectedItem.BangGia.Id) = True Then 'nếu chưa chọn bảng giá
                    Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Giá_bán = Tồn_Thực.Giá
                Else
                    For Each d In Me.Bảng_Giá_Chi_Tiết
                        If Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.SanPham.Id = d.SanPham.Id Then
                            Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Giá_bán = d.Giá_bán
                        End If
                    Next
                End If

                'Dim gianhap As Decimal = Convert.ToDecimal(Math.Round(Tồn_Thực.Giá_nhập, 2))
                Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Giá_vốn = Tồn_Thực.Giá_nhập
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

        Private Sub Xuất_Sản_Phẩm_Chi_Tiết_Validate(results As ScreenValidationResultsBuilder)
            Try
                If Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Số_lượng = 0 Then
                    results.AddPropertyError("Phải chọn số lượng xuất khác 0")
                    Me.OpenModalWindow("GroupChiTiet")
                End If
            Catch ex As Exception

            End Try
            ' results.AddPropertyError("<Error-Message>")

        End Sub

        Private Sub Sản_Phẩm_Validate(results As ScreenValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            Try

                Dim sanpham = DataWorkspace.BanHangData.SanPham_Single(Sản_Phẩm.Id)
                Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.SanPham = sanpham
                'Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.TonThuc = Tồn_Thực.Tồn
                'Me.Tồn = Tồn_Thực.Tồn
                'Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.KiemTraTonKho = Me.Application.KiemTraTonKho
                Dim donvitinh = DataWorkspace.BanHangData.DonViTinh_Single(Sản_Phẩm.Đơn_Vị_TínhItem.Id)
                Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Đơn_Vị_TínhItem = donvitinh
                Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Giá_bán = Sản_Phẩm.Giá
                'Dim gianhap As Decimal = Convert.ToDecimal(Math.Round(Tồn_Thực.Giá_nhập, 2))
                'Me.Xuất_Sản_Phẩm_Chi_Tiết.SelectedItem.Giá_vốn = Tồn_Thực.Giá_nhập

            Catch ex As Exception

            End Try
        End Sub

        Private Sub Chọn_tất_cả_Execute()
            ' Write your code here.
            Dim pageCount As Integer = Me.Details.Properties.Đặt_Hàng_Chi_Tiết.PageCount
            Dim CurrentPageNumber As Integer = 1
            For i As Integer = 0 To pageCount
                Me.Details.Properties.Đặt_Hàng_Chi_Tiết.PageNumber = CurrentPageNumber
                CurrentPageNumber = CurrentPageNumber + 1
                '=====DO WORKS HERE======//
                For Each p As DatHangChiTiet In Đặt_Hàng_Chi_Tiết
                    dathangchitiet.Add(p)
                Next
            Next
            Đặt_Hàng_Chi_Tiết.Refresh()
            Me.Details.Properties.Đặt_Hàng_Chi_Tiết.PageNumber = 1 ' Write your code here.
        End Sub

        Private Sub Bỏ_tất_cả_Execute()
            ' Write your code here.
            Dim pageCount As Integer = Me.Details.Properties.Đặt_Hàng_Chi_Tiết.PageCount
            Dim CurrentPageNumber As Integer = 1
            For i As Integer = 0 To pageCount
                Me.Details.Properties.Đặt_Hàng_Chi_Tiết.PageNumber = CurrentPageNumber
                CurrentPageNumber = CurrentPageNumber + 1
                '=====DO WORKS HERE======//
                For Each p As DatHangChiTiet In Đặt_Hàng_Chi_Tiết
                    dathangchitiet.Remove(p)
                Next
            Next
            Đặt_Hàng_Chi_Tiết.Refresh()
            Me.Details.Properties.Đặt_Hàng_Chi_Tiết.PageNumber = 1 ' Write your code here.
        End Sub

        Private Sub Chuyển_qua_Execute()
            ' Write your code here.
            For Each item In dathangchitiet
                Dim xuatchitiet As XuatSanPhamChiTiet = Xuất_Sản_Phẩm_Chi_Tiết.AddNew
                xuatchitiet.Số_lượng = item.Số_lượng
                xuatchitiet.SanPham = item.SanPham
                xuatchitiet.Đơn_Vị_TínhItem = item.SanPham.Đơn_Vị_TínhItem
            Next
            Me.Bỏ_tất_cả() ' Write your code here.
        End Sub
    End Class

End Namespace
