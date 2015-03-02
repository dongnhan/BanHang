
Namespace LightSwitchApplication

    Public Class MainListDetail

        Private Sub MainListDetail_Activated()
            Me.Application.TenDonVi = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Tên ' Write your code here.
            Me.Application.DiaChiDonVi = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Địa_chỉ
        End Sub
    End Class

End Namespace
