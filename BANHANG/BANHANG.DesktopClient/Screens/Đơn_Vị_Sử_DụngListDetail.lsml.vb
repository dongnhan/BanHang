
Namespace LightSwitchApplication

    Public Class Đơn_Vị_Sử_DụngListDetail

       
        Private Sub Đơn_Vị_Sử_DụngListDetail_Activated()
            If Đơn_Vị_Sử_Dụng.SelectedItem IsNot Nothing Then
                '0: ko cho xuất âm
                '1: xuất âm
                '2: xuất từ danh mục
                'Me.Application.KiemTraTonKho = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Kiểm_tra_tồn_kho
            Else
                Me.Đơn_Vị_Sử_Dụng.AddNew()
                Me.FindControl("Tên1").Focus()
            End If
            ' Write your code here.
        End Sub
    End Class

End Namespace
