Public Class BancoPagamento
    Public Parcelas As String
    Public IdOrcamento As String
    Public Sub New(Parcelas As String, IdOrcamento As String)
        Me.Parcelas = Parcelas
        Me.IdOrcamento = IdOrcamento
    End Sub
End Class
