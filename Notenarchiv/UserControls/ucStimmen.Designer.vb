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
        Me.components = New System.ComponentModel.Container()
        Me.tcStimmenAnsicht = New System.Windows.Forms.TabControl()
        Me.tpStimmenAnsichtListe = New System.Windows.Forms.TabPage()
        Me.dlvStimmen = New BrightIdeasSoftware.DataListView()
        Me.tbFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpStimmenAnsichtBaum = New System.Windows.Forms.TabPage()
        Me.btn_treeview = New System.Windows.Forms.Button()
        Me.tlvStimmenBaum = New BrightIdeasSoftware.TreeListView()
        Me.tcStimmenAnsicht.SuspendLayout()
        Me.tpStimmenAnsichtListe.SuspendLayout()
        CType(Me.dlvStimmen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpStimmenAnsichtBaum.SuspendLayout()
        CType(Me.tlvStimmenBaum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcStimmenAnsicht
        '
        Me.tcStimmenAnsicht.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcStimmenAnsicht.Controls.Add(Me.tpStimmenAnsichtListe)
        Me.tcStimmenAnsicht.Controls.Add(Me.tpStimmenAnsichtBaum)
        Me.tcStimmenAnsicht.Location = New System.Drawing.Point(4, 4)
        Me.tcStimmenAnsicht.Margin = New System.Windows.Forms.Padding(4)
        Me.tcStimmenAnsicht.Name = "tcStimmenAnsicht"
        Me.tcStimmenAnsicht.SelectedIndex = 0
        Me.tcStimmenAnsicht.Size = New System.Drawing.Size(1075, 416)
        Me.tcStimmenAnsicht.TabIndex = 0
        '
        'tpStimmenAnsichtListe
        '
        Me.tpStimmenAnsichtListe.Controls.Add(Me.dlvStimmen)
        Me.tpStimmenAnsichtListe.Controls.Add(Me.tbFilter)
        Me.tpStimmenAnsichtListe.Controls.Add(Me.Label1)
        Me.tpStimmenAnsichtListe.Location = New System.Drawing.Point(4, 25)
        Me.tpStimmenAnsichtListe.Margin = New System.Windows.Forms.Padding(4)
        Me.tpStimmenAnsichtListe.Name = "tpStimmenAnsichtListe"
        Me.tpStimmenAnsichtListe.Padding = New System.Windows.Forms.Padding(4)
        Me.tpStimmenAnsichtListe.Size = New System.Drawing.Size(1067, 387)
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
        Me.dlvStimmen.Location = New System.Drawing.Point(12, 50)
        Me.dlvStimmen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dlvStimmen.Name = "dlvStimmen"
        Me.dlvStimmen.ShowGroups = False
        Me.dlvStimmen.Size = New System.Drawing.Size(1050, 326)
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
        Me.tbFilter.Location = New System.Drawing.Point(59, 20)
        Me.tbFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFilter.Name = "tbFilter"
        Me.tbFilter.Size = New System.Drawing.Size(1004, 22)
        Me.tbFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter:"
        '
        'tpStimmenAnsichtBaum
        '
        Me.tpStimmenAnsichtBaum.Controls.Add(Me.btn_treeview)
        Me.tpStimmenAnsichtBaum.Controls.Add(Me.tlvStimmenBaum)
        Me.tpStimmenAnsichtBaum.Location = New System.Drawing.Point(4, 25)
        Me.tpStimmenAnsichtBaum.Margin = New System.Windows.Forms.Padding(4)
        Me.tpStimmenAnsichtBaum.Name = "tpStimmenAnsichtBaum"
        Me.tpStimmenAnsichtBaum.Padding = New System.Windows.Forms.Padding(4)
        Me.tpStimmenAnsichtBaum.Size = New System.Drawing.Size(1067, 387)
        Me.tpStimmenAnsichtBaum.TabIndex = 1
        Me.tpStimmenAnsichtBaum.Text = "Baum"
        Me.tpStimmenAnsichtBaum.UseVisualStyleBackColor = True
        '
        'btn_treeview
        '
        Me.btn_treeview.Location = New System.Drawing.Point(680, 109)
        Me.btn_treeview.Name = "btn_treeview"
        Me.btn_treeview.Size = New System.Drawing.Size(146, 65)
        Me.btn_treeview.TabIndex = 1
        Me.btn_treeview.Text = "Button1"
        Me.btn_treeview.UseVisualStyleBackColor = True
        '
        'tlvStimmenBaum
        '
        Me.tlvStimmenBaum.CellEditUseWholeCell = False
        Me.tlvStimmenBaum.Location = New System.Drawing.Point(3, 7)
        Me.tlvStimmenBaum.Name = "tlvStimmenBaum"
        Me.tlvStimmenBaum.ShowGroups = False
        Me.tlvStimmenBaum.Size = New System.Drawing.Size(532, 373)
        Me.tlvStimmenBaum.TabIndex = 0
        Me.tlvStimmenBaum.UseCompatibleStateImageBehavior = False
        Me.tlvStimmenBaum.View = System.Windows.Forms.View.Details
        Me.tlvStimmenBaum.VirtualMode = True
        '
        'ucStimmen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcStimmenAnsicht)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucStimmen"
        Me.Size = New System.Drawing.Size(1083, 423)
        Me.tcStimmenAnsicht.ResumeLayout(False)
        Me.tpStimmenAnsichtListe.ResumeLayout(False)
        Me.tpStimmenAnsichtListe.PerformLayout()
        CType(Me.dlvStimmen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpStimmenAnsichtBaum.ResumeLayout(False)
        CType(Me.tlvStimmenBaum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcStimmenAnsicht As TabControl
    Friend WithEvents tpStimmenAnsichtListe As TabPage
    Friend WithEvents tpStimmenAnsichtBaum As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFilter As TextBox
    Friend WithEvents dlvStimmen As BrightIdeasSoftware.DataListView
    Friend WithEvents tlvStimmenBaum As BrightIdeasSoftware.TreeListView
    Friend WithEvents btn_treeview As Button
End Class
