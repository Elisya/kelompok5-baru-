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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Nama_makananLabel As System.Windows.Forms.Label
        Dim Harga_makananLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Kel_5_si_restoDataSet1 = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.MenuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTableAdapter1 = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.menuTableAdapter()
        Me.TableAdapterManager1 = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.IdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Nama_makananTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Harga_makananTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MenuDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Nama_makananLabel = New System.Windows.Forms.Label()
        Harga_makananLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Kel_5_si_restoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nama_makananTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Harga_makananTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(IdLabel)
        Me.GroupBox2.Controls.Add(Me.IdSpinEdit)
        Me.GroupBox2.Controls.Add(Nama_makananLabel)
        Me.GroupBox2.Controls.Add(Me.Nama_makananTextEdit)
        Me.GroupBox2.Controls.Add(Harga_makananLabel)
        Me.GroupBox2.Controls.Add(Me.Harga_makananTextEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 235)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Kel_5_si_restoDataSet1
        '
        Me.Kel_5_si_restoDataSet1.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuBindingSource1
        '
        Me.MenuBindingSource1.DataMember = "menu"
        Me.MenuBindingSource1.DataSource = Me.Kel_5_si_restoDataSet1
        '
        'MenuTableAdapter1
        '
        Me.MenuTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.kasirTableAdapter = Nothing
        Me.TableAdapterManager1.menuTableAdapter = Me.MenuTableAdapter1
        Me.TableAdapterManager1.pelayanTableAdapter = Nothing
        Me.TableAdapterManager1.pemesananTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(10, 31)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'IdSpinEdit
        '
        Me.IdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MenuBindingSource1, "id", True))
        Me.IdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdSpinEdit.Location = New System.Drawing.Point(100, 28)
        Me.IdSpinEdit.Name = "IdSpinEdit"
        Me.IdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdSpinEdit.Size = New System.Drawing.Size(133, 20)
        Me.IdSpinEdit.TabIndex = 1
        '
        'Nama_makananLabel
        '
        Nama_makananLabel.AutoSize = True
        Nama_makananLabel.Location = New System.Drawing.Point(10, 57)
        Nama_makananLabel.Name = "Nama_makananLabel"
        Nama_makananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_makananLabel.TabIndex = 2
        Nama_makananLabel.Text = "Nama Makanan:"
        '
        'Nama_makananTextEdit
        '
        Me.Nama_makananTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MenuBindingSource1, "nama_makanan", True))
        Me.Nama_makananTextEdit.Location = New System.Drawing.Point(100, 54)
        Me.Nama_makananTextEdit.Name = "Nama_makananTextEdit"
        Me.Nama_makananTextEdit.Size = New System.Drawing.Size(167, 20)
        Me.Nama_makananTextEdit.TabIndex = 3
        '
        'Harga_makananLabel
        '
        Harga_makananLabel.AutoSize = True
        Harga_makananLabel.Location = New System.Drawing.Point(10, 83)
        Harga_makananLabel.Name = "Harga_makananLabel"
        Harga_makananLabel.Size = New System.Drawing.Size(87, 13)
        Harga_makananLabel.TabIndex = 4
        Harga_makananLabel.Text = "Harga Makanan:"
        '
        'Harga_makananTextEdit
        '
        Me.Harga_makananTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MenuBindingSource1, "harga_makanan", True))
        Me.Harga_makananTextEdit.Location = New System.Drawing.Point(100, 80)
        Me.Harga_makananTextEdit.Name = "Harga_makananTextEdit"
        Me.Harga_makananTextEdit.Size = New System.Drawing.Size(167, 20)
        Me.Harga_makananTextEdit.TabIndex = 5
        '
        'MenuDataGridView
        '
        Me.MenuDataGridView.AutoGenerateColumns = False
        Me.MenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.MenuDataGridView.DataSource = Me.MenuBindingSource1
        Me.MenuDataGridView.Location = New System.Drawing.Point(26, 254)
        Me.MenuDataGridView.Name = "MenuDataGridView"
        Me.MenuDataGridView.Size = New System.Drawing.Size(346, 220)
        Me.MenuDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
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
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(79, 189)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(122, 32)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Keluar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(140, 152)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 31)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(140, 111)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 35)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 31)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 35)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Lihat Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formmenu
        '
        Me.ClientSize = New System.Drawing.Size(415, 486)
        Me.Controls.Add(Me.MenuDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formmenu"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Kel_5_si_restoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nama_makananTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Harga_makananTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Kel_5_si_restoDataSet As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.menuTableAdapter
    Friend WithEvents TableAdapterManager As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lihatButton As System.Windows.Forms.Button
    Friend WithEvents keluarButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Kel_5_si_restoDataSet1 As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents MenuBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter1 As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.menuTableAdapter
    Friend WithEvents TableAdapterManager1 As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Nama_makananTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Harga_makananTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MenuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
