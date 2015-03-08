
Namespace LightSwitchApplication

    Public Class MainListDetail

        Private Sub MainListDetail_Activated()
            Me.Application.TenDonVi = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Tên ' Write your code here.
            Me.Application.DiaChiDonVi = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Địa_chỉ
            Me.Application.KiemTraTonKho = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Kiểm_tra_tồn_kho
        End Sub
    End Class

End Namespace
