Imports MySql.Data.MySqlClient
Public Class UpdateVeiculo
    Dim Conexao As New ConexaoSolafide
    Public Function UsarBancoUPVeiculo(Veiculo As USBancoUpdateVeiculo) As String
        Conexao.conectar()


        Dim Sql As String = ("UPDATE `tb_dados_veiculo` SET `fabricante`='" & Veiculo.Fabricante & "', `modelo`='" & Veiculo.Modelo & "', `placa`='" & Veiculo.Placa & "', `renavam`='" & Veiculo.Renavan & "', `cor_veiculo`='" & Veiculo.CorVeiculo & "', `qtde_portas`='" & Veiculo.qtda_portas & "', `tipo_combustivel`='" & Veiculo.Combustivel & "', `chassi`='" & Veiculo.Chassi & "', `financiamento`='" & Veiculo.Financiamento & "', `kit_gas`='" & Veiculo.KitGas & "' WHERE `tb_Questionario_Seguro_Auto_id_questionario`='" & Veiculo.IdQuestoes & "';")


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
