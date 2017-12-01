Option Compare Text
Imports MySql.Data.MySqlClient

Public Class CadastrarPessoaJuridica
    Dim Navegacao As New Navegar_PJuri
    Dim Objeto As New F_Objeto_PJuri
    Dim IDPessoaJuridica As String
    Dim CNPJPessoaJuridica As String

    ' INICIO EVENTO LOAD
    Private Sub CadastrarPessoaJuridica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        Objeto.TudoBloqueado()
        btnPrimeiro.Enabled = False
        btnVoltar.Enabled = False
    End Sub
    ' FIM EVENTO LOAD

    '=================================== INICIO EVENTOS DOS BOTOES =============================================
    ' INICIO DO BOTAO CADASTRAR
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Try
            Validacao()
        Catch ex As Exception
            MessageBox.Show("Erro ao Cadastrar Pessoa Jurídica - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Jurídica", MessageBoxButtons.OK)
        End Try
    End Sub
    ' FIM DO BOTAO CADASTRAR

    ' INICIO DO BOTAO EXCLUIR
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim result As Integer = MessageBox.Show("Deseja Realmente excluir essa Empresa?", "Excluir Pessoa Jurídica", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Deletar()
        End If
    End Sub
    ' FIM DO BOTAO EXCLUIR

    ' INICIO DO BOTAO ALTERAR
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        If TxtNFantasia.Enabled = False Then
            Desbloqueado()
            BtnCadastrar.Enabled = False
            BtLimpar.Enabled = False
            btnCancelar.Visible = True
            btnExcluir.Enabled = False

        ElseIf TxtNFantasia.Enabled = True Then
            ValidacaoAlterar()
        End If
    End Sub
    ' FIM DO BOTAO ALTERAR

    ' INICIO DO BOTAO CANCELAR
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As Integer = MessageBox.Show("Deseja Realmente Cancelar Essa Alteração/Cadastro em Pessoa Jurídica?", "Cancelar Alteração/Cadastro de Pessoa Jurídica", MessageBoxButtons.YesNo)
        If btnAlterar.Enabled = True Then
            result = MessageBox.Show("Deseja Realmente Cancelar Essa Alteração em Pessoa Jurídica?", "Cancelar Alteração em Pessoa Jurídica", MessageBoxButtons.YesNo)
        End If
        If BtnCadastrar.Enabled = True Then
            result = MessageBox.Show("Deseja Realmente Cancelar Esse Cadastro em Pessoa Jurídica?", "Cancelar Cadastro de Pessoa Jurídica", MessageBoxButtons.YesNo)
        End If

        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            Navegacao.MovimentarRegistros(Navegar_PJuri.registros.Primeiro)
            Objeto.DesbloqueiaNavegacao()
            Objeto.TudoBloqueado()
        End If
    End Sub
    ' FIM DO BOTAO CANCELAR

    ' INICIO DO BOTAO IMPRIMIR

    ' FIM DO BOTAO IMPRIMIR

    ' INICIO DO BOTAO LIMPAR
    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        Objeto.Novo()
        Objeto.Desbloqueado()
        Objeto.Bloqueanavegacao()
        txtRSocial.Focus()
    End Sub
    ' FIM DO BOTAO LIMPAR


    '===================================== FIM EVENTOS DOS BOTOES ==============================================

    '====================================== INICIO DOS EVENTOS =================================================
    ' INICIO DO EVENTO CADASTRAR
    Public Sub Cadastrar()
        Try

            'Declaração da variavel contendo os dados para conexão no banco de dados
            Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")

            'Declaração dos metodos construtores
            Dim UsaPessoaJuri As BancoPessoaJuri
            Dim UsaEnderecoJuri As BancoEnderecoJuri
            Dim UsaContatoJuri As BancoContatoJuri
            Dim UsaItem As BancoItemJuri

            'Declaração das classes auxiliares
            Dim UsPessoaJuri As USBancoJuridico = New USBancoJuridico()
            Dim UsEnderecoJuri As USBancoJuridico = New USBancoJuridico()
            Dim UsContatoJuri As USBancoJuridico = New USBancoJuridico()
            Dim UsItem As USBancoJuridico = New USBancoJuridico()

            Try
                'Usando a Classe BancoPessoaJuri e armazenando os dados recebidos pela form
                UsaPessoaJuri = New BancoPessoaJuri(txtRSocial.Text, TxtNFantasia.Text, txtRepresent.Text, MaskTxtCnpj.Text, txtAreaAtuacao.Text, txtSite.Text, TxtComentarios.Text, cboStatus.Text)
                'Cadastrando no Banco os dados os dados armazenados na classe BancoPessoaJuri
                UsPessoaJuri.USBancoPesJuridica(UsaPessoaJuri)
            Catch ex As Exception
                MsgBox("Erro ao Cadastrar os Dados da Pessoa Juridica = " & ex.Message)
            End Try

            'Inicio do codigo para pegar o id do ultimo cadastro em Pessoa Juridica
            Try
                ' Selecciona da  tabela "MyTable" o máximo/último ID (identificador único)
                Dim SQL As String = ("SELECT Max(id_Pessoa_Juridica) FROM solafide_v6.tb_pessoa_juridica;")
                ' Cria uma nova ligação à base de dados
                Dim connection As New MySqlConnection(myConnectionString)
                ' Criação do comando indicando a instrução e a ligação
                Dim command As New MySqlCommand(SQL, connection)
                ' Abre a ligação
                connection.Open()
                ' Executa o comando e guarda em “total” o último registo
                IDPessoaJuridica = command.ExecuteScalar.ToString
                ' Fecha a ligação e limpa as variáveis
                connection.Close()
                connection = Nothing
                command = Nothing
            Catch ex As Exception
                MsgBox("Erro no Select Max Pessoa Juridica" & ex.Message)
            End Try
            'Fim do codigo para pegar o id do ultimo cadastro em Pessoa Juridica

            Try
                'Usando a Classe BancoEnderecoJuri e armazenando os dados recebidos pela form
                UsaEnderecoJuri = New BancoEnderecoJuri(txtEndereco.Text, CInt(txtNumero.Text), MaskTxtCep.Text, txtBairro.Text, txtCidade.Text, cboUf.Text, txtBloco.Text, txtComplemento.Text, IDPessoaJuridica, txtApto.Text)
                'Cadastrando no Banco os dados os dados armazenados na classe BancoEnderecoJuri
                UsEnderecoJuri.USBancoEndJuridico(UsaEnderecoJuri)
            Catch ex As Exception
                MsgBox("Erro ao Cadastrar o Endereço da Pessoa Juridica = " & ex.Message)
            End Try

            Try
                'Usando a Classe BancoContatoJuri e armazenando os dados recebidos pela form
                UsaContatoJuri = New BancoContatoJuri(MaskTxtTelefone1.Text, mskCelular.Text, txtEmail.Text, IDPessoaJuridica)
                'Cadastrando no Banco os dados os dados armazenados na classe BancoContatoJuri
                UsContatoJuri.USBancoContatoJuri(UsaContatoJuri)
            Catch ex As Exception
                MsgBox("Erro ao Cadastrar o Contato da Pessoa Juridica = " & ex.Message)
            End Try

            Try
                'Usando a Classe BancoItemJuri e armazenando os dados recebidos pela form
                UsaItem = New BancoItemJuri(txtItem.Text, IDPessoaJuridica)
                'Cadastrando no Banco os dados os dados armazenados na classe BancoItemJuri
                UsItem.UsandoDadosItemJuridico(UsaItem)
            Catch ex As Exception
                MsgBox("Erro ao Cadastrar o Item da Pessoa Juridica = " & ex.Message)
            End Try

            MessageBox.Show("Pessoa jurídica Cadastrada Com Sucesso!", "Cadastrar Pessoa Jurídica", MessageBoxButtons.OK)
            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            Objeto.TudoBloqueado()
            Navegacao.MovimentarRegistros(Navegar_PJuri.registros.Primeiro)

        Catch ex As Exception
            MsgBox("Erro ao Cadastrar Pessoa Juridica - Erro: " & ex.Message)
        End Try

    End Sub
    ' FIM DO EVENTO CADASTRAR

    ' INICIO EVENTO NOVO
    Public Sub Novo()
        Me.Objeto.Novo()
    End Sub
    ' FIM EVENTO NOVO

    ' INICIO DO EVENTO DELETAR
    Private Sub Deletar()
        Try

            Dim CMD2 As New MySqlCommand("Delete From solafide_v6.tb_pessoa_juridica where id_Pessoa_Juridica=" & txtId.Text)
            CMD2.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
            CMD2.Connection.Open()
            CMD2.ExecuteNonQuery()
            CMD2.Connection.Close()

            MessageBox.Show("Empresa Excluida com sucesso!", "Excluir Pessoa Jurídica", MessageBoxButtons.OK)
            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.MovimentarRegistros(Navegar_PJuri.registros.Primeiro)
            Navegacao.AtualizarForm()
        Catch ex As Exception
            MsgBox("Erro ao Excluir Pessoa Jurídica - Erro: " & ex.Message)
        End Try
    End Sub
    ' FIM DO EVENTO DELETAR

    ' INICIO BOTAO ATUALIZAR
    Public Sub Atualizar()

        'Declaração de variaveis
        Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")

        Dim UpBancoJuri As UpdatePessoaJuri
        Dim UpEnderecoJuri As UpdateEnderecoJuri
        Dim UpContatoJuri As UpdateContatoJuri
        Dim UsPessoaJuri As USBancoUpdateJuri = New USBancoUpdateJuri()
        Dim UsEnderecoJuri As USBancoUpdateJuri = New USBancoUpdateJuri()
        Dim UsContatoJuri As USBancoUpdateJuri = New USBancoUpdateJuri()


        UpBancoJuri = New UpdatePessoaJuri(txtRSocial.Text, TxtNFantasia.Text, txtRepresent.Text, MaskTxtCnpj.Text, txtAreaAtuacao.Text, txtSite.Text, TxtComentarios.Text, cboStatus.Text, txtId.Text)

        UsPessoaJuri.USBancoPesJuridica(UpBancoJuri)

        'Usando a Classe UpEnderecoJuri e armazenando os dados recebidos pela form  
        UpEnderecoJuri = New UpdateEnderecoJuri(txtEndereco.Text, txtNumero.Text, MaskTxtCep.Text, txtBairro.Text, txtCidade.Text, cboUf.Text, txtBloco.Text, txtComplemento.Text, txtId.Text, txtApto.Text)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoEnderecoJuri
        UsEnderecoJuri.USBancoEndJuridico(UpEnderecoJuri)

        'Usando a Classe BancoContatoJuri e armazenando os dados recebidos pela form
        UpContatoJuri = New UpdateContatoJuri(MaskTxtTelefone1.Text, mskCelular.Text, txtEmail.Text, txtId.Text)
        'Cadastrando no Banco os dados os dados armazenados na classe BancoContatoJuri
        UsContatoJuri.USBancoContatoJuri(UpContatoJuri)

        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        Objeto.TudoBloqueado()
        Navegacao.MovimentarRegistros(Navegar_PJuri.registros.Primeiro)

    End Sub
    ' FIM BOTAO ATUALIZAR

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

    ' INICIO DO EVENTO VALIDACAO
    Private Sub Validacao()
        Dim Validar As New ValidacaoPJuridica
        Validar.Validacao()
    End Sub
    ' FIM DO EVENTO VALIDACAO

    ' INICIO DO EVENTO VALIDACAO ALTERAR
    Private Sub ValidacaoAlterar()
        Dim Validar As New ValidacaoPJuridica
        Validar.ValidacaoAlterar()
    End Sub
    ' FIM DO EVENTO VALIDACAO ALTERAR

    

    '======================================= FIM DOS EVENTOS ===================================================

    '================================= INICIO NAVEGAÇÃO DOS REGISTROS ==========================================

    ' INICIO BOTAO PRIMEIRO REGISTRO
    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Navegacao.MovimentarRegistros(Navegar_PJuri.registros.Primeiro)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO PRIMEIRO REGISTRO

    ' INICIO BOTAO VOLTAR REGISTRO
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Navegacao.MovimentarRegistros(Navegar_PJuri.registros.Anterior)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO VOLTAR REGISTRO

    ' INICIO BOTAO PROXIMO REGISTRO
    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        Navegacao.MovimentarRegistros(Navegar_PJuri.registros.Proximo)
        Navegacao.AtualizarForm()
    End Sub
    'FIM BOTAO PROXIMO REGISTRO

    ' INICIO BOTAO ULTIMO REGISTRO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Navegacao.MovimentarRegistros(Navegar_PJuri.registros.Ultimo)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO ULTIMO REGISTRO

    '====================================== FIM NAVEGAÇÃO DOS REGISTROS=========================================

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        RelatPJuridico.Show()
    End Sub

    Private Sub MaskTxtCep_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskTxtCep.MaskInputRejected
        If MaskTxtCep.TextLength = 9 Then
            Dim ConsultaCEP As New ConsultaPsJuridicaCEP
            ConsultaCEP.Consultar()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim ConsultaCEP As New ConsultaPsJuridicaCEP
        ConsultaCEP.Consultar()
    End Sub
End Class