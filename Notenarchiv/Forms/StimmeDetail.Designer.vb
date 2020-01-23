<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StimmeDetail
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbStimmeNr = New System.Windows.Forms.TextBox()
        Me.tbStimmeName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbAlternative1 = New System.Windows.Forms.TextBox()
        Me.tbAlternative2 = New System.Windows.Forms.TextBox()
        Me.tbAlternative4 = New System.Windows.Forms.TextBox()
        Me.tbAlternative3 = New System.Windows.Forms.TextBox()
        Me.btnChangeAlt1 = New System.Windows.Forms.Button()
        Me.btnChangeAlt2 = New System.Windows.Forms.Button()
        Me.btnChangeAlt3 = New System.Windows.Forms.Button()
        Me.btnChangeAlt4 = New System.Windows.Forms.Button()
        Me.btnResetAlt1 = New System.Windows.Forms.Button()
        Me.btnResetAlt2 = New System.Windows.Forms.Button()
        Me.btnResetAlt3 = New System.Windows.Forms.Button()
        Me.btnResetAlt4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbStimmeNr
        '
        Me.tbStimmeNr.Enabled = False
        Me.tbStimmeNr.Location = New System.Drawing.Point(68, 103)
        Me.tbStimmeNr.Margin = New System.Windows.Forms.Padding(4)
        Me.tbStimmeNr.Name = "tbStimmeNr"
        Me.tbStimmeNr.Size = New System.Drawing.Size(132, 22)
        Me.tbStimmeNr.TabIndex = 0
        '
        'tbStimmeName
        '
        Me.tbStimmeName.Enabled = False
        Me.tbStimmeName.Location = New System.Drawing.Point(209, 103)
        Me.tbStimmeName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbStimmeName.Name = "tbStimmeName"
        Me.tbStimmeName.Size = New System.Drawing.Size(399, 22)
        Me.tbStimmeName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 206)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Alternative 1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 238)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Alternative 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 270)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Alternative 3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 302)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alternative 4:"
        '
        'tbAlternative1
        '
        Me.tbAlternative1.Location = New System.Drawing.Point(161, 202)
        Me.tbAlternative1.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAlternative1.Name = "tbAlternative1"
        Me.tbAlternative1.ReadOnly = True
        Me.tbAlternative1.Size = New System.Drawing.Size(399, 22)
        Me.tbAlternative1.TabIndex = 7
        '
        'tbAlternative2
        '
        Me.tbAlternative2.Location = New System.Drawing.Point(161, 234)
        Me.tbAlternative2.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAlternative2.Name = "tbAlternative2"
        Me.tbAlternative2.ReadOnly = True
        Me.tbAlternative2.Size = New System.Drawing.Size(399, 22)
        Me.tbAlternative2.TabIndex = 8
        '
        'tbAlternative4
        '
        Me.tbAlternative4.Location = New System.Drawing.Point(161, 298)
        Me.tbAlternative4.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAlternative4.Name = "tbAlternative4"
        Me.tbAlternative4.ReadOnly = True
        Me.tbAlternative4.Size = New System.Drawing.Size(399, 22)
        Me.tbAlternative4.TabIndex = 9
        '
        'tbAlternative3
        '
        Me.tbAlternative3.Location = New System.Drawing.Point(161, 266)
        Me.tbAlternative3.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAlternative3.Name = "tbAlternative3"
        Me.tbAlternative3.ReadOnly = True
        Me.tbAlternative3.Size = New System.Drawing.Size(399, 22)
        Me.tbAlternative3.TabIndex = 10
        '
        'btnChangeAlt1
        '
        Me.btnChangeAlt1.Location = New System.Drawing.Point(569, 202)
        Me.btnChangeAlt1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChangeAlt1.Name = "btnChangeAlt1"
        Me.btnChangeAlt1.Size = New System.Drawing.Size(60, 25)
        Me.btnChangeAlt1.TabIndex = 11
        Me.btnChangeAlt1.Text = "..."
        Me.btnChangeAlt1.UseVisualStyleBackColor = True
        '
        'btnChangeAlt2
        '
        Me.btnChangeAlt2.Location = New System.Drawing.Point(569, 234)
        Me.btnChangeAlt2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChangeAlt2.Name = "btnChangeAlt2"
        Me.btnChangeAlt2.Size = New System.Drawing.Size(60, 25)
        Me.btnChangeAlt2.TabIndex = 12
        Me.btnChangeAlt2.Text = "..."
        Me.btnChangeAlt2.UseVisualStyleBackColor = True
        '
        'btnChangeAlt3
        '
        Me.btnChangeAlt3.Location = New System.Drawing.Point(569, 266)
        Me.btnChangeAlt3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChangeAlt3.Name = "btnChangeAlt3"
        Me.btnChangeAlt3.Size = New System.Drawing.Size(60, 25)
        Me.btnChangeAlt3.TabIndex = 13
        Me.btnChangeAlt3.Text = "..."
        Me.btnChangeAlt3.UseVisualStyleBackColor = True
        '
        'btnChangeAlt4
        '
        Me.btnChangeAlt4.Location = New System.Drawing.Point(569, 298)
        Me.btnChangeAlt4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChangeAlt4.Name = "btnChangeAlt4"
        Me.btnChangeAlt4.Size = New System.Drawing.Size(60, 25)
        Me.btnChangeAlt4.TabIndex = 14
        Me.btnChangeAlt4.Text = "..."
        Me.btnChangeAlt4.UseVisualStyleBackColor = True
        '
        'btnResetAlt1
        '
        Me.btnResetAlt1.Location = New System.Drawing.Point(637, 202)
        Me.btnResetAlt1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetAlt1.Name = "btnResetAlt1"
        Me.btnResetAlt1.Size = New System.Drawing.Size(25, 25)
        Me.btnResetAlt1.TabIndex = 15
        Me.btnResetAlt1.Text = "X"
        Me.btnResetAlt1.UseVisualStyleBackColor = True
        '
        'btnResetAlt2
        '
        Me.btnResetAlt2.Location = New System.Drawing.Point(637, 233)
        Me.btnResetAlt2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetAlt2.Name = "btnResetAlt2"
        Me.btnResetAlt2.Size = New System.Drawing.Size(25, 25)
        Me.btnResetAlt2.TabIndex = 16
        Me.btnResetAlt2.Text = "X"
        Me.btnResetAlt2.UseVisualStyleBackColor = True
        '
        'btnResetAlt3
        '
        Me.btnResetAlt3.Location = New System.Drawing.Point(637, 266)
        Me.btnResetAlt3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetAlt3.Name = "btnResetAlt3"
        Me.btnResetAlt3.Size = New System.Drawing.Size(25, 25)
        Me.btnResetAlt3.TabIndex = 17
        Me.btnResetAlt3.Text = "X"
        Me.btnResetAlt3.UseVisualStyleBackColor = True
        '
        'btnResetAlt4
        '
        Me.btnResetAlt4.Location = New System.Drawing.Point(637, 297)
        Me.btnResetAlt4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetAlt4.Name = "btnResetAlt4"
        Me.btnResetAlt4.Size = New System.Drawing.Size(25, 25)
        Me.btnResetAlt4.TabIndex = 18
        Me.btnResetAlt4.Text = "X"
        Me.btnResetAlt4.UseVisualStyleBackColor = True
        '
        'StimmeDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnResetAlt4)
        Me.Controls.Add(Me.btnResetAlt3)
        Me.Controls.Add(Me.btnResetAlt2)
        Me.Controls.Add(Me.btnResetAlt1)
        Me.Controls.Add(Me.btnChangeAlt4)
        Me.Controls.Add(Me.btnChangeAlt3)
        Me.Controls.Add(Me.btnChangeAlt2)
        Me.Controls.Add(Me.btnChangeAlt1)
        Me.Controls.Add(Me.tbAlternative3)
        Me.Controls.Add(Me.tbAlternative4)
        Me.Controls.Add(Me.tbAlternative2)
        Me.Controls.Add(Me.tbAlternative1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbStimmeName)
        Me.Controls.Add(Me.tbStimmeNr)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StimmeDetail"
        Me.Text = "StimmeDetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbStimmeNr As TextBox
    Friend WithEvents tbStimmeName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbAlternative1 As TextBox
    Friend WithEvents tbAlternative2 As TextBox
    Friend WithEvents tbAlternative4 As TextBox
    Friend WithEvents tbAlternative3 As TextBox
    Friend WithEvents btnChangeAlt1 As Button
    Friend WithEvents btnChangeAlt2 As Button
    Friend WithEvents btnChangeAlt3 As Button
    Friend WithEvents btnChangeAlt4 As Button
    Friend WithEvents btnResetAlt1 As Button
    Friend WithEvents btnResetAlt2 As Button
    Friend WithEvents btnResetAlt3 As Button
    Friend WithEvents btnResetAlt4 As Button
End Class
