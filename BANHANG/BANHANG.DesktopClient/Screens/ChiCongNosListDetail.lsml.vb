
Namespace LightSwitchApplication

    Public Class ChiCongNosListDetail
        Dim flagEdit As Boolean
        Private Sub ChiCongNoListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub ChiCongNoListAddAndEditNew_Execute()
            ' Write your code here.
            Me.ChiCongNos.AddNew()
            Me.FindControl("Đối_TượngItem1").Focus()
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Chi_Công_Nợ_Chi_Tiết.SelectedItem, ChiCongNoChiTiet).Details.DiscardChanges()
            Else
                Me.Chi_Công_Nợ_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Chi_Công_Nợ_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Chi_Công_Nợ_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Chi_Công_Nợ_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Chi_Công_Nợ_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Chi_Công_Nợ_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub
    End Class

End Namespace
