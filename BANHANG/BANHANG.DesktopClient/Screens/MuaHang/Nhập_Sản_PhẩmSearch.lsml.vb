
Namespace LightSwitchApplication

    Public Class Nhập_Sản_PhẩmSearch

        Private Sub Nhập_Sản_PhẩmSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Me.Từ_ngày = getNgayDauThang(Today) ' Write your code here.
            Me.Đến_ngày = getNgayCuoiThang(Today)
        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowSoChiTietMuaHangReportPreviewScreen(Me.Từ_ngày, Me.Đến_ngày) ' Write your code here.

        End Sub
    End Class

End Namespace
