<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Importieren
    Inherits System.Windows.Forms.UserControl

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageScans = New System.Windows.Forms.TabPage()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.lb_barcodes = New System.Windows.Forms.ListBox()
        Me.DataGridViewDateien = New System.Windows.Forms.DataGridView()
        Me.columnDateipfad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnLeereSeiten = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnA3Seiten = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Fortschritt = New Notenarchiv.DataGridViewProgressColumn()
        Me.ButtonEntfernen = New System.Windows.Forms.Button()
        Me.ButtonHinzufügen = New System.Windows.Forms.Button()
        Me.TabPageAnderesArchiv = New System.Windows.Forms.TabPage()
        Me.tbPfad = New System.Windows.Forms.TextBox()
        Me.btnEinlesen = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lbStimmen = New System.Windows.Forms.ListBox()
        Me.lbNotensatz = New System.Windows.Forms.ListBox()
        Me.TabPageManuell = New System.Windows.Forms.TabPage()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.DataGridViewProgressColumn1 = New Notenarchiv.DataGridViewProgressColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPageScans.SuspendLayout()
        CType(Me.DataGridViewDateien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAnderesArchiv.SuspendLayout()
        Me.TabPageManuell.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageScans)
        Me.TabControl1.Controls.Add(Me.TabPageAnderesArchiv)
        Me.TabControl1.Controls.Add(Me.TabPageManuell)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1059, 610)
        Me.TabControl1.TabIndex = 5
        '
        'TabPageScans
        '
        Me.TabPageScans.Controls.Add(Me.ProgressBar1)
        Me.TabPageScans.Controls.Add(Me.ButtonStart)
        Me.TabPageScans.Controls.Add(Me.btn_scan)
        Me.TabPageScans.Controls.Add(Me.lb_barcodes)
        Me.TabPageScans.Controls.Add(Me.DataGridViewDateien)
        Me.TabPageScans.Controls.Add(Me.ButtonEntfernen)
        Me.TabPageScans.Controls.Add(Me.ButtonHinzufügen)
        Me.TabPageScans.Location = New System.Drawing.Point(4, 25)
        Me.TabPageScans.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageScans.Name = "TabPageScans"
        Me.TabPageScans.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageScans.Size = New System.Drawing.Size(1051, 581)
        Me.TabPageScans.TabIndex = 0
        Me.TabPageScans.Text = "Scans verarbeiten"
        Me.TabPageScans.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(35, 529)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(711, 28)
        Me.ProgressBar1.TabIndex = 10
        '
        'ButtonStart
        '
        Me.ButtonStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonStart.Location = New System.Drawing.Point(943, 529)
        Me.ButtonStart.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(100, 28)
        Me.ButtonStart.TabIndex = 9
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'btn_scan
        '
        Me.btn_scan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_scan.Location = New System.Drawing.Point(943, 493)
        Me.btn_scan.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(100, 28)
        Me.btn_scan.TabIndex = 8
        Me.btn_scan.Text = "Erkennen"
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'lb_barcodes
        '
        Me.lb_barcodes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_barcodes.FormattingEnabled = True
        Me.lb_barcodes.ItemHeight = 16
        Me.lb_barcodes.Location = New System.Drawing.Point(754, 133)
        Me.lb_barcodes.Margin = New System.Windows.Forms.Padding(4)
        Me.lb_barcodes.MultiColumn = True
        Me.lb_barcodes.Name = "lb_barcodes"
        Me.lb_barcodes.Size = New System.Drawing.Size(289, 292)
        Me.lb_barcodes.TabIndex = 7
        '
        'DataGridViewDateien
        '
        Me.DataGridViewDateien.AllowDrop = True
        Me.DataGridViewDateien.AllowUserToAddRows = False
        Me.DataGridViewDateien.AllowUserToDeleteRows = False
        Me.DataGridViewDateien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDateien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDateien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnDateipfad, Me.columnLeereSeiten, Me.columnA3Seiten, Me.Fortschritt})
        Me.DataGridViewDateien.Location = New System.Drawing.Point(35, 38)
        Me.DataGridViewDateien.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewDateien.Name = "DataGridViewDateien"
        Me.DataGridViewDateien.Size = New System.Drawing.Size(711, 483)
        Me.DataGridViewDateien.TabIndex = 3
        '
        'columnDateipfad
        '
        Me.columnDateipfad.HeaderText = "Dateipfad"
        Me.columnDateipfad.Name = "columnDateipfad"
        Me.columnDateipfad.ReadOnly = True
        Me.columnDateipfad.Width = 250
        '
        'columnLeereSeiten
        '
        Me.columnLeereSeiten.HeaderText = "Leere Seiten entfernen"
        Me.columnLeereSeiten.Name = "columnLeereSeiten"
        Me.columnLeereSeiten.Width = 50
        '
        'columnA3Seiten
        '
        Me.columnA3Seiten.HeaderText = "A3 Seiten teilen"
        Me.columnA3Seiten.Name = "columnA3Seiten"
        Me.columnA3Seiten.Width = 50
        '
        'Fortschritt
        '
        Me.Fortschritt.HeaderText = "Fortschritt"
        Me.Fortschritt.Name = "Fortschritt"
        '
        'ButtonEntfernen
        '
        Me.ButtonEntfernen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEntfernen.Location = New System.Drawing.Point(943, 74)
        Me.ButtonEntfernen.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonEntfernen.Name = "ButtonEntfernen"
        Me.ButtonEntfernen.Size = New System.Drawing.Size(100, 28)
        Me.ButtonEntfernen.TabIndex = 2
        Me.ButtonEntfernen.Text = "Entfernen"
        Me.ButtonEntfernen.UseVisualStyleBackColor = True
        '
        'ButtonHinzufügen
        '
        Me.ButtonHinzufügen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHinzufügen.Location = New System.Drawing.Point(943, 38)
        Me.ButtonHinzufügen.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonHinzufügen.Name = "ButtonHinzufügen"
        Me.ButtonHinzufügen.Size = New System.Drawing.Size(100, 28)
        Me.ButtonHinzufügen.TabIndex = 1
        Me.ButtonHinzufügen.Text = "Hinzufügen"
        Me.ButtonHinzufügen.UseVisualStyleBackColor = True
        '
        'TabPageAnderesArchiv
        '
        Me.TabPageAnderesArchiv.Controls.Add(Me.tbPfad)
        Me.TabPageAnderesArchiv.Controls.Add(Me.btnEinlesen)
        Me.TabPageAnderesArchiv.Controls.Add(Me.btnBrowse)
        Me.TabPageAnderesArchiv.Controls.Add(Me.lbStimmen)
        Me.TabPageAnderesArchiv.Controls.Add(Me.lbNotensatz)
        Me.TabPageAnderesArchiv.Location = New System.Drawing.Point(4, 25)
        Me.TabPageAnderesArchiv.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageAnderesArchiv.Name = "TabPageAnderesArchiv"
        Me.TabPageAnderesArchiv.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageAnderesArchiv.Size = New System.Drawing.Size(1468, 888)
        Me.TabPageAnderesArchiv.TabIndex = 1
        Me.TabPageAnderesArchiv.Text = "Aus externem Archiv"
        Me.TabPageAnderesArchiv.UseVisualStyleBackColor = True
        '
        'tbPfad
        '
        Me.tbPfad.Location = New System.Drawing.Point(168, 48)
        Me.tbPfad.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPfad.Name = "tbPfad"
        Me.tbPfad.Size = New System.Drawing.Size(820, 22)
        Me.tbPfad.TabIndex = 5
        '
        'btnEinlesen
        '
        Me.btnEinlesen.Location = New System.Drawing.Point(977, 460)
        Me.btnEinlesen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEinlesen.Name = "btnEinlesen"
        Me.btnEinlesen.Size = New System.Drawing.Size(141, 28)
        Me.btnEinlesen.TabIndex = 9
        Me.btnEinlesen.Text = "Einlesen"
        Me.btnEinlesen.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(997, 46)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(141, 28)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "Ordner wählen"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lbStimmen
        '
        Me.lbStimmen.FormattingEnabled = True
        Me.lbStimmen.ItemHeight = 16
        Me.lbStimmen.Location = New System.Drawing.Point(609, 80)
        Me.lbStimmen.Margin = New System.Windows.Forms.Padding(4)
        Me.lbStimmen.MultiColumn = True
        Me.lbStimmen.Name = "lbStimmen"
        Me.lbStimmen.Size = New System.Drawing.Size(432, 340)
        Me.lbStimmen.TabIndex = 8
        '
        'lbNotensatz
        '
        Me.lbNotensatz.FormattingEnabled = True
        Me.lbNotensatz.ItemHeight = 16
        Me.lbNotensatz.Location = New System.Drawing.Point(168, 80)
        Me.lbNotensatz.Margin = New System.Windows.Forms.Padding(4)
        Me.lbNotensatz.Name = "lbNotensatz"
        Me.lbNotensatz.Size = New System.Drawing.Size(432, 340)
        Me.lbNotensatz.TabIndex = 7
        '
        'TabPageManuell
        '
        Me.TabPageManuell.Controls.Add(Me.btnAdd)
        Me.TabPageManuell.Location = New System.Drawing.Point(4, 25)
        Me.TabPageManuell.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageManuell.Name = "TabPageManuell"
        Me.TabPageManuell.Size = New System.Drawing.Size(1468, 888)
        Me.TabPageManuell.TabIndex = 2
        Me.TabPageManuell.Text = "Manuell einsortieren"
        Me.TabPageManuell.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(30, 96)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(97, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Hinzufügen"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'DataGridViewProgressColumn1
        '
        Me.DataGridViewProgressColumn1.HeaderText = "Fortschritt"
        Me.DataGridViewProgressColumn1.Name = "DataGridViewProgressColumn1"
        '
        'Importieren
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 638)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1100, 685)
        Me.Name = "Importieren"
        Me.Text = "Importieren"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageScans.ResumeLayout(False)
        CType(Me.DataGridViewDateien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAnderesArchiv.ResumeLayout(False)
        Me.TabPageAnderesArchiv.PerformLayout()
        Me.TabPageManuell.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageScans As TabPage
    Friend WithEvents TabPageAnderesArchiv As TabPage
    Friend WithEvents TabPageManuell As TabPage
    Friend WithEvents tbPfad As TextBox
    Friend WithEvents btnEinlesen As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lbStimmen As ListBox
    Friend WithEvents lbNotensatz As ListBox
    Friend WithEvents ButtonEntfernen As Button
    Friend WithEvents ButtonHinzufügen As Button
    Friend WithEvents DataGridViewDateien As DataGridView
    Friend WithEvents lb_barcodes As ListBox
    Friend WithEvents btn_scan As Button
    Friend WithEvents ButtonStart As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents columnDateipfad As DataGridViewTextBoxColumn
    Friend WithEvents columnLeereSeiten As DataGridViewCheckBoxColumn
    Friend WithEvents columnA3Seiten As DataGridViewCheckBoxColumn
    Friend WithEvents Fortschritt As DataGridViewProgressColumn
    Friend WithEvents DataGridViewProgressColumn1 As DataGridViewProgressColumn
    Friend WithEvents btnAdd As Button
End Class
