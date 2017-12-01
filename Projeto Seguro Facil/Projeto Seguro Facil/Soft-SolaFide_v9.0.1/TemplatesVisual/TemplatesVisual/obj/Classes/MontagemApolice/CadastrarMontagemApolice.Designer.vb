<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarOrcamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarOrcamento))
        Me.lbCadastrarOrcamento = New DevExpress.XtraEditors.LabelControl()
        Me.LabelObservacoes = New System.Windows.Forms.Label()
        Me.TxtObservacoes = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSeguradoras = New System.Windows.Forms.ComboBox()
        Me.mskPercComissao = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboFrmPagamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProponente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MskCI = New System.Windows.Forms.MaskedTextBox()
        Me.cboParcelas = New System.Windows.Forms.ComboBox()
        Me.lbFormaPagamento = New System.Windows.Forms.Label()
        Me.TxtFranquia = New System.Windows.Forms.TextBox()
        Me.lbFranquia = New System.Windows.Forms.Label()
        Me.TxtPremio = New System.Windows.Forms.TextBox()
        Me.LabelPrêmio = New System.Windows.Forms.Label()
        Me.lbSeguradoras = New System.Windows.Forms.Label()
        Me.MaskTxtVigenciaFim = New System.Windows.Forms.MaskedTextBox()
        Me.lbFim = New System.Windows.Forms.Label()
        Me.MaskTxtVigenciaInicio = New System.Windows.Forms.MaskedTextBox()
        Me.lbInicio = New System.Windows.Forms.Label()
        Me.lbVigencia = New System.Windows.Forms.Label()
        Me.MaskTxtDataDoCalculo = New System.Windows.Forms.MaskedTextBox()
        Me.lbDataDoCalculo = New System.Windows.Forms.Label()
        Me.gboCobertura = New System.Windows.Forms.GroupBox()
        Me.cboCobertura = New System.Windows.Forms.ComboBox()
        Me.cboDnMorais = New System.Windows.Forms.TextBox()
        Me.cboAppInval = New System.Windows.Forms.TextBox()
        Me.cboDnCorp = New System.Windows.Forms.TextBox()
        Me.cboDnMtr = New System.Windows.Forms.TextBox()
        Me.cboAppMorte = New System.Windows.Forms.TextBox()
        Me.lbDnMorais = New System.Windows.Forms.Label()
        Me.lbAppInval = New System.Windows.Forms.Label()
        Me.lbAppMorte = New System.Windows.Forms.Label()
        Me.lbDnCorp = New System.Windows.Forms.Label()
        Me.lbDnMtr = New System.Windows.Forms.Label()
        Me.lbCobertura = New System.Windows.Forms.Label()
        Me.gboClausulas = New System.Windows.Forms.GroupBox()
        Me.cboCarReserv = New System.Windows.Forms.ComboBox()
        Me.lbCarReserv = New System.Windows.Forms.Label()
        Me.cboVidros = New System.Windows.Forms.ComboBox()
        Me.lbVidros = New System.Windows.Forms.Label()
        Me.cboAss24Horas = New System.Windows.Forms.ComboBox()
        Me.lbAss24Horas = New System.Windows.Forms.Label()
        Me.lbId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.dgvCliOrc = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodCarro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModCarro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FabricanteCarro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSubtrairCliente = New System.Windows.Forms.PictureBox()
        Me.btnAdicionarCliente = New System.Windows.Forms.PictureBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrimeiro = New System.Windows.Forms.ToolStripButton()
        Me.btnVoltar = New System.Windows.Forms.ToolStripButton()
        Me.btnIr = New System.Windows.Forms.ToolStripButton()
        Me.btnUltimo = New System.Windows.Forms.ToolStripButton()
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GroupBox1.SuspendLayout()
        Me.gboCobertura.SuspendLayout()
        Me.gboClausulas.SuspendLayout()
        CType(Me.dgvCliOrc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubtrairCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdicionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCadastrarOrcamento
        '
        Me.lbCadastrarOrcamento.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCadastrarOrcamento.Location = New System.Drawing.Point(12, 12)
        Me.lbCadastrarOrcamento.Name = "lbCadastrarOrcamento"
        Me.lbCadastrarOrcamento.Size = New System.Drawing.Size(191, 24)
        Me.lbCadastrarOrcamento.TabIndex = 1
        Me.lbCadastrarOrcamento.Text = "Montagem de apólice"
        '
        'LabelObservacoes
        '
        Me.LabelObservacoes.AutoSize = True
        Me.LabelObservacoes.BackColor = System.Drawing.Color.Transparent
        Me.LabelObservacoes.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelObservacoes.Location = New System.Drawing.Point(37, 539)
        Me.LabelObservacoes.Name = "LabelObservacoes"
        Me.LabelObservacoes.Size = New System.Drawing.Size(76, 15)
        Me.LabelObservacoes.TabIndex = 47
        Me.LabelObservacoes.Text = "Observações:"
        '
        'TxtObservacoes
        '
        Me.TxtObservacoes.Location = New System.Drawing.Point(43, 557)
        Me.TxtObservacoes.MaxLength = 300
        Me.TxtObservacoes.Multiline = True
        Me.TxtObservacoes.Name = "TxtObservacoes"
        Me.TxtObservacoes.Size = New System.Drawing.Size(868, 69)
        Me.TxtObservacoes.TabIndex = 49
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSeguradoras)
        Me.GroupBox1.Controls.Add(Me.mskPercComissao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboFrmPagamento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtProponente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MskCI)
        Me.GroupBox1.Controls.Add(Me.cboParcelas)
        Me.GroupBox1.Controls.Add(Me.lbFormaPagamento)
        Me.GroupBox1.Controls.Add(Me.TxtFranquia)
        Me.GroupBox1.Controls.Add(Me.lbFranquia)
        Me.GroupBox1.Controls.Add(Me.TxtPremio)
        Me.GroupBox1.Controls.Add(Me.LabelPrêmio)
        Me.GroupBox1.Controls.Add(Me.lbSeguradoras)
        Me.GroupBox1.Controls.Add(Me.MaskTxtVigenciaFim)
        Me.GroupBox1.Controls.Add(Me.lbFim)
        Me.GroupBox1.Controls.Add(Me.MaskTxtVigenciaInicio)
        Me.GroupBox1.Controls.Add(Me.lbInicio)
        Me.GroupBox1.Controls.Add(Me.lbVigencia)
        Me.GroupBox1.Controls.Add(Me.MaskTxtDataDoCalculo)
        Me.GroupBox1.Controls.Add(Me.lbDataDoCalculo)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(717, 178)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'cboSeguradoras
        '
        Me.cboSeguradoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeguradoras.FormattingEnabled = True
        Me.cboSeguradoras.Location = New System.Drawing.Point(130, 76)
        Me.cboSeguradoras.Name = "cboSeguradoras"
        Me.cboSeguradoras.Size = New System.Drawing.Size(182, 21)
        Me.cboSeguradoras.TabIndex = 13
        '
        'mskPercComissao
        '
        Me.mskPercComissao.Location = New System.Drawing.Point(700, 111)
        Me.mskPercComissao.Mask = "000"
        Me.mskPercComissao.Name = "mskPercComissao"
        Me.mskPercComissao.Size = New System.Drawing.Size(44, 20)
        Me.mskPercComissao.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(484, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Percent. Comissão:*"
        '
        'cboFrmPagamento
        '
        Me.cboFrmPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrmPagamento.FormattingEnabled = True
        Me.cboFrmPagamento.Items.AddRange(New Object() {"A Vista", "Parcelado"})
        Me.cboFrmPagamento.Location = New System.Drawing.Point(164, 148)
        Me.cboFrmPagamento.Name = "cboFrmPagamento"
        Me.cboFrmPagamento.Size = New System.Drawing.Size(148, 21)
        Me.cboFrmPagamento.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Parcelado:*"
        '
        'txtProponente
        '
        Me.txtProponente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProponente.Location = New System.Drawing.Point(130, 111)
        Me.txtProponente.MaxLength = 75
        Me.txtProponente.Name = "txtProponente"
        Me.txtProponente.Size = New System.Drawing.Size(182, 20)
        Me.txtProponente.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Proponente:*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CI:*"
        '
        'MskCI
        '
        Me.MskCI.Location = New System.Drawing.Point(403, 111)
        Me.MskCI.Mask = "&&,&&&,&&&,&&&,&&&"
        Me.MskCI.Name = "MskCI"
        Me.MskCI.Size = New System.Drawing.Size(110, 20)
        Me.MskCI.TabIndex = 21
        '
        'cboParcelas
        '
        Me.cboParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParcelas.Enabled = False
        Me.cboParcelas.FormattingEnabled = True
        Me.cboParcelas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboParcelas.Location = New System.Drawing.Point(403, 148)
        Me.cboParcelas.Name = "cboParcelas"
        Me.cboParcelas.Size = New System.Drawing.Size(133, 21)
        Me.cboParcelas.TabIndex = 27
        '
        'lbFormaPagamento
        '
        Me.lbFormaPagamento.AutoSize = True
        Me.lbFormaPagamento.BackColor = System.Drawing.Color.Transparent
        Me.lbFormaPagamento.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormaPagamento.Location = New System.Drawing.Point(10, 151)
        Me.lbFormaPagamento.Name = "lbFormaPagamento"
        Me.lbFormaPagamento.Size = New System.Drawing.Size(140, 13)
        Me.lbFormaPagamento.TabIndex = 24
        Me.lbFormaPagamento.Text = "Forma de Pagamento(x):*"
        '
        'TxtFranquia
        '
        Me.TxtFranquia.Location = New System.Drawing.Point(403, 81)
        Me.TxtFranquia.Name = "TxtFranquia"
        Me.TxtFranquia.Size = New System.Drawing.Size(182, 20)
        Me.TxtFranquia.TabIndex = 15
        '
        'lbFranquia
        '
        Me.lbFranquia.AutoSize = True
        Me.lbFranquia.BackColor = System.Drawing.Color.Transparent
        Me.lbFranquia.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFranquia.Location = New System.Drawing.Point(281, 84)
        Me.lbFranquia.Name = "lbFranquia"
        Me.lbFranquia.Size = New System.Drawing.Size(64, 13)
        Me.lbFranquia.TabIndex = 14
        Me.lbFranquia.Text = "Franquia:*"
        '
        'TxtPremio
        '
        Me.TxtPremio.Location = New System.Drawing.Point(700, 81)
        Me.TxtPremio.MaxLength = 50
        Me.TxtPremio.Name = "TxtPremio"
        Me.TxtPremio.Size = New System.Drawing.Size(119, 20)
        Me.TxtPremio.TabIndex = 17
        '
        'LabelPrêmio
        '
        Me.LabelPrêmio.AutoSize = True
        Me.LabelPrêmio.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrêmio.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrêmio.Location = New System.Drawing.Point(543, 84)
        Me.LabelPrêmio.Name = "LabelPrêmio"
        Me.LabelPrêmio.Size = New System.Drawing.Size(55, 13)
        Me.LabelPrêmio.TabIndex = 16
        Me.LabelPrêmio.Text = "Prêmio:*"
        '
        'lbSeguradoras
        '
        Me.lbSeguradoras.AutoSize = True
        Me.lbSeguradoras.BackColor = System.Drawing.Color.Transparent
        Me.lbSeguradoras.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSeguradoras.Location = New System.Drawing.Point(28, 84)
        Me.lbSeguradoras.Name = "lbSeguradoras"
        Me.lbSeguradoras.Size = New System.Drawing.Size(82, 13)
        Me.lbSeguradoras.TabIndex = 12
        Me.lbSeguradoras.Text = "Seguradoras:*"
        '
        'MaskTxtVigenciaFim
        '
        Me.MaskTxtVigenciaFim.Location = New System.Drawing.Point(700, 41)
        Me.MaskTxtVigenciaFim.Mask = "00/00/0000"
        Me.MaskTxtVigenciaFim.Name = "MaskTxtVigenciaFim"
        Me.MaskTxtVigenciaFim.Size = New System.Drawing.Size(88, 20)
        Me.MaskTxtVigenciaFim.TabIndex = 11
        '
        'lbFim
        '
        Me.lbFim.AutoSize = True
        Me.lbFim.BackColor = System.Drawing.Color.Transparent
        Me.lbFim.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFim.Location = New System.Drawing.Point(561, 44)
        Me.lbFim.Name = "lbFim"
        Me.lbFim.Size = New System.Drawing.Size(37, 13)
        Me.lbFim.TabIndex = 10
        Me.lbFim.Text = "Fim:*"
        '
        'MaskTxtVigenciaInicio
        '
        Me.MaskTxtVigenciaInicio.Location = New System.Drawing.Point(403, 41)
        Me.MaskTxtVigenciaInicio.Mask = "00/00/0000"
        Me.MaskTxtVigenciaInicio.Name = "MaskTxtVigenciaInicio"
        Me.MaskTxtVigenciaInicio.Size = New System.Drawing.Size(88, 20)
        Me.MaskTxtVigenciaInicio.TabIndex = 9
        '
        'lbInicio
        '
        Me.lbInicio.AutoSize = True
        Me.lbInicio.BackColor = System.Drawing.Color.Transparent
        Me.lbInicio.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInicio.Location = New System.Drawing.Point(298, 44)
        Me.lbInicio.Name = "lbInicio"
        Me.lbInicio.Size = New System.Drawing.Size(47, 13)
        Me.lbInicio.TabIndex = 8
        Me.lbInicio.Text = "Início:*"
        '
        'lbVigencia
        '
        Me.lbVigencia.AutoSize = True
        Me.lbVigencia.BackColor = System.Drawing.Color.Transparent
        Me.lbVigencia.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVigencia.Location = New System.Drawing.Point(292, 16)
        Me.lbVigencia.Name = "lbVigencia"
        Me.lbVigencia.Size = New System.Drawing.Size(53, 13)
        Me.lbVigencia.TabIndex = 7
        Me.lbVigencia.Text = "Vigência"
        '
        'MaskTxtDataDoCalculo
        '
        Me.MaskTxtDataDoCalculo.Location = New System.Drawing.Point(130, 41)
        Me.MaskTxtDataDoCalculo.Mask = "00/00/0000"
        Me.MaskTxtDataDoCalculo.Name = "MaskTxtDataDoCalculo"
        Me.MaskTxtDataDoCalculo.Size = New System.Drawing.Size(88, 20)
        Me.MaskTxtDataDoCalculo.TabIndex = 6
        '
        'lbDataDoCalculo
        '
        Me.lbDataDoCalculo.AutoSize = True
        Me.lbDataDoCalculo.BackColor = System.Drawing.Color.Transparent
        Me.lbDataDoCalculo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataDoCalculo.Location = New System.Drawing.Point(10, 44)
        Me.lbDataDoCalculo.Name = "lbDataDoCalculo"
        Me.lbDataDoCalculo.Size = New System.Drawing.Size(100, 13)
        Me.lbDataDoCalculo.TabIndex = 5
        Me.lbDataDoCalculo.Text = "Data do Cálculo:*"
        '
        'gboCobertura
        '
        Me.gboCobertura.Controls.Add(Me.cboCobertura)
        Me.gboCobertura.Controls.Add(Me.cboDnMorais)
        Me.gboCobertura.Controls.Add(Me.cboAppInval)
        Me.gboCobertura.Controls.Add(Me.cboDnCorp)
        Me.gboCobertura.Controls.Add(Me.cboDnMtr)
        Me.gboCobertura.Controls.Add(Me.cboAppMorte)
        Me.gboCobertura.Controls.Add(Me.lbDnMorais)
        Me.gboCobertura.Controls.Add(Me.lbAppInval)
        Me.gboCobertura.Controls.Add(Me.lbAppMorte)
        Me.gboCobertura.Controls.Add(Me.lbDnCorp)
        Me.gboCobertura.Controls.Add(Me.lbDnMtr)
        Me.gboCobertura.Controls.Add(Me.lbCobertura)
        Me.gboCobertura.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboCobertura.Location = New System.Drawing.Point(78, 374)
        Me.gboCobertura.Name = "gboCobertura"
        Me.gboCobertura.Size = New System.Drawing.Size(655, 102)
        Me.gboCobertura.TabIndex = 29
        Me.gboCobertura.TabStop = False
        Me.gboCobertura.Text = "Cobertura"
        '
        'cboCobertura
        '
        Me.cboCobertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCobertura.FormattingEnabled = True
        Me.cboCobertura.Items.AddRange(New Object() {"Selecione", "Sem cobertura", "Compreensiva", "Incêndio", "Roubo"})
        Me.cboCobertura.Location = New System.Drawing.Point(80, 27)
        Me.cboCobertura.Name = "cboCobertura"
        Me.cboCobertura.Size = New System.Drawing.Size(120, 23)
        Me.cboCobertura.TabIndex = 31
        '
        'cboDnMorais
        '
        Me.cboDnMorais.Location = New System.Drawing.Point(524, 61)
        Me.cboDnMorais.Name = "cboDnMorais"
        Me.cboDnMorais.Size = New System.Drawing.Size(119, 22)
        Me.cboDnMorais.TabIndex = 41
        '
        'cboAppInval
        '
        Me.cboAppInval.Location = New System.Drawing.Point(297, 60)
        Me.cboAppInval.Name = "cboAppInval"
        Me.cboAppInval.Size = New System.Drawing.Size(125, 22)
        Me.cboAppInval.TabIndex = 37
        '
        'cboDnCorp
        '
        Me.cboDnCorp.Location = New System.Drawing.Point(524, 28)
        Me.cboDnCorp.Name = "cboDnCorp"
        Me.cboDnCorp.Size = New System.Drawing.Size(120, 22)
        Me.cboDnCorp.TabIndex = 39
        '
        'cboDnMtr
        '
        Me.cboDnMtr.Location = New System.Drawing.Point(297, 26)
        Me.cboDnMtr.Name = "cboDnMtr"
        Me.cboDnMtr.Size = New System.Drawing.Size(125, 22)
        Me.cboDnMtr.TabIndex = 35
        '
        'cboAppMorte
        '
        Me.cboAppMorte.Location = New System.Drawing.Point(80, 61)
        Me.cboAppMorte.Name = "cboAppMorte"
        Me.cboAppMorte.Size = New System.Drawing.Size(120, 22)
        Me.cboAppMorte.TabIndex = 33
        '
        'lbDnMorais
        '
        Me.lbDnMorais.AutoSize = True
        Me.lbDnMorais.Location = New System.Drawing.Point(427, 63)
        Me.lbDnMorais.Name = "lbDnMorais"
        Me.lbDnMorais.Size = New System.Drawing.Size(87, 15)
        Me.lbDnMorais.TabIndex = 40
        Me.lbDnMorais.Text = "Danos Morais:"
        '
        'lbAppInval
        '
        Me.lbAppInval.AutoSize = True
        Me.lbAppInval.Location = New System.Drawing.Point(206, 63)
        Me.lbAppInval.Name = "lbAppInval"
        Me.lbAppInval.Size = New System.Drawing.Size(83, 15)
        Me.lbAppInval.TabIndex = 36
        Me.lbAppInval.Text = "App Invalidez:"
        '
        'lbAppMorte
        '
        Me.lbAppMorte.AutoSize = True
        Me.lbAppMorte.Location = New System.Drawing.Point(6, 63)
        Me.lbAppMorte.Name = "lbAppMorte"
        Me.lbAppMorte.Size = New System.Drawing.Size(68, 15)
        Me.lbAppMorte.TabIndex = 32
        Me.lbAppMorte.Text = "App Morte:"
        '
        'lbDnCorp
        '
        Me.lbDnCorp.AutoSize = True
        Me.lbDnCorp.Location = New System.Drawing.Point(427, 29)
        Me.lbDnCorp.Name = "lbDnCorp"
        Me.lbDnCorp.Size = New System.Drawing.Size(91, 15)
        Me.lbDnCorp.TabIndex = 38
        Me.lbDnCorp.Text = "Dano Corporal:"
        '
        'lbDnMtr
        '
        Me.lbDnMtr.AutoSize = True
        Me.lbDnMtr.Location = New System.Drawing.Point(206, 29)
        Me.lbDnMtr.Name = "lbDnMtr"
        Me.lbDnMtr.Size = New System.Drawing.Size(89, 15)
        Me.lbDnMtr.TabIndex = 34
        Me.lbDnMtr.Text = "Dano Material:"
        '
        'lbCobertura
        '
        Me.lbCobertura.AutoSize = True
        Me.lbCobertura.Location = New System.Drawing.Point(6, 29)
        Me.lbCobertura.Name = "lbCobertura"
        Me.lbCobertura.Size = New System.Drawing.Size(63, 15)
        Me.lbCobertura.TabIndex = 30
        Me.lbCobertura.Text = "Cobertura"
        '
        'gboClausulas
        '
        Me.gboClausulas.Controls.Add(Me.cboCarReserv)
        Me.gboClausulas.Controls.Add(Me.lbCarReserv)
        Me.gboClausulas.Controls.Add(Me.cboVidros)
        Me.gboClausulas.Controls.Add(Me.lbVidros)
        Me.gboClausulas.Controls.Add(Me.cboAss24Horas)
        Me.gboClausulas.Controls.Add(Me.lbAss24Horas)
        Me.gboClausulas.Location = New System.Drawing.Point(78, 482)
        Me.gboClausulas.Name = "gboClausulas"
        Me.gboClausulas.Size = New System.Drawing.Size(655, 54)
        Me.gboClausulas.TabIndex = 42
        Me.gboClausulas.TabStop = False
        Me.gboClausulas.Text = "Cláusulas"
        '
        'cboCarReserv
        '
        Me.cboCarReserv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCarReserv.FormattingEnabled = True
        Me.cboCarReserv.Items.AddRange(New Object() {"Selecione", "SIM", "NÃO"})
        Me.cboCarReserv.Location = New System.Drawing.Point(595, 17)
        Me.cboCarReserv.Name = "cboCarReserv"
        Me.cboCarReserv.Size = New System.Drawing.Size(121, 21)
        Me.cboCarReserv.TabIndex = 48
        '
        'lbCarReserv
        '
        Me.lbCarReserv.AutoSize = True
        Me.lbCarReserv.Location = New System.Drawing.Point(486, 20)
        Me.lbCarReserv.Name = "lbCarReserv"
        Me.lbCarReserv.Size = New System.Drawing.Size(92, 13)
        Me.lbCarReserv.TabIndex = 47
        Me.lbCarReserv.Text = "Carro Reserva:*"
        '
        'cboVidros
        '
        Me.cboVidros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVidros.FormattingEnabled = True
        Me.cboVidros.Items.AddRange(New Object() {"Selecione", "SIM", "NÃO"})
        Me.cboVidros.Location = New System.Drawing.Point(353, 17)
        Me.cboVidros.Name = "cboVidros"
        Me.cboVidros.Size = New System.Drawing.Size(121, 21)
        Me.cboVidros.TabIndex = 46
        '
        'lbVidros
        '
        Me.lbVidros.AutoSize = True
        Me.lbVidros.Location = New System.Drawing.Point(284, 20)
        Me.lbVidros.Name = "lbVidros"
        Me.lbVidros.Size = New System.Drawing.Size(51, 13)
        Me.lbVidros.TabIndex = 45
        Me.lbVidros.Text = "Vidros:*"
        '
        'cboAss24Horas
        '
        Me.cboAss24Horas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAss24Horas.FormattingEnabled = True
        Me.cboAss24Horas.Items.AddRange(New Object() {"Selecione", "SIM", "NÃO"})
        Me.cboAss24Horas.Location = New System.Drawing.Point(152, 17)
        Me.cboAss24Horas.Name = "cboAss24Horas"
        Me.cboAss24Horas.Size = New System.Drawing.Size(121, 21)
        Me.cboAss24Horas.TabIndex = 44
        '
        'lbAss24Horas
        '
        Me.lbAss24Horas.AutoSize = True
        Me.lbAss24Horas.Location = New System.Drawing.Point(47, 20)
        Me.lbAss24Horas.Name = "lbAss24Horas"
        Me.lbAss24Horas.Size = New System.Drawing.Size(87, 13)
        Me.lbAss24Horas.TabIndex = 43
        Me.lbAss24Horas.Text = "Ass. 24 Horas:*"
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbId.Location = New System.Drawing.Point(623, 21)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(24, 15)
        Me.lbId.TabIndex = 2
        Me.lbId.Text = "ID:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(768, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(93, 20)
        Me.txtId.TabIndex = 3
        '
        'dgvCliOrc
        '
        Me.dgvCliOrc.AllowUserToAddRows = False
        Me.dgvCliOrc.AllowUserToDeleteRows = False
        Me.dgvCliOrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliOrc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NomeCliente, Me.CodCarro, Me.ModCarro, Me.FabricanteCarro})
        Me.dgvCliOrc.Location = New System.Drawing.Point(48, 229)
        Me.dgvCliOrc.Name = "dgvCliOrc"
        Me.dgvCliOrc.ReadOnly = True
        Me.dgvCliOrc.Size = New System.Drawing.Size(847, 139)
        Me.dgvCliOrc.TabIndex = 28
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "id_Pessoa_Fisica"
        Me.Codigo.HeaderText = "Codigo "
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'NomeCliente
        '
        Me.NomeCliente.DataPropertyName = "Nome_Completo"
        Me.NomeCliente.HeaderText = "Nome"
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.ReadOnly = True
        Me.NomeCliente.Width = 280
        '
        'CodCarro
        '
        Me.CodCarro.DataPropertyName = "id_Dados_Veiculo"
        Me.CodCarro.HeaderText = "Codigo do carro"
        Me.CodCarro.Name = "CodCarro"
        Me.CodCarro.ReadOnly = True
        '
        'ModCarro
        '
        Me.ModCarro.DataPropertyName = "Modelo"
        Me.ModCarro.HeaderText = "Modelo do carro"
        Me.ModCarro.Name = "ModCarro"
        Me.ModCarro.ReadOnly = True
        '
        'FabricanteCarro
        '
        Me.FabricanteCarro.DataPropertyName = "Fabricante"
        Me.FabricanteCarro.HeaderText = "Fabricante"
        Me.FabricanteCarro.Name = "FabricanteCarro"
        Me.FabricanteCarro.ReadOnly = True
        '
        'btnSubtrairCliente
        '
        Me.btnSubtrairCliente.Image = CType(resources.GetObject("btnSubtrairCliente.Image"), System.Drawing.Image)
        Me.btnSubtrairCliente.Location = New System.Drawing.Point(8, 264)
        Me.btnSubtrairCliente.Name = "btnSubtrairCliente"
        Me.btnSubtrairCliente.Size = New System.Drawing.Size(34, 27)
        Me.btnSubtrairCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSubtrairCliente.TabIndex = 88
        Me.btnSubtrairCliente.TabStop = False
        '
        'btnAdicionarCliente
        '
        Me.btnAdicionarCliente.Image = CType(resources.GetObject("btnAdicionarCliente.Image"), System.Drawing.Image)
        Me.btnAdicionarCliente.Location = New System.Drawing.Point(8, 231)
        Me.btnAdicionarCliente.Name = "btnAdicionarCliente"
        Me.btnAdicionarCliente.Size = New System.Drawing.Size(34, 27)
        Me.btnAdicionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAdicionarCliente.TabIndex = 87
        Me.btnAdicionarCliente.TabStop = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 83)
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrimeiro.Image = CType(resources.GetObject("btnPrimeiro.Image"), System.Drawing.Image)
        Me.btnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(68, 80)
        Me.btnPrimeiro.Text = "Voltar ao ultimo"
        Me.btnPrimeiro.ToolTipText = "Ir para o primeiro"
        '
        'btnVoltar
        '
        Me.btnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(68, 80)
        Me.btnVoltar.Text = "Voltar ao anterior"
        Me.btnVoltar.ToolTipText = "Voltar"
        '
        'btnIr
        '
        Me.btnIr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIr.Image = CType(resources.GetObject("btnIr.Image"), System.Drawing.Image)
        Me.btnIr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(68, 80)
        Me.btnIr.Text = "Ir ao proximo"
        Me.btnIr.ToolTipText = "Ir para o proximo"
        '
        'btnUltimo
        '
        Me.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(68, 80)
        Me.btnUltimo.Text = "Ir ao ultimo"
        Me.btnUltimo.ToolTipText = "Ir para o Ultimo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 83)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 83)
        '
        'btnExcluir
        '
        Me.btnExcluir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(68, 80)
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
        Me.btnAlterar.Size = New System.Drawing.Size(68, 80)
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.ToolTipText = "Alterar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 83)
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCadastrar.ForeColor = System.Drawing.Color.Black
        Me.BtnCadastrar.Image = Global.SeguroFacil.My.Resources.Resources.Botão
        Me.BtnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(68, 80)
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
        Me.BtLimpar.Size = New System.Drawing.Size(68, 80)
        Me.BtLimpar.Text = "Novo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 83)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(68, 80)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(68, 80)
        Me.btnImprimir.Text = "Imprimir"
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
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 650)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(796, 83)
        Me.ToolStrip1.TabIndex = 50
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'frmCadastrarOrcamento
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 733)
        Me.Controls.Add(Me.btnSubtrairCliente)
        Me.Controls.Add(Me.btnAdicionarCliente)
        Me.Controls.Add(Me.dgvCliOrc)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lbId)
        Me.Controls.Add(Me.gboClausulas)
        Me.Controls.Add(Me.gboCobertura)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TxtObservacoes)
        Me.Controls.Add(Me.LabelObservacoes)
        Me.Controls.Add(Me.lbCadastrarOrcamento)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadastrarOrcamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Montagem de Apólice ="
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboCobertura.ResumeLayout(False)
        Me.gboCobertura.PerformLayout()
        Me.gboClausulas.ResumeLayout(False)
        Me.gboClausulas.PerformLayout()
        CType(Me.dgvCliOrc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubtrairCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdicionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCadastrarOrcamento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelObservacoes As System.Windows.Forms.Label
    Friend WithEvents TxtObservacoes As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboParcelas As System.Windows.Forms.ComboBox
    Friend WithEvents lbFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents TxtFranquia As System.Windows.Forms.TextBox
    Friend WithEvents lbFranquia As System.Windows.Forms.Label
    Friend WithEvents TxtPremio As System.Windows.Forms.TextBox
    Friend WithEvents LabelPrêmio As System.Windows.Forms.Label
    Friend WithEvents lbSeguradoras As System.Windows.Forms.Label
    Friend WithEvents MaskTxtVigenciaFim As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbFim As System.Windows.Forms.Label
    Friend WithEvents MaskTxtVigenciaInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbInicio As System.Windows.Forms.Label
    Friend WithEvents lbVigencia As System.Windows.Forms.Label
    Friend WithEvents MaskTxtDataDoCalculo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbDataDoCalculo As System.Windows.Forms.Label
    Friend WithEvents gboCobertura As System.Windows.Forms.GroupBox
    Friend WithEvents lbCobertura As System.Windows.Forms.Label
    Friend WithEvents lbDnMorais As System.Windows.Forms.Label
    Friend WithEvents lbAppInval As System.Windows.Forms.Label
    Friend WithEvents lbAppMorte As System.Windows.Forms.Label
    Friend WithEvents lbDnCorp As System.Windows.Forms.Label
    Friend WithEvents lbDnMtr As System.Windows.Forms.Label
    Friend WithEvents gboClausulas As System.Windows.Forms.GroupBox
    Friend WithEvents cboCarReserv As System.Windows.Forms.ComboBox
    Friend WithEvents lbCarReserv As System.Windows.Forms.Label
    Friend WithEvents cboVidros As System.Windows.Forms.ComboBox
    Friend WithEvents lbVidros As System.Windows.Forms.Label
    Friend WithEvents cboAss24Horas As System.Windows.Forms.ComboBox
    Friend WithEvents lbAss24Horas As System.Windows.Forms.Label
    Friend WithEvents lbId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MskCI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtProponente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvCliOrc As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdicionarCliente As System.Windows.Forms.PictureBox
    Friend WithEvents btnSubtrairCliente As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrimeiro As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnVoltar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnIr As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUltimo As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cboDnMorais As System.Windows.Forms.TextBox
    Friend WithEvents cboAppInval As System.Windows.Forms.TextBox
    Friend WithEvents cboDnCorp As System.Windows.Forms.TextBox
    Friend WithEvents cboDnMtr As System.Windows.Forms.TextBox
    Friend WithEvents cboAppMorte As System.Windows.Forms.TextBox
    Friend WithEvents cboFrmPagamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodCarro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModCarro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FabricanteCarro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCobertura As System.Windows.Forms.ComboBox
    Friend WithEvents mskPercComissao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboSeguradoras As System.Windows.Forms.ComboBox
End Class
