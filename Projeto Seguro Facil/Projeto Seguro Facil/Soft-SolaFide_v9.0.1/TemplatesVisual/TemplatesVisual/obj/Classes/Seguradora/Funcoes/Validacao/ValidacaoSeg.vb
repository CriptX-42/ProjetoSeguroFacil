Option Compare Text
Imports System.Text
Imports System.Text.RegularExpressions
Public Class ValidacaoSeg
    Dim Objeto As New F_ObjetoSeg
    Dim Navegacao As New NavegarSeg
    Dim strRegex As String = _
"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
    Dim re As New Regex(strRegex)
    Public Sub Validacao()


        If CadastrarSeguradora.txtNome.Text.Trim = "" Then
            MessageBox.Show("Informe o nome da seguradora", "Cadastrar", _
                            MessageBoxButtons.OK)
            CadastrarSeguradora.txtNome.Focus()
            Exit Sub
        ElseIf CadastrarSeguradora.txtSite.Text = "" Then
            MessageBox.Show("Informe o site da seguradora", "Cadastrar", _
                            MessageBoxButtons.OK)
            CadastrarSeguradora.txtSite.Focus()
            Exit Sub
        ElseIf CadastrarSeguradora.txtSiteAreaCorretor.Text = "" Then
            MessageBox.Show("Informe o site do corretor", "Cadastrar", _
                            MessageBoxButtons.OK)
            CadastrarSeguradora.txtSite.Focus()
            Exit Sub
        ElseIf CadastrarSeguradora.MaskTxtTelefone1.Text.Trim = "()-" Then
            MessageBox.Show("Informe o Telefone Comercial", "Cadastrar", _
                            MessageBoxButtons.OK)
            frmCadPFisica.mskTelResid.Focus()
            Exit Sub
        ElseIf Not (re.IsMatch(CadastrarSeguradora.txtEmail.Text)) And CadastrarSeguradora.txtEmail.Text.Trim = "" Then
            MessageBox.Show("Por favor, digite um endereço de E-mail valido", "Cadastrar", _
      MessageBoxButtons.OK)
            CadastrarSeguradora.txtEmail.Focus()
            Exit Sub
        Else
            CadastrarSeguradora.Cadastrar()
            MessageBox.Show("Seguradora Cadastrada Com Sucesso!", "Sola Fide", _
                            MessageBoxButtons.OK)
            Objeto.DesbloqueiaNavegacao()
            Objeto.TudoBloqueado()
        End If

    End Sub
    Public Sub ValidacaoAlterar()
        If CadastrarSeguradora.txtNome.Text.Trim = "" Then
            MessageBox.Show("Informe o nome da seguradora", "Cadastrar", _
                            MessageBoxButtons.OK)
            CadastrarSeguradora.txtNome.Focus()
            Exit Sub
        ElseIf CadastrarSeguradora.txtSite.Text = "" Then
            MessageBox.Show("Informe o site da seguradora", "Cadastrar", _
                            MessageBoxButtons.OK)
            CadastrarSeguradora.txtSite.Focus()
            Exit Sub
        ElseIf CadastrarSeguradora.txtSiteAreaCorretor.Text = "" Then
            MessageBox.Show("Informe o site do corretor", "Cadastrar", _
                            MessageBoxButtons.OK)
            CadastrarSeguradora.txtSite.Focus()
            Exit Sub
        ElseIf CadastrarSeguradora.MaskTxtTelefone1.Text.Trim = "()-" Then
            MessageBox.Show("Informe o Telefone Comercial", "Cadastrar", _
                            MessageBoxButtons.OK)
            frmCadPFisica.mskTelResid.Focus()
            Exit Sub
        ElseIf Not (re.IsMatch(CadastrarSeguradora.txtEmail.Text)) And CadastrarSeguradora.txtEmail.Text.Trim = "" Then
            MessageBox.Show("Por favor, digite um endereço de E-mail valido", "Cadastrar", _
      MessageBoxButtons.OK)
            CadastrarSeguradora.txtEmail.Focus()
            Exit Sub
        Else
            Dim result As Integer = MessageBox.Show("Quer realmente atualizar essa Seguradora ?", "Sola Fide", MessageBoxButtons.YesNo)

            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                MessageBox.Show("Seguradora Alterada Com Sucesso!", "Sola Fide", _
                            MessageBoxButtons.OK)
                CadastrarSeguradora.Atualizar()

                Objeto.TudoBloqueado()

            End If
        End If



    End Sub
End Class
