<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sortierer
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tb_Datei = New System.Windows.Forms.TextBox()
        Me.tb_Ordner = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Datei = New System.Windows.Forms.Button()
        Me.btn_Ordner = New System.Windows.Forms.Button()
        Me.lb_barcodes = New System.Windows.Forms.ListBox()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.btn_split = New System.Windows.Forms.Button()
        Me.cbRemoveEmptyPages = New System.Windows.Forms.CheckBox()
        Me.cbSplitDINA3 = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tb_Datei
        '
        Me.tb_Datei.Location = New System.Drawing.Point(60, 19)
        Me.tb_Datei.Name = "tb_Datei"
        Me.tb_Datei.ReadOnly = True
        Me.tb_Datei.Size = New System.Drawing.Size(232, 20)
        Me.tb_Datei.TabIndex = 0
        '
        'tb_Ordner
        '
        Me.tb_Ordner.Location = New System.Drawing.Point(60, 89)
        Me.tb_Ordner.Name = "tb_Ordner"
        Me.tb_Ordner.ReadOnly = True
        Me.tb_Ordner.Size = New System.Drawing.Size(232, 20)
        Me.tb_Ordner.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Datei"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pfad"
        '
        'btn_Datei
        '
        Me.btn_Datei.Location = New System.Drawing.Point(298, 16)
        Me.btn_Datei.Name = "btn_Datei"
        Me.btn_Datei.Size = New System.Drawing.Size(75, 23)
        Me.btn_Datei.TabIndex = 4
        Me.btn_Datei.Text = "Datei"
        Me.btn_Datei.UseVisualStyleBackColor = True
        '
        'btn_Ordner
        '
        Me.btn_Ordner.Location = New System.Drawing.Point(298, 87)
        Me.btn_Ordner.Name = "btn_Ordner"
        Me.btn_Ordner.Size = New System.Drawing.Size(75, 23)
        Me.btn_Ordner.TabIndex = 5
        Me.btn_Ordner.Text = "Ordner"
        Me.btn_Ordner.UseVisualStyleBackColor = True
        '
        'lb_barcodes
        '
        Me.lb_barcodes.FormattingEnabled = True
        Me.lb_barcodes.Location = New System.Drawing.Point(18, 116)
        Me.lb_barcodes.MultiColumn = True
        Me.lb_barcodes.Name = "lb_barcodes"
        Me.lb_barcodes.Size = New System.Drawing.Size(355, 82)
        Me.lb_barcodes.TabIndex = 6
        '
        'btn_scan
        '
        Me.btn_scan.Location = New System.Drawing.Point(18, 204)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(75, 23)
        Me.btn_scan.TabIndex = 7
        Me.btn_scan.Text = "Erkennen"
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'btn_split
        '
        Me.btn_split.Location = New System.Drawing.Point(298, 204)
        Me.btn_split.Name = "btn_split"
        Me.btn_split.Size = New System.Drawing.Size(75, 23)
        Me.btn_split.TabIndex = 8
        Me.btn_split.Text = "Verarbeiten"
        Me.btn_split.UseVisualStyleBackColor = True
        '
        'cbRemoveEmptyPages
        '
        Me.cbRemoveEmptyPages.AutoSize = True
        Me.cbRemoveEmptyPages.Location = New System.Drawing.Point(60, 45)
        Me.cbRemoveEmptyPages.Name = "cbRemoveEmptyPages"
        Me.cbRemoveEmptyPages.Size = New System.Drawing.Size(134, 17)
        Me.cbRemoveEmptyPages.TabIndex = 9
        Me.cbRemoveEmptyPages.Text = "Leere Seiten entfernen"
        Me.cbRemoveEmptyPages.UseVisualStyleBackColor = True
        '
        'cbSplitDINA3
        '
        Me.cbSplitDINA3.AutoSize = True
        Me.cbSplitDINA3.Location = New System.Drawing.Point(60, 68)
        Me.cbSplitDINA3.Name = "cbSplitDINA3"
        Me.cbSplitDINA3.Size = New System.Drawing.Size(100, 17)
        Me.cbSplitDINA3.TabIndex = 10
        Me.cbSplitDINA3.Text = "A3 Seiten teilen"
        Me.cbSplitDINA3.UseVisualStyleBackColor = True
        '
        'Sortierer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 245)
        Me.Controls.Add(Me.cbSplitDINA3)
        Me.Controls.Add(Me.cbRemoveEmptyPages)
        Me.Controls.Add(Me.btn_split)
        Me.Controls.Add(Me.btn_scan)
        Me.Controls.Add(Me.lb_barcodes)
        Me.Controls.Add(Me.btn_Ordner)
        Me.Controls.Add(Me.btn_Datei)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Ordner)
        Me.Controls.Add(Me.tb_Datei)
        Me.Name = "Sortierer"
        Me.Text = "Sortierer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents tb_Datei As TextBox
    Friend WithEvents tb_Ordner As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Datei As Button
    Friend WithEvents btn_Ordner As Button
    Friend WithEvents lb_barcodes As ListBox
    Friend WithEvents btn_scan As Button
    Friend WithEvents btn_split As Button
    Friend WithEvents cbRemoveEmptyPages As CheckBox
    Friend WithEvents cbSplitDINA3 As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
