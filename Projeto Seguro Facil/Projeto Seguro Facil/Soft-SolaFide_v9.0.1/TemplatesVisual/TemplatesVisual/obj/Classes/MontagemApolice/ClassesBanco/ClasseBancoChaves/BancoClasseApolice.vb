Public Class BancoClasseApolice
    Public CodApolice As String
    Public CodClient As String
    Public Nome_Cliente As String
    Public CodigoCarro As String
    Public Modelo As String
    Public Fabricante As String
    Public Sub New(CodApolice As String, CodClient As String, Nome_Cliente As String, CodigoCarro As String, Modelo As String, Fabricante As String)
        Me.CodApolice = CodApolice
        Me.CodClient = CodClient
        Me.Nome_Cliente = Nome_Cliente
        Me.CodigoCarro = CodigoCarro
        Me.Modelo = Modelo
        Me.Fabricante = Fabricante

    End Sub
End Class
