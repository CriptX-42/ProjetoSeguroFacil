Imports MySql.Data.MySqlClient


Public Class F_ObjetoQuest
    Dim Conexao As New ConexaoSolafide
    Public Sub Novo()
        With frmDadosVeiculo


            .mskPlaca.Text = ""
            .txtRenavan.Text = ""
            .txtChassi.Text = ""
            .cboFinanciamento.Text = "Selecione"
            .txtCor.Text = ""
            .NumDPortas.Value = 2
            .cboCombustivel.Text = "Selecione"
            .cboKitGas.Text = "Selecione"

            .txtRelacaoCondutor.Text = ""
            .txtSegundoCondutor.Text = ""
            .mskDataNascSegCondut.Text = ""
            .cboSexo.Text = ""
            .cboPrincipalCondutorReside.Text = "Selecione"
            .cboPossuiFilhos.Text = "Não"

            .numQuantos.Minimum = 0
            .numIdade.Minimum = 0
            .numQuantos.Value = 0
            .numIdade.Value = 0
            .txtPrincCondut.Text = ""
            .txtIDQuestonario.Text = ""
            .mskCNH.Text = ""

            .txtDistAproxEmKmResidencia.Text = ""
            .txtDistAproxEmKmResidencia.Text = ""
            .mskCepDePerNoite.Text = ""
            .mskKmMediaMensal.Text = ""

            .cboGaragemFechada.Text = "Não"
            .cboNaResidencia.Text = "Não"
            .cboNoTrabalho.Text = "Não"
            .cboNaEscola.Text = "Não"
            .txtPrincCondut.Text = ""
            .cboUtilizaVeiculoVisitas.Text = "Não"
            .cboSeguradProprietario.Text = "Selecione"
            .cboRoubo.Text = "Selecione"
            .cboPossuiSistemaAntiFurto.SelectedIndex = 0
            .mskCepTrabalho.Text = ""
            .mskAnoFrabric.Text = ""
            .LblNomeShow.Text = ""

            .cboFabricante.Text = ""
            .cboModelo.Text = ""
            .cboSeguradora.Text = ""

            '=======================================================COMBO MARCA==========================================='
            Conexao.conectar()
            Try
                Dim sql As String = ("SELECT * FROM tb_lista_marca_veiculo")
                Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                .cboFabricante.DisplayMember = "Marca"
                .cboFabricante.DataSource = dt
            Catch ex As Exception

            Finally
                Conexao.cn.Close()
            End Try
            '======================================================================================================================
            '######################################################################################################################
            '==================================================COMBO MODELO========================================================
            Conexao.conectar()
            Try
                Dim sql As String = ("select * From solafide_v6.tb_lista_nome_veiculo inner Join tb_lista_marca_veiculo on tb_lista_marca_veiculo.id_lista_veiculo=tb_lista_nome_veiculo.id_lista_Nome_veiculo where marca like '" & .cboFabricante.Text & "';")
                Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                .cboModelo.DisplayMember = "Nome_veiculo"
                .cboModelo.DataSource = dt
            Catch ex As Exception

            Finally
                Conexao.cn.Close()
            End Try
            '======================================================================================================================
            '######################################################################################################################
            '=================================================COMBO DE SEGURADORA==================================================
            Try
                Conexao.conectar()
                Dim sql As String = ("SELECT * FROM tb_Seguradora")
                Dim cmd As MySqlCommand = New MySqlCommand(sql, Conexao.cn)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                .cboSeguradora.DisplayMember = "nome_seguradora"
                .cboSeguradora.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Erro ao trazer as Seguradoras Cadastrardas", "Erro Veiculo", MessageBoxButtons.OK)
            Finally
                Conexao.cn.Close()
            End Try
            '======================================================================================================================
            .txtClasseDeBonus.SelectedIndex = 0
            .NumQuantSinistr.Value = 0
            .cboUsoVeiculo.Text = "Selecione"
            .cboPrincCondutEstud.Text = "Não"
            .cboMatutino.Text = "Não"
            .cboVespertino.Text = "Não"
            .cboNoturno.Text = "Não"
            .cboResidemComCondutor.Text = "Selecione"


            .PictureBox1.Enabled = True
            .btnCancelar.Visible = True
            .BtnCadastrar.Visible = True
            .BtnCadastrar.Enabled = True
            .btnImprimir.Visible = False
        End With
        BloqueiaNavegacao()
    End Sub
    Public Sub Desbloqueado()
        With frmDadosVeiculo
            .txtRelacaoCondutor.Enabled = False
            .txtSegundoCondutor.Enabled = False
            .mskDataNascSegCondut.Enabled = False
            .cboSexo.Enabled = False
            .cboPrincipalCondutorReside.Enabled = True
            .cboPossuiFilhos.Enabled = False
            .numQuantos.Enabled = False
            .numIdade.Enabled = False
            .cboResidemComCondutor.Enabled = True
            .txtDistAproxEmKmResidencia.Enabled = False
            .mskCepDePerNoite.Enabled = True
            .mskKmMediaMensal.Enabled = True
            .mskCepTrabalho.Enabled = False


            .cboGaragemFechada.Enabled = False
            .cboNaResidencia.Enabled = False
            .cboNaEscola.Enabled = False
            .cboNoTrabalho.Enabled = False

            .cboUtilizaVeiculoVisitas.Enabled = False
            .cboSeguradProprietario.Enabled = True
            .cboRoubo.Enabled = True
            .cboPossuiSistemaAntiFurto.Enabled = True
            .cboSeguradora.Enabled = True
            .txtClasseDeBonus.Enabled = True
            .NumQuantSinistr.Enabled = True
            .cboUsoVeiculo.Enabled = True
            .cboPrincCondutEstud.Enabled = False
            .cboMatutino.Enabled = False
            .cboVespertino.Enabled = False
            .cboNoturno.Enabled = False
            .txtPrincCondut.Enabled = True
            .cboFabricante.Enabled = True
            .cboModelo.Enabled = True
            .mskPlaca.Enabled = True
            .txtChassi.Enabled = True
            .cboCombustivel.Enabled = True
            .cboKitGas.Enabled = True
            .NumDPortas.Enabled = True
            .txtCor.Enabled = True
            .txtRenavan.Enabled = True
            .cboFinanciamento.Enabled = True
            .mskAnoFrabric.Enabled = True

            .btnCancelar.Visible = True
        End With
    End Sub
    Public Sub TudoBloqueado()
        With frmDadosVeiculo
            .txtRelacaoCondutor.Enabled = False
            .txtSegundoCondutor.Enabled = False
            .mskDataNascSegCondut.Enabled = False
            .cboSexo.Enabled = False
            .cboPrincipalCondutorReside.Enabled = False
            .cboPossuiFilhos.Enabled = False
            .numQuantos.Enabled = False
            .numIdade.Enabled = False
            .cboResidemComCondutor.Enabled = False
            .txtDistAproxEmKmResidencia.Enabled = False
            .mskCepDePerNoite.Enabled = False
            .mskKmMediaMensal.Enabled = False
            .mskCepTrabalho.Enabled = False

            .cboGaragemFechada.Enabled = False
            .cboNaResidencia.Enabled = False
            .cboNaEscola.Enabled = False
            .cboNoTrabalho.Enabled = False

            .cboUtilizaVeiculoVisitas.Enabled = False
            .cboSeguradProprietario.Enabled = False
            .cboRoubo.Enabled = False
            .cboPossuiSistemaAntiFurto.Enabled = False
            .cboSeguradora.Enabled = False
            .txtClasseDeBonus.Enabled = False
            .NumQuantSinistr.Enabled = False
            .cboUsoVeiculo.Enabled = False
            .cboPrincCondutEstud.Enabled = False
            .cboMatutino.Enabled = False
            .cboVespertino.Enabled = False
            .cboNoturno.Enabled = False

            .cboFabricante.Enabled = False
            .cboModelo.Enabled = False
            .mskPlaca.Enabled = False
            .txtChassi.Enabled = False
            .cboCombustivel.Enabled = False
            .cboKitGas.Enabled = False
            .NumDPortas.Enabled = False
            .txtCor.Enabled = False
            .txtRenavan.Enabled = False
            .cboFinanciamento.Enabled = False
            .mskCNH.Enabled = False
            .mskAnoFrabric.Enabled = False
            .txtPrincCondut.Enabled = False
            DesbloqueiaNavegacao()
            .BtnCadastrar.Enabled = False
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .btnCancelar.Visible = False
            .PictureBox1.Enabled = False
        End With
    End Sub
    Public Sub BloqueiaNavegacao()
        With frmDadosVeiculo
            .btnPrimeiro.Enabled = False
            .btnVoltar.Enabled = False
            .btnIr.Enabled = False
            .btnUltimo.Enabled = False
            .btnAlterar.Enabled = False
            .btnExcluir.Enabled = False

        End With

    End Sub
    Public Sub DesbloqueiaNavegacao()
        With frmDadosVeiculo
            .btnPrimeiro.Enabled = True
            .btnVoltar.Enabled = True
            .btnIr.Enabled = True
            .btnUltimo.Enabled = True
            .BtnCadastrar.Enabled = True
            .btnAlterar.Enabled = True
            .btnExcluir.Enabled = True
            .BtLimpar.Enabled = True
            .btnCancelar.Enabled = True
            .btnImprimir.Visible = True
        End With

    End Sub
End Class
