
Namespace LightSwitchApplication

    Public Class Khu_VựcListDetail

        Private Sub Khu_VựcItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Khu_VựcItemListAddAndEditNew_Execute()
            Me.Khu_Vực.AddNew() ' Write your code here.
            Me.FindControl("Mã1").Focus()
        End Sub
    End Class

End Namespace
