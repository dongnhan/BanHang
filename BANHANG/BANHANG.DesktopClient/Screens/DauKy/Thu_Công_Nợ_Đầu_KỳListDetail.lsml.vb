
Namespace LightSwitchApplication

    Public Class Thu_Công_Nợ_Đầu_KỳListDetail

        Private Sub Thu_Công_Nợ_Đầu_KỳItemListAddAndEditNew_CanExecute(ByRef result As Boolean)
            ' Write your code here.

        End Sub

        Private Sub Thu_Công_Nợ_Đầu_KỳItemListAddAndEditNew_Execute()
            Me.Thu_Công_Nợ_Đầu_Kỳ.AddNew() ' Write your code here.
            Me.FindControl("Đối_TượngItem1").Focus()
        End Sub
    End Class

End Namespace
