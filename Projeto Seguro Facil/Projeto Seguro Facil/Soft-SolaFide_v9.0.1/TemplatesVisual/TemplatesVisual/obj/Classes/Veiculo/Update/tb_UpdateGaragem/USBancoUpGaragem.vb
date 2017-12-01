Imports MySql.Data.MySqlClient
Public Class USBancoUpGaragem
    Dim Conexao As New ConexaoSolafide
    Public Function UsarBancoUPGaragem(Garagem As UpdateGaragem) As String

        Conexao.conectar()

        Dim Sql As String = ("UPDATE `tb_garagem` SET `residencia`='" & Garagem.residencia & "', `trabalho`='" & Garagem.Trabalho & "', `local_estudos`='" & Garagem.local_Estudos & "' WHERE `tb_Questionario_id_questionario`='" & Garagem.idQuestionario & "';")



        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em inserir garagem -" + ex.Message, "Cadastro de veiculo", _
       MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString

    End Function
End Class
