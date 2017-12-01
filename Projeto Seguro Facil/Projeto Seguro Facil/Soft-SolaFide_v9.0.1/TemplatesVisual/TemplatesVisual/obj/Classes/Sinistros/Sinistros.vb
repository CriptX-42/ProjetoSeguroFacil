Imports MySql.Data.MySqlClient
Public Class Sinistros
    Dim Conexao As New ConexaoSolafide
    Dim Navegacao As New NavegacaoSinistr
    Dim Objeto As New F_ObjetoSinistr



    Public IdPessoaFisica As String = ""
    Public IdPessoaJuridica As String = ""

    Public IdSinistro As String

    Public dgvCodCli As String
    Public dgvCodCar As String

    Public Nome As String = ""
    Public IDCarro As String = ""
    Public ModeloCarro As String = ""
    Public FabriCarro As String = ""
    Public NomeJuri As String = ""
    Public IDCarroJuri As String = ""
    Public ModeloCarroJuri As String = ""
    Public FabriCarroJuri As String = ""
    Private Sub Sinistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        TudoBloqueado()
        btnPrimeiro.Enabled = False
        btnVoltar.Enabled = False
        btnIr.Enabled = True
        btnUltimo.Enabled = True

        DataGridClient()
    End Sub
    Private Sub DataGridClient()
        Dim Conexao As New ConexaoSolafide

        Conexao.conectar()

        Dim cmdProduto As New MySql.Data.MySqlClient.MySqlCommand
        Dim drProduto As MySql.Data.MySqlClient.MySqlDataReader

        Dim strSQL = "select cod_cliente, nome_cliente, tb_Dados_Veiculo_id_Dados_Veiculo, modelo, fabricante " & _
                "from tb_client_sinistro " & _
                "where tb_client_sinistro.tb_Sinistro_id_sinistro = '" & txtID.Text & "' ;"

        cmdProduto.Connection = Conexao.cn
        cmdProduto.CommandText = strSQL

        drProduto = cmdProduto.ExecuteReader
        For i = 0 To dgvCliSini.Rows.Count - 1
            For Each row As DataGridViewRow In dgvCliSini.Rows
                dgvCliSini.Rows.Remove(row)
            Next
        Next
        While drProduto.Read = True  '-- FAZER ENQUANTO HOUVER DADOS --'

            With dgvCliSini

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

    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Try
            Validacao()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar" + ex.Message)
        End Try
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If MaskedTextBox1.Enabled = False Then
            DataGridClient()
            Desbloqueado()
            BtnCadastrar.Enabled = False
            BtLimpar.Enabled = False
            btnCancelar.Visible = True
            btnExcluir.Enabled = False
        ElseIf MaskedTextBox1.Enabled = True Then
            ValidacaoAlterar()

        End If
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As Integer = MessageBox.Show("Quer realmente cancelar?", "Sola Fide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            Navegacao.MovimentarRegistros(NavegacaoSinistr.registros.Primeiro)
            DesbloqueiaNavegacao()
            TudoBloqueado()
            DataGridClient()
        End If
    End Sub

    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click

        Novo()
        Desbloqueado()
        Bloqueianavegacao()
    End Sub
    Public Sub Cadastrar()
        Dim UsarSinitro As BancoSinistro
        Dim UsandoBancoSinistro As USBancoSinistro = New USBancoSinistro()

        Dim UsarEnderecoSinitro As Endereco_Sinitr

        UsarSinitro = New BancoSinistro(TxtTipo.Text, TxtEnvolvidos.Text, MaskedTextBox1.Text, txtNumSinistro.Text, txtApolice.Text, TxtComentarios.Text)
        UsandoBancoSinistro.UsandoDadosSinistro(UsarSinitro)

        Try
            Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")

            Dim SQL As String = ("SELECT Max(id_sinistro) FROM tb_sinistro;")

            Dim connection As New MySqlConnection(myConnectionString)

            Dim command As New MySqlCommand(SQL, connection)

            connection.Open()

            IdSinistro = command.ExecuteScalar.ToString

            connection.Close()
            connection = Nothing
            command = Nothing
        Catch ex As Exception
            MsgBox("Erro no select Max de Sinistro" & ex.Message)
        End Try
        UsarEnderecoSinitro = New Endereco_Sinitr(txtEndereco.Text, txtNumCasa.Text, MaskTxtCep.Text, txtBairro.Text, txtCidade.Text, cboUf.Text, IdSinistro)
        UsandoBancoSinistro.UsandoDadosEnderecoSinistri(UsarEnderecoSinitro)

        For i = 1 To dgvCliSini.Rows.Count
            SubCadastroAux(IdSinistro, dgvCliSini.Rows(dgvCliSini.Rows.Count - 1).Cells("Codigo").Value.ToString, dgvCliSini.Rows(dgvCliSini.Rows.Count - 1).Cells("NomeCliente").Value.ToString,
                           dgvCliSini.Rows(dgvCliSini.Rows.Count - 1).Cells("CodCarro").Value.ToString, dgvCliSini.Rows(dgvCliSini.Rows.Count - 1).Cells("ModCarro").Value.ToString,
                           dgvCliSini.Rows(dgvCliSini.Rows.Count - 1).Cells("FabricanteCarro").Value.ToString)
        Next

        TudoBloqueado()
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        DataGridClient()
        Navegacao.MovimentarRegistros(NavegacaoSinistr.registros.Primeiro)

    End Sub
    Public Sub SubCadastroAux(idApolice As String, dgvCodCli As String, dgvNomeCli As String, dgvCodCarro As String, dgvModCarro As String, dgvFabCarro As String)
        Dim UsarIdSinistro As BancoClientSinistro
        Dim UsandoBancoClientSinistro As USBancoClientSinistro = New USBancoClientSinistro()

        UsarIdSinistro = New BancoClientSinistro(idSinistro, dgvCodCli, dgvNomeCli, dgvCodCarro, dgvModCarro, dgvFabCarro)
        UsandoBancoClientSinistro.UsandoClientSinistro(UsarIdSinistro)

        TudoBloqueado()
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        Navegacao.MovimentarRegistros(NavegacaoSinistr.registros.Primeiro)

    End Sub

    Public Sub Novo()
        Objeto.Novo()
    End Sub
    Private Sub Deletar()
        Try

            Dim CMD2 As New MySqlCommand("Delete From solafide_v6.tb_Sinistro where id_sinistro = " & txtID.Text)
            CMD2.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD2.Connection.Open()
            CMD2.ExecuteNonQuery()
            CMD2.Connection.Close()

            MessageBox.Show("Excluido com sucesso")

            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.MovimentarRegistros(NavegacaoSinistr.registros.Primeiro)
            Navegacao.AtualizarForm()

        Catch ex As Exception
            MsgBox("Erro ao excluir-" + ex.Message)
        End Try

    End Sub
    Public Sub Atualizar()
        Dim UsarSinitro As BancoSinistro
        Dim UsandoBancoSinistro As USBancoSinistro = New USBancoSinistro()

        UsarSinitro = New BancoSinistro(TxtTipo.Text, TxtEnvolvidos.Text, MaskedTextBox1.Text, txtNumSinistro.Text, txtApolice.Text, TxtComentarios.Text)
        UsandoBancoSinistro.UsandoDadosSinistro(UsarSinitro)

        AlterarDataGrid()

        For i = 0 To dgvCliSini.Rows.Count - 1
            SubCadastroAux(txtID.Text, dgvCliSini.Rows(i).Cells("Codigo").Value.ToString, dgvCliSini.Rows(i).Cells("NomeCliente").Value.ToString,
                           dgvCliSini.Rows(i).Cells("CodCarro").Value.ToString, dgvCliSini.Rows(i).Cells("ModCarro").Value.ToString,
                           dgvCliSini.Rows(i).Cells("FabricanteCarro").Value.ToString)
        Next

        TudoBloqueado()
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        DataGridClient()
        Navegacao.MovimentarRegistros(NavegacaoSinistr.registros.Primeiro)
    End Sub
    Private Sub AlterarDataGrid()
        Conexao.conectar()
        Dim Sql As String = "delete from solafide_v6.tb_client_sinistro where tb_Sinistro_id_sinistro = '" & txtID.Text & "';"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro deletar os dados da datagrid -" + ex.Message, "Alteração de Sinistro", _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CMD.Connection.Close()
        End Try
    End Sub
    Public Sub TudoBloqueado()
        Objeto.TudoBloqueado()
    End Sub
    Public Sub Desbloqueado()
        Objeto.Desbloqueado()
    End Sub
    Private Sub Bloqueianavegacao()
        Objeto.Bloqueanavegacao()
    End Sub
    Private Sub DesbloqueiaNavegacao()
        Objeto.DesbloqueiaNavegacao()
    End Sub
    Private Sub Validacao()
        Dim Validar As New ValidacaoSinistr
        Validar.validacao()
    End Sub
    Private Sub ValidacaoAlterar()
        Dim Validar As New ValidacaoSinistr
        Validar.ValidacaoAlterar()
    End Sub

    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Navegacao.MovimentarRegistros(NavegacaoSinistr.registros.Primeiro)
        Navegacao.AtualizarForm()



    End Sub
    ' FIM BOTAO PRIMEIRO REGISTRO

    ' INICIO BOTAO VOLTAR REGISTRO
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Navegacao.MovimentarRegistros(NavegacaoSinistr.registros.Anterior)
        Navegacao.AtualizarForm()



    End Sub
    ' FIM BOTAO VOLTAR REGISTRO

    ' INICIO BOTAO PROXIMO REGISTRO
    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        Navegacao.MovimentarRegistros(NavegacaoSinistr.registros.Proximo)
        Navegacao.AtualizarForm()



    End Sub
    'FIM BOTAO PROXIMO REGISTRO

    ' INICIO BOTAO ULTIMO REGISTRO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Navegacao.MovimentarRegistros(NavegacaoSinistr.registros.Ultimo)
        Navegacao.AtualizarForm()



    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim result As Integer = MessageBox.Show("Quer Realmente excluir esse Sinistro?", "Sola Fide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Deletar()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            TudoBloqueado()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        frmRelatSinistrovb.Show()
    End Sub

    Private Sub btnAdicionarCliente_Click(sender As Object, e As EventArgs) Handles btnAdicionarCliente.Click
        Dim objConsCli As New SlClienteVeiculo
        objConsCli.ShowDialog()

        If objConsCli.Confirm = True Then
            IdPessoaFisica = objConsCli.CodPfisica
            Nome = objConsCli.NomeComplet
            IDCarro = objConsCli.CodigoCarro.ToString
            ModeloCarro = objConsCli.ModeloCar
            FabriCarro = objConsCli.FabricanteCar

            AddClientVeiculo()
            IdPessoaJuridica = "Null"
        ElseIf objConsCli.Confirmarcao = True Then
            IdPessoaJuridica = objConsCli.CodPJuridica
            NomeJuri = objConsCli.Representante
            IDCarroJuri = objConsCli.CodVecJuri
            ModeloCarroJuri = objConsCli.ModelJuri
            FabriCarroJuri = objConsCli.FabricJuri

            AddClientJuriVeiculo()
            IdPessoaFisica = "Null"
        End If

    End Sub
    Public Sub AddClientVeiculo()
        Try
            Me.dgvCliSini.Rows.Add(IdPessoaFisica.ToString, Nome.ToString, IDCarro.ToString, ModeloCarro.ToString, FabriCarro.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub AddClientJuriVeiculo()
        Try
            Me.dgvCliSini.Rows.Add(IdPessoaJuridica.ToString, NomeJuri.ToString, IDCarroJuri.ToString, ModeloCarroJuri.ToString, FabriCarroJuri.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSubtrairCliente_Click(sender As Object, e As EventArgs) Handles btnSubtrairCliente.Click
        Dim i As Integer
        With dgvCliSini
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

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        With dgvCliSini
            For i = 0 To .Rows.Count - 1
                For Each row As DataGridViewRow In .Rows

                    .Rows.Remove(row)

                Next
            Next
        End With
        DataGridClient()
    End Sub

    Private Sub btnImprimir_Click_1(sender As Object, e As EventArgs) Handles btnImprimir.Click
        frmRelatSinistrovb.Show()
    End Sub

    Private Sub txtNumCasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumCasa.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Nº da casa", "Erro em Cadastro de Sinistro", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtNumSinistro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumSinistro.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Nº de Sinistro", "Erro em Cadastro de Sinistro", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtApolice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApolice.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Apólice ", "Erro em Cadastro de Sinistro", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class