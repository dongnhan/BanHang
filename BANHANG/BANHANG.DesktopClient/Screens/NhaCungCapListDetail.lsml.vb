
Namespace LightSwitchApplication

    Public Class NhaCungCapListDetail

        Private Sub Đối_TượngItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Đối_TượngItemListAddAndEditNew_Execute()
            Me.NhaCungCap.AddNew() ' Write your code here.
            Me.NhaCungCap.SelectedItem.Là_Khách_Hàng = False
            Me.NhaCungCap.SelectedItem.Là_Nhà_Cung_Cấp = True
            Me.FindControl("Tên1").Focus()
        End Sub
    End Class

End Namespace
