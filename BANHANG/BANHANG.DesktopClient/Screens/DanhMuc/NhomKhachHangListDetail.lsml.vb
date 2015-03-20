
Namespace LightSwitchApplication

    Public Class NhomKhachHangListDetail

        Private Sub Nhóm_Đối_TượngItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhóm_Đối_TượngItemListAddAndEditNew_Execute()
            Me.NhomKhachHang.AddNew() ' Write your code here.
            Me.FindControl("Tên1").Focus()
            Me.NhomKhachHang.SelectedItem.Là_nhóm_Khách_Hàng = True
            Me.NhomKhachHang.SelectedItem.Là_nhóm_Nhà_Cung_Cấp = False
        End Sub
    End Class

End Namespace
