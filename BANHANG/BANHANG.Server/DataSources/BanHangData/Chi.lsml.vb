
Namespace LightSwitchApplication

    Public Class Chi

        Private Sub Số_tiền_Validate(results As EntityValidationResultsBuilder)
            Dim tien = 0.0
            For Each d In Chi_Chi_Tiết
                tien += d.Số_tiền
            Next
            If tien > 0 Then
                Me.Số_tiền = tien
            End If ' results.AddPropertyError("<Error-Message>")

        End Sub
    End Class

End Namespace
