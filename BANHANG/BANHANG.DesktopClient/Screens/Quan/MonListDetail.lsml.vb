
Namespace LightSwitchApplication

    Public Class MonListDetail
        Dim flagEdit As Boolean
        Private Sub MónItem1ListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub MónItem1ListAddAndEditNew_Execute()
            ' Write your code here.
            Me.Mon.AddNew()
            Me.FindControl("Mã1").Focus()
            Me.Mon.SelectedItem.Tình_trạng = 0
        End Sub
        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.MonDinhLuongs.SelectedItem, MonDinhLuong).Details.DiscardChanges()
            Else
                Me.MonDinhLuongs.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub


        Private Sub MonDinhLuongsAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub MonDinhLuongsAddAndEditNew_Execute()
            ' Write your code here.
            Me.MonDinhLuongs.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub MonDinhLuongsEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub MonDinhLuongsEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub
    End Class

End Namespace
