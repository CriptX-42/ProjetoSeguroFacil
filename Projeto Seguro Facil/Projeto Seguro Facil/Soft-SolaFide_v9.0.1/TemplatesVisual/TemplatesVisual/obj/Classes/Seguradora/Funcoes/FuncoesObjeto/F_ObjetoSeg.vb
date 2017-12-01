Public Class F_ObjetoSeg

    Public Sub Novo()
        With CadastrarSeguradora
            .txtNome.Text = ""
            .txtSite.Text = ""
            .txtNextel.Text = ""
            .txtEmail.Text = ""
            .MaskTxtTelefone1.Text = ""
            .MaskTxtTelefone2.Text = ""
            .txtSiteAreaCorretor.Text = ""
            .txtComentarios.Text = ""

            .txtNome.Focus()

            .btnCancelar.Visible = True
            .btnImprimir.Visible = False
        End With

        
    End Sub
    Public Sub TudoBloqueado()
        With CadastrarSeguradora

            .txtNome.Enabled = False
            .txtSite.Enabled = False
            .txtNextel.Enabled = False
            .txtEmail.Enabled = False
            .MaskTxtTelefone1.Enabled = False
            .MaskTxtTelefone2.Enabled = False
            .txtSiteAreaCorretor.Enabled = False
            .txtComentarios.Enabled = False
            .BtnCadastrar.Enabled = False
            DesbloqueiaNavegacao()
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .btnCancelar.Visible = False
        End With

    End Sub
    Public Sub Desbloqueado()
        With CadastrarSeguradora

            .txtNome.Enabled = True
            .txtSite.Enabled = True
            .txtNextel.Enabled = True
            .txtEmail.Enabled = True
            .MaskTxtTelefone1.Enabled = True
            .MaskTxtTelefone2.Enabled = True
            .txtSiteAreaCorretor.Enabled = True
            .txtComentarios.Enabled = True
            .BtnCadastrar.Enabled = True
        End With
        
    End Sub
    Public Sub DesbloqueiaNavegacao()
        With CadastrarSeguradora
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
    Public Sub Bloqueanavegacao()
        With CadastrarSeguradora
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .btnIr.Enabled = False
            .btnUltimo.Enabled = False
            .btnAlterar.Enabled = False
            .btnExcluir.Enabled = False
        End With
        
    End Sub
End Class
