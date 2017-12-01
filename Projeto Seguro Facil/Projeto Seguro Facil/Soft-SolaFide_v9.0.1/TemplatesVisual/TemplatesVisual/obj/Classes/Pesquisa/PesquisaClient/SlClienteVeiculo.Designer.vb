<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlClienteVeiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SlClienteVeiculo))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AbaPessoa = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.DgvPesquisa = New System.Windows.Forms.DataGridView()
        Me.id_Pessoa_Fisica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_completo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Dados_Veiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fabricante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelDescPag = New DevExpress.XtraEditors.LabelControl()
        Me.AbaCondutores = New System.Windows.Forms.TabPage()
        Me.DgvPessoaJuridica = New System.Windows.Forms.DataGridView()
        Me.id_Pessoa_Juridica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.representanteJuri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Dados_Veiculo_Juri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fabricanteJuri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modeloJuri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPesquisaJuridica = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TabControl1.SuspendLayout()
        Me.AbaPessoa.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPesquisa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbaCondutores.SuspendLayout()
        CType(Me.DgvPessoaJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AbaPessoa)
        Me.TabControl1.Controls.Add(Me.AbaCondutores)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(596, 329)
        Me.TabControl1.TabIndex = 7
        '
        'AbaPessoa
        '
        Me.AbaPessoa.Controls.Add(Me.PictureBox1)
        Me.AbaPessoa.Controls.Add(Me.ComboBox1)
        Me.AbaPessoa.Controls.Add(Me.Label2)
        Me.AbaPessoa.Controls.Add(Me.Label1)
        Me.AbaPessoa.Controls.Add(Me.txtPesquisa)
        Me.AbaPessoa.Controls.Add(Me.DgvPesquisa)
        Me.AbaPessoa.Controls.Add(Me.LabelDescPag)
        Me.AbaPessoa.Location = New System.Drawing.Point(4, 22)
        Me.AbaPessoa.Name = "AbaPessoa"
        Me.AbaPessoa.Padding = New System.Windows.Forms.Padding(3)
        Me.AbaPessoa.Size = New System.Drawing.Size(588, 303)
        Me.AbaPessoa.TabIndex = 0
        Me.AbaPessoa.Text = "Pessoa Física"
        Me.AbaPessoa.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SeguroFacil.My.Resources.Resources.Action_ok_icon
        Me.PictureBox1.Location = New System.Drawing.Point(241, 222)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(304, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Pesquisar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Pesquisa:"
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Location = New System.Drawing.Point(69, 32)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(136, 21)
        Me.txtPesquisa.TabIndex = 1
        '
        'DgvPesquisa
        '
        Me.DgvPesquisa.AllowUserToAddRows = False
        Me.DgvPesquisa.AllowUserToDeleteRows = False
        Me.DgvPesquisa.AllowUserToOrderColumns = True
        Me.DgvPesquisa.BackgroundColor = System.Drawing.Color.White
        Me.DgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPesquisa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Pessoa_Fisica, Me.nome_completo, Me.id_Dados_Veiculo, Me.fabricante, Me.modelo})
        Me.DgvPesquisa.GridColor = System.Drawing.Color.Black
        Me.DgvPesquisa.Location = New System.Drawing.Point(9, 59)
        Me.DgvPesquisa.Name = "DgvPesquisa"
        Me.DgvPesquisa.ReadOnly = True
        Me.DgvPesquisa.Size = New System.Drawing.Size(573, 157)
        Me.DgvPesquisa.TabIndex = 14
        '
        'id_Pessoa_Fisica
        '
        Me.id_Pessoa_Fisica.DataPropertyName = "id_Pessoa_Fisica"
        Me.id_Pessoa_Fisica.HeaderText = "ID"
        Me.id_Pessoa_Fisica.Name = "id_Pessoa_Fisica"
        Me.id_Pessoa_Fisica.ReadOnly = True
        '
        'nome_completo
        '
        Me.nome_completo.DataPropertyName = "nome_completo"
        Me.nome_completo.HeaderText = "Nome Completo"
        Me.nome_completo.Name = "nome_completo"
        Me.nome_completo.ReadOnly = True
        '
        'id_Dados_Veiculo
        '
        Me.id_Dados_Veiculo.DataPropertyName = "id_Dados_Veiculo"
        Me.id_Dados_Veiculo.HeaderText = "Código do Carro"
        Me.id_Dados_Veiculo.Name = "id_Dados_Veiculo"
        Me.id_Dados_Veiculo.ReadOnly = True
        '
        'fabricante
        '
        Me.fabricante.DataPropertyName = "fabricante"
        Me.fabricante.HeaderText = "Fabricante"
        Me.fabricante.Name = "fabricante"
        Me.fabricante.ReadOnly = True
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "modelo"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'LabelDescPag
        '
        Me.LabelDescPag.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescPag.Location = New System.Drawing.Point(9, 2)
        Me.LabelDescPag.Name = "LabelDescPag"
        Me.LabelDescPag.Size = New System.Drawing.Size(69, 24)
        Me.LabelDescPag.TabIndex = 13
        Me.LabelDescPag.Text = "Seleção"
        '
        'AbaCondutores
        '
        Me.AbaCondutores.Controls.Add(Me.DgvPessoaJuridica)
        Me.AbaCondutores.Controls.Add(Me.PictureBox2)
        Me.AbaCondutores.Controls.Add(Me.ComboBox2)
        Me.AbaCondutores.Controls.Add(Me.Label3)
        Me.AbaCondutores.Controls.Add(Me.Label4)
        Me.AbaCondutores.Controls.Add(Me.txtPesquisaJuridica)
        Me.AbaCondutores.Controls.Add(Me.DataGridView2)
        Me.AbaCondutores.Controls.Add(Me.LabelControl1)
        Me.AbaCondutores.Location = New System.Drawing.Point(4, 22)
        Me.AbaCondutores.Name = "AbaCondutores"
        Me.AbaCondutores.Padding = New System.Windows.Forms.Padding(3)
        Me.AbaCondutores.Size = New System.Drawing.Size(588, 303)
        Me.AbaCondutores.TabIndex = 1
        Me.AbaCondutores.Text = "Pessoa Jurídica"
        Me.AbaCondutores.UseVisualStyleBackColor = True
        '
        'DgvPessoaJuridica
        '
        Me.DgvPessoaJuridica.AllowUserToAddRows = False
        Me.DgvPessoaJuridica.AllowUserToDeleteRows = False
        Me.DgvPessoaJuridica.AllowUserToOrderColumns = True
        Me.DgvPessoaJuridica.BackgroundColor = System.Drawing.Color.White
        Me.DgvPessoaJuridica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPessoaJuridica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Pessoa_Juridica, Me.representanteJuri, Me.id_Dados_Veiculo_Juri, Me.fabricanteJuri, Me.modeloJuri})
        Me.DgvPessoaJuridica.Location = New System.Drawing.Point(9, 63)
        Me.DgvPessoaJuridica.Name = "DgvPessoaJuridica"
        Me.DgvPessoaJuridica.ReadOnly = True
        Me.DgvPessoaJuridica.Size = New System.Drawing.Size(661, 157)
        Me.DgvPessoaJuridica.TabIndex = 26
        '
        'id_Pessoa_Juridica
        '
        Me.id_Pessoa_Juridica.DataPropertyName = "id_Pessoa_Juridica"
        Me.id_Pessoa_Juridica.HeaderText = "ID"
        Me.id_Pessoa_Juridica.Name = "id_Pessoa_Juridica"
        Me.id_Pessoa_Juridica.ReadOnly = True
        '
        'representanteJuri
        '
        Me.representanteJuri.DataPropertyName = "representante"
        Me.representanteJuri.HeaderText = "Representante"
        Me.representanteJuri.Name = "representanteJuri"
        Me.representanteJuri.ReadOnly = True
        '
        'id_Dados_Veiculo_Juri
        '
        Me.id_Dados_Veiculo_Juri.DataPropertyName = "id_Dados_Veiculo"
        Me.id_Dados_Veiculo_Juri.HeaderText = "Código do veiculo"
        Me.id_Dados_Veiculo_Juri.Name = "id_Dados_Veiculo_Juri"
        Me.id_Dados_Veiculo_Juri.ReadOnly = True
        '
        'fabricanteJuri
        '
        Me.fabricanteJuri.DataPropertyName = "fabricante"
        Me.fabricanteJuri.HeaderText = "Fabricante"
        Me.fabricanteJuri.Name = "fabricanteJuri"
        Me.fabricanteJuri.ReadOnly = True
        '
        'modeloJuri
        '
        Me.modeloJuri.DataPropertyName = "modelo"
        Me.modeloJuri.HeaderText = "Modelo"
        Me.modeloJuri.Name = "modeloJuri"
        Me.modeloJuri.ReadOnly = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.SeguroFacil.My.Resources.Resources.Action_ok_icon
        Me.PictureBox2.Location = New System.Drawing.Point(263, 222)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(304, 35)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Pesquisar por:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Pesquisa:"
        '
        'txtPesquisaJuridica
        '
        Me.txtPesquisaJuridica.Location = New System.Drawing.Point(69, 36)
        Me.txtPesquisaJuridica.Name = "txtPesquisaJuridica"
        Me.txtPesquisaJuridica.Size = New System.Drawing.Size(136, 21)
        Me.txtPesquisaJuridica.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.Color.Black
        Me.DataGridView2.Location = New System.Drawing.Point(9, 88)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(661, 132)
        Me.DataGridView2.TabIndex = 14
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(9, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 24)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Seleção"
        '
        'SlClienteVeiculo
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 345)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SlClienteVeiculo"
        Me.Text = "= Selecione o Cliente ="
        Me.TabControl1.ResumeLayout(False)
        Me.AbaPessoa.ResumeLayout(False)
        Me.AbaPessoa.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPesquisa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbaCondutores.ResumeLayout(False)
        Me.AbaCondutores.PerformLayout()
        CType(Me.DgvPessoaJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents AbaPessoa As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents DgvPesquisa As System.Windows.Forms.DataGridView
    Friend WithEvents LabelDescPag As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AbaCondutores As System.Windows.Forms.TabPage
    Friend WithEvents DgvPessoaJuridica As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPesquisaJuridica As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id_Pessoa_Fisica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_completo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_Dados_Veiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fabricante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_Pessoa_Juridica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents representanteJuri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_Dados_Veiculo_Juri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fabricanteJuri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modeloJuri As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
