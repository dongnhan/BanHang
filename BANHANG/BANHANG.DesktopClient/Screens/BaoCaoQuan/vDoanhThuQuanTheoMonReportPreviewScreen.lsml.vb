Imports DevExpress.Xpf.Printing
Namespace LightSwitchApplication

    Public Class vDoanhThuQuanTheoMonReportPreviewScreen
        Private model As ReportPreviewModel
        ' Do not rename the CustomizeReportPreviewModel method because it is used to access the ReportPreviewModel that is associated with this Report Preview Screen.
        ' You can remove this method if you do not need to access the ReportPreviewModel.
        Public Sub CustomizeReportPreviewModel(model As DevExpress.Xpf.Printing.ReportPreviewModel)
            Me.model = model
            model.Parameters("TuNgay").Value = Me.TuNgay
            model.Parameters("DenNgay").Value = Me.DenNgay
            model.CreateDocument()
        End Sub

        Private Sub vDoanhThuQuanTheoMonReportPreviewScreen_Activated()
            ' Assign the name of the report, which you want to preview in this screen.
            Me.ReportTypeName = "XtraReport_DoanhThuQuanTheoMon"
        End Sub

    End Class

End Namespace