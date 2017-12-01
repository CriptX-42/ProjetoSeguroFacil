Imports MySql.Data.MySqlClient
Public Class USRecibo
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoDadosRecibo(Recibo As Recibo) As String
        Conexao.conectar()
        Dim Sql As String = "insert into tb_recibo(pg,apolice,nome_cliente,seguradora,parcelas,Premio," & _
            "perc_comissao,comissao_bruta,desconto,liquido,valor_pago,valor_pagar,dt_pagamento) values(" & _
            "'" & Recibo.PG & "', '" & Recibo.Apolice & "', '" & Recibo.Cliente & "', '" & Recibo.Seguradora & _
            "', '" & Recibo.Parcelas & "', '" & Recibo.Premio & "', '" & Recibo.Comissao & "', '" & Recibo.ComissaoBruta & _
            "', '" & Recibo.Desconto & "', '" & Recibo.ComissaoLiquida & "', '" & Recibo.ValorPago & _
            "', '" & Recibo.ValorPagar & "', '" & Recibo.DtPagamento & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao inserir dados em Recibo - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
End Class
