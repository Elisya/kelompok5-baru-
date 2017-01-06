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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.keluarButton = New System.Windows.Forms.Button()
        Me.batalButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.PemesananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kel_5_si_restoDataSet = New App_Pemesanan.kel_5_si_restoDataSet()
        Me.PemesananTableAdapter = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.pemesananTableAdapter()
        Me.TableAdapterManager = New App_Pemesanan.kel_5_si_restoDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.keluarButton)
        Me.GroupBox1.Controls.Add(Me.batalButton)
        Me.GroupBox1.Controls.Add(Me.simpanButton)
        Me.GroupBox1.Controls.Add(Me.hapusButton)
        Me.GroupBox1.Controls.Add(Me.tambahButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1070, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pemesanan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(947, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'keluarButton
        '
        Me.keluarButton.Location = New System.Drawing.Point(145, 260)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(75, 23)
        Me.keluarButton.TabIndex = 19
        Me.keluarButton.Text = "Keluar"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'batalButton
        '
        Me.batalButton.Location = New System.Drawing.Point(41, 260)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(75, 23)
        Me.batalButton.TabIndex = 18
        Me.batalButton.Text = "Batal"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'simpanButton
        '
        Me.simpanButton.Location = New System.Drawing.Point(189, 216)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(75, 23)
        Me.simpanButton.TabIndex = 17
        Me.simpanButton.Text = "Simpan"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Location = New System.Drawing.Point(96, 216)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(75, 23)
        Me.hapusButton.TabIndex = 16
        Me.hapusButton.Text = "Hapus"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'tambahButton
        '
        Me.tambahButton.Location = New System.Drawing.Point(6, 216)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(75, 23)
        Me.tambahButton.TabIndex = 15
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.UseVisualStyleBackColor = True
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
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kel_5_si_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
