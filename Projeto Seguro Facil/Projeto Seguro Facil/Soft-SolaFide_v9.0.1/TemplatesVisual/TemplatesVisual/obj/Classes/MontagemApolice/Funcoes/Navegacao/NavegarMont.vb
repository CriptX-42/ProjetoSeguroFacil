Imports MySql.Data.MySqlClient
Public Class NavegarMont
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

            Dim adtp As New MySqlDataAdapter("SELECT * FROM tb_MontagemApolice Left Join tb_pagamento ON tb_MontagemApolice.id_MontagemApolice = tb_pagamento.tb_MontagemApolice_id_MontagemApolice Left Join tb_pessoa_fisica on tb_MontagemApolice.id_MontagemApolice = tb_pessoa_fisica.id_Pessoa_Fisica" & _
           " Inner Join tb_proponente on tb_MontagemApolice.id_MontagemApolice = tb_proponente.id_Proponente ;", Conexao)
            adtp.Fill(adaptador)

        Catch ex As Exception
            MsgBox("Erro em selecionar " + ex.Message)
        Finally
            Conexao.Close()
        End Try
    End Sub

    Public Sub DescarregarForm()
        Try
            adaptador.Clear()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AtualizarForm()
        Try
            With frmCadastrarOrcamento

                .txtId.Text = adaptador.Rows(posicao)("id_MontagemApolice").ToString
                .MaskTxtDataDoCalculo.Text = adaptador.Rows(posicao)("dt_calculo").ToString
                .MaskTxtVigenciaInicio.Text = adaptador.Rows(posicao)("dt_inicio").ToString
                .MaskTxtVigenciaFim.Text = adaptador.Rows(posicao)("dt_fim").ToString
                .TxtPremio.Text = adaptador.Rows(posicao)("premio_seguradora").ToString
                .TxtFranquia.Text = adaptador.Rows(posicao)("franquia").ToString
                .cboCobertura.Text = adaptador.Rows(posicao)("tipo_cobertura").ToString
                .cboDnMtr.Text = adaptador.Rows(posicao)("dano_material").ToString
                .cboDnCorp.Text = adaptador.Rows(posicao)("dano_corporal").ToString
                .MskCI.Text = adaptador.Rows(posicao)("CI").ToString
                .cboAppMorte.Text = adaptador.Rows(posicao)("app_morte").ToString
                .cboAppInval.Text = adaptador.Rows(posicao)("app_invalidez").ToString
                .cboDnMorais.Text = adaptador.Rows(posicao)("dano_moral").ToString
                .cboAss24Horas.Text = adaptador.Rows(posicao)("assist_24_horas").ToString
                .cboVidros.Text = adaptador.Rows(posicao)("vidros").ToString
                .cboCarReserv.Text = adaptador.Rows(posicao)("car_reserv").ToString
                .TxtObservacoes.Text = adaptador.Rows(posicao)("comentarios").ToString
                .cboSeguradoras.Text = adaptador.Rows(posicao)("Seguradora_Orc").ToString
                .txtProponente.Text = adaptador.Rows(posicao)("nomeProponente").ToString
                .mskPercComissao.Text = adaptador.Rows(posicao)("perc_comissao").ToString

                If adaptador.Rows(posicao)("parcelas").ToString = "1" Then
                    .cboFrmPagamento.Text = "A vista"
                Else
                    .cboFrmPagamento.Text = "Parcelado"
                    .cboParcelas.Text = adaptador.Rows(posicao)("parcelas").ToString
                End If

            End With


        Catch ex As Exception

        End Try

    End Sub
    Public Sub MovimentarRegistros(ByVal e As registros)
        Select Case e
            Case registros.Primeiro
                posicao = 0
                With frmCadastrarOrcamento
                    .btnPrimeiro.Enabled = False
                    .btnVoltar.Enabled = False
                    .btnIr.Enabled = True
                    .btnUltimo.Enabled = True
                End With
            Case registros.Anterior
                If posicao > 1 Then
                    With frmCadastrarOrcamento
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    End With
                    posicao -= 1
                Else
                    With frmCadastrarOrcamento
                        .btnPrimeiro.Enabled = False
                        .btnVoltar.Enabled = False
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    End With
                    posicao = 0
                End If

            Case registros.Proximo
                If posicao < (adaptador.Rows.Count - 2) Then
                    With frmCadastrarOrcamento
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = True
                        .btnUltimo.Enabled = True
                    End With
                    posicao += 1
                Else
                    With frmCadastrarOrcamento
                        .btnPrimeiro.Enabled = True
                        .btnVoltar.Enabled = True
                        .btnIr.Enabled = False
                        .btnUltimo.Enabled = False
                    End With
                    posicao = adaptador.Rows.Count - 1
                End If


            Case registros.Ultimo
                With frmCadastrarOrcamento
                    .btnPrimeiro.Enabled = True
                    .btnVoltar.Enabled = True
                    .btnIr.Enabled = False
                    .btnUltimo.Enabled = False
                End With
                posicao = adaptador.Rows.Count - 1

        End Select
    End Sub
End Class
