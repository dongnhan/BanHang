Imports System.Web
Imports System.Web.Services
Imports Microsoft.LightSwitch.Server

Public Class GetUserName
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        'Try
        '    Dim servercontext = ServerApplicationContext.CreateContext()

        '    context.Response.ContentType = "text/plain"
        '    context.Response.Write(servercontext.Application.User.Name)
        'Catch ex As Exception

        'End Try

        Using serverContext = ServerApplicationContext.CreateContext()
            context.Response.ContentType = "text/plain"
            context.Response.Write(serverContext.Application.User.Name)
        End Using
        'Using Context As ServerApplicationContext = ServerApplicationContext.CreateContext(ServerApplicationContextCreationOptions.SkipAuthentication)
        '    ' allow in unauthenticated users 
        '    ' my code goes here 
        'End Using


    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class