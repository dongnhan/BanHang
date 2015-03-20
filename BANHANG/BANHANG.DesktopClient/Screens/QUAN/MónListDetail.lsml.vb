
Namespace LightSwitchApplication

    Public Class MónListDetail

        Private Sub MónItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub MónItemListAddAndEditNew_Execute()
            Me.Món.AddNew() ' Write your code here.
            Me.FindControl("Mã1").Focus()
            Me.Món.SelectedItem.Tình_trạng = 0
        End Sub
    End Class

End Namespace
