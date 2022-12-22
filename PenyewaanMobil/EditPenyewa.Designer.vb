<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPenyewa
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
        Me.BtnEditPenyewa = New System.Windows.Forms.Button()
        Me.txtAlamatPenyewa = New System.Windows.Forms.RichTextBox()
        Me.txtNIKPenyewa = New System.Windows.Forms.TextBox()
        Me.txtNamaPenyewa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEditPenyewa
        '
        Me.BtnEditPenyewa.Location = New System.Drawing.Point(241, 228)
        Me.BtnEditPenyewa.Name = "BtnEditPenyewa"
        Me.BtnEditPenyewa.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditPenyewa.TabIndex = 13
        Me.BtnEditPenyewa.Text = "Edit"
        Me.BtnEditPenyewa.UseVisualStyleBackColor = True
        '
        'txtAlamatPenyewa
        '
        Me.txtAlamatPenyewa.Location = New System.Drawing.Point(173, 136)
        Me.txtAlamatPenyewa.Name = "txtAlamatPenyewa"
        Me.txtAlamatPenyewa.Size = New System.Drawing.Size(259, 66)
        Me.txtAlamatPenyewa.TabIndex = 12
        Me.txtAlamatPenyewa.Text = ""
        '
        'txtNIKPenyewa
        '
        Me.txtNIKPenyewa.Location = New System.Drawing.Point(173, 99)
        Me.txtNIKPenyewa.Name = "txtNIKPenyewa"
        Me.txtNIKPenyewa.Size = New System.Drawing.Size(259, 23)
        Me.txtNIKPenyewa.TabIndex = 11
        '
        'txtNamaPenyewa
        '
        Me.txtNamaPenyewa.Location = New System.Drawing.Point(173, 62)
        Me.txtNamaPenyewa.Name = "txtNamaPenyewa"
        Me.txtNamaPenyewa.Size = New System.Drawing.Size(259, 23)
        Me.txtNamaPenyewa.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama"
        '
        'EditPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 313)
        Me.Controls.Add(Me.BtnEditPenyewa)
        Me.Controls.Add(Me.txtAlamatPenyewa)
        Me.Controls.Add(Me.txtNIKPenyewa)
        Me.Controls.Add(Me.txtNamaPenyewa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditPenyewa"
        Me.Text = "Edit Penyewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEditPenyewa As Button
    Friend WithEvents txtAlamatPenyewa As RichTextBox
    Friend WithEvents txtNIKPenyewa As TextBox
    Friend WithEvents txtNamaPenyewa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
