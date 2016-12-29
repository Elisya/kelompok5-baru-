<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPemesanan
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
        Dim Jumlah_PesananLabel As System.Windows.Forms.Label
        Dim Menu_TambahanLabel As System.Windows.Forms.Label
        Dim Menu_Id_MakananLabel As System.Windows.Forms.Label
        Dim Kasir_Id_MejaLabel As System.Windows.Forms.Label
        Dim Pelayan_Id_PelayanLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.keluarButton = New System.Windows.Forms.Button()
        Me.batalButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.Id_MejaTextBox = New System.Windows.Forms.TextBox()
        Me.PemesananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.Nama_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Jumlah_PesananTextBox = New System.Windows.Forms.TextBox()
        Me.Menu_TambahanTextBox = New System.Windows.Forms.TextBox()
        Me.Menu_Id_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Kasir_Id_MejaTextBox = New System.Windows.Forms.TextBox()
        Me.Pelayan_Id_PelayanTextBox = New System.Windows.Forms.TextBox()
        Me.PemesananDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PemesananTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.pemesananTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Id_MejaLabel = New System.Windows.Forms.Label()
        Nama_MakananLabel = New System.Windows.Forms.Label()
        Jumlah_PesananLabel = New System.Windows.Forms.Label()
        Menu_TambahanLabel = New System.Windows.Forms.Label()
        Menu_Id_MakananLabel = New System.Windows.Forms.Label()
        Kasir_Id_MejaLabel = New System.Windows.Forms.Label()
        Pelayan_Id_PelayanLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemesananDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_MejaLabel
        '
        Id_MejaLabel.AutoSize = True
        Id_MejaLabel.Location = New System.Drawing.Point(6, 19)
        Id_MejaLabel.Name = "Id_MejaLabel"
        Id_MejaLabel.Size = New System.Drawing.Size(45, 13)
        Id_MejaLabel.TabIndex = 1
        Id_MejaLabel.Text = "Id Meja:"
        '
        'Nama_MakananLabel
        '
        Nama_MakananLabel.AutoSize = True
        Nama_MakananLabel.Location = New System.Drawing.Point(6, 45)
        Nama_MakananLabel.Name = "Nama_MakananLabel"
        Nama_MakananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_MakananLabel.TabIndex = 3
        Nama_MakananLabel.Text = "Nama Makanan:"
        '
        'Jumlah_PesananLabel
        '
        Jumlah_PesananLabel.AutoSize = True
        Jumlah_PesananLabel.Location = New System.Drawing.Point(6, 71)
        Jumlah_PesananLabel.Name = "Jumlah_PesananLabel"
        Jumlah_PesananLabel.Size = New System.Drawing.Size(88, 13)
        Jumlah_PesananLabel.TabIndex = 5
        Jumlah_PesananLabel.Text = "Jumlah Pesanan:"
        '
        'Menu_TambahanLabel
        '
        Menu_TambahanLabel.AutoSize = True
        Menu_TambahanLabel.Location = New System.Drawing.Point(6, 97)
        Menu_TambahanLabel.Name = "Menu_TambahanLabel"
        Menu_TambahanLabel.Size = New System.Drawing.Size(91, 13)
        Menu_TambahanLabel.TabIndex = 7
        Menu_TambahanLabel.Text = "Menu Tambahan:"
        '
        'Menu_Id_MakananLabel
        '
        Menu_Id_MakananLabel.AutoSize = True
        Menu_Id_MakananLabel.Location = New System.Drawing.Point(6, 123)
        Menu_Id_MakananLabel.Name = "Menu_Id_MakananLabel"
        Menu_Id_MakananLabel.Size = New System.Drawing.Size(97, 13)
        Menu_Id_MakananLabel.TabIndex = 9
        Menu_Id_MakananLabel.Text = "Menu Id Makanan:"
        '
        'Kasir_Id_MejaLabel
        '
        Kasir_Id_MejaLabel.AutoSize = True
        Kasir_Id_MejaLabel.Location = New System.Drawing.Point(6, 149)
        Kasir_Id_MejaLabel.Name = "Kasir_Id_MejaLabel"
        Kasir_Id_MejaLabel.Size = New System.Drawing.Size(71, 13)
        Kasir_Id_MejaLabel.TabIndex = 11
        Kasir_Id_MejaLabel.Text = "Kasir Id Meja:"
        '
        'Pelayan_Id_PelayanLabel
        '
        Pelayan_Id_PelayanLabel.AutoSize = True
        Pelayan_Id_PelayanLabel.Location = New System.Drawing.Point(6, 175)
        Pelayan_Id_PelayanLabel.Name = "Pelayan_Id_PelayanLabel"
        Pelayan_Id_PelayanLabel.Size = New System.Drawing.Size(101, 13)
        Pelayan_Id_PelayanLabel.TabIndex = 13
        Pelayan_Id_PelayanLabel.Text = "Pelayan Id Pelayan:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.GroupBox1.Controls.Add(Me.keluarButton)
        Me.GroupBox1.Controls.Add(Me.batalButton)
        Me.GroupBox1.Controls.Add(Me.simpanButton)
        Me.GroupBox1.Controls.Add(Me.hapusButton)
        Me.GroupBox1.Controls.Add(Me.tambahButton)
        Me.GroupBox1.Controls.Add(Id_MejaLabel)
        Me.GroupBox1.Controls.Add(Me.Id_MejaTextBox)
        Me.GroupBox1.Controls.Add(Nama_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_MakananTextBox)
        Me.GroupBox1.Controls.Add(Jumlah_PesananLabel)
        Me.GroupBox1.Controls.Add(Me.Jumlah_PesananTextBox)
        Me.GroupBox1.Controls.Add(Menu_TambahanLabel)
        Me.GroupBox1.Controls.Add(Me.Menu_TambahanTextBox)
        Me.GroupBox1.Controls.Add(Menu_Id_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Menu_Id_MakananTextBox)
        Me.GroupBox1.Controls.Add(Kasir_Id_MejaLabel)
        Me.GroupBox1.Controls.Add(Me.Kasir_Id_MejaTextBox)
        Me.GroupBox1.Controls.Add(Pelayan_Id_PelayanLabel)
        Me.GroupBox1.Controls.Add(Me.Pelayan_Id_PelayanTextBox)
        Me.GroupBox1.Controls.Add(Me.PemesananDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1070, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pemesanan"
        '
        'keluarButton
        '
        Me.keluarButton.Location = New System.Drawing.Point(150, 260)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(75, 23)
        Me.keluarButton.TabIndex = 19
        Me.keluarButton.Text = "Keluar"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'batalButton
        '
        Me.batalButton.Location = New System.Drawing.Point(47, 260)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(75, 23)
        Me.batalButton.TabIndex = 18
        Me.batalButton.Text = "Batal"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'simpanButton
        '
        Me.simpanButton.Location = New System.Drawing.Point(189, 231)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(75, 23)
        Me.simpanButton.TabIndex = 17
        Me.simpanButton.Text = "Simpan"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Location = New System.Drawing.Point(96, 231)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(75, 23)
        Me.hapusButton.TabIndex = 16
        Me.hapusButton.Text = "Hapus"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'tambahButton
        '
        Me.tambahButton.Location = New System.Drawing.Point(6, 231)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(75, 23)
        Me.tambahButton.TabIndex = 15
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'Id_MejaTextBox
        '
        Me.Id_MejaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource, "Id Meja", True))
        Me.Id_MejaTextBox.Location = New System.Drawing.Point(113, 16)
        Me.Id_MejaTextBox.Name = "Id_MejaTextBox"
        Me.Id_MejaTextBox.Size = New System.Drawing.Size(58, 20)
        Me.Id_MejaTextBox.TabIndex = 2
        '
        'PemesananBindingSource
        '
        Me.PemesananBindingSource.DataMember = "pemesanan"
        Me.PemesananBindingSource.DataSource = Me.Kel_5_si_restoDataSet
        '
        'Kel_5_si_restoDataSet
        '
        Me.Kel_5_si_restoDataSet.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nama_MakananTextBox
        '
        Me.Nama_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource, "Nama Makanan", True))
        Me.Nama_MakananTextBox.Location = New System.Drawing.Point(113, 42)
        Me.Nama_MakananTextBox.Name = "Nama_MakananTextBox"
        Me.Nama_MakananTextBox.Size = New System.Drawing.Size(171, 20)
        Me.Nama_MakananTextBox.TabIndex = 4
        '
        'Jumlah_PesananTextBox
        '
        Me.Jumlah_PesananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource, "Jumlah Pesanan", True))
        Me.Jumlah_PesananTextBox.Location = New System.Drawing.Point(113, 68)
        Me.Jumlah_PesananTextBox.Name = "Jumlah_PesananTextBox"
        Me.Jumlah_PesananTextBox.Size = New System.Drawing.Size(58, 20)
        Me.Jumlah_PesananTextBox.TabIndex = 6
        '
        'Menu_TambahanTextBox
        '
        Me.Menu_TambahanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource, "Menu Tambahan", True))
        Me.Menu_TambahanTextBox.Location = New System.Drawing.Point(113, 94)
        Me.Menu_TambahanTextBox.Name = "Menu_TambahanTextBox"
        Me.Menu_TambahanTextBox.Size = New System.Drawing.Size(171, 20)
        Me.Menu_TambahanTextBox.TabIndex = 8
        '
        'Menu_Id_MakananTextBox
        '
        Me.Menu_Id_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource, "Menu_Id Makanan", True))
        Me.Menu_Id_MakananTextBox.Location = New System.Drawing.Point(113, 120)
        Me.Menu_Id_MakananTextBox.Name = "Menu_Id_MakananTextBox"
        Me.Menu_Id_MakananTextBox.Size = New System.Drawing.Size(58, 20)
        Me.Menu_Id_MakananTextBox.TabIndex = 10
        '
        'Kasir_Id_MejaTextBox
        '
        Me.Kasir_Id_MejaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource, "Kasir_Id Meja", True))
        Me.Kasir_Id_MejaTextBox.Location = New System.Drawing.Point(113, 146)
        Me.Kasir_Id_MejaTextBox.Name = "Kasir_Id_MejaTextBox"
        Me.Kasir_Id_MejaTextBox.Size = New System.Drawing.Size(58, 20)
        Me.Kasir_Id_MejaTextBox.TabIndex = 12
        '
        'Pelayan_Id_PelayanTextBox
        '
        Me.Pelayan_Id_PelayanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource, "Pelayan_Id Pelayan", True))
        Me.Pelayan_Id_PelayanTextBox.Location = New System.Drawing.Point(113, 172)
        Me.Pelayan_Id_PelayanTextBox.Name = "Pelayan_Id_PelayanTextBox"
        Me.Pelayan_Id_PelayanTextBox.Size = New System.Drawing.Size(58, 20)
        Me.Pelayan_Id_PelayanTextBox.TabIndex = 14
        '
        'PemesananDataGridView
        '
        Me.PemesananDataGridView.AutoGenerateColumns = False
        Me.PemesananDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PemesananDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PemesananDataGridView.DataSource = Me.PemesananBindingSource
        Me.PemesananDataGridView.Location = New System.Drawing.Point(300, 19)
        Me.PemesananDataGridView.Name = "PemesananDataGridView"
        Me.PemesananDataGridView.Size = New System.Drawing.Size(738, 264)
        Me.PemesananDataGridView.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Jumlah Pesanan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jumlah Pesanan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Menu Tambahan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Menu Tambahan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Menu_Id Makanan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Menu_Id Makanan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Kasir_Id Meja"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kasir_Id Meja"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Pelayan_Id Pelayan"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pelayan_Id Pelayan"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'PemesananTableAdapter
        '
        Me.PemesananTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kasirTableAdapter = Nothing
        Me.TableAdapterManager.menuTableAdapter = Nothing
        Me.TableAdapterManager.pelayan_has_pemesananTableAdapter = Nothing
        Me.TableAdapterManager.pelayanTableAdapter = Nothing
        Me.TableAdapterManager.pemesananTableAdapter = Me.PemesananTableAdapter
        Me.TableAdapterManager.UpdateOrder = App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'formPemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 317)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formPemesanan"
        Me.Text = "Pemesanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemesananDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Kel_5_si_restoDataSet As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents PemesananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PemesananTableAdapter As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.pemesananTableAdapter
    Friend WithEvents TableAdapterManager As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PemesananDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents batalButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents Id_MejaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jumlah_PesananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Menu_TambahanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Menu_Id_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kasir_Id_MejaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pelayan_Id_PelayanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents keluarButton As System.Windows.Forms.Button
End Class
