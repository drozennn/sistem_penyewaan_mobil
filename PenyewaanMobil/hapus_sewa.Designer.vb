<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hapus_sewa
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
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelPenyewa = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelMerek = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(122, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 51)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Hapus Sewa Mobil"
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(243, 155)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(113, 23)
        Me.ButtonHapus.TabIndex = 48
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(29, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 21)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Anda yakin ingin menghapus data"
        '
        'LabelPenyewa
        '
        Me.LabelPenyewa.AutoSize = True
        Me.LabelPenyewa.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LabelPenyewa.ForeColor = System.Drawing.Color.Red
        Me.LabelPenyewa.Location = New System.Drawing.Point(291, 89)
        Me.LabelPenyewa.Name = "LabelPenyewa"
        Me.LabelPenyewa.Size = New System.Drawing.Size(37, 21)
        Me.LabelPenyewa.TabIndex = 50
        Me.LabelPenyewa.Text = "test"
        Me.LabelPenyewa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(357, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "yang menyewa mobil"
        '
        'LabelMerek
        '
        Me.LabelMerek.AutoSize = True
        Me.LabelMerek.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LabelMerek.ForeColor = System.Drawing.Color.Red
        Me.LabelMerek.Location = New System.Drawing.Point(538, 89)
        Me.LabelMerek.Name = "LabelMerek"
        Me.LabelMerek.Size = New System.Drawing.Size(37, 21)
        Me.LabelMerek.TabIndex = 52
        Me.LabelMerek.Text = "test"
        Me.LabelMerek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hapus_sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 229)
        Me.Controls.Add(Me.LabelMerek)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelPenyewa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "hapus_sewa"
        Me.Text = "hapus_sewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelPenyewa As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelMerek As Label
End Class
