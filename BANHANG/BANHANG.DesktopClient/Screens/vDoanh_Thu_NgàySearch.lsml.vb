
Namespace LightSwitchApplication

    Public Class vDoanh_Thu_NgàySearch

        Private Sub vDoanh_Thu_NgàySearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Dim thang = Me.DataWorkspace.BanHangData.Tháng_Single(Today.Month)
            Me.Tháng = thang ' Write your code here.
            Dim nam = Me.DataWorkspace.BanHangData.Năm_Single(Today.Year)
            Me.Năm = nam ' Write your code here.' Write your code here.

        End Sub
    End Class

End Namespace
