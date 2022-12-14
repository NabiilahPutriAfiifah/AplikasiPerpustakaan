<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnUpdateKoleksi = New System.Windows.Forms.Button()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.GroupBoxKategori = New System.Windows.Forms.GroupBox()
        Me.RadioButtonBIng = New System.Windows.Forms.RadioButton()
        Me.GroupBoxBahasa = New System.Windows.Forms.GroupBox()
        Me.RadioButtonBIndo = New System.Windows.Forms.RadioButton()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.TxtBoxStock = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePickerTglMsk = New System.Windows.Forms.DateTimePicker()
        Me.TxtBoxLocRak = New System.Windows.Forms.TextBox()
        Me.TxtBoxThTerbit = New System.Windows.Forms.TextBox()
        Me.TxtBoxPenerbit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxJenis = New System.Windows.Forms.ComboBox()
        Me.TxtBoxNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxKategori.SuspendLayout()
        Me.GroupBoxBahasa.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnUpdateKoleksi
        '
        Me.BtnUpdateKoleksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdateKoleksi.Location = New System.Drawing.Point(336, 799)
        Me.BtnUpdateKoleksi.Name = "BtnUpdateKoleksi"
        Me.BtnUpdateKoleksi.Size = New System.Drawing.Size(145, 34)
        Me.BtnUpdateKoleksi.TabIndex = 48
        Me.BtnUpdateKoleksi.Text = "Update Koleksi"
        Me.BtnUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(6, 135)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(96, 29)
        Me.CheckBoxBudaya.TabIndex = 3
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(6, 100)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(114, 29)
        Me.CheckBoxTeknologi.TabIndex = 2
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(6, 65)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(84, 29)
        Me.CheckBoxSosial.TabIndex = 1
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(6, 30)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(79, 29)
        Me.CheckBoxSains.TabIndex = 0
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'GroupBoxKategori
        '
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxSains)
        Me.GroupBoxKategori.Location = New System.Drawing.Point(444, 602)
        Me.GroupBoxKategori.Name = "GroupBoxKategori"
        Me.GroupBoxKategori.Size = New System.Drawing.Size(300, 177)
        Me.GroupBoxKategori.TabIndex = 47
        Me.GroupBoxKategori.TabStop = False
        Me.GroupBoxKategori.Text = "Kategori"
        '
        'RadioButtonBIng
        '
        Me.RadioButtonBIng.AutoSize = True
        Me.RadioButtonBIng.Location = New System.Drawing.Point(6, 65)
        Me.RadioButtonBIng.Name = "RadioButtonBIng"
        Me.RadioButtonBIng.Size = New System.Drawing.Size(152, 29)
        Me.RadioButtonBIng.TabIndex = 22
        Me.RadioButtonBIng.TabStop = True
        Me.RadioButtonBIng.Text = "Bahasa Inggris"
        Me.RadioButtonBIng.UseVisualStyleBackColor = True
        '
        'GroupBoxBahasa
        '
        Me.GroupBoxBahasa.Controls.Add(Me.RadioButtonBIng)
        Me.GroupBoxBahasa.Controls.Add(Me.RadioButtonBIndo)
        Me.GroupBoxBahasa.Location = New System.Drawing.Point(438, 488)
        Me.GroupBoxBahasa.Name = "GroupBoxBahasa"
        Me.GroupBoxBahasa.Size = New System.Drawing.Size(300, 108)
        Me.GroupBoxBahasa.TabIndex = 46
        Me.GroupBoxBahasa.TabStop = False
        Me.GroupBoxBahasa.Text = "Bahasa"
        '
        'RadioButtonBIndo
        '
        Me.RadioButtonBIndo.AutoSize = True
        Me.RadioButtonBIndo.Location = New System.Drawing.Point(6, 30)
        Me.RadioButtonBIndo.Name = "RadioButtonBIndo"
        Me.RadioButtonBIndo.Size = New System.Drawing.Size(174, 29)
        Me.RadioButtonBIndo.TabIndex = 21
        Me.RadioButtonBIndo.TabStop = True
        Me.RadioButtonBIndo.Text = "Bahasa Indonesia"
        Me.RadioButtonBIndo.UseVisualStyleBackColor = True
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(47, 51)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(145, 156)
        Me.PicFoto.TabIndex = 49
        Me.PicFoto.TabStop = False
        '
        'TxtBoxStock
        '
        Me.TxtBoxStock.Location = New System.Drawing.Point(438, 451)
        Me.TxtBoxStock.Name = "TxtBoxStock"
        Me.TxtBoxStock.Size = New System.Drawing.Size(300, 31)
        Me.TxtBoxStock.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(215, 602)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 25)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Kategori"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(215, 496)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 25)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Bahasa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(215, 458)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 25)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Stock"
        '
        'DateTimePickerTglMsk
        '
        Me.DateTimePickerTglMsk.Location = New System.Drawing.Point(438, 414)
        Me.DateTimePickerTglMsk.Name = "DateTimePickerTglMsk"
        Me.DateTimePickerTglMsk.Size = New System.Drawing.Size(300, 31)
        Me.DateTimePickerTglMsk.TabIndex = 41
        '
        'TxtBoxLocRak
        '
        Me.TxtBoxLocRak.Location = New System.Drawing.Point(438, 377)
        Me.TxtBoxLocRak.Name = "TxtBoxLocRak"
        Me.TxtBoxLocRak.Size = New System.Drawing.Size(300, 31)
        Me.TxtBoxLocRak.TabIndex = 40
        '
        'TxtBoxThTerbit
        '
        Me.TxtBoxThTerbit.Location = New System.Drawing.Point(438, 339)
        Me.TxtBoxThTerbit.Name = "TxtBoxThTerbit"
        Me.TxtBoxThTerbit.Size = New System.Drawing.Size(300, 31)
        Me.TxtBoxThTerbit.TabIndex = 39
        '
        'TxtBoxPenerbit
        '
        Me.TxtBoxPenerbit.Location = New System.Drawing.Point(438, 298)
        Me.TxtBoxPenerbit.Name = "TxtBoxPenerbit"
        Me.TxtBoxPenerbit.Size = New System.Drawing.Size(300, 31)
        Me.TxtBoxPenerbit.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 25)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(215, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 25)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(215, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 25)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Penerbit"
        '
        'RichTextBoxDeskripsi
        '
        Me.RichTextBoxDeskripsi.Location = New System.Drawing.Point(438, 146)
        Me.RichTextBoxDeskripsi.Name = "RichTextBoxDeskripsi"
        Me.RichTextBoxDeskripsi.Size = New System.Drawing.Size(300, 144)
        Me.RichTextBoxDeskripsi.TabIndex = 33
        Me.RichTextBoxDeskripsi.Text = ""
        '
        'ComboBoxJenis
        '
        Me.ComboBoxJenis.FormattingEnabled = True
        Me.ComboBoxJenis.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi", "Penelitian"})
        Me.ComboBoxJenis.Location = New System.Drawing.Point(438, 101)
        Me.ComboBoxJenis.Name = "ComboBoxJenis"
        Me.ComboBoxJenis.Size = New System.Drawing.Size(300, 33)
        Me.ComboBoxJenis.TabIndex = 32
        '
        'TxtBoxNama
        '
        Me.TxtBoxNama.Location = New System.Drawing.Point(438, 64)
        Me.TxtBoxNama.Name = "TxtBoxNama"
        Me.TxtBoxNama.Size = New System.Drawing.Size(300, 31)
        Me.TxtBoxNama.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nama Koleksi"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahGambar.Location = New System.Drawing.Point(47, 213)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(145, 34)
        Me.BtnTambahGambar.TabIndex = 27
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(47, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Update Koleksi"
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 846)
        Me.Controls.Add(Me.BtnUpdateKoleksi)
        Me.Controls.Add(Me.GroupBoxKategori)
        Me.Controls.Add(Me.GroupBoxBahasa)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.TxtBoxStock)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePickerTglMsk)
        Me.Controls.Add(Me.TxtBoxLocRak)
        Me.Controls.Add(Me.TxtBoxThTerbit)
        Me.Controls.Add(Me.TxtBoxPenerbit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBoxDeskripsi)
        Me.Controls.Add(Me.ComboBoxJenis)
        Me.Controls.Add(Me.TxtBoxNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        Me.GroupBoxKategori.ResumeLayout(False)
        Me.GroupBoxKategori.PerformLayout()
        Me.GroupBoxBahasa.ResumeLayout(False)
        Me.GroupBoxBahasa.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnUpdateKoleksi As Button
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents GroupBoxKategori As GroupBox
    Friend WithEvents RadioButtonBIng As RadioButton
    Friend WithEvents GroupBoxBahasa As GroupBox
    Friend WithEvents RadioButtonBIndo As RadioButton
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents TxtBoxStock As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePickerTglMsk As DateTimePicker
    Friend WithEvents TxtBoxLocRak As TextBox
    Friend WithEvents TxtBoxThTerbit As TextBox
    Friend WithEvents TxtBoxPenerbit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBoxDeskripsi As RichTextBox
    Friend WithEvents ComboBoxJenis As ComboBox
    Friend WithEvents TxtBoxNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents Label1 As Label
End Class
