Public Class PrincCondutor

    Public especifique As String

    'Public dt_nascimento As String
    'Public profissao As String
    'Public tempo_habilitacao As String
    'Public especif_tempo_habili As String
    Public IdPessoaFisica As String
    Public IdPessoJuridica As String
    Public IdQuestionario As String
    Public PrincipalReside As String
    Public NomePrinciCondut As String
    Public Sub New(especifique As String, IdPessoaFisica As String, IdPessoJuridica As String, IdQuestionario As String, PrincipalReside As String, NomePrinciCondut As String)

        'Me.dt_nascimento = dt_nascimento
        ' Me.profissao = profissao
        ' Me.tempo_habilitacao = tempo_habilitacao
        Me.especifique = especifique
        Me.IdPessoaFisica = IdPessoaFisica
        Me.IdPessoJuridica = IdPessoJuridica
        Me.IdQuestionario = IdQuestionario
        Me.PrincipalReside = PrincipalReside
        Me.NomePrinciCondut = NomePrinciCondut
    End Sub
End Class
