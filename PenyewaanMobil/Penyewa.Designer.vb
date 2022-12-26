<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Penyewa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridPenyewa = New System.Windows.Forms.DataGridView()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        CType(Me.DataGridPenyewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridPenyewa
        '
        Me.DataGridPenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPenyewa.Location = New System.Drawing.Point(127, 37)
        Me.DataGridPenyewa.Name = "DataGridPenyewa"
        Me.DataGridPenyewa.RowTemplate.Height = 25
        Me.DataGridPenyewa.Size = New System.Drawing.Size(445, 252)
        Me.DataGridPenyewa.TabIndex = 0
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(24, 47)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 1
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(24, 87)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(24, 126)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 3
        Me.BtnRemove.Text = "Hapus"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Penyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 322)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DataGridPenyewa)
        Me.Name = "Penyewa"
        Me.Text = "Penyewa"
        CType(Me.DataGridPenyewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridPenyewa As DataGridView
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnRemove As Button
End Class
