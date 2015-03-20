
Namespace LightSwitchApplication

    Public Class vDoanh_Thu_Ngày_Theo_Khách_HàngSearch

        Private Sub vDoanh_Thu_Ngày_Theo_Khách_HàngSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Dim khachhang = Me.DataWorkspace.BanHangData.KhachHang.FirstOrDefault ' Write your code here.
            Me.Khách_Hàng = khachhang

        End Sub

        Private Sub Báo_cáo_tất_cả_Khách_Hàng_Execute()
            Me.Application.ShowvDoanhThuAllKhachHangReportPreviewScreen(Me.Từ_ngày, Me.Đến_ngày) ' Write your code here.

        End Sub

        Private Sub Báo_cáo_từng_Khách_Hàng_Execute()
            Me.Application.ShowvDoanhThuKhachHangReportPreviewScreen(Me.Từ_ngày, Me.Đến_ngày, Me.Khách_Hàng.Id, Me.Khách_Hàng.Tên) ' Write your code here.

        End Sub
    End Class

End Namespace
