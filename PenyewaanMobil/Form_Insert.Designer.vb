<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Insert
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxJenisMobil = New System.Windows.Forms.TextBox()
        Me.DateTimePickerTanggal = New System.Windows.Forms.DateTimePicker()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(107, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 37)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Insert Jenis Mobil"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Location = New System.Drawing.Point(-1, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(467, 67)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(20, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Dibuat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(20, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Mobil"
        '
        'TxtBoxJenisMobil
        '
        Me.TxtBoxJenisMobil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBoxJenisMobil.Location = New System.Drawing.Point(165, 93)
        Me.TxtBoxJenisMobil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBoxJenisMobil.Name = "TxtBoxJenisMobil"
        Me.TxtBoxJenisMobil.Size = New System.Drawing.Size(219, 23)
        Me.TxtBoxJenisMobil.TabIndex = 2
        '
        'DateTimePickerTanggal
        '
        Me.DateTimePickerTanggal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePickerTanggal.Location = New System.Drawing.Point(165, 128)
        Me.DateTimePickerTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerTanggal.Name = "DateTimePickerTanggal"
        Me.DateTimePickerTanggal.Size = New System.Drawing.Size(219, 23)
        Me.DateTimePickerTanggal.TabIndex = 3
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Lucida Sans", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSubmit.ForeColor = System.Drawing.Color.White
        Me.BtnSubmit.Location = New System.Drawing.Point(326, 184)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(107, 41)
        Me.BtnSubmit.TabIndex = 4
        Me.BtnSubmit.Text = "Tambah"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'Form_Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 236)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DateTimePickerTanggal)
        Me.Controls.Add(Me.TxtBoxJenisMobil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_Insert"
        Me.Text = "Form_Insert"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxJenisMobil As TextBox
    Friend WithEvents DateTimePickerTanggal As DateTimePicker
    Friend WithEvents BtnSubmit As Button
End Class
