<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beranda
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tugas1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tugas2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LatihanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Latihan2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tugas3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TugasToolStripMenuItem, Me.LatihanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TugasToolStripMenuItem
        '
        Me.TugasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tugas1ToolStripMenuItem, Me.Tugas2ToolStripMenuItem, Me.Tugas3ToolStripMenuItem})
        Me.TugasToolStripMenuItem.Name = "TugasToolStripMenuItem"
        Me.TugasToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.TugasToolStripMenuItem.Text = "Tugas"
        '
        'Tugas1ToolStripMenuItem
        '
        Me.Tugas1ToolStripMenuItem.Name = "Tugas1ToolStripMenuItem"
        Me.Tugas1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Tugas1ToolStripMenuItem.Text = "Tugas 1"
        '
        'Tugas2ToolStripMenuItem
        '
        Me.Tugas2ToolStripMenuItem.Name = "Tugas2ToolStripMenuItem"
        Me.Tugas2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Tugas2ToolStripMenuItem.Text = "Tugas 2"
        '
        'LatihanToolStripMenuItem
        '
        Me.LatihanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Latihan2ToolStripMenuItem})
        Me.LatihanToolStripMenuItem.Name = "LatihanToolStripMenuItem"
        Me.LatihanToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.LatihanToolStripMenuItem.Text = "Latihan"
        '
        'Latihan2ToolStripMenuItem
        '
        Me.Latihan2ToolStripMenuItem.Name = "Latihan2ToolStripMenuItem"
        Me.Latihan2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Latihan2ToolStripMenuItem.Text = "Latihan 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "2311032 Yehezkiel Dio Sinolungan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Selamat datang di Beranda!"
        '
        'Tugas3ToolStripMenuItem
        '
        Me.Tugas3ToolStripMenuItem.Name = "Tugas3ToolStripMenuItem"
        Me.Tugas3ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Tugas3ToolStripMenuItem.Text = "Tugas 3"
        '
        'Beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Beranda"
        Me.Text = "Beranda"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tugas1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tugas2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LatihanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Latihan2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tugas3ToolStripMenuItem As ToolStripMenuItem
End Class
