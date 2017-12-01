Public Class UpdateEndereco
    Public Rua_Av As String
    Public numero As Integer
    Public CEP As String
    Public Bairro As String
    Public Cidade As String
    Public UF As String
    Public complemento As String
    Public Bloco As String
    Public Apto As String
    Public IdPessoaFisica As String
    Public Sub New(Rua_Av As String, Numero As Integer, CEP As String, Bairro As String, Cidade As String, UF As String, Complemento As String, Bloco As String, Apto As String, IdPessoaFisica As String)
        Me.Rua_Av = Rua_Av
        Me.numero = Numero
        Me.CEP = CEP
        Me.Bairro = Bairro
        Me.Cidade = Cidade
        Me.UF = UF
        Me.complemento = Complemento
        Me.Bloco = Bloco
        Me.IdPessoaFisica = IdPessoaFisica
        Me.Apto = Apto
    End Sub
End Class
