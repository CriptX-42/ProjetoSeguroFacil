Imports MySql.Data.MySqlClient
Public Class CadastrarSeguradora
    Dim Navegacao As New NavegarSeg
    Dim Objeto As New F_ObjetoSeg
    'Dim Objeto As New 
    Public IdSeguradora As String
    ' INICIO DO EVENTO LOAD
    Private Sub CadastrarSeguradora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TudoBloqueado()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()

        btnPrimeiro.Enabled = False
        btnVoltar.Enabled = False
        btnIr.Enabled = True
        btnUltimo.Enabled = True
    End Sub
    ' FIM DO EVENTO LOAD

    '================================== INICIO EVENTOS DOS BOTÕES ==============================================

    ' INICIO DO BOTAO CADASTRAR
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Try
            Validacao()
        Catch ex As Exception
            MsgBox("Erro na validação da seguradora - " & ex.Message)
        End Try

    End Sub
    ' INICIO DO BOTAO CADASTRAR

    ' INICIO DO BOTAO EXCLUIR
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim result As Integer = MessageBox.Show("Quer Realmente excluir essa Seguradora ? ", "Sola Fide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Deletar()
        End If
    End Sub
    ' FIM DO BOTAO EXCLUIR

    ' INICIO BOTAO ALTERAR
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If txtNome.Enabled = False Then
            Desbloqueado()
            BtnCadastrar.Enabled = False
            BtLimpar.Enabled = False
            btnCancelar.Visible = True
            btnExcluir.Enabled = False
        ElseIf txtNome.Enabled = True Then
            ValidacaoAlterar()

        End If
    End Sub
    ' FIM BOTAO ALTERAR

    ' INICIO DO BOTAO LIMPAR
    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        Novo()
        Desbloqueado()
        Bloqueanavegacao()
    End Sub
    ' FIM DO BOTAO LIMPAR

    ' INICIO DO BOTAO CANCELAR
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim result As Integer = MessageBox.Show("Quer realmente cancelar?", "Sola Fide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            Navegacao.MovimentarRegistros(NavegarSeg.registros.Primeiro)
            DesbloqueiaNavegacao()
            TudoBloqueado()
        End If
    End Sub
    ' FIM DO BOTAO CANCELAR



    '=================================== FIM EVENTOS DOS BOTÕES ================================================
    '======================================INICIO DOS EVENTOS ==================================================
    ' INICIO EVENTO CADASTRAR
    Public Sub Cadastrar()

        'Decracação de Variaveis
        Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")

        Dim BancoSeguradora As BancoSeguradora
        Dim BancoContatoSeg As BancoContatoSeg
        Dim UsaBancoSeguradora As USBancoSeguradora = New USBancoSeguradora()
        Dim UsaBancoContatoSeg As USBancoSeguradora = New USBancoSeguradora()

        'Usando a Classe BancoSeguradora e armazenando os dados recebidos pela form
        BancoSeguradora = New BancoSeguradora(txtNome.Text, txtSiteAreaCorretor.Text, txtSite.Text, txtComentarios.Text)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoSeguradora
        UsaBancoSeguradora.UsarBancoSeguradora(BancoSeguradora)

        'Inicio do codigo para pegar o id do ultimo cadastro em Seguradora
        Try
            ' Selecciona da  tabela "MyTable" o máximo/último ID (identificador único)
            Dim SQL As String = ("SELECT Max(id_seguradora) FROM solafide_v6.tb_seguradora;")

            ' Cria uma nova ligação à base de dados
            Dim connection As New MySqlConnection(myConnectionString)

            ' Criação do comando indicando a instrução e a ligação
            Dim command As New MySqlCommand(SQL, connection)

            ' Abre a ligação
            connection.Open()

            ' Executa o comando e guarda em “total” o último registo
            IdSeguradora = command.ExecuteScalar.ToString
            ' Fecha a ligação e limpa as variáveis
            connection.Close()
            connection = Nothing
            command = Nothing
        Catch ex As Exception
            MsgBox("Erro no select Max Seguradora - " & ex.Message)
        End Try
        'Fim do codigo para pegar o id do ultimo cadastro em Seguradora

        'Usando a Classe BancoContatoSeg e armazenando os dados recebidos pela form
        BancoContatoSeg = New BancoContatoSeg(MaskTxtTelefone1.Text, MaskTxtTelefone2.Text, txtNextel.Text, txtEmail.Text, IdSeguradora)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoContatoSeg
        UsaBancoContatoSeg.UsarBancoContato(BancoContatoSeg)

        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        Navegacao.MovimentarRegistros(NavegarSeg.registros.Primeiro)

    End Sub
    ' FIM EVENTO CADASTRAR

    ' INICIO EVENTO DELETAR
    Private Sub Deletar()
        Dim CMD2 As New MySqlCommand("Delete From tb_seguradora where id_seguradora=" & txtId.Text)
        Try


            CMD2.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD2.Connection.Open()
            CMD2.ExecuteNonQuery()


            Novo()
            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.MovimentarRegistros(NavegarSeg.registros.Primeiro)
            Navegacao.AtualizarForm()


        Catch ex As Exception
            MsgBox("Erro ao excluir Seguradora - " + ex.Message)
        Finally
            CMD2.Connection.Close()
        End Try

    End Sub
    ' FIM EVENTO DELETAR

    ' INICIO EVENTO ATULIZAR
    Public Sub Atualizar()
        'Decracação de Variaveis

        Dim UpdateSeguradora As UpdateSeguradora
        Dim UpdateContatoSeg As UpdateContatoSeg
        Dim UsaUpdateSeguradora As USUpdateSeguradora = New USUpdateSeguradora()
        Dim UsaUpdateContatoSeg As USUpdateSeguradora = New USUpdateSeguradora()

        'Usando a Classe BancoSeguradora e armazenando os dados recebidos pela form
        UpdateSeguradora = New UpdateSeguradora(txtNome.Text, txtSiteAreaCorretor.Text, txtSite.Text, txtComentarios.Text)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoSeguradora
        UsaUpdateSeguradora.UsarUpdateSeguradora(UpdateSeguradora)

        'Usando a Classe BancoContatoSeg e armazenando os dados recebidos pela form
        UpdateContatoSeg = New UpdateContatoSeg(MaskTxtTelefone1.Text, MaskTxtTelefone2.Text, txtNextel.Text, txtEmail.Text)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoContatoSeg
        UsaUpdateContatoSeg.UsarUpdateContato(UpdateContatoSeg)


        Navegacao.MovimentarRegistros(NavegarSeg.registros.Primeiro)
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
    End Sub
    ' FIM EVENTO ATUALIZAR

    ' INICIO EVENTO NOVO
    Public Sub Novo()
        Objeto.Novo()
    End Sub
    ' FIM EVENTO NOVO

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

    ' INICIO EVENTO BLOQUEANAVEACAO
    Private Sub Bloqueanavegacao()
        Objeto.Bloqueanavegacao()
    End Sub
    ' FIM EVENTO BLOQUEANAVEGACAO

    ' INICIO EVENTO DESBLOQUEIAMAVEGACAO
    Private Sub DesbloqueiaNavegacao()
        Objeto.DesbloqueiaNavegacao()
    End Sub
    ' FIM EVENTO DESBLOQUEIANAVEGACAO

    ' INICIO EVENTO VALIDACAO
    Private Sub Validacao()
        Dim Validar As New ValidacaoSeg
        Validar.Validacao()
    End Sub
    ' FIM EVENTO VALIDACAO

    ' INICIO EVENTO VALIDACAO ALTERAR
    Private Sub ValidacaoAlterar()
        Dim Validar As New ValidacaoSeg
        Validar.ValidacaoAlterar()
    End Sub
    ' FIM EVENTO VALIDACAO ALTERAR


    '======================================== FIM DOS EVENTOS ==================================================

    '=================================== INICIO NAVEGAÇÃO DOS REGISTROS ========================================
    ' INICIO BOTAO PRIMEIRO REGISTRO
    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Navegacao.MovimentarRegistros(NavegarSeg.registros.Primeiro)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO PRIMEIRO REGISTRO

    ' INICIO BOTAO VOLTAR REGISTRO
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Navegacao.MovimentarRegistros(NavegarSeg.registros.Anterior)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO VOLTAR REGISTRO

    ' INICIO BOTAO PROXIMO REGISTRO
    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        Navegacao.MovimentarRegistros(NavegarSeg.registros.Proximo)
        Navegacao.AtualizarForm()
    End Sub
    'FIM BOTAO PROXIMO REGISTRO

    ' INICIO BOTAO ULTIMO REGISTRO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Navegacao.MovimentarRegistros(NavegarSeg.registros.Ultimo)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO ULTIMO REGISTRO
    '===================================== FIM NAVEGAÇÃO DOS REGISTROS =========================================



    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        RelatorioSeguradoras.Show()
    End Sub

    Private Sub txtNextel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNextel.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Nextel ", "Cadastro de Seguradora", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            e.Handled = False
        End If
    End Sub
End Class