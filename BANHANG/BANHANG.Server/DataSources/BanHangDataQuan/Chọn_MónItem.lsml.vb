
Namespace LightSwitchApplication

    Public Class Chọn_MónItem

        Private Sub Thành_tiền_Compute(ByRef result As Decimal)
            Dim tien = 0.0
            For Each d In Chọn_Món_Chi_Tiết
                tien += d.Thành_tiền
            Next
            If tien > 0 Then
                result = tien
            End If ' Set result to the desired field value

        End Sub
    End Class

End Namespace
