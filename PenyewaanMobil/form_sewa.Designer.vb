﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.DataGridSewa = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button = New System.Windows.Forms.Button()
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(649, 375)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(118, 28)
        Me.ButtonHapus.TabIndex = 9
        Me.ButtonHapus.Text = "Hapus Data Sewa"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(490, 375)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(118, 28)
        Me.ButtonEdit.TabIndex = 8
        Me.ButtonEdit.Text = "Update Data Sewa"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(333, 375)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(118, 28)
        Me.ButtonTambah.TabIndex = 7
        Me.ButtonTambah.Text = "Tambah Data Sewa"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'DataGridSewa
        '
        Me.DataGridSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSewa.Location = New System.Drawing.Point(316, 78)
        Me.DataGridSewa.Name = "DataGridSewa"
        Me.DataGridSewa.RowTemplate.Height = 25
        Me.DataGridSewa.Size = New System.Drawing.Size(691, 229)
        Me.DataGridSewa.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(518, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 51)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sewa Mobil"
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(102, 104)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(118, 28)
        Me.Button.TabIndex = 10
        Me.Button.Text = "Tambah Data Sewa"
        Me.Button.UseVisualStyleBackColor = True
        '
        'form_sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 450)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.DataGridSewa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_sewa"
        Me.Text = "form_sewa"
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents DataGridSewa As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button As Button
End Class
