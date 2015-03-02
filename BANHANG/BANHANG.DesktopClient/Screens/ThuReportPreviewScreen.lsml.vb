Imports DevExpress.Xpf.Printing
Namespace LightSwitchApplication

    Public Class ThuReportPreviewScreen
        Private model As ReportPreviewModel
        ' Do not rename the CustomizeReportPreviewModel method because it is used to access the ReportPreviewModel that is associated with this Report Preview Screen.
        ' You can remove this method if you do not need to access the ReportPreviewModel.
        Public Sub CustomizeReportPreviewModel(model As DevExpress.Xpf.Printing.ReportPreviewModel)
            Me.model = model
            model.Parameters("TenDonVi").Value = Me.Application.TenDonVi
            model.Parameters("DiaChiDonVi").Value = Me.Application.DiaChiDonVi
            model.Parameters("Id").Value = Me.Id
            model.Parameters("SoTienThanhChu").Value = Me.SoTienThanhChu
            model.CreateDocument()
        End Sub

        Private Sub ThuReportPreviewScreen_Activated()
            ' Assign the name of the report, which you want to preview in this screen.
            Me.ReportTypeName = "XtraReport_Thu"
        End Sub

    End Class

End Namespace