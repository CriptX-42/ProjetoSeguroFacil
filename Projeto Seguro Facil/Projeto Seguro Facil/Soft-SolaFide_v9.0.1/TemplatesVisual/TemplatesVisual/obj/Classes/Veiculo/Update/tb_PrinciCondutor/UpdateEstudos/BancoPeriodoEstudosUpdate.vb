Imports MySql.Data.MySqlClient
Public Class BancoPeriodoEstudosUpdate
     Public Matutino As String
    Public Vespertino As String
    Public Noturno As String
    Public IDQuestoes As String
    Public Sub New(Matutino As String, Vespertino As String, Noturno As String, IDQuestoes As String)
        Me.Matutino = Matutino
        Me.Vespertino = Vespertino
        Me.Noturno = Noturno
        Me.IDQuestoes = IDQuestoes
    End Sub
End Class
