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
        Me.LabelMerek = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(174, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 41)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Hapus Sewa Mobil"
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(437, 217)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(113, 23)
        Me.ButtonHapus.TabIndex = 48
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(51, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Anda yakin ingin menghapus nama"
        '
        'LabelPenyewa
        '
        Me.LabelPenyewa.AutoSize = True
        Me.LabelPenyewa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelPenyewa.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPenyewa.ForeColor = System.Drawing.Color.Red
        Me.LabelPenyewa.Location = New System.Drawing.Point(470, 101)
        Me.LabelPenyewa.Name = "LabelPenyewa"
        Me.LabelPenyewa.Size = New System.Drawing.Size(35, 18)
        Me.LabelPenyewa.TabIndex = 50
        Me.LabelPenyewa.Text = "test"
        Me.LabelPenyewa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMerek
        '
        Me.LabelMerek.AutoSize = True
        Me.LabelMerek.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMerek.ForeColor = System.Drawing.Color.Red
        Me.LabelMerek.Location = New System.Drawing.Point(470, 154)
        Me.LabelMerek.Name = "LabelMerek"
        Me.LabelMerek.Size = New System.Drawing.Size(35, 18)
        Me.LabelMerek.TabIndex = 52
        Me.LabelMerek.Text = "test"
        Me.LabelMerek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(51, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 18)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "yang meminjam mobil"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 97)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'hapus_sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(667, 266)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelMerek)
        Me.Controls.Add(Me.LabelPenyewa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "hapus_sewa"
        Me.Text = "hapus_sewa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelPenyewa As Label
    Friend WithEvents LabelMerek As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
