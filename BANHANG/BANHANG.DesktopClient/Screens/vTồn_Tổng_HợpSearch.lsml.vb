
Namespace LightSwitchApplication

    Public Class vTồn_Tổng_HợpSearch

        Private Sub vTồn_Tổng_HợpSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Dim thang = Me.DataWorkspace.BanHangData.Thang_Single(Today.Month)
            Me.Tháng = thang ' Write your code here.
            Dim nam = Me.DataWorkspace.BanHangData.Nam_Single(Today.Year)
            Me.Năm = nam ' Write your code here.' Write your code here.

        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowvTonTongHopReportPreviewScreen(Me.Tháng.Id, Me.Năm.Id) ' Write your code here.

        End Sub
    End Class

End Namespace
