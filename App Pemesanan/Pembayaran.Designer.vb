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
        Dim Id_mejaLabel As System.Windows.Forms.Label
        Dim Nama_makananLabel As System.Windows.Forms.Label
        Dim Harga_makananLabel As System.Windows.Forms.Label
        Dim Jumlah_pesananLabel As System.Windows.Forms.Label
<<<<<<< HEAD
        Dim Total_pembayaranLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.KasirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KasirTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.KasirDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_mejaTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_makananTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_makananTextBox = New System.Windows.Forms.TextBox()
        Me.Jumlah_pesananTextBox = New System.Windows.Forms.TextBox()
        Me.Total_pembayaranTextBox = New System.Windows.Forms.TextBox()
=======
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
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        Id_mejaLabel = New System.Windows.Forms.Label()
        Nama_makananLabel = New System.Windows.Forms.Label()
        Harga_makananLabel = New System.Windows.Forms.Label()
        Jumlah_pesananLabel = New System.Windows.Forms.Label()
<<<<<<< HEAD
        Total_pembayaranLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasirDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
=======
        total = New System.Windows.Forms.Label()
        uangbayar = New System.Windows.Forms.Label()
        minum = New System.Windows.Forms.Label()
        hminum = New System.Windows.Forms.Label()
        jmlminum = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.KasirBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kel_5_si_restoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Id_mejaLabel)
        Me.GroupBox1.Controls.Add(Me.Id_mejaTextBox)
        Me.GroupBox1.Controls.Add(Nama_makananLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_makananTextBox)
        Me.GroupBox1.Controls.Add(Harga_makananLabel)
        Me.GroupBox1.Controls.Add(Me.Harga_makananTextBox)
        Me.GroupBox1.Controls.Add(Jumlah_pesananLabel)
        Me.GroupBox1.Controls.Add(Me.Jumlah_pesananTextBox)
        Me.GroupBox1.Controls.Add(Total_pembayaranLabel)
        Me.GroupBox1.Controls.Add(Me.Total_pembayaranTextBox)
        Me.GroupBox1.Controls.Add(Me.KasirDataGridView)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(798, 290)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembayaran"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
=======
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
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'Button3
        '
<<<<<<< HEAD
        Me.Button3.Location = New System.Drawing.Point(6, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
=======
        Harga_makananLabel.AutoSize = True
        Harga_makananLabel.Location = New System.Drawing.Point(8, 83)
        Harga_makananLabel.Name = "Harga_makananLabel"
        Harga_makananLabel.Size = New System.Drawing.Size(87, 13)
        Harga_makananLabel.TabIndex = 4
        Harga_makananLabel.Text = "Harga Makanan:"
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'Button4
        '
<<<<<<< HEAD
        Me.Button4.Location = New System.Drawing.Point(100, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(100, 236)
=======
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
<<<<<<< HEAD
        Me.GroupBox2.Controls.Add(minum)
        Me.GroupBox2.Controls.Add(Me.minuman)
        Me.GroupBox2.Controls.Add(hminum)
        Me.GroupBox2.Controls.Add(Me.minuman2)
        Me.GroupBox2.Controls.Add(jmlminum)
        Me.GroupBox2.Controls.Add(Me.minuman3)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
=======
<<<<<<< HEAD
        Me.GroupBox2.BackColor = System.Drawing.Color.Tomato
=======
>>>>>>> de7162584e1c2d4cda5782110d127fde45d50746
        Me.GroupBox2.Controls.Add(Me.kembali2)
        Me.GroupBox2.Controls.Add(Me.kembali)
        Me.GroupBox2.Controls.Add(uangbayar)
        Me.GroupBox2.Controls.Add(Me.pembyrn)
>>>>>>> 4c41f3f059032c790a8971a2c99a3abaa7eaf29d
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
<<<<<<< HEAD
        Me.GroupBox2.Controls.Add(Me.Jumlah_pesananTextBox)
        Me.GroupBox2.Controls.Add(Total_pembayaranLabel)
        Me.GroupBox2.Controls.Add(Me.Total_pembayaranTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(1, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(900, 317)
=======
        Me.GroupBox2.Controls.Add(Me.jumlah)
        Me.GroupBox2.Controls.Add(total)
        Me.GroupBox2.Controls.Add(Me.biaya)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 308)
>>>>>>> 4c41f3f059032c790a8971a2c99a3abaa7eaf29d
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
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Kel_5_si_restoDataSet
        '
<<<<<<< HEAD
        Me.Kel_5_si_restoDataSet.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
=======
        Me.Button4.Location = New System.Drawing.Point(440, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 42)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'KasirBindingSource
        '
<<<<<<< HEAD
        Me.KasirBindingSource.DataMember = "kasir"
        Me.KasirBindingSource.DataSource = Me.Kel_5_si_restoDataSet
=======
        Me.Button3.Location = New System.Drawing.Point(311, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 43)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'KasirTableAdapter
        '
<<<<<<< HEAD
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
        'KasirDataGridView
        '
        Me.KasirDataGridView.AutoGenerateColumns = False
        Me.KasirDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KasirDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.KasirDataGridView.DataSource = Me.KasirBindingSource
        Me.KasirDataGridView.Location = New System.Drawing.Point(248, 16)
        Me.KasirDataGridView.Name = "KasirDataGridView"
        Me.KasirDataGridView.Size = New System.Drawing.Size(544, 220)
        Me.KasirDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_meja"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_meja"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_makanan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_makanan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "harga_makanan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "harga_makanan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "jumlah_pesanan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "jumlah_pesanan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
=======
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
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'DataGridViewTextBoxColumn5
        '
<<<<<<< HEAD
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "total_pembayaran"
        Me.DataGridViewTextBoxColumn5.HeaderText = "total_pembayaran"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
=======
        Me.nama.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "nama_makanan", True))
        Me.nama.Location = New System.Drawing.Point(105, 54)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(171, 20)
        Me.nama.TabIndex = 3
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'Id_mejaLabel
        '
<<<<<<< HEAD
        Id_mejaLabel.AutoSize = True
        Id_mejaLabel.Location = New System.Drawing.Point(15, 19)
        Id_mejaLabel.Name = "Id_mejaLabel"
        Id_mejaLabel.Size = New System.Drawing.Size(43, 13)
        Id_mejaLabel.TabIndex = 6
        Id_mejaLabel.Text = "id meja:"
=======
        Me.harga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "harga_makanan", True))
        Me.harga.Location = New System.Drawing.Point(105, 80)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(171, 20)
        Me.harga.TabIndex = 5
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'Id_mejaTextBox
        '
