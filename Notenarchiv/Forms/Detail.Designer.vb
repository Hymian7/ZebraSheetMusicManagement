<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detail))
        Me.tbNotensatzNr = New System.Windows.Forms.TextBox()
        Me.tbNotensatzName = New System.Windows.Forms.TextBox()
        Me.tbArrangeur = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.olvNotenblaetter = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColStimmeNr = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColStimmeName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColIstVorhanden = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.RibbonDetail = New System.Windows.Forms.Ribbon()
        Me.RibbonTabNotensatz = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.dlvVerzeichnisse = New BrightIdeasSoftware.DataListView()
        Me.RibbonButtonRefresh = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonAddToVerzeichnis = New System.Windows.Forms.RibbonButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.olvNotenblaetter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dlvVerzeichnisse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbNotensatzNr
        '
        Me.tbNotensatzNr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNotensatzNr.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNotensatzNr.Location = New System.Drawing.Point(60, 219)
        Me.tbNotensatzNr.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNotensatzNr.Name = "tbNotensatzNr"
        Me.tbNotensatzNr.ReadOnly = True
        Me.tbNotensatzNr.Size = New System.Drawing.Size(376, 15)
        Me.tbNotensatzNr.TabIndex = 0
        '
        'tbNotensatzName
        '
        Me.tbNotensatzName.Location = New System.Drawing.Point(60, 251)
        Me.tbNotensatzName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNotensatzName.Name = "tbNotensatzName"
        Me.tbNotensatzName.Size = New System.Drawing.Size(376, 22)
        Me.tbNotensatzName.TabIndex = 1
        '
        'tbArrangeur
        '
        Me.tbArrangeur.Location = New System.Drawing.Point(60, 283)
        Me.tbArrangeur.Margin = New System.Windows.Forms.Padding(4)
        Me.tbArrangeur.Name = "tbArrangeur"
        Me.tbArrangeur.Size = New System.Drawing.Size(376, 22)
        Me.tbArrangeur.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(60, 313)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(944, 235)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.olvNotenblaetter)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(936, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stimmen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dlvVerzeichnisse)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(936, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Verzeichnisse"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'olvNotenblaetter
        '
        Me.olvNotenblaetter.AllColumns.Add(Me.OlvColStimmeNr)
        Me.olvNotenblaetter.AllColumns.Add(Me.OlvColStimmeName)
        Me.olvNotenblaetter.AllColumns.Add(Me.OlvColIstVorhanden)
        Me.olvNotenblaetter.AllowColumnReorder = True
        Me.olvNotenblaetter.CellEditUseWholeCell = False
        Me.olvNotenblaetter.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColStimmeNr, Me.OlvColStimmeName, Me.OlvColIstVorhanden})
        Me.olvNotenblaetter.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvNotenblaetter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvNotenblaetter.FullRowSelect = True
        Me.olvNotenblaetter.Location = New System.Drawing.Point(4, 4)
        Me.olvNotenblaetter.Name = "olvNotenblaetter"
        Me.olvNotenblaetter.ShowGroups = False
        Me.olvNotenblaetter.Size = New System.Drawing.Size(928, 198)
        Me.olvNotenblaetter.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.olvNotenblaetter.TabIndex = 9
        Me.olvNotenblaetter.UseCompatibleStateImageBehavior = False
        Me.olvNotenblaetter.View = System.Windows.Forms.View.Details
        '
        'OlvColStimmeNr
        '
        Me.OlvColStimmeNr.AspectName = "StimmeNr"
        Me.OlvColStimmeNr.Text = "Nummer"
        Me.OlvColStimmeNr.Width = 69
        '
        'OlvColStimmeName
        '
        Me.OlvColStimmeName.AspectName = "StimmeName"
        Me.OlvColStimmeName.Text = "Name"
        Me.OlvColStimmeName.Width = 151
        '
        'OlvColIstVorhanden
        '
        Me.OlvColIstVorhanden.AspectName = "IstVorhanden"
        Me.OlvColIstVorhanden.Text = "Vorhanden"
        Me.OlvColIstVorhanden.Width = 94
        '
        'RibbonDetail
        '
        Me.RibbonDetail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RibbonDetail.Location = New System.Drawing.Point(0, 0)
        Me.RibbonDetail.Minimized = False
        Me.RibbonDetail.Name = "RibbonDetail"
        '
        '
        '
        Me.RibbonDetail.OrbDropDown.BorderRoundness = 8
        Me.RibbonDetail.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.RibbonDetail.OrbDropDown.Name = ""
        Me.RibbonDetail.OrbDropDown.Size = New System.Drawing.Size(527, 72)
        Me.RibbonDetail.OrbDropDown.TabIndex = 0
        Me.RibbonDetail.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.RibbonDetail.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.RibbonDetail.Size = New System.Drawing.Size(1022, 200)
        Me.RibbonDetail.TabIndex = 10
        Me.RibbonDetail.Tabs.Add(Me.RibbonTabNotensatz)
        Me.RibbonDetail.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.RibbonDetail.TabSpacing = 4
        Me.RibbonDetail.Text = "RibbonDetail"
        '
        'RibbonTabNotensatz
        '
        Me.RibbonTabNotensatz.Name = "RibbonTabNotensatz"
        Me.RibbonTabNotensatz.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTabNotensatz.Text = "Notensatz"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.RibbonButtonRefresh)
        Me.RibbonPanel1.Items.Add(Me.RibbonButtonAddToVerzeichnis)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Text = Nothing
        '
        'dlvVerzeichnisse
        '
        Me.dlvVerzeichnisse.CellEditUseWholeCell = False
        Me.dlvVerzeichnisse.DataSource = Nothing
        Me.dlvVerzeichnisse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dlvVerzeichnisse.FullRowSelect = True
        Me.dlvVerzeichnisse.Location = New System.Drawing.Point(4, 4)
        Me.dlvVerzeichnisse.MultiSelect = False
        Me.dlvVerzeichnisse.Name = "dlvVerzeichnisse"
        Me.dlvVerzeichnisse.ShowGroups = False
        Me.dlvVerzeichnisse.Size = New System.Drawing.Size(928, 198)
        Me.dlvVerzeichnisse.TabIndex = 5
        Me.dlvVerzeichnisse.UseCompatibleStateImageBehavior = False
        Me.dlvVerzeichnisse.View = System.Windows.Forms.View.Details
        '
        'RibbonButtonRefresh
        '
        Me.RibbonButtonRefresh.Enabled = False
        Me.RibbonButtonRefresh.Image = CType(resources.GetObject("RibbonButtonRefresh.Image"), System.Drawing.Image)
        Me.RibbonButtonRefresh.LargeImage = CType(resources.GetObject("RibbonButtonRefresh.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonRefresh.MaximumSize = New System.Drawing.Size(128, 128)
        Me.RibbonButtonRefresh.MinimumSize = New System.Drawing.Size(64, 64)
        Me.RibbonButtonRefresh.Name = "RibbonButtonRefresh"
        Me.RibbonButtonRefresh.SmallImage = CType(resources.GetObject("RibbonButtonRefresh.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonRefresh.Text = "Update"
        '
        'RibbonButtonAddToVerzeichnis
        '
        Me.RibbonButtonAddToVerzeichnis.Image = CType(resources.GetObject("RibbonButtonAddToVerzeichnis.Image"), System.Drawing.Image)
        Me.RibbonButtonAddToVerzeichnis.LargeImage = CType(resources.GetObject("RibbonButtonAddToVerzeichnis.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonAddToVerzeichnis.Name = "RibbonButtonAddToVerzeichnis"
        Me.RibbonButtonAddToVerzeichnis.SmallImage = CType(resources.GetObject("RibbonButtonAddToVerzeichnis.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonAddToVerzeichnis.Text = "Zu Verzeichnis Hinzufügen"
        '
        'Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 561)
        Me.Controls.Add(Me.RibbonDetail)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tbArrangeur)
        Me.Controls.Add(Me.tbNotensatzName)
        Me.Controls.Add(Me.tbNotensatzNr)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Detail"
        Me.Text = "Detail"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.olvNotenblaetter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dlvVerzeichnisse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNotensatzNr As TextBox
    Friend WithEvents tbNotensatzName As TextBox
    Friend WithEvents tbArrangeur As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents olvNotenblaetter As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColStimmeNr As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColStimmeName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColIstVorhanden As BrightIdeasSoftware.OLVColumn
    Friend WithEvents RibbonDetail As Ribbon
    Friend WithEvents RibbonTabNotensatz As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonButtonRefresh As RibbonButton
    Friend WithEvents dlvVerzeichnisse As BrightIdeasSoftware.DataListView
    Friend WithEvents RibbonButtonAddToVerzeichnis As RibbonButton
End Class
