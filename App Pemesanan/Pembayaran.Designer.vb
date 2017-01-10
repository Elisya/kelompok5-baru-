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
        Id_mejaLabel = New System.Windows.Forms.Label()
        Nama_makananLabel = New System.Windows.Forms.Label()
        Harga_makananLabel = New System.Windows.Forms.Label()
        Jumlah_pesananLabel = New System.Windows.Forms.Label()
        Total_pembayaranLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasirDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
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
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
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
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "total_pembayaran"
        Me.DataGridViewTextBoxColumn5.HeaderText = "total_pembayaran"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Id_mejaLabel
        '
        Id_mejaLabel.AutoSize = True
        Id_mejaLabel.Location = New System.Drawing.Point(15, 19)
        Id_mejaLabel.Name = "Id_mejaLabel"
        Id_mejaLabel.Size = New System.Drawing.Size(43, 13)
        Id_mejaLabel.TabIndex = 6
        Id_mejaLabel.Text = "id meja:"
        '
        'Id_mejaTextBox
        '
        Me.Id_mejaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KasirBindingSource, "id_meja", True))
        Me.Id_mejaTextBox.Location = New System.Drawing.Point(112, 16)
        Me.Id_mejaTextBox.Name = "Id_mejaTextBox"
        Me.Id_mejaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_mejaTextBox.TabIndex = 7
        '
        'Nama_makananLabel
        '
        Nama_makananLabel.AutoSize = True
        Nama_makananLabel.Location = New System.Drawing.Point(15, 45)
        Nama_makananLabel.Name = "Nama_makananLabel"
        Nama_makananLabel.Size = New System.Drawing.Size(83, 13)
        Nama_makananLabel.TabIndex = 8
        Nama_makananLabel.Text = "nama makanan:"
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

