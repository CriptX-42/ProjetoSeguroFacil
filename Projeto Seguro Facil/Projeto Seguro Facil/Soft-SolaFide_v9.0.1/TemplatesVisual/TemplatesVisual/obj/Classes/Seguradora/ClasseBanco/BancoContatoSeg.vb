Public Class BancoContatoSeg
    Public TelComer As String
    Public CelComer As String
    Public nextel As String
    Public Email As String
    Public IdSeguradora As String
    Public Sub New(TelComer As String, CelComer As String, nextel As String, Email As String, IdSeguradora As String)
        Me.TelComer = TelComer
        Me.CelComer = CelComer
        Me.nextel = nextel
        Me.Email = Email
        Me.IdSeguradora = IdSeguradora
    End Sub
End Class
