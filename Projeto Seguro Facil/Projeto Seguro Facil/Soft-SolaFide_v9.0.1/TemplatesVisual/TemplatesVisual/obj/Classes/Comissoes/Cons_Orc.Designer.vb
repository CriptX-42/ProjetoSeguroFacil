<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cons_Orc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cons_Orc))
        Me.dgvConsOrc = New System.Windows.Forms.DataGridView()
        Me.dt_Calculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seguradora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Premio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parcelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perc_Comissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvConsOrc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsOrc
        '
        Me.dgvConsOrc.AllowUserToAddRows = False
        Me.dgvConsOrc.AllowUserToDeleteRows = False
        Me.dgvConsOrc.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvConsOrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsOrc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dt_Calculo, Me.Nome_Cliente, Me.Seguradora, Me.Premio, Me.parcelas, Me.Perc_Comissao})
        Me.dgvConsOrc.Location = New System.Drawing.Point(24, 12)
        Me.dgvConsOrc.Name = "dgvConsOrc"
        Me.dgvConsOrc.ReadOnly = True
        Me.dgvConsOrc.Size = New System.Drawing.Size(644, 265)
        Me.dgvConsOrc.TabIndex = 26
        '
        'dt_Calculo
        '
        Me.dt_Calculo.DataPropertyName = "dt_calculo"
        Me.dt_Calculo.HeaderText = "Data do Calculo"
        Me.dt_Calculo.Name = "dt_Calculo"
        Me.dt_Calculo.ReadOnly = True
        '
        'Nome_Cliente
        '
        Me.Nome_Cliente.DataPropertyName = "nome_cliente"
        Me.Nome_Cliente.HeaderText = "Nome Cliente"
        Me.Nome_Cliente.Name = "Nome_Cliente"
        Me.Nome_Cliente.ReadOnly = True
        '
        'Seguradora
        '
        Me.Seguradora.DataPropertyName = "Seguradora_Orc"
        Me.Seguradora.HeaderText = "Seguradora"
        Me.Seguradora.Name = "Seguradora"
        Me.Seguradora.ReadOnly = True
        '
        'Premio
        '
        Me.Premio.DataPropertyName = "premio_seguradora"
        Me.Premio.HeaderText = "Premio"
        Me.Premio.Name = "Premio"
        Me.Premio.ReadOnly = True
        '
        'parcelas
        '
        Me.parcelas.DataPropertyName = "parcelas"
        Me.parcelas.HeaderText = "Parcelas"
        Me.parcelas.Name = "parcelas"
        Me.parcelas.ReadOnly = True
        '
        'Perc_Comissao
        '
        Me.Perc_Comissao.DataPropertyName = "perc_comissao"
        Me.Perc_Comissao.HeaderText = "% de Comissão"
        Me.Perc_Comissao.Name = "Perc_Comissao"
        Me.Perc_Comissao.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SeguroFacil.My.Resources.Resources.Action_ok_icon
        Me.PictureBox1.Location = New System.Drawing.Point(302, 283)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Cons_Orc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(692, 366)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvConsOrc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cons_Orc"
        Me.Text = "Cons_Orc"
        CType(Me.dgvConsOrc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvConsOrc As System.Windows.Forms.DataGridView
    Friend WithEvents dt_Calculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seguradora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Premio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents parcelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Perc_Comissao As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
