<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sinistros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sinistros))
        Me.gBoxCadSinistro = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.LabelCidade = New System.Windows.Forms.Label()
        Me.LabelBairro = New System.Windows.Forms.Label()
        Me.MaskTxtCep = New System.Windows.Forms.MaskedTextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtNumCasa = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.LabelNumeroCasa = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.LabelEndereco = New System.Windows.Forms.Label()
        Me.btnSubtrairCliente = New System.Windows.Forms.PictureBox()
        Me.Label2CEP = New System.Windows.Forms.Label()
        Me.btnAdicionarCliente = New System.Windows.Forms.PictureBox()
        Me.dgvCliSini = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodCarro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModCarro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FabricanteCarro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApolice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumSinistro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtComentarios = New System.Windows.Forms.TextBox()
        Me.LblComentarios = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.LblData = New System.Windows.Forms.Label()
        Me.TxtEnvolvidos = New System.Windows.Forms.TextBox()
        Me.LblEnvolvidos = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
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
        Me.LabelDescPag = New DevExpress.XtraEditors.LabelControl()
        Me.gBoxCadSinistro.SuspendLayout()
        CType(Me.btnSubtrairCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdicionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliSini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gBoxCadSinistro
        '
        Me.gBoxCadSinistro.Controls.Add(Me.Label1)
        Me.gBoxCadSinistro.Controls.Add(Me.cboUf)
        Me.gBoxCadSinistro.Controls.Add(Me.LabelCidade)
        Me.gBoxCadSinistro.Controls.Add(Me.LabelBairro)
        Me.gBoxCadSinistro.Controls.Add(Me.MaskTxtCep)
        Me.gBoxCadSinistro.Controls.Add(Me.txtCidade)
        Me.gBoxCadSinistro.Controls.Add(Me.txtNumCasa)
        Me.gBoxCadSinistro.Controls.Add(Me.txtBairro)
        Me.gBoxCadSinistro.Controls.Add(Me.LabelNumeroCasa)
        Me.gBoxCadSinistro.Controls.Add(Me.txtEndereco)
        Me.gBoxCadSinistro.Controls.Add(Me.LabelEndereco)
        Me.gBoxCadSinistro.Controls.Add(Me.btnSubtrairCliente)
        Me.gBoxCadSinistro.Controls.Add(Me.Label2CEP)
        Me.gBoxCadSinistro.Controls.Add(Me.btnAdicionarCliente)
        Me.gBoxCadSinistro.Controls.Add(Me.dgvCliSini)
        Me.gBoxCadSinistro.Controls.Add(Me.txtID)
        Me.gBoxCadSinistro.Controls.Add(Me.Label4)
        Me.gBoxCadSinistro.Controls.Add(Me.txtApolice)
        Me.gBoxCadSinistro.Controls.Add(Me.Label3)
        Me.gBoxCadSinistro.Controls.Add(Me.txtNumSinistro)
        Me.gBoxCadSinistro.Controls.Add(Me.Label2)
        Me.gBoxCadSinistro.Controls.Add(Me.TxtComentarios)
        Me.gBoxCadSinistro.Controls.Add(Me.LblComentarios)
        Me.gBoxCadSinistro.Controls.Add(Me.MaskedTextBox1)
        Me.gBoxCadSinistro.Controls.Add(Me.LblData)
        Me.gBoxCadSinistro.Controls.Add(Me.TxtEnvolvidos)
        Me.gBoxCadSinistro.Controls.Add(Me.LblEnvolvidos)
        Me.gBoxCadSinistro.Controls.Add(Me.TxtTipo)
        Me.gBoxCadSinistro.Controls.Add(Me.LblTipo)
        Me.gBoxCadSinistro.Controls.Add(Me.LblInfo)
        Me.gBoxCadSinistro.Location = New System.Drawing.Point(12, 33)
        Me.gBoxCadSinistro.Name = "gBoxCadSinistro"
        Me.gBoxCadSinistro.Size = New System.Drawing.Size(802, 491)
        Me.gBoxCadSinistro.TabIndex = 33
        Me.gBoxCadSinistro.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(594, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "UF:"
        '
        'cboUf
        '
        Me.cboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUf.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.ItemHeight = 15
        Me.cboUf.Items.AddRange(New Object() {"Selecione...", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PR", "PB", "PA", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SE", "SP", "TO"})
        Me.cboUf.Location = New System.Drawing.Point(626, 110)
        Me.cboUf.MaxLength = 2
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(103, 23)
        Me.cboUf.TabIndex = 21
        '
        'LabelCidade
        '
        Me.LabelCidade.AutoSize = True
        Me.LabelCidade.BackColor = System.Drawing.Color.Transparent
        Me.LabelCidade.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCidade.Location = New System.Drawing.Point(432, 113)
        Me.LabelCidade.Name = "LabelCidade"
        Me.LabelCidade.Size = New System.Drawing.Size(48, 15)
        Me.LabelCidade.TabIndex = 18
        Me.LabelCidade.Text = "Cidade:"
        '
        'LabelBairro
        '
        Me.LabelBairro.AutoSize = True
        Me.LabelBairro.BackColor = System.Drawing.Color.Transparent
        Me.LabelBairro.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBairro.Location = New System.Drawing.Point(182, 150)
        Me.LabelBairro.Name = "LabelBairro"
        Me.LabelBairro.Size = New System.Drawing.Size(45, 15)
        Me.LabelBairro.TabIndex = 25
        Me.LabelBairro.Text = "Bairro:"
        '
        'MaskTxtCep
        '
        Me.MaskTxtCep.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskTxtCep.Location = New System.Drawing.Point(113, 144)
        Me.MaskTxtCep.Mask = "00000-000"
        Me.MaskTxtCep.Name = "MaskTxtCep"
        Me.MaskTxtCep.Size = New System.Drawing.Size(63, 22)
        Me.MaskTxtCep.TabIndex = 24
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(486, 109)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(102, 22)
        Me.txtCidade.TabIndex = 19
        '
        'txtNumCasa
        '
        Me.txtNumCasa.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCasa.Location = New System.Drawing.Point(364, 110)
        Me.txtNumCasa.MaxLength = 7
        Me.txtNumCasa.Name = "txtNumCasa"
        Me.txtNumCasa.Size = New System.Drawing.Size(63, 22)
        Me.txtNumCasa.TabIndex = 17
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(233, 144)
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(94, 22)
        Me.txtBairro.TabIndex = 26
        '
        'LabelNumeroCasa
        '
        Me.LabelNumeroCasa.AutoSize = True
        Me.LabelNumeroCasa.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroCasa.Location = New System.Drawing.Point(337, 117)
        Me.LabelNumeroCasa.Name = "LabelNumeroCasa"
        Me.LabelNumeroCasa.Size = New System.Drawing.Size(24, 15)
        Me.LabelNumeroCasa.TabIndex = 16
        Me.LabelNumeroCasa.Text = "Nº:"
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(112, 111)
        Me.txtEndereco.MaxLength = 60
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(215, 22)
        Me.txtEndereco.TabIndex = 15
        '
        'LabelEndereco
        '
        Me.LabelEndereco.AutoSize = True
        Me.LabelEndereco.BackColor = System.Drawing.Color.Transparent
        Me.LabelEndereco.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEndereco.Location = New System.Drawing.Point(39, 114)
        Me.LabelEndereco.Name = "LabelEndereco"
        Me.LabelEndereco.Size = New System.Drawing.Size(59, 15)
        Me.LabelEndereco.TabIndex = 14
        Me.LabelEndereco.Text = "Endereço:"
        '
        'btnSubtrairCliente
        '
        Me.btnSubtrairCliente.Image = CType(resources.GetObject("btnSubtrairCliente.Image"), System.Drawing.Image)
        Me.btnSubtrairCliente.Location = New System.Drawing.Point(753, 279)
        Me.btnSubtrairCliente.Name = "btnSubtrairCliente"
        Me.btnSubtrairCliente.Size = New System.Drawing.Size(34, 27)
        Me.btnSubtrairCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSubtrairCliente.TabIndex = 110
        Me.btnSubtrairCliente.TabStop = False
        '
        'Label2CEP
        '
        Me.Label2CEP.AutoSize = True
        Me.Label2CEP.BackColor = System.Drawing.Color.Transparent
        Me.Label2CEP.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2CEP.Location = New System.Drawing.Point(67, 150)
        Me.Label2CEP.Name = "Label2CEP"
        Me.Label2CEP.Size = New System.Drawing.Size(34, 15)
        Me.Label2CEP.TabIndex = 22
        Me.Label2CEP.Text = "CEP:"
        '
        'btnAdicionarCliente
        '
        Me.btnAdicionarCliente.Image = CType(resources.GetObject("btnAdicionarCliente.Image"), System.Drawing.Image)
        Me.btnAdicionarCliente.Location = New System.Drawing.Point(753, 246)
        Me.btnAdicionarCliente.Name = "btnAdicionarCliente"
        Me.btnAdicionarCliente.Size = New System.Drawing.Size(34, 27)
        Me.btnAdicionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAdicionarCliente.TabIndex = 109
        Me.btnAdicionarCliente.TabStop = False
        '
        'dgvCliSini
        '
        Me.dgvCliSini.AllowUserToAddRows = False
        Me.dgvCliSini.AllowUserToDeleteRows = False
        Me.dgvCliSini.BackgroundColor = System.Drawing.Color.White
        Me.dgvCliSini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliSini.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NomeCliente, Me.CodCarro, Me.ModCarro, Me.FabricanteCarro})
        Me.dgvCliSini.GridColor = System.Drawing.Color.Black
        Me.dgvCliSini.Location = New System.Drawing.Point(20, 197)
        Me.dgvCliSini.Name = "dgvCliSini"
        Me.dgvCliSini.ReadOnly = True
        Me.dgvCliSini.Size = New System.Drawing.Size(727, 198)
        Me.dgvCliSini.TabIndex = 29
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "id_Pessoa_Fisica"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'NomeCliente
        '
        Me.NomeCliente.DataPropertyName = "Nome_Completo"
        Me.NomeCliente.HeaderText = "Nome"
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.ReadOnly = True
        Me.NomeCliente.Width = 270
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
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(435, 14)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(49, 20)
        Me.txtID.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(348, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Id do Sinistro:"
        '
        'txtApolice
        '
        Me.txtApolice.Location = New System.Drawing.Point(389, 158)
        Me.txtApolice.MaxLength = 20
        Me.txtApolice.Name = "txtApolice"
        Me.txtApolice.Size = New System.Drawing.Size(153, 20)
        Me.txtApolice.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(333, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Apólice:"
        '
        'txtNumSinistro
        '
        Me.txtNumSinistro.Location = New System.Drawing.Point(435, 80)
        Me.txtNumSinistro.MaxLength = 20
        Me.txtNumSinistro.Name = "txtNumSinistro"
        Me.txtNumSinistro.Size = New System.Drawing.Size(153, 20)
        Me.txtNumSinistro.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(361, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nº Sinistro:"
        '
        'TxtComentarios
        '
        Me.TxtComentarios.Location = New System.Drawing.Point(22, 423)
        Me.TxtComentarios.MaxLength = 300
        Me.TxtComentarios.Multiline = True
        Me.TxtComentarios.Name = "TxtComentarios"
        Me.TxtComentarios.Size = New System.Drawing.Size(727, 96)
        Me.TxtComentarios.TabIndex = 30
        '
        'LblComentarios
        '
        Me.LblComentarios.AutoSize = True
        Me.LblComentarios.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComentarios.Location = New System.Drawing.Point(21, 372)
        Me.LblComentarios.Name = "LblComentarios"
        Me.LblComentarios.Size = New System.Drawing.Size(79, 13)
        Me.LblComentarios.TabIndex = 99
        Me.LblComentarios.Text = "Comentários:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(109, 81)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 11
        '
        'LblData
        '
        Me.LblData.AutoSize = True
        Me.LblData.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblData.Location = New System.Drawing.Point(6, 84)
        Me.LblData.Name = "LblData"
        Me.LblData.Size = New System.Drawing.Size(95, 13)
        Me.LblData.TabIndex = 10
        Me.LblData.Text = "Data do Sinistro:"
        '
        'TxtEnvolvidos
        '
        Me.TxtEnvolvidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEnvolvidos.Location = New System.Drawing.Point(435, 49)
        Me.TxtEnvolvidos.MaxLength = 75
        Me.TxtEnvolvidos.Name = "TxtEnvolvidos"
        Me.TxtEnvolvidos.Size = New System.Drawing.Size(153, 20)
        Me.TxtEnvolvidos.TabIndex = 9
        '
        'LblEnvolvidos
        '
        Me.LblEnvolvidos.AutoSize = True
        Me.LblEnvolvidos.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnvolvidos.Location = New System.Drawing.Point(321, 52)
        Me.LblEnvolvidos.Name = "LblEnvolvidos"
        Me.LblEnvolvidos.Size = New System.Drawing.Size(108, 13)
        Me.LblEnvolvidos.TabIndex = 8
        Me.LblEnvolvidos.Text = "Pessoas envolvidas:"
        '
        'TxtTipo
        '
        Me.TxtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTipo.Location = New System.Drawing.Point(109, 50)
        Me.TxtTipo.MaxLength = 30
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(153, 20)
        Me.TxtTipo.TabIndex = 7
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.Location = New System.Drawing.Point(5, 53)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(93, 13)
        Me.LblTipo.TabIndex = 6
        Me.LblTipo.Text = "Tipo de Sinistro:"
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(6, 16)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(78, 15)
        Me.LblInfo.TabIndex = 3
        Me.LblInfo.Text = "Informações:"
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
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 527)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(827, 79)
        Me.ToolStrip1.TabIndex = 34
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 79)
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
        'LabelDescPag
        '
        Me.LabelDescPag.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescPag.Location = New System.Drawing.Point(12, 6)
        Me.LabelDescPag.Name = "LabelDescPag"
        Me.LabelDescPag.Size = New System.Drawing.Size(75, 24)
        Me.LabelDescPag.TabIndex = 32
        Me.LabelDescPag.Text = "Sinistros"
        '
        'Sinistros
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 606)
        Me.Controls.Add(Me.gBoxCadSinistro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LabelDescPag)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sinistros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Sinistros ="
        Me.gBoxCadSinistro.ResumeLayout(False)
        Me.gBoxCadSinistro.PerformLayout()
        CType(Me.btnSubtrairCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdicionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliSini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gBoxCadSinistro As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboUf As System.Windows.Forms.ComboBox
    Friend WithEvents LabelCidade As System.Windows.Forms.Label
    Friend WithEvents LabelBairro As System.Windows.Forms.Label
    Friend WithEvents MaskTxtCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCasa As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents LabelNumeroCasa As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents LabelEndereco As System.Windows.Forms.Label
    Friend WithEvents btnSubtrairCliente As System.Windows.Forms.PictureBox
    Friend WithEvents Label2CEP As System.Windows.Forms.Label
    Friend WithEvents btnAdicionarCliente As System.Windows.Forms.PictureBox
    Friend WithEvents dgvCliSini As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodCarro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModCarro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FabricanteCarro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApolice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumSinistro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents LblComentarios As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblData As System.Windows.Forms.Label
    Friend WithEvents TxtEnvolvidos As System.Windows.Forms.TextBox
    Friend WithEvents LblEnvolvidos As System.Windows.Forms.Label
    Friend WithEvents TxtTipo As System.Windows.Forms.TextBox
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents LblInfo As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
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
    Friend WithEvents LabelDescPag As DevExpress.XtraEditors.LabelControl
End Class
