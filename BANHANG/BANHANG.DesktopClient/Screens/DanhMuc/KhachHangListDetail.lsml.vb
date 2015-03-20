
Namespace LightSwitchApplication

    Public Class KhachHangListDetail

        Private Sub Đối_TượngItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Đối_TượngItemListAddAndEditNew_Execute()
            Me.KhachHang.AddNew()
            Me.KhachHang.SelectedItem.Là_Khách_Hàng = True
            Me.KhachHang.SelectedItem.Là_Nhà_Cung_Cấp = False
            Me.FindControl("Tên1").Focus()
        End Sub
    End Class

End Namespace
