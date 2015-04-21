
Namespace LightSwitchApplication

    Public Class Sản_PhẩmListDetail1

        Private Sub Sản_PhẩmItem1ListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Sản_PhẩmItem1ListAddAndEditNew_Execute()
            Me.Sản_Phẩm.AddNew() ' Write your code here.
            Me.FindControl("Tên1").Focus()
        End Sub
    End Class

End Namespace
