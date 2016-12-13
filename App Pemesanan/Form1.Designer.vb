<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.menuButton = New System.Windows.Forms.Button()
        Me.pemesananButton = New System.Windows.Forms.Button()
        Me.pembayaranButton3 = New System.Windows.Forms.Button()
        Me.infoButton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.infoButton)
        Me.GroupBox1.Controls.Add(Me.pembayaranButton3)
        Me.GroupBox1.Controls.Add(Me.pemesananButton)
        Me.GroupBox1.Controls.Add(Me.menuButton)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 438)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'menuButton
        '
        Me.menuButton.Image = CType(resources.GetObject("menuButton.Image"), System.Drawing.Image)
        Me.menuButton.Location = New System.Drawing.Point(299, 19)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(203, 129)
        Me.menuButton.TabIndex = 0
        Me.menuButton.Text = "Menu"
        Me.menuButton.UseVisualStyleBackColor = True
        '
        'pemesananButton
        '
        Me.pemesananButton.Image = CType(resources.GetObject("pemesananButton.Image"), System.Drawing.Image)
        Me.pemesananButton.Location = New System.Drawing.Point(299, 154)
        Me.pemesananButton.Name = "pemesananButton"
        Me.pemesananButton.Size = New System.Drawing.Size(203, 118)
        Me.pemesananButton.TabIndex = 1
        Me.pemesananButton.Text = "Pemesanan"
        Me.pemesananButton.UseVisualStyleBackColor = True
        '
        'pembayaranButton3
        '
        Me.pembayaranButton3.Image = CType(resources.GetObject("pembayaranButton3.Image"), System.Drawing.Image)
        Me.pembayaranButton3.Location = New System.Drawing.Point(299, 278)
        Me.pembayaranButton3.Name = "pembayaranButton3"
        Me.pembayaranButton3.Size = New System.Drawing.Size(203, 154)
        Me.pembayaranButton3.TabIndex = 2
        Me.pembayaranButton3.Text = "Pembayaran"
        Me.pembayaranButton3.UseVisualStyleBackColor = True
        '
        'infoButton
        '
        Me.infoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.infoButton.Location = New System.Drawing.Point(40, 255)
        Me.infoButton.Name = "infoButton"
        Me.infoButton.Size = New System.Drawing.Size(91, 134)
        Me.infoButton.TabIndex = 3
        Me.infoButton.Text = "More Info"
        Me.infoButton.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(189, 255)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 140)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 206)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 463)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents infoButton As System.Windows.Forms.Button
    Friend WithEvents pembayaranButton3 As System.Windows.Forms.Button
    Friend WithEvents pemesananButton As System.Windows.Forms.Button
    Friend WithEvents menuButton As System.Windows.Forms.Button

End Class
