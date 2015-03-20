
Namespace LightSwitchApplication

    Public Class vLời_Lỗ_Ngày_Theo_Khách_HàngSearch

        Private Sub Báo_cáo_tất_cả_Khách_Hàng_Execute()
            ' Write your code here.
            Me.Application.ShowvLoiLoAllKhachHangReportPreviewScreen(Me.Từ_ngày, Me.Đến_ngày)
        End Sub

        Private Sub vLời_Lỗ_Ngày_Theo_Khách_HàngSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Dim khachhang = DataWorkspace.BanHangData.KhachHang.FirstOrDefault ' Write your code here.
            Me.Khách_Hàng = khachhang
        End Sub

        Private Sub Báo_cáo_từng_Khách_Hàng_Execute()
            ' Write your code here.

        End Sub
    End Class

End Namespace
