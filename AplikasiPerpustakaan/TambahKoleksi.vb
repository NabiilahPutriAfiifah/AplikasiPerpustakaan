Imports System.IO

Public Class TambahKoleksi
    'Dim nama
    'Dim foto_buku As String
    'Dim deskripsi
    'Dim penerbit
    'Dim tahun_terbit
    'Dim lokasi_rak
    'Dim tanggal_masuk
    'Dim stock
    'Dim bahasa
    'Dim kategori As New List(Of String)
    'Dim jenis_koleksi
    ''Dim jenis_koleksi As New List(Of String) From {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi", "Penelitian"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimePickerTglMsk.Format = DateTimePickerFormat.Custom
        DateTimePickerTglMsk.CustomFormat = "yyyy/MM/dd"

    End Sub

    Private Sub TxtBoxNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub

    Private Sub TxtBoxPenerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxPenerbit.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub

    Private Sub TxtBoxThTerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxThTerbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TxtBoxStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub


    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "All Format|*.*|BMP|*.bmp|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFileDialog1.ShowDialog()

        Dim PicKoleksiDir As String = OpenFileDialog1.FileName

        PicFoto.Load(PicKoleksiDir)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        'Perpustakaan.koleksi.GSFoto = OpenFileDialog1.FileName

        Perpustakaan.koleksi.GSFoto = PicKoleksiDir.ToString()
        Perpustakaan.koleksi.GSFoto = Perpustakaan.koleksi.GSFoto.Replace("\", "/")
    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        Perpustakaan.koleksi.GSNama = TxtBoxNama.Text
        Perpustakaan.koleksi.GSDeskripsi = RichTextBoxDeskripsi.Text
        Perpustakaan.koleksi.GSPenerbit = TxtBoxPenerbit.Text
        Perpustakaan.koleksi.GSTahunTerbit = TxtBoxThTerbit.Text
        Perpustakaan.koleksi.GSLokasiRak = TxtBoxLocRak.Text
        Perpustakaan.koleksi.GSTanggal = DateTimePickerTglMsk.Value.ToShortDateString
        Perpustakaan.koleksi.GSStock = TxtBoxStock.Text
        Perpustakaan.koleksi.GSJenis = ComboBoxJenis.Text


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

        Dim convertedKoleksi = Perpustakaan.koleksi.convertKoleksiToString(Perpustakaan.koleksi.GSKategori)
        Perpustakaan.koleksi.AddDataKoleksiDatabase(Perpustakaan.koleksi.GSFoto,
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
        Dim add_item = Perpustakaan.koleksi.GSNama
        Perpustakaan.ListBoxKoleksi.Items.Add(add_item)

        Dim infoTambah = New InfoTambahKoleksi()
        infoTambah.Show()

        Me.Close()
    End Sub

    Dim koleksi As koleksi
    Private Sub RadioButtonBIndo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBIndo.CheckedChanged
        Perpustakaan.koleksi.GSBahasa = "Bahasa Indonesia"
    End Sub

    Private Sub RadioButtonBIng_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBIng.CheckedChanged
        Perpustakaan.koleksi.GSBahasa = "Bahasa Inggris"
    End Sub
End Class