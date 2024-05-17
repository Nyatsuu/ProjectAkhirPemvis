<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.btnchart = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbnama = New System.Windows.Forms.ComboBox()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(315, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOKO OLAHRAGA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(398, 189)
        Me.DataGridView1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "List Barang"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(464, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(464, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(631, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(631, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = ":"
        '
        'tbjumlah
        '
        Me.tbjumlah.Location = New System.Drawing.Point(654, 105)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(243, 22)
        Me.tbjumlah.TabIndex = 10
        '
        'btnchart
        '
        Me.btnchart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchart.Location = New System.Drawing.Point(488, 159)
        Me.btnchart.Name = "btnchart"
        Me.btnchart.Size = New System.Drawing.Size(160, 68)
        Me.btnchart.TabIndex = 11
        Me.btnchart.Text = "Masukkan Ke Keranjang"
        Me.btnchart.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(684, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 68)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Lihat Keranjang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbnama
        '
        Me.cbnama.FormattingEnabled = True
        Me.cbnama.Location = New System.Drawing.Point(654, 70)
        Me.cbnama.Name = "cbnama"
        Me.cbnama.Size = New System.Drawing.Size(243, 24)
        Me.cbnama.TabIndex = 13
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(889, 12)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 31)
        Me.btnlogout.TabIndex = 14
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbjumlah)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cbnama)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnchart)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(34, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(912, 262)
        Me.Panel1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(226, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(510, 52)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = """Perlengkapan Hebat Untuk Atlet Hebat"""
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormUser
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.projekPA.My.Resources.Resources._5618236
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(976, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUser"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox
    Friend WithEvents btnchart As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbnama As System.Windows.Forms.ComboBox
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
