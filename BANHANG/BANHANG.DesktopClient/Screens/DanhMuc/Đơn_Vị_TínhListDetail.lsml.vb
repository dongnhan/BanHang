
Namespace LightSwitchApplication

    Public Class Đơn_Vị_TínhListDetail

        Private Sub Đơn_Vị_TínhItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Đơn_Vị_TínhItemListAddAndEditNew_Execute()
            Me.Đơn_Vị_Tính.AddNew() ' Write your code here.
            Me.FindControl("Tên1").Focus()
        End Sub
    End Class

End Namespace
