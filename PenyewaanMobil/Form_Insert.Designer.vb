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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxJenisMobil = New System.Windows.Forms.TextBox()
        Me.DateTimePickerTanggal = New System.Windows.Forms.DateTimePicker()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(151, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Mobil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(151, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Dibuat"
        '
        'TxtBoxJenisMobil
        '
        Me.TxtBoxJenisMobil.Location = New System.Drawing.Point(317, 168)
        Me.TxtBoxJenisMobil.Name = "TxtBoxJenisMobil"
        Me.TxtBoxJenisMobil.Size = New System.Drawing.Size(250, 27)
        Me.TxtBoxJenisMobil.TabIndex = 2
        '
        'DateTimePickerTanggal
        '
        Me.DateTimePickerTanggal.Location = New System.Drawing.Point(317, 215)
        Me.DateTimePickerTanggal.Name = "DateTimePickerTanggal"
        Me.DateTimePickerTanggal.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePickerTanggal.TabIndex = 3
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(473, 285)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(94, 29)
        Me.BtnSubmit.TabIndex = 4
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'Form_Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.DateTimePickerTanggal)
        Me.Controls.Add(Me.TxtBoxJenisMobil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Insert"
        Me.Text = "Form_Insert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxJenisMobil As TextBox
    Friend WithEvents DateTimePickerTanggal As DateTimePicker
    Friend WithEvents BtnSubmit As Button
End Class
