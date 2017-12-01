Public Class BancoCliente
    'AQUI ESTA O PARAMETRO DAS "TXT" DA FORM CADASTRAR
    Public Nome As String
    Public CPF As String
    Public RG As String
    Public Data_Expedicao As String
    Public Orgao_Expeditor As String
    Public CNH As String
    Public Tempo_Habilitacao As String
    Public Especificacao As String
    Public Data_Nasc As String
    Public Profissao As String
    Public Status As String
    Public Comentario As String
    'AQUI EU FAÇO O METODO CONSTRUTOR
    Public Sub New(Nome As String, CPF As String, RG As String, Data_Expedicao As String, Orgao_Expeditor As String, CNH As String, Tempo_Habilitacao As String, Especificacao As String, Data_Nasc As String, profissao As String, status As String, Comentarios As String)
        'AQUI EU FALO QUEM A CLASSE EM CIMA É 
        Me.Nome = Nome
        Me.CPF = CPF
        Me.RG = RG
        Me.Data_Expedicao = Data_Expedicao
        Me.Orgao_Expeditor = Orgao_Expeditor
        Me.CNH = CNH
        Me.Tempo_Habilitacao = Tempo_Habilitacao
        Me.Especificacao = Especificacao
        Me.Data_Nasc = Data_Nasc
        Me.Profissao = profissao
        Me.Status = status
        Me.Comentario = Comentarios
    End Sub
End Class
