<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditMobil
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.PictureBoxMobil = New System.Windows.Forms.PictureBox()
        Me.rdBtnTdkTersedia = New System.Windows.Forms.RadioButton()
        Me.rdBtnTersedia = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.lblTanggalMasuk = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTahun = New System.Windows.Forms.Label()
        Me.lblHargaSewa = New System.Windows.Forms.Label()
        Me.lblMerek = New System.Windows.Forms.Label()
        Me.lblTipe = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.GroupBoxStatus = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBoxMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(861, 764)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(112, 34)
        Me.btnEdit.TabIndex = 42
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(119, 274)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(170, 34)
        Me.BtnTambahGambar.TabIndex = 41
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'PictureBoxMobil
        '
        Me.PictureBoxMobil.Location = New System.Drawing.Point(75, 22)
        Me.PictureBoxMobil.Name = "PictureBoxMobil"
        Me.PictureBoxMobil.Size = New System.Drawing.Size(260, 228)
        Me.PictureBoxMobil.TabIndex = 40
        Me.PictureBoxMobil.TabStop = False
        '
        'rdBtnTdkTersedia
        '
        Me.rdBtnTdkTersedia.AutoSize = True
        Me.rdBtnTdkTersedia.Location = New System.Drawing.Point(561, 722)
        Me.rdBtnTdkTersedia.Name = "rdBtnTdkTersedia"
        Me.rdBtnTdkTersedia.Size = New System.Drawing.Size(146, 29)
        Me.rdBtnTdkTersedia.TabIndex = 38
        Me.rdBtnTdkTersedia.TabStop = True
        Me.rdBtnTdkTersedia.Text = "Tidak tersedia"
        Me.rdBtnTdkTersedia.UseVisualStyleBackColor = True
        '
        'rdBtnTersedia
        '
        Me.rdBtnTersedia.AutoSize = True
        Me.rdBtnTersedia.Location = New System.Drawing.Point(561, 658)
        Me.rdBtnTersedia.Name = "rdBtnTersedia"
        Me.rdBtnTersedia.Size = New System.Drawing.Size(100, 29)
        Me.rdBtnTersedia.TabIndex = 37
        Me.rdBtnTersedia.TabStop = True
        Me.rdBtnTersedia.Text = "Tersedia"
        Me.rdBtnTersedia.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(550, 545)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(326, 31)
        Me.DateTimePicker1.TabIndex = 36
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(550, 452)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(326, 31)
        Me.TextBox5.TabIndex = 35
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(550, 367)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(326, 31)
        Me.TextBox4.TabIndex = 34
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(550, 276)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(326, 31)
        Me.TextBox3.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(550, 183)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(326, 31)
        Me.TextBox2.TabIndex = 32
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(550, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(326, 33)
        Me.ComboBox1.TabIndex = 31
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(550, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 31)
        Me.TextBox1.TabIndex = 30
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(363, 282)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(67, 25)
        Me.lblJumlah.TabIndex = 29
        Me.lblJumlah.Text = "Jumlah"
        '
        'lblTanggalMasuk
        '
        Me.lblTanggalMasuk.AutoSize = True
        Me.lblTanggalMasuk.Location = New System.Drawing.Point(366, 551)
        Me.lblTanggalMasuk.Name = "lblTanggalMasuk"
        Me.lblTanggalMasuk.Size = New System.Drawing.Size(130, 25)
        Me.lblTanggalMasuk.TabIndex = 28
        Me.lblTanggalMasuk.Text = "Tanggal Masuk"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(366, 666)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(65, 25)
        Me.lblStatus.TabIndex = 27
        Me.lblStatus.Text = "Status "
        '
        'lblTahun
        '
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Location = New System.Drawing.Point(363, 458)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Size = New System.Drawing.Size(152, 25)
        Me.lblTahun.TabIndex = 26
        Me.lblTahun.Text = "Tahun Pembuatan"
        '
        'lblHargaSewa
        '
        Me.lblHargaSewa.AutoSize = True
        Me.lblHargaSewa.Location = New System.Drawing.Point(363, 373)
        Me.lblHargaSewa.Name = "lblHargaSewa"
        Me.lblHargaSewa.Size = New System.Drawing.Size(106, 25)
        Me.lblHargaSewa.TabIndex = 25
        Me.lblHargaSewa.Text = "Harga Sewa"
        '
        'lblMerek
        '
        Me.lblMerek.AutoSize = True
        Me.lblMerek.Location = New System.Drawing.Point(363, 189)
        Me.lblMerek.Name = "lblMerek"
        Me.lblMerek.Size = New System.Drawing.Size(61, 25)
        Me.lblMerek.TabIndex = 24
        Me.lblMerek.Text = "Merek"
        '
        'lblTipe
        '
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Location = New System.Drawing.Point(363, 121)
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.Size = New System.Drawing.Size(45, 25)
        Me.lblTipe.TabIndex = 23
        Me.lblTipe.Text = "Tipe"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(363, 50)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(49, 25)
        Me.lblJenis.TabIndex = 22
        Me.lblJenis.Text = "Jenis"
        '
        'GroupBoxStatus
        '
        Me.GroupBoxStatus.Location = New System.Drawing.Point(524, 618)
        Me.GroupBoxStatus.Name = "GroupBoxStatus"
        Me.GroupBoxStatus.Size = New System.Drawing.Size(300, 161)
        Me.GroupBoxStatus.TabIndex = 39
        Me.GroupBoxStatus.TabStop = False
        Me.GroupBoxStatus.Text = "Status"
        '
        'EditMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 820)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PictureBoxMobil)
        Me.Controls.Add(Me.rdBtnTdkTersedia)
        Me.Controls.Add(Me.rdBtnTersedia)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.lblTanggalMasuk)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTahun)
        Me.Controls.Add(Me.lblHargaSewa)
        Me.Controls.Add(Me.lblMerek)
        Me.Controls.Add(Me.lblTipe)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.GroupBoxStatus)
        Me.Name = "EditMobil"
        Me.Text = "EditMobil"
        CType(Me.PictureBoxMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents PictureBoxMobil As PictureBox
    Friend WithEvents rdBtnTdkTersedia As RadioButton
    Friend WithEvents rdBtnTersedia As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTanggalMasuk As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTahun As Label
    Friend WithEvents lblHargaSewa As Label
    Friend WithEvents lblMerek As Label
    Friend WithEvents lblTipe As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents GroupBoxStatus As GroupBox
End Class
