Imports MySql.Data.MySqlClient
Public Class USBancoMontagem
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoDadosBancoOrcamento(Orcamento As BancoMontagem) As String
        Conexao.conectar()
        Dim Sql As String = " INSERT INTO tb_MontagemApolice(dt_Calculo, dt_inicio, dt_fim, premio_seguradora, franquia, tipo_cobertura, dano_material, dano_corporal, app_morte," & _
                                     "app_invalidez, dano_moral, assist_24_horas, vidros, car_reserv, comentarios,ci,Seguradora_Orc,perc_comissao)" & _
                                         "values('" & Orcamento.DataCalculo & "', '" & Orcamento.VigeIni & "','" & Orcamento.VigeFim & "', '" & Orcamento.Premio & "','" & _
                                         Orcamento.franquia & "','" & Orcamento.cobertura & "', '" & Orcamento.dnMtr & "','" & Orcamento.dnCorp & "', '" & Orcamento.appMorte & "', '" & _
                                         Orcamento.appInval & "', '" & Orcamento.dnMoral & "', '" & Orcamento.ass24Horas & "', '" & Orcamento.vidros & "', '" & Orcamento.CarReserv & "','" & Orcamento.Comentarios & "', '" & Orcamento.CI & "', '" & Orcamento.Seguradora & "', '" & Orcamento.PercComissao & "');"
        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em cadastrar montagem de apolice 1 -" + ex.Message, "Cadastro de Montagem de apolice", _
      MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function
    Public Function UsandoDadosBancoPagamento(Pagamento As BancoPagamento) As String
        Conexao.conectar()
        Dim Sql As String = " INSERT INTO tb_Pagamento(parcelas,tb_MontagemApolice_id_MontagemApolice)" & _
                                         "values('" & Pagamento.Parcelas & "','" & Pagamento.IdOrcamento & "')"
        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception

            MessageBox.Show("Erro em cadastrar montagem de apolice 2 -" + ex.Message, "Cadastro de Montagem de apolice", _
     MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function
    Public Function UsandoDadosBancoProponente(Proponente As BancoProponente) As String
        Conexao.conectar()
        Dim Sql As String = " INSERT INTO `solafide_v6`.`tb_proponente` (`nomeProponente`, `tb_MontagemApolice_id_MontagemApolice`) VALUES ('" & Proponente.NomeProponente & "', '" & Proponente.IdOrcamento & "');"
        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro em cadastrar montagem de apolice 3 -" + ex.Message, "Cadastro de Montagem de apolice", _
      MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
        Return CMD.ToString
    End Function
End Class
