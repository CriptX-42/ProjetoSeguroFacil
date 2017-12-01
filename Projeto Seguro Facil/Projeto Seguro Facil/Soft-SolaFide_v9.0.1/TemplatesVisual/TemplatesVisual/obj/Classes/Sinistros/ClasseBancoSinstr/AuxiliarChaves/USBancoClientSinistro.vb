Imports MySql.Data.MySqlClient
Public Class USBancoClientSinistro
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoClientSinistro(Ident As BancoClientSinistro) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO `solafide_v6`.`tb_client_sinistro` (tb_Sinistro_id_sinistro,`cod_cliente`, `nome_cliente`, `tb_Dados_Veiculo_id_Dados_Veiculo`, `modelo`, `fabricante`)" & _
                                    "VALUES ('" & Ident.CodSinistro & "','" & Ident.CodClient & "', '" & Ident.Nome_Cliente & "', '" & Ident.CodigoCarro & "', '" & Ident.Modelo & "', '" & _
                                    Ident.Fabricante & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em cadastrar sinistro #2 - " + ex.Message, "Cadastro de sinistro", _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function
End Class
