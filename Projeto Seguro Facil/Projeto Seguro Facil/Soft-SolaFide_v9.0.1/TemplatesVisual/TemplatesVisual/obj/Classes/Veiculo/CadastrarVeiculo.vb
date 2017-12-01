Imports MySql.Data.MySqlClient
Public Class frmDadosVeiculo
    Dim Navegacao As New NavegarVeiculo

    Dim Objeto As New F_ObjetoQuest

    Dim Conexao As New ConexaoSolafide
    Public IDVeiculo As String
    Public IDQuestoes As String
    Public IDPessoaFisica As String = ""
    Public IDPessoaJuridica As String = ""
    Public IDSegundoCondutor As String
    Public txtIdQuestoes As String



    Public Sub Cadastrar()

        Try
            Dim UsarQuestionario As Questoes
            Dim UsarVeiculo As Veiculo
            Dim UsarGaragem As Garagem
            Dim UsarFilhoA17 As Filho_Ent_At17
            Dim UsarPrincCondutor As PrincCondutor
            Dim UsarSegCondt As SegundCondutor
            Dim UsarPeriodEstudo As BancoPeriodoEstudo
            Dim UsarSexo As UsandoSexoPrincCundult

            Dim UsandoBancoQuestoes As USBancoQuestoes = New USBancoQuestoes()

            UsarQuestionario = New Questoes(mskCepDePerNoite.Text, NumQuantSinistr.Value.ToString, txtClasseDeBonus.Text, cboUsoVeiculo.Text, cboResidemComCondutor.Text, txtDistAproxEmKmResidencia.Text, cboPrincCondutEstud.Text, cboUtilizaVeiculoVisitas.Text, cboRoubo.Text, cboPossuiFilhos.Text, cboGaragemFechada.Text, cboSeguradProprietario.Text, mskCepTrabalho.Text, IDPessoaFisica, IDPessoaJuridica, cboSeguradora.Text, mskKmMediaMensal.Text)

            UsandoBancoQuestoes.UsarBancoQuestionario(UsarQuestionario)


            Try

                Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
                Dim SQL As String = ("SELECT Max(id_questionario) FROM solafide_v6.tb_Questionario_Seguro_Auto;")
                Dim connection As New MySqlConnection(myConnectionString)
                Dim command As New MySqlCommand(SQL, connection)
                connection.Open()
                IDQuestoes = command.ExecuteScalar.ToString
                connection.Close()
                connection = Nothing
                command = Nothing
            Catch ex As Exception
                MsgBox("Erro no select Max de orçamento - " & ex.Message)
            End Try

            Dim UsandoBancoVeiculo As USBancoVeiculo = New USBancoVeiculo()
            Dim UsandoBancoGaragem As USBancoGaragem = New USBancoGaragem()
            Dim UsandoBancoPrinciCondutor As USBancoPrincCondutor = New USBancoPrincCondutor()
            Dim UsandoBancoPeriodoEstudos As USBancoPeriodoEstudos = New USBancoPeriodoEstudos()


            UsarGaragem = New Garagem(cboNaResidencia.Text, cboNoTrabalho.Text, cboNaEscola.Text, IDQuestoes)
            UsarFilhoA17 = New Filho_Ent_At17(numQuantos.Text, numIdade.Text, IDQuestoes)
            UsarVeiculo = New Veiculo(cboFabricante.Text, cboModelo.Text, mskPlaca.Text, txtRenavan.Text, txtChassi.Text, cboFinanciamento.Text, txtCor.Text, NumDPortas.Value.ToString, cboCombustivel.Text, cboKitGas.Text, IDQuestoes, IDPessoaFisica, IDPessoaJuridica, cboPossuiSistemaAntiFurto.Text, mskAnoFrabric.Text)
            UsarPrincCondutor = New PrincCondutor(txtRelacaoCondutor.Text, IDPessoaFisica, IDPessoaJuridica, IDQuestoes, cboPrincipalCondutorReside.Text, txtPrincCondut.Text)
            UsarSegCondt = New SegundCondutor(txtSegundoCondutor.Text, mskDataNascSegCondut.Text, IDQuestoes, mskCNH.Text)
            UsarPeriodEstudo = New BancoPeriodoEstudo(cboMatutino.Text, cboVespertino.Text, cboNoturno.Text, IDQuestoes)


            UsandoBancoPrinciCondutor.UsarSegundCond(UsarSegCondt)
            UsandoBancoPrinciCondutor.UsarCondtPrincipal(UsarPrincCondutor)
            UsandoBancoQuestoes.UsarBancoFilho(UsarFilhoA17)
            UsandoBancoVeiculo.UsarBancoVeiculo(UsarVeiculo)
            UsandoBancoGaragem.UsarBancoGaragem(UsarGaragem)
            UsandoBancoPeriodoEstudos.UsarPeridoEstud(UsarPeriodEstudo)

            Try

                Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
                Dim SQL As String = ("SELECT Max(id_segundo_condutor) FROM tb_Segundo_Condutor;")
                Dim connection As New MySqlConnection(myConnectionString)
                Dim command As New MySqlCommand(SQL, connection)
                connection.Open()
                IDSegundoCondutor = command.ExecuteScalar.ToString
                connection.Close()
                connection = Nothing
                command = Nothing
            Catch ex As Exception
                MsgBox("Erro no select Max Segundo Condutor" & ex.Message)
            End Try

            Dim UsandoBancoSexo As USBancoPrincCondutor = New USBancoPrincCondutor()
            UsarSexo = New UsandoSexoPrincCundult(cboSexo.Text, IDSegundoCondutor)
            UsandoBancoSexo.UsarSexo(UsarSexo)

        Catch ex As Exception

        End Try

    End Sub
    Public Sub Atualizar()
        Dim UPQuest As UpdateQuestoes
        Dim UsarUPFilhoA17 As Update_Filho_At17
        Dim UsarUPVeiculo As USBancoUpdateVeiculo
        Dim UsarUpGaragem As UpdateGaragem
        Dim PrinciCondutorUpdate As PrinciCondutorUpdate
        Dim SegundoCondutorUpdate As SegundCondutorUpdate
        Dim UsarUpdateEstudos As BancoPeriodoEstudosUpdate

        Dim UsandoUPBancoQuestoes As UPBancoQuestoes = New UPBancoQuestoes()
        Dim USBancoUpdateVeiculo As UpdateVeiculo = New UpdateVeiculo()
        Dim USBancoUpdateGaragem As USBancoUpGaragem = New USBancoUpGaragem()
        Dim USBancoUpdateCondutor As USBancoUpdateCondut = New USBancoUpdateCondut()
        Dim USBancoPeriodoEstudos As USBancoPeriodoEstudosUpdate = New USBancoPeriodoEstudosUpdate()

        UPQuest = New UpdateQuestoes(mskCepDePerNoite.Text, NumQuantSinistr.Value.ToString, txtClasseDeBonus.Text, cboUsoVeiculo.Text, cboResidemComCondutor.Text, txtDistAproxEmKmResidencia.Text, cboPrincCondutEstud.Text, cboUtilizaVeiculoVisitas.Text, cboRoubo.Text, cboPossuiFilhos.Text, cboGaragemFechada.Text, numQuantos.Value.ToString, cboSeguradProprietario.Text, mskCepTrabalho.Text, IDPessoaFisica, IDPessoaJuridica, cboSeguradora.Text, mskKmMediaMensal.Text, txtIDQuestonario.Text)
        UsarUPFilhoA17 = New Update_Filho_At17(numQuantos.Text, numIdade.Text, txtIDQuestonario.Text)
        UsarUPVeiculo = New USBancoUpdateVeiculo(cboFabricante.Text, cboModelo.Text, mskPlaca.Text, txtRenavan.Text, txtChassi.Text, cboFinanciamento.Text, txtCor.Text, NumDPortas.Value.ToString, cboCombustivel.Text, cboKitGas.Text, IDQuestoes, IDPessoaFisica, IDPessoaJuridica, cboPossuiSistemaAntiFurto.Text, mskAnoFrabric.Text, txtIDQuestonario.Text)
        UsarUpGaragem = New UpdateGaragem(cboNaResidencia.Text, cboNoTrabalho.Text, cboNaEscola.Text, txtIDQuestonario.Text)
        PrinciCondutorUpdate = New PrinciCondutorUpdate(txtRelacaoCondutor.Text, IDPessoaFisica, IDPessoaJuridica, txtIDQuestonario.Text, cboPrincipalCondutorReside.Text)
        SegundoCondutorUpdate = New SegundCondutorUpdate(txtSegundoCondutor.Text, mskDataNascSegCondut.Text, txtIDQuestonario.Text, mskCNH.Text)
        UsarUpdateEstudos = New BancoPeriodoEstudosUpdate(cboMatutino.Text, cboVespertino.Text, cboNoturno.Text, txtIDQuestonario.Text)

        UsandoUPBancoQuestoes.UPQuestoes(UPQuest)
        UsandoUPBancoQuestoes.UPDBancoFilho(UsarUPFilhoA17)
        USBancoUpdateVeiculo.UsarBancoUPVeiculo(UsarUPVeiculo)
        USBancoUpdateGaragem.UsarBancoUPGaragem(UsarUpGaragem)
        USBancoUpdateCondutor.UsarBancoUpdateCondutPrinci(PrinciCondutorUpdate)
        USBancoUpdateCondutor.UsarBancoUpdateSegundoCondutor(SegundoCondutorUpdate)
        USBancoPeriodoEstudos.UsarBancoPeriodoEstudos(UsarUpdateEstudos)
    End Sub


    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Try
            Validacao()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CadastrarVeiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()


        TudoBloqueado()
        btnPrimeiro.Enabled = False
        btnVoltar.Enabled = False
        btnIr.Enabled = True
        btnUltimo.Enabled = True
    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim result As Integer = MessageBox.Show("Quer Realmente excluir essa Seguradora ? ", "Sola Fide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Deletar()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If mskCepDePerNoite.Enabled = False Then
            Desbloqueado()
            BtnCadastrar.Enabled = False
            BtLimpar.Enabled = False
            btnCancelar.Visible = True
            btnExcluir.Enabled = False
        ElseIf mskCepDePerNoite.Enabled = True Then
            ValidacaoAlterar()

        End If
    End Sub

    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        Novo()
        Desbloqueado()
        Bloqueanavegacao()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As Integer = MessageBox.Show("Quer realmente cancelar?", "Sola Fide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            Navegacao.MovimentarRegistros(NavegarVeiculo.registros.Primeiro)




            DesbloqueiaNavegacao()
            TudoBloqueado()
        End If
    End Sub
    Private Sub Deletar()
        Dim CMD2 As New MySqlCommand("Delete From tb_questionario_seguro_auto where id_questionario = '" & txtIDQuestonario.Text & "';")
        Try


            CMD2.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD2.Connection.Open()
            CMD2.ExecuteNonQuery()


            MessageBox.Show("Excluido com sucesso")

            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            Navegacao.MovimentarRegistros(NavegarVeiculo.registros.Primeiro)





        Catch ex As Exception
            MsgBox("Erro ao excluir o Veiculo - " + ex.Message)
        Finally
            CMD2.Connection.Close()
        End Try

    End Sub

    Public Sub Novo()
        Objeto.Novo()
    End Sub
    Public Sub TudoBloqueado()
        Objeto.TudoBloqueado()
    End Sub
    Public Sub Desbloqueado()
        Objeto.Desbloqueado()
    End Sub
    Private Sub Bloqueanavegacao()
        Objeto.BloqueiaNavegacao()
    End Sub
    Private Sub DesbloqueiaNavegacao()
        Objeto.DesbloqueiaNavegacao()
    End Sub
    Private Sub Validacao()
        Dim Validar As New ValidacaoCadVeiculo
        Validar.Validacao()
    End Sub
    Private Sub ValidacaoAlterar()
        Dim Validar As New ValidacaoCadVeiculo
        Validar.ValidacaoAlterar()
    End Sub

    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Navegacao.MovimentarRegistros(NavegarVeiculo.registros.Primeiro)
        Navegacao.AtualizarForm()



    End Sub
    ' FIM BOTAO PRIMEIRO REGISTRO

    ' INICIO BOTAO VOLTAR REGISTRO
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Navegacao.MovimentarRegistros(NavegarVeiculo.registros.Anterior)
        Navegacao.AtualizarForm()



    End Sub
    ' FIM BOTAO VOLTAR REGISTRO

    ' INICIO BOTAO PROXIMO REGISTRO
    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        Navegacao.MovimentarRegistros(NavegarVeiculo.registros.Proximo)
        Navegacao.AtualizarForm()



    End Sub
    'FIM BOTAO PROXIMO REGISTRO

    ' INICIO BOTAO ULTIMO REGISTRO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Navegacao.MovimentarRegistros(NavegarVeiculo.registros.Ultimo)
        Navegacao.AtualizarForm()



    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        RelatorioVeiculo.Show()
    End Sub

    Private Sub cboPossuiFilhos_TextChanged(sender As Object, e As EventArgs) Handles cboPossuiFilhos.TextChanged
        If cboSeguradora.Enabled = True Then
            If cboPossuiFilhos.Text = "Sim" Then
                numQuantos.Enabled = True
                numIdade.Enabled = True
                numQuantos.Minimum = 1
                numIdade.Maximum = 17
                numQuantos.Value = 1
                numIdade.Value = 1
                numQuantos.Focus()
            End If
            If cboPossuiFilhos.Text = "Não" Or cboPossuiFilhos.Text = "" Or cboPossuiFilhos.Text = "Selecione" Then
                numQuantos.Enabled = False
                numIdade.Enabled = False
                numQuantos.Minimum = 0
                numIdade.Maximum = 0
                numQuantos.Value = 0
                numIdade.Value = 0
            End If
        Else
            numQuantos.Enabled = False
            numIdade.Enabled = False
        End If

    End Sub

    Private Sub cboGaragemFechada_TextChanged(sender As Object, e As EventArgs) Handles cboGaragemFechada.TextChanged
        If cboSeguradora.Enabled = True Then
            If cboGaragemFechada.Text = "Sim" Then
                If cboUsoVeiculo.Text = "Trabalho" Then
                    cboNaResidencia.Enabled = False
                    cboNaEscola.Enabled = False
                    cboNoTrabalho.Enabled = True
                End If
                If cboUsoVeiculo.Text = "Estudo" Then
                    cboNaResidencia.Enabled = False
                    cboNaEscola.Enabled = True
                    cboNoTrabalho.Enabled = False
                End If
                If cboUsoVeiculo.Text = "Lazer" Then
                    cboNaResidencia.Enabled = True
                    cboNaEscola.Enabled = False
                    cboNoTrabalho.Enabled = False
                End If
                If cboUsoVeiculo.Text = "Todos" Or cboUsoVeiculo.Text = "Outros" Then
                    cboNaResidencia.Enabled = True
                    cboNaEscola.Enabled = True
                    cboNoTrabalho.Enabled = True
                End If
                cboNaResidencia.Focus()
            End If
            If cboGaragemFechada.Text = "Não" Or cboGaragemFechada.Text = "" Or cboGaragemFechada.Text = "Selecione" Then
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboNaResidencia.Text = ""
                cboNaEscola.Text = ""
                cboNoTrabalho.Text = ""
            End If
        Else
            cboNaResidencia.Enabled = False
            cboNaEscola.Enabled = False
            cboNoTrabalho.Enabled = False
        End If

    End Sub

    Private Sub cboPrincCondutEstud_TextChanged(sender As Object, e As EventArgs) Handles cboPrincCondutEstud.TextChanged
        If cboSeguradora.Enabled = True Then
            If cboPrincCondutEstud.Text = "Sim" Then
                cboMatutino.Enabled = True
                cboVespertino.Enabled = True
                cboNoturno.Enabled = True

                cboMatutino.Focus()
            End If
            If cboPrincCondutEstud.Text = "Não" Or cboPrincCondutEstud.Text = "" Or cboPrincCondutEstud.Text = "Selecione" Then
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False

                cboMatutino.Text = ""
                cboVespertino.Text = ""
                cboNoturno.Text = ""
            End If
        Else
            cboMatutino.Enabled = False
            cboVespertino.Enabled = False
            cboNoturno.Enabled = False
        End If

    End Sub
    Private Sub cboSeguradProprietario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSeguradProprietario.SelectedIndexChanged
        If cboSeguradora.Enabled = True Then
            If cboSeguradProprietario.Text = "Sim" Or cboSeguradProprietario.Text = "Selecione" Or cboSeguradProprietario.Text = "" Then
                txtRelacaoCondutor.Enabled = False
                txtSegundoCondutor.Enabled = False
                mskDataNascSegCondut.Enabled = False
                cboSexo.Enabled = False
                cboPossuiFilhos.Enabled = False
                mskCNH.Enabled = False
                txtRelacaoCondutor.Text = ""
                txtSegundoCondutor.Text = ""
                mskDataNascSegCondut.Text = ""
                cboSexo.Text = ""
                cboPossuiFilhos.Text = "Não"
                mskCNH.Text = ""
                txtRelacaoCondutor.Focus()
            End If
            If cboSeguradProprietario.Text = "Não" Then
                txtRelacaoCondutor.Enabled = True
                txtSegundoCondutor.Enabled = True
                mskDataNascSegCondut.Enabled = True
                cboSexo.Enabled = True
                cboPossuiFilhos.Enabled = True
                mskCNH.Enabled = True
                numQuantos.Minimum = 0
                numIdade.Minimum = 0
                numIdade.Value = 0
                numQuantos.Value = 0
                txtRelacaoCondutor.Text = ""
                txtSegundoCondutor.Text = ""
                mskDataNascSegCondut.Text = ""
                cboSexo.Text = "Selecione"
                cboPossuiFilhos.Text = "Selecione"
                txtRelacaoCondutor.Focus()
            End If
        Else
            txtRelacaoCondutor.Enabled = False
            txtSegundoCondutor.Enabled = False
            mskDataNascSegCondut.Enabled = False
            cboSexo.Enabled = False
            cboPossuiFilhos.Enabled = False
            mskCNH.Enabled = False
        End If
    End Sub
    Private Sub cboSeguradProprietario_TabIndexChanged(sender As Object, e As EventArgs) Handles cboSeguradProprietario.TabIndexChanged
        If cboSeguradora.Enabled = True Then
            If cboSeguradProprietario.Text = "Sim" Or cboSeguradProprietario.Text = "Selecione" Or cboSeguradProprietario.Text = "" Then
                txtRelacaoCondutor.Enabled = False
                txtSegundoCondutor.Enabled = False
                mskDataNascSegCondut.Enabled = False
                cboSexo.Enabled = False
                cboPossuiFilhos.Enabled = False
                mskCNH.Enabled = False
                txtRelacaoCondutor.Text = ""
                txtSegundoCondutor.Text = ""
                mskDataNascSegCondut.Text = ""
                cboSexo.Text = ""
                cboPossuiFilhos.Text = "Não"
                mskCNH.Text = ""
                txtRelacaoCondutor.Focus()
            End If
            If cboSeguradProprietario.Text = "Não" Then
                txtRelacaoCondutor.Enabled = True
                txtSegundoCondutor.Enabled = True
                mskDataNascSegCondut.Enabled = True
                cboSexo.Enabled = True
                cboPossuiFilhos.Enabled = True
                mskCNH.Enabled = True
                numQuantos.Minimum = 0
                numIdade.Minimum = 0
                numIdade.Value = 0
                numQuantos.Value = 0
                txtRelacaoCondutor.Text = ""
                txtSegundoCondutor.Text = ""
                mskDataNascSegCondut.Text = ""
                cboSexo.Text = "Selecione"
                cboPossuiFilhos.Text = "Selecione"
                txtRelacaoCondutor.Focus()
            End If
        Else
            txtRelacaoCondutor.Enabled = False
            txtSegundoCondutor.Enabled = False
            mskDataNascSegCondut.Enabled = False
            cboSexo.Enabled = False
            cboPossuiFilhos.Enabled = False
            mskCNH.Enabled = False
        End If
    End Sub

    Private Sub cboSeguradProprietario_TextChanged(sender As Object, e As EventArgs) Handles cboSeguradProprietario.TextChanged
        If cboSeguradora.Enabled = True Then
            If cboSeguradProprietario.Text = "Sim" Or cboSeguradProprietario.Text = "Selecione" Or cboSeguradProprietario.Text = "" Then
                txtRelacaoCondutor.Enabled = False
                txtSegundoCondutor.Enabled = False
                mskDataNascSegCondut.Enabled = False
                cboSexo.Enabled = False
                cboPossuiFilhos.Enabled = False
                mskCNH.Enabled = False
                txtRelacaoCondutor.Text = ""
                txtSegundoCondutor.Text = ""
                mskDataNascSegCondut.Text = ""
                cboSexo.Text = ""
                cboPossuiFilhos.Text = "Não"
                mskCNH.Text = ""
                txtRelacaoCondutor.Focus()
            End If
            If cboSeguradProprietario.Text = "Não" Then
                txtRelacaoCondutor.Enabled = True
                txtSegundoCondutor.Enabled = True
                mskDataNascSegCondut.Enabled = True
                cboSexo.Enabled = True
                cboPossuiFilhos.Enabled = True
                mskCNH.Enabled = True
                numQuantos.Minimum = 0
                numIdade.Minimum = 0
                numIdade.Value = 0
                numQuantos.Value = 0
                txtRelacaoCondutor.Text = ""
                txtSegundoCondutor.Text = ""
                mskDataNascSegCondut.Text = ""
                cboSexo.Text = "Selecione"
                cboPossuiFilhos.Text = "Selecione"
                txtRelacaoCondutor.Focus()
            End If
        Else
            txtRelacaoCondutor.Enabled = False
            txtSegundoCondutor.Enabled = False
            mskDataNascSegCondut.Enabled = False
            cboSexo.Enabled = False
            cboPossuiFilhos.Enabled = False
            mskCNH.Enabled = False
        End If



    End Sub

    Private Sub cboUsoVeiculo_TextChanged(sender As Object, e As EventArgs) Handles cboUsoVeiculo.TextChanged
        If cboSeguradora.Enabled = True Then
            If cboUsoVeiculo.Text = "Trabalho" Then
                cboUtilizaVeiculoVisitas.Enabled = True
                txtDistAproxEmKmResidencia.Enabled = True
                mskCepTrabalho.Enabled = True
                cboGaragemFechada.Enabled = True
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboPrincCondutEstud.Enabled = False
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False
                cboUtilizaVeiculoVisitas.Text = "Selecione"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Selecione"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Não"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboUtilizaVeiculoVisitas.Focus()
            End If
            If cboUsoVeiculo.Text = "Selecione" Then
                cboUtilizaVeiculoVisitas.Enabled = False
                txtDistAproxEmKmResidencia.Enabled = False
                mskCepTrabalho.Enabled = False
                cboGaragemFechada.Enabled = False
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboPrincCondutEstud.Enabled = False
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False
                cboUtilizaVeiculoVisitas.Text = "Não"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Não"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Não"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboUsoVeiculo.Focus()
            End If

            If cboUsoVeiculo.Text = "Estudo" Then
                cboUtilizaVeiculoVisitas.Enabled = False
                txtDistAproxEmKmResidencia.Enabled = False
                mskCepTrabalho.Enabled = False
                cboGaragemFechada.Enabled = True
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboPrincCondutEstud.Enabled = True
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False
                cboUtilizaVeiculoVisitas.Text = "Não"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Selecione"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Selecione"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboGaragemFechada.Focus()
            End If

            If cboUsoVeiculo.Text = "Lazer" Then
                cboUtilizaVeiculoVisitas.Enabled = False
                txtDistAproxEmKmResidencia.Enabled = False
                mskCepTrabalho.Enabled = False
                cboGaragemFechada.Enabled = True
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboPrincCondutEstud.Enabled = False
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False
                cboUtilizaVeiculoVisitas.Text = "Não"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Selecione"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Não"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboGaragemFechada.Focus()
            End If

            If cboUsoVeiculo.Text = "Todos" Or cboUsoVeiculo.Text = "Outros" Then
                cboUtilizaVeiculoVisitas.Enabled = True
                txtDistAproxEmKmResidencia.Enabled = True
                mskCepTrabalho.Enabled = True
                cboGaragemFechada.Enabled = True
                cboPrincCondutEstud.Enabled = True
                cboUtilizaVeiculoVisitas.Text = "Selecione"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Selecione"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Selecione"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboUtilizaVeiculoVisitas.Focus()
            End If
        Else
            cboUtilizaVeiculoVisitas.Enabled = False
            txtDistAproxEmKmResidencia.Enabled = False
            mskCepTrabalho.Enabled = False
            cboGaragemFechada.Enabled = False
            cboNaResidencia.Enabled = False
            cboNaEscola.Enabled = False
            cboNoTrabalho.Enabled = False
            cboPrincCondutEstud.Enabled = False
            cboMatutino.Enabled = False
            cboVespertino.Enabled = False
            cboNoturno.Enabled = False
        End If

    End Sub

    Private Sub txtFabricante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFabricante.SelectedIndexChanged
        Atualizacao_Marca_Veiculo()
    End Sub
    Public Sub Atualizacao_Marca_Veiculo()
        Conexao.conectar()
        Try
            Dim sql As String = ("select * From solafide_v6.tb_lista_nome_veiculo inner Join tb_lista_marca_veiculo on tb_lista_marca_veiculo.id_lista_veiculo=tb_lista_nome_veiculo.id_lista_Nome_veiculo where marca like '" & cboFabricante.Text & "';")
            Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            cboModelo.DisplayMember = "Nome_veiculo"
            cboModelo.DataSource = dt
        Catch ex As Exception

        Finally
            Conexao.cn.Close()
        End Try
    End Sub
    Private Sub cboPossuiFilhos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPossuiFilhos.SelectedIndexChanged
        If cboSeguradora.Enabled = True Then
            If cboPossuiFilhos.Text = "Sim" Then
                numQuantos.Enabled = True
                numIdade.Enabled = True
                numQuantos.Minimum = 1
                numIdade.Maximum = 17
                numQuantos.Value = 1
                numIdade.Value = 1
                numQuantos.Focus()
            End If
            If cboPossuiFilhos.Text = "Não" Or cboPossuiFilhos.Text = "" Or cboPossuiFilhos.Text = "Selecione" Then
                numQuantos.Enabled = False
                numIdade.Enabled = False
                numQuantos.Minimum = 0
                numIdade.Minimum = 0
                numQuantos.Value = 0
                numIdade.Value = 0
            End If
        Else
            numQuantos.Enabled = False
            numIdade.Enabled = False
        End If

    End Sub

    Private Sub cboUsoVeiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsoVeiculo.SelectedIndexChanged
        If cboSeguradora.Enabled = True Then
            If cboUsoVeiculo.Text = "Trabalho" Then
                cboUtilizaVeiculoVisitas.Enabled = True
                txtDistAproxEmKmResidencia.Enabled = True
                mskCepTrabalho.Enabled = True
                cboGaragemFechada.Enabled = True
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboPrincCondutEstud.Enabled = False
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False
                cboUtilizaVeiculoVisitas.Text = "Selecione"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Selecione"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Não"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboUtilizaVeiculoVisitas.Focus()
            End If
            If cboUsoVeiculo.Text = "Selecione" Then
                cboUtilizaVeiculoVisitas.Enabled = False
                txtDistAproxEmKmResidencia.Enabled = False
                mskCepTrabalho.Enabled = False
                cboGaragemFechada.Enabled = False
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboPrincCondutEstud.Enabled = False
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False
                cboUtilizaVeiculoVisitas.Text = "Não"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Não"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Não"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboUsoVeiculo.Focus()
            End If

            If cboUsoVeiculo.Text = "Estudo" Then
                cboUtilizaVeiculoVisitas.Enabled = False
                txtDistAproxEmKmResidencia.Enabled = False
                mskCepTrabalho.Enabled = False
                cboGaragemFechada.Enabled = True
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboPrincCondutEstud.Enabled = True
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False
                cboUtilizaVeiculoVisitas.Text = "Não"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Selecione"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Selecione"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboGaragemFechada.Focus()
            End If

            If cboUsoVeiculo.Text = "Lazer" Then
                cboUtilizaVeiculoVisitas.Enabled = False
                txtDistAproxEmKmResidencia.Enabled = False
                mskCepTrabalho.Enabled = False
                cboGaragemFechada.Enabled = True
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboPrincCondutEstud.Enabled = False
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False
                cboUtilizaVeiculoVisitas.Text = "Não"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Selecione"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Não"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboGaragemFechada.Focus()
            End If

            If cboUsoVeiculo.Text = "Todos" Or cboUsoVeiculo.Text = "Outros" Then
                cboUtilizaVeiculoVisitas.Enabled = True
                txtDistAproxEmKmResidencia.Enabled = True
                mskCepTrabalho.Enabled = True
                cboGaragemFechada.Enabled = True
                cboPrincCondutEstud.Enabled = True
                cboUtilizaVeiculoVisitas.Text = "Selecione"
                txtDistAproxEmKmResidencia.Text = ""
                mskCepTrabalho.Text = ""
                cboGaragemFechada.Text = "Selecione"
                cboNaResidencia.Text = "Não"
                cboNaEscola.Text = "Não"
                cboNoTrabalho.Text = "Não"
                cboPrincCondutEstud.Text = "Selecione"
                cboMatutino.Text = "Não"
                cboVespertino.Text = "Não"
                cboNoturno.Text = "Não"
                cboUtilizaVeiculoVisitas.Focus()
            End If
        Else
            cboUtilizaVeiculoVisitas.Enabled = False
            txtDistAproxEmKmResidencia.Enabled = False
            mskCepTrabalho.Enabled = False
            cboGaragemFechada.Enabled = False
            cboNaResidencia.Enabled = False
            cboNaEscola.Enabled = False
            cboNoTrabalho.Enabled = False
            cboPrincCondutEstud.Enabled = False
            cboMatutino.Enabled = False
            cboVespertino.Enabled = False
            cboNoturno.Enabled = False
        End If
    End Sub

    Private Sub cboGaragemFechada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGaragemFechada.SelectedIndexChanged
        If cboSeguradora.Enabled = True Then
            If cboGaragemFechada.Text = "Sim" Then
                If cboUsoVeiculo.Text = "Trabalho" Then
                    cboNaResidencia.Enabled = False
                    cboNaEscola.Enabled = False
                    cboNoTrabalho.Enabled = True
                End If
                If cboUsoVeiculo.Text = "Estudo" Then
                    cboNaResidencia.Enabled = False
                    cboNaEscola.Enabled = True
                    cboNoTrabalho.Enabled = False
                End If
                If cboUsoVeiculo.Text = "Lazer" Then
                    cboNaResidencia.Enabled = True
                    cboNaEscola.Enabled = False
                    cboNoTrabalho.Enabled = False
                End If
                If cboUsoVeiculo.Text = "Todos" Or cboUsoVeiculo.Text = "Outros" Then
                    cboNaResidencia.Enabled = True
                    cboNaEscola.Enabled = True
                    cboNoTrabalho.Enabled = True
                End If
                cboNaResidencia.Focus()
            End If
            If cboGaragemFechada.Text = "Não" Or cboGaragemFechada.Text = "" Or cboGaragemFechada.Text = "Selecione" Then
                cboNaResidencia.Enabled = False
                cboNaEscola.Enabled = False
                cboNoTrabalho.Enabled = False
                cboNaResidencia.Text = ""
                cboNaEscola.Text = ""
                cboNoTrabalho.Text = ""
            End If
        Else
            cboNaResidencia.Enabled = False
            cboNaEscola.Enabled = False
            cboNoTrabalho.Enabled = False
        End If
    End Sub

    Private Sub cboPrincCondutEstud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPrincCondutEstud.SelectedIndexChanged
        If cboSeguradora.Enabled = True Then
            If cboPrincCondutEstud.Text = "Sim" Then
                cboMatutino.Enabled = True
                cboVespertino.Enabled = True
                cboNoturno.Enabled = True

                cboMatutino.Focus()
            End If
            If cboPrincCondutEstud.Text = "Não" Or cboPrincCondutEstud.Text = "" Or cboPrincCondutEstud.Text = "Selecione" Then
                cboMatutino.Enabled = False
                cboVespertino.Enabled = False
                cboNoturno.Enabled = False

                cboMatutino.Text = ""
                cboVespertino.Text = ""
                cboNoturno.Text = ""
            End If
        Else
            cboMatutino.Enabled = False
            cboVespertino.Enabled = False
            cboNoturno.Enabled = False
        End If

    End Sub

    Private Sub cboUsoVeiculo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboUsoVeiculo.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim objConsCli As New Pesquisa
        objConsCli.ShowDialog()

        If objConsCli.Confirm = True Then
            IDPessoaFisica = objConsCli.CodPfisica
            LblNomeShow.Text = objConsCli.NomeComplet
            IDPessoaJuridica = "Null"
        ElseIf objConsCli.Confirmarcao = True Then
            IDPessoaJuridica = objConsCli.CodPJuridica
            LblNomeShow.Text = objConsCli.Representante
            IDPessoaFisica = "Null"
        End If
    End Sub

    Private Sub txtCor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCor.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Digite apenas letras em Cor ", "Erro em Cadastro de Veículo", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False


        Else
            e.Handled = False

        End If
    End Sub
End Class
















































