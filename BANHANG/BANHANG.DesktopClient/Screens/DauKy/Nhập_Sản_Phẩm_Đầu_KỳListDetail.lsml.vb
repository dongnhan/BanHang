
Namespace LightSwitchApplication

    Public Class Nhập_Sản_Phẩm_Đầu_KỳListDetail

        Private Sub Nhập_Sản_Phẩm_Đầu_KỳItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhập_Sản_Phẩm_Đầu_KỳItemListAddAndEditNew_Execute()
            Me.Nhập_Sản_Phẩm_Đầu_Kỳ.AddNew() ' Write your code here.
            Me.FindControl("Ghi_chú1").Focus()
        End Sub
    End Class

End Namespace
