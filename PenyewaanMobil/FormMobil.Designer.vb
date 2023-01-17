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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMobil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewMobil = New System.Windows.Forms.DataGridView()
        Me.BtnTambahMobil = New System.Windows.Forms.Button()
        Me.BtnKurangMobil = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(98, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mobil"
        '
        'DataGridViewMobil
        '
        Me.DataGridViewMobil.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMobil.Location = New System.Drawing.Point(16, 64)
        Me.DataGridViewMobil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewMobil.Name = "DataGridViewMobil"
        Me.DataGridViewMobil.RowHeadersWidth = 62
        Me.DataGridViewMobil.RowTemplate.Height = 33
        Me.DataGridViewMobil.Size = New System.Drawing.Size(616, 209)
        Me.DataGridViewMobil.TabIndex = 1
        '
        'BtnTambahMobil
        '
        Me.BtnTambahMobil.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnTambahMobil.FlatAppearance.BorderSize = 0
        Me.BtnTambahMobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahMobil.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahMobil.ForeColor = System.Drawing.Color.White
        Me.BtnTambahMobil.Location = New System.Drawing.Point(54, 289)
        Me.BtnTambahMobil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnTambahMobil.Name = "BtnTambahMobil"
        Me.BtnTambahMobil.Size = New System.Drawing.Size(87, 36)
        Me.BtnTambahMobil.TabIndex = 2
        Me.BtnTambahMobil.Text = "Tambah"
        Me.BtnTambahMobil.UseVisualStyleBackColor = False
        '
        'BtnKurangMobil
        '
        Me.BtnKurangMobil.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnKurangMobil.FlatAppearance.BorderSize = 0
        Me.BtnKurangMobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKurangMobil.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnKurangMobil.ForeColor = System.Drawing.Color.White
        Me.BtnKurangMobil.Location = New System.Drawing.Point(341, 289)
        Me.BtnKurangMobil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnKurangMobil.Name = "BtnKurangMobil"
        Me.BtnKurangMobil.Size = New System.Drawing.Size(85, 36)
        Me.BtnKurangMobil.TabIndex = 3
        Me.BtnKurangMobil.Text = "Hapus"
        Me.BtnKurangMobil.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Location = New System.Drawing.Point(193, 289)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(94, 36)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(893, 61)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(670, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 198)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FormMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 343)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnKurangMobil)
        Me.Controls.Add(Me.BtnTambahMobil)
        Me.Controls.Add(Me.DataGridViewMobil)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormMobil"
        Me.Text = "FormMobil"
        CType(Me.DataGridViewMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewMobil As DataGridView
    Friend WithEvents BtnTambahMobil As Button
    Friend WithEvents BtnKurangMobil As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
