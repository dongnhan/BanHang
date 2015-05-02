Imports System.Linq.Expressions


Namespace LightSwitchApplication

    Public Class BanHangDataQuanService

        'Private Sub ChonMon_Inserting(entity As ChonMons)
        '    entity.UserName = Me.Application.User.Name
        'End Sub

        'Private Sub ChonMon_Updating(entity As ChonMons)
        '    entity.UserName = Me.Application.User.Name
        'End Sub

        Private Sub ChonMons_Inserting(entity As ChonMon1)
            entity.UserName = Me.Application.User.Name
        End Sub

        Private Sub ChonMons_Updating(entity As ChonMon1)
            entity.UserName = Me.Application.User.Name
        End Sub

        Private Sub ChonMons_Filter(ByRef filter As System.Linq.Expressions.Expression(Of System.Func(Of ChonMon1, Boolean)))
            filter = (Function(x) x.UserName = Me.Application.User.Name)
        End Sub
    End Class

End Namespace
