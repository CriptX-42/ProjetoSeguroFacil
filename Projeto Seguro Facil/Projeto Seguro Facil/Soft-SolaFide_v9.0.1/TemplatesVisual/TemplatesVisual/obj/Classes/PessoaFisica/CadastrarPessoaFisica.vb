Option Compare Text
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmCadPFisica

    Dim Navegacao As New Navegar
    Dim Objeto As New F_ObjetoCli
    Dim IdPessoaFisica As String
    Dim CPFPessoaFisica As String

    ' INICIO EVENTO LOAD
    Private Sub CadastrarPessoaFisica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        TudoBloqueado()
        btnPrimeiro.Enabled = False
        btnVoltar.Enabled = False
        btnProximo.Enabled = True
        btnUltimo.Enabled = True
    End Sub
    ' FIM EVENTO LOAD

    ' INICIO PESQUISA DE CEP
    Private Sub mskCEP_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskCEP.MaskInputRejected
        If mskCEP.TextLength = 9 Then
            Dim PesquisarCep As New ConsultarCEP
            PesquisarCep.Consultar()
        End If
    End Sub
    ' FIM PESQUISA DE CEP

    ' INICIO PESQUISA DE CPF
    Private Sub mskPesqCPF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskPesqCPF.KeyPress
        If mskPesqCPF.TextLength = 14 Then
            Dim ConsultarCPF As New PesquisarCPF_Consu
            ConsultarCPF.Consultar()
        End If
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True 'Para o BEEP da text
            Dim ConsultarCPF As New PesquisarCPF_Consu
            ConsultarCPF.Consultar()
        End If
    End Sub
    Private Sub picPesq_Click(sender As Object, e As EventArgs) Handles picPesq.Click
        If mskPesqCPF.TextLength = 14 Then
            Dim ConsultarCPF1 As New PesquisarCPF_Consu
            ConsultarCPF1.Consultar()
        End If
    End Sub
    ' FIM DE PESQUISA DE CPF
    '================================== INICIO EVENTOS DOS BOTÕES ==============================================

    ' INICIO DO BOTAO CADASTRAR
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Try
            Validacao()
        Catch ex As Exception
            MessageBox.Show("Erro ao Cadastrar Pessoa Física - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Física", MessageBoxButtons.OK)
        End Try
    End Sub
    ' FIM DO BOTÃO CADASTRAR

    ' INICIO BOTAO ALTERAR
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If txtNome.Enabled = False Then
            Desbloqueado()
            BtnCadastrar.Enabled = False
            BtnLimpar.Enabled = False
            btnCancelar.Visible = True
            btnImprimir.Visible = False
            btnExcluir.Enabled = False
            mskPesqCPF.Enabled = False
        ElseIf txtNome.Enabled = True Then
            ValidacaoAlterar()
        End If
    End Sub
    ' FIM BOTAO ALTERAR

    ' INICIO DO BOTAO EXCLUIR
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim result As Integer = MessageBox.Show("Deseja Realmente Excluir esse Cliente?", "Excluir Pessoa Física", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Deletar()

        End If
    End Sub
    ' FIM DO BOTAO EXCLUIR

    ' INICIO BOTAO CANCELAR
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim result As Integer = MessageBox.Show("Quer realmente cancelar?", "Seguro Fácil", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            Navegacao.MovimentarRegistros(Navegar.registros.Primeiro)
            DesbloqueiaNavegacao()
            TudoBloqueado()
        End If
    End Sub
    ' FIM BOTAO CANCELAR
    ' INICIO BOTAO IMPRIMIR
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        RelatorioPessoaFisica.Show()

    End Sub
    ' FIM BOTAO IMPRIMIR

    ' INICIO BOTAO LIMPAR
    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Novo()
        Desbloqueado()
        BloqueiaNavegacao()
    End Sub
    ' FIM BOTAO LIMPAR

    '=================================== FIM EVENTOS DOS BOTÕES ================================================

    '======================================INICIO DOS EVENTOS ==================================================

    ' INICIO EVENTO CADASTRAR
    Public Sub Cadastrar()
        Try
            'Declaração da variavel contendo os dados para conexão no banco de dados
            Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")

            'Declaração dos metodos construtores
            Dim PbancoSexo As BancoSexo
            Dim PbancoEndereco As BancoEndereco
            Dim PBancoEstadoCivil As BancoEstadoCivil
            Dim PBancoContato As BancoContato
            Dim Pbanco As BancoCliente
            Dim PItem As BancoItem

            'Declaração das classes auxiliares
            Dim UsandoBanco As USBanco = New USBanco()

            Try
                'Usando a Classe BancoCliente e armazenando os dados recebidos pela form
                Pbanco = New BancoCliente(txtNome.Text, Replace(MskCPF.Text.Replace("-", ""), ".", ""), Replace(mskRG.Text.Replace("-", ""), ".", ""), _
                                          Convert.ToDateTime(mskDataExp.Text).ToString("yyyy/MM/dd"), cboOrgExp.Text, mskCNH.Text, txtTempoHab.Text, _
                                          cboTempoHab.Text, Convert.ToDateTime(mskNascimento.Text).ToString("yyyy/MM/dd"), txtProfissao.Text, cboStatus.Text, txtComentario.Text)

                'Cadastrando no Banco os dados os dados armazenados na classe BancoCliente
                UsandoBanco.UsandoDadosClientes(Pbanco)
            Catch ex As Exception
                MessageBox.Show("Erro ao Cadastrar os Dados da Pessoa Física - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Física", MessageBoxButtons.OK)
            End Try


            'Inicio Codigo para pegar o id do ultimo cadastro em Pessoa Fisica
            Try
                ' Seleciona da  tabela "MyTable" o máximo/último ID (Identificador Único)
                Dim SQL As String = ("SELECT Max(id_Pessoa_Fisica) FROM solafide_v6.tb_pessoa_fisica;")

                ' Cria uma nova ligação à base de dados
                Dim connection As New MySqlConnection(myConnectionString)

                ' Criação do comando indicando a instrução e a ligação
                Dim command As New MySqlCommand(SQL, connection)

                ' Abre a ligação
                connection.Open()

                ' Executa o comando e guarda em “total” o último registo
                IdPessoaFisica = command.ExecuteScalar.ToString
                ' Fecha a ligação e limpa as variáveis
                connection.Close()
                connection = Nothing
                command = Nothing
            Catch ex As Exception
                MessageBox.Show("Erro no Select Max de Pessoa Física - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Física", MessageBoxButtons.OK)
            End Try
            'Fim Codigo para pegar o id do ultimo cadastro em Pessoa Fisica

            Try
                'Usando a Classe BancoSexo e armazenando os dados recebidos pela form
                PbancoSexo = New BancoSexo(cboSexo.Text, IdPessoaFisica)

                'Cadastrando no Banco os dados os dados armazenados na classe BancoSexo
                UsandoBanco.UsandoDadosBancoSexo(PbancoSexo)
            Catch ex As Exception
                MessageBox.Show("Erro ao Cadastrar o Sexo da Pessoa Física - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Física", MessageBoxButtons.OK)
            End Try

            Try
                'Usando a Classe BancoEndereco e armazenando os dados recebidos pela form
                PbancoEndereco = New BancoEndereco(txtEndereco.Text, CInt(txtNumCasa.Text), mskCEP.Text.Replace("-", ""), txtBairro.Text, txtCidade.Text, cboUf.Text,
                                                   txtComplemento.Text, txtBloco.Text, txtApto.Text, IdPessoaFisica)

                'Cadastrando no Banco os dados os dados armazenados na classe BancoEndereco
                UsandoBanco.UsandoDadosEndereco(PbancoEndereco)
            Catch ex As Exception
                MessageBox.Show("Erro ao Cadastrar o Endereço da Pessoa Física - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Física", MessageBoxButtons.OK)
            End Try

            Try
                'Usando a Classe BancoEstadoCivil e armazenando os dados recebidos pela form
                PBancoEstadoCivil = New BancoEstadoCivil(cboEstCivil.Text, IdPessoaFisica)

                'Cadastrando no Banco os dados os dados armazenados na classe BancoEstadoCivil
                UsandoBanco.UsandoDadosEstadoCivil(PBancoEstadoCivil)
            Catch ex As Exception
                MessageBox.Show("Erro ao Cadastrar o Estado Civil da Pessoa Física - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Física", MessageBoxButtons.OK)
            End Try

            Try
                'Usando a Classe BancoContato e armazenando os dados recebidos pela form
                PBancoContato = New BancoContato(Replace(Replace(mskTelResid.Text.Replace("(", ""), ")", ""), "-", ""), _
                                                 Replace(Replace(mskTelRecado.Text.Replace("(", ""), ")", ""), "-", ""), _
                                                 Replace(Replace(mskCelular.Text.Replace("(", ""), ")", ""), "-", ""), txtNextel.Text, txtEmail.Text, IdPessoaFisica)

                'Cadastrando no Banco os dados os dados armazenados na classe BancoContato
                UsandoBanco.UsandoDadosContato(PBancoContato)
            Catch ex As Exception
                MessageBox.Show("Erro ao Cadastrar o Contato da Pessoa Física - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Física", MessageBoxButtons.OK)
            End Try

            Try
                'Usando a Classe BancoItem e armazenando os dados recebidos pela form
                PItem = New BancoItem(txtItem.Text, IdPessoaFisica)

                'Cadastrando no Banco os dados os dados armazenados na classe BancoItem
                UsandoBanco.UsandoDadosItem(PItem)
            Catch ex As Exception
                MessageBox.Show("Erro ao Cadastrar o Item da Pessoa Física - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Física", MessageBoxButtons.OK)
            End Try

            MessageBox.Show("Pessoa Física Cadastrada com Sucesso!", "Cadastro de Pessoa Física", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show("Erro ao Cadastrar Pessoa Física - Erro: " & ex.Message, "Erro ao Cadastrar Pessoa Física", MessageBoxButtons.OK)
        End Try

        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.MovimentarRegistros(Navegar.registros.Ultimo)
        Navegacao.AtualizarForm()

        Dim CDiv As New VencData
        CDiv.Aniversario()
        CDiv.VencimentoApolice()


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

            Dim CMD2 As New MySqlCommand("Delete From solafide_v6.tb_Pessoa_Fisica where id_Pessoa_Fisica=" & TxtId.Text)
            CMD2.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")
            CMD2.Connection.Open()
            CMD2.ExecuteNonQuery()
            CMD2.Connection.Close()

            MessageBox.Show("Pessoa Física Excluida com Sucesso!", "Excluir Pessoa Física", MessageBoxButtons.OK)
            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.MovimentarRegistros(Navegar.registros.Ultimo)
            Navegacao.AtualizarForm()
        Catch ex As Exception
            MessageBox.Show("Erro ao Excluir Pessoa Física - Erro: " & ex.Message, "Erro ao Excluir Pessoa Física", MessageBoxButtons.OK)
        End Try

    End Sub
    ' FIM EVENTO DELETAR

    ' INICIO EVENTO ATUALIZAR
    Public Sub Atualizar()
        Try
            'Declaração da variavel contendo os dados para conexão no banco de dados
            Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=JJR; Pwd=2043;")

            'Declaração dos metodos construtores
            Dim UPSexo As UpdateSexo
            Dim UPDT_Endereco As UpdateEndereco
            Dim UPDT_EstCivil As Update_EstadoCivil
            Dim UPDT_Contato As UpdateContato
            Dim UpBanco As UpdateCliente
            Dim UpItem As UpdateItem

            'Declaração das classes auxiliares
            Dim UsandoBancoUP As UsarBancoUpdate = New UsarBancoUpdate()
            Try
                'Usando a Classe UpdateCliente e armazenando os dados recebidos pela form
                UpBanco = New UpdateCliente(txtNome.Text, Replace(MskCPF.Text.Replace("-", ""), ".", ""), Replace(mskRG.Text.Replace("-", ""), ".", ""), _
                                              Convert.ToDateTime(mskDataExp.Text).ToString("yyyy/MM/dd"), cboOrgExp.Text, mskCNH.Text, txtTempoHab.Text, _
                                              cboTempoHab.Text, Convert.ToDateTime(mskNascimento.Text).ToString("yyyy/MM/dd"), txtProfissao.Text, TxtId.Text, cboStatus.Text, txtComentario.Text)

                'Alterando o cadastro com os dados armazenados na classe UpdateCliente
                UsandoBancoUP.UpdateCliente(UpBanco)
            Catch ex As Exception
                MessageBox.Show("Erro ao Alterar os Dados da Pessoa Física - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
            End Try

            Try
                'Usando a Classe UpdateSexo e armazenando os dados recebidos pela form
                UPSexo = New UpdateSexo(cboSexo.Text, TxtId.Text)

                'Alterando o cadastro com os dados armazenados na classe UpdateSexo
                UsandoBancoUP.UpdateSexo(UPSexo)
            Catch ex As Exception
                MessageBox.Show("Erro ao Alterar o Sexo da Pessoa Física - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
            End Try

            Try
                'Usando a Classe UpdateEndereco e armazenando os dados recebidos pela form
                UPDT_Endereco = New UpdateEndereco(txtEndereco.Text, CInt(txtNumCasa.Text), mskCEP.Text.Replace("-", ""), txtBairro.Text, txtCidade.Text, _
                                                   cboUf.Text, txtComplemento.Text, txtBloco.Text, txtApto.Text, TxtId.Text)

                'Alterando o cadastro com os dados armazenados na classe UpdateEndereco
                UsandoBancoUP.UpdateEndereco(UPDT_Endereco)
            Catch ex As Exception
                MessageBox.Show("Erro ao Alterar o Endereço da Pessoa Física - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
            End Try

            Try
                'Usando a Classe Update_EstadoCivil e armazenando os dados recebidos pela form
                UPDT_EstCivil = New Update_EstadoCivil(cboEstCivil.Text, TxtId.Text)

                'Alterando o cadastro com os dados armazenados na classe Update_EstadoCivil
                UsandoBancoUP.UpdateEstadoCivil(UPDT_EstCivil)
            Catch ex As Exception
                MessageBox.Show("Erro ao Alterar o Estado Civil da Pessoa Física - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
            End Try

            Try
                'Usando a Classe UpdateContato e armazenando os dados recebidos pela form
                UPDT_Contato = New UpdateContato(Replace(Replace(mskTelResid.Text.Replace("(", ""), ")", ""), "-", ""), _
                                                 Replace(Replace(mskTelRecado.Text.Replace("(", ""), ")", ""), "-", ""), _
                                                 Replace(Replace(mskCelular.Text.Replace("(", ""), ")", ""), "-", ""), txtNextel.Text, txtEmail.Text, TxtId.Text)

                'Alterando o cadastro com os dados armazenados na classe UpdateContato
                UsandoBancoUP.UpdateContato(UPDT_Contato)
            Catch ex As Exception
                MessageBox.Show("Erro ao Alterar o Contato da Pessoa Física - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
            End Try

            Try
                'Usando a Classe UpdateItem e armazenando os dados recebidos pela form
                UpItem = New UpdateItem(txtItem.Text, TxtId.Text)

                'Alterando o cadastro com os dados armazenados na classe UpdateItem
                UsandoBancoUP.UpdateItem(UpItem)
            Catch ex As Exception
                MessageBox.Show("Erro ao Alterar o Item da Pessoa Física - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
            End Try

            MessageBox.Show("Pessoa Física Alterada com Sucesso!", "Alterar Pessoa Física", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show("Erro ao Alterar Pessoa Física - Erro: " & ex.Message, "Erro ao Alterar Pessoa Física", MessageBoxButtons.OK)
        End Try
        
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.MovimentarRegistros(Navegar.registros.Ultimo)
        Navegacao.AtualizarForm()

        Dim CDiv As New VencData
        CDiv.Aniversario()
        CDiv.VencimentoApolice()
    End Sub
    ' FIM EVENTO ATUALIZAR

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
    Private Sub BloqueiaNavegacao()
        Objeto.BloqueiaNavegacao()
    End Sub
    ' FIM EVENTO BLOQUEANAVEGACAO

    ' INICIO EVENTO DESBLOQUEIAMAVEGACAO
    Private Sub DesbloqueiaNavegacao()
        Objeto.DesbloqueiaNavegacao()
    End Sub
    ' FIM EVENTO DESBLOQUEIANAVEGACAO

    ' INICIO EVENTO VALIDACAO
    Private Sub Validacao()
        Dim Validar As New ValidacaoPFisica
        Validar.Validacao()
    End Sub
    ' FIM EVENTO VALIDACAO

    ' INICIO EVENTO VALIDACAOALTERAR
    Private Sub ValidacaoAlterar()
        Dim Validar As New ValidacaoPFisica
        Validar.ValidacaoAlterar()
    End Sub
    ' FIM EVENTO VALIDACAOALTERAR
    '======================================== FIM DOS EVENTOS ==================================================

    '=================================== INICIO NAVEGAÇÃO DOS REGISTROS ========================================
    ' INICIO BOTAO PRIMEIRO REGISTRO
    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Navegacao.MovimentarRegistros(Navegar.registros.Primeiro)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO PRIMEIRO REGISTRO

    ' INICIO BOTAO VOLTAR REGISTRO
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Navegacao.MovimentarRegistros(Navegar.registros.Anterior)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO VOLTAR REGISTRO

    ' INICIO BOTAO PROXIMO REGISTRO
    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        Navegacao.MovimentarRegistros(Navegar.registros.Proximo)
        Navegacao.AtualizarForm()
    End Sub
    'FIM BOTAO PROXIMO REGISTRO

    ' INICIO BOTAO ULTIMO REGISTRO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Navegacao.MovimentarRegistros(Navegar.registros.Ultimo)
        Navegacao.AtualizarForm()
    End Sub

    Private Sub txtNumCasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumCasa.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Nº da casa", "Cadastro de Pessoa Fisica", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtTempoHab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTempoHab.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros tempo de habilitação", "Cadastro de Pessoa Fisica", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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