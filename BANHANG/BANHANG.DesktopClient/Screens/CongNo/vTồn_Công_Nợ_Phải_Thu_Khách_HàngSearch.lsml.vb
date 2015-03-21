
Namespace LightSwitchApplication

    Public Class vTồn_Công_Nợ_Phải_Thu_Khách_HàngSearch

        Private Sub vTồn_Công_Nợ_Phải_Thu_Khách_HàngSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Dim kh = DataWorkspace.BanHangData.KhachHang.FirstOrDefault ' Write your code here.
            Me.Khách_Hàng = kh
            Dim thang = Me.DataWorkspace.BanHangData.Thang_Single(Today.Month)
            Me.Tháng = thang ' Write your code here.
            Dim nam = Me.DataWorkspace.BanHangData.Nam_Single(Today.Year)
            Me.Năm = nam
        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowvTonCongNoPhaiThuKhachHangReportPreviewScreen(Me.Tháng.Id, Me.Năm.Id, Me.Khách_Hàng.Id, Me.Khách_Hàng.Tên)

        End Sub
    End Class

End Namespace
