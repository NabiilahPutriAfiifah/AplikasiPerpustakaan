Imports Google.Protobuf.WellKnownTypes

Public Class UpdateKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call. 
        PicFoto.Load(Perpustakaan.koleksi.GSFoto)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerTglMsk.Format = DateTimePickerFormat.Custom
        DateTimePickerTglMsk.CustomFormat = "yyyy/MM/dd"
        TxtBoxNama.Text = Perpustakaan.koleksi.GSNama
        ComboBoxJenis.SelectedItem() = Perpustakaan.koleksi.GSJenis
        RichTextBoxDeskripsi.Text = Perpustakaan.koleksi.GSDeskripsi
        TxtBoxPenerbit.Text = Perpustakaan.koleksi.GSPenerbit
        TxtBoxThTerbit.Text = Perpustakaan.koleksi.GSTahunTerbit
        TxtBoxLocRak.Text = Perpustakaan.koleksi.GSLokasiRak
        DateTimePickerTglMsk.Value = Perpustakaan.koleksi.GSTanggal
        TxtBoxStock.Text = Perpustakaan.koleksi.GSStock

        If String.Compare(Perpustakaan.koleksi.GSBahasa, "Indonesia") = 0 Then
            RadioButtonBIndo.Checked = True
        ElseIf String.Compare(Perpustakaan.koleksi.GSBahasa, "Inggris") = 0 Then
            RadioButtonBIng.Checked = True
        End If

        For Each kategoriItem In Perpustakaan.koleksi.getKategoriItem()
            If String.Compare(kategoriItem, "Sains") = 0 Then
                CheckBoxSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Social") = 0 Then
                CheckBoxSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                CheckBoxTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                CheckBoxBudaya.Checked = True
            End If
        Next

        'If Perpustakaan.koleksi.GSBahasa() = "Bahasa Indonesia" Then
        '    RadioButtonBIndo.Checked = True
        'Else
        '    RadioButtonBIng.Checked = True
        'End If


        'For Each info_tambah In Perpustakaan.koleksi.GSKategori
        '    If info_tambah = "Sains" Then
        '        CheckBoxSains.Checked = True
        '    ElseIf info_tambah = "Sosial" Then
        '        CheckBoxSosial.Checked = True
        '    ElseIf info_tambah = "Teknologi" Then
        '        CheckBoxTeknologi.Checked = True
        '    ElseIf info_tambah = "Budaya" Then
        '        CheckBoxBudaya.Checked = True
        '    End If
        'Next

        Perpustakaan.koleksi.resetKategori()
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Gambar Koleksi"
        OpenFileDialog1.Filter = "All Format|*.*|BMP|*.bmp|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFileDialog1.ShowDialog()

        Dim PicKoleksiDir As String = OpenFileDialog1.FileName

        PicFoto.Load(PicKoleksiDir)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        'Perpustakaan.koleksi.GSFoto = OpenFileDialog1.FileName

        Perpustakaan.koleksi.GSFoto = PicKoleksiDir.ToString()
        Perpustakaan.koleksi.GSFoto = Perpustakaan.koleksi.GSFoto.Replace("\", "/")
    End Sub

    Private Sub BtnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BtnUpdateKoleksi.Click
        Perpustakaan.koleksi.GSNama = TxtBoxNama.Text.ToString()
        Perpustakaan.koleksi.GSJenis = ComboBoxJenis.SelectedItem().ToString()
        Perpustakaan.koleksi.GSDeskripsi = RichTextBoxDeskripsi.Text.ToString()
        Perpustakaan.koleksi.GSPenerbit = TxtBoxPenerbit.Text.ToString()
        Perpustakaan.koleksi.GSTahunTerbit = Integer.Parse(TxtBoxThTerbit.Text)

        Perpustakaan.koleksi.GSLokasiRak = TxtBoxLocRak.Text.ToString()
        Perpustakaan.koleksi.GSTanggal = DateTimePickerTglMsk.Value.ToString("yyyy/MM/dd")
        Perpustakaan.koleksi.GSStock = Integer.Parse(TxtBoxStock.Text)

        If RadioButtonBIndo.Checked Then
            Perpustakaan.koleksi.GSBahasa = "Indonesia"
        ElseIf RadioButtonBIng.Checked Then
            Perpustakaan.koleksi.GSBahasa = "Inggris"
        End If

        If CheckBoxSains.Checked() Then
            Perpustakaan.koleksi.AddKategori("Sains")
        End If

        If CheckBoxSosial.Checked() Then
            Perpustakaan.koleksi.AddKategori("Sosial")
        End If

        If CheckBoxTeknologi.Checked() Then
            Perpustakaan.koleksi.AddKategori("Teknologi")
        End If

        If CheckBoxBudaya.Checked() Then
            Perpustakaan.koleksi.AddKategori("Budaya")
        End If



        Perpustakaan.koleksi.AddKoleksi(TxtBoxNama.Text.ToString())

        Dim convertedKoleksi = Perpustakaan.koleksi.convertKoleksiToString(Perpustakaan.koleksi.getKategoriItem)
        Perpustakaan.koleksi.UpdateDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi,
                                                           Perpustakaan.koleksi.GSFoto,
                                                           Perpustakaan.koleksi.GSNama,
                                                           Perpustakaan.koleksi.GSJenis,
                                                           Perpustakaan.koleksi.GSPenerbit,
                                                           Perpustakaan.koleksi.GSDeskripsi,
                                                           Perpustakaan.koleksi.GSTahunTerbit,
                                                           Perpustakaan.koleksi.GSLokasiRak,
                                                           Perpustakaan.koleksi.GSTanggal,
                                                           Perpustakaan.koleksi.GSStock,
                                                           Perpustakaan.koleksi.GSBahasa,
                                                           convertedKoleksi
                                                           )
        Dim infotambah = New InfoTambahKoleksi()
        infotambah.Show()

        Me.Close()
    End Sub
End Class