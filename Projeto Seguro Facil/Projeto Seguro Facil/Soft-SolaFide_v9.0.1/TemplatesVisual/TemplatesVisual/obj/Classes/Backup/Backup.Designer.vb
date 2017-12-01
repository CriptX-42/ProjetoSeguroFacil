<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Backup))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.btnAlterarDest = New System.Windows.Forms.Button()
        Me.txtBackPath = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Backup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAlterarDest
        '
        Me.btnAlterarDest.Location = New System.Drawing.Point(71, 40)
        Me.btnAlterarDest.Name = "btnAlterarDest"
        Me.btnAlterarDest.Size = New System.Drawing.Size(80, 23)
        Me.btnAlterarDest.TabIndex = 1
        Me.btnAlterarDest.Text = "Salvar..."
        Me.btnAlterarDest.UseVisualStyleBackColor = True
        '
        'txtBackPath
        '
        Me.txtBackPath.Enabled = False
        Me.txtBackPath.Location = New System.Drawing.Point(13, 13)
        Me.txtBackPath.Name = "txtBackPath"
        Me.txtBackPath.Size = New System.Drawing.Size(311, 21)
        Me.txtBackPath.TabIndex = 2
        '
        'Backup
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 82)
        Me.Controls.Add(Me.txtBackPath)
        Me.Controls.Add(Me.btnAlterarDest)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= BackUp ="
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnAlterarDest As System.Windows.Forms.Button
    Friend WithEvents txtBackPath As System.Windows.Forms.TextBox
End Class
