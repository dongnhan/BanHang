
Namespace LightSwitchApplication

    Public Class Nhập_Sản_Phẩm_Chi_TiếtItem

        Private Sub Thành_tiền_Compute(ByRef result As Decimal)
            result = Số_lượng * Giá_nhập ' Set result to the desired field value

        End Sub

        Private Sub Tiền_thuế_Compute(ByRef result As Decimal)
            result = Số_lô * Giá_nhập * Phần_trăm_thuế
        End Sub

        Private Sub Tổng_tiền_Compute(ByRef result As Decimal)
            result = Thành_tiền + Tiền_thuế
        End Sub

        Private Sub Sản_PhẩmItem_Validate(results As EntityValidationResultsBuilder)
            Try
                Dim dvt As Đơn_Vị_TínhItem1 = Me.DataWorkspace.BanHangData1.Đơn_Vị_Tính_Single(Me.Sản_PhẩmItem.Đơn_Vị_TínhItem.Id)
                Me.Đơn_Vị_TínhItem = dvt
            Catch ex As Exception

            End Try ' results.AddPropertyError("<Error-Message>")

        End Sub
    End Class

End Namespace
