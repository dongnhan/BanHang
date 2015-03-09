
Namespace LightSwitchApplication

    Public Class BangGiaChiTiet

        Private Sub Giá_bán_Validate(results As EntityValidationResultsBuilder)
            Me.Giá_bán = Giá_vốn + Chi_phí ' results.AddPropertyError("<Error-Message>")

        End Sub

        Private Sub SanPham_Validate(results As EntityValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")

        End Sub
    End Class

End Namespace
