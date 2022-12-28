<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_sewa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_sewa))
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.DataGridSewa = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonJenis = New System.Windows.Forms.Button()
        Me.ButtonMobil = New System.Windows.Forms.Button()
        Me.ButtonPenyewa = New System.Windows.Forms.Button()
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ButtonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonHapus.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonHapus.Location = New System.Drawing.Point(701, 361)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(160, 38)
        Me.ButtonHapus.TabIndex = 9
        Me.ButtonHapus.Text = "Hapus Data Sewa"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEdit.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonEdit.Location = New System.Drawing.Point(515, 361)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(165, 38)
        Me.ButtonEdit.TabIndex = 8
        Me.ButtonEdit.Text = "Update Data Sewa"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'DataGridSewa
        '
        Me.DataGridSewa.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSewa.Location = New System.Drawing.Point(328, 101)
        Me.DataGridSewa.Name = "DataGridSewa"
        Me.DataGridSewa.RowTemplate.Height = 25
        Me.DataGridSewa.Size = New System.Drawing.Size(691, 245)
        Me.DataGridSewa.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(719, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Penyewaan Mobil"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(24, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 245)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ButtonPenyewa)
        Me.GroupBox1.Controls.Add(Me.ButtonMobil)
        Me.GroupBox1.Controls.Add(Me.ButtonJenis)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(-8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1027, 86)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ButtonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonTambah.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTambah.Location = New System.Drawing.Point(329, 361)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(165, 38)
        Me.ButtonTambah.TabIndex = 10
        Me.ButtonTambah.Text = "Tambah Data Sewa"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'ButtonJenis
        '
        Me.ButtonJenis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonJenis.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonJenis.Location = New System.Drawing.Point(32, 22)
        Me.ButtonJenis.Name = "ButtonJenis"
        Me.ButtonJenis.Size = New System.Drawing.Size(106, 41)
        Me.ButtonJenis.TabIndex = 6
        Me.ButtonJenis.Text = "Jenis Mobil"
        Me.ButtonJenis.UseVisualStyleBackColor = True
        '
        'ButtonMobil
        '
        Me.ButtonMobil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonMobil.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonMobil.Location = New System.Drawing.Point(191, 22)
        Me.ButtonMobil.Name = "ButtonMobil"
        Me.ButtonMobil.Size = New System.Drawing.Size(106, 41)
        Me.ButtonMobil.TabIndex = 7
        Me.ButtonMobil.Text = "Mobil"
        Me.ButtonMobil.UseVisualStyleBackColor = True
        '
        'ButtonPenyewa
        '
        Me.ButtonPenyewa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPenyewa.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonPenyewa.Location = New System.Drawing.Point(353, 22)
        Me.ButtonPenyewa.Name = "ButtonPenyewa"
        Me.ButtonPenyewa.Size = New System.Drawing.Size(106, 41)
        Me.ButtonPenyewa.TabIndex = 8
        Me.ButtonPenyewa.Text = "Penyewa"
        Me.ButtonPenyewa.UseVisualStyleBackColor = True
        '
        'form_sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1031, 411)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridSewa)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonEdit)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "form_sewa"
        Me.Text = "form_sewa"
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents DataGridSewa As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents ButtonPenyewa As Button
    Friend WithEvents ButtonMobil As Button
    Friend WithEvents ButtonJenis As Button
End Class
