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
        Dim Id_mejaLabel As System.Windows.Forms.Label
        Dim Nama_makananLabel As System.Windows.Forms.Label
        Dim Jumlah_pesananLabel As System.Windows.Forms.Label
        Dim Menu_tambahanLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PemesananDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PemesananBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kel_5_si_restoDataSet1 = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.Id_mejaTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_makananTextBox = New System.Windows.Forms.TextBox()
        Me.Jumlah_pesananTextBox = New System.Windows.Forms.TextBox()
        Me.Menu_tambahanTextBox = New System.Windows.Forms.TextBox()
        Me.PemesananTableAdapter1 = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.pemesananTableAdapter()
        Me.TableAdapterManager1 = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Id_mejaLabel = New System.Windows.Forms.Label()
        Nama_makananLabel = New System.Windows.Forms.Label()
        Jumlah_pesananLabel = New System.Windows.Forms.Label()
        Menu_tambahanLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PemesananDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemesananBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kel_5_si_restoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_mejaLabel
        '
        Id_mejaLabel.AutoSize = True
        Id_mejaLabel.Location = New System.Drawing.Point(10, 39)
        Id_mejaLabel.Name = "Id_mejaLabel"
        Id_mejaLabel.Size = New System.Drawing.Size(45, 13)
        Id_mejaLabel.TabIndex = 0
        Id_mejaLabel.Text = "Id Meja:"
        '
        'Nama_makananLabel
        '
        Nama_makananLabel.AutoSize = True
        Nama_makananLabel.Location = New System.Drawing.Point(10, 65)
        Nama_makananLabel.Name = "Nama_makananLabel"
        Nama_makananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_makananLabel.TabIndex = 2
        Nama_makananLabel.Text = "Nama Makanan:"
        '
        'Jumlah_pesananLabel
        '
        Jumlah_pesananLabel.AutoSize = True
        Jumlah_pesananLabel.Location = New System.Drawing.Point(10, 91)
        Jumlah_pesananLabel.Name = "Jumlah_pesananLabel"
        Jumlah_pesananLabel.Size = New System.Drawing.Size(88, 13)
        Jumlah_pesananLabel.TabIndex = 4
        Jumlah_pesananLabel.Text = "Jumlah Pesanan:"
        '
        'Menu_tambahanLabel
        '
        Menu_tambahanLabel.AutoSize = True
        Menu_tambahanLabel.Location = New System.Drawing.Point(10, 117)
        Menu_tambahanLabel.Name = "Menu_tambahanLabel"
        Menu_tambahanLabel.Size = New System.Drawing.Size(91, 13)
        Menu_tambahanLabel.TabIndex = 6
        Menu_tambahanLabel.Text = "Menu Tambahan:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.PemesananDataGridView)
        Me.GroupBox2.Controls.Add(Id_mejaLabel)
        Me.GroupBox2.Controls.Add(Me.Id_mejaTextBox)
        Me.GroupBox2.Controls.Add(Nama_makananLabel)
        Me.GroupBox2.Controls.Add(Me.Nama_makananTextBox)
        Me.GroupBox2.Controls.Add(Jumlah_pesananLabel)
        Me.GroupBox2.Controls.Add(Me.Jumlah_pesananTextBox)
        Me.GroupBox2.Controls.Add(Menu_tambahanLabel)
        Me.GroupBox2.Controls.Add(Me.Menu_tambahanTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(777, 300)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pemesanan"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(80, 233)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(122, 32)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Keluar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(141, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 31)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(141, 155)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 35)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 31)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 35)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PemesananDataGridView
        '
        Me.PemesananDataGridView.AutoGenerateColumns = False
        Me.PemesananDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PemesananDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PemesananDataGridView.DataSource = Me.PemesananBindingSource1
        Me.PemesananDataGridView.Location = New System.Drawing.Point(298, 36)
        Me.PemesananDataGridView.Name = "PemesananDataGridView"
        Me.PemesananDataGridView.Size = New System.Drawing.Size(442, 220)
        Me.PemesananDataGridView.TabIndex = 8
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "jumlah_pesanan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "jumlah_pesanan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "menu_tambahan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "menu_tambahan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'PemesananBindingSource1
        '
        Me.PemesananBindingSource1.DataMember = "pemesanan"
        Me.PemesananBindingSource1.DataSource = Me.Kel_5_si_restoDataSet1
        '
        'Kel_5_si_restoDataSet1
        '
        Me.Kel_5_si_restoDataSet1.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_mejaTextBox
        '
        Me.Id_mejaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource1, "id_meja", True))
        Me.Id_mejaTextBox.Location = New System.Drawing.Point(102, 36)
        Me.Id_mejaTextBox.Name = "Id_mejaTextBox"
        Me.Id_mejaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_mejaTextBox.TabIndex = 1
        '
        'Nama_makananTextBox
        '
        Me.Nama_makananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource1, "nama_makanan", True))
        Me.Nama_makananTextBox.Location = New System.Drawing.Point(102, 62)
        Me.Nama_makananTextBox.Name = "Nama_makananTextBox"
        Me.Nama_makananTextBox.Size = New System.Drawing.Size(190, 20)
        Me.Nama_makananTextBox.TabIndex = 3
        '
        'Jumlah_pesananTextBox
        '
        Me.Jumlah_pesananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource1, "jumlah_pesanan", True))
        Me.Jumlah_pesananTextBox.Location = New System.Drawing.Point(102, 88)
        Me.Jumlah_pesananTextBox.Name = "Jumlah_pesananTextBox"
        Me.Jumlah_pesananTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Jumlah_pesananTextBox.TabIndex = 5
        '
        'Menu_tambahanTextBox
        '
        Me.Menu_tambahanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemesananBindingSource1, "menu_tambahan", True))
        Me.Menu_tambahanTextBox.Location = New System.Drawing.Point(102, 114)
        Me.Menu_tambahanTextBox.Name = "Menu_tambahanTextBox"
        Me.Menu_tambahanTextBox.Size = New System.Drawing.Size(190, 20)
        Me.Menu_tambahanTextBox.TabIndex = 7
        '
        'PemesananTableAdapter1
        '
        Me.PemesananTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.kasirTableAdapter = Nothing
        Me.TableAdapterManager1.menuTableAdapter = Nothing
        Me.TableAdapterManager1.pelayanTableAdapter = Nothing
        Me.TableAdapterManager1.pemesananTableAdapter = Me.PemesananTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'formPemesanan
        '
        Me.ClientSize = New System.Drawing.Size(810, 324)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formPemesanan"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PemesananDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemesananBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kel_5_si_restoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Kel_5_si_restoDataSet As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents PemesananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PemesananTableAdapter As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.pemesananTableAdapter
    Friend WithEvents TableAdapterManager As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents batalButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents keluarButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Kel_5_si_restoDataSet1 As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents PemesananBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PemesananTableAdapter1 As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.pemesananTableAdapter
    Friend WithEvents TableAdapterManager1 As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PemesananDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_mejaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_makananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jumlah_pesananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Menu_tambahanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
