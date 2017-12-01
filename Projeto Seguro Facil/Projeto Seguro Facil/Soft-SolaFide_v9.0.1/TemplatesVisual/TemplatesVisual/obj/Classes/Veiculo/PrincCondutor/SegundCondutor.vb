Public Class SegundCondutor

    Public nome As String
    Public dt_nascimento As String
    Public idQuestionario As String
    Public CNH_SegundoCondutor As String
    Public Sub New(nome As String, dt_nasciemto As String, idQuestionario As String, CNH_SegundoCondutor As String)
        Me.nome = nome
        Me.dt_nascimento = dt_nasciemto
        Me.idQuestionario = idQuestionario
        Me.CNH_SegundoCondutor = CNH_SegundoCondutor
    End Sub

End Class
