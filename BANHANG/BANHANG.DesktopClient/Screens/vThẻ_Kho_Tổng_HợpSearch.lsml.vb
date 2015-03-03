
Namespace LightSwitchApplication

    Public Class vThẻ_Kho_Tổng_HợpSearch

        Private Sub vThẻ_Kho_Tổng_HợpSearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Dim thang = Me.DataWorkspace.BanHangData.Tháng_Single(Today.Month)
            Me.Tháng = thang ' Write your code here.
            Dim nam = Me.DataWorkspace.BanHangData.Năm_Single(Today.Year)
            Me.Năm = nam
        End Sub

        Private Sub Sản_Phẩm_Validate(results As ScreenValidationResultsBuilder)
               Dim CuoiKy As Integer = 0
            Dim acc As Integer
            For Each r In vThẻ_Kho_Tổng_Hợp
                acc = acc + 1
                If acc = 1 Then
                    If (r.Tồn = 0 And r.Nhập <> 0) Or (r.Tồn = 0 And r.Xuất <> 0) Then
                        CuoiKy = r.Nhập - r.Xuất
                        r.Tồn = CuoiKy
                    Else
                        CuoiKy = r.Tồn
                    End If
                Else
                    r.Tồn = CuoiKy + r.Nhập - r.Xuất
                End If
                If acc > 1 Then
                    CuoiKy = r.Tồn
                End If
            Next
            'ts.AddPropertyError("<Error-Message>")

        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowvTheKhoReportPreviewScreen(Me.Tháng.Id, Me.Năm.Id, Me.Sản_Phẩm.Id)

        End Sub

        Private Sub vThẻ_Kho_Tổng_HợpSearch_Closing(ByRef cancel As Boolean)
            Me.DataWorkspace.BanHangData.Details.DiscardChanges() ' Write your code here.
            Me.Close(True)
        End Sub
    End Class

End Namespace
