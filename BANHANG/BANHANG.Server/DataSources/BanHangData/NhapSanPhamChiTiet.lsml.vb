
Namespace LightSwitchApplication

    Public Class NhapSanPhamChiTiet

        Private Sub Thành_tiền_Compute(ByRef result As Decimal)
            ' Set result to the desired field value
            result = Số_lượng * Giá_nhập
        End Sub

        Private Sub Tiền_thuế_Compute(ByRef result As Decimal)
            result = Số_lượng * Giá_nhập * Phần_trăm_thuế
        End Sub

        Private Sub Tổng_tiền_Compute(ByRef result As Decimal)
            result = Thành_tiền + Tiền_thuế
        End Sub

        Private Sub SanPham_Validate(results As EntityValidationResultsBuilder)
            Try
                Dim dvt As Đơn_Vị_TínhItem = Me.DataWorkspace.BanHangData.DonViTinh_Single(Me.SanPham.Đơn_Vị_TínhItem.Id)
                Me.Đơn_Vị_TínhItem = dvt
            Catch ex As Exception

            End Try ' results.AddPropertyError("<Error-Message>")

        End Sub
    End Class

End Namespace
