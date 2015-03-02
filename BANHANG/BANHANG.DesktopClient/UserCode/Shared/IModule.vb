
Imports System.ComponentModel
''' <summary>
''' Các tiện ích và các hàm xử lý các công việc thường xảy ra
''' </summary>
''' <remarks></remarks>
Module IModule


    ''' <summary>
    ''' lấy ngày cuối năm của một date
    ''' </summary>
    ''' <param name="ngay">ngày</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNgayCuoiNam(ByVal ngay As Date) As Date
        Return New Date(ngay.Year, 12, 31)
    End Function
    ''' <summary>
    ''' lấy ngày đầu năm của một date
    ''' </summary>
    ''' <param name="ngay">giá trị date</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNgayDauNam(ByVal ngay As Date) As Date
        Return New Date(ngay.Year, 1, 1)
    End Function
   

    Public Function getNgayCuoiThang(ByVal ngay As Date) As Date
        Return New Date(ngay.Year, ngay.Month, Date.DaysInMonth(ngay.Year, ngay.Month))
    End Function
    ''' <summary>
    ''' Lấy ngày đầu tháng
    ''' </summary>
    ''' <param name="ngay">Ngày</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNgayDauThang(ByVal ngay As Date) As Date
        Return New Date(ngay.Year, ngay.Month, 1)
    End Function

    ''' <summary>
    ''' lấy ngày trước đó 
    ''' </summary>
    ''' <param name="ngay">Ngày</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNgayTruoc(ByVal ngay As Date) As Date
        Dim newdate As Date = DateAdd(DateInterval.Day, -1, ngay)
        Return New Date(newdate.Year, newdate.Month, newdate.Day)
    End Function
    ''' <summary>
    ''' Lấy ngày đầu tháng của tháng trước đó
    ''' </summary>
    ''' <param name="ngay">Ngày</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNgayDauThang_ThangTruoc(ByVal ngay As Date) As Date
        Dim newdate As Date = ngay.AddMonths(-1)
        Return getNgayDauThang(newdate)
    End Function
    ''' <summary>
    ''' lấy ngày cuối tháng của tháng trước đó
    ''' </summary>
    ''' <param name="ngay">Ngày</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNgayCuoiThang_ThangTruoc(ByVal ngay As Date) As Date
        Dim newdate As Date = ngay.AddMonths(-1)
        Return getNgayCuoiThang(newdate)
    End Function
    Public Function getNgayDauThang_ThangSau(ByVal ngay As Date) As Date
        Dim newdate As Date = ngay.AddMonths(1)
        Return getNgayDauThang(newdate)
    End Function
    Public Function getNgayCuoiThang_ThangSau(ByVal ngay As Date) As Date
        Dim newdate As Date = ngay.AddMonths(1)
        Return getNgayCuoiThang(newdate)
    End Function

    Public Function NumToText(ByVal s As String) As String
        Dim So() As String = {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"} 'Cái này nên để người dùng tự nhập vào vì có nhiều bảng mã khác nhau 
        Dim So1() As String = {"lẻ", "mốt", "tư", "lăm", "mười", "mươi"}
        Dim Hang() As String = {"", "ngàn", "triệu", "tỷ"}
        Dim I, J, donvi, chuc, tram As Integer
        Dim StrValue As String
        StrValue = ""
        I = Len(s)
        For J = 0 To I - 1
            If Microsoft.VisualBasic.Left(s, 1) = "0" Then
                s = Microsoft.VisualBasic.Right(s, I - J)
            End If
        Next J
        If s = "0" Then
            NumToText = So(0)
            Exit Function
        End If
        I = Len(s)
        If I = 0 Then
            StrValue = ""
        Else
            J = 0
            Do While I > 0
                donvi = Int(Mid(s, I, 1))
                I = I - 1
                If I > 0 Then
                    chuc = Int(Mid(s, I, 1))
                Else
                    chuc = -1
                End If
                I = I - 1
                If I > 0 Then
                    tram = Int(Mid(s, I, 1))
                Else
                    tram = -1
                End If
                I = I - 1
                If donvi > 0 Or chuc > 0 Or tram > 0 Or J = 3 Then
                    StrValue = Hang(J) & " " & StrValue
                End If
                J = J + 1
                If J > 3 Then
                    J = 1
                End If
                If donvi = 1 And chuc > 1 Then
                    StrValue = So1(1) & " " & StrValue
                ElseIf donvi = 4 And chuc > 1 Then
                    StrValue = So1(2) & " " & StrValue
                Else
                    If donvi = 5 And chuc > 0 Then
                        StrValue = So1(3) & " " & StrValue
                    ElseIf donvi > 0 Then
                        StrValue = So(donvi) & " " & StrValue
                    End If
                End If
                If chuc < 0 Then
                    Exit Do
                Else
                    If chuc = 0 And donvi > 0 Then
                        StrValue = So1(0) & " " & StrValue
                    ElseIf chuc = 1 Then
                        StrValue = So1(4) & " " & StrValue
                    ElseIf chuc > 1 Then
                        StrValue = So(chuc) & " " & So1(5) & " " & StrValue
                    End If
                End If
                If tram < 0 Then
                    Exit Do
                Else
                    If tram > 0 Or chuc > 0 Or donvi > 0 Then
                        StrValue = So(tram) & " " & "trăm" & " " & StrValue 'Lưu ý bảng mã 
                    End If
                End If
            Loop
        End If
        For I = 1 To 3
            StrValue = StrValue.Replace(Hang(I), Hang(I) & "")
        Next
        StrValue = StrValue.Replace(", " & Hang(3), " " & Hang(3))
        StrValue = Trim(StrValue)
        StrValue = StrValue.TrimEnd(",")
        StrValue = UCase(Microsoft.VisualBasic.Left(StrValue, 1)) & Microsoft.VisualBasic.Right(StrValue, Len(StrValue) - 1)
        NumToText = StrValue & " đồng."
    End Function
End Module
