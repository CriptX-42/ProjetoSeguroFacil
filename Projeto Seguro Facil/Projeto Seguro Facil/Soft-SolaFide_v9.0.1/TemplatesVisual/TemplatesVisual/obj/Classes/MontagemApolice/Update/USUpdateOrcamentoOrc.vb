Imports MySql.Data.MySqlClient
Public Class USUpdateOrcamentoOrc
    Dim Conexao As New ConexaoSolafide
    Public Function UsandoDadosBancoOrcamento(Orcamento As UpdateOrcamentoOrc) As String
        Conexao.conectar()
        Dim Sql As String = ("UPDATE tb_montagemapolice SET `ci`='" & Orcamento.CI & "',`dt_calculo` = '" & Orcamento.DataCalculo & "', `dt_inicio` = '" & Orcamento.VigeIni & "', `dt_fim` = '" & _
                                     Orcamento.VigeFim & "', `premio_seguradora` = '" & Orcamento.Premio & "',`franquia` = '" & Orcamento.franquia & "', `tipo_cobertura` = '" & _
                                     Orcamento.cobertura & "',`dano_material` = '" & Orcamento.dnMtr & "',`dano_corporal` = '" & Orcamento.dnCorp & "', `app_morte` = '" & _
                                     Orcamento.appMorte & "',`app_invalidez` = '" & Orcamento.appInval & "', `dano_moral` = '" & Orcamento.dnMoral & "', `assist_24_horas` = '" & _
                                     Orcamento.ass24Horas & "',`vidros` = '" & Orcamento.vidros & "', `car_reserv` = '" & Orcamento.CarReserv & "', `comentarios` = '" & _
                                     Orcamento.Comentarios & "', `Seguradora_Orc` = '" & Orcamento.NomeSeg & "', `perc_comissao` = '" & Orcamento.PercComissao & "' where id_MontagemApolice = '" & frmCadastrarOrcamento.txtId.Text & "';")

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao update de montagem de apolice - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
    Public Function UsandoDadosBancoPagamento(Pagamento As UpdatePagamentoOrc) As String
        Conexao.conectar()
        Dim Sql As String = ("UPDATE tb_Pagamento SET `parcelas` = '" & Pagamento.Parcelas & "' where tb_MontagemApolice_id_MontagemApolice = '" & frmCadastrarOrcamento.txtId.Text & "'")

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao Alterar Montagem de apolice - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
End Class
