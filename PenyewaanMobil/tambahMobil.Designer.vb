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
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.dtTglMasuk = New System.Windows.Forms.DateTimePicker()
        Me.PictureBoxMobil = New System.Windows.Forms.PictureBox()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.BtnTmbh = New System.Windows.Forms.Button()
        CType(Me.PictureBoxMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJenis.Location = New System.Drawing.Point(191, 26)
        Me.lblJenis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(37, 15)
        Me.lblJenis.TabIndex = 0
        Me.lblJenis.Text = "Jenis"
        '
        'lblTipe
        '
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTipe.Location = New System.Drawing.Point(191, 69)
        Me.lblTipe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.Size = New System.Drawing.Size(33, 15)
        Me.lblTipe.TabIndex = 1
        Me.lblTipe.Text = "Tipe"
        '
        'lblMerek
        '
        Me.lblMerek.AutoSize = True
        Me.lblMerek.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMerek.Location = New System.Drawing.Point(191, 109)
        Me.lblMerek.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMerek.Name = "lblMerek"
        Me.lblMerek.Size = New System.Drawing.Size(47, 15)
        Me.lblMerek.TabIndex = 2
        Me.lblMerek.Text = "Merek"
        '
        'lblHargaSewa
        '
        Me.lblHargaSewa.AutoSize = True
        Me.lblHargaSewa.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHargaSewa.Location = New System.Drawing.Point(191, 220)
        Me.lblHargaSewa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHargaSewa.Name = "lblHargaSewa"
        Me.lblHargaSewa.Size = New System.Drawing.Size(81, 15)
        Me.lblHargaSewa.TabIndex = 3
        Me.lblHargaSewa.Text = "Harga Sewa"
        '
        'lblTahun
        '
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTahun.Location = New System.Drawing.Point(191, 271)
        Me.lblTahun.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Size = New System.Drawing.Size(118, 15)
        Me.lblTahun.TabIndex = 4
        Me.lblTahun.Text = "Tahun Pembuatan"
        '
        'lblTanggalMasuk
        '
        Me.lblTanggalMasuk.AutoSize = True
        Me.lblTanggalMasuk.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTanggalMasuk.Location = New System.Drawing.Point(193, 327)
        Me.lblTanggalMasuk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTanggalMasuk.Name = "lblTanggalMasuk"
        Me.lblTanggalMasuk.Size = New System.Drawing.Size(100, 15)
        Me.lblTanggalMasuk.TabIndex = 7
        Me.lblTanggalMasuk.Text = "Tanggal Masuk"
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJumlah.Location = New System.Drawing.Point(191, 165)
        Me.lblJumlah.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(48, 15)
        Me.lblJumlah.TabIndex = 8
        Me.lblJumlah.Text = "Jumlah"
        '
        'txtTipe
        '
        Me.txtTipe.Location = New System.Drawing.Point(341, 63)
        Me.txtTipe.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.Size = New System.Drawing.Size(229, 23)
        Me.txtTipe.TabIndex = 9
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(341, 104)
        Me.txtMerek.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(229, 23)
        Me.txtMerek.TabIndex = 11
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(341, 160)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(229, 23)
        Me.txtJumlah.TabIndex = 12
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(341, 214)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(229, 23)
        Me.txtHarga.TabIndex = 13
        '
        'dtTglMasuk
        '
        Me.dtTglMasuk.Location = New System.Drawing.Point(341, 321)
        Me.dtTglMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.dtTglMasuk.Name = "dtTglMasuk"
        Me.dtTglMasuk.Size = New System.Drawing.Size(229, 23)
        Me.dtTglMasuk.TabIndex = 15
        '
        'PictureBoxMobil
        '
        Me.PictureBoxMobil.Location = New System.Drawing.Point(11, 22)
        Me.PictureBoxMobil.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxMobil.Name = "PictureBoxMobil"
        Me.PictureBoxMobil.Size = New System.Drawing.Size(151, 176)
        Me.PictureBoxMobil.TabIndex = 19
        Me.PictureBoxMobil.TabStop = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnTambahGambar.FlatAppearance.BorderSize = 0
        Me.BtnTambahGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahGambar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahGambar.ForeColor = System.Drawing.Color.White
        Me.BtnTambahGambar.Location = New System.Drawing.Point(11, 202)
        Me.BtnTambahGambar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(151, 34)
        Me.BtnTambahGambar.TabIndex = 20
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(341, 269)
        Me.txtTahun.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(229, 23)
        Me.txtTahun.TabIndex = 22
        '
        'cbJenis
        '
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(341, 22)
        Me.cbJenis.Margin = New System.Windows.Forms.Padding(2)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(229, 23)
        Me.cbJenis.TabIndex = 23
        '
        'BtnTmbh
        '
        Me.BtnTmbh.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnTmbh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTmbh.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTmbh.ForeColor = System.Drawing.Color.White
        Me.BtnTmbh.Location = New System.Drawing.Point(430, 362)
        Me.BtnTmbh.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTmbh.Name = "BtnTmbh"
        Me.BtnTmbh.Size = New System.Drawing.Size(140, 34)
        Me.BtnTmbh.TabIndex = 24
        Me.BtnTmbh.Text = "Tambah"
        Me.BtnTmbh.UseVisualStyleBackColor = False
        '
        'tambahMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(643, 414)
        Me.Controls.Add(Me.BtnTmbh)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PictureBoxMobil)
        Me.Controls.Add(Me.dtTglMasuk)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtMerek)
        Me.Controls.Add(Me.txtTipe)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.lblTanggalMasuk)
        Me.Controls.Add(Me.lblTahun)
        Me.Controls.Add(Me.lblHargaSewa)
        Me.Controls.Add(Me.lblMerek)
        Me.Controls.Add(Me.lblTipe)
        Me.Controls.Add(Me.lblJenis)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents txtMerek As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents dtTglMasuk As DateTimePicker
    Friend WithEvents PictureBoxMobil As PictureBox
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents BtnTmbh As Button
End Class
