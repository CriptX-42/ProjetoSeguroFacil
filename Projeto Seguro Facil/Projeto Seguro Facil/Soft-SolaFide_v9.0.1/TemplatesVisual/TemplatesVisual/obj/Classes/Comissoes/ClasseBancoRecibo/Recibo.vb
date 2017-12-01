Public Class Recibo
    Public PG As String
    Public Apolice As String
    Public Cliente As String
    Public Seguradora As String
    Public Parcelas As String
    Public Premio As String
    Public Comissao As String
    Public ComissaoBruta As String
    Public Desconto As String
    Public ComissaoLiquida As String
    Public ValorPago As String
    Public ValorPagar As String
    Public DtPagamento As String
    Public Sub New(PG As String, Apolice As String, Cliente As String, Seguradora As String, Parcelas As String, _
                   Premio As String, Comissao As String, ComissaoBruta As String, Desconto As String, _
                   ComissaoLiquida As String, ValorPago As String, ValorPagar As String, DtPagamento As String)
        Me.PG = PG
        Me.Apolice = Apolice
        Me.Cliente = Cliente
        Me.Seguradora = Seguradora
        Me.Parcelas = Parcelas
        Me.Premio = Premio
        Me.Comissao = Comissao
        Me.ComissaoBruta = ComissaoBruta
        Me.Desconto = Desconto
        Me.ComissaoLiquida = ComissaoLiquida
        Me.ValorPago = ValorPago
        Me.ValorPagar = ValorPagar
        Me.DtPagamento = DtPagamento
    End Sub
End Class
