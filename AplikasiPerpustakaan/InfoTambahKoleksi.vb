Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class InfoTambahKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Perpustakaan.koleksi.GSFoto) Then
            PictureBoxFoto.Load(Perpustakaan.koleksi.GSFoto)
            PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNama.Text = Perpustakaan.koleksi.GSNama
        LblDeskripsi.Text = Perpustakaan.koleksi.GSDeskripsi
        LblPenerbit.Text = Perpustakaan.koleksi.GSPenerbit
        LblThTerbit.Text = Perpustakaan.koleksi.GSTahunTerbit
        LblLokasiRak.Text = Perpustakaan.koleksi.GSLokasiRak
        LblTglMsk.Text = Perpustakaan.koleksi.GSTanggal
        LblStock.Text = Perpustakaan.koleksi.GSStock
        LblJenis.Text = Perpustakaan.koleksi.GSJenis
        LblBahasa.Text = Perpustakaan.koleksi.GSBahasa


        For Each info_tambah In Perpustakaan.koleksi.GSKategori
            ListBoxKategori.Items.Add(info_tambah)
        Next

        Perpustakaan.koleksi.GSKategori.Clear()

    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Dim add_item = Perpustakaan.koleksi.GSNama
        Perpustakaan.ListBoxKoleksi.Items.Add(add_item)
        Me.Close()
    End Sub
End Class