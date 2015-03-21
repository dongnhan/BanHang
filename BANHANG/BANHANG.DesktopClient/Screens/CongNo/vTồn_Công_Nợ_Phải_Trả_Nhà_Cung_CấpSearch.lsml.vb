
Namespace LightSwitchApplication

    Public Class vTồn_Công_Nợ_Phải_Trả_Nhà_Cung_CấpSearch

        Private Sub vTồn_Công_Nợ_Phải_Trả_Nhà_Cung_CấpSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Dim ncc = DataWorkspace.BanHangData.NhaCungCap.FirstOrDefault ' Write your code here.
            Me.Nhà_Cung_Cấp = ncc
            Dim thang = Me.DataWorkspace.BanHangData.Thang_Single(Today.Month)
            Me.Tháng = thang ' Write your code here.
            Dim nam = Me.DataWorkspace.BanHangData.Nam_Single(Today.Year)
            Me.Năm = nam
        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowvCongNoPhaiTraNhaCungCapReportPreviewScreen(Me.Tháng.Id, Me.Năm.Id, Me.Nhà_Cung_Cấp.Id, Me.Nhà_Cung_Cấp.Tên)

        End Sub
    End Class

End Namespace
