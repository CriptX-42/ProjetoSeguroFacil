Public Class F_ObjetoSinistr
    Public Sub Novo()
        With Sinistros
            .TxtTipo.Text = ""
            .TxtEnvolvidos.Text = ""
            .MaskedTextBox1.Text = ""
            .txtNumSinistro.Text = ""
            .txtApolice.Text = ""
            .TxtComentarios.Text = ""
            '====================Data Grid====================================='
            With .dgvCliSini

                For i = 0 To .Rows.Count - 1
                    For Each row As DataGridViewRow In .Rows

                        .Rows.Remove(row)

                    Next
                Next
            End With
            '================================================================='

            .txtNumCasa.Text = ""
            .txtCidade.Text = ""
            .cboUf.SelectedIndex = 0
            .txtEndereco.Text = ""
            .MaskTxtCep.Text = ""
            .txtBairro.Text = ""
            .txtApolice.Text = ""


            .TxtTipo.Focus()
            .btnCancelar.Visible = True
            .btnImprimir.Visible = False
            .BtnCadastrar.Visible = True
        End With

        
    End Sub

    Public Sub Desbloqueado()
        With Sinistros

            .dgvCliSini.Enabled = True
            .btnAdicionarCliente.Enabled = True
            .btnSubtrairCliente.Enabled = True

            .TxtTipo.Enabled = True
            .TxtEnvolvidos.Enabled = True
            .MaskedTextBox1.Enabled = True
            .txtNumSinistro.Enabled = True
            .txtApolice.Enabled = True
            .TxtComentarios.Enabled = True
            ' .LblNomeShow.Enabled = True
            .BtnCadastrar.Enabled = True

            .txtNumCasa.Enabled = True
            .txtCidade.Enabled = True
            .cboUf.Enabled = True
            .txtEndereco.Enabled = True
            .MaskTxtCep.Enabled = True
            .txtBairro.Enabled = True


        End With
    End Sub

    Public Sub TudoBloqueado()

        With Sinistros

            .dgvCliSini.Enabled = False
            .btnAdicionarCliente.Enabled = False
            .btnSubtrairCliente.Enabled = False

            .TxtTipo.Enabled = False
            .TxtEnvolvidos.Enabled = False
            .MaskedTextBox1.Enabled = False
            .txtNumSinistro.Enabled = False
            .txtApolice.Enabled = False
            .TxtComentarios.Enabled = False
            '.LblNomeShow.Enabled = False
            .BtnCadastrar.Enabled = False
            DesbloqueiaNavegacao()
            .btnCancelar.Visible = False
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False


            .txtNumCasa.Enabled = False
            .txtCidade.Enabled = False
            .cboUf.Enabled = False
            .txtEndereco.Enabled = False
            .MaskTxtCep.Enabled = False
            .txtBairro.Enabled = False

        End With


    End Sub

    Public Sub Bloqueanavegacao()
        With Sinistros
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .btnIr.Enabled = False
            .btnUltimo.Enabled = False
            .btnAlterar.Enabled = False
            .btnExcluir.Enabled = False

        End With

    End Sub

    Public Sub DesbloqueiaNavegacao()
        With Sinistros
            .btnPrimeiro.Enabled = True
            .btnVoltar.Enabled = True
            .btnIr.Enabled = True
            .btnUltimo.Enabled = True
            .btnAlterar.Enabled = True
            .btnExcluir.Enabled = True
            .BtLimpar.Enabled = True
            .btnCancelar.Enabled = True
            .btnImprimir.Visible = True
        End With

    End Sub
End Class
