﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feoq
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBotomatis = New System.Windows.Forms.RadioButton()
        Me.RBmanual = New System.Windows.Forms.RadioButton()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.GBotomatis = New System.Windows.Forms.GroupBox()
        Me.Takhir = New System.Windows.Forms.DateTimePicker()
        Me.Tawal = New System.Windows.Forms.DateTimePicker()
        Me.Cobat = New System.Windows.Forms.ComboBox()
        Me.Lket = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GBmanual = New System.Windows.Forms.GroupBox()
        Me.Csat_waktu = New System.Windows.Forms.ComboBox()
        Me.Tkebutuhan = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tpenyimpanan = New System.Windows.Forms.TextBox()
        Me.Tpembelian = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lhasil = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ttransportasi = New System.Windows.Forms.NumericUpDown()
        Me.Tpajak = New System.Windows.Forms.NumericUpDown()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GBotomatis.SuspendLayout()
        Me.GBmanual.SuspendLayout()
        CType(Me.Tkebutuhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ttransportasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tpajak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.RBotomatis)
        Me.GroupBox1.Controls.Add(Me.RBmanual)
        Me.GroupBox1.Controls.Add(Me.Bexit)
        Me.GroupBox1.Controls.Add(Me.GBotomatis)
        Me.GroupBox1.Controls.Add(Me.GBmanual)
        Me.GroupBox1.Controls.Add(Me.Tpenyimpanan)
        Me.GroupBox1.Controls.Add(Me.Tpembelian)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Lhasil)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Ttransportasi)
        Me.GroupBox1.Controls.Add(Me.Tpajak)
        Me.GroupBox1.Controls.Add(Me.Bsimpan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 420)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kalkulasi EOQ"
        '
        'RBotomatis
        '
        Me.RBotomatis.AutoSize = True
        Me.RBotomatis.Location = New System.Drawing.Point(15, 87)
        Me.RBotomatis.Name = "RBotomatis"
        Me.RBotomatis.Size = New System.Drawing.Size(14, 13)
        Me.RBotomatis.TabIndex = 39
        Me.RBotomatis.UseVisualStyleBackColor = True
        '
        'RBmanual
        '
        Me.RBmanual.AutoSize = True
        Me.RBmanual.Checked = True
        Me.RBmanual.Location = New System.Drawing.Point(15, 43)
        Me.RBmanual.Name = "RBmanual"
        Me.RBmanual.Size = New System.Drawing.Size(14, 13)
        Me.RBmanual.TabIndex = 38
        Me.RBmanual.TabStop = True
        Me.RBmanual.UseVisualStyleBackColor = True
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(343, 391)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(85, 23)
        Me.Bexit.TabIndex = 37
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'GBotomatis
        '
        Me.GBotomatis.Controls.Add(Me.Takhir)
        Me.GBotomatis.Controls.Add(Me.Tawal)
        Me.GBotomatis.Controls.Add(Me.Cobat)
        Me.GBotomatis.Controls.Add(Me.Lket)
        Me.GBotomatis.Controls.Add(Me.Label10)
        Me.GBotomatis.Controls.Add(Me.Label9)
        Me.GBotomatis.Controls.Add(Me.Label8)
        Me.GBotomatis.Location = New System.Drawing.Point(44, 75)
        Me.GBotomatis.Name = "GBotomatis"
        Me.GBotomatis.Size = New System.Drawing.Size(378, 103)
        Me.GBotomatis.TabIndex = 29
        Me.GBotomatis.TabStop = False
        Me.GBotomatis.Text = "Data Dari Transaksi"
        '
        'Takhir
        '
        Me.Takhir.CustomFormat = "dd-MM-yyyy"
        Me.Takhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Takhir.Location = New System.Drawing.Point(103, 77)
        Me.Takhir.Name = "Takhir"
        Me.Takhir.Size = New System.Drawing.Size(154, 20)
        Me.Takhir.TabIndex = 6
        '
        'Tawal
        '
        Me.Tawal.CustomFormat = "dd-MM-yyyy"
        Me.Tawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tawal.Location = New System.Drawing.Point(103, 52)
        Me.Tawal.Name = "Tawal"
        Me.Tawal.Size = New System.Drawing.Size(154, 20)
        Me.Tawal.TabIndex = 5
        '
        'Cobat
        '
        Me.Cobat.FormattingEnabled = True
        Me.Cobat.Location = New System.Drawing.Point(103, 25)
        Me.Cobat.Name = "Cobat"
        Me.Cobat.Size = New System.Drawing.Size(154, 21)
        Me.Cobat.TabIndex = 4
        '
        'Lket
        '
        Me.Lket.AutoSize = True
        Me.Lket.Location = New System.Drawing.Point(263, 25)
        Me.Lket.Name = "Lket"
        Me.Lket.Size = New System.Drawing.Size(0, 13)
        Me.Lket.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Waktu Akhir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Waktu Awal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Pilih Barang/Obat"
        '
        'GBmanual
        '
        Me.GBmanual.Controls.Add(Me.Csat_waktu)
        Me.GBmanual.Controls.Add(Me.Tkebutuhan)
        Me.GBmanual.Controls.Add(Me.Label5)
        Me.GBmanual.Controls.Add(Me.Label2)
        Me.GBmanual.Location = New System.Drawing.Point(44, 22)
        Me.GBmanual.Name = "GBmanual"
        Me.GBmanual.Size = New System.Drawing.Size(378, 47)
        Me.GBmanual.TabIndex = 28
        Me.GBmanual.TabStop = False
        Me.GBmanual.Text = "Data Manual"
        '
        'Csat_waktu
        '
        Me.Csat_waktu.FormattingEnabled = True
        Me.Csat_waktu.Location = New System.Drawing.Point(299, 19)
        Me.Csat_waktu.Name = "Csat_waktu"
        Me.Csat_waktu.Size = New System.Drawing.Size(73, 21)
        Me.Csat_waktu.TabIndex = 22
        '
        'Tkebutuhan
        '
        Me.Tkebutuhan.Location = New System.Drawing.Point(132, 20)
        Me.Tkebutuhan.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.Tkebutuhan.Name = "Tkebutuhan"
        Me.Tkebutuhan.Size = New System.Drawing.Size(125, 20)
        Me.Tkebutuhan.TabIndex = 17
        Me.Tkebutuhan.ThousandsSeparator = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Per"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Kebutuhan Barang"
        '
        'Tpenyimpanan
        '
        Me.Tpenyimpanan.Location = New System.Drawing.Point(143, 298)
        Me.Tpenyimpanan.Name = "Tpenyimpanan"
        Me.Tpenyimpanan.Size = New System.Drawing.Size(280, 20)
        Me.Tpenyimpanan.TabIndex = 27
        '
        'Tpembelian
        '
        Me.Tpembelian.Location = New System.Drawing.Point(143, 184)
        Me.Tpembelian.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.Tpembelian.Name = "Tpembelian"
        Me.Tpembelian.Size = New System.Drawing.Size(280, 20)
        Me.Tpembelian.TabIndex = 26
        Me.Tpembelian.ThousandsSeparator = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Biaya Pembelian"
        '
        'Lhasil
        '
        Me.Lhasil.AutoSize = True
        Me.Lhasil.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lhasil.Location = New System.Drawing.Point(142, 327)
        Me.Lhasil.Name = "Lhasil"
        Me.Lhasil.Size = New System.Drawing.Size(60, 15)
        Me.Lhasil.TabIndex = 24
        Me.Lhasil.Text = "Tidak Ada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Hasil Perhitungan"
        '
        'Ttransportasi
        '
        Me.Ttransportasi.Location = New System.Drawing.Point(143, 260)
        Me.Ttransportasi.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.Ttransportasi.Name = "Ttransportasi"
        Me.Ttransportasi.Size = New System.Drawing.Size(280, 20)
        Me.Ttransportasi.TabIndex = 19
        Me.Ttransportasi.ThousandsSeparator = True
        '
        'Tpajak
        '
        Me.Tpajak.Location = New System.Drawing.Point(143, 221)
        Me.Tpajak.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.Tpajak.Name = "Tpajak"
        Me.Tpajak.Size = New System.Drawing.Size(280, 20)
        Me.Tpajak.TabIndex = 18
        Me.Tpajak.ThousandsSeparator = True
        '
        'Bsimpan
        '
        Me.Bsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsimpan.Location = New System.Drawing.Point(15, 389)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(108, 25)
        Me.Bsimpan.TabIndex = 15
        Me.Bsimpan.Text = "HITUNG EOQ"
        Me.Bsimpan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Biaya Penyimpanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Biaya Transportasi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Biaya Pajak"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MintCream
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(456, 24)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObatToolStripMenuItem, Me.JenisObatToolStripMenuItem, Me.PemasokToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'ObatToolStripMenuItem
        '
        Me.ObatToolStripMenuItem.Name = "ObatToolStripMenuItem"
        Me.ObatToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ObatToolStripMenuItem.Text = "Obat"
        '
        'JenisObatToolStripMenuItem
        '
        Me.JenisObatToolStripMenuItem.Name = "JenisObatToolStripMenuItem"
        Me.JenisObatToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.JenisObatToolStripMenuItem.Text = "Jenis Obat"
        '
        'PemasokToolStripMenuItem
        '
        Me.PemasokToolStripMenuItem.Name = "PemasokToolStripMenuItem"
        Me.PemasokToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.PemasokToolStripMenuItem.Text = "Pemasok"
        '
        'Feoq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 459)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Feoq"
        Me.Text = "Perhitungan EOQ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBotomatis.ResumeLayout(False)
        Me.GBotomatis.PerformLayout()
        Me.GBmanual.ResumeLayout(False)
        Me.GBmanual.PerformLayout()
        CType(Me.Tkebutuhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ttransportasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tpajak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JenisObatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PemasokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ttransportasi As System.Windows.Forms.NumericUpDown
    Friend WithEvents Tpajak As System.Windows.Forms.NumericUpDown
    Friend WithEvents Tkebutuhan As System.Windows.Forms.NumericUpDown
    Friend WithEvents Bsimpan As System.Windows.Forms.Button
    Friend WithEvents Csat_waktu As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lhasil As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tpembelian As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tpenyimpanan As System.Windows.Forms.TextBox
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents GBotomatis As System.Windows.Forms.GroupBox
    Friend WithEvents Takhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cobat As System.Windows.Forms.ComboBox
    Friend WithEvents Lket As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GBmanual As System.Windows.Forms.GroupBox
    Friend WithEvents RBotomatis As System.Windows.Forms.RadioButton
    Friend WithEvents RBmanual As System.Windows.Forms.RadioButton
End Class