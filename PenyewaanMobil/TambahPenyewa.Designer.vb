<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPenyewa
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaPenyewa = New System.Windows.Forms.TextBox()
        Me.txtNIKPenyewa = New System.Windows.Forms.TextBox()
        Me.txtAlamatPenyewa = New System.Windows.Forms.RichTextBox()
        Me.BtnTambahPenyewa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'txtNamaPenyewa
        '
        Me.txtNamaPenyewa.Location = New System.Drawing.Point(150, 58)
        Me.txtNamaPenyewa.Name = "txtNamaPenyewa"
        Me.txtNamaPenyewa.Size = New System.Drawing.Size(259, 23)
        Me.txtNamaPenyewa.TabIndex = 3
        '
        'txtNIKPenyewa
        '
        Me.txtNIKPenyewa.Location = New System.Drawing.Point(150, 95)
        Me.txtNIKPenyewa.Name = "txtNIKPenyewa"
        Me.txtNIKPenyewa.Size = New System.Drawing.Size(259, 23)
        Me.txtNIKPenyewa.TabIndex = 4
        '
        'txtAlamatPenyewa
        '
        Me.txtAlamatPenyewa.Location = New System.Drawing.Point(150, 132)
        Me.txtAlamatPenyewa.Name = "txtAlamatPenyewa"
        Me.txtAlamatPenyewa.Size = New System.Drawing.Size(259, 66)
        Me.txtAlamatPenyewa.TabIndex = 5
        Me.txtAlamatPenyewa.Text = ""
        '
        'BtnTambahPenyewa
        '
        Me.BtnTambahPenyewa.Location = New System.Drawing.Point(218, 224)
        Me.BtnTambahPenyewa.Name = "BtnTambahPenyewa"
        Me.BtnTambahPenyewa.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambahPenyewa.TabIndex = 6
        Me.BtnTambahPenyewa.Text = "Tambah"
        Me.BtnTambahPenyewa.UseVisualStyleBackColor = True
        '
        'TambahPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 272)
        Me.Controls.Add(Me.BtnTambahPenyewa)
        Me.Controls.Add(Me.txtAlamatPenyewa)
        Me.Controls.Add(Me.txtNIKPenyewa)
        Me.Controls.Add(Me.txtNamaPenyewa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahPenyewa"
        Me.Text = "Tambah Penyewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamaPenyewa As TextBox
    Friend WithEvents txtNIKPenyewa As TextBox
    Friend WithEvents txtAlamatPenyewa As RichTextBox
    Friend WithEvents BtnTambahPenyewa As Button
End Class
