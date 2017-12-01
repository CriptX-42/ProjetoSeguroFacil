<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadPFisica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadPFisica))
        Me.lblDescPag = New DevExpress.XtraEditors.LabelControl()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblDataNasc = New System.Windows.Forms.Label()
        Me.LabelProfissao = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblTempoHab = New System.Windows.Forms.Label()
        Me.lblOrgaoExp = New System.Windows.Forms.Label()
        Me.lblDataExp = New System.Windows.Forms.Label()
        Me.lblRG = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblCel = New System.Windows.Forms.Label()
        Me.lblCNH = New System.Windows.Forms.Label()
        Me.lblFonRes = New System.Windows.Forms.Label()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.lblEstCivil = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblFoneCom = New System.Windows.Forms.Label()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblNextel = New System.Windows.Forms.Label()
        Me.lblNumeroCasa = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNumCasa = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.mskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.cboEstCivil = New System.Windows.Forms.ComboBox()
        Me.MskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtProfissao = New System.Windows.Forms.TextBox()
        Me.txtTempoHab = New System.Windows.Forms.TextBox()
        Me.cboTempoHab = New System.Windows.Forms.ComboBox()
        Me.mskCelular = New System.Windows.Forms.MaskedTextBox()
        Me.mskTelRecado = New System.Windows.Forms.MaskedTextBox()
        Me.mskTelResid = New System.Windows.Forms.MaskedTextBox()
        Me.txtNextel = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblBloco = New System.Windows.Forms.Label()
        Me.txtBloco = New System.Windows.Forms.TextBox()
        Me.lblApto = New System.Windows.Forms.Label()
        Me.txtApto = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tspPFisica = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrimeiro = New System.Windows.Forms.ToolStripButton()
        Me.btnVoltar = New System.Windows.Forms.ToolStripButton()
        Me.btnProximo = New System.Windows.Forms.ToolStripButton()
        Me.btnUltimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCadastrar = New System.Windows.Forms.ToolStripButton()
        Me.BtnLimpar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.grpContatoPFisica = New System.Windows.Forms.GroupBox()
        Me.grpDadosPFisica = New System.Windows.Forms.GroupBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.cboOrgExp = New System.Windows.Forms.ComboBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.mskCNH = New System.Windows.Forms.MaskedTextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.mskRG = New System.Windows.Forms.MaskedTextBox()
        Me.mskNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.mskDataExp = New System.Windows.Forms.MaskedTextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.grpEndPFisica = New System.Windows.Forms.GroupBox()
        Me.lblPesquisa = New System.Windows.Forms.Label()
        Me.picPesq = New System.Windows.Forms.PictureBox()
        Me.mskPesqCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.grpComentPFisica = New System.Windows.Forms.GroupBox()
        Me.tspPFisica.SuspendLayout()
        Me.grpContatoPFisica.SuspendLayout()
        Me.grpDadosPFisica.SuspendLayout()
        Me.grpEndPFisica.SuspendLayout()
        CType(Me.picPesq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpComentPFisica.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDescPag
        '
        Me.lblDescPag.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPag.Location = New System.Drawing.Point(12, 12)
        Me.lblDescPag.Name = "lblDescPag"
        Me.lblDescPag.Size = New System.Drawing.Size(233, 24)
        Me.lblDescPag.TabIndex = 1
        Me.lblDescPag.Text = "Cadastro de Pessoa Física"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.Color.Transparent
        Me.lblNome.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(32, 31)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(48, 15)
        Me.lblNome.TabIndex = 5
        Me.lblNome.Text = "Nome:*"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.BackColor = System.Drawing.Color.Transparent
        Me.lblCPF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(46, 97)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(40, 15)
        Me.lblCPF.TabIndex = 11
        Me.lblCPF.Text = "CPF:*"
        '
        'lblDataNasc
        '
        Me.lblDataNasc.AutoSize = True
        Me.lblDataNasc.BackColor = System.Drawing.Color.Transparent
        Me.lblDataNasc.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataNasc.Location = New System.Drawing.Point(211, 130)
        Me.lblDataNasc.Name = "lblDataNasc"
        Me.lblDataNasc.Size = New System.Drawing.Size(85, 15)
        Me.lblDataNasc.TabIndex = 17
        Me.lblDataNasc.Text = "Data de Nasc:*"
        '
        'LabelProfissao
        '
        Me.LabelProfissao.AutoSize = True
        Me.LabelProfissao.BackColor = System.Drawing.Color.Transparent
        Me.LabelProfissao.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProfissao.Location = New System.Drawing.Point(21, 202)
        Me.LabelProfissao.Name = "LabelProfissao"
        Me.LabelProfissao.Size = New System.Drawing.Size(59, 15)
        Me.LabelProfissao.TabIndex = 23
        Me.LabelProfissao.Text = "Profissão:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.BackColor = System.Drawing.Color.Transparent
        Me.lblSexo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(40, 130)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(43, 15)
        Me.lblSexo.TabIndex = 15
        Me.lblSexo.Text = "Sexo:*"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.BackColor = System.Drawing.Color.Transparent
        Me.lblCidade.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(190, 79)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(54, 15)
        Me.lblCidade.TabIndex = 39
        Me.lblCidade.Text = "Cidade:*"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.BackColor = System.Drawing.Color.Transparent
        Me.lblBairro.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(193, 116)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(51, 15)
        Me.lblBairro.TabIndex = 43
        Me.lblBairro.Text = "Bairro:*"
        '
        'lblTempoHab
        '
        Me.lblTempoHab.AutoSize = True
        Me.lblTempoHab.BackColor = System.Drawing.Color.Transparent
        Me.lblTempoHab.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempoHab.Location = New System.Drawing.Point(226, 238)
        Me.lblTempoHab.Name = "lblTempoHab"
        Me.lblTempoHab.Size = New System.Drawing.Size(130, 15)
        Me.lblTempoHab.TabIndex = 27
        Me.lblTempoHab.Text = "Tempo de Habilitação:*"
        '
        'lblOrgaoExp
        '
        Me.lblOrgaoExp.AutoSize = True
        Me.lblOrgaoExp.BackColor = System.Drawing.Color.Transparent
        Me.lblOrgaoExp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrgaoExp.Location = New System.Drawing.Point(183, 170)
        Me.lblOrgaoExp.Name = "lblOrgaoExp"
        Me.lblOrgaoExp.Size = New System.Drawing.Size(105, 15)
        Me.lblOrgaoExp.TabIndex = 21
        Me.lblOrgaoExp.Text = "Órgão Expedidor:*"
        '
        'lblDataExp
        '
        Me.lblDataExp.AutoSize = True
        Me.lblDataExp.BackColor = System.Drawing.Color.Transparent
        Me.lblDataExp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataExp.Location = New System.Drawing.Point(205, 93)
        Me.lblDataExp.Name = "lblDataExp"
        Me.lblDataExp.Size = New System.Drawing.Size(97, 15)
        Me.lblDataExp.TabIndex = 13
        Me.lblDataExp.Text = "Data Expedição:*"
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.BackColor = System.Drawing.Color.Transparent
        Me.lblRG.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRG.Location = New System.Drawing.Point(46, 168)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(34, 15)
        Me.lblRG.TabIndex = 19
        Me.lblRG.Text = "RG:*"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.BackColor = System.Drawing.Color.Transparent
        Me.lblEndereco.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(18, 41)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(65, 15)
        Me.lblEndereco.TabIndex = 35
        Me.lblEndereco.Text = "Endereço:*"
        '
        'lblCel
        '
        Me.lblCel.AutoSize = True
        Me.lblCel.BackColor = System.Drawing.Color.Transparent
        Me.lblCel.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCel.Location = New System.Drawing.Point(64, 19)
        Me.lblCel.Name = "lblCel"
        Me.lblCel.Size = New System.Drawing.Size(52, 15)
        Me.lblCel.TabIndex = 54
        Me.lblCel.Text = "Celular:"
        '
        'lblCNH
        '
        Me.lblCNH.AutoSize = True
        Me.lblCNH.BackColor = System.Drawing.Color.Transparent
        Me.lblCNH.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNH.Location = New System.Drawing.Point(43, 238)
        Me.lblCNH.Name = "lblCNH"
        Me.lblCNH.Size = New System.Drawing.Size(44, 15)
        Me.lblCNH.TabIndex = 25
        Me.lblCNH.Text = "CNH:*"
        '
        'lblFonRes
        '
        Me.lblFonRes.AutoSize = True
        Me.lblFonRes.BackColor = System.Drawing.Color.Transparent
        Me.lblFonRes.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFonRes.Location = New System.Drawing.Point(467, 57)
        Me.lblFonRes.Name = "lblFonRes"
        Me.lblFonRes.Size = New System.Drawing.Size(107, 15)
        Me.lblFonRes.TabIndex = 60
        Me.lblFonRes.Text = "Fone Residencial:*"
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.BackColor = System.Drawing.Color.Transparent
        Me.lblUF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUF.Location = New System.Drawing.Point(210, 151)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(32, 15)
        Me.lblUF.TabIndex = 47
        Me.lblUF.Text = "UF:*"
        '
        'lblEstCivil
        '
        Me.lblEstCivil.AutoSize = True
        Me.lblEstCivil.BackColor = System.Drawing.Color.Transparent
        Me.lblEstCivil.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstCivil.Location = New System.Drawing.Point(1, 60)
        Me.lblEstCivil.Name = "lblEstCivil"
        Me.lblEstCivil.Size = New System.Drawing.Size(80, 15)
        Me.lblEstCivil.TabIndex = 9
        Me.lblEstCivil.Text = "Estado Civíl:*"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(67, 91)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 15)
        Me.lblEmail.TabIndex = 62
        Me.lblEmail.Text = "E-mail:*"
        '
        'lblFoneCom
        '
        Me.lblFoneCom.AutoSize = True
        Me.lblFoneCom.BackColor = System.Drawing.Color.Transparent
        Me.lblFoneCom.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoneCom.Location = New System.Drawing.Point(475, 19)
        Me.lblFoneCom.Name = "lblFoneCom"
        Me.lblFoneCom.Size = New System.Drawing.Size(92, 15)
        Me.lblFoneCom.TabIndex = 58
        Me.lblFoneCom.Text = "Fone de Recado:"
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.BackColor = System.Drawing.Color.Transparent
        Me.lblCEP.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCEP.Location = New System.Drawing.Point(45, 116)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(40, 15)
        Me.lblCEP.TabIndex = 41
        Me.lblCEP.Text = "CEP:*"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.BackColor = System.Drawing.Color.Transparent
        Me.lblComplemento.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(0, 150)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(85, 15)
        Me.lblComplemento.TabIndex = 45
        Me.lblComplemento.Text = "Complemento:"
        '
        'lblNextel
        '
        Me.lblNextel.AutoSize = True
        Me.lblNextel.BackColor = System.Drawing.Color.Transparent
        Me.lblNextel.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextel.Location = New System.Drawing.Point(70, 58)
        Me.lblNextel.Name = "lblNextel"
        Me.lblNextel.Size = New System.Drawing.Size(46, 15)
        Me.lblNextel.TabIndex = 56
        Me.lblNextel.Text = "Nextel:"
        '
        'lblNumeroCasa
        '
        Me.lblNumeroCasa.AutoSize = True
        Me.lblNumeroCasa.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCasa.Location = New System.Drawing.Point(53, 79)
        Me.lblNumeroCasa.Name = "lblNumeroCasa"
        Me.lblNumeroCasa.Size = New System.Drawing.Size(30, 15)
        Me.lblNumeroCasa.TabIndex = 37
        Me.lblNumeroCasa.Text = "Nº:*"
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(87, 28)
        Me.txtNome.MaxLength = 75
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(255, 22)
        Me.txtNome.TabIndex = 6
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(91, 38)
        Me.txtEndereco.MaxLength = 60
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(261, 22)
        Me.txtEndereco.TabIndex = 36
        '
        'txtNumCasa
        '
        Me.txtNumCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumCasa.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCasa.Location = New System.Drawing.Point(91, 76)
        Me.txtNumCasa.MaxLength = 7
        Me.txtNumCasa.Name = "txtNumCasa"
        Me.txtNumCasa.Size = New System.Drawing.Size(63, 22)
        Me.txtNumCasa.TabIndex = 38
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplemento.Location = New System.Drawing.Point(91, 147)
        Me.txtComplemento.MaxLength = 45
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(94, 22)
        Me.txtComplemento.TabIndex = 46
        '
        'mskCEP
        '
        Me.mskCEP.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCEP.Location = New System.Drawing.Point(91, 110)
        Me.mskCEP.Mask = "00000-000"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.Size = New System.Drawing.Size(63, 22)
        Me.mskCEP.TabIndex = 42
        '
        'cboUf
        '
        Me.cboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUf.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.ItemHeight = 15
        Me.cboUf.Items.AddRange(New Object() {"Selecione", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PR", "PB", "PA", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SE", "SP", "TO"})
        Me.cboUf.Location = New System.Drawing.Point(249, 147)
        Me.cboUf.MaxLength = 2
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(103, 23)
        Me.cboUf.TabIndex = 48
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(249, 76)
        Me.txtCidade.MaxLength = 60
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(103, 22)
        Me.txtCidade.TabIndex = 40
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(249, 110)
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(103, 22)
        Me.txtBairro.TabIndex = 44
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Selecione", "Masculino", "Feminino"})
        Me.cboSexo.Location = New System.Drawing.Point(87, 126)
        Me.cboSexo.MaxLength = 45
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(99, 23)
        Me.cboSexo.TabIndex = 16
        '
        'cboEstCivil
        '
        Me.cboEstCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstCivil.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstCivil.FormattingEnabled = True
        Me.cboEstCivil.Items.AddRange(New Object() {"Selecione", "Solteiro", "Casado", "Divorciado"})
        Me.cboEstCivil.Location = New System.Drawing.Point(87, 57)
        Me.cboEstCivil.MaxLength = 45
        Me.cboEstCivil.Name = "cboEstCivil"
        Me.cboEstCivil.Size = New System.Drawing.Size(110, 23)
        Me.cboEstCivil.TabIndex = 10
        '
        'MskCPF
        '
        Me.MskCPF.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCPF.Location = New System.Drawing.Point(89, 94)
        Me.MskCPF.Mask = "000,000,000-00"
        Me.MskCPF.Name = "MskCPF"
        Me.MskCPF.Size = New System.Drawing.Size(105, 22)
        Me.MskCPF.TabIndex = 12
        '
        'txtProfissao
        '
        Me.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProfissao.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfissao.Location = New System.Drawing.Point(86, 199)
        Me.txtProfissao.MaxLength = 40
        Me.txtProfissao.Name = "txtProfissao"
        Me.txtProfissao.Size = New System.Drawing.Size(255, 22)
        Me.txtProfissao.TabIndex = 24
        '
        'txtTempoHab
        '
        Me.txtTempoHab.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempoHab.Location = New System.Drawing.Point(361, 235)
        Me.txtTempoHab.MaxLength = 2
        Me.txtTempoHab.Name = "txtTempoHab"
        Me.txtTempoHab.Size = New System.Drawing.Size(33, 22)
        Me.txtTempoHab.TabIndex = 28
        '
        'cboTempoHab
        '
        Me.cboTempoHab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTempoHab.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTempoHab.FormattingEnabled = True
        Me.cboTempoHab.Items.AddRange(New Object() {"Selecione", "Anos", "Meses"})
        Me.cboTempoHab.Location = New System.Drawing.Point(400, 235)
        Me.cboTempoHab.Name = "cboTempoHab"
        Me.cboTempoHab.Size = New System.Drawing.Size(86, 23)
        Me.cboTempoHab.TabIndex = 29
        '
        'mskCelular
        '
        Me.mskCelular.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCelular.Location = New System.Drawing.Point(122, 19)
        Me.mskCelular.Mask = "(00)00000-0000"
        Me.mskCelular.Name = "mskCelular"
        Me.mskCelular.Size = New System.Drawing.Size(111, 22)
        Me.mskCelular.TabIndex = 55
        '
        'mskTelRecado
        '
        Me.mskTelRecado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTelRecado.Location = New System.Drawing.Point(580, 19)
        Me.mskTelRecado.Mask = "(00)0000-0000"
        Me.mskTelRecado.Name = "mskTelRecado"
        Me.mskTelRecado.Size = New System.Drawing.Size(88, 22)
        Me.mskTelRecado.TabIndex = 59
        '
        'mskTelResid
        '
        Me.mskTelResid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTelResid.Location = New System.Drawing.Point(580, 55)
        Me.mskTelResid.Mask = "(00)0000-0000"
        Me.mskTelResid.Name = "mskTelResid"
        Me.mskTelResid.Size = New System.Drawing.Size(88, 22)
        Me.mskTelResid.TabIndex = 61
        '
        'txtNextel
        '
        Me.txtNextel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextel.Location = New System.Drawing.Point(122, 56)
        Me.txtNextel.MaxLength = 15
        Me.txtNextel.Name = "txtNextel"
        Me.txtNextel.Size = New System.Drawing.Size(111, 22)
        Me.txtNextel.TabIndex = 57
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(121, 89)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(342, 22)
        Me.txtEmail.TabIndex = 63
        '
        'lblBloco
        '
        Me.lblBloco.AutoSize = True
        Me.lblBloco.BackColor = System.Drawing.Color.Transparent
        Me.lblBloco.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloco.Location = New System.Drawing.Point(48, 186)
        Me.lblBloco.Name = "lblBloco"
        Me.lblBloco.Size = New System.Drawing.Size(40, 15)
        Me.lblBloco.TabIndex = 49
        Me.lblBloco.Text = "Bloco:"
        '
        'txtBloco
        '
        Me.txtBloco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBloco.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBloco.Location = New System.Drawing.Point(91, 179)
        Me.txtBloco.MaxLength = 2
        Me.txtBloco.Name = "txtBloco"
        Me.txtBloco.Size = New System.Drawing.Size(94, 22)
        Me.txtBloco.TabIndex = 50
        '
        'lblApto
        '
        Me.lblApto.AutoSize = True
        Me.lblApto.BackColor = System.Drawing.Color.Transparent
        Me.lblApto.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApto.Location = New System.Drawing.Point(48, 211)
        Me.lblApto.Name = "lblApto"
        Me.lblApto.Size = New System.Drawing.Size(35, 15)
        Me.lblApto.TabIndex = 51
        Me.lblApto.Text = "Apto:"
        '
        'txtApto
        '
        Me.txtApto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApto.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApto.Location = New System.Drawing.Point(91, 211)
        Me.txtApto.MaxLength = 4
        Me.txtApto.Name = "txtApto"
        Me.txtApto.Size = New System.Drawing.Size(94, 22)
        Me.txtApto.TabIndex = 52
        '
        'tspPFisica
        '
        Me.tspPFisica.AutoSize = False
        Me.tspPFisica.BackColor = System.Drawing.Color.Black
        Me.tspPFisica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tspPFisica.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tspPFisica.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspPFisica.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tspPFisica.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnPrimeiro, Me.btnVoltar, Me.btnProximo, Me.btnUltimo, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.btnExcluir, Me.btnAlterar, Me.ToolStripSeparator4, Me.BtnCadastrar, Me.BtnLimpar, Me.ToolStripSeparator5, Me.btnCancelar, Me.btnImprimir})
        Me.tspPFisica.Location = New System.Drawing.Point(0, 629)
        Me.tspPFisica.Name = "tspPFisica"
        Me.tspPFisica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tspPFisica.Size = New System.Drawing.Size(906, 79)
        Me.tspPFisica.TabIndex = 66
        Me.tspPFisica.Text = "ToolStrip1"
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
        'btnProximo
        '
        Me.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnProximo.Image = CType(resources.GetObject("btnProximo.Image"), System.Drawing.Image)
        Me.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(68, 76)
        Me.btnProximo.Text = "Ir ao proximo"
        Me.btnProximo.ToolTipText = "Ir para o proximo"
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
        'BtnLimpar
        '
        Me.BtnLimpar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(68, 76)
        Me.BtnLimpar.Text = "Novo"
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
        'grpContatoPFisica
        '
        Me.grpContatoPFisica.Controls.Add(Me.mskCelular)
        Me.grpContatoPFisica.Controls.Add(Me.lblCel)
        Me.grpContatoPFisica.Controls.Add(Me.lblFonRes)
        Me.grpContatoPFisica.Controls.Add(Me.lblEmail)
        Me.grpContatoPFisica.Controls.Add(Me.lblFoneCom)
        Me.grpContatoPFisica.Controls.Add(Me.lblNextel)
        Me.grpContatoPFisica.Controls.Add(Me.mskTelRecado)
        Me.grpContatoPFisica.Controls.Add(Me.mskTelResid)
        Me.grpContatoPFisica.Controls.Add(Me.txtEmail)
        Me.grpContatoPFisica.Controls.Add(Me.txtNextel)
        Me.grpContatoPFisica.Location = New System.Drawing.Point(12, 364)
        Me.grpContatoPFisica.Name = "grpContatoPFisica"
        Me.grpContatoPFisica.Size = New System.Drawing.Size(885, 123)
        Me.grpContatoPFisica.TabIndex = 53
        Me.grpContatoPFisica.TabStop = False
        Me.grpContatoPFisica.Text = "Contato"
        '
        'grpDadosPFisica
        '
        Me.grpDadosPFisica.Controls.Add(Me.txtItem)
        Me.grpDadosPFisica.Controls.Add(Me.cboOrgExp)
        Me.grpDadosPFisica.Controls.Add(Me.lblItem)
        Me.grpDadosPFisica.Controls.Add(Me.mskCNH)
        Me.grpDadosPFisica.Controls.Add(Me.lblStatus)
        Me.grpDadosPFisica.Controls.Add(Me.cboStatus)
        Me.grpDadosPFisica.Controls.Add(Me.mskRG)
        Me.grpDadosPFisica.Controls.Add(Me.mskNascimento)
        Me.grpDadosPFisica.Controls.Add(Me.mskDataExp)
        Me.grpDadosPFisica.Controls.Add(Me.lblId)
        Me.grpDadosPFisica.Controls.Add(Me.TxtId)
        Me.grpDadosPFisica.Controls.Add(Me.lblNome)
        Me.grpDadosPFisica.Controls.Add(Me.lblCPF)
        Me.grpDadosPFisica.Controls.Add(Me.lblDataNasc)
        Me.grpDadosPFisica.Controls.Add(Me.LabelProfissao)
        Me.grpDadosPFisica.Controls.Add(Me.lblSexo)
        Me.grpDadosPFisica.Controls.Add(Me.cboTempoHab)
        Me.grpDadosPFisica.Controls.Add(Me.lblTempoHab)
        Me.grpDadosPFisica.Controls.Add(Me.txtTempoHab)
        Me.grpDadosPFisica.Controls.Add(Me.lblOrgaoExp)
        Me.grpDadosPFisica.Controls.Add(Me.lblDataExp)
        Me.grpDadosPFisica.Controls.Add(Me.txtProfissao)
        Me.grpDadosPFisica.Controls.Add(Me.lblRG)
        Me.grpDadosPFisica.Controls.Add(Me.lblCNH)
        Me.grpDadosPFisica.Controls.Add(Me.MskCPF)
        Me.grpDadosPFisica.Controls.Add(Me.lblEstCivil)
        Me.grpDadosPFisica.Controls.Add(Me.cboEstCivil)
        Me.grpDadosPFisica.Controls.Add(Me.cboSexo)
        Me.grpDadosPFisica.Controls.Add(Me.txtNome)
        Me.grpDadosPFisica.Location = New System.Drawing.Point(12, 52)
        Me.grpDadosPFisica.Name = "grpDadosPFisica"
        Me.grpDadosPFisica.Size = New System.Drawing.Size(507, 306)
        Me.grpDadosPFisica.TabIndex = 4
        Me.grpDadosPFisica.TabStop = False
        Me.grpDadosPFisica.Text = "Informações do Cliente"
        '
        'txtItem
        '
        Me.txtItem.Enabled = False
        Me.txtItem.Location = New System.Drawing.Point(288, 298)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(100, 20)
        Me.txtItem.TabIndex = 33
        Me.txtItem.Text = "AUTO"
        '
        'cboOrgExp
        '
        Me.cboOrgExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrgExp.FormattingEnabled = True
        Me.cboOrgExp.Items.AddRange(New Object() {"Selecione", "SSP-AC", "SSP-AL", "SSP-AP", "SSP-AM", "SSP-BA", "SSP-CE", "SSP-DF", "SSP-ES", "SSP-GO", "SSP-MA", "SSP-MT", "SSP-MS", "SSP-MG", "SSP-PR", "SSP-PB", "SSP-PA", "SSP-PE", "SSP-PI", "SSP-RJ", "SSP-RN", "SSP-RS", "SSP-RO", "SSP-RR", "SSP-SC", "SSP-SE", "SSP-SP", "SSP-TO"})
        Me.cboOrgExp.Location = New System.Drawing.Point(296, 180)
        Me.cboOrgExp.Name = "cboOrgExp"
        Me.cboOrgExp.Size = New System.Drawing.Size(97, 22)
        Me.cboOrgExp.TabIndex = 22
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.BackColor = System.Drawing.Color.Transparent
        Me.lblItem.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(238, 278)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(41, 15)
        Me.lblItem.TabIndex = 32
        Me.lblItem.Text = "Item:*"
        '
        'mskCNH
        '
        Me.mskCNH.Location = New System.Drawing.Point(86, 252)
        Me.mskCNH.Mask = "00000000000"
        Me.mskCNH.Name = "mskCNH"
        Me.mskCNH.Size = New System.Drawing.Size(76, 20)
        Me.mskCNH.TabIndex = 26
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(31, 279)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(51, 15)
        Me.lblStatus.TabIndex = 30
        Me.lblStatus.Text = "Status:*"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Selecione", "Aguardando confirmação", "Frio", "Morno", "Quente", "Ativo"})
        Me.cboStatus.Location = New System.Drawing.Point(84, 297)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(128, 22)
        Me.cboStatus.TabIndex = 31
        '
        'mskRG
        '
        Me.mskRG.Location = New System.Drawing.Point(87, 179)
        Me.mskRG.Mask = "&&,&&&,&&&-&"
        Me.mskRG.Name = "mskRG"
        Me.mskRG.Size = New System.Drawing.Size(85, 20)
        Me.mskRG.TabIndex = 20
        '
        'mskNascimento
        '
        Me.mskNascimento.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskNascimento.Location = New System.Drawing.Point(311, 127)
        Me.mskNascimento.Mask = "00/00/0000"
        Me.mskNascimento.Name = "mskNascimento"
        Me.mskNascimento.Size = New System.Drawing.Size(76, 22)
        Me.mskNascimento.TabIndex = 18
        Me.mskNascimento.ValidatingType = GetType(Date)
        '
        'mskDataExp
        '
        Me.mskDataExp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDataExp.Location = New System.Drawing.Point(312, 90)
        Me.mskDataExp.Mask = "00/00/0000"
        Me.mskDataExp.Name = "mskDataExp"
        Me.mskDataExp.Size = New System.Drawing.Size(76, 22)
        Me.mskDataExp.TabIndex = 14
        Me.mskDataExp.ValidatingType = GetType(Date)
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(372, 33)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(20, 15)
        Me.lblId.TabIndex = 7
        Me.lblId.Text = "ID"
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(398, 28)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(41, 22)
        Me.TxtId.TabIndex = 8
        '
        'grpEndPFisica
        '
        Me.grpEndPFisica.Controls.Add(Me.txtEndereco)
        Me.grpEndPFisica.Controls.Add(Me.lblEndereco)
        Me.grpEndPFisica.Controls.Add(Me.txtNumCasa)
        Me.grpEndPFisica.Controls.Add(Me.lblNumeroCasa)
        Me.grpEndPFisica.Controls.Add(Me.mskCEP)
        Me.grpEndPFisica.Controls.Add(Me.txtApto)
        Me.grpEndPFisica.Controls.Add(Me.lblBairro)
        Me.grpEndPFisica.Controls.Add(Me.lblCidade)
        Me.grpEndPFisica.Controls.Add(Me.txtBairro)
        Me.grpEndPFisica.Controls.Add(Me.cboUf)
        Me.grpEndPFisica.Controls.Add(Me.txtCidade)
        Me.grpEndPFisica.Controls.Add(Me.lblCEP)
        Me.grpEndPFisica.Controls.Add(Me.lblApto)
        Me.grpEndPFisica.Controls.Add(Me.txtComplemento)
        Me.grpEndPFisica.Controls.Add(Me.lblComplemento)
        Me.grpEndPFisica.Controls.Add(Me.lblUF)
        Me.grpEndPFisica.Controls.Add(Me.txtBloco)
        Me.grpEndPFisica.Controls.Add(Me.lblBloco)
        Me.grpEndPFisica.Location = New System.Drawing.Point(525, 52)
        Me.grpEndPFisica.Name = "grpEndPFisica"
        Me.grpEndPFisica.Size = New System.Drawing.Size(372, 306)
        Me.grpEndPFisica.TabIndex = 34
        Me.grpEndPFisica.TabStop = False
        Me.grpEndPFisica.Text = "Endereço"
        '
        'lblPesquisa
        '
        Me.lblPesquisa.AutoSize = True
        Me.lblPesquisa.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesquisa.Location = New System.Drawing.Point(274, 23)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(57, 13)
        Me.lblPesquisa.TabIndex = 2
        Me.lblPesquisa.Text = "Pesquisa:"
        '
        'picPesq
        '
        Me.picPesq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPesq.Image = CType(resources.GetObject("picPesq.Image"), System.Drawing.Image)
        Me.picPesq.Location = New System.Drawing.Point(436, 16)
        Me.picPesq.Name = "picPesq"
        Me.picPesq.Size = New System.Drawing.Size(29, 30)
        Me.picPesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPesq.TabIndex = 71
        Me.picPesq.TabStop = False
        '
        'mskPesqCPF
        '
        Me.mskPesqCPF.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPesqCPF.Location = New System.Drawing.Point(337, 20)
        Me.mskPesqCPF.Mask = "000,000,000-00"
        Me.mskPesqCPF.Name = "mskPesqCPF"
        Me.mskPesqCPF.Size = New System.Drawing.Size(92, 22)
        Me.mskPesqCPF.TabIndex = 3
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(6, 19)
        Me.txtComentario.MaxLength = 300
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(873, 94)
        Me.txtComentario.TabIndex = 65
        '
        'grpComentPFisica
        '
        Me.grpComentPFisica.Controls.Add(Me.txtComentario)
        Me.grpComentPFisica.Location = New System.Drawing.Point(12, 496)
        Me.grpComentPFisica.Name = "grpComentPFisica"
        Me.grpComentPFisica.Size = New System.Drawing.Size(885, 119)
        Me.grpComentPFisica.TabIndex = 64
        Me.grpComentPFisica.TabStop = False
        Me.grpComentPFisica.Text = "Comentários:"
        '
        'frmCadPFisica
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 708)
        Me.Controls.Add(Me.grpComentPFisica)
        Me.Controls.Add(Me.mskPesqCPF)
        Me.Controls.Add(Me.picPesq)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.grpEndPFisica)
        Me.Controls.Add(Me.grpDadosPFisica)
        Me.Controls.Add(Me.grpContatoPFisica)
        Me.Controls.Add(Me.tspPFisica)
        Me.Controls.Add(Me.lblDescPag)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadPFisica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Cadastrar Pessoa Física ="
        Me.tspPFisica.ResumeLayout(False)
        Me.tspPFisica.PerformLayout()
        Me.grpContatoPFisica.ResumeLayout(False)
        Me.grpContatoPFisica.PerformLayout()
        Me.grpDadosPFisica.ResumeLayout(False)
        Me.grpDadosPFisica.PerformLayout()
        Me.grpEndPFisica.ResumeLayout(False)
        Me.grpEndPFisica.PerformLayout()
        CType(Me.picPesq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpComentPFisica.ResumeLayout(False)
        Me.grpComentPFisica.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescPag As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblCPF As System.Windows.Forms.Label
    Friend WithEvents lblDataNasc As System.Windows.Forms.Label
    Friend WithEvents LabelProfissao As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblTempoHab As System.Windows.Forms.Label
    Friend WithEvents lblOrgaoExp As System.Windows.Forms.Label
    Friend WithEvents lblDataExp As System.Windows.Forms.Label
    Friend WithEvents lblRG As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblCel As System.Windows.Forms.Label
    Friend WithEvents lblCNH As System.Windows.Forms.Label
    Friend WithEvents lblFonRes As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents lblEstCivil As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblFoneCom As System.Windows.Forms.Label
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblNextel As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCasa As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCasa As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents mskCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboUf As System.Windows.Forms.ComboBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents cboEstCivil As System.Windows.Forms.ComboBox
    Friend WithEvents MskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtProfissao As System.Windows.Forms.TextBox
    Friend WithEvents txtTempoHab As System.Windows.Forms.TextBox
    Friend WithEvents cboTempoHab As System.Windows.Forms.ComboBox
    Friend WithEvents mskCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTelRecado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTelResid As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNextel As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblBloco As System.Windows.Forms.Label
    Friend WithEvents txtBloco As System.Windows.Forms.TextBox
    Friend WithEvents lblApto As System.Windows.Forms.Label
    Friend WithEvents txtApto As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tspPFisica As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCadastrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrimeiro As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnVoltar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProximo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpContatoPFisica As System.Windows.Forms.GroupBox
    Friend WithEvents grpDadosPFisica As System.Windows.Forms.GroupBox
    Friend WithEvents grpEndPFisica As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLimpar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPesquisa As System.Windows.Forms.Label
    Friend WithEvents picPesq As System.Windows.Forms.PictureBox
    Friend WithEvents mskNascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskDataExp As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskPesqCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents grpComentPFisica As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents mskCNH As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboOrgExp As System.Windows.Forms.ComboBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
End Class
