Imports DevExpress.Mvvm.DataAnnotations
Imports System

Namespace DXSample.ViewModel

    <POCOViewModel>
    Public Class TabViewModel

        Public Overridable Property Updated As Date

        Public Overridable Property Content As Object

        Public Sub New()
            Updated = Date.Now
            Content = Guid.NewGuid()
        End Sub

        Public Sub UpdateDocument()
            Updated = Date.Now
            Content = Guid.NewGuid()
        End Sub
    End Class
End Namespace
