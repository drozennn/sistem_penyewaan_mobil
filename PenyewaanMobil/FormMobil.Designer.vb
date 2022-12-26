<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMobil
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
        Me.DataGridViewMobil = New System.Windows.Forms.DataGridView()
        Me.BtnTambahMobil = New System.Windows.Forms.Button()
        Me.BtnKurangMobil = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        CType(Me.DataGridViewMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 86)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mobil"
        '
        'DataGridViewMobil
        '
        Me.DataGridViewMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMobil.Location = New System.Drawing.Point(252, 35)
        Me.DataGridViewMobil.Name = "DataGridViewMobil"
        Me.DataGridViewMobil.RowHeadersWidth = 62
        Me.DataGridViewMobil.RowTemplate.Height = 33
        Me.DataGridViewMobil.Size = New System.Drawing.Size(948, 349)
        Me.DataGridViewMobil.TabIndex = 1
        '
        'BtnTambahMobil
        '
        Me.BtnTambahMobil.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahMobil.Location = New System.Drawing.Point(35, 129)
        Me.BtnTambahMobil.Name = "BtnTambahMobil"
        Me.BtnTambahMobil.Size = New System.Drawing.Size(55, 60)
        Me.BtnTambahMobil.TabIndex = 2
        Me.BtnTambahMobil.Text = "+"
        Me.BtnTambahMobil.UseVisualStyleBackColor = True
        '
        'BtnKurangMobil
        '
        Me.BtnKurangMobil.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnKurangMobil.Location = New System.Drawing.Point(144, 129)
        Me.BtnKurangMobil.Name = "BtnKurangMobil"
        Me.BtnKurangMobil.Size = New System.Drawing.Size(55, 60)
        Me.BtnKurangMobil.TabIndex = 3
        Me.BtnKurangMobil.Text = "-"
        Me.BtnKurangMobil.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(55, 249)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(112, 34)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'FormMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 521)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnKurangMobil)
        Me.Controls.Add(Me.BtnTambahMobil)
        Me.Controls.Add(Me.DataGridViewMobil)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMobil"
        Me.Text = "FormMobil"
        CType(Me.DataGridViewMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewMobil As DataGridView
    Friend WithEvents BtnTambahMobil As Button
    Friend WithEvents BtnKurangMobil As Button
    Friend WithEvents BtnEdit As Button
End Class
