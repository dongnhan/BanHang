
Namespace LightSwitchApplication

    Public Class vTồn_Quỹ_Tiền_MặtSearch

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowvTonQuyTienMatReportPreviewScreen(Me.Tháng.Id, Me.Năm.Id) ' Write your code here.

        End Sub

        Private Sub vTồn_Quỹ_Tiền_MặtSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Dim thang = Me.DataWorkspace.BanHangData.Thang_Single(Today.Month)
            Me.Tháng = thang ' Write your code here.
            Dim nam = Me.DataWorkspace.BanHangData.Nam_Single(Today.Year)
            Me.Năm = nam ' Write your code here.

        End Sub
    End Class

End Namespace
