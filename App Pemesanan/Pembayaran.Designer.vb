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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.keluarButton = New System.Windows.Forms.Button()
        Me.batalButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.KasirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.KasirTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.kasirTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.keluarButton)
        Me.GroupBox1.Controls.Add(Me.batalButton)
        Me.GroupBox1.Controls.Add(Me.hapusButton)
        Me.GroupBox1.Controls.Add(Me.simpanButton)
        Me.GroupBox1.Controls.Add(Me.tambahButton)
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
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
