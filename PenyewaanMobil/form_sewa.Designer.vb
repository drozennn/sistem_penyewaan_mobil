<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_sewa
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridSewa = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(649, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Hapus Data Sewa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(490, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Edit Data Sewa"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(333, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Tambah Data Sewa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridSewa
        '
        Me.DataGridSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSewa.Location = New System.Drawing.Point(320, 114)
        Me.DataGridSewa.Name = "DataGridSewa"
        Me.DataGridSewa.RowTemplate.Height = 25
        Me.DataGridSewa.Size = New System.Drawing.Size(687, 229)
        Me.DataGridSewa.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(405, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 51)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sewa Mobil"
        '
        'form_sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridSewa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_sewa"
        Me.Text = "form_sewa"
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridSewa As DataGridView
    Friend WithEvents Label1 As Label
End Class
