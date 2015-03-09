
Namespace LightSwitchApplication

    Public Class Nhóm_MónListDetail

        Private Sub Nhóm_MónItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhóm_MónItemListAddAndEditNew_Execute()
            Me.Nhóm_Món.AddNew() ' Write your code here.
            Me.FindControl("Mã1").Focus()
        End Sub
    End Class

End Namespace
