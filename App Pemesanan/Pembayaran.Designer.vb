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
        Dim Id_MejaLabel As System.Windows.Forms.Label
        Dim Nama_MakananLabel As System.Windows.Forms.Label
        Dim Harga_MakananLabel As System.Windows.Forms.Label
        Dim Jumlah_PesananLabel As System.Windows.Forms.Label
        Dim Total_PembayaranLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.keluarButton = New System.Windows.Forms.Button()
        Me.batalButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.KasirDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KasirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.Id_MejaTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Jumlah_PesananTextBox = New System.Windows.Forms.TextBox()
        Me.Total_PembayaranTextBox = New System.Windows.Forms.TextBox()
        Me.KasirTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Id_MejaLabel = New System.Windows.Forms.Label()
        Nama_MakananLabel = New System.Windows.Forms.Label()
        Harga_MakananLabel = New System.Windows.Forms.Label()
        Jumlah_PesananLabel = New System.Windows.Forms.Label()
        Total_PembayaranLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.KasirDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_MejaLabel
        '
        Id_MejaLabel.AutoSize = True
        Id_MejaLabel.Location = New System.Drawing.Point(5, 27)
        Id_MejaLabel.Name = "Id_MejaLabel"
        Id_MejaLabel.Size = New System.Drawing.Size(45, 13)
        Id_MejaLabel.TabIndex = 5
        Id_MejaLabel.Text = "Id Meja:"
        '
        'Nama_MakananLabel
        '
        Nama_MakananLabel.AutoSize = True
        Nama_MakananLabel.Location = New System.Drawing.Point(5, 53)
        Nama_MakananLabel.Name = "Nama_MakananLabel"
        Nama_MakananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_MakananLabel.TabIndex = 7
        Nama_MakananLabel.Text = "Nama Makanan:"
        '
        'Harga_MakananLabel
        '
        Harga_MakananLabel.AutoSize = True
        Harga_MakananLabel.Location = New System.Drawing.Point(6, 79)
        Harga_MakananLabel.Name = "Harga_MakananLabel"
        Harga_MakananLabel.Size = New System.Drawing.Size(87, 13)
        Harga_MakananLabel.TabIndex = 9
        Harga_MakananLabel.Text = "Harga Makanan:"
        '
        'Jumlah_PesananLabel
        '
        Jumlah_PesananLabel.AutoSize = True
        Jumlah_PesananLabel.Location = New System.Drawing.Point(6, 107)
        Jumlah_PesananLabel.Name = "Jumlah_PesananLabel"
        Jumlah_PesananLabel.Size = New System.Drawing.Size(88, 13)
        Jumlah_PesananLabel.TabIndex = 11
        Jumlah_PesananLabel.Text = "Jumlah Pesanan:"
        '
        'Total_PembayaranLabel
        '
        Total_PembayaranLabel.AutoSize = True
        Total_PembayaranLabel.Location = New System.Drawing.Point(5, 137)
        Total_PembayaranLabel.Name = "Total_PembayaranLabel"
        Total_PembayaranLabel.Size = New System.Drawing.Size(96, 13)
        Total_PembayaranLabel.TabIndex = 13
        Total_PembayaranLabel.Text = "Total Pembayaran:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.keluarButton)
        Me.GroupBox1.Controls.Add(Me.batalButton)
        Me.GroupBox1.Controls.Add(Me.hapusButton)
        Me.GroupBox1.Controls.Add(Me.simpanButton)
        Me.GroupBox1.Controls.Add(Me.tambahButton)
        Me.GroupBox1.Controls.Add(Me.KasirDataGridView)
        Me.GroupBox1.Controls.Add(Id_MejaLabel)
        Me.GroupBox1.Controls.Add(Me.Id_MejaTextBox)
        Me.GroupBox1.Controls.Add(Nama_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_MakananTextBox)
        Me.GroupBox1.Controls.Add(Harga_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Harga_MakananTextBox)
        Me.GroupBox1.Controls.Add(Jumlah_PesananLabel)
        Me.GroupBox1.Controls.Add(Me.Jumlah_PesananTextBox)
        Me.GroupBox1.Controls.Add(Total_PembayaranLabel)
        Me.GroupBox1.Controls.Add(Me.Total_PembayaranTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 266)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembayaran"
        '
        'keluarButton
        '
        Me.keluarButton.Location = New System.Drawing.Point(669, 205)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(73, 23)
        Me.keluarButton.TabIndex = 19
        Me.keluarButton.Text = "Keluar"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'batalButton
        '
        Me.batalButton.Location = New System.Drawing.Point(455, 205)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(73, 23)
        Me.batalButton.TabIndex = 18
        Me.batalButton.Text = "Batal"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Location = New System.Drawing.Point(231, 205)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(73, 23)
        Me.hapusButton.TabIndex = 17
        Me.hapusButton.Text = "Hapus"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'simpanButton
        '
        Me.simpanButton.Location = New System.Drawing.Point(564, 205)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(73, 23)
        Me.simpanButton.TabIndex = 16
        Me.simpanButton.Text = "Simpan"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'tambahButton
        '
        Me.tambahButton.Location = New System.Drawing.Point(342, 205)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(73, 23)
        Me.tambahButton.TabIndex = 15
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'KasirDataGridView
        '
        Me.KasirDataGridView.AutoGenerateColumns = False
        Me.KasirDataGridView.BackgroundColor = System.Drawing.Color.Aqua
        Me.KasirDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KasirDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.KasirDataGridView.DataSource = Me.KasirBindingSource
        Me.KasirDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.KasirDataGridView.Location = New System.Drawing.Point(215, 19)
        Me.KasirDataGridView.Name = "KasirDataGridView"
        Me.KasirDataGridView.Size = New System.Drawing.Size(544, 180)
        Me.KasirDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id Meja"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Meja"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama Makanan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Makanan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Harga Makanan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Harga Makanan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Jumlah Pesanan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Jumlah Pesanan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total Pembayaran"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Pembayaran"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
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
        'Id_MejaTextBox
        '
        Me.Id_MejaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "Id Meja", True))
        Me.Id_MejaTextBox.Location = New System.Drawing.Point(111, 27)
        Me.Id_MejaTextBox.Name = "Id_MejaTextBox"
        Me.Id_MejaTextBox.Size = New System.Drawing.Size(55, 20)
        Me.Id_MejaTextBox.TabIndex = 6
        '
        'Nama_MakananTextBox
        '
        Me.Nama_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "Nama Makanan", True))
        Me.Nama_MakananTextBox.Location = New System.Drawing.Point(111, 53)
        Me.Nama_MakananTextBox.Name = "Nama_MakananTextBox"
        Me.Nama_MakananTextBox.Size = New System.Drawing.Size(98, 20)
        Me.Nama_MakananTextBox.TabIndex = 8
        '
        'Harga_MakananTextBox
        '
        Me.Harga_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "Harga Makanan", True))
        Me.Harga_MakananTextBox.Location = New System.Drawing.Point(111, 79)
        Me.Harga_MakananTextBox.Name = "Harga_MakananTextBox"
        Me.Harga_MakananTextBox.Size = New System.Drawing.Size(98, 20)
        Me.Harga_MakananTextBox.TabIndex = 10
        '
        'Jumlah_PesananTextBox
        '
        Me.Jumlah_PesananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "Jumlah Pesanan", True))
        Me.Jumlah_PesananTextBox.Location = New System.Drawing.Point(111, 107)
        Me.Jumlah_PesananTextBox.Name = "Jumlah_PesananTextBox"
        Me.Jumlah_PesananTextBox.Size = New System.Drawing.Size(98, 20)
        Me.Jumlah_PesananTextBox.TabIndex = 12
        '
        'Total_PembayaranTextBox
        '
        Me.Total_PembayaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "Total Pembayaran", True))
        Me.Total_PembayaranTextBox.Location = New System.Drawing.Point(111, 137)
        Me.Total_PembayaranTextBox.Name = "Total_PembayaranTextBox"
        Me.Total_PembayaranTextBox.Size = New System.Drawing.Size(98, 20)
        Me.Total_PembayaranTextBox.TabIndex = 14
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
        Me.TableAdapterManager.pelayan_has_pemesananTableAdapter = Nothing
        Me.TableAdapterManager.pelayanTableAdapter = Nothing
        Me.TableAdapterManager.pemesananTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'formPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 294)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formPembayaran"
        Me.Text = "Pembayaran"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.KasirDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Kel_5_si_restoDataSet As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents KasirBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KasirTableAdapter As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter
    Friend WithEvents TableAdapterManager As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_MejaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Harga_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jumlah_PesananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_PembayaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KasirDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keluarButton As System.Windows.Forms.Button
    Friend WithEvents batalButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents tambahButton As System.Windows.Forms.Button
End Class
