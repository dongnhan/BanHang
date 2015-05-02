
Namespace LightSwitchApplication

    Public Class ChonMonsListDetail
        Dim flagEdit As Boolean
        Private Sub ChonMon1ListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub ChonMon1ListAddAndEditNew_Execute()
            ' Write your code here.
            Me.ChonMons.AddNew()
            Me.FindControl("BànItem1").Focus()
        End Sub

        Private Sub OK_Execute()
            ' Write your code here.
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub Hủy_Execute()
            ' Write your code here.
            If flagEdit Then
                CType(Me.ChonMonChiTiets.SelectedItem, ChonMonChiTiet1).Details.DiscardChanges()
            Else
                Me.ChonMonChiTiets.DeleteSelected()
            End If
            Me.CloseModalWindow("GroupChiTiet")
        End Sub

        Private Sub ChonMonChiTietsAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub ChonMonChiTietsAddAndEditNew_Execute()
            ' Write your code here.
            Me.ChonMonChiTiets.AddNew()
            Me.ChonMonChiTiets.SelectedItem.Số_lượng = 1
            'Me.ChonMonChiTiets.SelectedItem.SoLuong = Me.DataWorkspace.BanHangDataQuan.SoLuongs_Single(1)
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
        End Sub

        Private Sub ChonMonChiTietsEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub ChonMonChiTietsEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub

        Private Sub Báo_cáo_Execute()
            Me.Application.ShowPhieuTinhTienReportPreviewScreen(Me.ChonMons.SelectedItem.Id) ' Write your code here.

        End Sub
    End Class

End Namespace
