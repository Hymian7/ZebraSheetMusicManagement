<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notensätze
    Inherits System.Windows.Forms.UserControl

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbFilter = New System.Windows.Forms.TextBox()
        Me.dlvNotensaetze = New BrightIdeasSoftware.DataListView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dlvNotensaetze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbFilter
        '
        Me.tbFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFilter.Location = New System.Drawing.Point(55, 4)
        Me.tbFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFilter.Name = "tbFilter"
        Me.tbFilter.Size = New System.Drawing.Size(964, 22)
        Me.tbFilter.TabIndex = 8
        '
        'dlvNotensaetze
        '
        Me.dlvNotensaetze.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dlvNotensaetze.CellEditUseWholeCell = False
        Me.dlvNotensaetze.Cursor = System.Windows.Forms.Cursors.Default
        Me.dlvNotensaetze.DataSource = Nothing
        Me.dlvNotensaetze.FullRowSelect = True
        Me.dlvNotensaetze.Location = New System.Drawing.Point(0, 33)
        Me.dlvNotensaetze.Name = "dlvNotensaetze"
        Me.dlvNotensaetze.ShowGroups = False
        Me.dlvNotensaetze.Size = New System.Drawing.Size(1019, 299)
        Me.dlvNotensaetze.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.dlvNotensaetze.TabIndex = 9
        Me.dlvNotensaetze.UseCompatibleStateImageBehavior = False
        Me.dlvNotensaetze.UseFiltering = True
        Me.dlvNotensaetze.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Filtern:"
        '
        'Notensätze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dlvNotensaetze)
        Me.Controls.Add(Me.tbFilter)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Notensätze"
        Me.Size = New System.Drawing.Size(1019, 335)
        CType(Me.dlvNotensaetze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbFilter As TextBox
    Friend WithEvents dlvNotensaetze As BrightIdeasSoftware.DataListView
    Friend WithEvents Label1 As Label
End Class
