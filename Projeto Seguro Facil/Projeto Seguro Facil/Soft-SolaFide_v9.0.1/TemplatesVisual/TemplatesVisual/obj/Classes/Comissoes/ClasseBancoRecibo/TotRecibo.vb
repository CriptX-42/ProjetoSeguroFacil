Public Class TotRecibo
    Public pg As String
    Public Mensagem As String
    Public TotComiBruta As String
    Public ToDesc As String
    Public TotLiquido As String
    Public Sub New(pg As String, Mensagem As String, TotComiBruta As String, TotDesc As String, TotLiquido As String)
        Me.pg = pg
        Me.Mensagem = Mensagem
        Me.TotComiBruta = TotComiBruta
        Me.ToDesc = TotDesc
        Me.TotLiquido = TotLiquido
    End Sub
End Class
