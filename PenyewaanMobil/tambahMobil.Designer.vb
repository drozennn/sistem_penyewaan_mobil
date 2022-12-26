<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambahMobil
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
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.lblTipe = New System.Windows.Forms.Label()
        Me.lblMerek = New System.Windows.Forms.Label()
        Me.lblHargaSewa = New System.Windows.Forms.Label()
        Me.lblTahun = New System.Windows.Forms.Label()
        Me.lblTanggalMasuk = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.txtTipe = New System.Windows.Forms.TextBox()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.dtTglMasuk = New System.Windows.Forms.DateTimePicker()
        Me.PictureBoxMobil = New System.Windows.Forms.PictureBox()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.DtTahunPembuatan = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBoxMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(300, 40)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(49, 25)
        Me.lblJenis.TabIndex = 0
        Me.lblJenis.Text = "Jenis"
        '
        'lblTipe
        '
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Location = New System.Drawing.Point(300, 111)
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.Size = New System.Drawing.Size(45, 25)
        Me.lblTipe.TabIndex = 1
        Me.lblTipe.Text = "Tipe"
        '
        'lblMerek
        '
        Me.lblMerek.AutoSize = True
        Me.lblMerek.Location = New System.Drawing.Point(300, 179)
        Me.lblMerek.Name = "lblMerek"
        Me.lblMerek.Size = New System.Drawing.Size(61, 25)
        Me.lblMerek.TabIndex = 2
        Me.lblMerek.Text = "Merek"
        '
        'lblHargaSewa
        '
        Me.lblHargaSewa.AutoSize = True
        Me.lblHargaSewa.Location = New System.Drawing.Point(300, 363)
        Me.lblHargaSewa.Name = "lblHargaSewa"
        Me.lblHargaSewa.Size = New System.Drawing.Size(106, 25)
        Me.lblHargaSewa.TabIndex = 3
        Me.lblHargaSewa.Text = "Harga Sewa"
        '
        'lblTahun
        '
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Location = New System.Drawing.Point(300, 448)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Size = New System.Drawing.Size(152, 25)
        Me.lblTahun.TabIndex = 4
        Me.lblTahun.Text = "Tahun Pembuatan"
        '
        'lblTanggalMasuk
        '
        Me.lblTanggalMasuk.AutoSize = True
        Me.lblTanggalMasuk.Location = New System.Drawing.Point(303, 541)
        Me.lblTanggalMasuk.Name = "lblTanggalMasuk"
        Me.lblTanggalMasuk.Size = New System.Drawing.Size(130, 25)
        Me.lblTanggalMasuk.TabIndex = 7
        Me.lblTanggalMasuk.Text = "Tanggal Masuk"
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(300, 272)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(67, 25)
        Me.lblJumlah.TabIndex = 8
        Me.lblJumlah.Text = "Jumlah"
        '
        'txtTipe
        '
        Me.txtTipe.Location = New System.Drawing.Point(487, 105)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.Size = New System.Drawing.Size(326, 31)
        Me.txtTipe.TabIndex = 9
        '
        'cbJenis
        '
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(487, 40)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(326, 33)
        Me.cbJenis.TabIndex = 10
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(487, 173)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(326, 31)
        Me.txtMerek.TabIndex = 11
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(487, 266)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(326, 31)
        Me.txtJumlah.TabIndex = 12
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(487, 357)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(326, 31)
        Me.txtHarga.TabIndex = 13
        '
        'dtTglMasuk
        '
        Me.dtTglMasuk.Location = New System.Drawing.Point(487, 535)
        Me.dtTglMasuk.Name = "dtTglMasuk"
        Me.dtTglMasuk.Size = New System.Drawing.Size(326, 31)
        Me.dtTglMasuk.TabIndex = 15
        '
        'PictureBoxMobil
        '
        Me.PictureBoxMobil.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxMobil.Name = "PictureBoxMobil"
        Me.PictureBoxMobil.Size = New System.Drawing.Size(260, 228)
        Me.PictureBoxMobil.TabIndex = 19
        Me.PictureBoxMobil.TabStop = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(56, 264)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(170, 34)
        Me.BtnTambahGambar.TabIndex = 20
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(798, 754)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(112, 34)
        Me.btnTambah.TabIndex = 21
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'DtTahunPembuatan
        '
        Me.DtTahunPembuatan.Location = New System.Drawing.Point(487, 448)
        Me.DtTahunPembuatan.Name = "DtTahunPembuatan"
        Me.DtTahunPembuatan.Size = New System.Drawing.Size(326, 31)
        Me.DtTahunPembuatan.TabIndex = 22
        '
        'tambahMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 801)
        Me.Controls.Add(Me.DtTahunPembuatan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PictureBoxMobil)
        Me.Controls.Add(Me.dtTglMasuk)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtMerek)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.txtTipe)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.lblTanggalMasuk)
        Me.Controls.Add(Me.lblTahun)
        Me.Controls.Add(Me.lblHargaSewa)
        Me.Controls.Add(Me.lblMerek)
        Me.Controls.Add(Me.lblTipe)
        Me.Controls.Add(Me.lblJenis)
        Me.Name = "tambahMobil"
        Me.Text = "tambahMobil"
        CType(Me.PictureBoxMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJenis As Label
    Friend WithEvents lblTipe As Label
    Friend WithEvents lblMerek As Label
    Friend WithEvents lblHargaSewa As Label
    Friend WithEvents lblTahun As Label
    Friend WithEvents lblTanggalMasuk As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtTipe As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtMerek As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents dtTglMasuk As DateTimePicker
    Friend WithEvents PictureBoxMobil As PictureBox
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnTambah As Button
    Friend WithEvents DtTahunPembuatan As DateTimePicker
End Class
