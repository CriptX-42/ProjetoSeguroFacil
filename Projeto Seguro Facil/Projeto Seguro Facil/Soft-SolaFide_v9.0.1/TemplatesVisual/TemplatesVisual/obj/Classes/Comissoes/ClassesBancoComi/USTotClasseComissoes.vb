Imports MySql.Data.MySqlClient
Public Class USTotClasseComissoes
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoDadosTotComissoes(TotComissoes As TotClasseComissoes) As String
        Conexao.conectar()
        Dim Sql As String = "insert into tb_Comissoes(pago,nome_cliente,comissao_bruta,desconto,liquido) " & _
            "values('" & TotComissoes.pg & "','" & TotComissoes.Mensagem & "', '" & TotComissoes.TotComiBruta & "', '" & _
            TotComissoes.ToDesc & "', '" & TotComissoes.TotLiquido & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao inserir total em Comissões - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
End Class
