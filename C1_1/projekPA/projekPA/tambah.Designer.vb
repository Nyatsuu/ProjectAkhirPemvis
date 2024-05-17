<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah
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
        Me.tgKategori = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bekas = New System.Windows.Forms.RadioButton()
        Me.gbkondisi = New System.Windows.Forms.GroupBox()
        Me.baru = New System.Windows.Forms.RadioButton()
        Me.tbtgl = New System.Windows.Forms.DateTimePicker()
        Me.tambah_data = New System.Windows.Forms.Button()
        Me.tbtambah = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbharga = New System.Windows.Forms.TextBox()
        Me.lihat = New System.Windows.Forms.Button()
        Me.gbkondisi.SuspendLayout()
        Me.SuspendLayout()
        '
        'tgKategori
        '
        Me.tgKategori.FormattingEnabled = True
        Me.tgKategori.Items.AddRange(New Object() {"Badminton", "Futsal", "Voli"})
        Me.tgKategori.Location = New System.Drawing.Point(309, 184)
        Me.tgKategori.Name = "tgKategori"
        Me.tgKategori.Size = New System.Drawing.Size(233, 24)
        Me.tgKategori.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 29)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "TAMBAH DATA BARANG"
        '
        'bekas
        '
        Me.bekas.AutoSize = True
        Me.bekas.Location = New System.Drawing.Point(186, 33)
        Me.bekas.Name = "bekas"
        Me.bekas.Size = New System.Drawing.Size(68, 21)
        Me.bekas.TabIndex = 1
        Me.bekas.TabStop = True
        Me.bekas.Text = "Bekas"
        Me.bekas.UseVisualStyleBackColor = True
        '
        'gbkondisi
        '
        Me.gbkondisi.Controls.Add(Me.bekas)
        Me.gbkondisi.Controls.Add(Me.baru)
        Me.gbkondisi.Location = New System.Drawing.Point(200, 258)
        Me.gbkondisi.Name = "gbkondisi"
        Me.gbkondisi.Size = New System.Drawing.Size(344, 72)
        Me.gbkondisi.TabIndex = 27
        Me.gbkondisi.TabStop = False
        Me.gbkondisi.Text = "Kondisi"
        '
        'baru
        '
        Me.baru.AutoSize = True
        Me.baru.Location = New System.Drawing.Point(80, 33)
        Me.baru.Name = "baru"
        Me.baru.Size = New System.Drawing.Size(59, 21)
        Me.baru.TabIndex = 0
        Me.baru.TabStop = True
        Me.baru.Text = "Baru"
        Me.baru.UseVisualStyleBackColor = True
        '
        'tbtgl
        '
        Me.tbtgl.Location = New System.Drawing.Point(309, 144)
        Me.tbtgl.Name = "tbtgl"
        Me.tbtgl.Size = New System.Drawing.Size(235, 22)
        Me.tbtgl.TabIndex = 26
        '
        'tambah_data
        '
        Me.tambah_data.Location = New System.Drawing.Point(200, 348)
        Me.tambah_data.Name = "tambah_data"
        Me.tambah_data.Size = New System.Drawing.Size(141, 53)
        Me.tambah_data.TabIndex = 25
        Me.tambah_data.Text = "Tambah"
        Me.tambah_data.UseVisualStyleBackColor = True
        '
        'tbtambah
        '
        Me.tbtambah.Location = New System.Drawing.Point(309, 102)
        Me.tbtambah.Name = "tbtambah"
        Me.tbtambah.Size = New System.Drawing.Size(235, 22)
        Me.tbtambah.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Kategori Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Tanggal Masuk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nama Barang"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Harga"
        '
        'tbharga
        '
        Me.tbharga.Location = New System.Drawing.Point(309, 223)
        Me.tbharga.Name = "tbharga"
        Me.tbharga.Size = New System.Drawing.Size(235, 22)
        Me.tbharga.TabIndex = 40
        '
        'lihat
        '
        Me.lihat.Location = New System.Drawing.Point(401, 348)
        Me.lihat.Name = "lihat"
        Me.lihat.Size = New System.Drawing.Size(141, 53)
        Me.lihat.TabIndex = 29
        Me.lihat.Text = "Lihat Data"
        Me.lihat.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 496)
        Me.Controls.Add(Me.tbharga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tgKategori)
        Me.Controls.Add(Me.lihat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbkondisi)
        Me.Controls.Add(Me.tbtgl)
        Me.Controls.Add(Me.tambah_data)
        Me.Controls.Add(Me.tbtambah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.gbkondisi.ResumeLayout(False)
        Me.gbkondisi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tgKategori As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bekas As RadioButton
    Friend WithEvents gbkondisi As GroupBox
    Friend WithEvents baru As RadioButton
    Friend WithEvents tbtgl As DateTimePicker
    Friend WithEvents tambah_data As Button
    Friend WithEvents tbtambah As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbharga As System.Windows.Forms.TextBox
    Friend WithEvents lihat As System.Windows.Forms.Button
End Class
