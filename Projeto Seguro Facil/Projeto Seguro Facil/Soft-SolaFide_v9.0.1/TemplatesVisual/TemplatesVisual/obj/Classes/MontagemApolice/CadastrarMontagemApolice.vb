Imports MySql.Data.MySqlClient
Public Class frmCadastrarOrcamento
    Public IdOrcamento As String
    Dim Navegacao As New NavegarMont
    Dim Objeto As New F_ObjetoMont
    Dim Conexao As New ConexaoSolafide

    Dim FormaPagamento As String = ""

    Public CodCLi As String = ""
    Public CodCliJuri As String = ""

    Public DgvCodCli As Integer
    Public DgvCodCar As String = ""

    Public IdPessoaFisica As String = ""
    Public IdPessoaJuridica As String = ""
    Public Nome As String = ""
    Public IDCarro As String = ""
    Public ModeloCarro As String = ""
    Public FabriCarro As String = ""
    Public NomeJuri As String = ""
    Public IDCarroJuri As String = ""
    Public ModeloCarroJuri As String = ""
    Public FabriCarroJuri As String = ""

    ' INICIO EVENTO LOAD
    Private Sub CadastrarOrcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        TudoBloqueado()
        btnPrimeiro.Enabled = False
        btnVoltar.Enabled = False
        btnIr.Enabled = True
        btnUltimo.Enabled = True

        DataGridClient()
        
    End Sub
    ' FIM EVENTO LOAD
    
    Private Sub DataGridClient()

        Conexao.conectar()

        Dim cmdProduto As New MySql.Data.MySqlClient.MySqlCommand
        Dim drProduto As MySql.Data.MySqlClient.MySqlDataReader

        Dim strSQL = "select cod_cliente,nome_cliente,tb_Dados_Veiculo_id_Dados_Veiculo,modelo,fabricante " & _
            "from tb_client_montapolice where tb_MontagemApolice_id_MontagemApolice = '" & txtId.Text & "';"

        cmdProduto.Connection = Conexao.cn
        cmdProduto.CommandText = strSQL

        drProduto = cmdProduto.ExecuteReader
        With dgvCliOrc
            For i = 0 To .Rows.Count - 1
                For Each row As DataGridViewRow In .Rows
                    .Rows.Remove(row)
                Next
            Next
        End With
        While drProduto.Read = True  '-- FAZER ENQUANTO HOUVER DADOS --'

            With dgvCliOrc

                .Rows.Add()  '-- ADICIONAR NOVA LINHA EM BRANCO

                .Rows(.Rows.Count() - 1).Cells("Codigo").Value = _
                    drProduto("cod_cliente").ToString

                .Rows(.Rows.Count() - 1).Cells("NomeCliente").Value = _
                    drProduto("nome_cliente").ToString()

                .Rows(.Rows.Count() - 1).Cells("CodCarro").Value = _
                    drProduto("tb_Dados_Veiculo_id_Dados_Veiculo").ToString()

                .Rows(.Rows.Count() - 1).Cells("ModCarro").Value = _
                    drProduto("modelo").ToString()

                .Rows(.Rows.Count() - 1).Cells("FabricanteCarro").Value = _
                    drProduto("fabricante").ToString()
            End With

        End While

        cmdProduto.Connection.Close()
        drProduto.Close()
        cmdProduto = Nothing

    End Sub
    '================================== INICIO EVENTOS DOS BOTÕES ==============================================

    ' INICIO DO BOTAO CADASTRAR
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Try
            Validacao()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar Pessoa Fisica " & ex.Message)
        End Try
    End Sub
    ' FIM DO BOTÃO CADASTRAR

    ' INICIO DO BOTAO ALTERAR
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If MaskTxtDataDoCalculo.Enabled = False Then
            Desbloqueado()
            BtnCadastrar.Enabled = False
            BtLimpar.Enabled = False
            btnCancelar.Visible = True
            btnExcluir.Enabled = False
        ElseIf MaskTxtDataDoCalculo.Enabled = True Then
            ValidacaoAlterar()

        End If
    End Sub
    ' FIM DO BOTAO ALTERAR

    ' INICIO DO BOTAO CANCELAR
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As Integer = MessageBox.Show("Quer realmente cancelar?", "Sola Fide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            Navegacao.MovimentarRegistros(NavegarMont.registros.Primeiro)
            DesbloqueiaNavegacao()
            TudoBloqueado()
            DataGridClient()
        End If
    End Sub
    ' FIM DO BOTAO CANCELAR

    ' INICIO DO BOTAO EXCLUIR
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim result As Integer = MessageBox.Show("Quer Realmente excluir esse orçamento?", "Sola Fide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Deletar()
        End If
    End Sub
    ' FIM DO BOTAO EXCLUIR

    ' INICIO BOTAO IMPRIMIR
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        frmRelatMont.Show()
    End Sub
    ' FIM BOTAO IMPRIMIR

    ' INICIO DO BOTAO LIMPAR
    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        With dgvCliOrc
            For i = 0 To .Rows.Count - 1
                For Each row As DataGridViewRow In .Rows

                    .Rows.Remove(row)

                Next
            Next
        End With
        Novo()
        Desbloqueado()
        Bloqueianavegacao()
    End Sub
    ' FIM DO BOTAO LIMPAR

    '=================================== FIM EVENTOS DOS BOTÕES ================================================

    '===================================== INICIO DOS EVENTOS ==================================================

    ' INICIO EVENTO CADASTRAR
    Public Sub Cadastrar()
        Dim UsarOrcamento As BancoMontagem
        Dim UsarPagamento As BancoPagamento
        Dim UsarProponente As BancoProponente
        Dim UsandoBancoOrcamento As USBancoMontagem = New USBancoMontagem()
        Dim UsandoBancoPagamento As USBancoMontagem = New USBancoMontagem()

        UsarOrcamento = New BancoMontagem(MaskTxtDataDoCalculo.Text, MaskTxtVigenciaInicio.Text, Convert.ToDateTime(MaskTxtVigenciaFim.Text).ToString("yyyy/MM/dd"), TxtPremio.Text, TxtFranquia.Text, cboCobertura.Text, cboDnMtr.Text,
                                           cboDnCorp.Text, cboAppMorte.Text, cboAppInval.Text, cboDnMorais.Text, cboAss24Horas.Text, cboVidros.Text, cboCarReserv.Text, TxtObservacoes.Text, MskCI.Text, cboSeguradoras.Text, mskPercComissao.Text)

        UsandoBancoOrcamento.UsandoDadosBancoOrcamento(UsarOrcamento)

        'Inicio do Codigo para pegar o id do ultimo cadastro em Pessoa Fisica
        Try
            Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")

            ' Selecciona da  tabela "MyTable" o máximo/último ID (identificador único)
            Dim SQL As String = ("SELECT Max(id_MontagemApolice) FROM tb_MontagemApolice;")

            ' Cria uma nova ligação à base de dados
            Dim connection As New MySqlConnection(myConnectionString)

            ' Criação do comando indicando a instrução e a ligação
            Dim command As New MySqlCommand(SQL, connection)

            ' Abre a ligação
            connection.Open()

            ' Executa o comando e guarda em “total” o último registo
            IdOrcamento = command.ExecuteScalar.ToString


            ' Fecha a ligação e limpa as variáveis
            connection.Close()
            connection = Nothing
            command = Nothing
        Catch ex As Exception
            MsgBox("Erro no select Max de Montagem de apolice " & ex.Message)
        End Try
        'Fim do Codigo para pegar o id do ultimo cadastro em Pessoa Fisica

        UsarPagamento = New BancoPagamento(cboParcelas.Text, IdOrcamento)
        UsandoBancoPagamento.UsandoDadosBancoPagamento(UsarPagamento)
        UsarProponente = New BancoProponente(txtProponente.Text, IdOrcamento)
        UsandoBancoOrcamento.UsandoDadosBancoProponente(UsarProponente)

        For i = 1 To dgvCliOrc.Rows.Count
            SubCadastroAux(IdOrcamento, dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("Codigo").Value.ToString, dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("NomeCliente").Value.ToString,
                           dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("CodCarro").Value.ToString, dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("ModCarro").Value.ToString,
                           dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("FabricanteCarro").Value.ToString)
        Next

        TudoBloqueado()
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        DataGridClient()
        Navegacao.MovimentarRegistros(NavegarMont.registros.Primeiro)
        Dim CDiv As New VencData
        CDiv.Aniversario()
        CDiv.VencimentoApolice()

    End Sub
    Public Sub SubCadastroAux(idApolice As String, dgvCodCli As String, dgvNomeCli As String, dgvCodCarro As String, dgvModCarro As String, dgvFabCarro As String)

        Dim UsarBancoClasseApolice As BancoClasseApolice
        Dim UsandoBancoClasseApolice As USBancoClasseApolice = New USBancoClasseApolice()

        UsarBancoClasseApolice = New BancoClasseApolice(idApolice, dgvCodCli, dgvNomeCli, dgvCodCarro, dgvModCarro, dgvFabCarro)
        UsandoBancoClasseApolice.UsandoClientApolice(UsarBancoClasseApolice)

        TudoBloqueado()
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        Navegacao.MovimentarRegistros(NavegarMont.registros.Primeiro)

    End Sub


    ' FIM EVENTO CADASTRAR

    ' INICIO EVENTO NOVO
    Public Sub Novo()
        Objeto.Novo()
    End Sub
    ' FIM EVENTO NOVO

    ' INICIO EVENTO DELETAR
    Private Sub Deletar()
        Try

            Dim CMD2 As New MySqlCommand("Delete From tb_MontagemApolice where id_MontagemApolice =" & txtId.Text)
            CMD2.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD2.Connection.Open()
            CMD2.ExecuteNonQuery()
            CMD2.Connection.Close()

            MessageBox.Show("Excluido com sucesso")

            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.MovimentarRegistros(NavegarMont.registros.Primeiro)
            Navegacao.AtualizarForm()

        Catch ex As Exception
            MsgBox("Erro ao excluir-" + ex.Message)
        End Try

    End Sub
    ' FIM EVENTO DELETAR

    ' INICIO EVENTO ATUALIZAR
    Public Sub Atualizar()
        Dim UpdatePagamentoOrc As UpdatePagamentoOrc
        Dim UpdateOrcamentoOrc As UpdateOrcamentoOrc
        Dim UsandoUpdateOrcamentoOrc As USUpdateOrcamentoOrc = New USUpdateOrcamentoOrc()
        Dim UsandoUpdatePagamentoOrc As USUpdateOrcamentoOrc = New USUpdateOrcamentoOrc()

        UpdateOrcamentoOrc = New UpdateOrcamentoOrc(MaskTxtDataDoCalculo.Text, Convert.ToDateTime(MaskTxtVigenciaInicio.Text).ToString("yyyy/MM/dd"), Convert.ToDateTime(MaskTxtVigenciaFim.Text).ToString("yyyy/MM/dd"), TxtPremio.Text, TxtFranquia.Text, cboCobertura.Text, cboDnMtr.Text, cboDnCorp.Text,
                                           cboAppMorte.Text, cboAppInval.Text, cboDnMorais.Text, cboAss24Horas.Text, cboVidros.Text, cboCarReserv.Text, TxtObservacoes.Text, cboSeguradoras.Text, MskCI.Text, mskPercComissao.Text)
        UsandoUpdateOrcamentoOrc.UsandoDadosBancoOrcamento(UpdateOrcamentoOrc)
        
        UpdatePagamentoOrc = New UpdatePagamentoOrc(cboParcelas.Text)
        UsandoUpdatePagamentoOrc.UsandoDadosBancoPagamento(UpdatePagamentoOrc)

        AlterarDataGrid()

        For i = 1 To dgvCliOrc.Rows.Count
            SubCadastroAux(txtId.Text, dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("Codigo").Value.ToString, dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("NomeCliente").Value.ToString,
                           dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("CodCarro").Value.ToString, dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("ModCarro").Value.ToString,
                           dgvCliOrc.Rows(dgvCliOrc.Rows.Count - 1).Cells("FabricanteCarro").Value.ToString)
        Next

        TudoBloqueado()
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()

        Navegacao.MovimentarRegistros(NavegarMont.registros.Primeiro)

        Dim CDiv As New VencData
        CDiv.Aniversario()
        CDiv.VencimentoApolice()
    End Sub
    ' FIM EVENTO ATUALIZAR
    Private Sub AlterarDataGrid()
        Conexao.conectar()
        Dim Sql As String = "delete from solafide_v6.tb_client_montapolice where tb_MontagemApolice_id_MontagemApolice = '" & txtId.Text & "';"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro deletar os dados da datagrid -" + ex.Message, "Alteração de Montagem de Apolice", _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
    End Sub

    ' INICIO EVENTO TUDOBOQUEADO
    Public Sub TudoBloqueado()
        Objeto.TudoBloqueado()
    End Sub
    ' FIM EVENTO TUDOBLOQUEADO

    ' INICIO EVENTO DESBLOQUEADO
    Public Sub Desbloqueado()
        Objeto.Desbloqueado()
    End Sub
    ' FIM EVENTO DESBLOQUEADO

    ' INICIO EVENTO BLOQUEIANAVEACAO
    Private Sub Bloqueianavegacao()
        Objeto.BloqueiaNavegacao()
    End Sub
    ' FIM EVENTO BLOQUEIANAVEGACAO

    ' INICIO EVENTO DESBLOQUEIAMAVEGACAO
    Private Sub DesbloqueiaNavegacao()
        Objeto.DesbloqueiaNavegacao()
    End Sub
    ' FIM EVENTO DESBLOQUEIANAVEGACAO

    ' INICIO EVENTO VALIDACAO
    Private Sub Validacao()
        Dim Validar As New ValidacaoMont
        Validar.Validacao()
    End Sub
    ' FIM EVENTO VALIDACAO

    ' INICIO EVENTO VALIDACAOALTERAR
    Private Sub ValidacaoAlterar()
        Dim Validar As New ValidacaoMont
        Validar.ValidacaoAlterar()
    End Sub
    ' FIM EVENTO VALIDACAOALTERAR

    '======================================= FIM DOS EVENTOS ===================================================

    '=================================== INICIO NAVEGAÇÃO DOS REGISTROS ========================================
    ' INICIO BOTAO PRIMEIRO REGISTRO
    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Navegacao.MovimentarRegistros(NavegarMont.registros.Primeiro)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO PRIMEIRO REGISTRO

    ' INICIO BOTAO VOLTAR REGISTRO
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Navegacao.MovimentarRegistros(NavegarMont.registros.Anterior)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO VOLTAR REGISTRO

    ' INICIO BOTAO PROXIMO REGISTRO
    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        Navegacao.MovimentarRegistros(NavegarMont.registros.Proximo)
        Navegacao.AtualizarForm()
    End Sub
    'FIM BOTAO PROXIMO REGISTRO

    ' INICIO BOTAO ULTIMO REGISTRO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Navegacao.MovimentarRegistros(NavegarMont.registros.Ultimo)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO ULTIMO REGISTRO

    '===================================== FIM NAVEGAÇÃO DOS REGISTROS =========================================

    Private Sub BotaoSalvar_Click(sender As Object, e As EventArgs)
        Cadastrar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Pesquisa.Show()
    End Sub

    Private Sub btnAdicionarCliente_Click(sender As Object, e As EventArgs) Handles btnAdicionarCliente.Click
       Dim objConsCli As New SlClienteVeiculo
        objConsCli.ShowDialog()

        If objConsCli.Confirm = True Then
            IdPessoaFisica = objConsCli.CodPfisica.ToString
            Nome = objConsCli.NomeComplet
            IDCarro = objConsCli.CodigoCarro.ToString
            ModeloCarro = objConsCli.ModeloCar
            FabriCarro = objConsCli.FabricanteCar

            AddClientVeiculo()
            IdPessoaJuridica = "Null"
        ElseIf objConsCli.Confirmarcao = True Then
            IdPessoaJuridica = objConsCli.CodPJuridica.ToString
            NomeJuri = objConsCli.Representante
            IDCarroJuri = objConsCli.CodigoCarro.ToString
            ModeloCarroJuri = objConsCli.ModeloCar
            FabriCarroJuri = objConsCli.FabricanteCar

            AddClientVeiculoJuri()
            IdPessoaFisica = "Null"
        End If
    End Sub
    Public Sub AddClientVeiculo()
        Me.dgvCliOrc.Rows.Add(IdPessoaFisica.ToString, Nome.ToString, IDCarro.ToString, ModeloCarro.ToString, FabriCarro.ToString)
    End Sub
    Public Sub AddClientVeiculoJuri()
        Me.dgvCliOrc.Rows.Add(IdPessoaJuridica.ToString, NomeJuri.ToString, IDCarroJuri.ToString, ModeloCarroJuri.ToString, FabriCarroJuri.ToString)
    End Sub

    Private Sub btnSubtrairCliente_Click(sender As Object, e As EventArgs) Handles btnSubtrairCliente.Click
        Dim i As Integer
        With dgvCliOrc
            'envia mensagem perguntando se o usuário deseja excluir as linhas selecionadas
            If MsgBox("Deseja excluir as linha(s) selecionada(s)?", vbExclamation + vbYesNo, "Excluir") = vbYes Then
                For i = 0 To .Rows.Count - 1
                    For Each row As DataGridViewRow In .Rows

                        .Rows.Remove(row)

                    Next
                Next
            End If
        End With
    End Sub

    Private Sub TxtFranquia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFranquia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em franquia", "Cadastro de Orçamento", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TxtPremio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPremio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Premio", "Cadastro de Orçamento", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    

    Private Sub cboAppMorte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAppMorte.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em App. Morte", "Cadastro de Orçamento", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cboDnMtr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDnMtr.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Danos Materiais", "Cadastro de Orçamento", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cboAppInval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAppInval.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em App. Invelidez", "Cadastro de Orçamento", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cboDnCorp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDnCorp.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Danos Corporais", "Cadastro de Orçamento", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cboDnMorais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDnMorais.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Danos Morais", "Cadastro de Orçamento", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub cboFrmPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFrmPagamento.SelectedIndexChanged
        If cboFrmPagamento.Text = "Parcelado" Then
            FormaPagamento = ""
            cboParcelas.Text = "2"
            cboParcelas.Enabled = True
        Else
            FormaPagamento = ""
            FormaPagamento = "1"
            cboParcelas.Text = "1"
            cboParcelas.Enabled = False
        End If
    End Sub

    Private Sub cboFrmPagamento_TextChanged(sender As Object, e As EventArgs) Handles cboFrmPagamento.TextChanged
        If cboFrmPagamento.Text = "Parcelado" Then
            FormaPagamento = ""
            cboParcelas.Text = "2"
            cboParcelas.Enabled = True
        Else
            FormaPagamento = ""
            FormaPagamento = "1"
            cboParcelas.Text = "1"
            cboParcelas.Enabled = False
        End If
    End Sub

    Private Sub cboParcelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboParcelas.SelectedIndexChanged
        FormaPagamento = ""
        FormaPagamento = cboParcelas.Text
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

        With dgvCliOrc
            For i = 0 To .Rows.Count - 1
                For Each row As DataGridViewRow In .Rows

                    .Rows.Remove(row)

                Next
            Next
        End With
        DataGridClient()
    End Sub
    Public Sub Moeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        n = txt.Text.Replace(",", "").Replace(".", "")
        If n.Equals("") Then n = ""
        n = n.PadLeft(3, "0")
        If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length)
        txt.Text = String.Format("(0:N)", v)
        txt.SelectionStart = txt.Text.Length

    End Sub
End Class