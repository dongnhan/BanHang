
Namespace LightSwitchApplication

    Public Class BànListDetail

        Private Sub BànItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub BànItemListAddAndEditNew_Execute()
            Me.Bàn.AddNew() ' Write your code here.
            Me.FindControl("Mã1").Focus()
        End Sub
    End Class

End Namespace
