<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim idmeja As System.Windows.Forms.Label
        Dim Nama_makananLabel As System.Windows.Forms.Label
        Dim Harga_makananLabel As System.Windows.Forms.Label
        Dim Jumlah_pesananLabel As System.Windows.Forms.Label
        Dim Total_pembayaranLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.KasirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KasirTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.id = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.biaya = New System.Windows.Forms.TextBox()
        Me.minum = New System.Windows.Forms.TextBox()
        Me.minum2 = New System.Windows.Forms.TextBox()
        Me.minum3 = New System.Windows.Forms.TextBox()
        Me.pembyrn = New System.Windows.Forms.TextBox()
        Me.kembali = New System.Windows.Forms.Label()
        Me.kembali2 = New System.Windows.Forms.Label()
        idmeja = New System.Windows.Forms.Label()
        Nama_makananLabel = New System.Windows.Forms.Label()
        Harga_makananLabel = New System.Windows.Forms.Label()
        Jumlah_pesananLabel = New System.Windows.Forms.Label()
        Total_pembayaranLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.kembali2)
        Me.GroupBox1.Controls.Add(Me.kembali)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.pembyrn)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.minum)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.minum2)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.minum3)
        Me.GroupBox1.Controls.Add(idmeja)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Nama_makananLabel)
        Me.GroupBox1.Controls.Add(Me.nama)
        Me.GroupBox1.Controls.Add(Harga_makananLabel)
        Me.GroupBox1.Controls.Add(Me.harga)
        Me.GroupBox1.Controls.Add(Jumlah_pesananLabel)
        Me.GroupBox1.Controls.Add(Me.jumlah)
        Me.GroupBox1.Controls.Add(Total_pembayaranLabel)
        Me.GroupBox1.Controls.Add(Me.biaya)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 381)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(299, 174)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(254, 32)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Keluar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(426, 124)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 44)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(426, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 44)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(298, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 44)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(299, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 44)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Kel_5_si_restoDataSet
        '
        Me.Kel_5_si_restoDataSet.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KasirBindingSource
        '
        Me.KasirBindingSource.DataMember = "kasir"
        Me.KasirBindingSource.DataSource = Me.Kel_5_si_restoDataSet
        '
        'KasirTableAdapter
        '
        Me.KasirTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kasirTableAdapter = Me.KasirTableAdapter
        Me.TableAdapterManager.menuTableAdapter = Nothing
        Me.TableAdapterManager.pelayanTableAdapter = Nothing
        Me.TableAdapterManager.pemesananTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'idmeja
        '
        idmeja.AutoSize = True
        idmeja.Location = New System.Drawing.Point(11, 38)
        idmeja.Name = "idmeja"
        idmeja.Size = New System.Drawing.Size(45, 13)
        idmeja.TabIndex = 18
        idmeja.Text = "Id Meja:"
        '
        'id
        '
        Me.id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "id_meja", True))
        Me.id.Location = New System.Drawing.Point(108, 35)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 19
        '
        'Nama_makananLabel
        '
        Nama_makananLabel.AutoSize = True
        Nama_makananLabel.Location = New System.Drawing.Point(11, 64)
        Nama_makananLabel.Name = "Nama_makananLabel"
        Nama_makananLabel.Size = New System.Drawing.Size(85, 13)
        Nama_makananLabel.TabIndex = 20
        Nama_makananLabel.Text = "Menu Makanan:"
        '
        'nama
        '
        Me.nama.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "nama_makanan", True))
        Me.nama.Location = New System.Drawing.Point(108, 61)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(100, 20)
        Me.nama.TabIndex = 21
        '
        'Harga_makananLabel
        '
        Harga_makananLabel.AutoSize = True
        Harga_makananLabel.Location = New System.Drawing.Point(11, 90)
        Harga_makananLabel.Name = "Harga_makananLabel"
        Harga_makananLabel.Size = New System.Drawing.Size(87, 13)
        Harga_makananLabel.TabIndex = 22
        Harga_makananLabel.Text = "Harga Makanan:"
        '
        'harga
        '
        Me.harga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "harga_makanan", True))
        Me.harga.Location = New System.Drawing.Point(108, 87)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(100, 20)
        Me.harga.TabIndex = 23
        '
        'Jumlah_pesananLabel
        '
        Jumlah_pesananLabel.AutoSize = True
        Jumlah_pesananLabel.Location = New System.Drawing.Point(11, 116)
        Jumlah_pesananLabel.Name = "Jumlah_pesananLabel"
        Jumlah_pesananLabel.Size = New System.Drawing.Size(88, 13)
        Jumlah_pesananLabel.TabIndex = 24
        Jumlah_pesananLabel.Text = "Jumlah Pesanan:"
        '
        'jumlah
        '
        Me.jumlah.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "jumlah_pesanan", True))
        Me.jumlah.Location = New System.Drawing.Point(108, 113)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(100, 20)
        Me.jumlah.TabIndex = 25
        '
        'Total_pembayaranLabel
        '
        Total_pembayaranLabel.AutoSize = True
        Total_pembayaranLabel.Location = New System.Drawing.Point(11, 220)
        Total_pembayaranLabel.Name = "Total_pembayaranLabel"
        Total_pembayaranLabel.Size = New System.Drawing.Size(96, 13)
        Total_pembayaranLabel.TabIndex = 26
        Total_pembayaranLabel.Text = "Total Pembayaran:"
        '
        'biaya
        '
        Me.biaya.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "total_pembayaran", True))
        Me.biaya.Location = New System.Drawing.Point(108, 217)
        Me.biaya.Name = "biaya"
        Me.biaya.Size = New System.Drawing.Size(100, 20)
        Me.biaya.TabIndex = 27
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(11, 139)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 13)
        Label1.TabIndex = 28
        Label1.Text = "Menu Minuman"
        '
        'minum
        '
        Me.minum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "nama_makanan", True))
        Me.minum.Location = New System.Drawing.Point(108, 136)
        Me.minum.Name = "minum"
        Me.minum.Size = New System.Drawing.Size(100, 20)
        Me.minum.TabIndex = 29
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(11, 165)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(82, 13)
        Label2.TabIndex = 30
        Label2.Text = "Harga Minuman"
        '
        'minum2
        '
        Me.minum2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "harga_makanan", True))
        Me.minum2.Location = New System.Drawing.Point(108, 162)
        Me.minum2.Name = "minum2"
        Me.minum2.Size = New System.Drawing.Size(100, 20)
        Me.minum2.TabIndex = 31
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(11, 191)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(88, 13)
        Label3.TabIndex = 32
        Label3.Text = "Jumlah Pesanan:"
        '
        'minum3
        '
        Me.minum3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "jumlah_pesanan", True))
        Me.minum3.Location = New System.Drawing.Point(108, 188)
        Me.minum3.Name = "minum3"
        Me.minum3.Size = New System.Drawing.Size(100, 20)
        Me.minum3.TabIndex = 33
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(11, 246)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(95, 13)
        Label4.TabIndex = 34
        Label4.Text = "Uang Pembayaran"
        '
        'pembyrn
        '
        Me.pembyrn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "total_pembayaran", True))
        Me.pembyrn.Location = New System.Drawing.Point(108, 243)
        Me.pembyrn.Name = "pembyrn"
        Me.pembyrn.Size = New System.Drawing.Size(100, 20)
        Me.pembyrn.TabIndex = 35
        '
        'kembali
        '
        Me.kembali.AutoSize = True
        Me.kembali.Location = New System.Drawing.Point(17, 281)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(56, 13)
        Me.kembali.TabIndex = 36
        Me.kembali.Text = "Kembalian"
        '
        'kembali2
        '
        Me.kembali2.AutoSize = True
        Me.kembali2.Location = New System.Drawing.Point(124, 356)
        Me.kembali2.Name = "kembali2"
        Me.kembali2.Size = New System.Drawing.Size(59, 13)
        Me.kembali2.TabIndex = 37
        Me.kembali2.Text = "Kembalian "
        '
        'formPembayaran
        '
        Me.ClientSize = New System.Drawing.Size(592, 405)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formPembayaran"
        Me.Text = "Pembayaran"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

