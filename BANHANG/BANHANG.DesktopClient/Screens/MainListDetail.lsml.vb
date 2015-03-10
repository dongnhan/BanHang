Imports System.Linq
Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Collections.Generic
Imports Microsoft.LightSwitch
Imports Microsoft.LightSwitch.Framework.Client
Imports Microsoft.LightSwitch.Presentation
Imports Microsoft.LightSwitch.Presentation.Extensions
Imports System.Windows.Threading
Imports Microsoft.LightSwitch.Threading
Namespace LightSwitchApplication

    Public Class MainListDetail
        Private _timer As System.Threading.Timer
        Private Sub Application_LoggedIn()
            If (_timer Is Nothing) Then
                _timer = New System.Threading.Timer( _
                    Sub(x)
                        Me.Details.Dispatcher.BeginInvoke( _
                            Sub()

                                'Dim item = Me.DataWorkspace() _
                                '    .BanHangData.SanPham.FirstOrDefault()
                                ShowMessageBox("docbaovem !!!")
                            End Sub)
                    End Sub _
                   , Nothing, 15000, 30000 _
                   )
            End If
        End Sub
        Private Sub MainListDetail_Activated()
            Me.Application.TenDonVi = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Tên ' Write your code here.
            Me.Application.DiaChiDonVi = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Địa_chỉ
            Me.Application.KiemTraTonKho = Me.Đơn_Vị_Sử_Dụng.SelectedItem.Kiểm_tra_tồn_kho
        End Sub

        Private Sub MainListDetail_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            'Application_LoggedIn()
        End Sub

        Private Sub Each_Tick(sender As Object, e As EventArgs)

            Dispatchers.Main.BeginInvoke(Sub() sender = False)
            'Items.Refresh()

        End Sub
    End Class

End Namespace
