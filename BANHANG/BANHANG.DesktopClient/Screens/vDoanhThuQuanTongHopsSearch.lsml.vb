
Namespace LightSwitchApplication

    Public Class vDoanhThuQuanTongHopsSearch

        Private Sub Báo_cáo_Execute()
            Try
                Me.Application.ShowvDoanhThuQuanTongHopReportPreviewScreen(Me.Từ_ngày, Me.Đến_ngày)
            Catch ex As Exception

            End Try
            ' Write your code here.

        End Sub
    End Class

End Namespace
