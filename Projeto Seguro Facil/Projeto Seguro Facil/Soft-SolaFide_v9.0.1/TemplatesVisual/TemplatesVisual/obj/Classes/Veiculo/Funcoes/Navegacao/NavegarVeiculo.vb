Imports MySql.Data.MySqlClient

Public Class NavegarVeiculo
    Dim Conexao As ConexaoSolafide
    Dim adaptador As New DataTable
    Dim posicao As Integer = 0
    Public Enum registros
        Anterior
        Primeiro
        Proximo
        Ultimo
    End Enum

    Public Sub CarregarForm()

        Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
        Dim Conexao As New MySqlConnection(Conectando)
        Try

            Dim adtp As New MySqlDataAdapter("Select * From tb_questionario_seguro_auto " & _
          " left Join tb_cliente_veiculo cv on cv.tb_questionario_seguro_auto_id_questionario = tb_questionario_seguro_auto.id_questionario " & _
          " Inner Join tb_dados_veiculo on solafide_v6.tb_dados_veiculo.id_Dados_Veiculo = solafide_v6.tb_questionario_seguro_auto.id_questionario  " & _
          " Inner Join tb_Filho_Enteado_17_Anos on tb_Filho_Enteado_17_Anos.id_filho_enteado_17_anos = tb_questionario_seguro_auto.id_questionario  " & _
          " Inner Join tb_garagem on tb_garagem.id_Estacionamento_Trabalho = tb_questionario_seguro_auto.id_questionario  " & _
          " Inner Join tb_principal_condutor on tb_principal_condutor.id_principal_condutor = tb_questionario_seguro_auto.id_questionario " & _
          " Inner Join tb_Periodo_Estudo on tb_Periodo_Estudo.id_periodo_estudo = tb_questionario_seguro_auto.id_questionario " & _
          " Inner Join tb_Segundo_Condutor on tb_Segundo_Condutor.id_segundo_condutor = tb_questionario_seguro_auto.id_questionario " & _
          " left Join tb_Sexo on tb_sexo.id_sexo = tb_questionario_seguro_auto.id_questionario", Conexao)
            adtp.Fill(adaptador)

        Catch ex As Exception
            MsgBox("Erro ao carregar Cadastro veiculo : " + ex.Message)
        Finally
            Conexao.Close()
        End Try
    End Sub

    Public Sub DescarregarForm()
        Try
            adaptador.Clear()
        Catch ex As Exception
            MsgBox("Erro em Descarregar Cadastro veiculo : " + ex.Message)
        End Try
    End Sub
    Public Sub AtualizarForm()
        Try
            With frmDadosVeiculo

                .txtIDQuestonario.Text = adaptador.Rows(posicao)("id_questionario").ToString
                .LblNomeShow.Text = adaptador.Rows(posicao)("nome_cliente_veiculo").ToString
                .mskCepDePerNoite.Text = adaptador.Rows(posicao)("cep_pernoite").ToString
                .cboSeguradora.Text = adaptador.Rows(posicao)("Seguradora_quest").ToString
                .NumQuantSinistr.Text = adaptador.Rows(posicao)("qtde_sinis_ult_perio").ToString
                .txtClasseDeBonus.Text = adaptador.Rows(posicao)("bonus").ToString
                .cboUsoVeiculo.Text = adaptador.Rows(posicao)("uso_veiculo").ToString
                .cboResidemComCondutor.Text = adaptador.Rows(posicao)("resid_princ_cond_pes_18_24").ToString
                .txtDistAproxEmKmResidencia.Text = adaptador.Rows(posicao)("distan_resi_trab_km").ToString
                .cboPrincipalCondutorReside.Text = adaptador.Rows(posicao)("Reside_Em").ToString
                .cboUtilizaVeiculoVisitas.Text = adaptador.Rows(posicao)("veiculo_usado_cli_forn").ToString
                .cboRoubo.Text = adaptador.Rows(posicao)("roub_veic_ult_dois_anos").ToString
                .cboPossuiFilhos.Text = adaptador.Rows(posicao)("Possui_FIlhos_ate_17").ToString
                .cboGaragemFechada.Text = adaptador.Rows(posicao)("garagem_fechada").ToString
                .cboSeguradProprietario.Text = adaptador.Rows(posicao)("segurado_proprie_veicu").ToString
                .mskCepTrabalho.Text = adaptador.Rows(posicao)("cep_trabalho").ToString
                .cboPrincCondutEstud.Text = adaptador.Rows(posicao)("principal_condutor_estuda").ToString
                .txtSegundoCondutor.Text = adaptador.Rows(posicao)("nomeSegundCondut").ToString
                .cboSexo.Text = adaptador.Rows(posicao)("sexo").ToString

                .numQuantos.Text = adaptador.Rows(posicao)("qnt_filhos").ToString
                .numIdade.Text = adaptador.Rows(posicao)("idade").ToString

                .cboFabricante.Text = adaptador.Rows(posicao)("fabricante").ToString
                .txtChassi.Text = adaptador.Rows(posicao)("chassi").ToString
                .cboModelo.Text = adaptador.Rows(posicao)("modelo").ToString
                .mskPlaca.Text = adaptador.Rows(posicao)("placa").ToString
                .cboCombustivel.Text = adaptador.Rows(posicao)("tipo_combustivel").ToString
                .cboKitGas.Text = adaptador.Rows(posicao)("kit_gas").ToString
                .NumDPortas.Value = CDec(adaptador.Rows(posicao)("qtde_portas"))
                .txtCor.Text = adaptador.Rows(posicao)("cor_veiculo").ToString
                .cboFinanciamento.Text = adaptador.Rows(posicao)("financiamento").ToString
                .txtRenavan.Text = adaptador.Rows(posicao)("renavam").ToString
                .cboPossuiSistemaAntiFurto.Text = adaptador.Rows(posicao)("Disposit_Ant_Furto").ToString
                .mskAnoFrabric.Text = adaptador.Rows(posicao)("Ano_frabric").ToString



                .cboNaResidencia.Text = adaptador.Rows(posicao)("residencia").ToString
                .cboNoTrabalho.Text = adaptador.Rows(posicao)("trabalho").ToString
                .cboNaEscola.Text = adaptador.Rows(posicao)("local_estudos").ToString

                .cboMatutino.Text = adaptador.Rows(posicao)("matutino").ToString
                .cboVespertino.Text = adaptador.Rows(posicao)("vespertino").ToString
                .cboNoturno.Text = adaptador.Rows(posicao)("noturno").ToString

                .txtRelacaoCondutor.Text = adaptador.Rows(posicao)("especifique").ToString
                .txtSegundoCondutor.Text = adaptador.Rows(posicao)("nomeSegundCondut").ToString
                .mskDataNascSegCondut.Text = adaptador.Rows(posicao)("dt_nascimento").ToString
                .mskKmMediaMensal.Text = adaptador.Rows(posicao)("Km_Media_Mensal").ToString
                .mskCNH.Text = adaptador.Rows(posicao)("CNH_Seg_Condult").ToString
                .txtPrincCondut.Text = adaptador.Rows(posicao)("Nome_princ_condut").ToString
            End With


        Catch ex As Exception

        End Try

    End Sub

    Public Sub MovimentarRegistros(ByVal e As registros)
        Try
            With frmDadosVeiculo
                Select Case e
                    Case registros.Primeiro
                        posicao = 0
                        .btnPrimeiro.Enabled = False
                        .btnVoltar.Enabled = False
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    Case registros.Anterior
                        If posicao > 1 Then
                            posicao -= 1
                            .btnPrimeiro.Enabled = True
                            .btnVoltar.Enabled = True
                            .btnIr.Enabled = True
                            .btnUltimo.Enabled = True
                        Else
                            posicao = 0
                            .btnPrimeiro.Enabled = False
                            .btnVoltar.Enabled = False
                            .btnIr.Enabled = True
                            .btnUltimo.Enabled = True
                        End If

                    Case registros.Proximo
                        If posicao < (adaptador.Rows.Count - 2) Then
                            posicao += 1
                            .btnPrimeiro.Enabled = True
                            .btnVoltar.Enabled = True
                            .btnIr.Enabled = True
                            .btnUltimo.Enabled = True
                        Else
                            posicao = adaptador.Rows.Count - 1
                            .btnPrimeiro.Enabled = True
                            .btnVoltar.Enabled = True
                            .btnIr.Enabled = False
                            .btnUltimo.Enabled = False
                        End If


                    Case registros.Ultimo
                        posicao = adaptador.Rows.Count - 1
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = False
                        .btnUltimo.Enabled = False

                End Select
            End With
        Catch ex As Exception
            MsgBox("Erro - " + ex.Message)
        End Try

    End Sub


End Class
