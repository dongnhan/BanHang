
Namespace LightSwitchApplication

    Public Class ChonMon1

  
        Private Sub Thành_tiền_Validate(results As EntityValidationResultsBuilder)
            Dim tien = 0.0
            For Each d In ChonMonChiTiets
                tien += d.Thành_tiền
            Next
            If tien > 0 Then
                Me.Thành_tiền = tien
            End If ' results.AddPropertyError("<Error-Message>")

        End Sub

        Private Sub Tổng_tiền_Validate(results As EntityValidationResultsBuilder)
            Me.Tổng_tiền = Thành_tiền - Tiền_giảm
        End Sub
    End Class

End Namespace
