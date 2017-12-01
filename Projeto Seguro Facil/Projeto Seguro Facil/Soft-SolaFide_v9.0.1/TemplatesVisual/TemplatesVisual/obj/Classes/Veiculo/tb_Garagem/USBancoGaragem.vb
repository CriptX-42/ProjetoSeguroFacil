Imports MySql.Data.MySqlClient
Public Class USBancoGaragem
    Dim Conexao As New ConexaoSolafide
    Public Function UsarBancoGaragem(Garagem As Garagem) As String

        Conexao.conectar()

        Dim Sql As String = ("INSERT INTO tb_Garagem (`residencia`, `trabalho`, `local_estudos`,`tb_Questionario_id_questionario`)" & _
                                    " VALUES ('" & Garagem.residencia & "', '" & Garagem.Trabalho & "', '" & Garagem.local_Estudos & "','" & Garagem.idQuestionario & "');")



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
