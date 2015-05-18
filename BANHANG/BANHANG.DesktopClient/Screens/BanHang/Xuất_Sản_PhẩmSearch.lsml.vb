
Namespace LightSwitchApplication

    Public Class Xuất_Sản_PhẩmSearch

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowSoChiTietBanHangReportPreviewScreen(Me.Từ_ngày, Me.Đến_ngày) ' Write your code here.

        End Sub

        Private Sub Xuất_Sản_PhẩmSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Me.Từ_ngày = getNgayDauThang(Today) ' Write your code here.
            Me.Đến_ngày = getNgayCuoiThang(Today) ' Write your code here.

        End Sub
    End Class

End Namespace
