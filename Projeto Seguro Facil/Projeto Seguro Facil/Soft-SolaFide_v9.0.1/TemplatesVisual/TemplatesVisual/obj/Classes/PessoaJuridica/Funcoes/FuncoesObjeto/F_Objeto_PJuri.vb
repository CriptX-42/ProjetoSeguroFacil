Public Class F_Objeto_PJuri
    Public Sub Novo()
        With CadastrarPessoaJuridica
            .txtPesquisa.Text = ""

            .txtRSocial.Text = ""
            .TxtNFantasia.Text = ""
            .txtRepresent.Text = ""
            .MaskTxtCnpj.Text = ""
            .txtAreaAtuacao.Text = ""
            .txtSite.Text = ""
            .TxtComentarios.Text = ""
            .cboStatus.Text = "Selecione"

            .txtEndereco.Text = ""
            .txtNumero.Text = ""
            .MaskTxtCep.Text = ""
            .txtBairro.Text = ""
            .txtCidade.Text = ""
            .cboUf.Text = "Selecione"
            .txtBloco.Text = ""
            .txtComplemento.Text = ""

            .MaskTxtTelefone1.Text = ""
            .mskCelular.Text = ""
            .txtEmail.Text = ""
            .txtApto.Text = ""

            .txtRSocial.Focus()

            .txtPesquisa.Enabled = False
            .btnCancelar.Visible = True
            .btnImprimir.Visible = False
            .PictureBox1.Enabled = False
        End With


    End Sub
    Public Sub TudoBloqueado()

        With CadastrarPessoaJuridica
            .txtRSocial.Enabled = False
            .TxtNFantasia.Enabled = False
            .txtRepresent.Enabled = False
            .MaskTxtCnpj.Enabled = False
            .txtAreaAtuacao.Enabled = False
            .txtSite.Enabled = False
            .TxtComentarios.Enabled = False
            .cboStatus.Enabled = False

            .txtEndereco.Enabled = False
            .txtNumero.Enabled = False
            .MaskTxtCep.Enabled = False
            .txtBairro.Enabled = False
            .txtCidade.Enabled = False
            .cboUf.Enabled = False
            .txtBloco.Enabled = False
            .txtComplemento.Enabled = False

            .MaskTxtTelefone1.Enabled = False
            .mskCelular.Enabled = False
            .txtEmail.Enabled = False

            .txtApto.Enabled = False


            .BtnCadastrar.Enabled = False
            .btnCancelar.Visible = False
            .btnImprimir.Visible = True
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
        End With

        DesbloqueiaNavegacao()

    End Sub
    Public Sub Desbloqueado()
        With CadastrarPessoaJuridica
            .txtRSocial.Enabled = True
            .TxtNFantasia.Enabled = True
            .txtRepresent.Enabled = True
            .MaskTxtCnpj.Enabled = True
            .txtAreaAtuacao.Enabled = True
            .txtSite.Enabled = True
            .TxtComentarios.Enabled = True
            .cboStatus.Enabled = True

            .txtEndereco.Enabled = True
            .txtNumero.Enabled = True
            .MaskTxtCep.Enabled = True
            .txtBairro.Enabled = True
            .txtCidade.Enabled = True
            .cboUf.Enabled = True
            .txtBloco.Enabled = True
            .txtComplemento.Enabled = True

            .MaskTxtTelefone1.Enabled = True
            .mskCelular.Enabled = True
            .txtEmail.Enabled = True

            .txtApto.Enabled = True


            .BtnCadastrar.Enabled = True
            .btnCancelar.Visible = True
        End With



    End Sub

    Public Sub Bloqueanavegacao()
        With CadastrarPessoaJuridica
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .btnIr.Enabled = False
            .btnUltimo.Enabled = False
            .btnAlterar.Enabled = False
            .btnExcluir.Enabled = False
        End With
    End Sub

    Public Sub DesbloqueiaNavegacao()
        With CadastrarPessoaJuridica
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .btnIr.Enabled = True
            .btnUltimo.Enabled = True
            .btnAlterar.Enabled = True
            .btnExcluir.Enabled = True
            .BtLimpar.Enabled = True
            .btnCancelar.Enabled = True
        End With
    End Sub
End Class