<<<<<<< HEAD
        Me.Id_mejaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "id_meja", True))
        Me.Id_mejaTextBox.Location = New System.Drawing.Point(112, 16)
        Me.Id_mejaTextBox.Name = "Id_mejaTextBox"
        Me.Id_mejaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_mejaTextBox.TabIndex = 7
=======
        Me.jumlah.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "jumlah_pesanan", True))
        Me.jumlah.Location = New System.Drawing.Point(105, 106)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(171, 20)
        Me.jumlah.TabIndex = 7
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'Nama_makananLabel
        '
<<<<<<< HEAD
        Nama_makananLabel.AutoSize = True
        Nama_makananLabel.Location = New System.Drawing.Point(15, 45)
        Nama_makananLabel.Name = "Nama_makananLabel"
        Nama_makananLabel.Size = New System.Drawing.Size(83, 13)
        Nama_makananLabel.TabIndex = 8
        Nama_makananLabel.Text = "nama makanan:"
=======
        Me.biaya.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "total_pembayaran", True))
        Me.biaya.Location = New System.Drawing.Point(105, 203)
        Me.biaya.Name = "biaya"
        Me.biaya.Size = New System.Drawing.Size(171, 20)
        Me.biaya.TabIndex = 9
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'Nama_makananTextBox
        '
        Me.Nama_makananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "nama_makanan", True))
        Me.Nama_makananTextBox.Location = New System.Drawing.Point(112, 42)
        Me.Nama_makananTextBox.Name = "Nama_makananTextBox"
        Me.Nama_makananTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_makananTextBox.TabIndex = 9
        '
        'Harga_makananLabel
        '
        Harga_makananLabel.AutoSize = True
        Harga_makananLabel.Location = New System.Drawing.Point(15, 71)
        Harga_makananLabel.Name = "Harga_makananLabel"
        Harga_makananLabel.Size = New System.Drawing.Size(84, 13)
        Harga_makananLabel.TabIndex = 10
        Harga_makananLabel.Text = "harga makanan:"
        '
<<<<<<< HEAD
        'Harga_makananTextBox
        '
        Me.Harga_makananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "harga_makanan", True))
        Me.Harga_makananTextBox.Location = New System.Drawing.Point(112, 68)
        Me.Harga_makananTextBox.Name = "Harga_makananTextBox"
        Me.Harga_makananTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Harga_makananTextBox.TabIndex = 11
        '
        'Jumlah_pesananLabel
        '
        Jumlah_pesananLabel.AutoSize = True
        Jumlah_pesananLabel.Location = New System.Drawing.Point(15, 97)
        Jumlah_pesananLabel.Name = "Jumlah_pesananLabel"
        Jumlah_pesananLabel.Size = New System.Drawing.Size(84, 13)
        Jumlah_pesananLabel.TabIndex = 12
        Jumlah_pesananLabel.Text = "jumlah pesanan:"
        '
        'Jumlah_pesananTextBox
        '
        Me.Jumlah_pesananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "jumlah_pesanan", True))
        Me.Jumlah_pesananTextBox.Location = New System.Drawing.Point(112, 94)
        Me.Jumlah_pesananTextBox.Name = "Jumlah_pesananTextBox"
        Me.Jumlah_pesananTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Jumlah_pesananTextBox.TabIndex = 13
        '
        'Total_pembayaranLabel
        '
        Total_pembayaranLabel.AutoSize = True
        Total_pembayaranLabel.Location = New System.Drawing.Point(15, 123)
        Total_pembayaranLabel.Name = "Total_pembayaranLabel"
        Total_pembayaranLabel.Size = New System.Drawing.Size(91, 13)
        Total_pembayaranLabel.TabIndex = 14
        Total_pembayaranLabel.Text = "total pembayaran:"
        '
        'Total_pembayaranTextBox
        '
        Me.Total_pembayaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "total_pembayaran", True))
        Me.Total_pembayaranTextBox.Location = New System.Drawing.Point(112, 120)
        Me.Total_pembayaranTextBox.Name = "Total_pembayaranTextBox"
        Me.Total_pembayaranTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_pembayaranTextBox.TabIndex = 15
=======
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
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
        '
        'formPembayaran
        '
        Me.ClientSize = New System.Drawing.Size(822, 310)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formPembayaran"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KasirDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

<<<<<<< HEAD
=======
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
>>>>>>> 37c4296ee17073d8e0afce1ebd1c023b4c0fcc03
