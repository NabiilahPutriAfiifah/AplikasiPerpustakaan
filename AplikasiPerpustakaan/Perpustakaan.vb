Public Class Perpustakaan
    Public Shared koleksi As koleksi
    'Public Shared selectedKoleksi As String
    Public Sub updateDataTableArrayList()
        DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In koleksi.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(3),
                                         rowKoleksi(2),
                                         rowKoleksi(4),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9),
                                         rowKoleksi(10)}
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        koleksi = New koleksi()
        'updateDataTableArrayList()

        ReloadDataTableDatabase()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim tambah_koleksi = New TambahKoleksi()
        tambah_koleksi.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If (ListBoxKoleksi.SelectedIndex = -1) Then
            MessageBox.Show("Pilih koleksi yang ingin dihapus")
        Else
            koleksi.GSDelete = ListBoxKoleksi.SelectedItem()
            Dim hapus_koleksi = New HapusKoleksi()
            hapus_koleksi.Show()
        End If
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim tambah_koleksi = New TambahKoleksi()
        tambah_koleksi.Show()
    End Sub



    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'ListBoxKoleksi.Items.Clear()

        'For Each koll In koleksi.getKoleksiItem
        '    ListBoxKoleksi.Items.Add(koll)
        'Next
        'updateDataTableArrayList()

        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = koleksi.GetDataKoleksiDatabase()
    End Sub

    Public Sub procHapus(item As String)
        koleksi.removeKoleksiDataTable(item)
        ListBoxKoleksi.Items.Remove(item)
    End Sub

    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim selectedKoleksi = koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        koleksi.GSFoto = selectedKoleksi(2)
        koleksi.GSNama = selectedKoleksi(1)
        koleksi.GSJenis = selectedKoleksi(5)
        koleksi.GSDeskripsi = selectedKoleksi(3)
        koleksi.GSPenerbit = selectedKoleksi(4)
        koleksi.GSTahunTerbit = selectedKoleksi(6)
        koleksi.GSLokasiRak = selectedKoleksi(7)
        koleksi.GSTanggal = selectedKoleksi(8)
        koleksi.GSStock = selectedKoleksi(9)
        koleksi.GSBahasa = selectedKoleksi(10)

        Dim data_kategori As List(Of String) = koleksi.convertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            koleksi.AddKategori(info_kategori)
        Next

        Dim infoTambah = New InfoTambahKoleksi()
        infoTambah.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)
        koleksi.GSFoto = selectedKoleksi(2)

        koleksi.GSNama = selectedKoleksi(1)
        koleksi.GSJenis = selectedKoleksi(5)
        koleksi.GSDeskripsi = selectedKoleksi(3)
        koleksi.GSPenerbit = selectedKoleksi(4)
        koleksi.GSTahunTerbit = selectedKoleksi(6)
        koleksi.GSLokasiRak = selectedKoleksi(7)
        koleksi.GSTanggal = selectedKoleksi(8)
        koleksi.GSStock = selectedKoleksi(9)
        koleksi.GSBahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = koleksi.convertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            koleksi.AddKategori(info_kategori)
        Next

        Dim formUpdate = New UpdateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formHapus = New HapusKoleksi()
        formHapus.Show()
    End Sub
End Class
