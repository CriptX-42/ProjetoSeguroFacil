Public Class UpdatePessoaJuri
    Public RazaoSocial As String
    Public NomeFantasia As String
    Public Representante As String
    Public CNPJ As String
    Public AreaAtuacao As String
    Public Site As String
    Public Comentarios As String
    Public Status As String
    Public id As String

    Public Sub New(RazaoSocial As String, NomeFantasia As String, Representante As String, CNPJ As String, AreaAtuacao As String, Site As String, Comentarios As String, Status As String, id As String)
        Me.RazaoSocial = RazaoSocial
        Me.NomeFantasia = NomeFantasia
        Me.Representante = Representante
        Me.CNPJ = CNPJ
        Me.AreaAtuacao = AreaAtuacao
        Me.Site = Site
        Me.Comentarios = Comentarios
        Me.Status = Status
        Me.id = id
    End Sub
End Class
