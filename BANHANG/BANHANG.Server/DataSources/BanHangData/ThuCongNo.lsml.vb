
Namespace LightSwitchApplication

    Public Class ThuCongNo

        Private Sub Số_tiền_Validate(results As EntityValidationResultsBuilder)
            Dim tien = 0.0
            For Each d In Thu_Công_Nợ_Chi_Tiết
                tien += d.Số_tiền
            Next
            If tien > 0 Then
                Số_tiền = tien
            End If ' results.AddPropertyError("<Error-Message>")

        End Sub
    End Class

End Namespace
