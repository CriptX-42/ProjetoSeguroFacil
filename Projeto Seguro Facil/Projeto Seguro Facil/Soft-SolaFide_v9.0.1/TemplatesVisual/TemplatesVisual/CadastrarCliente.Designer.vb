<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastrarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastrarCliente))
        Me.MenuOpcoes = New System.Windows.Forms.MenuStrip()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguradoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrçamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PessoaFísicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PessoaJurídicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxPesquisar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItemOpcoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.FazerBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarDadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarDadosExcluidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComissõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelRecData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelSeparador1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelRecHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelSeparador2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelRecCumprimentos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelDescPag = New DevExpress.XtraEditors.LabelControl()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.LabelCPF = New System.Windows.Forms.Label()
        Me.LabelDataNasc = New System.Windows.Forms.Label()
        Me.LabelProfissao = New System.Windows.Forms.Label()
        Me.LabelSexo = New System.Windows.Forms.Label()
        Me.LabelCidade = New System.Windows.Forms.Label()
        Me.LabelBairro = New System.Windows.Forms.Label()
        Me.LabelTempoHab = New System.Windows.Forms.Label()
        Me.LabelOrgaoExp = New System.Windows.Forms.Label()
        Me.LabelDataExp = New System.Windows.Forms.Label()
        Me.LabelRG = New System.Windows.Forms.Label()
        Me.LabelEndereco = New System.Windows.Forms.Label()
        Me.LabelCel = New System.Windows.Forms.Label()
        Me.LabelCNH = New System.Windows.Forms.Label()
        Me.LabelFonRes = New System.Windows.Forms.Label()
        Me.LabelUF = New System.Windows.Forms.Label()
        Me.Label1EstCivil = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelFoneCom = New System.Windows.Forms.Label()
        Me.Label2CEP = New System.Windows.Forms.Label()
        Me.LabelComplemento = New System.Windows.Forms.Label()
        Me.LabelNextel = New System.Windows.Forms.Label()
        Me.LabelNumeroCasa = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.TextBoxEndereco = New System.Windows.Forms.TextBox()
        Me.TextBoxNumeroCasa = New System.Windows.Forms.TextBox()
        Me.TextBoxComplemento = New System.Windows.Forms.TextBox()
        Me.MaskedTextBoxCep = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBoxUF = New System.Windows.Forms.ComboBox()
        Me.TextBoxCidade = New System.Windows.Forms.TextBox()
        Me.TextBoxBairro = New System.Windows.Forms.TextBox()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBoxDataNasc = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBoxEstCivil = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBoxRG = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxCPF = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxOrgExp = New System.Windows.Forms.TextBox()
        Me.MaskedTextBoxDataExp = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxProfissao = New System.Windows.Forms.TextBox()
        Me.TextBoxCNH = New System.Windows.Forms.TextBox()
        Me.TextBoxTempoHab = New System.Windows.Forms.TextBox()
        Me.ComboBox4TempoHab = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBoxCelular = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxComercial = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxResidencial = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxNextel = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuOpcoes.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuOpcoes
        '
        Me.MenuOpcoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.MenuOpcoes.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.SinistrosToolStripMenuItem, Me.ToolStripTextBoxPesquisar, Me.ToolStripMenuItemOpcoes, Me.ComissõesToolStripMenuItem})
        Me.MenuOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.MenuOpcoes.Name = "MenuOpcoes"
        Me.MenuOpcoes.Size = New System.Drawing.Size(1159, 25)
        Me.MenuOpcoes.TabIndex = 1
        Me.MenuOpcoes.Text = "MenuStrip1"
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.SeguradoraToolStripMenuItem, Me.OrçamentosToolStripMenuItem})
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(71, 21)
        Me.CadastrarToolStripMenuItem.Text = "Cadastrar"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'SeguradoraToolStripMenuItem
        '
        Me.SeguradoraToolStripMenuItem.Name = "SeguradoraToolStripMenuItem"
        Me.SeguradoraToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SeguradoraToolStripMenuItem.Text = "Seguradora"
        '
        'OrçamentosToolStripMenuItem
        '
        Me.OrçamentosToolStripMenuItem.Name = "OrçamentosToolStripMenuItem"
        Me.OrçamentosToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.OrçamentosToolStripMenuItem.Text = "Orçamentos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PessoaFísicaToolStripMenuItem, Me.PessoaJurídicaToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(64, 21)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
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
        'SinistrosToolStripMenuItem
        '
        Me.SinistrosToolStripMenuItem.Name = "SinistrosToolStripMenuItem"
        Me.SinistrosToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.SinistrosToolStripMenuItem.Text = "Sinistros"
        '
        'ToolStripTextBoxPesquisar
        '
        Me.ToolStripTextBoxPesquisar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBoxPesquisar.BackColor = System.Drawing.Color.White
        Me.ToolStripTextBoxPesquisar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBoxPesquisar.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripTextBoxPesquisar.Name = "ToolStripTextBoxPesquisar"
        Me.ToolStripTextBoxPesquisar.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBoxPesquisar.Text = "Pesquisar"
        '
        'ToolStripMenuItemOpcoes
        '
        Me.ToolStripMenuItemOpcoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItemOpcoes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FazerBackupToolStripMenuItem, Me.ImportarDadosToolStripMenuItem, Me.RestaurarDadosExcluidosToolStripMenuItem})
        Me.ToolStripMenuItemOpcoes.Image = CType(resources.GetObject("ToolStripMenuItemOpcoes.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemOpcoes.Name = "ToolStripMenuItemOpcoes"
        Me.ToolStripMenuItemOpcoes.Size = New System.Drawing.Size(73, 21)
        Me.ToolStripMenuItemOpcoes.Text = "Opções"
        '
        'FazerBackupToolStripMenuItem
        '
        Me.FazerBackupToolStripMenuItem.Name = "FazerBackupToolStripMenuItem"
        Me.FazerBackupToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.FazerBackupToolStripMenuItem.Text = "Fazer Backup"
        '
        'ImportarDadosToolStripMenuItem
        '
        Me.ImportarDadosToolStripMenuItem.Name = "ImportarDadosToolStripMenuItem"
        Me.ImportarDadosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ImportarDadosToolStripMenuItem.Text = "Importar Dados"
        '
        'RestaurarDadosExcluidosToolStripMenuItem
        '
        Me.RestaurarDadosExcluidosToolStripMenuItem.Name = "RestaurarDadosExcluidosToolStripMenuItem"
        Me.RestaurarDadosExcluidosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RestaurarDadosExcluidosToolStripMenuItem.Text = "Restaurar Dados Exc."
        '
        'ComissõesToolStripMenuItem
        '
        Me.ComissõesToolStripMenuItem.Name = "ComissõesToolStripMenuItem"
        Me.ComissõesToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.ComissõesToolStripMenuItem.Text = "Comissões"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelRecData, Me.ToolStripStatusLabelSeparador1, Me.ToolStripStatusLabelRecHora, Me.ToolStripStatusLabelSeparador2, Me.ToolStripStatusLabelRecCumprimentos})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 719)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1159, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelRecData
        '
        Me.ToolStripStatusLabelRecData.Name = "ToolStripStatusLabelRecData"
        Me.ToolStripStatusLabelRecData.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabelRecData.Text = "00/00/0000"
        '
        'ToolStripStatusLabelSeparador1
        '
        Me.ToolStripStatusLabelSeparador1.Name = "ToolStripStatusLabelSeparador1"
        Me.ToolStripStatusLabelSeparador1.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabelSeparador1.Text = " |"
        '
        'ToolStripStatusLabelRecHora
        '
        Me.ToolStripStatusLabelRecHora.Name = "ToolStripStatusLabelRecHora"
        Me.ToolStripStatusLabelRecHora.Size = New System.Drawing.Size(49, 17)
        Me.ToolStripStatusLabelRecHora.Text = "00:00:00"
        '
        'ToolStripStatusLabelSeparador2
        '
        Me.ToolStripStatusLabelSeparador2.Name = "ToolStripStatusLabelSeparador2"
        Me.ToolStripStatusLabelSeparador2.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabelSeparador2.Text = " |"
        '
        'ToolStripStatusLabelRecCumprimentos
        '
        Me.ToolStripStatusLabelRecCumprimentos.Name = "ToolStripStatusLabelRecCumprimentos"
        Me.ToolStripStatusLabelRecCumprimentos.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabelRecCumprimentos.Text = "Cumprimentos"
        '
        'LabelDescPag
        '
        Me.LabelDescPag.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescPag.Location = New System.Drawing.Point(12, 40)
        Me.LabelDescPag.Name = "LabelDescPag"
        Me.LabelDescPag.Size = New System.Drawing.Size(184, 24)
        Me.LabelDescPag.TabIndex = 6
        Me.LabelDescPag.Text = "Cadastro de Clientes"
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.BackColor = System.Drawing.Color.Transparent
        Me.LabelNome.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNome.Location = New System.Drawing.Point(16, 99)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(42, 15)
        Me.LabelNome.TabIndex = 7
        Me.LabelNome.Text = "Nome:"
        '
        'LabelCPF
        '
        Me.LabelCPF.AutoSize = True
        Me.LabelCPF.BackColor = System.Drawing.Color.Transparent
        Me.LabelCPF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCPF.Location = New System.Drawing.Point(162, 250)
        Me.LabelCPF.Name = "LabelCPF"
        Me.LabelCPF.Size = New System.Drawing.Size(34, 15)
        Me.LabelCPF.TabIndex = 8
        Me.LabelCPF.Text = "CPF:"
        '
        'LabelDataNasc
        '
        Me.LabelDataNasc.AutoSize = True
        Me.LabelDataNasc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDataNasc.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDataNasc.Location = New System.Drawing.Point(161, 208)
        Me.LabelDataNasc.Name = "LabelDataNasc"
        Me.LabelDataNasc.Size = New System.Drawing.Size(78, 15)
        Me.LabelDataNasc.TabIndex = 9
        Me.LabelDataNasc.Text = "Data de Nasc."
        '
        'LabelProfissao
        '
        Me.LabelProfissao.AutoSize = True
        Me.LabelProfissao.BackColor = System.Drawing.Color.Transparent
        Me.LabelProfissao.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProfissao.Location = New System.Drawing.Point(20, 293)
        Me.LabelProfissao.Name = "LabelProfissao"
        Me.LabelProfissao.Size = New System.Drawing.Size(59, 15)
        Me.LabelProfissao.TabIndex = 10
        Me.LabelProfissao.Text = "Profissão:"
        '
        'LabelSexo
        '
        Me.LabelSexo.AutoSize = True
        Me.LabelSexo.BackColor = System.Drawing.Color.Transparent
        Me.LabelSexo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSexo.Location = New System.Drawing.Point(18, 208)
        Me.LabelSexo.Name = "LabelSexo"
        Me.LabelSexo.Size = New System.Drawing.Size(37, 15)
        Me.LabelSexo.TabIndex = 11
        Me.LabelSexo.Text = "Sexo:"
        '
        'LabelCidade
        '
        Me.LabelCidade.AutoSize = True
        Me.LabelCidade.BackColor = System.Drawing.Color.Transparent
        Me.LabelCidade.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCidade.Location = New System.Drawing.Point(253, 168)
        Me.LabelCidade.Name = "LabelCidade"
        Me.LabelCidade.Size = New System.Drawing.Size(48, 15)
        Me.LabelCidade.TabIndex = 12
        Me.LabelCidade.Text = "Cidade:"
        '
        'LabelBairro
        '
        Me.LabelBairro.AutoSize = True
        Me.LabelBairro.BackColor = System.Drawing.Color.Transparent
        Me.LabelBairro.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBairro.Location = New System.Drawing.Point(439, 168)
        Me.LabelBairro.Name = "LabelBairro"
        Me.LabelBairro.Size = New System.Drawing.Size(45, 15)
        Me.LabelBairro.TabIndex = 13
        Me.LabelBairro.Text = "Bairro:"
        '
        'LabelTempoHab
        '
        Me.LabelTempoHab.AutoSize = True
        Me.LabelTempoHab.BackColor = System.Drawing.Color.Transparent
        Me.LabelTempoHab.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTempoHab.Location = New System.Drawing.Point(225, 335)
        Me.LabelTempoHab.Name = "LabelTempoHab"
        Me.LabelTempoHab.Size = New System.Drawing.Size(124, 15)
        Me.LabelTempoHab.TabIndex = 14
        Me.LabelTempoHab.Text = "Tempo de Habilitação:"
        '
        'LabelOrgaoExp
        '
        Me.LabelOrgaoExp.AutoSize = True
        Me.LabelOrgaoExp.BackColor = System.Drawing.Color.Transparent
        Me.LabelOrgaoExp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOrgaoExp.Location = New System.Drawing.Point(328, 250)
        Me.LabelOrgaoExp.Name = "LabelOrgaoExp"
        Me.LabelOrgaoExp.Size = New System.Drawing.Size(99, 15)
        Me.LabelOrgaoExp.TabIndex = 15
        Me.LabelOrgaoExp.Text = "Órgão Expedidor:"
        '
        'LabelDataExp
        '
        Me.LabelDataExp.AutoSize = True
        Me.LabelDataExp.BackColor = System.Drawing.Color.Transparent
        Me.LabelDataExp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDataExp.Location = New System.Drawing.Point(494, 250)
        Me.LabelDataExp.Name = "LabelDataExp"
        Me.LabelDataExp.Size = New System.Drawing.Size(91, 15)
        Me.LabelDataExp.TabIndex = 16
        Me.LabelDataExp.Text = "Data Expedição:"
        '
        'LabelRG
        '
        Me.LabelRG.AutoSize = True
        Me.LabelRG.BackColor = System.Drawing.Color.Transparent
        Me.LabelRG.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRG.Location = New System.Drawing.Point(19, 250)
        Me.LabelRG.Name = "LabelRG"
        Me.LabelRG.Size = New System.Drawing.Size(28, 15)
        Me.LabelRG.TabIndex = 17
        Me.LabelRG.Text = "RG:"
        '
        'LabelEndereco
        '
        Me.LabelEndereco.AutoSize = True
        Me.LabelEndereco.BackColor = System.Drawing.Color.Transparent
        Me.LabelEndereco.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEndereco.Location = New System.Drawing.Point(325, 99)
        Me.LabelEndereco.Name = "LabelEndereco"
        Me.LabelEndereco.Size = New System.Drawing.Size(59, 15)
        Me.LabelEndereco.TabIndex = 18
        Me.LabelEndereco.Text = "Endereço:"
        '
        'LabelCel
        '
        Me.LabelCel.AutoSize = True
        Me.LabelCel.BackColor = System.Drawing.Color.Transparent
        Me.LabelCel.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCel.Location = New System.Drawing.Point(20, 384)
        Me.LabelCel.Name = "LabelCel"
        Me.LabelCel.Size = New System.Drawing.Size(52, 15)
        Me.LabelCel.TabIndex = 19
        Me.LabelCel.Text = "Celular:"
        '
        'LabelCNH
        '
        Me.LabelCNH.AutoSize = True
        Me.LabelCNH.BackColor = System.Drawing.Color.Transparent
        Me.LabelCNH.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCNH.Location = New System.Drawing.Point(20, 335)
        Me.LabelCNH.Name = "LabelCNH"
        Me.LabelCNH.Size = New System.Drawing.Size(38, 15)
        Me.LabelCNH.TabIndex = 20
        Me.LabelCNH.Text = "CNH:"
        '
        'LabelFonRes
        '
        Me.LabelFonRes.AutoSize = True
        Me.LabelFonRes.BackColor = System.Drawing.Color.Transparent
        Me.LabelFonRes.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFonRes.Location = New System.Drawing.Point(485, 384)
        Me.LabelFonRes.Name = "LabelFonRes"
        Me.LabelFonRes.Size = New System.Drawing.Size(101, 15)
        Me.LabelFonRes.TabIndex = 21
        Me.LabelFonRes.Text = "Fone Residencial:"
        '
        'LabelUF
        '
        Me.LabelUF.AutoSize = True
        Me.LabelUF.BackColor = System.Drawing.Color.Transparent
        Me.LabelUF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUF.Location = New System.Drawing.Point(163, 168)
        Me.LabelUF.Name = "LabelUF"
        Me.LabelUF.Size = New System.Drawing.Size(26, 15)
        Me.LabelUF.TabIndex = 22
        Me.LabelUF.Text = "UF:"
        '
        'Label1EstCivil
        '
        Me.Label1EstCivil.AutoSize = True
        Me.Label1EstCivil.BackColor = System.Drawing.Color.Transparent
        Me.Label1EstCivil.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1EstCivil.Location = New System.Drawing.Point(357, 208)
        Me.Label1EstCivil.Name = "Label1EstCivil"
        Me.Label1EstCivil.Size = New System.Drawing.Size(74, 15)
        Me.Label1EstCivil.TabIndex = 23
        Me.Label1EstCivil.Text = "Estado Civíl:"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.BackColor = System.Drawing.Color.Transparent
        Me.LabelEmail.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(225, 425)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(46, 15)
        Me.LabelEmail.TabIndex = 24
        Me.LabelEmail.Text = "E-mail:"
        '
        'LabelFoneCom
        '
        Me.LabelFoneCom.AutoSize = True
        Me.LabelFoneCom.BackColor = System.Drawing.Color.Transparent
        Me.LabelFoneCom.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFoneCom.Location = New System.Drawing.Point(225, 384)
        Me.LabelFoneCom.Name = "LabelFoneCom"
        Me.LabelFoneCom.Size = New System.Drawing.Size(95, 15)
        Me.LabelFoneCom.TabIndex = 25
        Me.LabelFoneCom.Text = "Fone Comercial:"
        '
        'Label2CEP
        '
        Me.Label2CEP.AutoSize = True
        Me.Label2CEP.BackColor = System.Drawing.Color.Transparent
        Me.Label2CEP.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2CEP.Location = New System.Drawing.Point(17, 168)
        Me.Label2CEP.Name = "Label2CEP"
        Me.Label2CEP.Size = New System.Drawing.Size(34, 15)
        Me.Label2CEP.TabIndex = 26
        Me.Label2CEP.Text = "CEP:"
        '
        'LabelComplemento
        '
        Me.LabelComplemento.AutoSize = True
        Me.LabelComplemento.BackColor = System.Drawing.Color.Transparent
        Me.LabelComplemento.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComplemento.Location = New System.Drawing.Point(93, 131)
        Me.LabelComplemento.Name = "LabelComplemento"
        Me.LabelComplemento.Size = New System.Drawing.Size(85, 15)
        Me.LabelComplemento.TabIndex = 27
        Me.LabelComplemento.Text = "Complemento:"
        '
        'LabelNextel
        '
        Me.LabelNextel.AutoSize = True
        Me.LabelNextel.BackColor = System.Drawing.Color.Transparent
        Me.LabelNextel.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNextel.Location = New System.Drawing.Point(20, 425)
        Me.LabelNextel.Name = "LabelNextel"
        Me.LabelNextel.Size = New System.Drawing.Size(46, 15)
        Me.LabelNextel.TabIndex = 28
        Me.LabelNextel.Text = "Nextel:"
        '
        'LabelNumeroCasa
        '
        Me.LabelNumeroCasa.AutoSize = True
        Me.LabelNumeroCasa.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroCasa.Location = New System.Drawing.Point(17, 131)
        Me.LabelNumeroCasa.Name = "LabelNumeroCasa"
        Me.LabelNumeroCasa.Size = New System.Drawing.Size(20, 15)
        Me.LabelNumeroCasa.TabIndex = 29
        Me.LabelNumeroCasa.Text = "Nº"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(64, 97)
        Me.TextBoxNome.MaxLength = 50
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxNome.TabIndex = 30
        '
        'TextBoxEndereco
        '
        Me.TextBoxEndereco.Location = New System.Drawing.Point(390, 97)
        Me.TextBoxEndereco.MaxLength = 50
        Me.TextBoxEndereco.Name = "TextBoxEndereco"
        Me.TextBoxEndereco.Size = New System.Drawing.Size(290, 20)
        Me.TextBoxEndereco.TabIndex = 31
        '
        'TextBoxNumeroCasa
        '
        Me.TextBoxNumeroCasa.Location = New System.Drawing.Point(43, 129)
        Me.TextBoxNumeroCasa.MaxLength = 10
        Me.TextBoxNumeroCasa.Name = "TextBoxNumeroCasa"
        Me.TextBoxNumeroCasa.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxNumeroCasa.TabIndex = 32
        '
        'TextBoxComplemento
        '
        Me.TextBoxComplemento.Location = New System.Drawing.Point(184, 129)
        Me.TextBoxComplemento.MaxLength = 50
        Me.TextBoxComplemento.Name = "TextBoxComplemento"
        Me.TextBoxComplemento.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxComplemento.TabIndex = 33
        '
        'MaskedTextBoxCep
        '
        Me.MaskedTextBoxCep.Location = New System.Drawing.Point(57, 166)
        Me.MaskedTextBoxCep.Mask = "00000-000"
        Me.MaskedTextBoxCep.Name = "MaskedTextBoxCep"
        Me.MaskedTextBoxCep.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxCep.TabIndex = 34
        '
        'ComboBoxUF
        '
        Me.ComboBoxUF.FormattingEnabled = True
        Me.ComboBoxUF.Items.AddRange(New Object() {"SP", "RJ"})
        Me.ComboBoxUF.Location = New System.Drawing.Point(195, 164)
        Me.ComboBoxUF.Name = "ComboBoxUF"
        Me.ComboBoxUF.Size = New System.Drawing.Size(52, 22)
        Me.ComboBoxUF.TabIndex = 35
        '
        'TextBoxCidade
        '
        Me.TextBoxCidade.Location = New System.Drawing.Point(308, 165)
        Me.TextBoxCidade.MaxLength = 50
        Me.TextBoxCidade.Name = "TextBoxCidade"
        Me.TextBoxCidade.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxCidade.TabIndex = 36
        '
        'TextBoxBairro
        '
        Me.TextBoxBairro.Location = New System.Drawing.Point(488, 165)
        Me.TextBoxBairro.MaxLength = 50
        Me.TextBoxBairro.Name = "TextBoxBairro"
        Me.TextBoxBairro.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxBairro.TabIndex = 37
        '
        'ComboBoxSexo
        '
        Me.ComboBoxSexo.FormattingEnabled = True
        Me.ComboBoxSexo.Items.AddRange(New Object() {"Masculino", "Feminino", "Astronalta"})
        Me.ComboBoxSexo.Location = New System.Drawing.Point(61, 206)
        Me.ComboBoxSexo.Name = "ComboBoxSexo"
        Me.ComboBoxSexo.Size = New System.Drawing.Size(94, 22)
        Me.ComboBoxSexo.TabIndex = 38
        '
        'MaskedTextBoxDataNasc
        '
        Me.MaskedTextBoxDataNasc.Location = New System.Drawing.Point(245, 208)
        Me.MaskedTextBoxDataNasc.Mask = "00/00/0000"
        Me.MaskedTextBoxDataNasc.Name = "MaskedTextBoxDataNasc"
        Me.MaskedTextBoxDataNasc.Size = New System.Drawing.Size(87, 20)
        Me.MaskedTextBoxDataNasc.TabIndex = 39
        '
        'ComboBoxEstCivil
        '
        Me.ComboBoxEstCivil.FormattingEnabled = True
        Me.ComboBoxEstCivil.Items.AddRange(New Object() {"Solteiro", "Casado", "Divorciado"})
        Me.ComboBoxEstCivil.Location = New System.Drawing.Point(440, 207)
        Me.ComboBoxEstCivil.Name = "ComboBoxEstCivil"
        Me.ComboBoxEstCivil.Size = New System.Drawing.Size(110, 22)
        Me.ComboBoxEstCivil.TabIndex = 40
        '
        'MaskedTextBoxRG
        '
        Me.MaskedTextBoxRG.Location = New System.Drawing.Point(53, 248)
        Me.MaskedTextBoxRG.Mask = "00.000.000-0"
        Me.MaskedTextBoxRG.Name = "MaskedTextBoxRG"
        Me.MaskedTextBoxRG.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxRG.TabIndex = 41
        '
        'MaskedTextBoxCPF
        '
        Me.MaskedTextBoxCPF.Location = New System.Drawing.Point(202, 248)
        Me.MaskedTextBoxCPF.Mask = "000,000,000-00"
        Me.MaskedTextBoxCPF.Name = "MaskedTextBoxCPF"
        Me.MaskedTextBoxCPF.Size = New System.Drawing.Size(120, 20)
        Me.MaskedTextBoxCPF.TabIndex = 42
        '
        'TextBoxOrgExp
        '
        Me.TextBoxOrgExp.Location = New System.Drawing.Point(426, 248)
        Me.TextBoxOrgExp.MaxLength = 50
        Me.TextBoxOrgExp.Name = "TextBoxOrgExp"
        Me.TextBoxOrgExp.Size = New System.Drawing.Size(62, 20)
        Me.TextBoxOrgExp.TabIndex = 43
        '
        'MaskedTextBoxDataExp
        '
        Me.MaskedTextBoxDataExp.Location = New System.Drawing.Point(591, 248)
        Me.MaskedTextBoxDataExp.Mask = "00/00/0000"
        Me.MaskedTextBoxDataExp.Name = "MaskedTextBoxDataExp"
        Me.MaskedTextBoxDataExp.Size = New System.Drawing.Size(89, 20)
        Me.MaskedTextBoxDataExp.TabIndex = 44
        '
        'TextBoxProfissao
        '
        Me.TextBoxProfissao.Location = New System.Drawing.Point(85, 291)
        Me.TextBoxProfissao.MaxLength = 50
        Me.TextBoxProfissao.Name = "TextBoxProfissao"
        Me.TextBoxProfissao.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxProfissao.TabIndex = 45
        '
        'TextBoxCNH
        '
        Me.TextBoxCNH.Location = New System.Drawing.Point(57, 333)
        Me.TextBoxCNH.MaxLength = 50
        Me.TextBoxCNH.Name = "TextBoxCNH"
        Me.TextBoxCNH.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxCNH.TabIndex = 46
        '
        'TextBoxTempoHab
        '
        Me.TextBoxTempoHab.Location = New System.Drawing.Point(355, 333)
        Me.TextBoxTempoHab.MaxLength = 50
        Me.TextBoxTempoHab.Name = "TextBoxTempoHab"
        Me.TextBoxTempoHab.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxTempoHab.TabIndex = 47
        '
        'ComboBox4TempoHab
        '
        Me.ComboBox4TempoHab.FormattingEnabled = True
        Me.ComboBox4TempoHab.Items.AddRange(New Object() {"Anos", "Meses"})
        Me.ComboBox4TempoHab.Location = New System.Drawing.Point(394, 333)
        Me.ComboBox4TempoHab.Name = "ComboBox4TempoHab"
        Me.ComboBox4TempoHab.Size = New System.Drawing.Size(110, 22)
        Me.ComboBox4TempoHab.TabIndex = 48
        '
        'MaskedTextBoxCelular
        '
        Me.MaskedTextBoxCelular.Location = New System.Drawing.Point(78, 382)
        Me.MaskedTextBoxCelular.Mask = "(00)00000-0000"
        Me.MaskedTextBoxCelular.Name = "MaskedTextBoxCelular"
        Me.MaskedTextBoxCelular.Size = New System.Drawing.Size(111, 20)
        Me.MaskedTextBoxCelular.TabIndex = 49
        '
        'MaskedTextBoxComercial
        '
        Me.MaskedTextBoxComercial.Location = New System.Drawing.Point(326, 382)
        Me.MaskedTextBoxComercial.Mask = "(00)0000-0000"
        Me.MaskedTextBoxComercial.Name = "MaskedTextBoxComercial"
        Me.MaskedTextBoxComercial.Size = New System.Drawing.Size(107, 20)
        Me.MaskedTextBoxComercial.TabIndex = 50
        '
        'MaskedTextBoxResidencial
        '
        Me.MaskedTextBoxResidencial.Location = New System.Drawing.Point(592, 382)
        Me.MaskedTextBoxResidencial.Mask = "(00)0000-0000"
        Me.MaskedTextBoxResidencial.Name = "MaskedTextBoxResidencial"
        Me.MaskedTextBoxResidencial.Size = New System.Drawing.Size(88, 20)
        Me.MaskedTextBoxResidencial.TabIndex = 51
        '
        'TextBoxNextel
        '
        Me.TextBoxNextel.Location = New System.Drawing.Point(72, 423)
        Me.TextBoxNextel.MaxLength = 50
        Me.TextBoxNextel.Name = "TextBoxNextel"
        Me.TextBoxNextel.Size = New System.Drawing.Size(147, 20)
        Me.TextBoxNextel.TabIndex = 52
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(277, 423)
        Me.TextBoxEmail.MaxLength = 50
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxEmail.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(605, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Cadastrar!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'CadastrarCliente
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = CType(resources.GetObject("$this.BackgroundImageStore"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1159, 741)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxNextel)
        Me.Controls.Add(Me.MaskedTextBoxResidencial)
        Me.Controls.Add(Me.MaskedTextBoxComercial)
        Me.Controls.Add(Me.MaskedTextBoxCelular)
        Me.Controls.Add(Me.ComboBox4TempoHab)
        Me.Controls.Add(Me.TextBoxTempoHab)
        Me.Controls.Add(Me.TextBoxCNH)
        Me.Controls.Add(Me.TextBoxProfissao)
        Me.Controls.Add(Me.MaskedTextBoxDataExp)
        Me.Controls.Add(Me.TextBoxOrgExp)
        Me.Controls.Add(Me.MaskedTextBoxCPF)
        Me.Controls.Add(Me.MaskedTextBoxRG)
        Me.Controls.Add(Me.ComboBoxEstCivil)
        Me.Controls.Add(Me.MaskedTextBoxDataNasc)
        Me.Controls.Add(Me.ComboBoxSexo)
        Me.Controls.Add(Me.TextBoxBairro)
        Me.Controls.Add(Me.TextBoxCidade)
        Me.Controls.Add(Me.ComboBoxUF)
        Me.Controls.Add(Me.MaskedTextBoxCep)
        Me.Controls.Add(Me.TextBoxComplemento)
        Me.Controls.Add(Me.TextBoxNumeroCasa)
        Me.Controls.Add(Me.TextBoxEndereco)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.LabelNumeroCasa)
        Me.Controls.Add(Me.LabelNextel)
        Me.Controls.Add(Me.LabelComplemento)
        Me.Controls.Add(Me.Label2CEP)
        Me.Controls.Add(Me.LabelFoneCom)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.Label1EstCivil)
        Me.Controls.Add(Me.LabelUF)
        Me.Controls.Add(Me.LabelFonRes)
        Me.Controls.Add(Me.LabelCNH)
        Me.Controls.Add(Me.LabelCel)
        Me.Controls.Add(Me.LabelEndereco)
        Me.Controls.Add(Me.LabelRG)
        Me.Controls.Add(Me.LabelDataExp)
        Me.Controls.Add(Me.LabelOrgaoExp)
        Me.Controls.Add(Me.LabelTempoHab)
        Me.Controls.Add(Me.LabelBairro)
        Me.Controls.Add(Me.LabelCidade)
        Me.Controls.Add(Me.LabelSexo)
        Me.Controls.Add(Me.LabelProfissao)
        Me.Controls.Add(Me.LabelDataNasc)
        Me.Controls.Add(Me.LabelCPF)
        Me.Controls.Add(Me.LabelNome)
        Me.Controls.Add(Me.LabelDescPag)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuOpcoes)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CadastrarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Cadastrar Cliente ="
        Me.MenuOpcoes.ResumeLayout(False)
        Me.MenuOpcoes.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuOpcoes As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguradoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrçamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PessoaFísicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PessoaJurídicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxPesquisar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItemOpcoes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FazerBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarDadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestaurarDadosExcluidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComissõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelRecData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelSeparador1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelRecHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelSeparador2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelRecCumprimentos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelDescPag As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelNome As System.Windows.Forms.Label
    Friend WithEvents LabelCPF As System.Windows.Forms.Label
    Friend WithEvents LabelDataNasc As System.Windows.Forms.Label
    Friend WithEvents LabelProfissao As System.Windows.Forms.Label
    Friend WithEvents LabelSexo As System.Windows.Forms.Label
    Friend WithEvents LabelCidade As System.Windows.Forms.Label
    Friend WithEvents LabelBairro As System.Windows.Forms.Label
    Friend WithEvents LabelTempoHab As System.Windows.Forms.Label
    Friend WithEvents LabelOrgaoExp As System.Windows.Forms.Label
    Friend WithEvents LabelDataExp As System.Windows.Forms.Label
    Friend WithEvents LabelRG As System.Windows.Forms.Label
    Friend WithEvents LabelEndereco As System.Windows.Forms.Label
    Friend WithEvents LabelCel As System.Windows.Forms.Label
    Friend WithEvents LabelCNH As System.Windows.Forms.Label
    Friend WithEvents LabelFonRes As System.Windows.Forms.Label
    Friend WithEvents LabelUF As System.Windows.Forms.Label
    Friend WithEvents Label1EstCivil As System.Windows.Forms.Label
    Friend WithEvents LabelEmail As System.Windows.Forms.Label
    Friend WithEvents LabelFoneCom As System.Windows.Forms.Label
    Friend WithEvents Label2CEP As System.Windows.Forms.Label
    Friend WithEvents LabelComplemento As System.Windows.Forms.Label
    Friend WithEvents LabelNextel As System.Windows.Forms.Label
    Friend WithEvents LabelNumeroCasa As System.Windows.Forms.Label
    Friend WithEvents TextBoxNome As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndereco As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNumeroCasa As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxComplemento As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBoxCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBoxUF As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxCidade As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBairro As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBoxDataNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBoxEstCivil As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBoxRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBoxOrgExp As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBoxDataExp As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBoxProfissao As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCNH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTempoHab As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4TempoHab As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBoxCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxComercial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxResidencial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBoxNextel As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
