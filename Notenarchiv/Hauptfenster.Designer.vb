﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.RibbonOrbMenuItemEinstellungen = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.ribbontab_Start = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanelModus = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonNotensätze = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonBarcodes = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonImport = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonInhaltsverzeichnisse = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonStimmen = New System.Windows.Forms.RibbonButton()
        Me.RibbonTabNotensatz = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanelNotensatz = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonAddNotensatz = New System.Windows.Forms.RibbonButton()
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
        Me.Importieren1 = New Notenarchiv.Importieren()
        Me.TabControlFenster.SuspendLayout()
        Me.tabPageNotensaetze.SuspendLayout()
        Me.tabPageImportieren.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonHauptfenster
        '
        Me.RibbonHauptfenster.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RibbonHauptfenster.Location = New System.Drawing.Point(0, 0)
        Me.RibbonHauptfenster.Margin = New System.Windows.Forms.Padding(4)
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
        Me.RibbonHauptfenster.OrbText = "Zebra"
        Me.RibbonHauptfenster.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.RibbonHauptfenster.Size = New System.Drawing.Size(1588, 200)
        Me.RibbonHauptfenster.TabIndex = 0
        Me.RibbonHauptfenster.Tabs.Add(Me.ribbontab_Start)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabNotensatz)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabBarcode)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabImport)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabInhaltsverzeichnis)
        Me.RibbonHauptfenster.Tabs.Add(Me.RibbonTabStimme)
        Me.RibbonHauptfenster.TabsMargin = New System.Windows.Forms.Padding(5, 26, 20, 0)
        Me.RibbonHauptfenster.TabSpacing = 4
        Me.RibbonHauptfenster.Text = "Ribbon1"
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
        'ribbontab_Start
        '
        Me.ribbontab_Start.Name = "ribbontab_Start"
        Me.ribbontab_Start.Panels.Add(Me.RibbonPanelModus)
        Me.ribbontab_Start.Text = "Start"
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
        'RibbonTabNotensatz
        '
        Me.RibbonTabNotensatz.Name = "RibbonTabNotensatz"
        Me.RibbonTabNotensatz.Panels.Add(Me.RibbonPanelNotensatz)
        Me.RibbonTabNotensatz.Text = "Notensatz"
        '
        'RibbonPanelNotensatz
        '
        Me.RibbonPanelNotensatz.Items.Add(Me.RibbonButtonAddNotensatz)
        Me.RibbonPanelNotensatz.Name = "RibbonPanelNotensatz"
        Me.RibbonPanelNotensatz.Text = "Notensatz Tools"
        '
        'RibbonButtonAddNotensatz
        '
        Me.RibbonButtonAddNotensatz.Image = CType(resources.GetObject("RibbonButtonAddNotensatz.Image"), System.Drawing.Image)
        Me.RibbonButtonAddNotensatz.LargeImage = CType(resources.GetObject("RibbonButtonAddNotensatz.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonAddNotensatz.Name = "RibbonButtonAddNotensatz"
        Me.RibbonButtonAddNotensatz.SmallImage = CType(resources.GetObject("RibbonButtonAddNotensatz.SmallImage"), System.Drawing.Image)
        Me.RibbonButtonAddNotensatz.Text = "Notensatz hinzufügen"
        '
        'RibbonTabBarcode
        '
        Me.RibbonTabBarcode.Name = "RibbonTabBarcode"
        Me.RibbonTabBarcode.Text = "Barcode"
        '
        'RibbonTabImport
        '
        Me.RibbonTabImport.Name = "RibbonTabImport"
        Me.RibbonTabImport.Text = "Import"
        '
        'RibbonTabInhaltsverzeichnis
        '
        Me.RibbonTabInhaltsverzeichnis.Name = "RibbonTabInhaltsverzeichnis"
        Me.RibbonTabInhaltsverzeichnis.Text = "Inhaltsverzeichnis"
        '
        'RibbonTabStimme
        '
        Me.RibbonTabStimme.Name = "RibbonTabStimme"
        Me.RibbonTabStimme.Text = "Stimme"
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
        Me.TabControlFenster.Location = New System.Drawing.Point(0, 207)
        Me.TabControlFenster.Name = "TabControlFenster"
        Me.TabControlFenster.SelectedIndex = 0
        Me.TabControlFenster.Size = New System.Drawing.Size(1588, 594)
        Me.TabControlFenster.TabIndex = 1
        '
        'tabPageNotensaetze
        '
        Me.tabPageNotensaetze.Controls.Add(Me.ucNotensätze)
        Me.tabPageNotensaetze.Location = New System.Drawing.Point(4, 25)
        Me.tabPageNotensaetze.Name = "tabPageNotensaetze"
        Me.tabPageNotensaetze.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageNotensaetze.Size = New System.Drawing.Size(1580, 567)
        Me.tabPageNotensaetze.TabIndex = 0
        Me.tabPageNotensaetze.Text = "Notensätze"
        Me.tabPageNotensaetze.UseVisualStyleBackColor = True
        '
        'tabPageBarcodes
        '
        Me.tabPageBarcodes.Location = New System.Drawing.Point(4, 25)
        Me.tabPageBarcodes.Name = "tabPageBarcodes"
        Me.tabPageBarcodes.Size = New System.Drawing.Size(1580, 567)
        Me.tabPageBarcodes.TabIndex = 2
        Me.tabPageBarcodes.Text = "Barcodes"
        Me.tabPageBarcodes.UseVisualStyleBackColor = True
        '
        'tabPageImportieren
        '
        Me.tabPageImportieren.Controls.Add(Me.Importieren1)
        Me.tabPageImportieren.Location = New System.Drawing.Point(4, 25)
        Me.tabPageImportieren.Name = "tabPageImportieren"
        Me.tabPageImportieren.Size = New System.Drawing.Size(1580, 567)
        Me.tabPageImportieren.TabIndex = 3
        Me.tabPageImportieren.Text = "Importieren"
        Me.tabPageImportieren.UseVisualStyleBackColor = True
        '
        'tabPageInhaltsverzeichnisse
        '
        Me.tabPageInhaltsverzeichnisse.Location = New System.Drawing.Point(4, 25)
        Me.tabPageInhaltsverzeichnisse.Name = "tabPageInhaltsverzeichnisse"
        Me.tabPageInhaltsverzeichnisse.Size = New System.Drawing.Size(1580, 567)
        Me.tabPageInhaltsverzeichnisse.TabIndex = 4
        Me.tabPageInhaltsverzeichnisse.Text = "Inhaltsverzeichnisse"
        Me.tabPageInhaltsverzeichnisse.UseVisualStyleBackColor = True
        '
        'tabPageStimmen
        '
        Me.tabPageStimmen.Location = New System.Drawing.Point(4, 25)
        Me.tabPageStimmen.Name = "tabPageStimmen"
        Me.tabPageStimmen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageStimmen.Size = New System.Drawing.Size(1580, 567)
        Me.tabPageStimmen.TabIndex = 1
        Me.tabPageStimmen.Text = "Stimmen"
        Me.tabPageStimmen.UseVisualStyleBackColor = True
        '
        'tabPageDetail
        '
        Me.tabPageDetail.Location = New System.Drawing.Point(4, 25)
        Me.tabPageDetail.Name = "tabPageDetail"
        Me.tabPageDetail.Size = New System.Drawing.Size(1580, 565)
        Me.tabPageDetail.TabIndex = 5
        Me.tabPageDetail.Text = "Detail"
        Me.tabPageDetail.UseVisualStyleBackColor = True
        '
        'ucNotensätze
        '
        Me.ucNotensätze.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucNotensätze.Location = New System.Drawing.Point(4, 7)
        Me.ucNotensätze.Margin = New System.Windows.Forms.Padding(4)
        Me.ucNotensätze.Name = "ucNotensätze"
        Me.ucNotensätze.Size = New System.Drawing.Size(1576, 556)
        Me.ucNotensätze.TabIndex = 0
        '
        'Importieren1
        '
        Me.Importieren1.Location = New System.Drawing.Point(4, 4)
        Me.Importieren1.Margin = New System.Windows.Forms.Padding(4)
        Me.Importieren1.MinimumSize = New System.Drawing.Size(1100, 685)
        Me.Importieren1.Name = "Importieren1"
        Me.Importieren1.Size = New System.Drawing.Size(1572, 685)
        Me.Importieren1.TabIndex = 0
        '
        'Hauptfenster
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1588, 813)
        Me.Controls.Add(Me.TabControlFenster)
        Me.Controls.Add(Me.RibbonHauptfenster)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Hauptfenster"
        Me.Text = "Hauptfenster"
        Me.TabControlFenster.ResumeLayout(False)
        Me.tabPageNotensaetze.ResumeLayout(False)
        Me.tabPageImportieren.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonHauptfenster As Ribbon
    Friend WithEvents ribbontab_Start As RibbonTab
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
    Friend WithEvents RibbonTabNotensatz As RibbonTab
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
    Friend WithEvents Importieren1 As Importieren
End Class
