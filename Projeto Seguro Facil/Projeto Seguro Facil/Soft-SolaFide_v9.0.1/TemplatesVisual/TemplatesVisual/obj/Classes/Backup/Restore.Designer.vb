<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restore))
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.txtRestorePath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Location = New System.Drawing.Point(173, 40)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(88, 23)
        Me.btnRestaurar.TabIndex = 0
        Me.btnRestaurar.Text = "Restaurar"
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'txtRestorePath
        '
        Me.txtRestorePath.Enabled = False
        Me.txtRestorePath.Location = New System.Drawing.Point(13, 13)
        Me.txtRestorePath.Name = "txtRestorePath"
        Me.txtRestorePath.Size = New System.Drawing.Size(318, 21)
        Me.txtRestorePath.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Abrir..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Restore
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 74)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtRestorePath)
        Me.Controls.Add(Me.btnRestaurar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Restore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Restaurar = "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtRestorePath As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
