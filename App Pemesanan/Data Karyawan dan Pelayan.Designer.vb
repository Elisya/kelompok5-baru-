<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formpelayan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formpelayan))
        Dim Id_pelayanLabel As System.Windows.Forms.Label
        Dim Nama_pelayanLabel As System.Windows.Forms.Label
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.PelayanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PelayanTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.pelayanTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PelayanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_pelayanTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_pelayanTextBox = New System.Windows.Forms.TextBox()
        Id_pelayanLabel = New System.Windows.Forms.Label()
        Nama_pelayanLabel = New System.Windows.Forms.Label()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelayanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PelayanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kel_5_si_restoDataSet
        '
        Me.Kel_5_si_restoDataSet.DataSetName = "kel_5_si_restoDataSet"
        Me.Kel_5_si_restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PelayanBindingSource
        '
        Me.PelayanBindingSource.DataMember = "pelayan"
        Me.PelayanBindingSource.DataSource = Me.Kel_5_si_restoDataSet
        '
        'PelayanTableAdapter
        '
        Me.PelayanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kasirTableAdapter = Nothing
        Me.TableAdapterManager.menuTableAdapter = Nothing
        Me.TableAdapterManager.pelayanTableAdapter = Me.PelayanTableAdapter
        Me.TableAdapterManager.pemesananTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.PelayanDataGridView)
        Me.GroupBox1.Controls.Add(Id_pelayanLabel)
        Me.GroupBox1.Controls.Add(Me.Id_pelayanTextBox)
        Me.GroupBox1.Controls.Add(Nama_pelayanLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_pelayanTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 322)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data "
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(8, 154)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 31)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Keluar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(7, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 26)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 26)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PelayanDataGridView
        '
        Me.PelayanDataGridView.AutoGenerateColumns = False
        Me.PelayanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PelayanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.PelayanDataGridView.DataSource = Me.PelayanBindingSource
        Me.PelayanDataGridView.Location = New System.Drawing.Point(118, 75)
        Me.PelayanDataGridView.Name = "PelayanDataGridView"
        Me.PelayanDataGridView.Size = New System.Drawing.Size(244, 214)
        Me.PelayanDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_pelayan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_pelayan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_pelayan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_pelayan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Id_pelayanLabel
        '
        Id_pelayanLabel.AutoSize = True
        Id_pelayanLabel.Location = New System.Drawing.Point(13, 26)
        Id_pelayanLabel.Name = "Id_pelayanLabel"
        Id_pelayanLabel.Size = New System.Drawing.Size(58, 13)
        Id_pelayanLabel.TabIndex = 19
        Id_pelayanLabel.Text = "id pelayan:"
        '
        'Id_pelayanTextBox
        '
        Me.Id_pelayanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelayanBindingSource, "id_pelayan", True))
        Me.Id_pelayanTextBox.Location = New System.Drawing.Point(95, 23)
        Me.Id_pelayanTextBox.Name = "Id_pelayanTextBox"
        Me.Id_pelayanTextBox.Size = New System.Drawing.Size(272, 20)
        Me.Id_pelayanTextBox.TabIndex = 20
        '
        'Nama_pelayanLabel
        '
        Nama_pelayanLabel.AutoSize = True
        Nama_pelayanLabel.Location = New System.Drawing.Point(13, 52)
        Nama_pelayanLabel.Name = "Nama_pelayanLabel"
        Nama_pelayanLabel.Size = New System.Drawing.Size(76, 13)
        Nama_pelayanLabel.TabIndex = 21
        Nama_pelayanLabel.Text = "nama pelayan:"
        '
        'Nama_pelayanTextBox
        '
        Me.Nama_pelayanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelayanBindingSource, "nama_pelayan", True))
        Me.Nama_pelayanTextBox.Location = New System.Drawing.Point(95, 49)
        Me.Nama_pelayanTextBox.Name = "Nama_pelayanTextBox"
        Me.Nama_pelayanTextBox.Size = New System.Drawing.Size(272, 20)
        Me.Nama_pelayanTextBox.TabIndex = 23
        '
        'formpelayan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(410, 346)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formpelayan"
        Me.Text = "Data_Karyawan_dan_Pelayan"
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelayanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PelayanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Kel_5_si_restoDataSet As App_Pemesanan.kel_5_si_restoDataSet
    Friend WithEvents PelayanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PelayanTableAdapter As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.pelayanTableAdapter
    Friend WithEvents TableAdapterManager As App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PelayanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_pelayanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_pelayanTextBox As System.Windows.Forms.TextBox
End Class
