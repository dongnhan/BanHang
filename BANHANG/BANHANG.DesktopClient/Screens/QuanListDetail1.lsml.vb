
Namespace LightSwitchApplication

    Public Class QuanListDetail1
        Dim flagEdit As Boolean
        Private Sub Báo_cáo_Execute()
            Me.Application.ShowPhieuTinhTienReportPreviewScreen(Me.ChonMons.SelectedItem.Id) ' Write your code here.

        End Sub

        Private Sub ChonMon1ListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.
           
        End Sub

        Private Sub ChonMon1ListAddAndEditNew_Execute()
            ' Write your code here.
            Me.ChonMons.AddNew()
            Me.FindControl("BànItem1").Focus()
            Me.ChonMons.SelectedItem.Trạng_thái = 0
            Me.ChonMons.SelectedItem.Khách_hàng = "Test"
            Me.ChonMons.SelectedItem.UserName = "TestUser"

        End Sub
        Private Sub OK_Execute()
            ' Write your code here.
            Me.FindControl("ChonMonChiTietsAddAndEditNew").Focus()
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
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = False
            Me.FindControl("ChonMonChiTietsAddAndEditNew").Focus()
        End Sub

        Private Sub ChonMonChiTietsEditSelected_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub ChonMonChiTietsEditSelected_Execute()
            ' Write your code here.
            Me.OpenModalWindow("GroupChiTiet") ' Write your code here.
            Me.flagEdit = True
        End Sub

        Private Sub vBàn_Chưa_Tính_Tiền_SelectionChanged()
            Try
                Me.ChonMons.SelectedItem = Me.DataWorkspace.BanHangDataQuan.ChonMons_SingleOrDefault(Me.vBàn_Chưa_Tính_Tiền.SelectedItem.Id)
            Catch ex As Exception

            End Try

        End Sub

        Private Sub vBàn_Chờ_Tính_Tiền_SelectionChanged()
            Try
                Me.ChonMons.SelectedItem = Me.DataWorkspace.BanHangDataQuan.ChonMons_SingleOrDefault(Me.vBàn_Chờ_Tính_Tiền.SelectedItem.Id)
            Catch ex As Exception

            End Try

        End Sub

        Private Sub vBàn_Đã_Tính_Tiền_SelectionChanged()
            Try
                Me.ChonMons.SelectedItem = Me.DataWorkspace.BanHangDataQuan.ChonMons_SingleOrDefault(Me.vBàn_Đã_Tính_Tiền.SelectedItem.Id)
            Catch ex As Exception

            End Try

        End Sub

        Private Sub Tổng_hợp_Execute()
            Try
                Me.Application.ShowvDoanhThuQuanTongHopReportPreviewScreen(Today, Today)
            Catch ex As Exception

            End Try
            ' Write your code here.

        End Sub

        Private Sub Theo_món_Execute()
            ' Write your code here.
            Try
                Me.Application.ShowvDoanhThuQuanTheoMonReportPreviewScreen(Today, Today)
            Catch ex As Exception

            End Try
        End Sub
    End Class

End Namespace
