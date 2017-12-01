Partial Public Class PaginaPrincipal
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaginaPrincipal))
        Me.MenuOpcoes = New System.Windows.Forms.MenuStrip()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PessoaFísicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PessoaJurídicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VeículoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaVeiculoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionarioVeiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrçamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguradoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemOpcoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.FazerBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarDadosExcluidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComissõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelDescPag = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnGoCadCli = New System.Windows.Forms.Button()
        Me.btnGoCadEmp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGoCadVei = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nome_Completo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_Nascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.dt_Fim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Orcamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuOpcoes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuOpcoes
        '
        Me.MenuOpcoes.AutoSize = False
        Me.MenuOpcoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.MenuOpcoes.BackgroundImage = CType(resources.GetObject("MenuOpcoes.BackgroundImage"), System.Drawing.Image)
        Me.MenuOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuOpcoes.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.SinistrosToolStripMenuItem, Me.ToolStripMenuItemOpcoes, Me.ComissõesToolStripMenuItem})
        Me.MenuOpcoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.MenuOpcoes.Name = "MenuOpcoes"
        Me.MenuOpcoes.Size = New System.Drawing.Size(1284, 30)
        Me.MenuOpcoes.TabIndex = 0
        Me.MenuOpcoes.Text = "MenuStrip1"
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.VeículoToolStripMenuItem1, Me.OrçamentosToolStripMenuItem, Me.SeguradoraToolStripMenuItem})
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(71, 26)
        Me.CadastrarToolStripMenuItem.Text = "Cadastrar"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PessoaFísicaToolStripMenuItem, Me.PessoaJurídicaToolStripMenuItem})
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'PessoaFísicaToolStripMenuItem
        '
        Me.PessoaFísicaToolStripMenuItem.Name = "PessoaFísicaToolStripMenuItem"
        Me.PessoaFísicaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PessoaFísicaToolStripMenuItem.Text = "Pessoa Física"
        '
        'PessoaJurídicaToolStripMenuItem
        '
        Me.PessoaJurídicaToolStripMenuItem.Name = "PessoaJurídicaToolStripMenuItem"
        Me.PessoaJurídicaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PessoaJurídicaToolStripMenuItem.Text = "Pessoa Jurídica"
        '
        'VeículoToolStripMenuItem1
        '
        Me.VeículoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcaVeiculoToolStripMenuItem1, Me.QuestionarioVeiculoToolStripMenuItem})
        Me.VeículoToolStripMenuItem1.Name = "VeículoToolStripMenuItem1"
        Me.VeículoToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.VeículoToolStripMenuItem1.Text = "Veículos"
        '
        'MarcaVeiculoToolStripMenuItem1
        '
        Me.MarcaVeiculoToolStripMenuItem1.Name = "MarcaVeiculoToolStripMenuItem1"
        Me.MarcaVeiculoToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
        Me.MarcaVeiculoToolStripMenuItem1.Text = "Marca/Veiculo"
        '
        'QuestionarioVeiculoToolStripMenuItem
        '
        Me.QuestionarioVeiculoToolStripMenuItem.Name = "QuestionarioVeiculoToolStripMenuItem"
        Me.QuestionarioVeiculoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.QuestionarioVeiculoToolStripMenuItem.Text = "Questionario/Veiculo"
        '
        'OrçamentosToolStripMenuItem
        '
        Me.OrçamentosToolStripMenuItem.Name = "OrçamentosToolStripMenuItem"
        Me.OrçamentosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.OrçamentosToolStripMenuItem.Text = "Montagem de apólice"
        '
        'SeguradoraToolStripMenuItem
        '
        Me.SeguradoraToolStripMenuItem.Name = "SeguradoraToolStripMenuItem"
        Me.SeguradoraToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SeguradoraToolStripMenuItem.Text = "Seguradora"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(67, 26)
        Me.ClientesToolStripMenuItem.Text = "Consulta"
        '
        'SinistrosToolStripMenuItem
        '
        Me.SinistrosToolStripMenuItem.Name = "SinistrosToolStripMenuItem"
        Me.SinistrosToolStripMenuItem.Size = New System.Drawing.Size(67, 26)
        Me.SinistrosToolStripMenuItem.Text = "Sinistros"
        '
        'ToolStripMenuItemOpcoes
        '
        Me.ToolStripMenuItemOpcoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItemOpcoes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FazerBackupToolStripMenuItem, Me.RestaurarDadosExcluidosToolStripMenuItem})
        Me.ToolStripMenuItemOpcoes.Image = CType(resources.GetObject("ToolStripMenuItemOpcoes.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemOpcoes.Name = "ToolStripMenuItemOpcoes"
        Me.ToolStripMenuItemOpcoes.Size = New System.Drawing.Size(73, 26)
        Me.ToolStripMenuItemOpcoes.Text = "Opções"
        '
        'FazerBackupToolStripMenuItem
        '
        Me.FazerBackupToolStripMenuItem.Name = "FazerBackupToolStripMenuItem"
        Me.FazerBackupToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FazerBackupToolStripMenuItem.Text = "Fazer Backup"
        '
        'RestaurarDadosExcluidosToolStripMenuItem
        '
        Me.RestaurarDadosExcluidosToolStripMenuItem.Name = "RestaurarDadosExcluidosToolStripMenuItem"
        Me.RestaurarDadosExcluidosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RestaurarDadosExcluidosToolStripMenuItem.Text = "Restaurar Backup."
        '
        'ComissõesToolStripMenuItem
        '
        Me.ComissõesToolStripMenuItem.Name = "ComissõesToolStripMenuItem"
        Me.ComissõesToolStripMenuItem.Size = New System.Drawing.Size(75, 26)
        Me.ComissõesToolStripMenuItem.Text = "Comissões"
        '
        'LabelDescPag
        '
        Me.LabelDescPag.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescPag.Location = New System.Drawing.Point(21, 46)
        Me.LabelDescPag.Name = "LabelDescPag"
        Me.LabelDescPag.Size = New System.Drawing.Size(122, 24)
        Me.LabelDescPag.TabIndex = 3
        Me.LabelDescPag.Text = "Página Inicial"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnGoCadCli
        '
        Me.btnGoCadCli.BackColor = System.Drawing.Color.Transparent
        Me.btnGoCadCli.BackgroundImage = CType(resources.GetObject("btnGoCadCli.BackgroundImage"), System.Drawing.Image)
        Me.btnGoCadCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGoCadCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoCadCli.FlatAppearance.BorderSize = 0
        Me.btnGoCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoCadCli.Location = New System.Drawing.Point(140, 107)
        Me.btnGoCadCli.Name = "btnGoCadCli"
        Me.btnGoCadCli.Size = New System.Drawing.Size(151, 131)
        Me.btnGoCadCli.TabIndex = 4
        Me.btnGoCadCli.UseVisualStyleBackColor = False
        '
        'btnGoCadEmp
        '
        Me.btnGoCadEmp.BackColor = System.Drawing.Color.Transparent
        Me.btnGoCadEmp.BackgroundImage = CType(resources.GetObject("btnGoCadEmp.BackgroundImage"), System.Drawing.Image)
        Me.btnGoCadEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGoCadEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoCadEmp.FlatAppearance.BorderSize = 0
        Me.btnGoCadEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoCadEmp.Location = New System.Drawing.Point(297, 107)
        Me.btnGoCadEmp.Name = "btnGoCadEmp"
        Me.btnGoCadEmp.Size = New System.Drawing.Size(151, 131)
        Me.btnGoCadEmp.TabIndex = 5
        Me.btnGoCadEmp.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1027, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Aniversariantes próximos:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1027, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apólices prestes a encerrar:"
        '
        'btnGoCadVei
        '
        Me.btnGoCadVei.BackColor = System.Drawing.Color.Transparent
        Me.btnGoCadVei.BackgroundImage = CType(resources.GetObject("btnGoCadVei.BackgroundImage"), System.Drawing.Image)
        Me.btnGoCadVei.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGoCadVei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoCadVei.FlatAppearance.BorderSize = 0
        Me.btnGoCadVei.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoCadVei.Location = New System.Drawing.Point(454, 107)
        Me.btnGoCadVei.Name = "btnGoCadVei"
        Me.btnGoCadVei.Size = New System.Drawing.Size(150, 131)
        Me.btnGoCadVei.TabIndex = 10
        Me.btnGoCadVei.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome_Completo, Me.dt_Nascimento})
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(1031, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(248, 291)
        Me.DataGridView1.TabIndex = 11
        '
        'Nome_Completo
        '
        Me.Nome_Completo.DataPropertyName = "Nome_Completo"
        Me.Nome_Completo.HeaderText = "Nome"
        Me.Nome_Completo.Name = "Nome_Completo"
        Me.Nome_Completo.ReadOnly = True
        '
        'dt_Nascimento
        '
        Me.dt_Nascimento.DataPropertyName = "dt_Nascimento"
        Me.dt_Nascimento.HeaderText = "Dt. de Nascimento"
        Me.dt_Nascimento.Name = "dt_Nascimento"
        Me.dt_Nascimento.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dt_Fim, Me.id_Orcamento})
        Me.DataGridView2.GridColor = System.Drawing.Color.Black
        Me.DataGridView2.Location = New System.Drawing.Point(1031, 412)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(248, 291)
        Me.DataGridView2.TabIndex = 12
        '
        'dt_Fim
        '
        Me.dt_Fim.DataPropertyName = "dt_Fim"
        Me.dt_Fim.HeaderText = "Dt. Fim de Apólice"
        Me.dt_Fim.Name = "dt_Fim"
        Me.dt_Fim.ReadOnly = True
        '
        'id_Orcamento
        '
        Me.id_Orcamento.DataPropertyName = "id_Orcamento"
        Me.id_Orcamento.HeaderText = "ID do orçamento"
        Me.id_Orcamento.Name = "id_Orcamento"
        Me.id_Orcamento.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(1018, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 686)
        Me.Label3.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(721, 682)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Horário"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(21, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(985, 14)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "_________________________________________________________________________________" & _
    "________________________________________________________________________________" & _
    "__"
        '
        'PaginaPrincipal
        '
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.ClientSize = New System.Drawing.Size(1284, 715)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnGoCadVei)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGoCadEmp)
        Me.Controls.Add(Me.btnGoCadCli)
        Me.Controls.Add(Me.LabelDescPag)
        Me.Controls.Add(Me.MenuOpcoes)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuOpcoes
        Me.Name = "PaginaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Página Principal ="
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuOpcoes.ResumeLayout(False)
        Me.MenuOpcoes.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuOpcoes As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelDescPag As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItemOpcoes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguradoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrçamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FazerBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestaurarDadosExcluidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComissõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VeículoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PessoaFísicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PessoaJurídicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGoCadCli As System.Windows.Forms.Button
    Friend WithEvents btnGoCadEmp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGoCadVei As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents dt_Fim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_Orcamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome_Completo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_Nascimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MarcaVeiculoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuestionarioVeiculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

#End Region

End Class
