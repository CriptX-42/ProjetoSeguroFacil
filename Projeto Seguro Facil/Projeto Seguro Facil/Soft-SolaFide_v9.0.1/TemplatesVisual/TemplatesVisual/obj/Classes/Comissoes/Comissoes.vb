Imports MySql.Data.MySqlClient
Public Class Comissoes
    Dim Conexao As New ConexaoSolafide
    Dim nome_clienteOrc As String = ""
    Dim seguradoraOrc As String = ""
    Dim PremioOrc As String
    Dim perc_comissaoOrc As String
    Dim ParcelasOrc As String = ""
    Dim TotComiBruta As Double = 0
    Dim TotDesc As Double = 0
    Dim TotLiquido As Double = 0
    Private blnNovoItem As Boolean = True
    Dim ValorPagar As Double = 0

    Private Sub Comissoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAddComissao.Enabled = False
        mskDt_Pagamento.Text = Format(Now(), "dd/MM/yyyy")
        Dim intLinha As Integer
        With dgvComissoes
            intLinha = 0
            Try
                Conexao.conectar()
            Catch ex As Exception
                MessageBox.Show("Erro ao conectar no banco de dados", "Erro em Comissões", MessageBoxButtons.OK)
            End Try

            Dim cmdReciboSum As New MySql.Data.MySqlClient.MySqlCommand
            Dim drReciboSum As MySql.Data.MySqlClient.MySqlDataReader
            Dim strSQLSum As String = "select sum(r.comissao_bruta) as 'soma_comissao_bruta', " & _
                "sum(r.desconto) as 'soma_desconto',sum(r.liquido) as 'soma_liquido' " & _
                "from solafide_v6.tb_recibo r;"

            cmdReciboSum.Connection = Conexao.cn
            cmdReciboSum.CommandText = strSQLSum

            drReciboSum = cmdReciboSum.ExecuteReader
            While drReciboSum.Read = True
                If drReciboSum("soma_comissao_bruta").ToString() = "" Then
                    TotComiBruta = 0
                    ' MessageBox.Show("deu certo comissao Bruta")
                Else
                    TotComiBruta = CDbl(drReciboSum("soma_comissao_bruta").ToString())
                End If
                If drReciboSum("soma_desconto").ToString() = "" Then
                    TotDesc = 0
                    ' MessageBox.Show("deu certo totDesc")
                Else
                    TotDesc = CDbl(drReciboSum("soma_desconto").ToString())
                End If
                If drReciboSum("soma_liquido").ToString() = "" Then
                    TotLiquido = 0
                    ' MessageBox.Show("deu certo liquido")
                Else
                    TotLiquido = CDbl(drReciboSum("soma_liquido").ToString())
                End If
            End While
            cmdReciboSum.Connection.Close()
            cmdReciboSum = Nothing
            drReciboSum.Close()
            Try
                Conexao.conectar()
            Catch ex As Exception
                MessageBox.Show("Erro ao conectar no banco de dados", "Erro em Comissões", MessageBoxButtons.OK)
            End Try

            Dim cmdRecibo As New MySql.Data.MySqlClient.MySqlCommand
            Dim drRecibo As MySql.Data.MySqlClient.MySqlDataReader
            Dim strSQL As String = "select r.pg, r.apolice, r.nome_cliente, r.seguradora, r.parcelas," & _
                "r.Premio, r.perc_comissao,r.comissao_bruta, r.desconto," & _
            "r.liquido, r.valor_pago, " & _
                "r.valor_pagar, r.dt_pagamento from tb_recibo r;"

            cmdRecibo.Connection = Conexao.cn
            cmdRecibo.CommandText = strSQL

            drRecibo = cmdRecibo.ExecuteReader
            With dgvComissoes
                For i = 0 To .Rows.Count - 1
                    For Each row As DataGridViewRow In .Rows
                        .Rows.Remove(row)
                    Next
                Next
            End With
            While drRecibo.Read = True  '-- FAZER ENQUANTO HOUVER DADOS --'
                With dgvComissoes
                    .Rows.Add()
                    .Rows(.Rows.Count() - 1).Cells("PG").Value = _
                        drRecibo("PG").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Apolice").Value = _
                        drRecibo("apolice").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Cliente").Value = _
                        drRecibo("nome_cliente").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Seguradora").Value = _
                        drRecibo("seguradora").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Parcelas").Value = _
                        drRecibo("parcelas").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Premio").Value = _
                        drRecibo("Premio")

                    .Rows(.Rows.Count() - 1).Cells("Comissao").Value = _
                           drRecibo("perc_comissao").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Comissao_Bruta").Value = _
                            drRecibo("comissao_bruta").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Desconto").Value = _
                            drRecibo("desconto").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Comissao_Liquida").Value = _
                            drRecibo("liquido").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Valor_Pago").Value =
                        drRecibo("valor_pago").ToString()

                    .Rows(.Rows.Count() - 1).Cells("Valor_Pagar").Value =
                        drRecibo("valor_pagar").ToString()

                    .Rows(.Rows.Count() - 1).Cells("dt_Pagamento").Value =
                        drRecibo("dt_pagamento").ToString()
                End With

            End While
            cmdRecibo.Connection.Close()
            cmdRecibo = Nothing
            drRecibo.Close()


        End With


    End Sub
    Private Sub btnAddComissao_Click(sender As Object, e As EventArgs) Handles btnAddComissao.Click
        Dim ComiBruta As String = ((CDbl(perc_comissaoOrc.ToString) * CDbl(PremioOrc.ToString)) / 100).ToString
        Dim Desc As String = (((CDbl(perc_comissaoOrc.ToString) * CDbl(PremioOrc.ToString)) / 100) * 0.3).ToString
        Dim Liquido As String = (CDbl(ComiBruta.ToString) - CDbl(Desc.ToString)).ToString
        TotComiBruta = CDbl(ComiBruta.ToString) + CDbl(TotComiBruta.ToString)
        TotDesc = CDbl(TotDesc) + CDbl(Desc)
        TotLiquido = CDbl(TotLiquido) + CDbl(Liquido)
        If Val(mskDtCalc.Text.ToString) = 0 Then
            MessageBox.Show("Informe um Orçamento", "Adicionar Comissão", MessageBoxButtons.OK)
            mskDtCalc.Focus()
            Exit Sub
        ElseIf Not IsNumeric(mskApolice.Text) Then
            MessageBox.Show("numero da apólice Inválida", "Adicionar Comissão", MessageBoxButtons.OK)
            mskApolice.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtVlrPago.Text.ToString) Then
            MessageBox.Show("Valor pago Invalido", "Adicionar Comissão", MessageBoxButtons.OK)
            txtVlrPago.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtVlrPagar.Text.ToString) Then
            MessageBox.Show("Valor à pagar Invalido", "Adicionar Comissão", MessageBoxButtons.OK)
            txtVlrPagar.Focus()
            Exit Sub
        ElseIf CDbl(numParcela.Text.ToString) = 0 Then
            MessageBox.Show("Informe a parcela", "Adicionar Comissão", MessageBoxButtons.OK)
            numParcela.Focus()
            Exit Sub
        End If

        With dgvComissoes
            Dim intLinha As Integer
            Dim intPG As Integer

            If blnNovoItem Then
                .Rows.Add()
                intLinha = .Rows.Count() - 1
                intPG = .Rows.Count()
                Dim UsandoBancoRecibo As USRecibo = New USRecibo()
                Dim PbancoRecibo As Recibo
                'Usando a Classe Recibo e armazenando os dados recebidos pela form
                PbancoRecibo = New Recibo(intPG.ToString, mskApolice.Text.ToString, nome_clienteOrc.ToString,
                        seguradoraOrc.ToString, numParcela.Value.ToString, PremioOrc.ToString, perc_comissaoOrc.ToString,
                        ComiBruta.ToString, Desc.ToString, Liquido.ToString, txtVlrPago.Text.ToString,
                        txtVlrPagar.Text.ToString, mskDt_Pagamento.Text.ToString)

                'Cadastrando no Banco os dados os dados armazenados na classe Recibo
                UsandoBancoRecibo.UsandoDadosRecibo(PbancoRecibo)

                Dim UsandoBancoComissoes As USClasseComissoes = New USClasseComissoes()
                Dim PbancoComissoes As ClasseComissoes

                'Usando a Classe ClasseComissoes e armazenando os dados recebidos pela form
                PbancoComissoes = New ClasseComissoes(intPG.ToString, mskApolice.Text.ToString, nome_clienteOrc.ToString,
                        seguradoraOrc.ToString, numParcela.Value.ToString, PremioOrc.ToString, perc_comissaoOrc.ToString,
                        ComiBruta.ToString, Desc.ToString, Liquido.ToString, txtVlrPago.Text.ToString,
                        txtVlrPagar.Text.ToString, mskDt_Pagamento.Text.ToString)

                'Cadastrando no Banco os dados os dados armazenados na classe ClasseComissoes
                UsandoBancoComissoes.UsandoDadosComissoes(PbancoComissoes)

            Else
                intLinha = .CurrentRow.Index
                intPG = CInt(.CurrentRow.Cells("PG").Value)

            End If

            .Rows(intLinha).Cells("PG").Value = intPG.ToString

            .Rows(intLinha).Cells("Apolice").Value = mskApolice.Text.ToString

            .Rows(intLinha).Cells("Cliente").Value = nome_clienteOrc.ToString

            .Rows(intLinha).Cells("Seguradora").Value = seguradoraOrc.ToString

            .Rows(intLinha).Cells("Parcelas").Value = ParcelasOrc.ToString

            .Rows(intLinha).Cells("Premio").Value = PremioOrc.ToString

            .Rows(intLinha).Cells("Comissao").Value = perc_comissaoOrc.ToString

            .Rows(intLinha).Cells("Comissao_Bruta").Value = ComiBruta.ToString

            .Rows(intLinha).Cells("Desconto").Value = Desc.ToString

            .Rows(intLinha).Cells("Comissao_Liquida").Value = Liquido.ToString

            .Rows(intLinha).Cells("Valor_Pago").Value = txtVlrPago.Text.ToString

            .Rows(intLinha).Cells("Valor_Pagar").Value = txtVlrPagar.Text.ToString

            .Rows(intLinha).Cells("dt_Pagamento").Value = mskDt_Pagamento.Text.ToString

        End With
        btnLimpar_Click(sender, e)
    End Sub

    Private Sub dgvComissoes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComissoes.CellDoubleClick
        Dim ItemSel As DataGridViewRow = dgvComissoes.CurrentRow

        mskDtCalc.Text = ItemSel.Cells("PG").Value.ToString
        mskApolice.Text = ItemSel.Cells("Apolice").Value.ToString
        mskDt_Pagamento.Text = ItemSel.Cells("dt_Pagamento").Value.ToString
        txtVlrPago.Text = ItemSel.Cells("Valor_Pago").Value.ToString
        txtVlrPagar.Text = ItemSel.Cells("Valor_Pagar").Value.ToString
        numParcela.Value = CDec(ItemSel.Cells("Parcelas").Value)

        blnNovoItem = False
        btnAddComissao.Text = "Alterar Comissão"
        btnExcluirComissao.Enabled = True
        mskDtCalc.Focus()

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        mskDtCalc.Text = ""
        mskApolice.Text = ""
        txtVlrPago.Text = ""
        txtVlrPagar.Text = ""
        numParcela.Value = 0
    End Sub

    Private Sub btnExcluirComissao_Click(sender As Object, e As EventArgs) Handles btnExcluirComissao.Click
        With dgvComissoes
            .Rows.Remove(.CurrentRow)
            btnLimpar_Click(sender, e)
        End With


    End Sub

    Private Sub btnFecharComissoes_Click(sender As Object, e As EventArgs) Handles btnFecharComissoes.Click

        Dim intLinha As Integer
        Dim intPG As Integer

        With dgvComissoes
            .Rows.Add()
            intLinha = .Rows.Count() - 1
            intPG = .Rows.Count()

            .Rows(intLinha).Cells("PG").Value = intPG.ToString

            .Rows(intLinha).Cells("Apolice").Value = "".ToString

            .Rows(intLinha).Cells("Cliente").Value = "Total da Comissão:"

            .Rows(intLinha).Cells("Seguradora").Value = "".ToString

            .Rows(intLinha).Cells("Parcelas").Value = "".ToString

            .Rows(intLinha).Cells("Premio").Value = "".ToString

            .Rows(intLinha).Cells("Comissao").Value = "".ToString

            .Rows(intLinha).Cells("Comissao_Bruta").Value = TotComiBruta.ToString

            .Rows(intLinha).Cells("Desconto").Value = TotDesc.ToString

            .Rows(intLinha).Cells("Comissao_Liquida").Value = TotLiquido.ToString

            .Rows(intLinha).Cells("Valor_Pago").Value = "".ToString

            .Rows(intLinha).Cells("Valor_Pagar").Value = "".ToString

            .Rows(intLinha).Cells("dt_Pagamento").Value = "".ToString
        End With

        ' inicio do codigo para inserir os dados na tabela
        Dim intPG2 As Integer
        With dgvComissoes
            intPG2 = .Rows.Count()
            Dim UsandoBancoTotRecibo As USTotRecibo = New USTotRecibo()
            Dim PbancoTotRecibo As TotRecibo
            'Usando a Classe TotRecibo e armazenando os dados recebidos pela form
            PbancoTotRecibo = New TotRecibo(intPG2.ToString, "Total das Comissões:".ToString, TotComiBruta.ToString,
                                          TotDesc.ToString, TotLiquido.ToString)
            'Cadastrando no Banco os dados os dados armazenados na classe TotRecibo
            UsandoBancoTotRecibo.UsandoDadosTotRecibo(PbancoTotRecibo)

            Dim UsandoBancoTotComissoes As USTotClasseComissoes = New USTotClasseComissoes()
            Dim PbancoTotComissoes As TotClasseComissoes

            'Usando a Classe TotClasseComissoes e armazenando os dados recebidos pela form
            PbancoTotComissoes = New TotClasseComissoes(intPG2.ToString, "Total das Comissões:".ToString, TotComiBruta.ToString,
                                          TotDesc.ToString, TotLiquido.ToString)

            'Cadastrando no Banco os dados os dados armazenados na classe TotClasseComissoes
            UsandoBancoTotComissoes.UsandoDadosTotComissoes(PbancoTotComissoes)

        End With
        'fim do codigo para inserir os dados na tabela

        ' inicio codigo para remover as linhas da datagridview
        With dgvComissoes
            For i = 0 To .Rows.Count - 1
                For Each row As DataGridViewRow In .Rows
                    .Rows.Remove(row)
                Next
            Next
        End With
        ' fim codigo para remover as linhas da datagridview

        ' inicio do codigo para fazer o truncate na tabela recibo
        Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
        Dim conn As New MySqlConnection(myConnectionString)
        Try
            Dim strSQL As String = "truncate table tb_recibo;"
            Dim cmd As MySqlCommand = New MySqlCommand(strSQL, conn)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' fim do codigo para fazer o truncate na tabela recibo

        TotComiBruta = 0
        TotDesc = 0
        TotLiquido = 0
    End Sub

    Private Sub btnPesqOrc_Click(sender As Object, e As EventArgs) Handles btnPesqOrc.Click
        Dim objConsOrc As New Cons_Orc
        objConsOrc.ShowDialog()
        If objConsOrc.Confirm = True Then
            nome_clienteOrc = objConsOrc.nome_completoCons
            seguradoraOrc = objConsOrc.SeguradoraCons
            PremioOrc = objConsOrc.PremioCons
            perc_comissaoOrc = objConsOrc.PercComiCons
            ParcelasOrc = objConsOrc.ParcelasCons
            mskDtCalc.Text = objConsOrc.dtCalculoCons
            btnAddComissao.Enabled = True
            Dim ComiBrutaPesq As String = ((CDbl(perc_comissaoOrc.ToString) * CDbl(PremioOrc.ToString)) / 100).ToString
            Dim DescPesq As String = (((CDbl(perc_comissaoOrc.ToString) * CDbl(PremioOrc.ToString)) / 100) * 0.3).ToString
            Dim LiquidoPesq As String = (CDbl(ComiBrutaPesq.ToString) - CDbl(DescPesq.ToString)).ToString

            ValorPagar = CDbl(LiquidoPesq)
            txtVlrPagar.Text = LiquidoPesq.ToString
        End If
    End Sub

    Private Sub txtVlrPago_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVlrPago.Validating
        If (ValorPagar - CDbl(txtVlrPago.Text)) < 0 Then
            MessageBox.Show("Valor Pago é maior que o à pagar")
            txtVlrPagar.Text = ValorPagar.ToString
            txtVlrPago.Text = ""
            txtVlrPago.Focus()
            Exit Sub
        End If
        txtVlrPagar.Text = (ValorPagar - CDbl(txtVlrPago.Text)).ToString
    End Sub

    Private Sub txtVlrPago_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtVlrPago.MaskInputRejected
        If (ValorPagar - CDbl(txtVlrPago.Text)) < 0 Then
            MessageBox.Show("Valor Pago é maior que o à pagar")
            txtVlrPagar.Text = ValorPagar.ToString
            txtVlrPago.Text = ""
            txtVlrPago.Focus()
            Exit Sub
        End If
        txtVlrPagar.Text = (ValorPagar - CDbl(txtVlrPago.Text)).ToString
    End Sub
End Class