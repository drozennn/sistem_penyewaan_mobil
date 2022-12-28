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
        CType(Me.PictureBoxMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(798, 754)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 34)
        Me.btnUpdate.TabIndex = 42
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(56, 264)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(170, 34)
        Me.BtnTambahGambar.TabIndex = 41
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'PictureBoxMobil
        '
        Me.PictureBoxMobil.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxMobil.Name = "PictureBoxMobil"
        Me.PictureBoxMobil.Size = New System.Drawing.Size(260, 228)
        Me.PictureBoxMobil.TabIndex = 40
        Me.PictureBoxMobil.TabStop = False
        '
        'dtTglMasuk
        '
        Me.dtTglMasuk.Location = New System.Drawing.Point(487, 535)
        Me.dtTglMasuk.Name = "dtTglMasuk"
        Me.dtTglMasuk.Size = New System.Drawing.Size(326, 31)
        Me.dtTglMasuk.TabIndex = 36
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(487, 357)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(326, 31)
        Me.txtHarga.TabIndex = 35
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(487, 266)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(326, 31)
        Me.txtJumlah.TabIndex = 34
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(487, 173)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(326, 31)
        Me.txtMerek.TabIndex = 33
        '
        'cbJenis
        '
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(487, 40)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(326, 33)
        Me.cbJenis.TabIndex = 32
        '
        'txtTipe
        '
        Me.txtTipe.Location = New System.Drawing.Point(487, 105)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.Size = New System.Drawing.Size(326, 31)
        Me.txtTipe.TabIndex = 31
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(300, 272)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(67, 25)
        Me.lblJumlah.TabIndex = 30
        Me.lblJumlah.Text = "Jumlah"
        '
        'lblTanggalMasuk
        '
        Me.lblTanggalMasuk.AutoSize = True
        Me.lblTanggalMasuk.Location = New System.Drawing.Point(303, 541)
        Me.lblTanggalMasuk.Name = "lblTanggalMasuk"
        Me.lblTanggalMasuk.Size = New System.Drawing.Size(130, 25)
        Me.lblTanggalMasuk.TabIndex = 29
        Me.lblTanggalMasuk.Text = "Tanggal Masuk"
        '
        'lblTahun
        '
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Location = New System.Drawing.Point(300, 448)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Size = New System.Drawing.Size(152, 25)
        Me.lblTahun.TabIndex = 27
        Me.lblTahun.Text = "Tahun Pembuatan"
        '
        'lblHargaSewa
        '
        Me.lblHargaSewa.AutoSize = True
        Me.lblHargaSewa.Location = New System.Drawing.Point(300, 363)
        Me.lblHargaSewa.Name = "lblHargaSewa"
        Me.lblHargaSewa.Size = New System.Drawing.Size(106, 25)
        Me.lblHargaSewa.TabIndex = 26
        Me.lblHargaSewa.Text = "Harga Sewa"
        '
        'lblMerek
        '
        Me.lblMerek.AutoSize = True
        Me.lblMerek.Location = New System.Drawing.Point(300, 179)
        Me.lblMerek.Name = "lblMerek"
        Me.lblMerek.Size = New System.Drawing.Size(61, 25)
        Me.lblMerek.TabIndex = 25
        Me.lblMerek.Text = "Merek"
        '
        'lblTipe
        '
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Location = New System.Drawing.Point(300, 111)
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.Size = New System.Drawing.Size(45, 25)
        Me.lblTipe.TabIndex = 24
        Me.lblTipe.Text = "Tipe"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(300, 40)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(49, 25)
        Me.lblJenis.TabIndex = 23
        Me.lblJenis.Text = "Jenis"
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(487, 448)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(326, 31)
        Me.txtTahun.TabIndex = 43
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 629)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Tersedia", "Dipinjam"})
        Me.cbStatus.Location = New System.Drawing.Point(487, 629)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(326, 33)
        Me.cbStatus.TabIndex = 45
        '
        'EditMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 820)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.btnUpdate)
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
        Me.Name = "EditMobil"
        Me.Text = "EditMobil"
        CType(Me.PictureBoxMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
