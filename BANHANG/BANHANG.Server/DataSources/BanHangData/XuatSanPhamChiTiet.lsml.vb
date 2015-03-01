
Namespace LightSwitchApplication

    Public Class XuatSanPhamChiTiet

        Private Sub Thành_tiền_Compute(ByRef result As Decimal)
            ' Set result to the desired field value
            result = Số_lượng * Giá_bán
        End Sub

        Private Sub Tiền_thuế_Compute(ByRef result As Decimal)
            result = Số_lượng * Giá_bán * Phần_trăm_thuế
        End Sub

        Private Sub Tổng_tiền_Compute(ByRef result As Decimal)
            result = Thành_tiền + Tổng_tiền
        End Sub
    End Class

End Namespace
