
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

     
        Private Sub Tiền_giảm_Validate(results As EntityValidationResultsBuilder)
            Me.Tổng_tiền = Thành_tiền - Tiền_giảm
        End Sub

        Private Sub Giảm_giá_Validate(results As EntityValidationResultsBuilder)
            Try
                If Giảm_giá = 0 Then
                    Tiền_giảm = 0
                End If
                If Giảm_giá = 1 Then
                    Tiền_giảm = Thành_tiền * 10 / 100
                End If
                If Giảm_giá = 2 Then
                    Tiền_giảm = Thành_tiền * 20 / 100
                End If
            Catch ex As Exception

            End Try
            ' results.AddPropertyError("<Error-Message>")

        End Sub
    End Class

End Namespace
