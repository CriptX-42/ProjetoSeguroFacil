Public Class Banco
    'AQUI ESTA O PARAMETRO DAS "TXT" DA FORM CADASTRAR
    Public Nome As String
    Public CPF As String
    'AQUI EU FAÇO O METODO CONSTRUTOR
    Public Sub New(Nome As String, CPF As String)
        'AQUI EU FALO QUEM A CLASSE EM CIMA É 
        Me.Nome = Nome
        Me.CPF = CPF
    End Sub
End Class
