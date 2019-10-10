<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucStimmen
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.tcStimmenAnsicht = New System.Windows.Forms.TabControl()
        Me.tpStimmenAnsichtListe = New System.Windows.Forms.TabPage()
        Me.dlvStimmen = New BrightIdeasSoftware.DataListView()
        Me.tbFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpStimmenAnsichtÜbersicht = New System.Windows.Forms.TabPage()
        Me.tcStimmenAnsicht.SuspendLayout()
        Me.tpStimmenAnsichtListe.SuspendLayout()
        CType(Me.dlvStimmen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcStimmenAnsicht
        '
        Me.tcStimmenAnsicht.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcStimmenAnsicht.Controls.Add(Me.tpStimmenAnsichtListe)
        Me.tcStimmenAnsicht.Controls.Add(Me.tpStimmenAnsichtÜbersicht)
        Me.tcStimmenAnsicht.Location = New System.Drawing.Point(3, 3)
        Me.tcStimmenAnsicht.Name = "tcStimmenAnsicht"
        Me.tcStimmenAnsicht.SelectedIndex = 0
        Me.tcStimmenAnsicht.Size = New System.Drawing.Size(529, 338)
        Me.tcStimmenAnsicht.TabIndex = 0
        '
        'tpStimmenAnsichtListe
        '
        Me.tpStimmenAnsichtListe.Controls.Add(Me.dlvStimmen)
        Me.tpStimmenAnsichtListe.Controls.Add(Me.tbFilter)
        Me.tpStimmenAnsichtListe.Controls.Add(Me.Label1)
        Me.tpStimmenAnsichtListe.Location = New System.Drawing.Point(4, 22)
        Me.tpStimmenAnsichtListe.Name = "tpStimmenAnsichtListe"
        Me.tpStimmenAnsichtListe.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStimmenAnsichtListe.Size = New System.Drawing.Size(521, 312)
        Me.tpStimmenAnsichtListe.TabIndex = 0
        Me.tpStimmenAnsichtListe.Text = "Liste"
        Me.tpStimmenAnsichtListe.UseVisualStyleBackColor = True
        '
        'dlvStimmen
        '
        Me.dlvStimmen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dlvStimmen.CellEditUseWholeCell = False
        Me.dlvStimmen.Cursor = System.Windows.Forms.Cursors.Default
        Me.dlvStimmen.DataSource = Nothing
        Me.dlvStimmen.FullRowSelect = True
        Me.dlvStimmen.Location = New System.Drawing.Point(9, 41)
        Me.dlvStimmen.Margin = New System.Windows.Forms.Padding(2)
        Me.dlvStimmen.Name = "dlvStimmen"
        Me.dlvStimmen.ShowGroups = False
        Me.dlvStimmen.Size = New System.Drawing.Size(506, 266)
        Me.dlvStimmen.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.dlvStimmen.TabIndex = 10
        Me.dlvStimmen.UseCompatibleStateImageBehavior = False
        Me.dlvStimmen.UseFiltering = True
        Me.dlvStimmen.View = System.Windows.Forms.View.Details
        '
        'tbFilter
        '
        Me.tbFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFilter.Location = New System.Drawing.Point(44, 16)
        Me.tbFilter.Name = "tbFilter"
        Me.tbFilter.Size = New System.Drawing.Size(471, 20)
        Me.tbFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter:"
        '
        'tpStimmenAnsichtÜbersicht
        '
        Me.tpStimmenAnsichtÜbersicht.Location = New System.Drawing.Point(4, 22)
        Me.tpStimmenAnsichtÜbersicht.Name = "tpStimmenAnsichtÜbersicht"
        Me.tpStimmenAnsichtÜbersicht.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStimmenAnsichtÜbersicht.Size = New System.Drawing.Size(521, 312)
        Me.tpStimmenAnsichtÜbersicht.TabIndex = 1
        Me.tpStimmenAnsichtÜbersicht.Text = "Übersicht"
        Me.tpStimmenAnsichtÜbersicht.UseVisualStyleBackColor = True
        '
        'ucStimmen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcStimmenAnsicht)
        Me.Name = "ucStimmen"
        Me.Size = New System.Drawing.Size(535, 344)
        Me.tcStimmenAnsicht.ResumeLayout(False)
        Me.tpStimmenAnsichtListe.ResumeLayout(False)
        Me.tpStimmenAnsichtListe.PerformLayout()
        CType(Me.dlvStimmen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcStimmenAnsicht As TabControl
    Friend WithEvents tpStimmenAnsichtListe As TabPage
    Friend WithEvents tpStimmenAnsichtÜbersicht As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFilter As TextBox
    Friend WithEvents dlvStimmen As BrightIdeasSoftware.DataListView
End Class
