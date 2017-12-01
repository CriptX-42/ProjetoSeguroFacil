Imports MySql.Data.MySqlClient
Public Class USBancoMarca
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoDadosMarca(Marca As BancoMarca) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO tb_lista_marca_veiculo(`Marca`) VALUES ('" & Marca.Marca & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao inserir dados da Marca - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
    Public Function UsandoDadosVeiculo_Marca(Veiculo As BancoVeiculo_Marca) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO tb_lista_nome_veiculo(Nome_veiculo, tb_lista_Marca_Veiculo_id_lista_veiculo) VALUES ('" & Veiculo.Veiculo & "', '" & Veiculo.IDMarca & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao inserir dados da Marca - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
End Class
