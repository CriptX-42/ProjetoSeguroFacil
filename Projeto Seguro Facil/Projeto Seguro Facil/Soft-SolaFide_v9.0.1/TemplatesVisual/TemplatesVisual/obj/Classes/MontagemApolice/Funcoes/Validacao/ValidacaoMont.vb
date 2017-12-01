Public Class ValidacaoMont
    Dim Objeto As New F_ObjetoMont
    Public Sub validacao()
        With frmCadastrarOrcamento
            If Not IsDate(.MaskTxtDataDoCalculo.Text) Then
                MessageBox.Show("Data do Calculo Inválida", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MaskTxtDataDoCalculo.Focus()
                Exit Sub
            ElseIf Not IsDate(.MaskTxtVigenciaInicio.Text) Then
                MessageBox.Show("Data de Inicio Vigência Invalida", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MaskTxtVigenciaInicio.Focus()
                Exit Sub
            ElseIf Not IsDate(.MaskTxtVigenciaFim.Text) Then
                MessageBox.Show("Data de Fim da Vigência Inválida", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MaskTxtVigenciaFim.Focus()
                Exit Sub
            ElseIf .TxtFranquia.Text = "" Then
                MessageBox.Show("Digite a franquia", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .TxtFranquia.Focus()
                Exit Sub
            ElseIf .TxtPremio.Text = "" Then
                MessageBox.Show("Digite o premio", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .TxtPremio.Focus()
                Exit Sub
            ElseIf .mskPercComissao.Text = "" Then
                MessageBox.Show("Digite Perc. de Comissão", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .mskPercComissao.Focus()
                Exit Sub
            ElseIf .txtProponente.Text = "" Then
                MessageBox.Show("Digite o nome do proponete", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .txtProponente.Focus()
                Exit Sub
            ElseIf .cboDnMtr.Text = "" Then
                MessageBox.Show("Digite o valor de dano material ", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MskCI.Focus()
                Exit Sub
            ElseIf Not .MskCI.MaskCompleted Then
                MessageBox.Show("Digite o CI", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MskCI.Focus()
                Exit Sub
            ElseIf .cboDnCorp.Text = "" Then
                MessageBox.Show("Digite o valor de dano corporal", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboDnCorp.Focus()
                Exit Sub
            ElseIf .cboAppMorte.Text = "" Then
                MessageBox.Show("Digite o valor de app. Morte", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboAppMorte.Focus()
                Exit Sub
            ElseIf .cboAppInval.Text = "" Then
                MessageBox.Show("Digite o valor de app. invalidez", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboAppInval.Focus()
                Exit Sub

            ElseIf .cboAss24Horas.SelectedIndex = 0 Then
                MessageBox.Show("Escolha a assistente 24 horas", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboAss24Horas.Focus()
                Exit Sub
            ElseIf .cboVidros.SelectedIndex = 0 Then
                MessageBox.Show("Escolha o vidro", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboVidros.Focus()
                Exit Sub
            ElseIf .cboCarReserv.SelectedIndex = 0 Then
                MessageBox.Show("Escolha o carro reserva", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboCarReserv.Focus()
                Exit Sub
                'ElseIf .MSKApolice.Text = "" Then
                '   MessageBox.Show("Digite a apolice", "Cadastrar Orcamento", _
                '                  MessageBoxButtons.OK)
                '  .TxtFranquia.Focus()
                Exit Sub

            Else
                .Cadastrar()

            End If


            MessageBox.Show("Foi Cadastrado", "Sola Fide", _
                            MessageBoxButtons.OK)

            Objeto.DesbloqueiaNavegacao()
            Objeto.TudoBloqueado()
            Exit Sub



        End With

    End Sub
    Public Sub ValidacaoAlterar()
        With frmCadastrarOrcamento
            If Not IsDate(.MaskTxtDataDoCalculo.Text) Then
                MessageBox.Show("Data do Calculo Inválida", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MaskTxtDataDoCalculo.Focus()
                Exit Sub
            ElseIf Not IsDate(.MaskTxtVigenciaInicio.Text) Then
                MessageBox.Show("Data de Inicio Vigência Invalida", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MaskTxtVigenciaInicio.Focus()
                Exit Sub
            ElseIf Not IsDate(.MaskTxtVigenciaFim.Text) Then
                MessageBox.Show("Data de Fim da Vigência Inválida", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MaskTxtVigenciaFim.Focus()
                Exit Sub
            ElseIf .TxtFranquia.Text = "" Then
                MessageBox.Show("Digite a franquia", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .TxtFranquia.Focus()
                Exit Sub
            ElseIf .TxtPremio.Text = "" Then
                MessageBox.Show("Digite o premio", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .TxtPremio.Focus()
                Exit Sub
            ElseIf .mskPercComissao.Text = "" Then
                MessageBox.Show("Digite Perc. de Comissão", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .mskPercComissao.Focus()
                Exit Sub
            ElseIf .txtProponente.Text = "" Then
                MessageBox.Show("Digite o nome do proponete", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .txtProponente.Focus()
                Exit Sub
            ElseIf .cboDnMtr.Text = "" Then
                MessageBox.Show("Digite o valor de dano material ", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MskCI.Focus()
                Exit Sub
            ElseIf Not .MskCI.MaskCompleted Then
                MessageBox.Show("Digite o CI", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .MskCI.Focus()
                Exit Sub
            ElseIf .cboDnCorp.Text = "" Then
                MessageBox.Show("Digite o valor de dano corporal", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboDnCorp.Focus()
                Exit Sub
            ElseIf .cboAppMorte.Text = "" Then
                MessageBox.Show("Digite o valor de app. Morte", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboAppMorte.Focus()
                Exit Sub
            ElseIf .cboAppInval.Text = "" Then
                MessageBox.Show("Digite o valor de app. invalidez", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboAppInval.Focus()
                Exit Sub

            ElseIf .cboAss24Horas.SelectedIndex = 0 Then
                MessageBox.Show("Escolha a assistente 24 horas", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboAss24Horas.Focus()
                Exit Sub
            ElseIf .cboVidros.SelectedIndex = 0 Then
                MessageBox.Show("Escolha o vidro", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboVidros.Focus()
                Exit Sub
            ElseIf .cboCarReserv.SelectedIndex = 0 Then
                MessageBox.Show("Escolha o carro reserva", "Montagem de apolce", _
                                MessageBoxButtons.OK)
                .cboCarReserv.Focus()
                Exit Sub
                'ElseIf .MSKApolice.Text = "" Then
                '    MessageBox.Show("Digite a apolice", "Alterar Orcamento", _
                '                    MessageBoxButtons.OK)
                '   .TxtFranquia.Focus()
                '   Exit Sub
            Else
                Dim result As Integer = MessageBox.Show("Quer realmente atualizar esse orcamento?", "Sola Fide", MessageBoxButtons.YesNo)
                If result = DialogResult.Cancel Then

                ElseIf result = DialogResult.No Then

                ElseIf result = DialogResult.Yes Then

                    frmCadastrarOrcamento.Atualizar()
                    Objeto.TudoBloqueado()

                End If
            End If
        End With
    End Sub
End Class
