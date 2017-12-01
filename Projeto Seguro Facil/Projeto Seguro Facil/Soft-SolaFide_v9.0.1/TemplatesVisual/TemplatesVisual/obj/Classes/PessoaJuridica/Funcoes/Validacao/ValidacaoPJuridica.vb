Option Compare Text
Imports System.Text
Imports System.Text.RegularExpressions
Public Class ValidacaoPJuridica
    Dim Objeto As New F_Objeto_PJuri
    Dim Navegar As New Navegar_PJuri
    Public Sub Validacao()
        With CadastrarPessoaJuridica
            If .txtRSocial.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe a Razão Social da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtRSocial.Focus()
                Exit Sub
            ElseIf .TxtNFantasia.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Nome Fantasia da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .TxtNFantasia.Focus()
                Exit Sub
            ElseIf .txtAreaAtuacao.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe a Area de Atuação da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtAreaAtuacao.Focus()
                Exit Sub
            ElseIf .txtRepresent.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Representante Dessa Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtRepresent.Focus()
                Exit Sub
            ElseIf Not .MaskTxtCnpj.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o CNPJ da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .MaskTxtCnpj.Focus()
                Exit Sub
            ElseIf .txtSite.Text = "" Then
                MessageBox.Show("Por Favor, Informe o Site da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtSite.Focus()
                Exit Sub
            ElseIf .txtEndereco.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Endereço da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtEndereco.Focus()
                Exit Sub
            ElseIf .txtNumero.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Número do Endereço da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtNumero.Focus()
                Exit Sub
            ElseIf Not .MaskTxtCep.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o CEP da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .MaskTxtCep.Focus()
                Exit Sub
            ElseIf .txtBairro.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Bairro da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtBairro.Focus()
                Exit Sub
            ElseIf .cboUf.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o UF da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .cboUf.Focus()
                Exit Sub
            ElseIf .txtCidade.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe a Cidade da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtCidade.Focus()
                Exit Sub
            ElseIf .cboStatus.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe um Status para a Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .cboStatus.Focus()
                Exit Sub
            ElseIf Not .MaskTxtTelefone1.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o Telefone da Empresa Cliente", "Erro ao Cadastrar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .MaskTxtTelefone1.Focus()
                Exit Sub
            Else
                CadastrarPessoaJuridica.Cadastrar()
                Objeto.DesbloqueiaNavegacao()
                Objeto.TudoBloqueado()
            End If
        End With
    End Sub
    Public Sub ValidacaoAlterar()
        With CadastrarPessoaJuridica
            If .txtRSocial.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe a Razão Social da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtRSocial.Focus()
                Exit Sub
            ElseIf .TxtNFantasia.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Nome Fantasia da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .TxtNFantasia.Focus()
                Exit Sub
            ElseIf .txtAreaAtuacao.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe a Area de Atuação da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtAreaAtuacao.Focus()
                Exit Sub
            ElseIf .txtRepresent.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Representante Dessa Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtRepresent.Focus()
                Exit Sub
            ElseIf Not .MaskTxtCnpj.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o CNPJ da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .MaskTxtCnpj.Focus()
                Exit Sub
            ElseIf .txtSite.Text = "" Then
                MessageBox.Show("Por Favor, Informe o Site da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtSite.Focus()
                Exit Sub
            ElseIf .txtEndereco.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Endereço da Empresa Cliente", "Erro ao Alterarr Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtEndereco.Focus()
                Exit Sub
            ElseIf .txtNumero.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Número do Endereço da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtNumero.Focus()
                Exit Sub
            ElseIf Not .MaskTxtCep.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o CEP da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .MaskTxtCep.Focus()
                Exit Sub
            ElseIf .txtBairro.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Bairro da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtBairro.Focus()
                Exit Sub
            ElseIf .cboUf.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o UF da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .cboUf.Focus()
                Exit Sub
            ElseIf .txtCidade.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe a Cidade da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .txtCidade.Focus()
                Exit Sub
            ElseIf .cboStatus.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe um Status para a Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .cboStatus.Focus()
                Exit Sub
            ElseIf Not .MaskTxtTelefone1.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o Telefone da Empresa Cliente", "Erro ao Alterar Pessoa Juridica", _
                                MessageBoxButtons.OK)
                .MaskTxtTelefone1.Focus()
                Exit Sub
            Else
                Dim result As Integer = MessageBox.Show("Deseja Realmente Atualizar Esse Cliente?", "Cadastrar Pessoa Jurídica", MessageBoxButtons.YesNo)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    CadastrarPessoaJuridica.Atualizar()
                    Navegar.DescarregarForm()
                    Navegar.CarregarForm()
                    Navegar.AtualizarForm()
                    Objeto.TudoBloqueado()
                    Navegar.MovimentarRegistros(Navegar_PJuri.registros.Primeiro)
                End If
            End If
        End With
    End Sub
End Class