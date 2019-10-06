<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inhaltsverzeichnisse
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.olvProgramm = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColProgrammNr = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColNotensatzName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColArrangeurName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColNotensatzNr = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dlvVerzeichnisse = New BrightIdeasSoftware.DataListView()
        CType(Me.olvProgramm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dlvVerzeichnisse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'olvProgramm
        '
        Me.olvProgramm.AllColumns.Add(Me.OlvColProgrammNr)
        Me.olvProgramm.AllColumns.Add(Me.OlvColNotensatzName)
        Me.olvProgramm.AllColumns.Add(Me.OlvColArrangeurName)
        Me.olvProgramm.AllColumns.Add(Me.OlvColNotensatzNr)
        Me.olvProgramm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvProgramm.CellEditUseWholeCell = False
        Me.olvProgramm.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColProgrammNr, Me.OlvColNotensatzName, Me.OlvColArrangeurName, Me.OlvColNotensatzNr})
        Me.olvProgramm.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvProgramm.FullRowSelect = True
        Me.olvProgramm.Location = New System.Drawing.Point(514, 41)
        Me.olvProgramm.Name = "olvProgramm"
        Me.olvProgramm.ShowGroups = False
        Me.olvProgramm.Size = New System.Drawing.Size(434, 399)
        Me.olvProgramm.TabIndex = 1
        Me.olvProgramm.UseCompatibleStateImageBehavior = False
        Me.olvProgramm.View = System.Windows.Forms.View.Details
        '
        'OlvColProgrammNr
        '
        Me.OlvColProgrammNr.AspectName = "ProgrammNr"
        Me.OlvColProgrammNr.Text = "Nummer"
        Me.OlvColProgrammNr.Width = 91
        '
        'OlvColNotensatzName
        '
        Me.OlvColNotensatzName.AspectName = "Notensatz.NotensatzName"
        Me.OlvColNotensatzName.Text = "Lied"
        Me.OlvColNotensatzName.Width = 126
        '
        'OlvColArrangeurName
        '
        Me.OlvColArrangeurName.AspectName = "Notensatz.Arrangeur"
        Me.OlvColArrangeurName.Text = "Arrangeur"
        Me.OlvColArrangeurName.Width = 133
        '
        'OlvColNotensatzNr
        '
        Me.OlvColNotensatzNr.AspectName = "Notensatz.NotensatzNr"
        Me.OlvColNotensatzNr.Text = "NotensatzNr"
        Me.OlvColNotensatzNr.Width = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Verzeichnisse"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(511, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Programm:"
        '
        'dlvVerzeichnisse
        '
        Me.dlvVerzeichnisse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dlvVerzeichnisse.CellEditUseWholeCell = False
        Me.dlvVerzeichnisse.DataSource = Nothing
        Me.dlvVerzeichnisse.FullRowSelect = True
        Me.dlvVerzeichnisse.Location = New System.Drawing.Point(21, 41)
        Me.dlvVerzeichnisse.MultiSelect = False
        Me.dlvVerzeichnisse.Name = "dlvVerzeichnisse"
        Me.dlvVerzeichnisse.ShowGroups = False
        Me.dlvVerzeichnisse.Size = New System.Drawing.Size(487, 399)
        Me.dlvVerzeichnisse.TabIndex = 4
        Me.dlvVerzeichnisse.UseCompatibleStateImageBehavior = False
        Me.dlvVerzeichnisse.View = System.Windows.Forms.View.Details
        '
        'Inhaltsverzeichnisse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dlvVerzeichnisse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.olvProgramm)
        Me.Name = "Inhaltsverzeichnisse"
        Me.Size = New System.Drawing.Size(948, 440)
        CType(Me.olvProgramm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dlvVerzeichnisse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents olvProgramm As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColProgrammNr As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColNotensatzName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColArrangeurName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColNotensatzNr As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dlvVerzeichnisse As BrightIdeasSoftware.DataListView
End Class
