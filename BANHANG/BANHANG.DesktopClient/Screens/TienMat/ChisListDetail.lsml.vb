
Namespace LightSwitchApplication

    Public Class ChisListDetail
        Dim flagEdit As Boolean
        Private Sub ChiListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub ChiListAddAndEditNew_Execute()
            ' Write your code here.
            Me.Chis.AddNew()
            Me.FindControl("Đối_TượngItem1").Focus()
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
            Me.FindControl("Chi_Chi_TiếtAddAndEditNew").Focus()
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Chi_Chi_Tiết.SelectedItem, ChiChiTiet).Details.DiscardChanges()
            Else
                Me.Chi_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Chi_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Chi_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Chi_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Chi_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Chi_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowChiReportPreviewScreen(Me.Chis.SelectedItem.Id, NumToText(Me.Chis.SelectedItem.Số_tiền)) ' Write your code here.

        End Sub
    End Class

End Namespace
