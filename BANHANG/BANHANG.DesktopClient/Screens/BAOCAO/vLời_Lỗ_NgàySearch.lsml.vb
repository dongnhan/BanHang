
Namespace LightSwitchApplication

    Public Class vLời_Lỗ_NgàySearch

        Private Sub vLời_Lỗ_NgàySearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Me.Từ_ngày = getNgayDauThang(Today) ' Write your code here.
            Me.Đến_ngày = getNgayCuoiThang(Today)
        End Sub
    End Class

End Namespace
