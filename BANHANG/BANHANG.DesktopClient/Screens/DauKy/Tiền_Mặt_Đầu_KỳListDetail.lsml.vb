
Namespace LightSwitchApplication

    Public Class Tiền_Mặt_Đầu_KỳListDetail

        Private Sub Tiền_Mặt_Đầu_KỳListDetail_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            If Me.Tiền_Mặt_Đầu_Kỳ.SelectedItem IsNot Nothing Then
                '0: ko cho xuất âm
                '1: xuất âm
                '2: xuất từ danh mục
                'Me.Application.KiemTraTonKho = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Kiểm_tra_tồn_kho
            Else
                Me.Tiền_Mặt_Đầu_Kỳ.AddNew()
                Me.FindControl("Số_tiền1").Focus()
            End If
        End Sub
    End Class

End Namespace
