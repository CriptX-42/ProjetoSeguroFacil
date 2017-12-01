Public Class Endereco_Sinitr
    Public Rua_Av As String
    Public numero As Integer
    Public CEP As String
    Public Bairro As String
    Public Cidade As String
    Public UF As String
    Public IdSinistro As String

    Public Sub New(Rua_Av As String, Numero As Integer, CEP As String, Bairro As String, Cidade As String, UF As String, IdSinistro As String)
        Me.Rua_Av = Rua_Av
        Me.numero = Numero
        Me.CEP = CEP
        Me.Bairro = Bairro
        Me.Cidade = Cidade
        Me.UF = UF
        Me.IdSinistro = IdSinistro

    End Sub
End Class
