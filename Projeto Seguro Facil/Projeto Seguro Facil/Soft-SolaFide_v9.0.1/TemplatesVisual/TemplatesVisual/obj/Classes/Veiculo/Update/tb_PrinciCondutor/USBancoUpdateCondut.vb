Imports MySql.Data.MySqlClient
Public Class USBancoUpdateCondut
    Dim Conexao As ConexaoSolafide
    Public Function UsarBancoUpdateCondutPrinci(PrinciCondut As PrinciCondutorUpdate) As String
        Conexao.conectar()


        Dim Sql As String = ("UPDATE `tb_principal_condutor` SET `especifique`='" & PrinciCondut.especifique & "', `Reside_Em`='" & PrinciCondut.PrincipalReside & "' WHERE `tb_Questionario_Seguro_Auto_id_questionario`='" & PrinciCondut.IdQuestionario & "';")


        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em inserir veiculo -" + ex.Message, "Cadastro de veiculo", _
       MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString

    End Function
    Public Function UsarBancoUpdateSegundoCondutor(SegundCondut As SegundCondutorUpdate) As String
        Conexao.conectar()


        Dim Sql As String = ("UPDATE `tb_Segundo_Condutor` SET `nomeSegundCondut`='" & SegundCondut.nome & "', `dt_nascimento`='" & SegundCondut.dt_nascimento & "', `CNH_Seg_Condult`='" & SegundCondut.CNH_SegundoCondutor & "' WHERE `tb_Questionario_Seguro_Auto_id_questionario`='" & SegundCondut.idQuestionario & "';")


        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em inserir veiculo -" + ex.Message, "Cadastro de veiculo", _
       MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString

    End Function
    Public Function UsarBancoUpdateSexo(Sexo As SexoCondutUpdate) As String
        Conexao.conectar()


        Dim Sql As String = ("UPDATE `tb_Sexo` SET `sexo`='" & Sexo.Sexo & "' WHERE `tb_Segundo_Condutor_id_segundo_condutor`='" & Sexo.IdSegundoCondutor & "';")


        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em inserir veiculo -" + ex.Message, "Cadastro de veiculo", _
       MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString

    End Function
End Class
