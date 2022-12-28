<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusPenyewa
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
        Me.NamaPenyewaHapus = New System.Windows.Forms.Label()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnKonfirmasi = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(73, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah anda yakin ingin menghapus data penyewa :"
        '
        'NamaPenyewaHapus
        '
        Me.NamaPenyewaHapus.AutoSize = True
        Me.NamaPenyewaHapus.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NamaPenyewaHapus.ForeColor = System.Drawing.Color.Red
        Me.NamaPenyewaHapus.Location = New System.Drawing.Point(242, 129)
        Me.NamaPenyewaHapus.Name = "NamaPenyewaHapus"
        Me.NamaPenyewaHapus.Size = New System.Drawing.Size(68, 20)
        Me.NamaPenyewaHapus.TabIndex = 1
        Me.NamaPenyewaHapus.Text = "Label2"
        Me.NamaPenyewaHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnBatal.Location = New System.Drawing.Point(121, 185)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(90, 29)
        Me.BtnBatal.TabIndex = 2
        Me.BtnBatal.Text = "Tidak"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnKonfirmasi
        '
        Me.BtnKonfirmasi.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnKonfirmasi.Location = New System.Drawing.Point(347, 185)
        Me.BtnKonfirmasi.Name = "BtnKonfirmasi"
        Me.BtnKonfirmasi.Size = New System.Drawing.Size(88, 29)
        Me.BtnKonfirmasi.TabIndex = 3
        Me.BtnKonfirmasi.Text = "Ya"
        Me.BtnKonfirmasi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Red
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(-4, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 66)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(155, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 41)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hapus Penyewa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HapusPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 252)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnKonfirmasi)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.NamaPenyewaHapus)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "HapusPenyewa"
        Me.Text = "Hapus Penyewa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NamaPenyewaHapus As Label
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnKonfirmasi As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
End Class
