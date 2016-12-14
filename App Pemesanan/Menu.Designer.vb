<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formmenu
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
        Dim Id_MakananLabel As System.Windows.Forms.Label
        Dim Nama_MakananLabel As System.Windows.Forms.Label
        Dim Harga_MakananLabel As System.Windows.Forms.Label
        Dim Pelayan_Id_PelayanLabel As System.Windows.Forms.Label
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.menuTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_MakananTextBox = New System.Windows.Forms.TextBox()
        Me.Pelayan_Id_PelayanTextBox = New System.Windows.Forms.TextBox()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.keluarButton = New System.Windows.Forms.Button()
        Me.lihatButton = New System.Windows.Forms.Button()
        Id_MakananLabel = New System.Windows.Forms.Label()
        Nama_MakananLabel = New System.Windows.Forms.Label()
        Harga_MakananLabel = New System.Windows.Forms.Label()
        Pelayan_Id_PelayanLabel = New System.Windows.Forms.Label()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kel_5_si_restoDataSet
        '
        Me.Kel_5_si_restoDataSet.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "menu"
        Me.MenuBindingSource.DataSource = Me.Kel_5_si_restoDataSet
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kasirTableAdapter = Nothing
        Me.TableAdapterManager.menuTableAdapter = Me.MenuTableAdapter
        Me.TableAdapterManager.pelayan_has_pemesananTableAdapter = Nothing
        Me.TableAdapterManager.pelayanTableAdapter = Nothing
        Me.TableAdapterManager.pemesananTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lihatButton)
        Me.GroupBox1.Controls.Add(Me.keluarButton)
        Me.GroupBox1.Controls.Add(Me.hapusButton)
        Me.GroupBox1.Controls.Add(Me.simpanButton)
        Me.GroupBox1.Controls.Add(Me.tambahButton)
        Me.GroupBox1.Controls.Add(Id_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Id_MakananTextBox)
        Me.GroupBox1.Controls.Add(Nama_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_MakananTextBox)
        Me.GroupBox1.Controls.Add(Harga_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Harga_MakananTextBox)
        Me.GroupBox1.Controls.Add(Pelayan_Id_PelayanLabel)
        Me.GroupBox1.Controls.Add(Me.Pelayan_Id_PelayanTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 204)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabel Menu"
        '
        'MenuDataGridView
        '
        Me.MenuDataGridView.AutoGenerateColumns = False
        Me.MenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MenuDataGridView.DataSource = Me.MenuBindingSource
        Me.MenuDataGridView.Location = New System.Drawing.Point(18, 224)
        Me.MenuDataGridView.Name = "MenuDataGridView"
        Me.MenuDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.MenuDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id Makanan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Makanan"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Pelayan_Id Pelayan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Pelayan_Id Pelayan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Id_MakananLabel
        '
        Id_MakananLabel.AutoSize = True
        Id_MakananLabel.Location = New System.Drawing.Point(6, 24)
        Id_MakananLabel.Name = "Id_MakananLabel"
        Id_MakananLabel.Size = New System.Drawing.Size(67, 13)
        Id_MakananLabel.TabIndex = 0
        Id_MakananLabel.Text = "Id Makanan:"
        '
        'Id_MakananTextBox
        '
        Me.Id_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Id Makanan", True))
        Me.Id_MakananTextBox.Location = New System.Drawing.Point(109, 21)
        Me.Id_MakananTextBox.Name = "Id_MakananTextBox"
        Me.Id_MakananTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Id_MakananTextBox.TabIndex = 1
        '
        'Nama_MakananLabel
        '
        Nama_MakananLabel.AutoSize = True
        Nama_MakananLabel.Location = New System.Drawing.Point(6, 50)
        Nama_MakananLabel.Name = "Nama_MakananLabel"
        Nama_MakananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_MakananLabel.TabIndex = 2
        Nama_MakananLabel.Text = "Nama Makanan:"
        '
        'Nama_MakananTextBox
        '
        Me.Nama_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Nama Makanan", True))
        Me.Nama_MakananTextBox.Location = New System.Drawing.Point(109, 47)
        Me.Nama_MakananTextBox.Name = "Nama_MakananTextBox"
        Me.Nama_MakananTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Nama_MakananTextBox.TabIndex = 3
        '
        'Harga_MakananLabel
        '
        Harga_MakananLabel.AutoSize = True
        Harga_MakananLabel.Location = New System.Drawing.Point(6, 76)
        Harga_MakananLabel.Name = "Harga_MakananLabel"
        Harga_MakananLabel.Size = New System.Drawing.Size(87, 13)
        Harga_MakananLabel.TabIndex = 4
        Harga_MakananLabel.Text = "Harga Makanan:"
        '
        'Harga_MakananTextBox
        '
        Me.Harga_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Harga Makanan", True))
        Me.Harga_MakananTextBox.Location = New System.Drawing.Point(109, 73)
        Me.Harga_MakananTextBox.Name = "Harga_MakananTextBox"
        Me.Harga_MakananTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Harga_MakananTextBox.TabIndex = 5
        '
        'Pelayan_Id_PelayanLabel
        '
        Pelayan_Id_PelayanLabel.AutoSize = True
        Pelayan_Id_PelayanLabel.Location = New System.Drawing.Point(6, 102)
        Pelayan_Id_PelayanLabel.Name = "Pelayan_Id_PelayanLabel"
        Pelayan_Id_PelayanLabel.Size = New System.Drawing.Size(101, 13)
        Pelayan_Id_PelayanLabel.TabIndex = 6
        Pelayan_Id_PelayanLabel.Text = "Pelayan Id Pelayan:"
        '
        'Pelayan_Id_PelayanTextBox
        '
        Me.Pelayan_Id_PelayanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Pelayan_Id Pelayan", True))
        Me.Pelayan_Id_PelayanTextBox.Location = New System.Drawing.Point(109, 99)
        Me.Pelayan_Id_PelayanTextBox.Name = "Pelayan_Id_PelayanTextBox"
        Me.Pelayan_Id_PelayanTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Pelayan_Id_PelayanTextBox.TabIndex = 7
        '
        'tambahButton
        '
        Me.tambahButton.Location = New System.Drawing.Point(9, 136)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(75, 23)
        Me.tambahButton.TabIndex = 8
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'simpanButton
        '
        Me.simpanButton.Location = New System.Drawing.Point(90, 136)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(75, 23)
        Me.simpanButton.TabIndex = 9
        Me.simpanButton.Text = "Simpan"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Location = New System.Drawing.Point(9, 165)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(75, 23)
        Me.hapusButton.TabIndex = 10
        Me.hapusButton.Text = "Hapus"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'keluarButton
        '
        Me.keluarButton.Location = New System.Drawing.Point(90, 165)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(75, 23)
        Me.keluarButton.TabIndex = 11
        Me.keluarButton.Text = "Keluar"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'lihatButton
        '
        Me.lihatButton.Location = New System.Drawing.Point(318, 136)
        Me.lihatButton.Name = "lihatButton"
        Me.lihatButton.Size = New System.Drawing.Size(124, 62)
        Me.lihatButton.TabIndex = 12
        Me.lihatButton.Text = "Lihat Menu"
        Me.lihatButton.UseVisualStyleBackColor = True
        '
        'formmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 464)
        Me.Controls.Add(Me.MenuDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formmenu"
        Me.Text = "Menu"
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Kel_5_si_restoDataSet As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.menuTableAdapter
    Friend WithEvents TableAdapterManager As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lihatButton As System.Windows.Forms.Button
    Friend WithEvents keluarButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents Id_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Harga_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pelayan_Id_PelayanTextBox As System.Windows.Forms.TextBox
End Class
