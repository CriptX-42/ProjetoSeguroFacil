Imports MySql.Data.MySqlClient
Public Class USBancoSinistro
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoDadosSinistro(Sinistro As BancoSinistro) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO tb_sinistro(`nro_sinistro`, `apolice`, `sinistro_ocorrido`, `pessoas_envolvidas`, `dt_sinistro`, `acompanhamento`)" & _
                                    "VALUES ('" & Sinistro.NumSinitro & "', '" & Sinistro.Apolice & "', '" & Sinistro.TipoSinistro & "', '" & Sinistro.PessoasEnvolvidas & "', '" & Sinistro.DataSinistro & "', '" & Sinistro.Comentarios & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em cadastrar sistro # 1 -" + ex.Message, "Cadastro de Sinistro", _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function
    Public Function UsandoDadosEnderecoSinistri(Endereco As Endereco_Sinitr) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO tb_endereco(Endereco, Numero, cep, bairro, cidade, uf, tb_Sinistro_id_sinistro)" & _
                                         "values('" & Endereco.Rua_Av & "', '" & Endereco.numero & "', '" & Endereco.CEP & "', '" & Endereco.Bairro & "', '" & Endereco.Cidade & "', '" & Endereco.UF & "','" & Endereco.IdSinistro & "');"
        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao inserir dados na tabela Endereco - " & ex.Message)
        Finally

            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
End Class
