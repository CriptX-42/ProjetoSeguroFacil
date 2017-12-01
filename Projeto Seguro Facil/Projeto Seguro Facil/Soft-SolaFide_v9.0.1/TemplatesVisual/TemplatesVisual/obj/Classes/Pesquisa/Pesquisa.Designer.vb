<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesquisa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pesquisa))
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
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_expedicao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orgao_exped = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempo_habilitacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.especif_temp_hap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_nascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.profissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelDescPag = New DevExpress.XtraEditors.LabelControl()
        Me.AbaCondutores = New System.Windows.Forms.TabPage()
        Me.DgvPessoaJuridica = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPesquisaJuridica = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.TabControl1.Size = New System.Drawing.Size(685, 329)
        Me.TabControl1.TabIndex = 6
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
        Me.AbaPessoa.Location = New System.Drawing.Point(4, 23)
        Me.AbaPessoa.Name = "AbaPessoa"
        Me.AbaPessoa.Padding = New System.Windows.Forms.Padding(3)
        Me.AbaPessoa.Size = New System.Drawing.Size(677, 302)
        Me.AbaPessoa.TabIndex = 0
        Me.AbaPessoa.Text = "Pessoa Física"
        Me.AbaPessoa.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SeguroFacil.My.Resources.Resources.Action_ok_icon
        Me.PictureBox1.Location = New System.Drawing.Point(304, 221)
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
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
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
        Me.txtPesquisa.Size = New System.Drawing.Size(136, 20)
        Me.txtPesquisa.TabIndex = 1
        '
        'DgvPesquisa
        '
        Me.DgvPesquisa.AllowUserToAddRows = False
        Me.DgvPesquisa.AllowUserToDeleteRows = False
        Me.DgvPesquisa.AllowUserToOrderColumns = True
        Me.DgvPesquisa.BackgroundColor = System.Drawing.Color.White
        Me.DgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPesquisa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Pessoa_Fisica, Me.nome_completo, Me.cpf, Me.rg, Me.dt_expedicao, Me.orgao_exped, Me.cnh, Me.tempo_habilitacao, Me.especif_temp_hap, Me.dt_nascimento, Me.profissao, Me.comentarios})
        Me.DgvPesquisa.GridColor = System.Drawing.Color.Black
        Me.DgvPesquisa.Location = New System.Drawing.Point(9, 59)
        Me.DgvPesquisa.Name = "DgvPesquisa"
        Me.DgvPesquisa.ReadOnly = True
        Me.DgvPesquisa.Size = New System.Drawing.Size(661, 157)
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
        'cpf
        '
        Me.cpf.DataPropertyName = "cpf"
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        '
        'rg
        '
        Me.rg.DataPropertyName = "rg"
        Me.rg.HeaderText = "RG"
        Me.rg.Name = "rg"
        Me.rg.ReadOnly = True
        '
        'dt_expedicao
        '
        Me.dt_expedicao.DataPropertyName = "dt_expedicao"
        Me.dt_expedicao.HeaderText = "Data expedição"
        Me.dt_expedicao.Name = "dt_expedicao"
        Me.dt_expedicao.ReadOnly = True
        '
        'orgao_exped
        '
        Me.orgao_exped.DataPropertyName = "orgao_exped"
        Me.orgao_exped.HeaderText = "Orgão Expeditor"
        Me.orgao_exped.Name = "orgao_exped"
        Me.orgao_exped.ReadOnly = True
        '
        'cnh
        '
        Me.cnh.DataPropertyName = "cnh"
        Me.cnh.HeaderText = "CNH"
        Me.cnh.Name = "cnh"
        Me.cnh.ReadOnly = True
        '
        'tempo_habilitacao
        '
        Me.tempo_habilitacao.DataPropertyName = "tempo_habilitacao"
        Me.tempo_habilitacao.HeaderText = "Tempo Habilitação"
        Me.tempo_habilitacao.Name = "tempo_habilitacao"
        Me.tempo_habilitacao.ReadOnly = True
        '
        'especif_temp_hap
        '
        Me.especif_temp_hap.DataPropertyName = "especif_temp_hap"
        Me.especif_temp_hap.HeaderText = "Especificação "
        Me.especif_temp_hap.Name = "especif_temp_hap"
        Me.especif_temp_hap.ReadOnly = True
        '
        'dt_nascimento
        '
        Me.dt_nascimento.DataPropertyName = "dt_nascimento"
        Me.dt_nascimento.HeaderText = "Data Nascimento"
        Me.dt_nascimento.Name = "dt_nascimento"
        Me.dt_nascimento.ReadOnly = True
        '
        'profissao
        '
        Me.profissao.DataPropertyName = "profissao"
        Me.profissao.HeaderText = "Profissão"
        Me.profissao.Name = "profissao"
        Me.profissao.ReadOnly = True
        '
        'comentarios
        '
        Me.comentarios.DataPropertyName = "comentarios"
        Me.comentarios.HeaderText = "Comentario"
        Me.comentarios.Name = "comentarios"
        Me.comentarios.ReadOnly = True
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
        Me.AbaCondutores.Location = New System.Drawing.Point(4, 23)
        Me.AbaCondutores.Name = "AbaCondutores"
        Me.AbaCondutores.Padding = New System.Windows.Forms.Padding(3)
        Me.AbaCondutores.Size = New System.Drawing.Size(677, 302)
        Me.AbaCondutores.TabIndex = 1
        Me.AbaCondutores.Text = "Pessoa Jurídica"
        Me.AbaCondutores.UseVisualStyleBackColor = True
        '
        'DgvPessoaJuridica
        '
        Me.DgvPessoaJuridica.AllowUserToDeleteRows = False
        Me.DgvPessoaJuridica.BackgroundColor = System.Drawing.Color.White
        Me.DgvPessoaJuridica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPessoaJuridica.Location = New System.Drawing.Point(9, 63)
        Me.DgvPessoaJuridica.Name = "DgvPessoaJuridica"
        Me.DgvPessoaJuridica.ReadOnly = True
        Me.DgvPessoaJuridica.Size = New System.Drawing.Size(661, 157)
        Me.DgvPessoaJuridica.TabIndex = 26
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.SeguroFacil.My.Resources.Resources.Action_ok_icon
        Me.PictureBox2.Location = New System.Drawing.Point(305, 223)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(305, 35)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Pesquisar por:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Pesquisa:"
        '
        'txtPesquisaJuridica
        '
        Me.txtPesquisaJuridica.Location = New System.Drawing.Point(70, 36)
        Me.txtPesquisaJuridica.Name = "txtPesquisaJuridica"
        Me.txtPesquisaJuridica.Size = New System.Drawing.Size(136, 20)
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Pesquisa
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 345)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pesquisa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Seleção ="
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents DgvPesquisa As System.Windows.Forms.DataGridView
    Friend WithEvents LabelDescPag As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AbaCondutores As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPesquisaJuridica As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents id_Pessoa_Fisica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_completo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_expedicao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents orgao_exped As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tempo_habilitacao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents especif_temp_hap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_nascimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents profissao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgvPessoaJuridica As System.Windows.Forms.DataGridView
End Class
