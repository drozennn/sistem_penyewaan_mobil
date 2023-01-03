<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditMobil
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.PictureBoxMobil = New System.Windows.Forms.PictureBox()
        Me.dtTglMasuk = New System.Windows.Forms.DateTimePicker()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.txtTipe = New System.Windows.Forms.TextBox()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.lblTanggalMasuk = New System.Windows.Forms.Label()
        Me.lblTahun = New System.Windows.Forms.Label()
        Me.lblHargaSewa = New System.Windows.Forms.Label()
        Me.lblMerek = New System.Windows.Forms.Label()
        Me.lblTipe = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(834, 292)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 39)
        Me.btnUpdate.TabIndex = 42
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnTambahGambar.FlatAppearance.BorderSize = 0
        Me.BtnTambahGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahGambar.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahGambar.ForeColor = System.Drawing.Color.White
        Me.BtnTambahGambar.Location = New System.Drawing.Point(5, 293)
        Me.BtnTambahGambar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(167, 36)
        Me.BtnTambahGambar.TabIndex = 41
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = False
        '
        'PictureBoxMobil
        '
        Me.PictureBoxMobil.Location = New System.Drawing.Point(5, 80)
        Me.PictureBoxMobil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxMobil.Name = "PictureBoxMobil"
        Me.PictureBoxMobil.Size = New System.Drawing.Size(167, 200)
        Me.PictureBoxMobil.TabIndex = 40
        Me.PictureBoxMobil.TabStop = False
        '
        'dtTglMasuk
        '
        Me.dtTglMasuk.Location = New System.Drawing.Point(173, 104)
        Me.dtTglMasuk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtTglMasuk.Name = "dtTglMasuk"
        Me.dtTglMasuk.Size = New System.Drawing.Size(229, 23)
        Me.dtTglMasuk.TabIndex = 36
        '
        'txtHarga
        '
        Me.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHarga.Location = New System.Drawing.Point(173, 23)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(229, 23)
        Me.txtHarga.TabIndex = 35
        '
        'txtJumlah
        '
        Me.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJumlah.Location = New System.Drawing.Point(88, 143)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(229, 23)
        Me.txtJumlah.TabIndex = 34
        '
        'txtMerek
        '
        Me.txtMerek.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMerek.Location = New System.Drawing.Point(88, 101)
        Me.txtMerek.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(229, 23)
        Me.txtMerek.TabIndex = 33
        '
        'cbJenis
        '
        Me.cbJenis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(88, 23)
        Me.cbJenis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(229, 23)
        Me.cbJenis.TabIndex = 32
        '
        'txtTipe
        '
        Me.txtTipe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipe.Location = New System.Drawing.Point(88, 63)
        Me.txtTipe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.Size = New System.Drawing.Size(229, 23)
        Me.txtTipe.TabIndex = 31
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblJumlah.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJumlah.Location = New System.Drawing.Point(13, 144)
        Me.lblJumlah.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(57, 17)
        Me.lblJumlah.TabIndex = 30
        Me.lblJumlah.Text = "Jumlah"
        '
        'lblTanggalMasuk
        '
        Me.lblTanggalMasuk.AutoSize = True
        Me.lblTanggalMasuk.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTanggalMasuk.Location = New System.Drawing.Point(10, 110)
        Me.lblTanggalMasuk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTanggalMasuk.Name = "lblTanggalMasuk"
        Me.lblTanggalMasuk.Size = New System.Drawing.Size(116, 17)
        Me.lblTanggalMasuk.TabIndex = 29
        Me.lblTanggalMasuk.Text = "Tanggal Masuk"
        '
        'lblTahun
        '
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTahun.Location = New System.Drawing.Point(10, 67)
        Me.lblTahun.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Size = New System.Drawing.Size(136, 17)
        Me.lblTahun.TabIndex = 27
        Me.lblTahun.Text = "Tahun Pembuatan"
        '
        'lblHargaSewa
        '
        Me.lblHargaSewa.AutoSize = True
        Me.lblHargaSewa.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHargaSewa.Location = New System.Drawing.Point(10, 24)
        Me.lblHargaSewa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHargaSewa.Name = "lblHargaSewa"
        Me.lblHargaSewa.Size = New System.Drawing.Size(92, 17)
        Me.lblHargaSewa.TabIndex = 26
        Me.lblHargaSewa.Text = "Harga Sewa"
        '
        'lblMerek
        '
        Me.lblMerek.AutoSize = True
        Me.lblMerek.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblMerek.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMerek.Location = New System.Drawing.Point(17, 104)
        Me.lblMerek.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMerek.Name = "lblMerek"
        Me.lblMerek.Size = New System.Drawing.Size(53, 17)
        Me.lblMerek.TabIndex = 25
        Me.lblMerek.Text = "Merek"
        '
        'lblTipe
        '
        Me.lblTipe.AutoSize = True
        Me.lblTipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblTipe.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTipe.Location = New System.Drawing.Point(16, 64)
        Me.lblTipe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.Size = New System.Drawing.Size(40, 17)
        Me.lblTipe.TabIndex = 24
        Me.lblTipe.Text = "Tipe"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblJenis.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJenis.Location = New System.Drawing.Point(13, 24)
        Me.lblJenis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(43, 17)
        Me.lblJenis.TabIndex = 23
        Me.lblJenis.Text = "Jenis"
        '
        'txtTahun
        '
        Me.txtTahun.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTahun.Location = New System.Drawing.Point(173, 61)
        Me.txtTahun.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(229, 23)
        Me.txtTahun.TabIndex = 43
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Tersedia", "Dipinjam"})
        Me.cbStatus.Location = New System.Drawing.Point(173, 147)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(229, 23)
        Me.cbStatus.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 69)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblJenis)
        Me.GroupBox2.Controls.Add(Me.lblTipe)
        Me.GroupBox2.Controls.Add(Me.lblMerek)
        Me.GroupBox2.Controls.Add(Me.lblJumlah)
        Me.GroupBox2.Controls.Add(Me.cbJenis)
        Me.GroupBox2.Controls.Add(Me.txtTipe)
        Me.GroupBox2.Controls.Add(Me.txtMerek)
        Me.GroupBox2.Controls.Add(Me.txtJumlah)
        Me.GroupBox2.Location = New System.Drawing.Point(196, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 189)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cbStatus)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtTahun)
        Me.GroupBox3.Controls.Add(Me.lblTanggalMasuk)
        Me.GroupBox3.Controls.Add(Me.lblTahun)
        Me.GroupBox3.Controls.Add(Me.dtTglMasuk)
        Me.GroupBox3.Controls.Add(Me.lblHargaSewa)
        Me.GroupBox3.Controls.Add(Me.txtHarga)
        Me.GroupBox3.Location = New System.Drawing.Point(550, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 189)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 41)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Edit Mobil"
        '
        'EditMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(997, 342)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PictureBoxMobil)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "EditMobil"
        Me.Text = "EditMobil"
        CType(Me.PictureBoxMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents PictureBoxMobil As PictureBox
    Friend WithEvents dtTglMasuk As DateTimePicker
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtMerek As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtTipe As TextBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTanggalMasuk As Label
    Friend WithEvents lblTahun As Label
    Friend WithEvents lblHargaSewa As Label
    Friend WithEvents lblMerek As Label
    Friend WithEvents lblTipe As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
