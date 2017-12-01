<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDadosVeiculo
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDadosVeiculo))
        Me.LabelDescPag = New System.Windows.Forms.Label()
        Me.LabelFabricante = New System.Windows.Forms.Label()
        Me.LabelModelo = New System.Windows.Forms.Label()
        Me.LabelCor = New System.Windows.Forms.Label()
        Me.txtCor = New System.Windows.Forms.TextBox()
        Me.LabelPortas = New System.Windows.Forms.Label()
        Me.LabelCombustivel = New System.Windows.Forms.Label()
        Me.LabelKitGas = New System.Windows.Forms.Label()
        Me.cboKitGas = New System.Windows.Forms.ComboBox()
        Me.LabelPlaca = New System.Windows.Forms.Label()
        Me.mskPlaca = New System.Windows.Forms.MaskedTextBox()
        Me.LabelRenavan = New System.Windows.Forms.Label()
        Me.LabelChassi = New System.Windows.Forms.Label()
        Me.LabelFinanciamento = New System.Windows.Forms.Label()
        Me.cboFinanciamento = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPrimeiro = New System.Windows.Forms.ToolStripButton()
        Me.btnVoltar = New System.Windows.Forms.ToolStripButton()
        Me.btnIr = New System.Windows.Forms.ToolStripButton()
        Me.btnUltimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCadastrar = New System.Windows.Forms.ToolStripButton()
        Me.BtLimpar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.TabCtrlCadVeic = New System.Windows.Forms.TabControl()
        Me.TabDadosVeic = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboModelo = New System.Windows.Forms.ComboBox()
        Me.cboFabricante = New System.Windows.Forms.ComboBox()
        Me.cboPossuiSistemaAntiFurto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskAnoFrabric = New System.Windows.Forms.MaskedTextBox()
        Me.txtChassi = New System.Windows.Forms.MaskedTextBox()
        Me.txtRenavan = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCombustivel = New System.Windows.Forms.ComboBox()
        Me.NumDPortas = New System.Windows.Forms.NumericUpDown()
        Me.TabQuest = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboSeguradora = New System.Windows.Forms.ComboBox()
        Me.txtPrincCondut = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GpBoxShowCli = New System.Windows.Forms.GroupBox()
        Me.LblNomeShow = New System.Windows.Forms.Label()
        Me.LblGpBoxShowCli = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIDQuestonario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboSeguradProprietario = New System.Windows.Forms.ComboBox()
        Me.LabelSeguradora = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.mskKmMediaMensal = New System.Windows.Forms.MaskedTextBox()
        Me.mskCepDePerNoite = New System.Windows.Forms.MaskedTextBox()
        Me.LabelCepDePerNoite = New System.Windows.Forms.Label()
        Me.LabelKmMediaMensal = New System.Windows.Forms.Label()
        Me.LabelHouveSinistro = New System.Windows.Forms.Label()
        Me.NumQuantSinistr = New System.Windows.Forms.NumericUpDown()
        Me.NomeSegundoCondutor = New System.Windows.Forms.GroupBox()
        Me.cboUsoVeiculo = New System.Windows.Forms.ComboBox()
        Me.cboNoTrabalho = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelNoTrabalho = New System.Windows.Forms.Label()
        Me.cboNaEscola = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelNaEscola = New System.Windows.Forms.Label()
        Me.LabelDistAproxEmKmResidencia = New System.Windows.Forms.Label()
        Me.cboNaResidencia = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelNaResidencia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelPossuiGaragem = New System.Windows.Forms.Label()
        Me.mskCepTrabalho = New System.Windows.Forms.MaskedTextBox()
        Me.cboGaragemFechada = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboNoturno = New System.Windows.Forms.ComboBox()
        Me.cboVespertino = New System.Windows.Forms.ComboBox()
        Me.txtDistAproxEmKmResidencia = New System.Windows.Forms.TextBox()
        Me.cboMatutino = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboUtilizaVeiculoVisitas = New System.Windows.Forms.ComboBox()
        Me.LabelUtilizaVeiculoVisitas = New System.Windows.Forms.Label()
        Me.cboPrincCondutEstud = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskCNH = New System.Windows.Forms.MaskedTextBox()
        Me.LabelRelacaoCondutor = New System.Windows.Forms.Label()
        Me.numIdade = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelIdade = New System.Windows.Forms.Label()
        Me.numQuantos = New System.Windows.Forms.NumericUpDown()
        Me.LabelQuantos = New System.Windows.Forms.Label()
        Me.txtRelacaoCondutor = New System.Windows.Forms.TextBox()
        Me.cboPossuiFilhos = New System.Windows.Forms.ComboBox()
        Me.Label543 = New System.Windows.Forms.Label()
        Me.LabelPossuiFilhos = New System.Windows.Forms.Label()
        Me.mskDataNascSegCondut = New System.Windows.Forms.MaskedTextBox()
        Me.txtSegundoCondutor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtClasseDeBonus = New System.Windows.Forms.ComboBox()
        Me.LabelPrincipalCondutorReside = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPrincipalCondutorReside = New System.Windows.Forms.ComboBox()
        Me.cboRoubo = New System.Windows.Forms.ComboBox()
        Me.LabelResidemComCondutor = New System.Windows.Forms.Label()
        Me.cboResidemComCondutor = New System.Windows.Forms.ComboBox()
        Me.LabelClasseDeBonus = New System.Windows.Forms.Label()
        Me.LabelSexo = New System.Windows.Forms.Label()
        Me.LabelCpf = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.TabCtrlCadVeic.SuspendLayout()
        Me.TabDadosVeic.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumDPortas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabQuest.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBoxShowCli.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NumQuantSinistr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NomeSegundoCondutor.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.numIdade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQuantos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDescPag
        '
        Me.LabelDescPag.AutoSize = True
        Me.LabelDescPag.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescPag.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescPag.Location = New System.Drawing.Point(12, 9)
        Me.LabelDescPag.Name = "LabelDescPag"
        Me.LabelDescPag.Size = New System.Drawing.Size(125, 19)
        Me.LabelDescPag.TabIndex = 0
        Me.LabelDescPag.Text = "Dados do Veículo"
        '
        'LabelFabricante
        '
        Me.LabelFabricante.AutoSize = True
        Me.LabelFabricante.BackColor = System.Drawing.Color.Transparent
        Me.LabelFabricante.Location = New System.Drawing.Point(70, 51)
        Me.LabelFabricante.Name = "LabelFabricante"
        Me.LabelFabricante.Size = New System.Drawing.Size(72, 13)
        Me.LabelFabricante.TabIndex = 2
        Me.LabelFabricante.Text = "Fabricante:*"
        '
        'LabelModelo
        '
        Me.LabelModelo.AutoSize = True
        Me.LabelModelo.BackColor = System.Drawing.Color.Transparent
        Me.LabelModelo.Location = New System.Drawing.Point(283, 51)
        Me.LabelModelo.Name = "LabelModelo"
        Me.LabelModelo.Size = New System.Drawing.Size(55, 13)
        Me.LabelModelo.TabIndex = 4
        Me.LabelModelo.Text = "Modelo:*"
        '
        'LabelCor
        '
        Me.LabelCor.AutoSize = True
        Me.LabelCor.BackColor = System.Drawing.Color.Transparent
        Me.LabelCor.Location = New System.Drawing.Point(105, 157)
        Me.LabelCor.Name = "LabelCor"
        Me.LabelCor.Size = New System.Drawing.Size(37, 13)
        Me.LabelCor.TabIndex = 16
        Me.LabelCor.Text = "Cor:*"
        '
        'txtCor
        '
        Me.txtCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCor.Location = New System.Drawing.Point(157, 154)
        Me.txtCor.MaxLength = 15
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Size = New System.Drawing.Size(100, 20)
        Me.txtCor.TabIndex = 17
        '
        'LabelPortas
        '
        Me.LabelPortas.AutoSize = True
        Me.LabelPortas.BackColor = System.Drawing.Color.Transparent
        Me.LabelPortas.Location = New System.Drawing.Point(288, 157)
        Me.LabelPortas.Name = "LabelPortas"
        Me.LabelPortas.Size = New System.Drawing.Size(50, 13)
        Me.LabelPortas.TabIndex = 18
        Me.LabelPortas.Text = "Portas:*"
        '
        'LabelCombustivel
        '
        Me.LabelCombustivel.AutoSize = True
        Me.LabelCombustivel.BackColor = System.Drawing.Color.Transparent
        Me.LabelCombustivel.Location = New System.Drawing.Point(59, 118)
        Me.LabelCombustivel.Name = "LabelCombustivel"
        Me.LabelCombustivel.Size = New System.Drawing.Size(83, 13)
        Me.LabelCombustivel.TabIndex = 12
        Me.LabelCombustivel.Text = "Combustível:*"
        '
        'LabelKitGas
        '
        Me.LabelKitGas.AutoSize = True
        Me.LabelKitGas.BackColor = System.Drawing.Color.Transparent
        Me.LabelKitGas.Location = New System.Drawing.Point(282, 118)
        Me.LabelKitGas.Name = "LabelKitGas"
        Me.LabelKitGas.Size = New System.Drawing.Size(56, 13)
        Me.LabelKitGas.TabIndex = 14
        Me.LabelKitGas.Text = "Kit Gás:*"
        '
        'cboKitGas
        '
        Me.cboKitGas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKitGas.FormattingEnabled = True
        Me.cboKitGas.Items.AddRange(New Object() {"Selecione", "Sim", "Não"})
        Me.cboKitGas.Location = New System.Drawing.Point(352, 115)
        Me.cboKitGas.Name = "cboKitGas"
        Me.cboKitGas.Size = New System.Drawing.Size(99, 21)
        Me.cboKitGas.TabIndex = 15
        '
        'LabelPlaca
        '
        Me.LabelPlaca.AutoSize = True
        Me.LabelPlaca.BackColor = System.Drawing.Color.Transparent
        Me.LabelPlaca.Location = New System.Drawing.Point(97, 82)
        Me.LabelPlaca.Name = "LabelPlaca"
        Me.LabelPlaca.Size = New System.Drawing.Size(45, 13)
        Me.LabelPlaca.TabIndex = 8
        Me.LabelPlaca.Text = "Placa:*"
        '
        'mskPlaca
        '
        Me.mskPlaca.Location = New System.Drawing.Point(155, 79)
        Me.mskPlaca.Mask = ">LLL-0000"
        Me.mskPlaca.Name = "mskPlaca"
        Me.mskPlaca.Size = New System.Drawing.Size(62, 20)
        Me.mskPlaca.TabIndex = 9
        '
        'LabelRenavan
        '
        Me.LabelRenavan.AutoSize = True
        Me.LabelRenavan.BackColor = System.Drawing.Color.Transparent
        Me.LabelRenavan.Location = New System.Drawing.Point(276, 191)
        Me.LabelRenavan.Name = "LabelRenavan"
        Me.LabelRenavan.Size = New System.Drawing.Size(62, 13)
        Me.LabelRenavan.TabIndex = 22
        Me.LabelRenavan.Text = "Renavan:*"
        '
        'LabelChassi
        '
        Me.LabelChassi.AutoSize = True
        Me.LabelChassi.BackColor = System.Drawing.Color.Transparent
        Me.LabelChassi.Location = New System.Drawing.Point(291, 82)
        Me.LabelChassi.Name = "LabelChassi"
        Me.LabelChassi.Size = New System.Drawing.Size(47, 13)
        Me.LabelChassi.TabIndex = 10
        Me.LabelChassi.Text = "Chassi:"
        '
        'LabelFinanciamento
        '
        Me.LabelFinanciamento.AutoSize = True
        Me.LabelFinanciamento.BackColor = System.Drawing.Color.Transparent
        Me.LabelFinanciamento.Location = New System.Drawing.Point(48, 191)
        Me.LabelFinanciamento.Name = "LabelFinanciamento"
        Me.LabelFinanciamento.Size = New System.Drawing.Size(95, 13)
        Me.LabelFinanciamento.TabIndex = 20
        Me.LabelFinanciamento.Text = "Financiamento:*"
        '
        'cboFinanciamento
        '
        Me.cboFinanciamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFinanciamento.FormattingEnabled = True
        Me.cboFinanciamento.Items.AddRange(New Object() {"Selecione", "Quitado", "Financiado"})
        Me.cboFinanciamento.Location = New System.Drawing.Point(158, 188)
        Me.cboFinanciamento.MaxLength = 3
        Me.cboFinanciamento.Name = "cboFinanciamento"
        Me.cboFinanciamento.Size = New System.Drawing.Size(111, 21)
        Me.cboFinanciamento.TabIndex = 21
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrimeiro.Image = CType(resources.GetObject("btnPrimeiro.Image"), System.Drawing.Image)
        Me.btnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(68, 76)
        Me.btnPrimeiro.Text = "Voltar ao ultimo"
        Me.btnPrimeiro.ToolTipText = "Ir para o primeiro"
        '
        'btnVoltar
        '
        Me.btnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(68, 76)
        Me.btnVoltar.Text = "Voltar ao anterior"
        Me.btnVoltar.ToolTipText = "Voltar"
        '
        'btnIr
        '
        Me.btnIr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIr.Image = CType(resources.GetObject("btnIr.Image"), System.Drawing.Image)
        Me.btnIr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(68, 76)
        Me.btnIr.Text = "Ir ao proximo"
        Me.btnIr.ToolTipText = "Ir para o proximo"
        '
        'btnUltimo
        '
        Me.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(68, 76)
        Me.btnUltimo.Text = "Ir ao ultimo"
        Me.btnUltimo.ToolTipText = "Ir para o Ultimo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnPrimeiro, Me.btnVoltar, Me.btnIr, Me.btnUltimo, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.btnExcluir, Me.btnAlterar, Me.ToolStripSeparator4, Me.BtnCadastrar, Me.BtLimpar, Me.ToolStripSeparator5, Me.btnCancelar, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 581)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(1158, 79)
        Me.ToolStrip1.TabIndex = 97
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 79)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 79)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 79)
        '
        'btnExcluir
        '
        Me.btnExcluir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(68, 76)
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.ToolTipText = "Excluir"
        '
        'btnAlterar
        '
        Me.btnAlterar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(68, 76)
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.ToolTipText = "Alterar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 79)
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCadastrar.ForeColor = System.Drawing.Color.Black
        Me.BtnCadastrar.Image = Global.SeguroFacil.My.Resources.Resources.Botão
        Me.BtnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(68, 76)
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.ToolTipText = "Cadastrar"
        '
        'BtLimpar
        '
        Me.BtLimpar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtLimpar.Image = CType(resources.GetObject("BtLimpar.Image"), System.Drawing.Image)
        Me.BtLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtLimpar.Name = "BtLimpar"
        Me.BtLimpar.Size = New System.Drawing.Size(68, 76)
        Me.BtLimpar.Text = "Novo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 79)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(68, 76)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(68, 76)
        Me.btnImprimir.Text = "Imprimir"
        '
        'TabCtrlCadVeic
        '
        Me.TabCtrlCadVeic.Controls.Add(Me.TabDadosVeic)
        Me.TabCtrlCadVeic.Controls.Add(Me.TabQuest)
        Me.TabCtrlCadVeic.Location = New System.Drawing.Point(0, 31)
        Me.TabCtrlCadVeic.Name = "TabCtrlCadVeic"
        Me.TabCtrlCadVeic.SelectedIndex = 0
        Me.TabCtrlCadVeic.Size = New System.Drawing.Size(1147, 545)
        Me.TabCtrlCadVeic.TabIndex = 26
        '
        'TabDadosVeic
        '
        Me.TabDadosVeic.BackColor = System.Drawing.Color.White
        Me.TabDadosVeic.Controls.Add(Me.GroupBox1)
        Me.TabDadosVeic.Location = New System.Drawing.Point(4, 22)
        Me.TabDadosVeic.Name = "TabDadosVeic"
        Me.TabDadosVeic.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDadosVeic.Size = New System.Drawing.Size(1139, 519)
        Me.TabDadosVeic.TabIndex = 0
        Me.TabDadosVeic.Text = "Dados do Veiculo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboModelo)
        Me.GroupBox1.Controls.Add(Me.cboFabricante)
        Me.GroupBox1.Controls.Add(Me.cboPossuiSistemaAntiFurto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.mskAnoFrabric)
        Me.GroupBox1.Controls.Add(Me.txtChassi)
        Me.GroupBox1.Controls.Add(Me.txtRenavan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboCombustivel)
        Me.GroupBox1.Controls.Add(Me.NumDPortas)
        Me.GroupBox1.Controls.Add(Me.LabelKitGas)
        Me.GroupBox1.Controls.Add(Me.LabelFabricante)
        Me.GroupBox1.Controls.Add(Me.cboKitGas)
        Me.GroupBox1.Controls.Add(Me.LabelModelo)
        Me.GroupBox1.Controls.Add(Me.LabelCombustivel)
        Me.GroupBox1.Controls.Add(Me.LabelPlaca)
        Me.GroupBox1.Controls.Add(Me.cboFinanciamento)
        Me.GroupBox1.Controls.Add(Me.mskPlaca)
        Me.GroupBox1.Controls.Add(Me.LabelFinanciamento)
        Me.GroupBox1.Controls.Add(Me.LabelPortas)
        Me.GroupBox1.Controls.Add(Me.LabelRenavan)
        Me.GroupBox1.Controls.Add(Me.LabelChassi)
        Me.GroupBox1.Controls.Add(Me.txtCor)
        Me.GroupBox1.Controls.Add(Me.LabelCor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 265)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Veiculo"
        '
        'cboModelo
        '
        Me.cboModelo.FormattingEnabled = True
        Me.cboModelo.Location = New System.Drawing.Point(352, 47)
        Me.cboModelo.Name = "cboModelo"
        Me.cboModelo.Size = New System.Drawing.Size(121, 21)
        Me.cboModelo.TabIndex = 5
        '
        'cboFabricante
        '
        Me.cboFabricante.FormattingEnabled = True
        Me.cboFabricante.Location = New System.Drawing.Point(154, 47)
        Me.cboFabricante.Name = "cboFabricante"
        Me.cboFabricante.Size = New System.Drawing.Size(121, 21)
        Me.cboFabricante.TabIndex = 3
        '
        'cboPossuiSistemaAntiFurto
        '
        Me.cboPossuiSistemaAntiFurto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPossuiSistemaAntiFurto.FormattingEnabled = True
        Me.cboPossuiSistemaAntiFurto.Items.AddRange(New Object() {"Selecione", "Sim", "Não"})
        Me.cboPossuiSistemaAntiFurto.Location = New System.Drawing.Point(324, 233)
        Me.cboPossuiSistemaAntiFurto.Name = "cboPossuiSistemaAntiFurto"
        Me.cboPossuiSistemaAntiFurto.Size = New System.Drawing.Size(121, 21)
        Me.cboPossuiSistemaAntiFurto.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(501, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Ano de Fabricação:*"
        '
        'mskAnoFrabric
        '
        Me.mskAnoFrabric.Location = New System.Drawing.Point(631, 48)
        Me.mskAnoFrabric.Mask = "0000"
        Me.mskAnoFrabric.Name = "mskAnoFrabric"
        Me.mskAnoFrabric.Size = New System.Drawing.Size(46, 20)
        Me.mskAnoFrabric.TabIndex = 7
        '
        'txtChassi
        '
        Me.txtChassi.Location = New System.Drawing.Point(352, 79)
        Me.txtChassi.Mask = ">0LLLL00L0L0000000"
        Me.txtChassi.Name = "txtChassi"
        Me.txtChassi.Size = New System.Drawing.Size(177, 20)
        Me.txtChassi.TabIndex = 11
        '
        'txtRenavan
        '
        Me.txtRenavan.Location = New System.Drawing.Point(352, 188)
        Me.txtRenavan.Mask = "00000000000"
        Me.txtRenavan.Name = "txtRenavan"
        Me.txtRenavan.Size = New System.Drawing.Size(110, 20)
        Me.txtRenavan.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Possui Dispositivo Anti-Furto/Alarme/Rastreador:*"
        '
        'cboCombustivel
        '
        Me.cboCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCombustivel.FormattingEnabled = True
        Me.cboCombustivel.Items.AddRange(New Object() {"Selecione", "Etanol", "Diesel", "Gasolina", "Alcool", "Flex"})
        Me.cboCombustivel.Location = New System.Drawing.Point(156, 115)
        Me.cboCombustivel.Name = "cboCombustivel"
        Me.cboCombustivel.Size = New System.Drawing.Size(100, 21)
        Me.cboCombustivel.TabIndex = 13
        '
        'NumDPortas
        '
        Me.NumDPortas.Location = New System.Drawing.Point(352, 154)
        Me.NumDPortas.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumDPortas.Name = "NumDPortas"
        Me.NumDPortas.Size = New System.Drawing.Size(50, 20)
        Me.NumDPortas.TabIndex = 19
        Me.NumDPortas.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'TabQuest
        '
        Me.TabQuest.BackColor = System.Drawing.Color.White
        Me.TabQuest.Controls.Add(Me.GroupBox2)
        Me.TabQuest.Controls.Add(Me.GroupBox5)
        Me.TabQuest.Controls.Add(Me.NomeSegundoCondutor)
        Me.TabQuest.Controls.Add(Me.GroupBox4)
        Me.TabQuest.Controls.Add(Me.GroupBox3)
        Me.TabQuest.Controls.Add(Me.LabelSexo)
        Me.TabQuest.Controls.Add(Me.LabelCpf)
        Me.TabQuest.Location = New System.Drawing.Point(4, 22)
        Me.TabQuest.Name = "TabQuest"
        Me.TabQuest.Padding = New System.Windows.Forms.Padding(3)
        Me.TabQuest.Size = New System.Drawing.Size(1139, 519)
        Me.TabQuest.TabIndex = 1
        Me.TabQuest.Text = "Questionario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboSeguradora)
        Me.GroupBox2.Controls.Add(Me.txtPrincCondut)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.GpBoxShowCli)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtIDQuestonario)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cboSeguradProprietario)
        Me.GroupBox2.Controls.Add(Me.LabelSeguradora)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 149)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'cboSeguradora
        '
        Me.cboSeguradora.FormattingEnabled = True
        Me.cboSeguradora.Location = New System.Drawing.Point(263, 53)
        Me.cboSeguradora.Name = "cboSeguradora"
        Me.cboSeguradora.Size = New System.Drawing.Size(186, 21)
        Me.cboSeguradora.TabIndex = 34
        '
        'txtPrincCondut
        '
        Me.txtPrincCondut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrincCondut.Location = New System.Drawing.Point(263, 86)
        Me.txtPrincCondut.MaxLength = 75
        Me.txtPrincCondut.Name = "txtPrincCondut"
        Me.txtPrincCondut.Size = New System.Drawing.Size(304, 20)
        Me.txtPrincCondut.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 184
        Me.PictureBox1.TabStop = False
        '
        'GpBoxShowCli
        '
        Me.GpBoxShowCli.BackColor = System.Drawing.Color.Transparent
        Me.GpBoxShowCli.Controls.Add(Me.LblNomeShow)
        Me.GpBoxShowCli.Controls.Add(Me.LblGpBoxShowCli)
        Me.GpBoxShowCli.Location = New System.Drawing.Point(33, 12)
        Me.GpBoxShowCli.Name = "GpBoxShowCli"
        Me.GpBoxShowCli.Size = New System.Drawing.Size(279, 33)
        Me.GpBoxShowCli.TabIndex = 28
        Me.GpBoxShowCli.TabStop = False
        Me.GpBoxShowCli.Text = "Cliente:"
        '
        'LblNomeShow
        '
        Me.LblNomeShow.AutoSize = True
        Me.LblNomeShow.Location = New System.Drawing.Point(53, 17)
        Me.LblNomeShow.Name = "LblNomeShow"
        Me.LblNomeShow.Size = New System.Drawing.Size(0, 13)
        Me.LblNomeShow.TabIndex = 2
        '
        'LblGpBoxShowCli
        '
        Me.LblGpBoxShowCli.AutoSize = True
        Me.LblGpBoxShowCli.Location = New System.Drawing.Point(6, 16)
        Me.LblGpBoxShowCli.Name = "LblGpBoxShowCli"
        Me.LblGpBoxShowCli.Size = New System.Drawing.Size(41, 13)
        Me.LblGpBoxShowCli.TabIndex = 29
        Me.LblGpBoxShowCli.Text = "Nome:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(56, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(166, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Nome do Principal Condutor:*"
        '
        'txtIDQuestonario
        '
        Me.txtIDQuestonario.Enabled = False
        Me.txtIDQuestonario.Location = New System.Drawing.Point(528, 30)
        Me.txtIDQuestonario.MaxLength = 75
        Me.txtIDQuestonario.Name = "txtIDQuestonario"
        Me.txtIDQuestonario.Size = New System.Drawing.Size(39, 20)
        Me.txtIDQuestonario.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(397, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ID do questionario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(12, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Segurado é o proprietario do veiculo:*"
        '
        'cboSeguradProprietario
        '
        Me.cboSeguradProprietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeguradProprietario.FormattingEnabled = True
        Me.cboSeguradProprietario.Items.AddRange(New Object() {"Selecione", "Sim", "Não"})
        Me.cboSeguradProprietario.Location = New System.Drawing.Point(263, 112)
        Me.cboSeguradProprietario.MaxLength = 3
        Me.cboSeguradProprietario.Name = "cboSeguradProprietario"
        Me.cboSeguradProprietario.Size = New System.Drawing.Size(103, 21)
        Me.cboSeguradProprietario.TabIndex = 38
        '
        'LabelSeguradora
        '
        Me.LabelSeguradora.AutoSize = True
        Me.LabelSeguradora.BackColor = System.Drawing.Color.Transparent
        Me.LabelSeguradora.Location = New System.Drawing.Point(161, 59)
        Me.LabelSeguradora.Name = "LabelSeguradora"
        Me.LabelSeguradora.Size = New System.Drawing.Size(77, 13)
        Me.LabelSeguradora.TabIndex = 33
        Me.LabelSeguradora.Text = "Seguradora:*"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.mskKmMediaMensal)
        Me.GroupBox5.Controls.Add(Me.mskCepDePerNoite)
        Me.GroupBox5.Controls.Add(Me.LabelCepDePerNoite)
        Me.GroupBox5.Controls.Add(Me.LabelKmMediaMensal)
        Me.GroupBox5.Controls.Add(Me.LabelHouveSinistro)
        Me.GroupBox5.Controls.Add(Me.NumQuantSinistr)
        Me.GroupBox5.Location = New System.Drawing.Point(627, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(499, 149)
        Me.GroupBox5.TabIndex = 65
        Me.GroupBox5.TabStop = False
        '
        'mskKmMediaMensal
        '
        Me.mskKmMediaMensal.Location = New System.Drawing.Point(385, 50)
        Me.mskKmMediaMensal.Mask = "000000"
        Me.mskKmMediaMensal.Name = "mskKmMediaMensal"
        Me.mskKmMediaMensal.Size = New System.Drawing.Size(51, 20)
        Me.mskKmMediaMensal.TabIndex = 69
        '
        'mskCepDePerNoite
        '
        Me.mskCepDePerNoite.Location = New System.Drawing.Point(163, 80)
        Me.mskCepDePerNoite.Mask = "00000-000"
        Me.mskCepDePerNoite.Name = "mskCepDePerNoite"
        Me.mskCepDePerNoite.Size = New System.Drawing.Size(70, 20)
        Me.mskCepDePerNoite.TabIndex = 71
        '
        'LabelCepDePerNoite
        '
        Me.LabelCepDePerNoite.AutoSize = True
        Me.LabelCepDePerNoite.BackColor = System.Drawing.Color.Transparent
        Me.LabelCepDePerNoite.Location = New System.Drawing.Point(38, 86)
        Me.LabelCepDePerNoite.Name = "LabelCepDePerNoite"
        Me.LabelCepDePerNoite.Size = New System.Drawing.Size(101, 13)
        Me.LabelCepDePerNoite.TabIndex = 70
        Me.LabelCepDePerNoite.Text = "CEP de Pernoite:*"
        '
        'LabelKmMediaMensal
        '
        Me.LabelKmMediaMensal.AutoSize = True
        Me.LabelKmMediaMensal.BackColor = System.Drawing.Color.Transparent
        Me.LabelKmMediaMensal.Location = New System.Drawing.Point(255, 53)
        Me.LabelKmMediaMensal.Name = "LabelKmMediaMensal"
        Me.LabelKmMediaMensal.Size = New System.Drawing.Size(111, 13)
        Me.LabelKmMediaMensal.TabIndex = 68
        Me.LabelKmMediaMensal.Text = "Km Média Mensal:*"
        '
        'LabelHouveSinistro
        '
        Me.LabelHouveSinistro.AutoSize = True
        Me.LabelHouveSinistro.BackColor = System.Drawing.Color.Transparent
        Me.LabelHouveSinistro.Location = New System.Drawing.Point(6, 56)
        Me.LabelHouveSinistro.Name = "LabelHouveSinistro"
        Me.LabelHouveSinistro.Size = New System.Drawing.Size(133, 13)
        Me.LabelHouveSinistro.TabIndex = 66
        Me.LabelHouveSinistro.Text = "Quantdade de sinistro:*"
        '
        'NumQuantSinistr
        '
        Me.NumQuantSinistr.Location = New System.Drawing.Point(163, 51)
        Me.NumQuantSinistr.Name = "NumQuantSinistr"
        Me.NumQuantSinistr.Size = New System.Drawing.Size(86, 20)
        Me.NumQuantSinistr.TabIndex = 67
        '
        'NomeSegundoCondutor
        '
        Me.NomeSegundoCondutor.Controls.Add(Me.cboUsoVeiculo)
        Me.NomeSegundoCondutor.Controls.Add(Me.cboNoTrabalho)
        Me.NomeSegundoCondutor.Controls.Add(Me.Label3)
        Me.NomeSegundoCondutor.Controls.Add(Me.LabelNoTrabalho)
        Me.NomeSegundoCondutor.Controls.Add(Me.cboNaEscola)
        Me.NomeSegundoCondutor.Controls.Add(Me.Label14)
        Me.NomeSegundoCondutor.Controls.Add(Me.LabelNaEscola)
        Me.NomeSegundoCondutor.Controls.Add(Me.LabelDistAproxEmKmResidencia)
        Me.NomeSegundoCondutor.Controls.Add(Me.cboNaResidencia)
        Me.NomeSegundoCondutor.Controls.Add(Me.Label13)
        Me.NomeSegundoCondutor.Controls.Add(Me.LabelNaResidencia)
        Me.NomeSegundoCondutor.Controls.Add(Me.Label12)
        Me.NomeSegundoCondutor.Controls.Add(Me.LabelPossuiGaragem)
        Me.NomeSegundoCondutor.Controls.Add(Me.mskCepTrabalho)
        Me.NomeSegundoCondutor.Controls.Add(Me.cboGaragemFechada)
        Me.NomeSegundoCondutor.Controls.Add(Me.Label10)
        Me.NomeSegundoCondutor.Controls.Add(Me.cboNoturno)
        Me.NomeSegundoCondutor.Controls.Add(Me.cboVespertino)
        Me.NomeSegundoCondutor.Controls.Add(Me.txtDistAproxEmKmResidencia)
        Me.NomeSegundoCondutor.Controls.Add(Me.cboMatutino)
        Me.NomeSegundoCondutor.Controls.Add(Me.Label11)
        Me.NomeSegundoCondutor.Controls.Add(Me.cboUtilizaVeiculoVisitas)
        Me.NomeSegundoCondutor.Controls.Add(Me.LabelUtilizaVeiculoVisitas)
        Me.NomeSegundoCondutor.Controls.Add(Me.cboPrincCondutEstud)
        Me.NomeSegundoCondutor.Location = New System.Drawing.Point(627, 160)
        Me.NomeSegundoCondutor.Name = "NomeSegundoCondutor"
        Me.NomeSegundoCondutor.Size = New System.Drawing.Size(499, 351)
        Me.NomeSegundoCondutor.TabIndex = 72
        Me.NomeSegundoCondutor.TabStop = False
        '
        'cboUsoVeiculo
        '
        Me.cboUsoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsoVeiculo.FormattingEnabled = True
        Me.cboUsoVeiculo.Items.AddRange(New Object() {"Selecione", "Todos", "Trabalho", "Estudo", "Lazer", "Outros"})
        Me.cboUsoVeiculo.Location = New System.Drawing.Point(269, 15)
        Me.cboUsoVeiculo.MaxLength = 15
        Me.cboUsoVeiculo.Name = "cboUsoVeiculo"
        Me.cboUsoVeiculo.Size = New System.Drawing.Size(156, 21)
        Me.cboUsoVeiculo.TabIndex = 74
        '
        'cboNoTrabalho
        '
        Me.cboNoTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNoTrabalho.FormattingEnabled = True
        Me.cboNoTrabalho.Items.AddRange(New Object() {"Selecione", "Sim", "Não"})
        Me.cboNoTrabalho.Location = New System.Drawing.Point(177, 219)
        Me.cboNoTrabalho.MaxLength = 3
        Me.cboNoTrabalho.Name = "cboNoTrabalho"
        Me.cboNoTrabalho.Size = New System.Drawing.Size(76, 21)
        Me.cboNoTrabalho.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(111, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Uso do Veiculo:*"
        '
        'LabelNoTrabalho
        '
        Me.LabelNoTrabalho.AutoSize = True
        Me.LabelNoTrabalho.BackColor = System.Drawing.Color.Transparent
        Me.LabelNoTrabalho.Location = New System.Drawing.Point(68, 222)
        Me.LabelNoTrabalho.Name = "LabelNoTrabalho"
        Me.LabelNoTrabalho.Size = New System.Drawing.Size(73, 13)
        Me.LabelNoTrabalho.TabIndex = 87
        Me.LabelNoTrabalho.Text = "No Trabalho:"
        '
        'cboNaEscola
        '
        Me.cboNaEscola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNaEscola.FormattingEnabled = True
        Me.cboNaEscola.Items.AddRange(New Object() {"Selecione", "Sim", "Não"})
        Me.cboNaEscola.Location = New System.Drawing.Point(468, 179)
        Me.cboNaEscola.MaxLength = 3
        Me.cboNaEscola.Name = "cboNaEscola"
        Me.cboNaEscola.Size = New System.Drawing.Size(61, 21)
        Me.cboNaEscola.TabIndex = 86
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(359, 289)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Noturno:"
        '
        'LabelNaEscola
        '
        Me.LabelNaEscola.AutoSize = True
        Me.LabelNaEscola.BackColor = System.Drawing.Color.Transparent
        Me.LabelNaEscola.Location = New System.Drawing.Point(399, 182)
        Me.LabelNaEscola.Name = "LabelNaEscola"
        Me.LabelNaEscola.Size = New System.Drawing.Size(60, 13)
        Me.LabelNaEscola.TabIndex = 85
        Me.LabelNaEscola.Text = "Na Escola:"
        '
        'LabelDistAproxEmKmResidencia
        '
        Me.LabelDistAproxEmKmResidencia.AutoSize = True
        Me.LabelDistAproxEmKmResidencia.BackColor = System.Drawing.Color.Transparent
        Me.LabelDistAproxEmKmResidencia.Location = New System.Drawing.Point(6, 81)
        Me.LabelDistAproxEmKmResidencia.Name = "LabelDistAproxEmKmResidencia"
        Me.LabelDistAproxEmKmResidencia.Size = New System.Drawing.Size(324, 13)
        Me.LabelDistAproxEmKmResidencia.TabIndex = 77
        Me.LabelDistAproxEmKmResidencia.Text = "Distância Aproximada da Residência até o Trabalho (Em Km):"
        '
        'cboNaResidencia
        '
        Me.cboNaResidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNaResidencia.FormattingEnabled = True
        Me.cboNaResidencia.Items.AddRange(New Object() {"Selecione", "Sim c/ Portão Automático", "Sim c/ Portão Manual", "Não"})
        Me.cboNaResidencia.Location = New System.Drawing.Point(177, 179)
        Me.cboNaResidencia.MaxLength = 40
        Me.cboNaResidencia.Name = "cboNaResidencia"
        Me.cboNaResidencia.Size = New System.Drawing.Size(209, 21)
        Me.cboNaResidencia.TabIndex = 84
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(182, 289)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Vespertino:"
        '
        'LabelNaResidencia
        '
        Me.LabelNaResidencia.AutoSize = True
        Me.LabelNaResidencia.BackColor = System.Drawing.Color.Transparent
        Me.LabelNaResidencia.Location = New System.Drawing.Point(56, 182)
        Me.LabelNaResidencia.Name = "LabelNaResidencia"
        Me.LabelNaResidencia.Size = New System.Drawing.Size(85, 13)
        Me.LabelNaResidencia.TabIndex = 83
        Me.LabelNaResidencia.Text = "Na Residência:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(6, 289)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Matutino:"
        '
        'LabelPossuiGaragem
        '
        Me.LabelPossuiGaragem.AutoSize = True
        Me.LabelPossuiGaragem.BackColor = System.Drawing.Color.Transparent
        Me.LabelPossuiGaragem.Location = New System.Drawing.Point(36, 137)
        Me.LabelPossuiGaragem.Name = "LabelPossuiGaragem"
        Me.LabelPossuiGaragem.Size = New System.Drawing.Size(310, 13)
        Me.LabelPossuiGaragem.TabIndex = 81
        Me.LabelPossuiGaragem.Text = "Possui Garagem ou Estacionamento Fechado para Veículo:"
        '
        'mskCepTrabalho
        '
        Me.mskCepTrabalho.Location = New System.Drawing.Point(402, 104)
        Me.mskCepTrabalho.Mask = "00000-000"
        Me.mskCepTrabalho.Name = "mskCepTrabalho"
        Me.mskCepTrabalho.Size = New System.Drawing.Size(70, 20)
        Me.mskCepTrabalho.TabIndex = 80
        '
        'cboGaragemFechada
        '
        Me.cboGaragemFechada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGaragemFechada.FormattingEnabled = True
        Me.cboGaragemFechada.Items.AddRange(New Object() {"Selecione", "Não", "Sim"})
        Me.cboGaragemFechada.Location = New System.Drawing.Point(402, 133)
        Me.cboGaragemFechada.MaxLength = 3
        Me.cboGaragemFechada.Name = "cboGaragemFechada"
        Me.cboGaragemFechada.Size = New System.Drawing.Size(117, 21)
        Me.cboGaragemFechada.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(251, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "CEP do Trabalho:"
        '
        'cboNoturno
        '
        Me.cboNoturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNoturno.FormattingEnabled = True
        Me.cboNoturno.Items.AddRange(New Object() {"Selecione", "Sim", "Não"})
        Me.cboNoturno.Location = New System.Drawing.Point(428, 286)
        Me.cboNoturno.MaxLength = 3
        Me.cboNoturno.Name = "cboNoturno"
        Me.cboNoturno.Size = New System.Drawing.Size(117, 21)
        Me.cboNoturno.TabIndex = 96
        '
        'cboVespertino
        '
        Me.cboVespertino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVespertino.FormattingEnabled = True
        Me.cboVespertino.Items.AddRange(New Object() {"Selecione", "Sim", "Não"})
        Me.cboVespertino.Location = New System.Drawing.Point(268, 286)
        Me.cboVespertino.MaxLength = 3
        Me.cboVespertino.Name = "cboVespertino"
        Me.cboVespertino.Size = New System.Drawing.Size(71, 21)
        Me.cboVespertino.TabIndex = 94
        '
        'txtDistAproxEmKmResidencia
        '
        Me.txtDistAproxEmKmResidencia.Location = New System.Drawing.Point(402, 78)
        Me.txtDistAproxEmKmResidencia.MaxLength = 5
        Me.txtDistAproxEmKmResidencia.Name = "txtDistAproxEmKmResidencia"
        Me.txtDistAproxEmKmResidencia.Size = New System.Drawing.Size(51, 20)
        Me.txtDistAproxEmKmResidencia.TabIndex = 78
        '
        'cboMatutino
        '
        Me.cboMatutino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMatutino.FormattingEnabled = True
        Me.cboMatutino.Items.AddRange(New Object() {"Selecione", "Sim", "Não"})
        Me.cboMatutino.Location = New System.Drawing.Point(80, 286)
        Me.cboMatutino.MaxLength = 3
        Me.cboMatutino.Name = "cboMatutino"
        Me.cboMatutino.Size = New System.Drawing.Size(81, 21)
        Me.cboMatutino.TabIndex = 92
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(6, 254)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 13)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Principal condutor estuda:"
        '
        'cboUtilizaVeiculoVisitas
        '
        Me.cboUtilizaVeiculoVisitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUtilizaVeiculoVisitas.FormattingEnabled = True
        Me.cboUtilizaVeiculoVisitas.Items.AddRange(New Object() {"Selecione", "Sim", "Não"})
        Me.cboUtilizaVeiculoVisitas.Location = New System.Drawing.Point(402, 46)
        Me.cboUtilizaVeiculoVisitas.MaxLength = 3
        Me.cboUtilizaVeiculoVisitas.Name = "cboUtilizaVeiculoVisitas"
        Me.cboUtilizaVeiculoVisitas.Size = New System.Drawing.Size(110, 21)
        Me.cboUtilizaVeiculoVisitas.TabIndex = 76
        '
        'LabelUtilizaVeiculoVisitas
        '
        Me.LabelUtilizaVeiculoVisitas.AutoSize = True
        Me.LabelUtilizaVeiculoVisitas.BackColor = System.Drawing.Color.Transparent
        Me.LabelUtilizaVeiculoVisitas.Location = New System.Drawing.Point(6, 49)
        Me.LabelUtilizaVeiculoVisitas.Name = "LabelUtilizaVeiculoVisitas"
        Me.LabelUtilizaVeiculoVisitas.Size = New System.Drawing.Size(340, 13)
        Me.LabelUtilizaVeiculoVisitas.TabIndex = 75
        Me.LabelUtilizaVeiculoVisitas.Text = "Utiliza o Veículo para Fazer Visitas à Clientes ou Fornecedores:"
        '
        'cboPrincCondutEstud
        '
        Me.cboPrincCondutEstud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrincCondutEstud.FormattingEnabled = True
        Me.cboPrincCondutEstud.Items.AddRange(New Object() {"Selecione", "Não", "Sim"})
        Me.cboPrincCondutEstud.Location = New System.Drawing.Point(177, 251)
        Me.cboPrincCondutEstud.MaxLength = 3
        Me.cboPrincCondutEstud.Name = "cboPrincCondutEstud"
        Me.cboPrincCondutEstud.Size = New System.Drawing.Size(117, 21)
        Me.cboPrincCondutEstud.TabIndex = 90
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.mskCNH)
        Me.GroupBox4.Controls.Add(Me.LabelRelacaoCondutor)
        Me.GroupBox4.Controls.Add(Me.numIdade)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.LabelIdade)
        Me.GroupBox4.Controls.Add(Me.numQuantos)
        Me.GroupBox4.Controls.Add(Me.LabelQuantos)
        Me.GroupBox4.Controls.Add(Me.txtRelacaoCondutor)
        Me.GroupBox4.Controls.Add(Me.cboPossuiFilhos)
        Me.GroupBox4.Controls.Add(Me.Label543)
        Me.GroupBox4.Controls.Add(Me.LabelPossuiFilhos)
        Me.GroupBox4.Controls.Add(Me.mskDataNascSegCondut)
        Me.GroupBox4.Controls.Add(Me.txtSegundoCondutor)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cboSexo)
        Me.GroupBox4.Location = New System.Drawing.Point(35, 160)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(582, 216)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(439, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "CNH:"
        '
        'mskCNH
        '
        Me.mskCNH.Location = New System.Drawing.Point(482, 158)
        Me.mskCNH.Mask = "00000000000"
        Me.mskCNH.Name = "mskCNH"
        Me.mskCNH.Size = New System.Drawing.Size(83, 20)
        Me.mskCNH.TabIndex = 55
        '
        'LabelRelacaoCondutor
        '
        Me.LabelRelacaoCondutor.AutoSize = True
        Me.LabelRelacaoCondutor.BackColor = System.Drawing.Color.Transparent
        Me.LabelRelacaoCondutor.Location = New System.Drawing.Point(0, 23)
        Me.LabelRelacaoCondutor.Name = "LabelRelacaoCondutor"
        Me.LabelRelacaoCondutor.Size = New System.Drawing.Size(256, 13)
        Me.LabelRelacaoCondutor.TabIndex = 40
        Me.LabelRelacaoCondutor.Text = "Relação do Principal Condutor com o Segurado:"
        '
        'numIdade
        '
        Me.numIdade.Enabled = False
        Me.numIdade.Location = New System.Drawing.Point(319, 158)
        Me.numIdade.Maximum = New Decimal(New Integer() {17, 0, 0, 0})
        Me.numIdade.Name = "numIdade"
        Me.numIdade.Size = New System.Drawing.Size(49, 20)
        Me.numIdade.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(440, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Sexo:"
        '
        'LabelIdade
        '
        Me.LabelIdade.AutoSize = True
        Me.LabelIdade.BackColor = System.Drawing.Color.Transparent
        Me.LabelIdade.Location = New System.Drawing.Point(213, 160)
        Me.LabelIdade.Name = "LabelIdade"
        Me.LabelIdade.Size = New System.Drawing.Size(74, 13)
        Me.LabelIdade.TabIndex = 52
        Me.LabelIdade.Text = "Idade Média:"
        '
        'numQuantos
        '
        Me.numQuantos.Enabled = False
        Me.numQuantos.Location = New System.Drawing.Point(482, 127)
        Me.numQuantos.Name = "numQuantos"
        Me.numQuantos.Size = New System.Drawing.Size(52, 20)
        Me.numQuantos.TabIndex = 51
        '
        'LabelQuantos
        '
        Me.LabelQuantos.AutoSize = True
        Me.LabelQuantos.BackColor = System.Drawing.Color.Transparent
        Me.LabelQuantos.Location = New System.Drawing.Point(420, 129)
        Me.LabelQuantos.Name = "LabelQuantos"
        Me.LabelQuantos.Size = New System.Drawing.Size(56, 13)
        Me.LabelQuantos.TabIndex = 50
        Me.LabelQuantos.Text = "Quantos:"
        '
        'txtRelacaoCondutor
        '
        Me.txtRelacaoCondutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRelacaoCondutor.Location = New System.Drawing.Point(319, 20)
        Me.txtRelacaoCondutor.MaxLength = 20
        Me.txtRelacaoCondutor.Name = "txtRelacaoCondutor"
        Me.txtRelacaoCondutor.Size = New System.Drawing.Size(130, 20)
        Me.txtRelacaoCondutor.TabIndex = 41
        '
        'cboPossuiFilhos
        '
        Me.cboPossuiFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPossuiFilhos.FormattingEnabled = True
        Me.cboPossuiFilhos.Items.AddRange(New Object() {"Selecione", "Não", "Sim"})
        Me.cboPossuiFilhos.Location = New System.Drawing.Point(319, 125)
        Me.cboPossuiFilhos.MaxLength = 3
        Me.cboPossuiFilhos.Name = "cboPossuiFilhos"
        Me.cboPossuiFilhos.Size = New System.Drawing.Size(95, 21)
        Me.cboPossuiFilhos.TabIndex = 49
        '
        'Label543
        '
        Me.Label543.AutoSize = True
        Me.Label543.BackColor = System.Drawing.Color.Transparent
        Me.Label543.Location = New System.Drawing.Point(64, 93)
        Me.Label543.Name = "Label543"
        Me.Label543.Size = New System.Drawing.Size(200, 13)
        Me.Label543.TabIndex = 44
        Me.Label543.Text = "Data Nascimento Segundo Condutor:"
        '
        'LabelPossuiFilhos
        '
        Me.LabelPossuiFilhos.AutoSize = True
        Me.LabelPossuiFilhos.BackColor = System.Drawing.Color.Transparent
        Me.LabelPossuiFilhos.Location = New System.Drawing.Point(52, 128)
        Me.LabelPossuiFilhos.Name = "LabelPossuiFilhos"
        Me.LabelPossuiFilhos.Size = New System.Drawing.Size(212, 13)
        Me.LabelPossuiFilhos.TabIndex = 48
        Me.LabelPossuiFilhos.Text = "Possui Filhos Ou Enteados Até 17 Anos:"
        '
        'mskDataNascSegCondut
        '
        Me.mskDataNascSegCondut.Location = New System.Drawing.Point(319, 90)
        Me.mskDataNascSegCondut.Mask = "00/00/0000"
        Me.mskDataNascSegCondut.Name = "mskDataNascSegCondut"
        Me.mskDataNascSegCondut.Size = New System.Drawing.Size(73, 20)
        Me.mskDataNascSegCondut.TabIndex = 45
        Me.mskDataNascSegCondut.ValidatingType = GetType(Date)
        '
        'txtSegundoCondutor
        '
        Me.txtSegundoCondutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSegundoCondutor.Location = New System.Drawing.Point(319, 51)
        Me.txtSegundoCondutor.MaxLength = 75
        Me.txtSegundoCondutor.Name = "txtSegundoCondutor"
        Me.txtSegundoCondutor.Size = New System.Drawing.Size(306, 20)
        Me.txtSegundoCondutor.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(113, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nome do Segundo Condutor:"
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"", "Selecione", "Masculino", "Feminino"})
        Me.cboSexo.Location = New System.Drawing.Point(482, 90)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(108, 21)
        Me.cboSexo.TabIndex = 47
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtClasseDeBonus)
        Me.GroupBox3.Controls.Add(Me.LabelPrincipalCondutorReside)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cboPrincipalCondutorReside)
        Me.GroupBox3.Controls.Add(Me.cboRoubo)
        Me.GroupBox3.Controls.Add(Me.LabelResidemComCondutor)
        Me.GroupBox3.Controls.Add(Me.cboResidemComCondutor)
        Me.GroupBox3.Controls.Add(Me.LabelClasseDeBonus)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 382)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(582, 129)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        '
        'txtClasseDeBonus
        '
        Me.txtClasseDeBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtClasseDeBonus.FormattingEnabled = True
        Me.txtClasseDeBonus.Items.AddRange(New Object() {"Selecione", "0", "1", "2", "3", "4", "5"})
        Me.txtClasseDeBonus.Location = New System.Drawing.Point(570, 94)
        Me.txtClasseDeBonus.Name = "txtClasseDeBonus"
        Me.txtClasseDeBonus.Size = New System.Drawing.Size(103, 21)
        Me.txtClasseDeBonus.TabIndex = 64
        '
        'LabelPrincipalCondutorReside
        '
        Me.LabelPrincipalCondutorReside.AutoSize = True
        Me.LabelPrincipalCondutorReside.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrincipalCondutorReside.Location = New System.Drawing.Point(118, 27)
        Me.LabelPrincipalCondutorReside.Name = "LabelPrincipalCondutorReside"
        Me.LabelPrincipalCondutorReside.Size = New System.Drawing.Size(188, 13)
        Me.LabelPrincipalCondutorReside.TabIndex = 57
        Me.LabelPrincipalCondutorReside.Text = "O Principal Condutor Reside Em:*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(105, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Vitima de roubo nos ultimos 2 anos:*"
        '
        'cboPrincipalCondutorReside
        '
        Me.cboPrincipalCondutorReside.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrincipalCondutorReside.FormattingEnabled = True
        Me.cboPrincipalCondutorReside.Items.AddRange(New Object() {"Selecione", "Casa/Sobrado", "Condominio Fechado", "Apartamento / Flat", "Chácara / Fazenda / Sitio", "Outros", "Não Informado"})
        Me.cboPrincipalCondutorReside.Location = New System.Drawing.Point(346, 24)
        Me.cboPrincipalCondutorReside.MaxLength = 40
        Me.cboPrincipalCondutorReside.Name = "cboPrincipalCondutorReside"
        Me.cboPrincipalCondutorReside.Size = New System.Drawing.Size(219, 21)
        Me.cboPrincipalCondutorReside.TabIndex = 58
        '
        'cboRoubo
        '
        Me.cboRoubo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoubo.FormattingEnabled = True
        Me.cboRoubo.Items.AddRange(New Object() {"Selecione", "Não", "Sim"})
        Me.cboRoubo.Location = New System.Drawing.Point(346, 94)
        Me.cboRoubo.MaxLength = 3
        Me.cboRoubo.Name = "cboRoubo"
        Me.cboRoubo.Size = New System.Drawing.Size(103, 21)
        Me.cboRoubo.TabIndex = 62
        '
        'LabelResidemComCondutor
        '
        Me.LabelResidemComCondutor.AutoSize = True
        Me.LabelResidemComCondutor.BackColor = System.Drawing.Color.Transparent
        Me.LabelResidemComCondutor.Location = New System.Drawing.Point(3, 62)
        Me.LabelResidemComCondutor.Name = "LabelResidemComCondutor"
        Me.LabelResidemComCondutor.Size = New System.Drawing.Size(291, 13)
        Me.LabelResidemComCondutor.TabIndex = 59
        Me.LabelResidemComCondutor.Text = "Residem com o Condutor, Pessoas entre 18 e 25 Anos:*"
        '
        'cboResidemComCondutor
        '
        Me.cboResidemComCondutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResidemComCondutor.FormattingEnabled = True
        Me.cboResidemComCondutor.Items.AddRange(New Object() {"Selecione", "Não", "Sim e não utiliza o veículo", "Sim e utiliza veículo 15% do tempo"})
        Me.cboResidemComCondutor.Location = New System.Drawing.Point(346, 59)
        Me.cboResidemComCondutor.MaxLength = 50
        Me.cboResidemComCondutor.Name = "cboResidemComCondutor"
        Me.cboResidemComCondutor.Size = New System.Drawing.Size(240, 21)
        Me.cboResidemComCondutor.TabIndex = 60
        '
        'LabelClasseDeBonus
        '
        Me.LabelClasseDeBonus.AutoSize = True
        Me.LabelClasseDeBonus.BackColor = System.Drawing.Color.Transparent
        Me.LabelClasseDeBonus.Location = New System.Drawing.Point(454, 97)
        Me.LabelClasseDeBonus.Name = "LabelClasseDeBonus"
        Me.LabelClasseDeBonus.Size = New System.Drawing.Size(103, 13)
        Me.LabelClasseDeBonus.TabIndex = 63
        Me.LabelClasseDeBonus.Text = "Classe de Bônus:*"
        '
        'LabelSexo
        '
        Me.LabelSexo.AutoSize = True
        Me.LabelSexo.BackColor = System.Drawing.Color.Transparent
        Me.LabelSexo.Location = New System.Drawing.Point(-93, 300)
        Me.LabelSexo.Name = "LabelSexo"
        Me.LabelSexo.Size = New System.Drawing.Size(36, 13)
        Me.LabelSexo.TabIndex = 113
        Me.LabelSexo.Text = "Sexo:"
        '
        'LabelCpf
        '
        Me.LabelCpf.AutoSize = True
        Me.LabelCpf.BackColor = System.Drawing.Color.Transparent
        Me.LabelCpf.Location = New System.Drawing.Point(-93, 266)
        Me.LabelCpf.Name = "LabelCpf"
        Me.LabelCpf.Size = New System.Drawing.Size(33, 13)
        Me.LabelCpf.TabIndex = 107
        Me.LabelCpf.Text = "CPF:"
        '
        'frmDadosVeiculo
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 660)
        Me.Controls.Add(Me.TabCtrlCadVeic)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LabelDescPag)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDadosVeiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Cadastro de Veículo ="
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabCtrlCadVeic.ResumeLayout(False)
        Me.TabDadosVeic.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumDPortas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabQuest.ResumeLayout(False)
        Me.TabQuest.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBoxShowCli.ResumeLayout(False)
        Me.GpBoxShowCli.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NumQuantSinistr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NomeSegundoCondutor.ResumeLayout(False)
        Me.NomeSegundoCondutor.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.numIdade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQuantos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDescPag As System.Windows.Forms.Label
    Friend WithEvents LabelFabricante As System.Windows.Forms.Label
    Friend WithEvents LabelModelo As System.Windows.Forms.Label
    Friend WithEvents LabelCor As System.Windows.Forms.Label
    Friend WithEvents txtCor As System.Windows.Forms.TextBox
    Friend WithEvents LabelPortas As System.Windows.Forms.Label
    Friend WithEvents LabelCombustivel As System.Windows.Forms.Label
    Friend WithEvents LabelKitGas As System.Windows.Forms.Label
    Friend WithEvents cboKitGas As System.Windows.Forms.ComboBox
    Friend WithEvents LabelPlaca As System.Windows.Forms.Label
    Friend WithEvents mskPlaca As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelRenavan As System.Windows.Forms.Label
    Friend WithEvents LabelChassi As System.Windows.Forms.Label
    Friend WithEvents LabelFinanciamento As System.Windows.Forms.Label
    Friend WithEvents cboFinanciamento As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnPrimeiro As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnVoltar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnIr As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCadastrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtLimpar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabCtrlCadVeic As System.Windows.Forms.TabControl
    Friend WithEvents TabDadosVeic As System.Windows.Forms.TabPage
    Friend WithEvents TabQuest As System.Windows.Forms.TabPage
    Friend WithEvents LabelSexo As System.Windows.Forms.Label
    Friend WithEvents LabelCpf As System.Windows.Forms.Label
    Friend WithEvents NumDPortas As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCombustivel As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtChassi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRenavan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mskAnoFrabric As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboPossuiSistemaAntiFurto As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrincCondut As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GpBoxShowCli As System.Windows.Forms.GroupBox
    Friend WithEvents LblNomeShow As System.Windows.Forms.Label
    Friend WithEvents LblGpBoxShowCli As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtIDQuestonario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboSeguradProprietario As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSeguradora As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents mskKmMediaMensal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCepDePerNoite As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelCepDePerNoite As System.Windows.Forms.Label
    Friend WithEvents LabelKmMediaMensal As System.Windows.Forms.Label
    Friend WithEvents LabelHouveSinistro As System.Windows.Forms.Label
    Friend WithEvents NumQuantSinistr As System.Windows.Forms.NumericUpDown
    Friend WithEvents NomeSegundoCondutor As System.Windows.Forms.GroupBox
    Friend WithEvents cboUsoVeiculo As System.Windows.Forms.ComboBox
    Friend WithEvents cboNoTrabalho As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelNoTrabalho As System.Windows.Forms.Label
    Friend WithEvents cboNaEscola As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LabelNaEscola As System.Windows.Forms.Label
    Friend WithEvents LabelDistAproxEmKmResidencia As System.Windows.Forms.Label
    Friend WithEvents cboNaResidencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LabelNaResidencia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LabelPossuiGaragem As System.Windows.Forms.Label
    Friend WithEvents mskCepTrabalho As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboGaragemFechada As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboNoturno As System.Windows.Forms.ComboBox
    Friend WithEvents cboVespertino As System.Windows.Forms.ComboBox
    Friend WithEvents txtDistAproxEmKmResidencia As System.Windows.Forms.TextBox
    Friend WithEvents cboMatutino As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboUtilizaVeiculoVisitas As System.Windows.Forms.ComboBox
    Friend WithEvents LabelUtilizaVeiculoVisitas As System.Windows.Forms.Label
    Friend WithEvents cboPrincCondutEstud As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mskCNH As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelRelacaoCondutor As System.Windows.Forms.Label
    Friend WithEvents numIdade As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelIdade As System.Windows.Forms.Label
    Friend WithEvents numQuantos As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelQuantos As System.Windows.Forms.Label
    Friend WithEvents txtRelacaoCondutor As System.Windows.Forms.TextBox
    Friend WithEvents cboPossuiFilhos As System.Windows.Forms.ComboBox
    Friend WithEvents Label543 As System.Windows.Forms.Label
    Friend WithEvents LabelPossuiFilhos As System.Windows.Forms.Label
    Friend WithEvents mskDataNascSegCondut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSegundoCondutor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtClasseDeBonus As System.Windows.Forms.ComboBox
    Friend WithEvents LabelPrincipalCondutorReside As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboPrincipalCondutorReside As System.Windows.Forms.ComboBox
    Friend WithEvents cboRoubo As System.Windows.Forms.ComboBox
    Friend WithEvents LabelResidemComCondutor As System.Windows.Forms.Label
    Friend WithEvents cboResidemComCondutor As System.Windows.Forms.ComboBox
    Friend WithEvents LabelClasseDeBonus As System.Windows.Forms.Label
    Friend WithEvents cboFabricante As System.Windows.Forms.ComboBox
    Friend WithEvents cboModelo As System.Windows.Forms.ComboBox
    Friend WithEvents cboSeguradora As System.Windows.Forms.ComboBox
End Class
