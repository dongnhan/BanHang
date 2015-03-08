
Namespace LightSwitchApplication

    Public Class Nhóm_Sản_PhẩmListDetail

        Private Sub Nhóm_Sản_PhẩmItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhóm_Sản_PhẩmItemListAddAndEditNew_Execute()
            Me.Nhóm_Sản_Phẩm.AddNew() ' Write your code here.
            Me.FindControl("Tên1").Focus()
        End Sub
    End Class

End Namespace
