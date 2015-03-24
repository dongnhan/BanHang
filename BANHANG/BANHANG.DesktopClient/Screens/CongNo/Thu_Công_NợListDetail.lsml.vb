
Namespace LightSwitchApplication

    Public Class Thu_Công_NợListDetail
        Dim flagEdit As Boolean
        Private Sub Thu_Công_NợItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Thu_Công_NợItemListAddAndEditNew_Execute()
            ' Write your code here.
            Me.Thu_Công_Nợ.AddNew()
            Me.FindControl("Đối_TượngItem1").Focus()
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Thu_Công_Nợ_Chi_Tiết.SelectedItem, Thu_Công_Nợ_Chi_TiếtItem).Details.DiscardChanges()
            Else
                Me.Thu_Công_Nợ_Chi_Tiết.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Thu_Công_Nợ_Chi_TiếtAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Thu_Công_Nợ_Chi_TiếtAddAndEditNew_Execute()
            ' Write your code here.
            Me.Thu_Công_Nợ_Chi_Tiết.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Thu_Công_Nợ_Chi_TiếtEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Thu_Công_Nợ_Chi_TiếtEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub
    End Class

End Namespace
