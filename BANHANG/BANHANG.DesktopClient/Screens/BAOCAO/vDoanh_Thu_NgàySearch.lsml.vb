
Namespace LightSwitchApplication

    Public Class vDoanh_Thu_NgàySearch

        Private Sub vDoanh_Thu_NgàySearch_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Me.Từ_ngày = getNgayDauThang(Today) ' Write your code here.
            Me.Đến_ngày = getNgayCuoiThang(Today) 'Write your code here.' Write your code here.

        End Sub
    End Class

End Namespace
