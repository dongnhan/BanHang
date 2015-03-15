
Namespace LightSwitchApplication

    Public Class vLời_Lỗ_Ngày_Theo_Sản_PhẩmSearch

        Private Sub vLời_Lỗ_Ngày_Theo_Sản_PhẩmSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Dim sanpham = Me.DataWorkspace.BanHangData.SanPham.FirstOrDefault ' Write your code here.
            Me.Sản_Phẩm = sanpham

        End Sub

        Private Sub Báo_cáo_tất_cả_Sản_Phẩm_Execute()
            ' Write your code here.

        End Sub

        Private Sub Báo_cáo_từng_Sản_Phẩm_Execute()
            ' Write your code here.
            Me.Application.ShowvLoiLoSanPhamReportPreviewScreen(Me.Từ_ngày, Me.Đến_ngày, Me.Sản_Phẩm.Id, Me.Sản_Phẩm.Tên)
        End Sub
    End Class

End Namespace
