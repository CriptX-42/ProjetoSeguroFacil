Imports MySql.Data.MySqlClient
Public Class USBancoVeiculo
    Dim Conexao As New ConexaoSolafide
    Public Function UsarBancoVeiculo(Veiculo As Veiculo) As String
        Conexao.conectar()


        Dim Sql As String = ("INSERT INTO tb_dados_veiculo (`fabricante`, `modelo`, `placa`, `renavam`, `cor_veiculo`, `qtde_portas`, `tipo_combustivel`, `chassi`, `financiamento`, `kit_gas`,`tb_Questionario_Seguro_Auto_id_questionario`,`tb_Pessoa_Fisica_id_Pessoa_Fisica`,`tb_Pessoa_Juridica_id_Pessoa_Juridica`,`Disposit_Ant_Furto`,`Ano_frabric`)" & _
                                    "VALUES ('" & Veiculo.Fabricante & "', '" & Veiculo.Modelo & "', '" & Veiculo.Placa & "', '" & Veiculo.Renavan & "', '" & Veiculo.CorVeiculo & "', '" & Veiculo.qtda_portas & "', '" & Veiculo.Combustivel & "', '" & Veiculo.Chassi & "', '" & Veiculo.Financiamento & "', '" & Veiculo.KitGas & "', '" & Veiculo.IdQuestao & "'," & Veiculo.IdPessoaFisica & "," & Veiculo.IdPessoaJuridica & ",'" & Veiculo.AntFurto & "','" & Veiculo.AnoFabric & "');")


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
