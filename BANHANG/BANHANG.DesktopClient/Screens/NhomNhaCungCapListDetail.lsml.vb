
Namespace LightSwitchApplication

    Public Class NhomNhaCungCapListDetail

        Private Sub Nhóm_Đối_TượngItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhóm_Đối_TượngItemListAddAndEditNew_Execute()
            Me.NhomNhaCungCap.AddNew()
            Me.NhomNhaCungCap.SelectedItem.Là_nhóm_Khách_Hàng = False
            Me.NhomNhaCungCap.SelectedItem.Là_nhóm_Nhà_Cung_Cấp = True
            Me.FindControl("Tên1").Focus() ' Write your code here.

        End Sub
    End Class

End Namespace
