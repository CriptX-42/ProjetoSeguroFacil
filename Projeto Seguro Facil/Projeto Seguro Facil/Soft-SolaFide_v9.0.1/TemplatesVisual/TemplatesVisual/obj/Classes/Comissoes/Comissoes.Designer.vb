<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comissoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Comissoes))
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.mskApolice = New System.Windows.Forms.MaskedTextBox()
        Me.btnExcluirComissao = New System.Windows.Forms.Button()
        Me.mskDt_Pagamento = New System.Windows.Forms.MaskedTextBox()
        Me.mskDtCalc = New System.Windows.Forms.MaskedTextBox()
        Me.lbApolice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numParcela = New System.Windows.Forms.NumericUpDown()
        Me.lbDt_Pagamento = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbCodOrc = New System.Windows.Forms.Label()
        Me.btnPesqOrc = New System.Windows.Forms.Button()
        Me.btnAddComissao = New System.Windows.Forms.Button()
        Me.dgvComissoes = New System.Windows.Forms.DataGridView()
        Me.PG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apolice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seguradora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Parcelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Premio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comissao_Bruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comissao_Liquida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor_Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor_Pagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_Pagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFecharComissoes = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.txtVlrPago = New System.Windows.Forms.MaskedTextBox()
        Me.txtVlrPagar = New System.Windows.Forms.MaskedTextBox()
        CType(Me.numParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvComissoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpar
        '
        Me.btnLimpar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(752, 54)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 40)
        Me.btnLimpar.TabIndex = 16
        Me.btnLimpar.Text = "LIMPAR"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'mskApolice
        '
        Me.mskApolice.Location = New System.Drawing.Point(376, 21)
        Me.mskApolice.Mask = "0000000"
        Me.mskApolice.Name = "mskApolice"
        Me.mskApolice.Size = New System.Drawing.Size(82, 20)
        Me.mskApolice.TabIndex = 5
        '
        'btnExcluirComissao
        '
        Me.btnExcluirComissao.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluirComissao.Location = New System.Drawing.Point(662, 54)
        Me.btnExcluirComissao.Name = "btnExcluirComissao"
        Me.btnExcluirComissao.Size = New System.Drawing.Size(83, 40)
        Me.btnExcluirComissao.TabIndex = 15
        Me.btnExcluirComissao.Text = "EXCLUIR COMISSÃO"
        Me.btnExcluirComissao.UseVisualStyleBackColor = True
        '
        'mskDt_Pagamento
        '
        Me.mskDt_Pagamento.Enabled = False
        Me.mskDt_Pagamento.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDt_Pagamento.Location = New System.Drawing.Point(755, 20)
        Me.mskDt_Pagamento.Mask = "00/00/0000"
        Me.mskDt_Pagamento.Name = "mskDt_Pagamento"
        Me.mskDt_Pagamento.Size = New System.Drawing.Size(71, 22)
        Me.mskDt_Pagamento.TabIndex = 9
        Me.mskDt_Pagamento.ValidatingType = GetType(Date)
        '
        'mskDtCalc
        '
        Me.mskDtCalc.Enabled = False
        Me.mskDtCalc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDtCalc.Location = New System.Drawing.Point(139, 21)
        Me.mskDtCalc.Mask = "00/00/0000"
        Me.mskDtCalc.Name = "mskDtCalc"
        Me.mskDtCalc.Size = New System.Drawing.Size(86, 22)
        Me.mskDtCalc.TabIndex = 2
        Me.mskDtCalc.ValidatingType = GetType(Date)
        '
        'lbApolice
        '
        Me.lbApolice.AutoSize = True
        Me.lbApolice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApolice.Location = New System.Drawing.Point(305, 23)
        Me.lbApolice.Name = "lbApolice"
        Me.lbApolice.Size = New System.Drawing.Size(62, 15)
        Me.lbApolice.TabIndex = 4
        Me.lbApolice.Text = "APÓLICE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(474, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PARCELA:"
        '
        'numParcela
        '
        Me.numParcela.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numParcela.Location = New System.Drawing.Point(546, 19)
        Me.numParcela.Name = "numParcela"
        Me.numParcela.Size = New System.Drawing.Size(48, 22)
        Me.numParcela.TabIndex = 7
        '
        'lbDt_Pagamento
        '
        Me.lbDt_Pagamento.AutoSize = True
        Me.lbDt_Pagamento.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDt_Pagamento.Location = New System.Drawing.Point(600, 23)
        Me.lbDt_Pagamento.Name = "lbDt_Pagamento"
        Me.lbDt_Pagamento.Size = New System.Drawing.Size(145, 15)
        Me.lbDt_Pagamento.TabIndex = 8
        Me.lbDt_Pagamento.Text = "DATA DE PAGAMENTO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "VALOR PAGO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "VALOR À PAGAR:"
        '
        'lbCodOrc
        '
        Me.lbCodOrc.AutoSize = True
        Me.lbCodOrc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodOrc.Location = New System.Drawing.Point(7, 23)
        Me.lbCodOrc.Name = "lbCodOrc"
        Me.lbCodOrc.Size = New System.Drawing.Size(126, 15)
        Me.lbCodOrc.TabIndex = 1
        Me.lbCodOrc.Text = "DATA DO CALCULO:"
        '
        'btnPesqOrc
        '
        Me.btnPesqOrc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesqOrc.Location = New System.Drawing.Point(255, 20)
        Me.btnPesqOrc.Name = "btnPesqOrc"
        Me.btnPesqOrc.Size = New System.Drawing.Size(33, 23)
        Me.btnPesqOrc.TabIndex = 3
        Me.btnPesqOrc.Text = "..."
        Me.btnPesqOrc.UseVisualStyleBackColor = True
        '
        'btnAddComissao
        '
        Me.btnAddComissao.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddComissao.Location = New System.Drawing.Point(566, 54)
        Me.btnAddComissao.Name = "btnAddComissao"
        Me.btnAddComissao.Size = New System.Drawing.Size(90, 40)
        Me.btnAddComissao.TabIndex = 14
        Me.btnAddComissao.Text = "ADICIONAR COMISSÃO"
        Me.btnAddComissao.UseVisualStyleBackColor = True
        '
        'dgvComissoes
        '
        Me.dgvComissoes.AllowUserToAddRows = False
        Me.dgvComissoes.AllowUserToDeleteRows = False
        Me.dgvComissoes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvComissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComissoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PG, Me.Apolice, Me.Cliente, Me.Seguradora, Me.Parcelas, Me.Premio, Me.Comissao, Me.Comissao_Bruta, Me.Desconto, Me.Comissao_Liquida, Me.Valor_Pago, Me.Valor_Pagar, Me.dt_Pagamento})
        Me.dgvComissoes.Location = New System.Drawing.Point(10, 107)
        Me.dgvComissoes.MultiSelect = False
        Me.dgvComissoes.Name = "dgvComissoes"
        Me.dgvComissoes.ReadOnly = True
        Me.dgvComissoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComissoes.Size = New System.Drawing.Size(817, 266)
        Me.dgvComissoes.TabIndex = 17
        '
        'PG
        '
        Me.PG.HeaderText = "PG"
        Me.PG.Name = "PG"
        Me.PG.ReadOnly = True
        '
        'Apolice
        '
        Me.Apolice.HeaderText = "Apolice"
        Me.Apolice.Name = "Apolice"
        Me.Apolice.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Seguradora
        '
        Me.Seguradora.HeaderText = "Seguradora"
        Me.Seguradora.Name = "Seguradora"
        Me.Seguradora.ReadOnly = True
        '
        'Parcelas
        '
        Me.Parcelas.HeaderText = "Parcelas"
        Me.Parcelas.Name = "Parcelas"
        Me.Parcelas.ReadOnly = True
        '
        'Premio
        '
        Me.Premio.HeaderText = "Prêmio"
        Me.Premio.Name = "Premio"
        Me.Premio.ReadOnly = True
        '
        'Comissao
        '
        Me.Comissao.HeaderText = " % de Comissão"
        Me.Comissao.Name = "Comissao"
        Me.Comissao.ReadOnly = True
        '
        'Comissao_Bruta
        '
        Me.Comissao_Bruta.HeaderText = "Comissão Bruta"
        Me.Comissao_Bruta.Name = "Comissao_Bruta"
        Me.Comissao_Bruta.ReadOnly = True
        '
        'Desconto
        '
        Me.Desconto.HeaderText = "Desconto"
        Me.Desconto.Name = "Desconto"
        Me.Desconto.ReadOnly = True
        '
        'Comissao_Liquida
        '
        Me.Comissao_Liquida.HeaderText = "Comissão Líquida"
        Me.Comissao_Liquida.Name = "Comissao_Liquida"
        Me.Comissao_Liquida.ReadOnly = True
        '
        'Valor_Pago
        '
        Me.Valor_Pago.HeaderText = "Valor Pago"
        Me.Valor_Pago.Name = "Valor_Pago"
        Me.Valor_Pago.ReadOnly = True
        '
        'Valor_Pagar
        '
        Me.Valor_Pagar.HeaderText = "Valor à Pagar"
        Me.Valor_Pagar.Name = "Valor_Pagar"
        Me.Valor_Pagar.ReadOnly = True
        '
        'dt_Pagamento
        '
        Me.dt_Pagamento.HeaderText = "Data de Pagamento"
        Me.dt_Pagamento.Name = "dt_Pagamento"
        Me.dt_Pagamento.ReadOnly = True
        '
        'btnFecharComissoes
        '
        Me.btnFecharComissoes.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharComissoes.Location = New System.Drawing.Point(10, 390)
        Me.btnFecharComissoes.Name = "btnFecharComissoes"
        Me.btnFecharComissoes.Size = New System.Drawing.Size(150, 23)
        Me.btnFecharComissoes.TabIndex = 18
        Me.btnFecharComissoes.Text = "FECHAR COMISSÕES"
        Me.btnFecharComissoes.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 425)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(842, 79)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'txtVlrPago
        '
        Me.txtVlrPago.Location = New System.Drawing.Point(134, 57)
        Me.txtVlrPago.Mask = "000000000000000"
        Me.txtVlrPago.Name = "txtVlrPago"
        Me.txtVlrPago.Size = New System.Drawing.Size(108, 20)
        Me.txtVlrPago.TabIndex = 11
        '
        'txtVlrPagar
        '
        Me.txtVlrPagar.Location = New System.Drawing.Point(393, 57)
        Me.txtVlrPagar.Mask = "000000000000000"
        Me.txtVlrPagar.Name = "txtVlrPagar"
        Me.txtVlrPagar.Size = New System.Drawing.Size(114, 20)
        Me.txtVlrPagar.TabIndex = 20
        '
        'Comissoes
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 504)
        Me.Controls.Add(Me.txtVlrPagar)
        Me.Controls.Add(Me.txtVlrPago)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.mskApolice)
        Me.Controls.Add(Me.btnExcluirComissao)
        Me.Controls.Add(Me.mskDt_Pagamento)
        Me.Controls.Add(Me.mskDtCalc)
        Me.Controls.Add(Me.lbApolice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numParcela)
        Me.Controls.Add(Me.lbDt_Pagamento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbCodOrc)
        Me.Controls.Add(Me.btnPesqOrc)
        Me.Controls.Add(Me.btnAddComissao)
        Me.Controls.Add(Me.dgvComissoes)
        Me.Controls.Add(Me.btnFecharComissoes)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Comissoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Comissões ="
        CType(Me.numParcela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvComissoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents mskApolice As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnExcluirComissao As System.Windows.Forms.Button
    Friend WithEvents mskDt_Pagamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskDtCalc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbApolice As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numParcela As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbDt_Pagamento As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbCodOrc As System.Windows.Forms.Label
    Friend WithEvents btnPesqOrc As System.Windows.Forms.Button
    Friend WithEvents btnAddComissao As System.Windows.Forms.Button
    Friend WithEvents dgvComissoes As System.Windows.Forms.DataGridView
    Friend WithEvents PG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apolice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seguradora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Parcelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Premio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comissao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comissao_Bruta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desconto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comissao_Liquida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor_Pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor_Pagar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_Pagamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnFecharComissoes As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtVlrPago As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtVlrPagar As System.Windows.Forms.MaskedTextBox
End Class
