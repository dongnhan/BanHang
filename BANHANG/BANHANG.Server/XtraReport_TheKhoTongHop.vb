Public Class XtraReport_TheKhoTongHop
    Dim ton As Integer
    Dim acc As Integer
    Private Sub xrTableCell_Ton_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles xrTableCell_Ton.BeforePrint
        acc = acc + 1
        If acc = 1 Then
            If CInt(GetCurrentColumnValue("Nhập")) > 0 Then 'trường hợp nhập > 0
                xrTableCell_Ton.Text = GetCurrentColumnValue("Nhập")
                ton = GetCurrentColumnValue("Nhập")
            Else
                xrTableCell_Ton.Text = GetPreviousColumnValue("Tồn")
                ton = GetPreviousColumnValue("Tồn")
            End If
        Else
            xrTableCell_Ton.Text = ton + GetCurrentColumnValue("Nhập") - GetCurrentColumnValue("Xuất")
            ton = ton + GetCurrentColumnValue("Nhập") - GetCurrentColumnValue("Xuất")
        End If
    End Sub
End Class