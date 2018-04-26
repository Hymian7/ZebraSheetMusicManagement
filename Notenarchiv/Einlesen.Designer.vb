<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einlesen
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
        Me.tbPfad = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbNotensatz = New System.Windows.Forms.ListBox()
        Me.lbStimmen = New System.Windows.Forms.ListBox()
        Me.btnEinlesen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbPfad
        '
        Me.tbPfad.Location = New System.Drawing.Point(12, 12)
        Me.tbPfad.Name = "tbPfad"
        Me.tbPfad.Size = New System.Drawing.Size(616, 20)
        Me.tbPfad.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(634, 10)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(106, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Ordner wählen"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lbNotensatz
        '
        Me.lbNotensatz.FormattingEnabled = True
        Me.lbNotensatz.Location = New System.Drawing.Point(102, 96)
        Me.lbNotensatz.Name = "lbNotensatz"
        Me.lbNotensatz.Size = New System.Drawing.Size(325, 277)
        Me.lbNotensatz.TabIndex = 2
        '
        'lbStimmen
        '
        Me.lbStimmen.FormattingEnabled = True
        Me.lbStimmen.Location = New System.Drawing.Point(433, 96)
        Me.lbStimmen.MultiColumn = True
        Me.lbStimmen.Name = "lbStimmen"
        Me.lbStimmen.Size = New System.Drawing.Size(325, 277)
        Me.lbStimmen.TabIndex = 3
        '
        'btnEinlesen
        '
        Me.btnEinlesen.Location = New System.Drawing.Point(652, 391)
        Me.btnEinlesen.Name = "btnEinlesen"
        Me.btnEinlesen.Size = New System.Drawing.Size(106, 23)
        Me.btnEinlesen.TabIndex = 4
        Me.btnEinlesen.Text = "Einlesen"
        Me.btnEinlesen.UseVisualStyleBackColor = True
        '
        'Einlesen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 451)
        Me.Controls.Add(Me.btnEinlesen)
        Me.Controls.Add(Me.lbStimmen)
        Me.Controls.Add(Me.lbNotensatz)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tbPfad)
        Me.Name = "Einlesen"
        Me.Text = "Einlesen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPfad As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lbNotensatz As ListBox
    Friend WithEvents lbStimmen As ListBox
    Friend WithEvents btnEinlesen As Button
End Class
