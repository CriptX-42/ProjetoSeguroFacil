<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastrarSeguradora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastrarSeguradora))
        Me.LabelDescPag = New DevExpress.XtraEditors.LabelControl()
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
        Me.gBoxSegParc = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lbId = New System.Windows.Forms.Label()
        Me.txtNextel = New System.Windows.Forms.TextBox()
        Me.lbNextel = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.lblComentarios = New System.Windows.Forms.Label()
        Me.txtSiteAreaCorretor = New System.Windows.Forms.TextBox()
        Me.lblSiteAreaCorretor = New System.Windows.Forms.Label()
        Me.MaskTxtTelefone2 = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefone2 = New System.Windows.Forms.Label()
        Me.MaskTxtTelefone1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefone1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.lblSite = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNomeSeguradora = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.gBoxSegParc.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDescPag
        '
        Me.LabelDescPag.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescPag.Location = New System.Drawing.Point(12, 12)
        Me.LabelDescPag.Name = "LabelDescPag"
        Me.LabelDescPag.Size = New System.Drawing.Size(315, 24)
        Me.LabelDescPag.TabIndex = 6
        Me.LabelDescPag.Text = "Cadastro de Seguradoras Parceiras"
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
        Me.btnPrimeiro.Size = New System.Drawing.Size(68, 88)
        Me.btnPrimeiro.Text = "Voltar ao ultimo"
        Me.btnPrimeiro.ToolTipText = "Ir para o primeiro"
        '
        'btnVoltar
        '
        Me.btnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(68, 88)
        Me.btnVoltar.Text = "Voltar ao anterior"
        Me.btnVoltar.ToolTipText = "Voltar"
        '
        'btnIr
        '
        Me.btnIr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIr.Image = CType(resources.GetObject("btnIr.Image"), System.Drawing.Image)
        Me.btnIr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(68, 88)
        Me.btnIr.Text = "Ir ao proximo"
        Me.btnIr.ToolTipText = "Ir para o proximo"
        '
        'btnUltimo
        '
        Me.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(68, 88)
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
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 346)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(735, 91)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 91)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 91)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 91)
        '
        'btnExcluir
        '
        Me.btnExcluir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(68, 88)
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
        Me.btnAlterar.Size = New System.Drawing.Size(68, 88)
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.ToolTipText = "Alterar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 91)
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCadastrar.ForeColor = System.Drawing.Color.Black
        Me.BtnCadastrar.Image = Global.SeguroFacil.My.Resources.Resources.Botão
        Me.BtnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(68, 88)
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
        Me.BtLimpar.Size = New System.Drawing.Size(68, 88)
        Me.BtLimpar.Text = "Novo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 91)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(68, 88)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(68, 88)
        Me.btnImprimir.Text = "Imprimir"
        '
        'gBoxSegParc
        '
        Me.gBoxSegParc.Controls.Add(Me.txtId)
        Me.gBoxSegParc.Controls.Add(Me.lbId)
        Me.gBoxSegParc.Controls.Add(Me.txtNextel)
        Me.gBoxSegParc.Controls.Add(Me.lbNextel)
        Me.gBoxSegParc.Controls.Add(Me.txtComentarios)
        Me.gBoxSegParc.Controls.Add(Me.lblComentarios)
        Me.gBoxSegParc.Controls.Add(Me.txtSiteAreaCorretor)
        Me.gBoxSegParc.Controls.Add(Me.lblSiteAreaCorretor)
        Me.gBoxSegParc.Controls.Add(Me.MaskTxtTelefone2)
        Me.gBoxSegParc.Controls.Add(Me.lblTelefone2)
        Me.gBoxSegParc.Controls.Add(Me.MaskTxtTelefone1)
        Me.gBoxSegParc.Controls.Add(Me.lblTelefone1)
        Me.gBoxSegParc.Controls.Add(Me.txtEmail)
        Me.gBoxSegParc.Controls.Add(Me.lblEmail)
        Me.gBoxSegParc.Controls.Add(Me.txtSite)
        Me.gBoxSegParc.Controls.Add(Me.lblSite)
        Me.gBoxSegParc.Controls.Add(Me.txtNome)
        Me.gBoxSegParc.Controls.Add(Me.lblNomeSeguradora)
        Me.gBoxSegParc.Location = New System.Drawing.Point(98, 42)
        Me.gBoxSegParc.Name = "gBoxSegParc"
        Me.gBoxSegParc.Size = New System.Drawing.Size(546, 294)
        Me.gBoxSegParc.TabIndex = 1
        Me.gBoxSegParc.TabStop = False
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(448, 21)
        Me.txtId.MaxLength = 120
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(83, 22)
        Me.txtId.TabIndex = 51
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.BackColor = System.Drawing.Color.Transparent
        Me.lbId.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbId.Location = New System.Drawing.Point(418, 24)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(24, 15)
        Me.lbId.TabIndex = 50
        Me.lbId.Text = "ID:"
        '
        'txtNextel
        '
        Me.txtNextel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextel.Location = New System.Drawing.Point(164, 156)
        Me.txtNextel.Name = "txtNextel"
        Me.txtNextel.Size = New System.Drawing.Size(107, 22)
        Me.txtNextel.TabIndex = 8
        '
        'lbNextel
        '
        Me.lbNextel.AutoSize = True
        Me.lbNextel.BackColor = System.Drawing.Color.Transparent
        Me.lbNextel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNextel.Location = New System.Drawing.Point(112, 163)
        Me.lbNextel.Name = "lbNextel"
        Me.lbNextel.Size = New System.Drawing.Size(46, 15)
        Me.lbNextel.TabIndex = 48
        Me.lbNextel.Text = "Nextel:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.Location = New System.Drawing.Point(12, 210)
        Me.txtComentarios.MaxLength = 300
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(519, 70)
        Me.txtComentarios.TabIndex = 9
        '
        'lblComentarios
        '
        Me.lblComentarios.AutoSize = True
        Me.lblComentarios.BackColor = System.Drawing.Color.Transparent
        Me.lblComentarios.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentarios.Location = New System.Drawing.Point(6, 188)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Size = New System.Drawing.Size(81, 15)
        Me.lblComentarios.TabIndex = 46
        Me.lblComentarios.Text = "Comentários:"
        '
        'txtSiteAreaCorretor
        '
        Me.txtSiteAreaCorretor.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSiteAreaCorretor.Location = New System.Drawing.Point(164, 92)
        Me.txtSiteAreaCorretor.MaxLength = 120
        Me.txtSiteAreaCorretor.Name = "txtSiteAreaCorretor"
        Me.txtSiteAreaCorretor.Size = New System.Drawing.Size(143, 22)
        Me.txtSiteAreaCorretor.TabIndex = 4
        '
        'lblSiteAreaCorretor
        '
        Me.lblSiteAreaCorretor.AutoSize = True
        Me.lblSiteAreaCorretor.BackColor = System.Drawing.Color.Transparent
        Me.lblSiteAreaCorretor.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSiteAreaCorretor.Location = New System.Drawing.Point(6, 95)
        Me.lblSiteAreaCorretor.Name = "lblSiteAreaCorretor"
        Me.lblSiteAreaCorretor.Size = New System.Drawing.Size(152, 15)
        Me.lblSiteAreaCorretor.TabIndex = 44
        Me.lblSiteAreaCorretor.Text = "Site da Área do Corretor:*"
        '
        'MaskTxtTelefone2
        '
        Me.MaskTxtTelefone2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskTxtTelefone2.Location = New System.Drawing.Point(388, 126)
        Me.MaskTxtTelefone2.Mask = "(00)00000-0000"
        Me.MaskTxtTelefone2.Name = "MaskTxtTelefone2"
        Me.MaskTxtTelefone2.Size = New System.Drawing.Size(100, 22)
        Me.MaskTxtTelefone2.TabIndex = 7
        '
        'lblTelefone2
        '
        Me.lblTelefone2.AutoSize = True
        Me.lblTelefone2.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefone2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone2.Location = New System.Drawing.Point(316, 129)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(53, 15)
        Me.lblTelefone2.TabIndex = 42
        Me.lblTelefone2.Text = "Celular:"
        '
        'MaskTxtTelefone1
        '
        Me.MaskTxtTelefone1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskTxtTelefone1.Location = New System.Drawing.Point(164, 122)
        Me.MaskTxtTelefone1.Mask = "(00)0000-0000"
        Me.MaskTxtTelefone1.Name = "MaskTxtTelefone1"
        Me.MaskTxtTelefone1.Size = New System.Drawing.Size(100, 22)
        Me.MaskTxtTelefone1.TabIndex = 6
        '
        'lblTelefone1
        '
        Me.lblTelefone1.AutoSize = True
        Me.lblTelefone1.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefone1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone1.Location = New System.Drawing.Point(84, 129)
        Me.lblTelefone1.Name = "lblTelefone1"
        Me.lblTelefone1.Size = New System.Drawing.Size(74, 15)
        Me.lblTelefone1.TabIndex = 40
        Me.lblTelefone1.Text = "Telefone 1:*"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(388, 92)
        Me.txtEmail.MaxLength = 60
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(143, 22)
        Me.txtEmail.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(320, 95)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 15)
        Me.lblEmail.TabIndex = 38
        Me.lblEmail.Text = "Email:*"
        '
        'txtSite
        '
        Me.txtSite.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSite.Location = New System.Drawing.Point(388, 55)
        Me.txtSite.MaxLength = 120
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(143, 22)
        Me.txtSite.TabIndex = 3
        '
        'lblSite
        '
        Me.lblSite.AutoSize = True
        Me.lblSite.BackColor = System.Drawing.Color.Transparent
        Me.lblSite.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSite.Location = New System.Drawing.Point(329, 58)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.Size = New System.Drawing.Size(40, 15)
        Me.lblSite.TabIndex = 36
        Me.lblSite.Text = "Site:*"
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(164, 55)
        Me.txtNome.MaxLength = 30
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(143, 22)
        Me.txtNome.TabIndex = 2
        '
        'lblNomeSeguradora
        '
        Me.lblNomeSeguradora.AutoSize = True
        Me.lblNomeSeguradora.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeSeguradora.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeSeguradora.Location = New System.Drawing.Point(27, 58)
        Me.lblNomeSeguradora.Name = "lblNomeSeguradora"
        Me.lblNomeSeguradora.Size = New System.Drawing.Size(131, 15)
        Me.lblNomeSeguradora.TabIndex = 34
        Me.lblNomeSeguradora.Text = "Nome da Seguradora:*"
        '
        'CadastrarSeguradora
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 437)
        Me.Controls.Add(Me.gBoxSegParc)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LabelDescPag)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastrarSeguradora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Cadastrar Seguradora ="
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gBoxSegParc.ResumeLayout(False)
        Me.gBoxSegParc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDescPag As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents gBoxSegParc As System.Windows.Forms.GroupBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lbId As System.Windows.Forms.Label
    Friend WithEvents txtNextel As System.Windows.Forms.TextBox
    Friend WithEvents lbNextel As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents lblComentarios As System.Windows.Forms.Label
    Friend WithEvents txtSiteAreaCorretor As System.Windows.Forms.TextBox
    Friend WithEvents lblSiteAreaCorretor As System.Windows.Forms.Label
    Friend WithEvents MaskTxtTelefone2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTelefone2 As System.Windows.Forms.Label
    Friend WithEvents MaskTxtTelefone1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTelefone1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents lblSite As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNomeSeguradora As System.Windows.Forms.Label
End Class
