﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKoleksi
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
        Me.LabelBuku = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah ingin menghapus koleksi"
        '
        'LabelBuku
        '
        Me.LabelBuku.AutoSize = True
        Me.LabelBuku.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelBuku.ForeColor = System.Drawing.Color.CadetBlue
        Me.LabelBuku.Location = New System.Drawing.Point(202, 195)
        Me.LabelBuku.Name = "LabelBuku"
        Me.LabelBuku.Size = New System.Drawing.Size(352, 96)
        Me.LabelBuku.TabIndex = 1
        Me.LabelBuku.Text = "Koleksi A"
        '
        'BtnHapus
        '
        Me.BtnHapus.ForeColor = System.Drawing.Color.Black
        Me.BtnHapus.Location = New System.Drawing.Point(312, 339)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 34)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LabelBuku)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusKoleksi"
        Me.Text = "HapusKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelBuku As Label
    Friend WithEvents BtnHapus As Button
End Class
