﻿Public Class Feoq
    Dim eoq As Double
    Dim r, s, c As Double
    Dim data As New DataTable
    Sub hitungEoq()
        If Csat_waktu.Text = "Hari" Then
            r = Tkebutuhan.Value * 365
        ElseIf Csat_waktu.Text = "Minggu" Then
            r = Tkebutuhan.Value * 52
        ElseIf Csat_waktu.Text = "Bulan" Then
            r = Tkebutuhan.Value * 12
        Else
            r = Tkebutuhan.Value * 1
        End If
        c = Tpembelian.Value
        s = Tpajak.Value + Ttransportasi.Value
        eoq = Math.Ceiling(Math.Sqrt((2 * (r * s)) / (Val(Tpenyimpanan.Text) * c)))
        Lhasil.Text = "Diperkirakan pemesanan stok paling" & vbCrLf & " ekonomis adalah sebanyak " & eoq.ToString & " " & vbCrLf & "untuk " & Csat_waktu.Text & " selanjutnya."
    End Sub
    Sub resetEoq()
        Call fetchComboboxData("select * from daftar_obat", Cobat, "Nama_Obat", "Id_Obat")
        Call fetchComboboxData("select * from daftar_satuan where Id_Sat between 17 and 20", Csat_waktu, "Nama_Satuan", "Id_Sat")
        Tkebutuhan.ResetText()
        Tpajak.ResetText()
        Ttransportasi.ResetText()
        Tpenyimpanan.Clear()
        Tpembelian.ResetText()
        eoq = 0
        Csat_waktu.SelectedIndex = -1
        Lhasil.Text = "Tidak Ada"
        Cobat.SelectedIndex = -1
    End Sub

    Private Sub Feoq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call resetEoq()
    End Sub

    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        Call hitungEoq()
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Fmenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RBmanual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBmanual.CheckedChanged
        If RBmanual.Checked = False Then
            GBmanual.Enabled = False
            GBotomatis.Enabled = True
        Else
            GBmanual.Enabled = True
            GBotomatis.Enabled = False
        End If
    End Sub

    Private Sub RBotomatis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBotomatis.CheckedChanged
        If RBotomatis.Checked = True Then
            GBmanual.Enabled = False
            GBotomatis.Enabled = True
        Else
            GBmanual.Enabled = True
            GBotomatis.Enabled = False
        End If
    End Sub

    Private Sub Tawal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tawal.ValueChanged, Takhir.ValueChanged, Cobat.SelectedValueChanged
        If Cobat.SelectedIndex <> -1 Then
            data = fetchData("select a.tgl_transaksi,b.id_obat,sum(b.jumlah) as jumlah,a.id_transaksi from tbl_transaksi a join tbl_detail_transaksi b on a.id_transaksi = b.id_transaksi group by b.id_obat where id_obat = " & Cobat.SelectedValue & " AND DATE(b.tgl_transaksi) between '" & Tawal.Value.ToString("yyyy-MM-dd") & "' and '" & Takhir.Value.ToString("yyyy-MM-dd") & "'")
            If data.Rows.Count = 0 Then
                Lket.Text = "Silahkan pilih " & vbCrLf & "tanggal lain..."
            Else
                If data.Rows(0).Item("jumlah") = 0 Then
                    Lket.Text = "Silahkan pilih " & vbCrLf & "tanggal lain..."
                Else
                    Lket.Text = "Lama waktu " & Tawal.Value.Subtract(Takhir.Value).Days.ToString & " hari dengan " & vbCrLf & " jumlah kebutuhan barang " & data.Rows(0).Item("jumlah").ToString
                End If
            End If
        End If
    End Sub
End Class