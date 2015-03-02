
Namespace LightSwitchApplication

    Public Class ThusListDetail
        Dim flagEdit As Boolean
        Private Sub ThuListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub ThuListAddAndEditNew_Execute()
            ' Write your code here.
            Me.Thus.AddNew()
            Me.FindControl("Đối_TượngItem1").Focus()
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
            Me.FindControl("Thu_Chi_TiếtAddAndEditNew").Focus()
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Thu_Chi_Tiết.SelectedItem, ThuChiTiet).Details.DiscardChanges()
            Else
                Me.Thu_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Thu_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Thu_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Thu_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Thu_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Thu_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub

        Private Sub Báo_cáo_Execute()
            ' Write your code here.
            Me.Application.ShowThuReportPreviewScreen(Me.Thus.SelectedItem.Id, NumToText(Me.Thus.SelectedItem.Số_tiền))
        End Sub
    End Class

End Namespace
