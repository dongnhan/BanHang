
Namespace LightSwitchApplication

    Public Class Sản_PhẩmListDetail
        Dim flagEdit As Boolean
        Private Sub SanPhamListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub SanPhamListAddAndEditNew_Execute()
            ' Write your code here.
            Me.Sản_Phẩm.AddNew()
            Me.FindControl("Tên1").Focus()
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
            'Me.FindControl("Chi_Chi_TiếtAddAndEditNew").Focus()
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.Nhóm_của_Sản_Phẩm.SelectedItem, NhomCuaSanPham).Details.DiscardChanges()
            Else
                Me.Nhóm_của_Sản_Phẩm.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Nhóm_của_Sản_PhẩmAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhóm_của_Sản_PhẩmAddAndEditNew_Execute()
            ' Write your code here.
            Me.Nhóm_của_Sản_Phẩm.AddNew()
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub Nhóm_của_Sản_PhẩmEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Nhóm_của_Sản_PhẩmEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub
    End Class

End Namespace
