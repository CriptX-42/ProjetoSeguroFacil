Imports MySql.Data.MySqlClient
Public Class F_ObjetoMont
    Dim Conexao As New ConexaoSolafide
    Public Sub Novo()
        With frmCadastrarOrcamento

            .MaskTxtDataDoCalculo.Text = ""
            .MaskTxtVigenciaInicio.Text = ""
            .MaskTxtVigenciaFim.Text = ""
            .TxtFranquia.Text = ""
            .TxtPremio.Text = ""
            .TxtObservacoes.Text = ""
            .mskPercComissao.Text = ""

            .MaskTxtDataDoCalculo.Text = ""
            .MaskTxtVigenciaInicio.Text = ""
            .MaskTxtVigenciaFim.Text = ""

            .cboCobertura.SelectedIndex = 0
            .cboDnMtr.Text = ""
            .cboDnCorp.Text = ""
            .cboAppMorte.Text = ""
            .cboAppInval.Text = ""
            .cboDnMorais.Text = ""
            .cboAss24Horas.SelectedIndex = 0
            .cboVidros.SelectedIndex = 0
            .cboCarReserv.SelectedIndex = 0
            .TxtObservacoes.Text = ""
            .txtProponente.Text = ""
            .btnCancelar.Visible = True

            .MskCI.Text = ""



            Try
                Conexao.conectar()

                Dim sql As String = ("SELECT * FROM tb_Seguradora")
                Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable

                da.Fill(dt)

                .cboSeguradoras.DisplayMember = "nome_seguradora"

                .cboSeguradoras.DataSource = dt

            Catch ex As Exception

            Finally
                Conexao.cn.Close()
            End Try

            .cboFrmPagamento.SelectedIndex = 0
            .cboParcelas.Text = "Selecione"

            .cboParcelas.Enabled = False

            .btnCancelar.Visible = True
            .BtnCadastrar.Visible = True
            .btnImprimir.Visible = False
        End With
        BloqueiaNavegacao()
        frmCadastrarOrcamento.MaskTxtDataDoCalculo.Focus()
    End Sub
    Public Sub Desbloqueado()
        With frmCadastrarOrcamento

            .MaskTxtDataDoCalculo.Enabled = True
            .MaskTxtVigenciaInicio.Enabled = True
            .MaskTxtVigenciaFim.Enabled = True
            .cboSeguradoras.Enabled = True
            .TxtFranquia.Enabled = True
            .TxtPremio.Enabled = True
            .cboParcelas.Enabled = False
            .cboCobertura.Enabled = True
            .cboDnMtr.Enabled = True
            .cboDnCorp.Enabled = True
            .cboAppMorte.Enabled = True
            .cboAppInval.Enabled = True
            .cboDnMorais.Enabled = True
            .cboAss24Horas.Enabled = True
            .cboVidros.Enabled = True
            .cboCarReserv.Enabled = True
            .TxtObservacoes.Enabled = True
            .BtnCadastrar.Enabled = True
            .btnCancelar.Visible = True
            .txtProponente.Enabled = True
            .cboFrmPagamento.Enabled = True
            .btnAdicionarCliente.Enabled = True
            .btnSubtrairCliente.Enabled = True
            .mskPercComissao.Enabled = True

            '.btnPesquisar.Enabled = True
            .MskCI.Enabled = True

        End With
    End Sub
    Public Sub TudoBloqueado()
        With frmCadastrarOrcamento
            .MaskTxtDataDoCalculo.Enabled = False
            .MaskTxtVigenciaInicio.Enabled = False
            .MaskTxtVigenciaFim.Enabled = False
            .cboSeguradoras.Enabled = False
            .TxtFranquia.Enabled = False
            .TxtPremio.Enabled = False
            .cboParcelas.Enabled = False
            .cboCobertura.Enabled = False
            .cboDnMtr.Enabled = False
            .cboDnCorp.Enabled = False
            .cboAppMorte.Enabled = False
            .cboAppInval.Enabled = False
            .cboDnMorais.Enabled = False
            .cboAss24Horas.Enabled = False
            .cboVidros.Enabled = False
            .cboCarReserv.Enabled = False
            .TxtObservacoes.Enabled = False
            DesbloqueiaNavegacao()
            .BtnCadastrar.Enabled = False
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .txtProponente.Enabled = False
            .cboFrmPagamento.Enabled = False
            .btnAdicionarCliente.Enabled = False
            .btnSubtrairCliente.Enabled = False
            .btnCancelar.Visible = False
            .MskCI.Enabled = False
            .mskPercComissao.Enabled = False
            '.btnPesquisar.Enabled = False
        End With
    End Sub
    Public Sub BloqueiaNavegacao()
        With frmCadastrarOrcamento
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .btnIr.Enabled = False
            .btnUltimo.Enabled = False
            .btnAlterar.Enabled = False
            .btnExcluir.Enabled = False
            '.btnPesquisar.Enabled = True
        End With

    End Sub
    Public Sub DesbloqueiaNavegacao()
        With frmCadastrarOrcamento
            .btnPrimeiro.Enabled = True
            .btnVoltar.Enabled = True
            .btnIr.Enabled = True
            .btnUltimo.Enabled = True
            .BtnCadastrar.Enabled = True
            .btnAlterar.Enabled = True
            .btnExcluir.Enabled = True
            .BtLimpar.Enabled = True
            .btnCancelar.Enabled = True
            .btnImprimir.Visible = True
        End With

    End Sub
End Class
