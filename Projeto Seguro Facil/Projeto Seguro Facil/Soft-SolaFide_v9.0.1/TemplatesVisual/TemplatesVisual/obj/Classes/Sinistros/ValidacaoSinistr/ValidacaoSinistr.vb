Public Class ValidacaoSinistr
    Dim Objeto As New F_ObjetoSinistr

    Public Sub validacao()
        With Sinistros
            If .TxtTipo.Text = "" Then
                MessageBox.Show("Coloque um tipo de sinitro", "Sinitro", _
                                MessageBoxButtons.OK)
                .TxtTipo.Focus()
                Exit Sub
            ElseIf Not IsDate(.MaskedTextBox1.Text) Then
                MessageBox.Show("Data de sinistro invalida", "Sinistro", _
                                MessageBoxButtons.OK)
                .MaskedTextBox1.Focus()
                Exit Sub
            ElseIf .TxtEnvolvidos.Text = "" Then
                MessageBox.Show("Coloque algum envolvido", "Sinistro", _
                                MessageBoxButtons.OK)
                .TxtEnvolvidos.Focus()
                Exit Sub

            ElseIf .txtNumSinistro.Text = "" Then
                MessageBox.Show("Coloque o numero do sinitro", "Sinistro", _
                                MessageBoxButtons.OK)
                .txtNumSinistro.Focus()
                Exit Sub
            ElseIf .txtApolice.Text = "" Then
                MessageBox.Show("Coloque o numero da police", "Sinistro", _
                                MessageBoxButtons.OK)
                .txtApolice.Focus()
                Exit Sub
            ElseIf .txtEndereco.Text.Trim = "" Then
                MessageBox.Show("Informe o Endereço do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtEndereco.Focus()
                Exit Sub
            ElseIf .txtNumCasa.Text.Trim = "" Then
                MessageBox.Show("Informe Numero da casa", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtNumCasa.Focus()
                Exit Sub
            ElseIf .txtCidade.Text.Trim = "" Then
                MessageBox.Show("Informe a cidade", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtCidade.Focus()
                Exit Sub
            ElseIf .txtBairro.Text.Trim = "" Then
                MessageBox.Show("Informe o Bairro", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtBairro.Focus()
                Exit Sub
            ElseIf Not .MaskTxtCep.MaskCompleted Then
                MessageBox.Show("Informe o CEP", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskTxtCep.Focus()
                Exit Sub
            Else
                .Cadastrar()

                MessageBox.Show("Foi Cadastrado", "Sola Fide", _
                                MessageBoxButtons.OK)

                Objeto.DesbloqueiaNavegacao()
                Objeto.TudoBloqueado()
            End If



        End With

    End Sub
    Public Sub ValidacaoAlterar()
        With Sinistros
            If .TxtTipo.Text = "" Then
                MessageBox.Show("Coloque um tipo de sinitro", "Sinitro", _
                                MessageBoxButtons.OK)
                .TxtTipo.Focus()
                Exit Sub
            ElseIf Not IsDate(.MaskedTextBox1.Text) Then
                MessageBox.Show("Data de sinistro invalida", "Sinistro", _
                                MessageBoxButtons.OK)
                .MaskedTextBox1.Focus()
                Exit Sub
            ElseIf .TxtEnvolvidos.Text = "" Then
                MessageBox.Show("Coloque algum envolvido", "Sinistro", _
                                MessageBoxButtons.OK)
                .TxtEnvolvidos.Focus()
                Exit Sub

            ElseIf .txtNumSinistro.Text = "" Then
                MessageBox.Show("Coloque o numero do sinitro", "Sinistro", _
                                MessageBoxButtons.OK)
                .txtNumSinistro.Focus()
                Exit Sub
            ElseIf .txtApolice.Text = "" Then
                MessageBox.Show("Coloque o numero da police", "Sinistro", _
                                MessageBoxButtons.OK)
                .txtApolice.Focus()
                Exit Sub
            ElseIf .txtEndereco.Text.Trim = "" Then
                MessageBox.Show("Informe o Endereço do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtEndereco.Focus()
                Exit Sub
            ElseIf .txtNumCasa.Text.Trim = "" Then
                MessageBox.Show("Informe Numero da casa", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtNumCasa.Focus()
                Exit Sub
            ElseIf .txtCidade.Text.Trim = "" Then
                MessageBox.Show("Informe a cidade", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtCidade.Focus()
                Exit Sub
            ElseIf .txtBairro.Text.Trim = "" Then
                MessageBox.Show("Informe o Bairro", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtBairro.Focus()
                Exit Sub
            ElseIf Not .MaskTxtCep.MaskCompleted Then
                MessageBox.Show("Informe o CEP", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskTxtCep.Focus()
                Exit Sub

            Else
                'For i = 0 To .dgvCliSini.Rows.Count - 1
                '    .Cadastrar(.txtID.Text.ToString, .dgvCliSini.Rows(i).Cells("Codigo").Value, .dgvCliSini.Rows(i).Cells("CodCarro").Value)
                'Next
                .Cadastrar()
                MessageBox.Show("Foi Cadastrado", "Sola Fide", _
                                MessageBoxButtons.OK)

                Objeto.DesbloqueiaNavegacao()
                Objeto.TudoBloqueado()
            End If

        End With

    End Sub
End Class
