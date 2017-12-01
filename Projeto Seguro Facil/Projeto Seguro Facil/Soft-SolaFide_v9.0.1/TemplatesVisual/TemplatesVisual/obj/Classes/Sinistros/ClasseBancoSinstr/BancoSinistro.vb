Public Class BancoSinistro
    Public TipoSinistro As String
    Public PessoasEnvolvidas As String
    Public DataSinistro As String
    Public NumSinitro As String
    Public Apolice As String
    Public Comentarios As String

    Public Sub New(TipoSinistro As String, PessoasEnvolvidas As String, DataSinistro As String, NumSinitro As String, Apolice As String, Comentarios As String)
        Me.TipoSinistro = TipoSinistro
        Me.PessoasEnvolvidas = PessoasEnvolvidas
        Me.DataSinistro = DataSinistro
        Me.NumSinitro = NumSinitro
        Me.Apolice = Apolice
        Me.Comentarios = Comentarios

    End Sub
End Class
