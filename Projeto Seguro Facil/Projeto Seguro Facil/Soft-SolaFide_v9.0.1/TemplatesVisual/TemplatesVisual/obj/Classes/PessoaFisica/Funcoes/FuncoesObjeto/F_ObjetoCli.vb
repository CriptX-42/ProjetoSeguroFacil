Public Class F_ObjetoCli
    Public Sub Novo()
        With frmCadPFisica
            'Inicio dos itens referentes aos Dados da Pessoa Física
            .txtNome.Text = ""
            .TxtId.Text = ""
            .cboEstCivil.SelectedIndex = 0
            .MskCPF.Text = ""
            .mskDataExp.Text = ""
            .cboSexo.SelectedIndex = 0
            .mskNascimento.Text = ""
            .mskRG.Text = ""
            .cboOrgExp.SelectedIndex = 0
            .txtProfissao.Text = ""
            .mskCNH.Text = ""
            .txtTempoHab.Text = ""
            .cboTempoHab.SelectedIndex = 0
            .cboStatus.SelectedIndex = 0
            'Fim dos itens referentes aos Dados da Pessoa Física

            'Inicio dos itens referentes ao Endereço da Pessoa Física
            .txtEndereco.Text = ""
            .txtNumCasa.Text = ""
            .txtCidade.Text = ""
            .mskCEP.Text = ""
            .txtBairro.Text = ""
            .txtComplemento.Text = ""
            .cboUf.SelectedIndex = 0
            .txtBloco.Text = ""
            .txtApto.Text = ""
            'Fim dos itens referentes ao Endereço da Pessoa Física

            'Inicio dos itens referentes ao Contato da Pessoa Física
            .mskCelular.Text = ""
            .txtNextel.Text = ""
            .mskTelRecado.Text = ""
            .mskTelResid.Text = ""
            .txtEmail.Text = ""
            'Inicio dos itens referentes ao Contato da Pessoa Física

            'Inicio dos itens referentes ao Comentário da Pessoa Física
            .txtComentario.Text = ""
            'Inicio dos itens referentes ao Comentário da Pessoa Física

            .txtNome.Focus()

            .btnCancelar.Visible = True
            .btnImprimir.Visible = False
        End With
    End Sub

    Public Sub Desbloqueado()
        With frmCadPFisica
            'Inicio dos itens referentes aos Dados da Pessoa Física
            .txtNome.Enabled = True
            .cboEstCivil.Enabled = True
            .MskCPF.Enabled = True
            .mskDataExp.Enabled = True
            .cboSexo.Enabled = True
            .mskNascimento.Enabled = True
            .mskRG.Enabled = True
            .cboOrgExp.Enabled = True
            .txtProfissao.Enabled = True
            .mskCNH.Enabled = True
            .txtTempoHab.Enabled = True
            .cboTempoHab.Enabled = True
            .cboStatus.Enabled = True
            'Fim dos itens referentes aos Dados da Pessoa Física

            'Inicio dos itens referentes ao Endereço da Pessoa Física
            .txtEndereco.Enabled = True
            .txtNumCasa.Enabled = True
            .txtCidade.Enabled = True
            .mskCEP.Enabled = True
            .txtBairro.Enabled = True
            .txtComplemento.Enabled = True
            .cboUf.Enabled = True
            .txtBloco.Enabled = True
            .txtApto.Enabled = True
            'Fim dos itens referentes ao Endereço da Pessoa Física

            'Inicio dos itens referentes ao Contato da Pessoa Física
            .mskCelular.Enabled = True
            .txtNextel.Enabled = True
            .mskTelRecado.Enabled = True
            .mskTelResid.Enabled = True
            .txtEmail.Enabled = True
            'Inicio dos itens referentes ao Contato da Pessoa Física

            'Inicio dos itens referentes ao Comentário da Pessoa Física
            .txtComentario.Enabled = True
            'Inicio dos itens referentes ao Comentário da Pessoa Física

            .BtnCadastrar.Enabled = True
        End With
    End Sub

    Public Sub TudoBloqueado()
        With frmCadPFisica
            'Inicio dos itens referentes aos Dados da Pessoa Física
            .txtNome.Enabled = False
            .cboEstCivil.Enabled = False
            .MskCPF.Enabled = False
            .mskDataExp.Enabled = False
            .cboSexo.Enabled = False
            .mskNascimento.Enabled = False
            .mskRG.Enabled = False
            .cboOrgExp.Enabled = False
            .txtProfissao.Enabled = False
            .mskCNH.Enabled = False
            .txtTempoHab.Enabled = False
            .cboTempoHab.Enabled = False
            .cboStatus.Enabled = False
            'Fim dos itens referentes aos Dados da Pessoa Física

            'Inicio dos itens referentes ao Endereço da Pessoa Física
            .txtEndereco.Enabled = False
            .txtNumCasa.Enabled = False
            .txtCidade.Enabled = False
            .mskCEP.Enabled = False
            .txtBairro.Enabled = False
            .txtComplemento.Enabled = False
            .cboUf.Enabled = False
            .txtBloco.Enabled = False
            .txtApto.Enabled = False
            'Fim dos itens referentes ao Endereço da Pessoa Física

            'Inicio dos itens referentes ao Contato da Pessoa Física
            .mskCelular.Enabled = False
            .txtNextel.Enabled = False
            .mskTelRecado.Enabled = False
            .mskTelResid.Enabled = False
            .txtEmail.Enabled = False
            'Inicio dos itens referentes ao Contato da Pessoa Física

            'Inicio dos itens referentes ao Comentário da Pessoa Física
            .txtComentario.Enabled = False
            'Inicio dos itens referentes ao Comentário da Pessoa Física

            DesbloqueiaNavegacao()

            .BtnCadastrar.Enabled = False
            .btnCancelar.Visible = False
            .btnProximo.Enabled = False
            .btnUltimo.Enabled = False
        End With
    End Sub

    Public Sub BloqueiaNavegacao()
        With frmCadPFisica
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .btnProximo.Enabled = False
            .btnUltimo.Enabled = False
            .btnAlterar.Enabled = False
            .btnExcluir.Enabled = False
            .mskPesqCPF.Enabled = False
        End With
    End Sub

    Public Sub DesbloqueiaNavegacao()
        With frmCadPFisica
            .btnPrimeiro.Enabled = True
            .btnVoltar.Enabled = True
            .btnProximo.Enabled = True
            .btnUltimo.Enabled = True
            .btnImprimir.Visible = True
            .btnCancelar.Enabled = True
            .BtnLimpar.Enabled = True
            .BtnCadastrar.Enabled = True
            .btnAlterar.Enabled = True
            .btnExcluir.Enabled = True
            .mskPesqCPF.Enabled = True
        End With
    End Sub
End Class
