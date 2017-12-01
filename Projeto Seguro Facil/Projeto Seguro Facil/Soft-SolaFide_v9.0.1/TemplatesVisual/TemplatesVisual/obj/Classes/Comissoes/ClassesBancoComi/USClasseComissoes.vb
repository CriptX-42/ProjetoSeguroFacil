Imports MySql.Data.MySqlClient
Public Class USClasseComissoes
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoDadosComissoes(Comi As ClasseComissoes) As String
        Conexao.conectar()
        Dim Sql As String = "insert into tb_Comissoes(pago,apolice,nome_cliente,seguradora,parcelas,Premio," & _
            "perc_comissao,comissao_bruta,desconto,liquido,valor_pago,valor_pagar,dt_pagamento) values(" & _
            "'" & Comi.PG & "', '" & Comi.Apolice & "', '" & Comi.Cliente & "', '" & Comi.Seguradora & _
            "', '" & Comi.Parcelas & "', '" & Comi.Premio & "', '" & Comi.Comissao & "', '" & Comi.ComissaoBruta & _
            "', '" & Comi.Desconto & "', '" & Comi.ComissaoLiquida & "', '" & Comi.ValorPago & _
            "', '" & Comi.ValorPagar & "', '" & Comi.DtPagamento & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao inserir dados em Comissoes - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
End Class
