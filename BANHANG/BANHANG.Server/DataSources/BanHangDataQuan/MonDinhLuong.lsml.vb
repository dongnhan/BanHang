
Namespace LightSwitchApplication

    Public Class MonDinhLuong

        Private Sub Sản_PhẩmItem_Validate(results As EntityValidationResultsBuilder)
            Try
                Dim dvt As Đơn_Vị_TínhItem2 = Me.DataWorkspace.BanHangDataQuan.DonViTinh_Single(Me.Sản_PhẩmItem.Đơn_Vị_TínhItem.Id)
                Me.Đơn_Vị_TínhItem = dvt
            Catch ex As Exception

            End Try
            ' results.AddPropertyError("<Error-Message>")

        End Sub
    End Class

End Namespace
