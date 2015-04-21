Imports DevExpress.Xpf.Printing
Namespace LightSwitchApplication

    Public Class vDoanhThuQuanTongHopReportPreviewScreen
        Private model As ReportPreviewModel
        ' Do not rename the CustomizeReportPreviewModel method because it is used to access the ReportPreviewModel that is associated with this Report Preview Screen.
        ' You can remove this method if you do not need to access the ReportPreviewModel.
        Public Sub CustomizeReportPreviewModel(model As DevExpress.Xpf.Printing.ReportPreviewModel)
            Me.model = model
            model.Parameters("TuNgay").Value = Me.TuNgay
            model.Parameters("DenNgay").Value = Me.DenNgay
            model.CreateDocument()
        End Sub

        Private Sub vDoanhThuQuanTongHopReportPreviewScreen_Activated()
            ' Assign the name of the report, which you want to preview in this screen.
            Me.ReportTypeName = "XtraReport_DoanhThuQuanTongHop"
        End Sub

    End Class

End Namespace