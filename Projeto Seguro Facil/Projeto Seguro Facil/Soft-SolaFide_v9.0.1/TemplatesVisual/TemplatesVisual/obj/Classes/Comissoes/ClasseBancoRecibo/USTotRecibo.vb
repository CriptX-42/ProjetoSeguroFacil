Imports MySql.Data.MySqlClient
Public Class USTotRecibo
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoDadosTotRecibo(TotRecibo As TotRecibo) As String
        Conexao.conectar()
        Dim Sql As String = "insert into tb_recibo(pg,nome_cliente,comissao_bruta,desconto,liquido) " & _
            "values('" & TotRecibo.pg & "','" & TotRecibo.Mensagem & "', '" & TotRecibo.TotComiBruta & "', '" & _
            TotRecibo.ToDesc & "', '" & TotRecibo.TotLiquido & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao inserir total em Recibo - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
End Class
