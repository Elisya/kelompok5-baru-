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
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.menuTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lihatButton = New System.Windows.Forms.Button()
        Me.keluarButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(14, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 204)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabel Menu"
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
        'keluarButton
        '
        Me.keluarButton.Location = New System.Drawing.Point(90, 165)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(75, 23)
        Me.keluarButton.TabIndex = 11
        Me.keluarButton.Text = "Keluar"
        Me.keluarButton.UseVisualStyleBackColor = True
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
        'simpanButton
        '
        Me.simpanButton.Location = New System.Drawing.Point(90, 136)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(75, 23)
        Me.simpanButton.TabIndex = 9
        Me.simpanButton.Text = "Simpan"
        Me.simpanButton.UseVisualStyleBackColor = True
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
        'formmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 464)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formmenu"
        Me.Text = "Menu"
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
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
End Class
