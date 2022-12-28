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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEditPenyewa
        '
        Me.BtnEditPenyewa.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditPenyewa.Location = New System.Drawing.Point(242, 312)
        Me.BtnEditPenyewa.Name = "BtnEditPenyewa"
        Me.BtnEditPenyewa.Size = New System.Drawing.Size(95, 30)
        Me.BtnEditPenyewa.TabIndex = 13
        Me.BtnEditPenyewa.Text = "Edit"
        Me.BtnEditPenyewa.UseVisualStyleBackColor = True
        '
        'txtAlamatPenyewa
        '
        Me.txtAlamatPenyewa.Location = New System.Drawing.Point(193, 208)
        Me.txtAlamatPenyewa.Name = "txtAlamatPenyewa"
        Me.txtAlamatPenyewa.Size = New System.Drawing.Size(259, 66)
        Me.txtAlamatPenyewa.TabIndex = 12
        Me.txtAlamatPenyewa.Text = ""
        '
        'txtNIKPenyewa
        '
        Me.txtNIKPenyewa.Location = New System.Drawing.Point(193, 171)
        Me.txtNIKPenyewa.Name = "txtNIKPenyewa"
        Me.txtNIKPenyewa.Size = New System.Drawing.Size(259, 23)
        Me.txtNIKPenyewa.TabIndex = 11
        '
        'txtNamaPenyewa
        '
        Me.txtNamaPenyewa.Location = New System.Drawing.Point(193, 134)
        Me.txtNamaPenyewa.Name = "txtNamaPenyewa"
        Me.txtNamaPenyewa.Size = New System.Drawing.Size(259, 23)
        Me.txtNamaPenyewa.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(100, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(100, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(100, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Chocolate
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 82)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(171, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 41)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Edit Penyewa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 390)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnEditPenyewa)
        Me.Controls.Add(Me.txtAlamatPenyewa)
        Me.Controls.Add(Me.txtNIKPenyewa)
        Me.Controls.Add(Me.txtNamaPenyewa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditPenyewa"
        Me.Text = "Edit Penyewa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
End Class
