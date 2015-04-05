
Namespace LightSwitchApplication

    Public Class MónItem1

        Private Sub Tên_Giá_Compute(ByRef result As String)
            result = Me.Tên + " " + Format(Giá, "N0").ToString ' Set result to the desired field value

        End Sub
    End Class

End Namespace
