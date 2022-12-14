Public Class HapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LabelBuku.Text = Perpustakaan.koleksi.GSDelete
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'Dim indexItem = 0
        'Perpustakaan.ListBoxKoleksi.Items.RemoveAt(Perpustakaan.ListBoxKoleksi.SelectedIndex)
        'For Each item In Perpustakaan.koleksi.getKoleksiDataTable()
        '    If item(0) Is Perpustakaan.ListBoxKoleksi.SelectedItem() Then
        '        indexItem = Perpustakaan.koleksi.getKoleksiDataTable().IndexOf(item)

        '    End If
        'Next

        'Perpustakaan.koleksi.removeKoleksiDataTable(indexItem)
        Perpustakaan.koleksi.DeleteDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class