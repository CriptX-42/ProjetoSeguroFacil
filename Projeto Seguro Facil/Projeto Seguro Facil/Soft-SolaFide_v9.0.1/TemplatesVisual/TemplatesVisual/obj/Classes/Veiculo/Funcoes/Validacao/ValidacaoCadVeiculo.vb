Public Class ValidacaoCadVeiculo
    Dim Objeto As New F_ObjetoQuest
    Dim Navegacao As New NavegarVeiculo
    Public Sub Validacao()
        With frmDadosVeiculo
            '--------------------------------Parte de veiculo ---------------------------------
            If .cboFabricante.Text = "" Then
                MessageBox.Show("Informe a fabricante do veiculo!", "Cadastro de veiculo", _
                                MessageBoxButtons.OK)
                .cboFabricante.Focus()
                Exit Sub
            ElseIf .cboModelo.Text = "" Then
                MessageBox.Show("Informe o modelo do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboModelo.Focus()
                Exit Sub
            ElseIf Not .mskAnoFrabric.MaskCompleted Then
                MessageBox.Show("Informe o ano de fabricação do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboModelo.Focus()
                Exit Sub
            ElseIf Not .mskPlaca.MaskCompleted Then
                MessageBox.Show("Informe a Placa do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .mskPlaca.Focus()
                Exit Sub
            ElseIf Not .txtChassi.MaskCompleted Then
                MessageBox.Show("Informe o chassi do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .txtChassi.Focus()
                Exit Sub
            ElseIf .txtChassi.Text = "" Then
                MessageBox.Show("Informe o chassi do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .txtChassi.Focus()
                Exit Sub
            ElseIf .NumDPortas.Value = 0 Then
                MessageBox.Show("Informe o numero de portas", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .NumDPortas.Focus()
                Exit Sub
            ElseIf .txtCor.Text = "" Then
                MessageBox.Show("Informe a cor do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .txtCor.Focus()
                Exit Sub
            ElseIf Not .txtRenavan.MaskCompleted Then
                MessageBox.Show("Informe o Renavan!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .txtRenavan.Focus()
                Exit Sub
            ElseIf .cboCombustivel.Text = "Selecione" Then
                MessageBox.Show("Informe o combustivel!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboCombustivel.Focus()

            ElseIf .cboKitGas.Text = "Selecione" Then
                MessageBox.Show("Informe o Kit Gas!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboKitGas.Focus()
                Exit Sub
            ElseIf .cboFinanciamento.Text = "Selecione" Then
                MessageBox.Show("Informe o Financiamento!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboFinanciamento.Focus()
                Exit Sub
            ElseIf .cboPossuiSistemaAntiFurto.Text = "Selecione" Then
                MessageBox.Show("Informe se possui sistema ant furto!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboPossuiSistemaAntiFurto.Focus()
                Exit Sub
                '----------------------**********----------------------------
                '-------------------QUESTIONARIO PARTE 1, 2, 3 e 4 ----------------
            ElseIf .LblNomeShow.Text = "" Then
                MessageBox.Show("Selecione um cliente!", "Questionario", _
                               MessageBoxButtons.OK)
                Exit Sub
            ElseIf .cboSeguradProprietario.Text = "Selecione" Then
                MessageBox.Show("Informe a relação do condutor com o segurado!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboSeguradProprietario.Focus()
                Exit Sub
            ElseIf .txtPrincCondut.Text = "" Then
                MessageBox.Show("Informe o nome do principal condutor!", "Questionario", _
                               MessageBoxButtons.OK)
                .txtPrincCondut.Focus()
                Exit Sub
                '______________________________________Parte 2_______________________________________

            ElseIf .mskDataNascSegCondut.MaskCompleted And Not IsDate(.mskDataNascSegCondut.Text) Then
                MessageBox.Show("Data de Nascimento Inválida", "Questionario", _
                                MessageBoxButtons.OK)
                .mskDataNascSegCondut.Focus()
                Exit Sub
            ElseIf .cboPrincipalCondutorReside.Text = "" Then
                MessageBox.Show("Informe onde o principal condutor reside!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboPrincipalCondutorReside.Focus()
                Exit Sub



            ElseIf Not .mskCepDePerNoite.MaskCompleted Then
                MessageBox.Show("Informe o CEP Pernoite!", "Questionario", _
                               MessageBoxButtons.OK)
                .mskCepDePerNoite.Focus()
                Exit Sub
            ElseIf .mskKmMediaMensal.Text = "" Then
                MessageBox.Show("Informe o KM de média mensal!", "Questionario", _
                               MessageBoxButtons.OK)
                .mskKmMediaMensal.Focus()
                Exit Sub


                '____________________***********************************___________
                '____________________Parte 4 ______________________________________

            ElseIf .cboPrincipalCondutorReside.Text = "Selecione" Then
                MessageBox.Show("Informe onde o principal condutor reside!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboPrincipalCondutorReside.Focus()
                Exit Sub
            ElseIf .cboResidemComCondutor.Text = "Selecione" Then
                MessageBox.Show("Informe se ele reside com condutor de 18 a 25 anos!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboResidemComCondutor.Focus()
                Exit Sub
            ElseIf .cboRoubo.Text = "Selecione" Then
                MessageBox.Show("Informe se ele foi vitima de roubo nos ultimos 2 anos!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboRoubo.Focus()
                Exit Sub
            ElseIf .txtClasseDeBonus.Text = "Selecione" Then
                MessageBox.Show("Informe a classe bônus!", "Questionario", _
                               MessageBoxButtons.OK)
                .txtClasseDeBonus.Focus()
                Exit Sub
            ElseIf .cboUsoVeiculo.Text = "Selecione" Then
                MessageBox.Show("Informe uso do veiculo!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboUsoVeiculo.Focus()
                Exit Sub

                '------------------------****************************----------
            Else

                frmDadosVeiculo.Cadastrar()
                MessageBox.Show("Veiculo Cadastrado com Sucesso!", "Sola Fide", _
                                MessageBoxButtons.OK)
                Objeto.DesbloqueiaNavegacao()
                Objeto.TudoBloqueado()
            End If


        End With

    End Sub
    Public Sub ValidacaoAlterar()

        With frmDadosVeiculo
            '--------------------------------Parte de veiculo ---------------------------------
            If .cboFabricante.Text = "" Then
                MessageBox.Show("Informe a fabricante do veiculo!", "Cadastro de veiculo", _
                                MessageBoxButtons.OK)
                .cboFabricante.Focus()
                Exit Sub
            ElseIf .cboModelo.Text = "" Then
                MessageBox.Show("Informe o modelo do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboModelo.Focus()
                Exit Sub
            ElseIf Not .mskAnoFrabric.MaskCompleted Then
                MessageBox.Show("Informe o ano de fabricação do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboModelo.Focus()
                Exit Sub
            ElseIf Not .mskPlaca.MaskCompleted Then
                MessageBox.Show("Informe a Placa do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .mskPlaca.Focus()
                Exit Sub
            ElseIf Not .txtChassi.MaskCompleted Then
                MessageBox.Show("Informe o chassi do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .txtChassi.Focus()
                Exit Sub
            ElseIf .txtChassi.Text = "" Then
                MessageBox.Show("Informe o chassi do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .txtChassi.Focus()
                Exit Sub
            ElseIf .NumDPortas.Value = 0 Then
                MessageBox.Show("Informe o numero de portas", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .NumDPortas.Focus()
                Exit Sub
            ElseIf .txtCor.Text = "" Then
                MessageBox.Show("Informe a cor do veiculo!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .txtCor.Focus()
                Exit Sub
            ElseIf Not .txtRenavan.MaskCompleted Then
                MessageBox.Show("Informe o Renavan!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .txtRenavan.Focus()
                Exit Sub
            ElseIf .cboCombustivel.Text = "Selecione" Then
                MessageBox.Show("Informe o combustivel!", "Alteração de veiculo", _
                               MessageBoxButtons.OK)
                .cboCombustivel.Focus()
                Exit Sub
            ElseIf .cboKitGas.Text = "Selecione" Then
                MessageBox.Show("Informe o Kit Gas!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboKitGas.Focus()
                Exit Sub
            ElseIf .cboFinanciamento.Text = "Selecione" Then
                MessageBox.Show("Informe o Financiamento!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboFinanciamento.Focus()
                Exit Sub
            ElseIf .cboPossuiSistemaAntiFurto.Text = "Selecione" Then
                MessageBox.Show("Informe se possui sistema ant furto!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboPossuiSistemaAntiFurto.Focus()
                Exit Sub
                '----------------------**********----------------------------
                '-------------------QUESTIONARIO PARTE 1, 2, 3 e 4 ----------------
            ElseIf .LblNomeShow.Text = "" Then
                MessageBox.Show("Selecione um cliente!", "Questionario", _
                               MessageBoxButtons.OK)
                Exit Sub
            ElseIf .cboSeguradProprietario.Text = "Selecione" Then
                MessageBox.Show("Informe a relação do condutor com o segurado!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboSeguradProprietario.Focus()
                Exit Sub
            ElseIf .txtPrincCondut.Text = "" Then
                MessageBox.Show("Informe o nome do principal condutor!", "Questionario", _
                               MessageBoxButtons.OK)
                .txtPrincCondut.Focus()
                Exit Sub
                '______________________________________Parte 2_______________________________________

            ElseIf .mskDataNascSegCondut.MaskCompleted And Not IsDate(.mskDataNascSegCondut.Text) Then
                MessageBox.Show("Data de Nascimento Inválida", "Questionario", _
                                MessageBoxButtons.OK)
                .mskDataNascSegCondut.Focus()
                Exit Sub
            ElseIf .cboPrincipalCondutorReside.Text = "" Then
                MessageBox.Show("Informe onde o principal condutor reside!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboPrincipalCondutorReside.Focus()
                Exit Sub



            ElseIf Not .mskCepDePerNoite.MaskCompleted Then
                MessageBox.Show("Informe o CEP Pernoite!", "Questionario", _
                               MessageBoxButtons.OK)
                .mskCepDePerNoite.Focus()
                Exit Sub
            ElseIf .mskKmMediaMensal.Text = "" Then
                MessageBox.Show("Informe o KM de média mensal!", "Questionario", _
                               MessageBoxButtons.OK)
                .mskKmMediaMensal.Focus()
                Exit Sub


                '____________________***********************************___________
                '____________________Parte 4 ______________________________________

            ElseIf .cboPrincipalCondutorReside.Text = "Selecione" Then
                MessageBox.Show("Informe onde o principal condutor reside!", "Cadastro de veiculo", _
                               MessageBoxButtons.OK)
                .cboPrincipalCondutorReside.Focus()
                Exit Sub
            ElseIf .cboResidemComCondutor.Text = "Selecione" Then
                MessageBox.Show("Informe se ele reside com condutor de 18 a 25 anos!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboResidemComCondutor.Focus()
                Exit Sub
            ElseIf .cboRoubo.Text = "Selecione" Then
                MessageBox.Show("Informe se ele foi vitima de roubo nos ultimos 2 anos!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboRoubo.Focus()
                Exit Sub
            ElseIf .txtClasseDeBonus.Text = "Selecione" Then
                MessageBox.Show("Informe a classe bônus!", "Questionario", _
                               MessageBoxButtons.OK)
                .txtClasseDeBonus.Focus()
                Exit Sub
            ElseIf .cboUsoVeiculo.Text = "Selecione" Then
                MessageBox.Show("Informe uso do veiculo!", "Questionario", _
                               MessageBoxButtons.OK)
                .cboUsoVeiculo.Focus()
                Exit Sub

            Else

                Dim result As Integer = MessageBox.Show("Quer realmente atualizar essa Seguradora ?", "Sola Fide", MessageBoxButtons.YesNo)

                If result = DialogResult.Cancel Then

                ElseIf result = DialogResult.No Then

                ElseIf result = DialogResult.Yes Then
                    MessageBox.Show("Seguradora Alterada Com Sucesso!", "Sola Fide", _
                                MessageBoxButtons.OK)
                    frmDadosVeiculo.Atualizar()

                    Objeto.TudoBloqueado()

                End If
            End If
        End With
    End Sub
End Class
