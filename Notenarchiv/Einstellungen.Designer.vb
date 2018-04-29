<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen
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
        Me.tbArchivePath = New System.Windows.Forms.TextBox()
        Me.lblArchivePath = New System.Windows.Forms.Label()
        Me.btnChangeArchivePath = New System.Windows.Forms.Button()
        Me.btnChangeDBPath = New System.Windows.Forms.Button()
        Me.lblDBPath = New System.Windows.Forms.Label()
        Me.tbDBPath = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialogArchivePath = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialogDBPath = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'tbArchivePath
        '
        Me.tbArchivePath.Location = New System.Drawing.Point(31, 48)
        Me.tbArchivePath.Name = "tbArchivePath"
        Me.tbArchivePath.ReadOnly = True
        Me.tbArchivePath.Size = New System.Drawing.Size(371, 20)
        Me.tbArchivePath.TabIndex = 0
        '
        'lblArchivePath
        '
        Me.lblArchivePath.AutoSize = True
        Me.lblArchivePath.Location = New System.Drawing.Point(28, 32)
        Me.lblArchivePath.Name = "lblArchivePath"
        Me.lblArchivePath.Size = New System.Drawing.Size(87, 13)
        Me.lblArchivePath.TabIndex = 1
        Me.lblArchivePath.Text = "Pfad zum Archiv:"
        '
        'btnChangeArchivePath
        '
        Me.btnChangeArchivePath.Location = New System.Drawing.Point(408, 46)
        Me.btnChangeArchivePath.Name = "btnChangeArchivePath"
        Me.btnChangeArchivePath.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeArchivePath.TabIndex = 2
        Me.btnChangeArchivePath.Text = "Ändern"
        Me.btnChangeArchivePath.UseVisualStyleBackColor = True
        '
        'btnChangeDBPath
        '
        Me.btnChangeDBPath.Location = New System.Drawing.Point(408, 104)
        Me.btnChangeDBPath.Name = "btnChangeDBPath"
        Me.btnChangeDBPath.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeDBPath.TabIndex = 5
        Me.btnChangeDBPath.Text = "Ändern"
        Me.btnChangeDBPath.UseVisualStyleBackColor = True
        '
        'lblDBPath
        '
        Me.lblDBPath.AutoSize = True
        Me.lblDBPath.Location = New System.Drawing.Point(28, 90)
        Me.lblDBPath.Name = "lblDBPath"
        Me.lblDBPath.Size = New System.Drawing.Size(105, 13)
        Me.lblDBPath.TabIndex = 4
        Me.lblDBPath.Text = "Pfad zur Datenbank:"
        '
        'tbDBPath
        '
        Me.tbDBPath.Location = New System.Drawing.Point(31, 106)
        Me.tbDBPath.Name = "tbDBPath"
        Me.tbDBPath.ReadOnly = True
        Me.tbDBPath.Size = New System.Drawing.Size(371, 20)
        Me.tbDBPath.TabIndex = 3
        '
        'OpenFileDialogDBPath
        '
        Me.OpenFileDialogDBPath.FileName = "OpenFileDialog1"
        '
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 172)
        Me.Controls.Add(Me.btnChangeDBPath)
        Me.Controls.Add(Me.lblDBPath)
        Me.Controls.Add(Me.tbDBPath)
        Me.Controls.Add(Me.btnChangeArchivePath)
        Me.Controls.Add(Me.lblArchivePath)
        Me.Controls.Add(Me.tbArchivePath)
        Me.Name = "Einstellungen"
        Me.Text = "Einstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbArchivePath As TextBox
    Friend WithEvents lblArchivePath As Label
    Friend WithEvents btnChangeArchivePath As Button
    Friend WithEvents btnChangeDBPath As Button
    Friend WithEvents lblDBPath As Label
    Friend WithEvents tbDBPath As TextBox
    Friend WithEvents FolderBrowserDialogArchivePath As FolderBrowserDialog
    Friend WithEvents OpenFileDialogDBPath As OpenFileDialog
End Class
