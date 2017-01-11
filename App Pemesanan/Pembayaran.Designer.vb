<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formpembayaran
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
        Dim l1 As System.Windows.Forms.Label
        Dim l2 As System.Windows.Forms.Label
        Dim l3 As System.Windows.Forms.Label
        Dim l4 As System.Windows.Forms.Label
        Dim Total_pembayaranLabel As System.Windows.Forms.Label
        Dim l5 As System.Windows.Forms.Label
        Dim l6 As System.Windows.Forms.Label
        Dim l7 As System.Windows.Forms.Label
        Dim l9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formpembayaran))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.kembali2 = New System.Windows.Forms.Label()
        Me.kembali = New System.Windows.Forms.Label()
        Me.t9 = New System.Windows.Forms.TextBox()
        Me.KasirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.t6 = New System.Windows.Forms.TextBox()
        Me.t7 = New System.Windows.Forms.TextBox()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.t4 = New System.Windows.Forms.TextBox()
        Me.t8 = New System.Windows.Forms.TextBox()
        Me.keluar = New System.Windows.Forms.Button()
        Me.hps = New System.Windows.Forms.Button()
        Me.btl = New System.Windows.Forms.Button()
        Me.smpn = New System.Windows.Forms.Button()
        Me.tmbh = New System.Windows.Forms.Button()
        Me.KasirTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.c2 = New System.Windows.Forms.ComboBox()
        Me.c5 = New System.Windows.Forms.ComboBox()
        l1 = New System.Windows.Forms.Label()
        l2 = New System.Windows.Forms.Label()
        l3 = New System.Windows.Forms.Label()
        l4 = New System.Windows.Forms.Label()
        Total_pembayaranLabel = New System.Windows.Forms.Label()
        l5 = New System.Windows.Forms.Label()
        l6 = New System.Windows.Forms.Label()
        l7 = New System.Windows.Forms.Label()
        l9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l1
        '
        l1.AutoSize = True
        l1.Location = New System.Drawing.Point(10, 32)
        l1.Name = "l1"
        l1.Size = New System.Drawing.Size(42, 13)
        l1.TabIndex = 9
        l1.Text = "Id Meja"
        '
        'l2
        '
        l2.AutoSize = True
        l2.Location = New System.Drawing.Point(10, 58)
        l2.Name = "l2"
        l2.Size = New System.Drawing.Size(82, 13)
        l2.TabIndex = 11
        l2.Text = "Menu Makanan"
        '
        'l3
        '
        l3.AutoSize = True
        l3.Location = New System.Drawing.Point(10, 84)
        l3.Name = "l3"
        l3.Size = New System.Drawing.Size(39, 13)
        l3.TabIndex = 13
        l3.Text = "Harga "
        '
        'l4
        '
        l4.AutoSize = True
        l4.Location = New System.Drawing.Point(10, 110)
        l4.Name = "l4"
        l4.Size = New System.Drawing.Size(85, 13)
        l4.TabIndex = 15
        l4.Text = "Jumlah Pesanan"
        '
        'Total_pembayaranLabel
        '
        Total_pembayaranLabel.AutoSize = True
        Total_pembayaranLabel.Location = New System.Drawing.Point(10, 222)
        Total_pembayaranLabel.Name = "Total_pembayaranLabel"
        Total_pembayaranLabel.Size = New System.Drawing.Size(93, 13)
        Total_pembayaranLabel.TabIndex = 17
        Total_pembayaranLabel.Text = "Total Pembayaran"
        AddHandler Total_pembayaranLabel.Click, AddressOf Me.Total_pembayaranLabel_Click
        '
        'l5
        '
        l5.AutoSize = True
        l5.Location = New System.Drawing.Point(11, 141)
        l5.Name = "l5"
        l5.Size = New System.Drawing.Size(80, 13)
        l5.TabIndex = 19
        l5.Text = "Menu Minuman"
        '
        'l6
        '
        l6.AutoSize = True
        l6.Location = New System.Drawing.Point(11, 167)
        l6.Name = "l6"
        l6.Size = New System.Drawing.Size(36, 13)
        l6.TabIndex = 21
        l6.Text = "Harga"
        '
        'l7
        '
        l7.AutoSize = True
        l7.Location = New System.Drawing.Point(11, 193)
        l7.Name = "l7"
        l7.Size = New System.Drawing.Size(85, 13)
        l7.TabIndex = 23
        l7.Text = "Jumlah Pesanan"
        '
        'l9
        '
        l9.AutoSize = True
        l9.Location = New System.Drawing.Point(10, 252)
        l9.Name = "l9"
        l9.Size = New System.Drawing.Size(95, 13)
        l9.TabIndex = 25
        l9.Text = "Uang Pembayaran"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.c5)
        Me.GroupBox1.Controls.Add(Me.c2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.kembali2)
        Me.GroupBox1.Controls.Add(Me.kembali)
        Me.GroupBox1.Controls.Add(l9)
        Me.GroupBox1.Controls.Add(Me.t9)
        Me.GroupBox1.Controls.Add(l5)
        Me.GroupBox1.Controls.Add(l6)
        Me.GroupBox1.Controls.Add(Me.t6)
        Me.GroupBox1.Controls.Add(l7)
        Me.GroupBox1.Controls.Add(Me.t7)
        Me.GroupBox1.Controls.Add(l1)
        Me.GroupBox1.Controls.Add(Me.t1)
        Me.GroupBox1.Controls.Add(l2)
        Me.GroupBox1.Controls.Add(l3)
        Me.GroupBox1.Controls.Add(Me.t3)
        Me.GroupBox1.Controls.Add(l4)
        Me.GroupBox1.Controls.Add(Me.t4)
        Me.GroupBox1.Controls.Add(Total_pembayaranLabel)
        Me.GroupBox1.Controls.Add(Me.t8)
        Me.GroupBox1.Controls.Add(Me.keluar)
        Me.GroupBox1.Controls.Add(Me.hps)
        Me.GroupBox1.Controls.Add(Me.btl)
        Me.GroupBox1.Controls.Add(Me.smpn)
        Me.GroupBox1.Controls.Add(Me.tmbh)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 355)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kasir"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(267, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 29
        '
        'kembali2
        '
        Me.kembali2.AutoSize = True
        Me.kembali2.Location = New System.Drawing.Point(188, 336)
        Me.kembali2.Name = "kembali2"
        Me.kembali2.Size = New System.Drawing.Size(56, 13)
        Me.kembali2.TabIndex = 28
        Me.kembali2.Text = "Kembalian"
        '
        'kembali
        '
        Me.kembali.AutoSize = True
        Me.kembali.Location = New System.Drawing.Point(14, 287)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(56, 13)
        Me.kembali.TabIndex = 27
        Me.kembali.Text = "Kembalian"
        '
        't9
        '
        Me.t9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "total_pembayaran", True))
        Me.t9.Location = New System.Drawing.Point(107, 249)
        Me.t9.Name = "t9"
        Me.t9.Size = New System.Drawing.Size(148, 20)
        Me.t9.TabIndex = 26
        '
        'KasirBindingSource
        '
        Me.KasirBindingSource.DataMember = "kasir"
        Me.KasirBindingSource.DataSource = Me.Kel_5_si_restoDataSet
        '
        'Kel_5_si_restoDataSet
        '
        Me.Kel_5_si_restoDataSet.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        't6
        '
        Me.t6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "harga_makanan", True))
        Me.t6.Location = New System.Drawing.Point(108, 164)
        Me.t6.Name = "t6"
        Me.t6.Size = New System.Drawing.Size(148, 20)
        Me.t6.TabIndex = 22
        '
        't7
        '
        Me.t7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "jumlah_pesanan", True))
        Me.t7.Location = New System.Drawing.Point(108, 190)
        Me.t7.Name = "t7"
        Me.t7.Size = New System.Drawing.Size(148, 20)
        Me.t7.TabIndex = 24
        '
        't1
        '
        Me.t1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "id_meja", True))
        Me.t1.Location = New System.Drawing.Point(107, 29)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(148, 20)
        Me.t1.TabIndex = 10
        '
        't3
        '
        Me.t3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "harga_makanan", True))
        Me.t3.Location = New System.Drawing.Point(107, 81)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(148, 20)
        Me.t3.TabIndex = 14
        '
        't4
        '
        Me.t4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "jumlah_pesanan", True))
        Me.t4.Location = New System.Drawing.Point(107, 107)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(148, 20)
        Me.t4.TabIndex = 16
        '
        't8
        '
        Me.t8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "total_pembayaran", True))
        Me.t8.Location = New System.Drawing.Point(107, 219)
        Me.t8.Name = "t8"
        Me.t8.Size = New System.Drawing.Size(148, 20)
        Me.t8.TabIndex = 18
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(267, 205)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(260, 40)
        Me.keluar.TabIndex = 9
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hps
        '
        Me.hps.Location = New System.Drawing.Point(400, 160)
        Me.hps.Name = "hps"
        Me.hps.Size = New System.Drawing.Size(127, 39)
        Me.hps.TabIndex = 8
        Me.hps.Text = "Hapus"
        Me.hps.UseVisualStyleBackColor = True
        '
        'btl
        '
        Me.btl.Location = New System.Drawing.Point(267, 160)
        Me.btl.Name = "btl"
        Me.btl.Size = New System.Drawing.Size(127, 39)
        Me.btl.TabIndex = 7
        Me.btl.Text = "Batal"
        Me.btl.UseVisualStyleBackColor = True
        '
        'smpn
        '
        Me.smpn.Location = New System.Drawing.Point(400, 113)
        Me.smpn.Name = "smpn"
        Me.smpn.Size = New System.Drawing.Size(127, 41)
        Me.smpn.TabIndex = 6
        Me.smpn.Text = "Simpan"
        Me.smpn.UseVisualStyleBackColor = True
        '
        'tmbh
        '
        Me.tmbh.Location = New System.Drawing.Point(267, 113)
        Me.tmbh.Name = "tmbh"
        Me.tmbh.Size = New System.Drawing.Size(127, 41)
        Me.tmbh.TabIndex = 5
        Me.tmbh.Text = "Tambah"
        Me.tmbh.UseVisualStyleBackColor = True
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
        'c2
        '
        Me.c2.FormattingEnabled = True
        Me.c2.Location = New System.Drawing.Point(107, 55)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(148, 21)
        Me.c2.TabIndex = 30
        '
        'c5
        '
        Me.c5.FormattingEnabled = True
        Me.c5.Location = New System.Drawing.Point(110, 135)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(146, 21)
        Me.c5.TabIndex = 31
        '
        'formpembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(552, 379)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formpembayaran"
        Me.Text = "Pembayaran"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents keluar As System.Windows.Forms.Button
    Friend WithEvents hps As System.Windows.Forms.Button
    Friend WithEvents btl As System.Windows.Forms.Button
    Friend WithEvents smpn As System.Windows.Forms.Button
    Friend WithEvents tmbh As System.Windows.Forms.Button
    Friend WithEvents Kel_5_si_restoDataSet As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents KasirBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KasirTableAdapter As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter
    Friend WithEvents TableAdapterManager As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents kembali2 As System.Windows.Forms.Label
    Friend WithEvents kembali As System.Windows.Forms.Label
    Friend WithEvents t9 As System.Windows.Forms.TextBox
    Friend WithEvents t6 As System.Windows.Forms.TextBox
    Friend WithEvents t7 As System.Windows.Forms.TextBox
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents t4 As System.Windows.Forms.TextBox
    Friend WithEvents t8 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents c5 As System.Windows.Forms.ComboBox
    Friend WithEvents c2 As System.Windows.Forms.ComboBox
End Class
