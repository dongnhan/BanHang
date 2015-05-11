
Namespace LightSwitchApplication

    Public Class Xuất_Sản_Phẩm_Chi_TiếtItem

        Private Sub Thành_tiền_Compute(ByRef result As Decimal)
            result = Số_lượng * Giá_bán ' Set result to the desired field value

        End Sub

        Private Sub Tiền_thuế_Compute(ByRef result As Decimal)
            result = Số_lượng * Giá_bán * Phần_trăm_thuế
        End Sub

        Private Sub Tổng_tiền_Compute(ByRef result As Decimal)
            result = Thành_tiền + Tiền_thuế
        End Sub
    End Class

End Namespace
