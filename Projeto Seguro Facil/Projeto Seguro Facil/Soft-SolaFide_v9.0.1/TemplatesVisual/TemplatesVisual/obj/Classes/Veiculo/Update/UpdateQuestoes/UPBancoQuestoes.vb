Imports MySql.Data.MySqlClient
Public Class UPBancoQuestoes
    Dim Conexao As New ConexaoSolafide
    Public Function UPQuestoes(UPVeiculo As UpdateQuestoes) As String
        Conexao.conectar()
        Dim Sql As String = ("UPDATE tb_questionario_seguro_auto SET `cep_pernoite`='" & UPVeiculo.cep_pernoite & "'," & _
            " `qtde_sinis_ult_perio`='" & UPVeiculo.qtde_sinis_ult_perio & "', `bonus`='" & UPVeiculo.bonus & "'', `uso_veiculo`='" & UPVeiculo.uso_veiculo & "', `resid_princ_cond_pes_18_24`='" & UPVeiculo.resid_princ_cond_pes_18_24 & "'" & _
            ", `distan_resi_trab_km`='" & UPVeiculo.distan_resi_trab_km & "', `principal_condutor_estuda`='" & UPVeiculo.principal_condutor_estuda & "', `veiculo_usado_cli_forn`='" & UPVeiculo.veiculo_usado_cli_forn & "', `roub_veic_ult_dois_anos`='" & UPVeiculo.roub_veic_ult_dois_anos & "'," & _
            "`Possui_FIlhos_ate_17`='" & UPVeiculo.Possui_FIlhos_ate_17 & "', `garagem_fechada`='" & UPVeiculo.garagem_fechada & "', `segurado_proprie_veicu`='" & UPVeiculo.segurado_proprie_veicu & "', `quantos_filhos`='" & UPVeiculo.numQuantos & "', `cep_trabalho`='" & UPVeiculo.cep_trabalho & "'', `Seguradora_quest`='" & UPVeiculo.Seguradora & "', `Km_Media_Mensal`='" & UPVeiculo.kmMedia_Mensal & "' WHERE `id_questionario`='" & UPVeiculo.IdVeiculos & "';")

        '################################ quantos_filhos FAZER 
        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em alterar questões -" + ex.Message, "Cadastro de veiculo", _
      MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
    Public Function UPDBancoFilho(FilhoEnt As Update_Filho_At17) As String



        Dim Sql As String = ("UPDATE `tb_filho_enteado_17_anos` SET  `qnt_filhos`='" & FilhoEnt.QuantFilhos & "', `idade`='" & FilhoEnt.Idade & "' WHERE `tb_Questionario_id_questionario`='" & FilhoEnt.IDQuestoes & "';")

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em alterar questões -" + ex.Message, "Cadastro de veiculo", _
       MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString

    End Function
End Class
