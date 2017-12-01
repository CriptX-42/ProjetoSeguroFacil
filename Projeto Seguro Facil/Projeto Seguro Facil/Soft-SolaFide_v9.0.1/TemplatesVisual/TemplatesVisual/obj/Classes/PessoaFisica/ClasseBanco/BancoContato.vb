Public Class BancoContato
    Public TelResidencial As String
    Public TelComercial As String
    Public Celular As String
    Public Nextel As String
    Public Email As String
    Public IdPessoaFisica As String
    Public Sub New(TelResidencial As String, TelComercial As String, Celular As String, Nextel As String, Email As String, IdPessoaFisica As String)
        Me.TelResidencial = TelResidencial
        Me.TelComercial = TelComercial
        Me.Celular = Celular
        Me.Nextel = Nextel
        Me.Email = Email
        Me.IdPessoaFisica = IdPessoaFisica
    End Sub

End Class
