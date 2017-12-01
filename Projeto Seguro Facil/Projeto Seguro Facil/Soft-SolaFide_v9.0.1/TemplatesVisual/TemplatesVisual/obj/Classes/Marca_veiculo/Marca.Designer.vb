<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marca))
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtVeiculo = New System.Windows.Forms.TextBox()
        Me.CboMarcas = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCadastrar = New System.Windows.Forms.ToolStripButton()
        Me.BtLimpar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbVeiculo = New System.Windows.Forms.RadioButton()
        Me.RbMarca = New System.Windows.Forms.RadioButton()
        Me.lbNovoVeiculo = New System.Windows.Forms.Label()
        Me.lbNovaMarca = New System.Windows.Forms.Label()
        Me.lbMarca = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvVeiculos = New System.Windows.Forms.DataGridView()
        Me.id_Veiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Veiculos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvMarca = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvVeiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMarca
        '
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Location = New System.Drawing.Point(441, 55)
        Me.txtMarca.MaxLength = 45
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(164, 21)
        Me.txtMarca.TabIndex = 0
        '
        'txtVeiculo
        '
        Me.txtVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVeiculo.Location = New System.Drawing.Point(441, 82)
        Me.txtVeiculo.MaxLength = 45
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.Size = New System.Drawing.Size(164, 21)
        Me.txtVeiculo.TabIndex = 1
        '
        'CboMarcas
        '
        Me.CboMarcas.FormattingEnabled = True
        Me.CboMarcas.Location = New System.Drawing.Point(441, 27)
        Me.CboMarcas.Name = "CboMarcas"
        Me.CboMarcas.Size = New System.Drawing.Size(164, 21)
        Me.CboMarcas.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator3, Me.btnExcluir, Me.btnAlterar, Me.ToolStripSeparator4, Me.BtnCadastrar, Me.BtLimpar, Me.ToolStripSeparator5, Me.btnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 300)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(681, 79)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 79)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lbNovoVeiculo)
        Me.GroupBox1.Controls.Add(Me.lbNovaMarca)
        Me.GroupBox1.Controls.Add(Me.lbMarca)
        Me.GroupBox1.Controls.Add(Me.txtVeiculo)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.CboMarcas)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 118)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbVeiculo)
        Me.GroupBox2.Controls.Add(Me.RbMarca)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 87)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Novo:"
        '
        'RbVeiculo
        '
        Me.RbVeiculo.AutoSize = True
        Me.RbVeiculo.Location = New System.Drawing.Point(6, 20)
        Me.RbVeiculo.Name = "RbVeiculo"
        Me.RbVeiculo.Size = New System.Drawing.Size(90, 17)
        Me.RbVeiculo.TabIndex = 7
        Me.RbVeiculo.TabStop = True
        Me.RbVeiculo.Text = "Novo veiculo:"
        Me.RbVeiculo.UseVisualStyleBackColor = True
        '
        'RbMarca
        '
        Me.RbMarca.AutoSize = True
        Me.RbMarca.Location = New System.Drawing.Point(6, 53)
        Me.RbMarca.Name = "RbMarca"
        Me.RbMarca.Size = New System.Drawing.Size(86, 17)
        Me.RbMarca.TabIndex = 6
        Me.RbMarca.TabStop = True
        Me.RbMarca.Text = "Nova Marca:"
        Me.RbMarca.UseVisualStyleBackColor = True
        '
        'lbNovoVeiculo
        '
        Me.lbNovoVeiculo.AutoSize = True
        Me.lbNovoVeiculo.Location = New System.Drawing.Point(359, 85)
        Me.lbNovoVeiculo.Name = "lbNovoVeiculo"
        Me.lbNovoVeiculo.Size = New System.Drawing.Size(72, 13)
        Me.lbNovoVeiculo.TabIndex = 5
        Me.lbNovoVeiculo.Text = "Novo veiculo:"
        '
        'lbNovaMarca
        '
        Me.lbNovaMarca.AutoSize = True
        Me.lbNovaMarca.Location = New System.Drawing.Point(363, 58)
        Me.lbNovaMarca.Name = "lbNovaMarca"
        Me.lbNovaMarca.Size = New System.Drawing.Size(68, 13)
        Me.lbNovaMarca.TabIndex = 4
        Me.lbNovaMarca.Text = "Nova marca:"
        '
        'lbMarca
        '
        Me.lbMarca.AutoSize = True
        Me.lbMarca.Location = New System.Drawing.Point(386, 30)
        Me.lbMarca.Name = "lbMarca"
        Me.lbMarca.Size = New System.Drawing.Size(45, 13)
        Me.lbMarca.TabIndex = 3
        Me.lbMarca.Text = "Marcas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 8
        '
        'dgvVeiculos
        '
        Me.dgvVeiculos.AllowUserToAddRows = False
        Me.dgvVeiculos.AllowUserToDeleteRows = False
        Me.dgvVeiculos.BackgroundColor = System.Drawing.Color.White
        Me.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVeiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Veiculo, Me.Veiculos})
        Me.dgvVeiculos.GridColor = System.Drawing.Color.Black
        Me.dgvVeiculos.Location = New System.Drawing.Point(375, 136)
        Me.dgvVeiculos.Name = "dgvVeiculos"
        Me.dgvVeiculos.ReadOnly = True
        Me.dgvVeiculos.Size = New System.Drawing.Size(281, 150)
        Me.dgvVeiculos.TabIndex = 9
        '
        'id_Veiculo
        '
        Me.id_Veiculo.DataPropertyName = "id_lista_Nome_veiculo"
        Me.id_Veiculo.HeaderText = "Cod. Veiculo"
        Me.id_Veiculo.Name = "id_Veiculo"
        Me.id_Veiculo.ReadOnly = True
        '
        'Veiculos
        '
        Me.Veiculos.DataPropertyName = "Nome_veiculo"
        Me.Veiculos.HeaderText = "Veiculos"
        Me.Veiculos.Name = "Veiculos"
        Me.Veiculos.ReadOnly = True
        '
        'DgvMarca
        '
        Me.DgvMarca.AllowUserToAddRows = False
        Me.DgvMarca.AllowUserToDeleteRows = False
        Me.DgvMarca.BackgroundColor = System.Drawing.Color.White
        Me.DgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMarca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.Mark})
        Me.DgvMarca.GridColor = System.Drawing.Color.Black
        Me.DgvMarca.Location = New System.Drawing.Point(42, 136)
        Me.DgvMarca.Name = "DgvMarca"
        Me.DgvMarca.ReadOnly = True
        Me.DgvMarca.Size = New System.Drawing.Size(296, 148)
        Me.DgvMarca.TabIndex = 10
        '
        'cod
        '
        Me.cod.DataPropertyName = "id_lista_veiculo"
        Me.cod.HeaderText = "Cod. da Marca"
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        '
        'Mark
        '
        Me.Mark.DataPropertyName = "Marca"
        Me.Mark.HeaderText = "Marca"
        Me.Mark.Name = "Mark"
        Me.Mark.ReadOnly = True
        '
        'Marca
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 379)
        Me.Controls.Add(Me.DgvMarca)
        Me.Controls.Add(Me.dgvVeiculos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Marca"
        Me.Text = "= Marca/Veiculos ="
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvVeiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtVeiculo As System.Windows.Forms.TextBox
    Friend WithEvents CboMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCadastrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtLimpar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbVeiculo As System.Windows.Forms.RadioButton
    Friend WithEvents RbMarca As System.Windows.Forms.RadioButton
    Friend WithEvents lbNovoVeiculo As System.Windows.Forms.Label
    Friend WithEvents lbNovaMarca As System.Windows.Forms.Label
    Friend WithEvents lbMarca As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvVeiculos As System.Windows.Forms.DataGridView
    Friend WithEvents id_Veiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Veiculos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgvMarca As System.Windows.Forms.DataGridView
    Friend WithEvents cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mark As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
