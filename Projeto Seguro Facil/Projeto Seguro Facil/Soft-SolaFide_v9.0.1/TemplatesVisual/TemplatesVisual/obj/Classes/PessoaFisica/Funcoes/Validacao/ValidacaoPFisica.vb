Option Compare Text
Imports System.Text
Imports System.Text.RegularExpressions
Public Class ValidacaoPFisica
    Dim Objeto As New F_ObjetoCli
    Dim Navegacao As New Navegar
    Dim strRegex As String = _
"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
    Dim re As New Regex(strRegex)
    Public Sub Validacao()
        With frmCadPFisica
            If .txtNome.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Nome do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtNome.Focus()
                Exit Sub
            ElseIf Not .MskCPF.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o CPF do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .MskCPF.Focus()
                Exit Sub
            ElseIf Not IsDate(.mskNascimento.Text) Then
                MessageBox.Show("Por Favor, Informe uma Data de Nascimento Válida", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                frmCadPFisica.mskNascimento.Focus()
                Exit Sub
            ElseIf Not IsDate(.mskDataExp.Text) Then
                MessageBox.Show("Por Favor, Informe uma Data de Expedição Válida", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .mskDataExp.Focus()
                Exit Sub
            ElseIf Not .mskRG.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe um RG Válido", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .mskRG.Focus()
                Exit Sub
            ElseIf .txtTempoHab.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Tempo de Habilitação do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtTempoHab.Focus()
                Exit Sub
            ElseIf .txtEndereco.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Endereço do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtEndereco.Focus()
                Exit Sub
            ElseIf .txtNumCasa.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe Número da Casa do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtNumCasa.Focus()
                Exit Sub
            ElseIf .txtCidade.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe a Cidade do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtCidade.Focus()
                Exit Sub
            ElseIf .txtBairro.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Bairro do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtBairro.Focus()
                Exit Sub
            ElseIf Not .mskTelResid.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o Telefone Residencial do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .mskTelResid.Focus()
                Exit Sub
            ElseIf Not (re.IsMatch(.txtEmail.Text)) And .txtEmail.Text.Trim = "" Then
                MessageBox.Show("Por favor, digite um endereço de E-mail valido", "Erro ao Cadastrar Pessoa Física", _
          MessageBoxButtons.OK)
                .txtEmail.Focus()
                Exit Sub
                '= CBO'S ===========================================
            ElseIf .cboSexo.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o Sexo do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboSexo.Focus()
                Exit Sub
            ElseIf .cboEstCivil.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o Estado Civil do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboEstCivil.Focus()
                Exit Sub
            ElseIf .cboOrgExp.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o Orgão Expeditor do RG do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboSexo.Focus()
                Exit Sub
            ElseIf .cboTempoHab.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o Tempo de Halibitação do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboTempoHab.Focus()
                Exit Sub
            ElseIf .cboStatus.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe Status do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboStatus.Focus()
                Exit Sub
            ElseIf .cboUf.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o UF do Cliente", "Erro ao Cadastrar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboUf.Focus()
                Exit Sub
            Else
                frmCadPFisica.Cadastrar()
                Objeto.TudoBloqueado()
            End If
        End With
    End Sub
    Public Sub ValidacaoAlterar()
        With frmCadPFisica
            If .txtNome.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Nome do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtNome.Focus()
                Exit Sub
            ElseIf Not .MskCPF.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o CPF do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .MskCPF.Focus()
                Exit Sub
            ElseIf Not IsDate(.mskNascimento.Text) Then
                MessageBox.Show("Por Favor, Informe uma Data de Nascimento Válida", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                frmCadPFisica.mskNascimento.Focus()
                Exit Sub
            ElseIf Not IsDate(.mskDataExp.Text) Then
                MessageBox.Show("Por Favor, Informe uma Data de Expedição Válida", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .mskDataExp.Focus()
                Exit Sub
            ElseIf Not .mskRG.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe um RG Válido", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .mskRG.Focus()
                Exit Sub
            ElseIf .txtTempoHab.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Tempo de Habilitação do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtTempoHab.Focus()
                Exit Sub
            ElseIf .txtEndereco.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Endereço do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtEndereco.Focus()
                Exit Sub
            ElseIf .txtNumCasa.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe Número da Casa do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtNumCasa.Focus()
                Exit Sub
            ElseIf .txtCidade.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe a Cidade do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtCidade.Focus()
                Exit Sub
            ElseIf .txtBairro.Text.Trim = "" Then
                MessageBox.Show("Por Favor, Informe o Bairro do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .txtBairro.Focus()
                Exit Sub
            ElseIf Not .mskTelResid.MaskCompleted Then
                MessageBox.Show("Por Favor, Informe o Telefone Residencial do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .mskTelResid.Focus()
                Exit Sub
            ElseIf Not (re.IsMatch(.txtEmail.Text)) And .txtEmail.Text.Trim = "" Then
                MessageBox.Show("Por favor, digite um endereço de E-mail valido", "Erro ao Alterar Pessoa Física", _
          MessageBoxButtons.OK)
                .txtEmail.Focus()
                Exit Sub
                '= CBO'S ===========================================
            ElseIf .cboSexo.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o Sexo do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboSexo.Focus()
                Exit Sub
            ElseIf .cboEstCivil.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o Estado Civil do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboEstCivil.Focus()
                Exit Sub
            ElseIf .cboOrgExp.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o Orgão Expeditor do RG do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboSexo.Focus()
                Exit Sub
            ElseIf .cboTempoHab.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o Tempo de Halibitação do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboTempoHab.Focus()
                Exit Sub
            ElseIf .cboStatus.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe Status do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboStatus.Focus()
                Exit Sub
            ElseIf .cboUf.SelectedIndex = 0 Then
                MessageBox.Show("Por Favor, Informe o UF do Cliente", "Erro ao Alterar Pessoa Física", _
                                MessageBoxButtons.OK)
                .cboUf.Focus()
                Exit Sub
            Else
                Dim result As Integer = MessageBox.Show("Quer Realmente Atualizar Esse Cliente ?", "Alterar Pessoa Física", MessageBoxButtons.YesNo)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    frmCadPFisica.Atualizar()
                    Objeto.TudoBloqueado()
                End If
            End If
        End With
    End Sub
End Class