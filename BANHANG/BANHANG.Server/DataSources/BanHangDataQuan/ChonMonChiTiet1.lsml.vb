
Namespace LightSwitchApplication

    Public Class ChonMonChiTiet1

        Private Sub Thành_tiền_Validate(results As EntityValidationResultsBuilder)
            Me.Thành_tiền = Me.Số_lượng * Giá ' results.AddPropertyError("<Error-Message>")

        End Sub

        Private Sub MónItem_Validate(results As EntityValidationResultsBuilder)
            Try
                Me.Giá = Me.MónItem.Giá
            Catch ex As Exception

            End Try
            ' results.AddPropertyError("<Error-Message>")

        End Sub

        Private Sub SoLuong_Validate(results As EntityValidationResultsBuilder)
            'Try
            '    Me.Thành_tiền = Me.SoLuong.Id * Giá

            'Catch ex As Exception

            'End Try
            ' results.AddPropertyError("<Error-Message>")

        End Sub

        Private Sub Tiền_giảm_Validate(results As EntityValidationResultsBuilder)
            'Me.ChonMon_Validate(results) ' results.AddPropertyError("<Error-Message>")
        End Sub

       
        Private Sub Thanh_tien_Compute(ByRef result As Decimal)
            result = Số_lượng * Giá
        End Sub
    End Class

End Namespace
