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
        Dim Total_pembayaranLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Kel_5_si_restoDataSet1 = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.KasirBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KasirTableAdapter1 = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter()
        Me.TableAdapterManager1 = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.Id_mejaTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_makananTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_makananTextBox = New System.Windows.Forms.TextBox()
        Me.Jumlah_pesananTextBox = New System.Windows.Forms.TextBox()
        Me.Total_pembayaranTextBox = New System.Windows.Forms.TextBox()
        Me.KasirDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Id_mejaLabel = New System.Windows.Forms.Label()
        Nama_makananLabel = New System.Windows.Forms.Label()
        Harga_makananLabel = New System.Windows.Forms.Label()
        Jumlah_pesananLabel = New System.Windows.Forms.Label()
        Total_pembayaranLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Kel_5_si_restoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasirBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasirDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.KasirDataGridView)
        Me.GroupBox2.Controls.Add(Id_mejaLabel)
        Me.GroupBox2.Controls.Add(Me.Id_mejaTextBox)
        Me.GroupBox2.Controls.Add(Nama_makananLabel)
        Me.GroupBox2.Controls.Add(Me.Nama_makananTextBox)
        Me.GroupBox2.Controls.Add(Harga_makananLabel)
        Me.GroupBox2.Controls.Add(Me.Harga_makananTextBox)
        Me.GroupBox2.Controls.Add(Jumlah_pesananLabel)
        Me.GroupBox2.Controls.Add(Me.Jumlah_pesananTextBox)
        Me.GroupBox2.Controls.Add(Total_pembayaranLabel)
        Me.GroupBox2.Controls.Add(Me.Total_pembayaranTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(857, 324)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Kel_5_si_restoDataSet1
        '
        Me.Kel_5_si_restoDataSet1.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KasirBindingSource1
        '
        Me.KasirBindingSource1.DataMember = "kasir"
        Me.KasirBindingSource1.DataSource = Me.Kel_5_si_restoDataSet1
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
        'Id_mejaLabel
        '
        Id_mejaLabel.AutoSize = True
        Id_mejaLabel.Location = New System.Drawing.Point(8, 47)
        Id_mejaLabel.Name = "Id_mejaLabel"
        Id_mejaLabel.Size = New System.Drawing.Size(45, 13)
        Id_mejaLabel.TabIndex = 0
        Id_mejaLabel.Text = "Id Meja:"
        '
        'Id_mejaTextBox
        '
        Me.Id_mejaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "id_meja", True))
        Me.Id_mejaTextBox.Location = New System.Drawing.Point(105, 44)
        Me.Id_mejaTextBox.Name = "Id_mejaTextBox"
        Me.Id_mejaTextBox.Size = New System.Drawing.Size(171, 20)
        Me.Id_mejaTextBox.TabIndex = 1
        '
        'Nama_makananLabel
        '
        Nama_makananLabel.AutoSize = True
        Nama_makananLabel.Location = New System.Drawing.Point(8, 73)
        Nama_makananLabel.Name = "Nama_makananLabel"
        Nama_makananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_makananLabel.TabIndex = 2
        Nama_makananLabel.Text = "Nama Makanan:"
        '
        'Nama_makananTextBox
        '
        Me.Nama_makananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "nama_makanan", True))
        Me.Nama_makananTextBox.Location = New System.Drawing.Point(105, 70)
        Me.Nama_makananTextBox.Name = "Nama_makananTextBox"
        Me.Nama_makananTextBox.Size = New System.Drawing.Size(171, 20)
        Me.Nama_makananTextBox.TabIndex = 3
        '
        'Harga_makananLabel
        '
        Harga_makananLabel.AutoSize = True
        Harga_makananLabel.Location = New System.Drawing.Point(8, 99)
        Harga_makananLabel.Name = "Harga_makananLabel"
        Harga_makananLabel.Size = New System.Drawing.Size(87, 13)
        Harga_makananLabel.TabIndex = 4
        Harga_makananLabel.Text = "Harga Makanan:"
        '
        'Harga_makananTextBox
        '
        Me.Harga_makananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "harga_makanan", True))
        Me.Harga_makananTextBox.Location = New System.Drawing.Point(105, 96)
        Me.Harga_makananTextBox.Name = "Harga_makananTextBox"
        Me.Harga_makananTextBox.Size = New System.Drawing.Size(171, 20)
        Me.Harga_makananTextBox.TabIndex = 5
        '
        'Jumlah_pesananLabel
        '
        Jumlah_pesananLabel.AutoSize = True
        Jumlah_pesananLabel.Location = New System.Drawing.Point(8, 125)
        Jumlah_pesananLabel.Name = "Jumlah_pesananLabel"
        Jumlah_pesananLabel.Size = New System.Drawing.Size(88, 13)
        Jumlah_pesananLabel.TabIndex = 6
        Jumlah_pesananLabel.Text = "Jumlah Pesanan:"
        '
        'Jumlah_pesananTextBox
        '
        Me.Jumlah_pesananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "jumlah_pesanan", True))
        Me.Jumlah_pesananTextBox.Location = New System.Drawing.Point(105, 122)
        Me.Jumlah_pesananTextBox.Name = "Jumlah_pesananTextBox"
        Me.Jumlah_pesananTextBox.Size = New System.Drawing.Size(171, 20)
        Me.Jumlah_pesananTextBox.TabIndex = 7
        '
        'Total_pembayaranLabel
        '
        Total_pembayaranLabel.AutoSize = True
        Total_pembayaranLabel.Location = New System.Drawing.Point(8, 151)
        Total_pembayaranLabel.Name = "Total_pembayaranLabel"
        Total_pembayaranLabel.Size = New System.Drawing.Size(96, 13)
        Total_pembayaranLabel.TabIndex = 8
        Total_pembayaranLabel.Text = "Total Pembayaran:"
        '
        'Total_pembayaranTextBox
        '
        Me.Total_pembayaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource1, "total_pembayaran", True))
        Me.Total_pembayaranTextBox.Location = New System.Drawing.Point(105, 148)
        Me.Total_pembayaranTextBox.Name = "Total_pembayaranTextBox"
        Me.Total_pembayaranTextBox.Size = New System.Drawing.Size(171, 20)
        Me.Total_pembayaranTextBox.TabIndex = 9
        '
        'KasirDataGridView
        '
        Me.KasirDataGridView.AutoGenerateColumns = False
        Me.KasirDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KasirDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.KasirDataGridView.DataSource = Me.KasirBindingSource1
        Me.KasirDataGridView.Location = New System.Drawing.Point(302, 44)
        Me.KasirDataGridView.Name = "KasirDataGridView"
        Me.KasirDataGridView.Size = New System.Drawing.Size(549, 238)
        Me.KasirDataGridView.TabIndex = 10
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
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "total_pembayaran"
        Me.DataGridViewTextBoxColumn5.HeaderText = "total_pembayaran"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(88, 271)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(122, 32)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Keluar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(149, 234)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 31)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(149, 193)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 35)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 31)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 35)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'formPembayaran
        '
        Me.ClientSize = New System.Drawing.Size(900, 377)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formPembayaran"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Kel_5_si_restoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KasirBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KasirDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KasirDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_mejaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_makananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Harga_makananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jumlah_pesananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_pembayaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
