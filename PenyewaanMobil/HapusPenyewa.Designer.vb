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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah anda yakin ingin menghapus data penyewa :"
        '
        'NamaPenyewaHapus
        '
        Me.NamaPenyewaHapus.AutoSize = True
        Me.NamaPenyewaHapus.Location = New System.Drawing.Point(133, 77)
        Me.NamaPenyewaHapus.Name = "NamaPenyewaHapus"
        Me.NamaPenyewaHapus.Size = New System.Drawing.Size(41, 15)
        Me.NamaPenyewaHapus.TabIndex = 1
        Me.NamaPenyewaHapus.Text = "Label2"
        Me.NamaPenyewaHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(48, 138)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtnBatal.TabIndex = 2
        Me.BtnBatal.Text = "Tidak"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnKonfirmasi
        '
        Me.BtnKonfirmasi.Location = New System.Drawing.Point(180, 138)
        Me.BtnKonfirmasi.Name = "BtnKonfirmasi"
        Me.BtnKonfirmasi.Size = New System.Drawing.Size(75, 23)
        Me.BtnKonfirmasi.TabIndex = 3
        Me.BtnKonfirmasi.Text = "Ya"
        Me.BtnKonfirmasi.UseVisualStyleBackColor = True
        '
        'HapusPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 190)
        Me.Controls.Add(Me.BtnKonfirmasi)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.NamaPenyewaHapus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusPenyewa"
        Me.Text = "Hapus Penyewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NamaPenyewaHapus As Label
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnKonfirmasi As Button
End Class
