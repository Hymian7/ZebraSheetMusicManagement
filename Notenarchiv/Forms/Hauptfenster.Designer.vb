<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hauptfenster
    Inherits System.Windows.Forms.Form
    'Inherits System.Windows.Forms.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hauptfenster))
        Me.RibbonHauptfenster = New System.Windows.Forms.Ribbon()
        Me.RibbonTabStart = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanelModus = New System.Windows.Forms.RibbonPanel()
        Me.RibbonTabNotensaetze = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanelNotensatz = New System.Windows.Forms.RibbonPanel()
        Me.RibbonTabBarcode = New System.Windows.Forms.RibbonTab()
        Me.RibbonTabImport = New System.Windows.Forms.RibbonTab()
        Me.RibbonTabInhaltsverzeichnis = New System.Windows.Forms.RibbonTab()
        Me.RibbonTabStimme = New System.Windows.Forms.RibbonTab()
        Me.TabControlFenster = New System.Windows.Forms.TabControl()
        Me.tabPageNotensaetze = New System.Windows.Forms.TabPage()
        Me.tabPageBarcodes = New System.Windows.Forms.TabPage()
        Me.tabPageImportieren = New System.Windows.Forms.TabPage()
        Me.tabPageInhaltsverzeichnisse = New System.Windows.Forms.TabPage()
        Me.tabPageStimmen = New System.Windows.Forms.TabPage()
        Me.tabPageDetail = New System.Windows.Forms.TabPage()
        Me.ucNotensätze = New Notenarchiv.Notensätze()
        Me.ucImportieren = New Notenarchiv.Importieren()
        Me.ucInhaltsverzeichnisse = New Notenarchiv.Inhaltsverzeichnisse()
        Me.UcStimmen1 = New Notenarchiv.ucStimmen()
        Me.RibbonOrbMenuItemEinstellungen = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonButtonNotensätze = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonBarcodes = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonImport = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonInhaltsverzeichnisse = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonStimmen = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonNotensaetzeAktualisieren = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonAddNotensatz = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonNotensatzLoeschen = New System.Windows.Forms.RibbonButton()
        Me.TabControlFenster.SuspendLayout()
        Me.tabPageNotensaetze.SuspendLayout()
        Me.tabPageImportieren.SuspendLayout()
        Me.tabPageInhaltsverzeichnisse.SuspendLayout()
        Me.tabPageStimmen.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonHauptfenster
        '
        Me.RibbonHauptfenster.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RibbonHauptfenster.Location = New System.Drawing.Point(0, 0)
        Me.RibbonHauptfenster.Minimized = False
        Me.RibbonHauptfenster.Name = "RibbonHauptfenster"
        '
        '
        '
        Me.RibbonHauptfenster.OrbDropDown.BorderRoundness = 8
        Me.RibbonHauptfenster.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.RibbonHauptfenster.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItemEinstellungen)
        Me.RibbonHauptfenster.OrbDropDown.Name = ""
        Me.RibbonHauptfenster.OrbDropDown.Size = New System.Drawing.Size(527, 116)
        Me.RibbonHauptfenster.OrbDropDown.TabIndex = 0
        Me.RibbonHauptfenster.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.RibbonHauptfenster.OrbText = "ZEBRA"
        '
        '
        '
        Me.RibbonHauptfenster.QuickAccessToolbar.Visible = False
        Me.RibbonHauptfenster.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.RibbonHauptfenster.Size = New System.Drawing.Size(1191, 162)
        Me.RibbonHauptfenster.TabIndex = 0
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabStart)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabNotensaetze)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabBarcode)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabImport)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabInhaltsverzeichnis)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabStimme)
        Me.RibbonHauptfenster.TabsMargin = New System.Windows.Forms.Padding(5, 26, 20, 0)
        Me.RibbonHauptfenster.TabSpacing = 4
        Me.RibbonHauptfenster.Text = "Ribbon1"
        '
        'RibbonTabStart
        '
        Me.RibbonTabStart.Name = "RibbonTabStart"
        Me.RibbonTabStart.Panels.Add(Me.RibbonPanelModus)
        Me.RibbonTabStart.Text = "START"
        '
        'RibbonPanelModus
        '
        Me.RibbonPanelModus.Items.Add(Me.RibbonButtonNotensätze)
        Me.RibbonPanelModus.Items.Add(Me.RibbonButtonBarcodes)
        Me.RibbonPanelModus.Items.Add(Me.RibbonButtonImport)
        Me.RibbonPanelModus.Items.Add(Me.RibbonButtonInhaltsverzeichnisse)
        Me.RibbonPanelModus.Items.Add(Me.RibbonButtonStimmen)
        Me.RibbonPanelModus.Name = "RibbonPanelModus"
        Me.RibbonPanelModus.Text = "Modus"
        '
        'RibbonTabNotensaetze
        '
        Me.RibbonTabNotensaetze.Name = "RibbonTabNotensaetze"
        Me.RibbonTabNotensaetze.Panels.Add(Me.RibbonPanelNotensatz)
        Me.RibbonTabNotensaetze.Text = "NOTENSÄTZE"
        '
        'RibbonPanelNotensatz
        '
        Me.RibbonPanelNotensatz.Items.Add(Me.RibbonButtonNotensaetzeAktualisieren)
        Me.RibbonPanelNotensatz.Items.Add(Me.RibbonButtonAddNotensatz)
        Me.RibbonPanelNotensatz.Items.Add(Me.RibbonButtonNotensatzLoeschen)
        Me.RibbonPanelNotensatz.Name = "RibbonPanelNotensatz"
        Me.RibbonPanelNotensatz.Text = "Notensatz Tools"
        '
        'RibbonTabBarcode
        '
        Me.RibbonTabBarcode.Name = "RibbonTabBarcode"
        Me.RibbonTabBarcode.Text = "BARCODE"
        '
        'RibbonTabImport
        '
        Me.RibbonTabImport.Name = "RibbonTabImport"
        Me.RibbonTabImport.Text = "IMPORT"
        '
        'RibbonTabInhaltsverzeichnis
        '
        Me.RibbonTabInhaltsverzeichnis.Name = "RibbonTabInhaltsverzeichnis"
        Me.RibbonTabInhaltsverzeichnis.Text = "INHALTSVERZEICHNIS"
        '
        'RibbonTabStimme
        '
        Me.RibbonTabStimme.Name = "RibbonTabStimme"
        Me.RibbonTabStimme.Text = "STIMME"
        '
        'TabControlFenster
        '
        Me.TabControlFenster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlFenster.Controls.Add(Me.tabPageNotensaetze)
        Me.TabControlFenster.Controls.Add(Me.tabPageBarcodes)
        Me.TabControlFenster.Controls.Add(Me.tabPageImportieren)
        Me.TabControlFenster.Controls.Add(Me.tabPageInhaltsverzeichnisse)
        Me.TabControlFenster.Controls.Add(Me.tabPageStimmen)
        Me.TabControlFenster.Controls.Add(Me.tabPageDetail)
        Me.TabControlFenster.Location = New System.Drawing.Point(0, 168)
        Me.TabControlFenster.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlFenster.Name = "TabControlFenster"
        Me.TabControlFenster.SelectedIndex = 0
        Me.TabControlFenster.Size = New System.Drawing.Size(1191, 483)
        Me.TabControlFenster.TabIndex = 1
        '
        'tabPageNotensaetze
        '
        Me.tabPageNotensaetze.Controls.Add(Me.ucNotensätze)
        Me.tabPageNotensaetze.Location = New System.Drawing.Point(4, 22)
        Me.tabPageNotensaetze.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPageNotensaetze.Name = "tabPageNotensaetze"
        Me.tabPageNotensaetze.Padding = New System.Windows.Forms.Padding(2)
        Me.tabPageNotensaetze.Size = New System.Drawing.Size(1183, 457)
        Me.tabPageNotensaetze.TabIndex = 0
        Me.tabPageNotensaetze.Text = "Notensätze"
        Me.tabPageNotensaetze.UseVisualStyleBackColor = True
        '
        'tabPageBarcodes
        '
        Me.tabPageBarcodes.Location = New System.Drawing.Point(4, 22)
        Me.tabPageBarcodes.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPageBarcodes.Name = "tabPageBarcodes"
        Me.tabPageBarcodes.Size = New System.Drawing.Size(1183, 457)
        Me.tabPageBarcodes.TabIndex = 2
        Me.tabPageBarcodes.Text = "Barcodes"
        Me.tabPageBarcodes.UseVisualStyleBackColor = True
        '
        'tabPageImportieren
        '
        Me.tabPageImportieren.Controls.Add(Me.ucImportieren)
        Me.tabPageImportieren.Location = New System.Drawing.Point(4, 22)
        Me.tabPageImportieren.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPageImportieren.Name = "tabPageImportieren"
        Me.tabPageImportieren.Size = New System.Drawing.Size(1183, 457)
        Me.tabPageImportieren.TabIndex = 3
        Me.tabPageImportieren.Text = "Importieren"
        Me.tabPageImportieren.UseVisualStyleBackColor = True
        '
        'tabPageInhaltsverzeichnisse
        '
        Me.tabPageInhaltsverzeichnisse.Controls.Add(Me.ucInhaltsverzeichnisse)
        Me.tabPageInhaltsverzeichnisse.Location = New System.Drawing.Point(4, 22)
        Me.tabPageInhaltsverzeichnisse.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPageInhaltsverzeichnisse.Name = "tabPageInhaltsverzeichnisse"
        Me.tabPageInhaltsverzeichnisse.Size = New System.Drawing.Size(1183, 457)
        Me.tabPageInhaltsverzeichnisse.TabIndex = 4
        Me.tabPageInhaltsverzeichnisse.Text = "Inhaltsverzeichnisse"
        Me.tabPageInhaltsverzeichnisse.UseVisualStyleBackColor = True
        '
        'tabPageStimmen
        '
        Me.tabPageStimmen.Controls.Add(Me.UcStimmen1)
        Me.tabPageStimmen.Location = New System.Drawing.Point(4, 22)
        Me.tabPageStimmen.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPageStimmen.Name = "tabPageStimmen"
        Me.tabPageStimmen.Padding = New System.Windows.Forms.Padding(2)
        Me.tabPageStimmen.Size = New System.Drawing.Size(1183, 457)
        Me.tabPageStimmen.TabIndex = 1
        Me.tabPageStimmen.Text = "Stimmen"
        Me.tabPageStimmen.UseVisualStyleBackColor = True
        '
        'tabPageDetail
        '
        Me.tabPageDetail.Location = New System.Drawing.Point(4, 22)
        Me.tabPageDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPageDetail.Name = "tabPageDetail"
        Me.tabPageDetail.Size = New System.Drawing.Size(1183, 457)
        Me.tabPageDetail.TabIndex = 5
        Me.tabPageDetail.Text = "Detail"
        Me.tabPageDetail.UseVisualStyleBackColor = True
        '
        'ucNotensätze
        '
        Me.ucNotensätze.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucNotensätze.Location = New System.Drawing.Point(3, 6)
        Me.ucNotensätze.Name = "ucNotensätze"
        Me.ucNotensätze.Size = New System.Drawing.Size(1182, 452)
        Me.ucNotensätze.TabIndex = 0
        '
        'ucImportieren
        '
        Me.ucImportieren.Location = New System.Drawing.Point(3, 3)
        Me.ucImportieren.MinimumSize = New System.Drawing.Size(825, 557)
        Me.ucImportieren.Name = "ucImportieren"
        Me.ucImportieren.Size = New System.Drawing.Size(1179, 557)
        Me.ucImportieren.TabIndex = 0
        '
        'ucInhaltsverzeichnisse
        '
        Me.ucInhaltsverzeichnisse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucInhaltsverzeichnisse.Location = New System.Drawing.Point(0, 0)
        Me.ucInhaltsverzeichnisse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ucInhaltsverzeichnisse.Name = "ucInhaltsverzeichnisse"
        Me.ucInhaltsverzeichnisse.Size = New System.Drawing.Size(1183, 457)
        Me.ucInhaltsverzeichnisse.TabIndex = 0
        '
        'UcStimmen1
        '
        Me.UcStimmen1.Location = New System.Drawing.Point(8, 5)
        Me.UcStimmen1.Name = "UcStimmen1"
        Me.UcStimmen1.Size = New System.Drawing.Size(1167, 447)
        Me.UcStimmen1.TabIndex = 0
        '
        'RibbonOrbMenuItemEinstellungen
        '
        Me.RibbonOrbMenuItemEinstellungen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItemEinstellungen.Image = CType(resources.GetObject("RibbonOrbMenuItemEinstellungen.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItemEinstellungen.LargeImage = CType(resources.GetObject("RibbonOrbMenuItemEinstellungen.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItemEinstellungen.Name = "RibbonOrbMenuItemEinstellungen"
        Me.RibbonOrbMenuItemEinstellungen.SmallImage = CType(resources.GetObject("RibbonOrbMenuItemEinstellungen.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItemEinstellungen.Text = "Einstellungen"
        '
        'RibbonButtonNotensätze
        '
        Me.RibbonButtonNotensätze.Image = Global.Notenarchiv.My.Resources.Resources.sheet_music
        Me.RibbonButtonNotensätze.LargeImage = Global.Notenarchiv.My.Resources.Resources.sheet_music
        Me.RibbonButtonNotensätze.MaximumSize = New System.Drawing.Size(84, 84)
        Me.RibbonButtonNotensätze.MinimumSize = New System.Drawing.Size(84, 64)
        Me.RibbonButtonNotensätze.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Overflow
        Me.RibbonButtonNotensätze.Name = "RibbonButtonNotensätze"
        Me.RibbonButtonNotensätze.SmallImage = Global.Notenarchiv.My.Resources.Resources.sheet_music32
        Me.RibbonButtonNotensätze.Text = "Notensätze"
        Me.RibbonButtonNotensätze.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        Me.RibbonButtonNotensätze.ToolTipTitle = "Notensätze"
        '
        'RibbonButtonBarcodes
        '
        Me.RibbonButtonBarcodes.Image = Global.Notenarchiv.My.Resources.Resources.barcode64
        Me.RibbonButtonBarcodes.LargeImage = Global.Notenarchiv.My.Resources.Resources.barcode64
        Me.RibbonButtonBarcodes.MaximumSize = New System.Drawing.Size(84, 84)
        Me.RibbonButtonBarcodes.MinimumSize = New System.Drawing.Size(84, 64)
        Me.RibbonButtonBarcodes.Name = "RibbonButtonBarcodes"
        Me.RibbonButtonBarcodes.SmallImage = Global.Notenarchiv.My.Resources.Resources.barcode32
        Me.RibbonButtonBarcodes.Tag = "Barcodes"
        Me.RibbonButtonBarcodes.Text = "Barcodes"
        '
        'RibbonButtonImport
        '
        Me.RibbonButtonImport.Image = Global.Notenarchiv.My.Resources.Resources.import64
        Me.RibbonButtonImport.LargeImage = Global.Notenarchiv.My.Resources.Resources.import64
        Me.RibbonButtonImport.MaximumSize = New System.Drawing.Size(84, 84)
        Me.RibbonButtonImport.MinimumSize = New System.Drawing.Size(84, 64)
        Me.RibbonButtonImport.Name = "RibbonButtonImport"
        Me.RibbonButtonImport.SmallImage = Global.Notenarchiv.My.Resources.Resources.import32
        Me.RibbonButtonImport.Text = "Importieren"
        '
        'RibbonButtonInhaltsverzeichnisse
        '
        Me.RibbonButtonInhaltsverzeichnisse.Image = Global.Notenarchiv.My.Resources.Resources.numbered_list64
        Me.RibbonButtonInhaltsverzeichnisse.LargeImage = Global.Notenarchiv.My.Resources.Resources.numbered_list64
        Me.RibbonButtonInhaltsverzeichnisse.MaximumSize = New System.Drawing.Size(124, 84)
        Me.RibbonButtonInhaltsverzeichnisse.MinimumSize = New System.Drawing.Size(124, 64)
        Me.RibbonButtonInhaltsverzeichnisse.Name = "RibbonButtonInhaltsverzeichnisse"
        Me.RibbonButtonInhaltsverzeichnisse.SmallImage = CType(resources.GetObject("RibbonButtonInhaltsverzeichnisse.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonInhaltsverzeichnisse.Text = "Inhaltsverzeichnisse"
        '
        'RibbonButtonStimmen
        '
        Me.RibbonButtonStimmen.Image = Global.Notenarchiv.My.Resources.Resources.bass_clef64
        Me.RibbonButtonStimmen.LargeImage = Global.Notenarchiv.My.Resources.Resources.bass_clef64
        Me.RibbonButtonStimmen.MaximumSize = New System.Drawing.Size(124, 84)
        Me.RibbonButtonStimmen.MinimumSize = New System.Drawing.Size(124, 64)
        Me.RibbonButtonStimmen.Name = "RibbonButtonStimmen"
        Me.RibbonButtonStimmen.SmallImage = Global.Notenarchiv.My.Resources.Resources.bass_clef32
        Me.RibbonButtonStimmen.Text = "Stimmen"
        '
        'RibbonButtonNotensaetzeAktualisieren
        '
        Me.RibbonButtonNotensaetzeAktualisieren.Image = CType(resources.GetObject("RibbonButtonNotensaetzeAktualisieren.Image"), System.Drawing.Image)
        Me.RibbonButtonNotensaetzeAktualisieren.LargeImage = CType(resources.GetObject("RibbonButtonNotensaetzeAktualisieren.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonNotensaetzeAktualisieren.Name = "RibbonButtonNotensaetzeAktualisieren"
        Me.RibbonButtonNotensaetzeAktualisieren.SmallImage = CType(resources.GetObject("RibbonButtonNotensaetzeAktualisieren.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonNotensaetzeAktualisieren.Text = "Aktualisieren"
        '
        'RibbonButtonAddNotensatz
        '
        Me.RibbonButtonAddNotensatz.Image = CType(resources.GetObject("RibbonButtonAddNotensatz.Image"), System.Drawing.Image)
        Me.RibbonButtonAddNotensatz.LargeImage = CType(resources.GetObject("RibbonButtonAddNotensatz.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonAddNotensatz.Name = "RibbonButtonAddNotensatz"
        Me.RibbonButtonAddNotensatz.SmallImage = CType(resources.GetObject("RibbonButtonAddNotensatz.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonAddNotensatz.Text = "Notensatz hinzufügen"
        '
        'RibbonButtonNotensatzLoeschen
        '
        Me.RibbonButtonNotensatzLoeschen.Image = CType(resources.GetObject("RibbonButtonNotensatzLoeschen.Image"), System.Drawing.Image)
        Me.RibbonButtonNotensatzLoeschen.LargeImage = CType(resources.GetObject("RibbonButtonNotensatzLoeschen.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonNotensatzLoeschen.Name = "RibbonButtonNotensatzLoeschen"
        Me.RibbonButtonNotensatzLoeschen.SmallImage = CType(resources.GetObject("RibbonButtonNotensatzLoeschen.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonNotensatzLoeschen.Text = "Notensatz Löschen"
        '
        'Hauptfenster
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1191, 661)
        Me.Controls.Add(Me.TabControlFenster)
        Me.Controls.Add(Me.RibbonHauptfenster)
        Me.KeyPreview = True
        Me.Name = "Hauptfenster"
        Me.Text = "Hauptfenster"
        Me.TabControlFenster.ResumeLayout(False)
        Me.tabPageNotensaetze.ResumeLayout(False)
        Me.tabPageImportieren.ResumeLayout(False)
        Me.tabPageInhaltsverzeichnisse.ResumeLayout(False)
        Me.tabPageStimmen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonHauptfenster As Ribbon
    Friend WithEvents RibbonTabStart As RibbonTab
    Friend WithEvents RibbonPanelModus As RibbonPanel
    Friend WithEvents RibbonOrbMenuItem1 As RibbonOrbMenuItem
    Friend WithEvents RibbonOrbMenuItem2 As RibbonOrbMenuItem
    Friend WithEvents RibbonOrbMenuItem3 As RibbonOrbMenuItem
    Friend WithEvents RibbonOrbOptionButton1 As RibbonOrbOptionButton
    Friend WithEvents RibbonOrbOptionButton2 As RibbonOrbOptionButton
    Friend WithEvents RibbonOrbRecentItem1 As RibbonOrbRecentItem
    Friend WithEvents RibbonContext1 As RibbonContext
    Friend WithEvents RibbonContext2 As RibbonContext
    Friend WithEvents RibbonContext3 As RibbonContext
    Friend WithEvents RibbonContext4 As RibbonContext
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonTabNotensaetze As RibbonTab
    Friend WithEvents RibbonTabBarcode As RibbonTab
    Friend WithEvents RibbonTabImport As RibbonTab
    Friend WithEvents RibbonTabInhaltsverzeichnis As RibbonTab
    Friend WithEvents RibbonTabStimme As RibbonTab
    Friend WithEvents RibbonButtonNotensätze As RibbonButton
    Friend WithEvents RibbonButtonBarcodes As RibbonButton
    Friend WithEvents RibbonButtonImport As RibbonButton
    Friend WithEvents RibbonButtonInhaltsverzeichnisse As RibbonButton
    Friend WithEvents RibbonButtonStimmen As RibbonButton
    Friend WithEvents RibbonOrbMenuItemEinstellungen As RibbonOrbMenuItem
    Friend WithEvents RibbonPanelNotensatz As RibbonPanel
    Friend WithEvents RibbonButtonAddNotensatz As RibbonButton
    Friend WithEvents TabControlFenster As TabControl
    Friend WithEvents tabPageNotensaetze As TabPage
    Friend WithEvents tabPageStimmen As TabPage
    Friend WithEvents tabPageBarcodes As TabPage
    Friend WithEvents tabPageImportieren As TabPage
    Friend WithEvents tabPageInhaltsverzeichnisse As TabPage
    Friend WithEvents tabPageDetail As TabPage
    Friend WithEvents ucNotensätze As Notensätze
    Friend WithEvents ucImportieren As Importieren
    Friend WithEvents RibbonButtonNotensaetzeAktualisieren As RibbonButton
    Friend WithEvents RibbonButtonNotensatzLoeschen As RibbonButton
    Friend WithEvents ucInhaltsverzeichnisse As Inhaltsverzeichnisse
    Friend WithEvents UcStimmen1 As ucStimmen
End Class
