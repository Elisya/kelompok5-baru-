﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPembayaran
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
        Me.components = New System.ComponentModel.Container()
        Dim Id_mejaLabel As System.Windows.Forms.Label
        Dim Nama_makananLabel As System.Windows.Forms.Label
        Dim Harga_makananLabel As System.Windows.Forms.Label
        Dim Jumlah_pesananLabel As System.Windows.Forms.Label
        Dim total As System.Windows.Forms.Label
        Dim uangbayar As System.Windows.Forms.Label
        Dim minum As System.Windows.Forms.Label
        Dim hminum As System.Windows.Forms.Label
        Dim jmlminum As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.kembali2 = New System.Windows.Forms.Label()
        Me.kembali = New System.Windows.Forms.Label()
        Me.pembyrn = New System.Windows.Forms.TextBox()
        Me.KasirBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kel_5_si_restoDataSet1 = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.biaya = New System.Windows.Forms.TextBox()
        Me.KasirTableAdapter1 = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter()
        Me.TableAdapterManager1 = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.minuman = New System.Windows.Forms.TextBox()
        Me.minuman2 = New System.Windows.Forms.TextBox()
        Me.minuman3 = New System.Windows.Forms.TextBox()
        Id_mejaLabel = New System.Windows.Forms.Label()
        Nama_makananLabel = New System.Windows.Forms.Label()
        Harga_makananLabel = New System.Windows.Forms.Label()
        Jumlah_pesananLabel = New System.Windows.Forms.Label()
        total = New System.Windows.Forms.Label()
        uangbayar = New System.Windows.Forms.Label()
        minum = New System.Windows.Forms.Label()
        hminum = New System.Windows.Forms.Label()
        jmlminum = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.KasirBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kel_5_si_restoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_mejaLabel
        '
        Id_mejaLabel.AutoSize = True
        Id_mejaLabel.Location = New System.Drawing.Point(8, 31)
        Id_mejaLabel.Name = "Id_mejaLabel"
        Id_mejaLabel.Size = New System.Drawing.Size(45, 13)
        Id_mejaLabel.TabIndex = 0
        Id_mejaLabel.Text = "Id Meja:"
        '
        'Nama_makananLabel
        '
        Nama_makananLabel.AutoSize = True
        Nama_makananLabel.Location = New System.Drawing.Point(8, 57)
        Nama_makananLabel.Name = "Nama_makananLabel"
        Nama_makananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_makananLabel.TabIndex = 2
        Nama_makananLabel.Text = "Nama Makanan:"
        '
        'Harga_makananLabel
        '
        Harga_makananLabel.AutoSize = True
        Harga_makananLabel.Location = New System.Drawing.Point(8, 83)
        Harga_makananLabel.Name = "Harga_makananLabel"
        Harga_makananLabel.Size = New System.Drawing.Size(87, 13)
        Harga_makananLabel.TabIndex = 4
        Harga_makananLabel.Text = "Harga Makanan:"
        '
        'Jumlah_pesananLabel
        '
        Jumlah_pesananLabel.AutoSize = True
        Jumlah_pesananLabel.Location = New System.Drawing.Point(8, 109)
        Jumlah_pesananLabel.Name = "Jumlah_pesananLabel"
        Jumlah_pesananLabel.Size = New System.Drawing.Size(88, 13)
        Jumlah_pesananLabel.TabIndex = 6
        Jumlah_pesananLabel.Text = "Jumlah Pesanan:"
        '
        'total
        '
        total.AutoSize = True
        total.Location = New System.Drawing.Point(8, 206)
        total.Name = "total"
        total.Size = New System.Drawing.Size(96, 13)
        total.TabIndex = 8
        total.Text = "Total Pembayaran:"
        '
        'uangbayar
        '
        uangbayar.AutoSize = True
        uangbayar.Location = New System.Drawing.Point(8, 235)
        uangbayar.Name = "uangbayar"
        uangbayar.Size = New System.Drawing.Size(98, 13)
        uangbayar.TabIndex = 19
        uangbayar.Text = "Uang Pembayaran:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(minum)
        Me.GroupBox2.Controls.Add(Me.minuman)
        Me.GroupBox2.Controls.Add(hminum)
        Me.GroupBox2.Controls.Add(Me.minuman2)
        Me.GroupBox2.Controls.Add(jmlminum)
        Me.GroupBox2.Controls.Add(Me.minuman3)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.kembali2)
        Me.GroupBox2.Controls.Add(Me.kembali)
        Me.GroupBox2.Controls.Add(uangbayar)
        Me.GroupBox2.Controls.Add(Me.pembyrn)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Id_mejaLabel)
        Me.GroupBox2.Controls.Add(Me.id)
        Me.GroupBox2.Controls.Add(Nama_makananLabel)
        Me.GroupBox2.Controls.Add(Me.nama)
        Me.GroupBox2.Controls.Add(Harga_makananLabel)
        Me.GroupBox2.Controls.Add(Me.harga)
        Me.GroupBox2.Controls.Add(Jumlah_pesananLabel)
        Me.GroupBox2.Controls.Add(Me.jumlah)
        Me.GroupBox2.Controls.Add(total)
        Me.GroupBox2.Controls.Add(Me.biaya)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 308)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pembayaran"
        '
        'kembali2
        '
        Me.kembali2.AutoSize = True
        Me.kembali2.Location = New System.Drawing.Point(145, 287)
        Me.kembali2.Name = "kembali2"
        Me.kembali2.Size = New System.Drawing.Size(56, 13)
        Me.kembali2.TabIndex = 22
        Me.kembali2.Text = "Kembalian"
        '
        'kembali
        '
        Me.kembali.AutoSize = True
        Me.kembali.Location = New System.Drawing.Point(29, 269)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(62, 13)
        Me.kembali.TabIndex = 21
        Me.kembali.Text = "Kembalian :"
        '
        'pembyrn
        '
        Me.pembyrn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "total_pembayaran", True))
        Me.pembyrn.Location = New System.Drawing.Point(105, 232)
        Me.pembyrn.Name = "pembyrn"
        Me.pembyrn.Size = New System.Drawing.Size(171, 20)
        Me.pembyrn.TabIndex = 20
        '
        'KasirBindingSource1
        '
        Me.KasirBindingSource1.DataMember = "kasir"
        Me.KasirBindingSource1.DataSource = Me.Kel_5_si_restoDataSet1
        '
        'Kel_5_si_restoDataSet1
        '
        Me.Kel_5_si_restoDataSet1.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(311, 174)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(255, 45)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Keluar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(439, 121)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 43)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(440, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 42)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(311, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 43)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(311, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 42)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "id_meja", True))
        Me.id.Location = New System.Drawing.Point(105, 28)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(171, 20)
        Me.id.TabIndex = 1
        '
        'nama
        '
        Me.nama.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "nama_makanan", True))
        Me.nama.Location = New System.Drawing.Point(105, 54)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(171, 20)
        Me.nama.TabIndex = 3
        '
        'harga
        '
        Me.harga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "harga_makanan", True))
        Me.harga.Location = New System.Drawing.Point(105, 80)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(171, 20)
        Me.harga.TabIndex = 5
        '
        'jumlah
        '
        Me.jumlah.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "jumlah_pesanan", True))
        Me.jumlah.Location = New System.Drawing.Point(105, 106)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(171, 20)
        Me.jumlah.TabIndex = 7
        '
        'biaya
        '
        Me.biaya.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "total_pembayaran", True))
        Me.biaya.Location = New System.Drawing.Point(105, 203)
        Me.biaya.Name = "biaya"
        Me.biaya.Size = New System.Drawing.Size(171, 20)
        Me.biaya.TabIndex = 9
        '
        'KasirTableAdapter1
        '
        Me.KasirTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.kasirTableAdapter = Me.KasirTableAdapter1
        Me.TableAdapterManager1.menuTableAdapter = Nothing
        Me.TableAdapterManager1.pelayanTableAdapter = Nothing
        Me.TableAdapterManager1.pemesananTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(311, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'minum
        '
        minum.AutoSize = True
        minum.Location = New System.Drawing.Point(8, 134)
        minum.Name = "minum"
        minum.Size = New System.Drawing.Size(81, 13)
        minum.TabIndex = 24
        minum.Text = "Nama Minuman"
        '
        'minuman
        '
        Me.minuman.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "nama_makanan", True))
        Me.minuman.Location = New System.Drawing.Point(105, 131)
        Me.minuman.Name = "minuman"
        Me.minuman.Size = New System.Drawing.Size(171, 20)
        Me.minuman.TabIndex = 25
        '
        'hminum
        '
        hminum.AutoSize = True
        hminum.Location = New System.Drawing.Point(8, 160)
        hminum.Name = "hminum"
        hminum.Size = New System.Drawing.Size(82, 13)
        hminum.TabIndex = 26
        hminum.Text = "Harga Minuman"
        '
        'minuman2
        '
        Me.minuman2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "harga_makanan", True))
        Me.minuman2.Location = New System.Drawing.Point(105, 157)
        Me.minuman2.Name = "minuman2"
        Me.minuman2.Size = New System.Drawing.Size(171, 20)
        Me.minuman2.TabIndex = 27
        '
        'jmlminum
        '
        jmlminum.AutoSize = True
        jmlminum.Location = New System.Drawing.Point(8, 183)
        jmlminum.Name = "jmlminum"
        jmlminum.Size = New System.Drawing.Size(88, 13)
        jmlminum.TabIndex = 28
        jmlminum.Text = "Jumlah Pesanan:"
        '
        'minuman3
        '
        Me.minuman3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "jumlah_pesanan", True))
        Me.minuman3.Location = New System.Drawing.Point(105, 180)
        Me.minuman3.Name = "minuman3"
        Me.minuman3.Size = New System.Drawing.Size(171, 20)
        Me.minuman3.TabIndex = 29
        '
        'formPembayaran
        '
        Me.ClientSize = New System.Drawing.Size(666, 357)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formPembayaran"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.KasirBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kel_5_si_restoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Kel_5_si_restoDataSet As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents KasirBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KasirTableAdapter As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter
    Friend WithEvents TableAdapterManager As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents keluarButton As System.Windows.Forms.Button
    Friend WithEvents batalButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Kel_5_si_restoDataSet1 As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents KasirBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KasirTableAdapter1 As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter
    Friend WithEvents TableAdapterManager1 As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents harga As System.Windows.Forms.TextBox
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents biaya As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pembyrn As System.Windows.Forms.TextBox
    Friend WithEvents kembali As System.Windows.Forms.Label
    Friend WithEvents kembali2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents minuman As System.Windows.Forms.TextBox
    Friend WithEvents minuman2 As System.Windows.Forms.TextBox
    Friend WithEvents minuman3 As System.Windows.Forms.TextBox
End Class
