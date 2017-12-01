Imports MySql.Data.MySqlClient
Public Class USBancoClasseApolice
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoClientApolice(Ident As BancoClasseApolice) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO `solafide_v6`.`tb_client_MontApolice` (`tb_MontagemApolice_id_MontagemApolice`,`cod_cliente`, `nome_cliente`, `tb_Dados_Veiculo_id_Dados_Veiculo`, `modelo`, `fabricante`) " & _
                                    "VALUES ('" & Ident.CodApolice & "','" & Ident.CodClient & "', '" & Ident.Nome_Cliente & "', '" & Ident.CodigoCarro & "', '" & Ident.Modelo & "', '" & _
                                    Ident.Fabricante & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em cadastrar montagem de apolice #2 - " + ex.Message, "Cadastro de montagem de apolice", _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function
End Class
