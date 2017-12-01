Public Class BancoSeguradora
    Public NomeSeguradora As String
    Public SitePrincipal As String
    Public SiteCorretor As String
    Public Comentarios As String
    Public Sub New(NomeSeguradora As String, SiteCorretor As String, SitePrincipal As String, Comentarios As String)
        Me.NomeSeguradora = NomeSeguradora
        Me.SitePrincipal = SitePrincipal
        Me.SiteCorretor = SiteCorretor
        Me.Comentarios = Comentarios
    End Sub
End Class
