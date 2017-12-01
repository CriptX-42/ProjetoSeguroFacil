Public Class UpdateEnderecoJuri
    Public Endereco As String
    Public Numero As Integer
    Public CEP As String
    Public Bairro As String
    Public Cidade As String
    Public UF As String
    Public Bloco As String
    Public Complemento As String
    Public id As String
    Public Apto As String
    Public Sub New(endereco As String, numero As Integer, Cep As String, Bairro As String, Cidade As String, Uf As String, Bloco As String, Complemento As String, id As String, Apto As String)
        Me.Endereco = endereco
        Me.Numero = numero
        Me.CEP = Cep
        Me.Bairro = Bairro
        Me.Cidade = Cidade
        Me.UF = Uf
        Me.Bloco = Bloco
        Me.Complemento = Complemento
        Me.id = id
        Me.Apto = Apto
    End Sub
End Class
