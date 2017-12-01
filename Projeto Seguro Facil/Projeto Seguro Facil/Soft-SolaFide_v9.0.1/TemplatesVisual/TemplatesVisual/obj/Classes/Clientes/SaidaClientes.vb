Imports MySql.Data.MySqlClient
Public Class SaidaClientes
    Dim StrItemPesquisa As String
    Dim StrItemPesquisaJuri As String
    Dim Linhas As Integer
    Dim LinhasJuridica As Integer
    Dim CorStatus As New CorStatus

    Private Sub SaidaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox1.SelectedIndex = 0 Then
            StrItemPesquisa = "Nome_Completo"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            StrItemPesquisa = "cpf"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            StrItemPesquisa = "dt_nascimento"
        End If

        If CmbPorJurid.SelectedIndex = 0 Then
            StrItemPesquisaJuri = "razao_social"
        ElseIf CmbPorJurid.SelectedIndex = 1 Then
            StrItemPesquisaJuri = "nome_fantasia"
        ElseIf CmbPorJurid.SelectedIndex = 2 Then
            StrItemPesquisaJuri = "cnpj"
        End If

        Pesquisar()
        PesquisaJuridica()
        CorStatus.CorStatusCli()
        PesquisaSeguradora()
        PesquisaSinistros()
        PesquisaMontagemApolice()
        PesquisaComissoes()

        LinhasJuridica = DgvPessoaJuridica.Rows.Count - 1
        TotalJurid.Text = LinhasJuridica.ToString
        Linhas = DgvCli.Rows.Count - 1
        txtTotalizador.Text = Linhas.ToString

    End Sub
    Private Sub Pesquisar()

        Try

            Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
            Dim conn As New MySqlConnection(Conectando)
            Dim OledbConnection As New MySqlConnection(Conectando)
            Dim adaptadorTabela As New DataTable
            Dim Adaptador2 As New MySqlDataAdapter("SELECT id_Pessoa_Fisica, nome_completo, cpf, rg, status From tb_pessoa_Fisica where " & StrItemPesquisa & " Like '%" & txtPesquisaFisica.Text & "%'", conn)

            Adaptador2.Fill(adaptadorTabela)
            DgvCli.DataSource = adaptadorTabela

            CorStatus.CorStatusCli()
            conn.Close()
        Catch ex As Exception
            MsgBox("Erro no data grid pesquisar-: " & ex.Message)
        End Try
    End Sub
    Private Sub PesquisaJuridica()
        Try

            Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
            Dim conn As New MySqlConnection(Conectando)
            Dim OledbConnection As New MySqlConnection(Conectando)
            Dim adaptadorTabela1 As New DataTable
            Dim Adaptador3 As New MySqlDataAdapter("SELECT solafide_v6.tb_pessoa_juridica.id_Pessoa_Juridica'Id'," & _
            "solafide_v6.tb_pessoa_juridica.nome_fantasia'Nome Fantasia', solafide_v6.tb_pessoa_juridica.area_Atuacao 'Área de atuação',solafide_v6.tb_pessoa_juridica.status 'Status' " & _
            " FROM tb_pessoa_juridica " & _
            "INNER JOIN tb_contato_profissional ON tb_pessoa_juridica.id_pessoa_juridica = tb_contato_profissional.tb_pessoa_juridica_id_pessoa_juridica " & _
            "INNER JOIN tb_endereco On tb_pessoa_juridica.id_pessoa_juridica=tb_endereco.tb_pessoa_juridica_id_pessoa_juridica where " & StrItemPesquisaJuri & " Like '%" & PsqJuridica.Text & "%'", conn)


            Adaptador3.Fill(adaptadorTabela1)
            DgvPessoaJuridica.DataSource = adaptadorTabela1

        Catch ex As Exception
            MsgBox("Erro no data grid PesquisaJuridica-: " & ex.Message)
        End Try
    End Sub
    Private Sub PesquisaSeguradora()
        Try

            Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
            Dim conn As New MySqlConnection(Conectando)
            Dim OledbConnection As New MySqlConnection(Conectando)
            Dim adaptadorTabela1 As New DataTable
            Dim Adaptador3 As New MySqlDataAdapter("Select id_seguradora,nome_seguradora,site_principal From tb_seguradora where tb_seguradora.nome_seguradora  Like '%" & txtSinistro.Text & "%'", conn)


            Adaptador3.Fill(adaptadorTabela1)
            DgvSinitr.DataSource = adaptadorTabela1

        Catch ex As Exception
            MsgBox("Erro no data grid PesquisaSeguradora-: " & ex.Message)
        End Try
    End Sub
    Private Sub PesquisaSinistros()

        Try

            Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
            Dim conn As New MySqlConnection(Conectando)
            Dim OledbConnection As New MySqlConnection(Conectando)
            Dim adaptadorTabela1 As New DataTable
            Dim Adaptador3 As New MySqlDataAdapter("Select id_sinistro,nome_cliente,sinistro_ocorrido,dt_sinistro From solafide_v6.tb_client_sinistro " & _
                        "Inner Join solafide_v6.tb_sinistro on solafide_v6.tb_sinistro.id_sinistro = solafide_v6.tb_client_sinistro.tb_Sinistro_id_sinistro " & _
                        "where solafide_v6.tb_client_sinistro.nome_cliente Like '%" & txtSinistros.Text & "%';", conn)


            Adaptador3.Fill(adaptadorTabela1)
            DgvSinistros.DataSource = adaptadorTabela1

        Catch ex As Exception
            MsgBox("Erro no data grid PesquisaSinistros-: " & ex.Message)
        End Try

    End Sub
    Private Sub PesquisaMontagemApolice()
        Try

            Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
            Dim conn As New MySqlConnection(Conectando)
            Dim OledbConnection As New MySqlConnection(Conectando)
            Dim adaptadorTabela1 As New DataTable
            Dim Adaptador3 As New MySqlDataAdapter("Select id_MontagemApolice,nome_cliente,dt_calculo,dt_inicio,dt_fim from tb_client_montapolice " & _
                                                   "Inner Join tb_montagemapolice on tb_montagemapolice.id_MontagemApolice = tb_client_montapolice.tb_MontagemApolice_id_MontagemApolice " & _
            "where tb_client_montapolice.nome_cliente like '%" & TxtMontApolice.Text & "%';", conn)


            Adaptador3.Fill(adaptadorTabela1)
            DgvMontApolice.DataSource = adaptadorTabela1

        Catch ex As Exception
            MsgBox("Erro no data grid PesquisaMontagemApolice-: " & ex.Message)
        End Try
    End Sub
    Private Sub PesquisaComissoes()
        Try

            Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
            Dim conn As New MySqlConnection(Conectando)
            Dim OledbConnection As New MySqlConnection(Conectando)
            Dim adaptadorTabela1 As New DataTable
            Dim Adaptador3 As New MySqlDataAdapter("Select id_Comissoes,nome_cliente,perc_comissao,comissao_bruta,valor_pago,dt_pagamento from solafide_v6.tb_comissoes where tb_comissoes.nome_cliente like '%" & txtComissoes.Text & "%';", conn)


            Adaptador3.Fill(adaptadorTabela1)
            dgvComissoes.DataSource = adaptadorTabela1

        Catch ex As Exception
            MsgBox("Erro no data grid PesquisaComissoes-: " & ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisaFisica.TextChanged
        Pesquisar()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ComboBox1.SelectedIndex = 0 Then
            StrItemPesquisa = "Nome_Completo"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            StrItemPesquisa = "cpf"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            StrItemPesquisa = "dt_nascimento"
        End If

        If CmbPorJurid.SelectedIndex = 0 Then
            StrItemPesquisaJuri = "razao_social"
        ElseIf CmbPorJurid.SelectedIndex = 1 Then
            StrItemPesquisaJuri = "nome_fantasia"
        ElseIf CmbPorJurid.SelectedIndex = 2 Then
            StrItemPesquisaJuri = "cnpj"
        End If
        CorStatus.CorStatusCli()
        CorStatus.CorStatusCliJurid()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        RelatorioClientes.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        RelatorioClientes.Show()
        Me.Cursor = Cursors.Default
    End Sub

   
    
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        RelatorioJuridico.ShowDialog()
    End Sub

    Private Sub PsqJuridica_TextChanged(sender As Object, e As EventArgs) Handles PsqJuridica.TextChanged
        PesquisaJuridica()
    End Sub

    Private Sub btnImprimir_Click_1(sender As Object, e As EventArgs) Handles btnImprimir.Click
        RelatorioClientes.Show()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        RelatorioJuridico.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        RelatSedurad.Show()
    End Sub

    
    Private Sub ToolStrip5_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip5.ItemClicked
        RetSinistr.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        RelatOrc.Show()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        If RadioButton1.Checked Then
            RecibRelatorio.Show()
        ElseIf RadioButton2.Checked Then
            RetComiss.Show()
        End If

    End Sub

    Private Sub txtSinistro_TextChanged(sender As Object, e As EventArgs) Handles txtSinistro.TextChanged
        PesquisaSeguradora()
    End Sub

    Private Sub txtSinistros_TextChanged(sender As Object, e As EventArgs) Handles txtSinistros.TextChanged
        PesquisaSinistros()
    End Sub

    Private Sub TxtMontApolice_TextChanged(sender As Object, e As EventArgs) Handles TxtMontApolice.TextChanged
        PesquisaMontagemApolice()
    End Sub

    Private Sub txtComissoes_TextChanged(sender As Object, e As EventArgs) Handles txtComissoes.TextChanged
        PesquisaComissoes()
    End Sub
End Class