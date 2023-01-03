<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusMobil
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHapusMobil = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(216, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "apakah anda ingin menghapus"
        '
        'lblHapusMobil
        '
        Me.lblHapusMobil.AutoSize = True
        Me.lblHapusMobil.Font = New System.Drawing.Font("Old English Text MT", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHapusMobil.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblHapusMobil.Location = New System.Drawing.Point(174, 110)
        Me.lblHapusMobil.Name = "lblHapusMobil"
        Me.lblHapusMobil.Size = New System.Drawing.Size(429, 171)
        Me.lblHapusMobil.TabIndex = 1
        Me.lblHapusMobil.Text = "Mobil"
        Me.lblHapusMobil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(335, 329)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 34)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'HapusMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.lblHapusMobil)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusMobil"
        Me.Text = "HapusMobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblHapusMobil As Label
    Friend WithEvents BtnHapus As Button
End Class
