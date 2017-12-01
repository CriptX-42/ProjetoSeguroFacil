Imports MySql.Data.MySqlClient
Public Class USBancoQuestoes

    Dim Conexao As New ConexaoSolafide
    Public Function UsarBancoQuestionario(Questionario As Questoes) As String
        Conexao.conectar()
        Dim Sql As String = ("INSERT INTO `solafide_v6`.`tb_questionario_seguro_auto` (`cep_pernoite`, `qtde_sinis_ult_perio`," & _
                                    "`bonus`, `uso_veiculo`, `resid_princ_cond_pes_18_24`, `distan_resi_trab_km`," & _
                                    "`principal_condutor_estuda`, `veiculo_usado_cli_forn`, `roub_veic_ult_dois_anos`," & _
                                    "`Possui_FIlhos_ate_17`, `garagem_fechada`, " & _
                                    "`segurado_proprie_veicu`, `cep_trabalho`,`tb_Pessoa_Fisica_id_Pessoa_Fisica`,`tb_Pessoa_Juridica_id_Pessoa_Juridica`,`Seguradora_quest`,`Km_Media_Mensal`)" & _
                                    "VALUES ('" & Questionario.cep_pernoite & "', '" & Questionario.qtde_sinis_ult_perio & "', '" & Questionario.bonus & "','" & Questionario.uso_veiculo & "', '" & Questionario.resid_princ_cond_pes_18_24 & "', '" & Questionario.distan_resi_trab_km & "', '" & Questionario.principal_condutor_estuda & "'," & _
                                    "'" & Questionario.veiculo_usado_cli_forn & "', '" & Questionario.roub_veic_ult_dois_anos & "', '" & Questionario.Possui_FIlhos_ate_17 & "', '" & Questionario.garagem_fechada & "'," & _
                                    "'" & Questionario.segurado_proprie_veicu & "', '" & Questionario.cep_trabalho & "', " & Questionario.IdPessoaFisica & "," & Questionario.IdPessoaJuridica & ",'" & Questionario.Seguradora & "','" & Questionario.kmMedia_Mensal & "');")



        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em Questionario -" + ex.Message, "Cadastro de questionario", _
      MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString

    End Function
    Public Function UsarBancoFilho(FilhoEnt As Filho_Ent_At17) As String

        Conexao.conectar()

        Dim Sql As String = ("INSERT INTO `tb_filho_enteado_17_anos` (`qnt_filhos`, `idade`, `tb_Questionario_id_questionario`)" & _
                                    "VALUES ('" & FilhoEnt.QuantFilhos & "','" & FilhoEnt.Idade & "','" & FilhoEnt.IDQuestoes & "');")

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em questionario -" + ex.Message, "Cadastro de questionario", _
      MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString

    End Function

End Class
