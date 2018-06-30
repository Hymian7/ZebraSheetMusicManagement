<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hauptfenster
    'Inherits System.Windows.Forms.Form
    Inherits System.Windows.Forms.RibbonForm

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
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonOrbMenuItemEinstellungen = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.ribbontab_Start = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanelModus = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonNotensätze = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonBarcodes = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonImport = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonInhaltsverzeichnisse = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonStimmen = New System.Windows.Forms.RibbonButton()
        Me.RibbonTabNotensatz = New System.Windows.Forms.RibbonTab()
        Me.RibbonTabBarcode = New System.Windows.Forms.RibbonTab()
        Me.RibbonTabImport = New System.Windows.Forms.RibbonTab()
        Me.RibbonTabInhaltsverzeichnis = New System.Windows.Forms.RibbonTab()
        Me.RibbonTabStimme = New System.Windows.Forms.RibbonTab()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItemEinstellungen)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 116)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.Ribbon1.OrbText = "Zebra"
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(1601, 161)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.ribbontab_Start)
        Me.Ribbon1.Tabs.Add(Me.RibbonTabNotensatz)
        Me.Ribbon1.Tabs.Add(Me.RibbonTabBarcode)
        Me.Ribbon1.Tabs.Add(Me.RibbonTabImport)
        Me.Ribbon1.Tabs.Add(Me.RibbonTabInhaltsverzeichnis)
        Me.Ribbon1.Tabs.Add(Me.RibbonTabStimme)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(5, 26, 20, 0)
        Me.Ribbon1.TabSpacing = 4
        Me.Ribbon1.Text = "Ribbon1"
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
        Me.RibbonButtonStimmen.Name = "RibbonButtonStimmen"
        Me.RibbonButtonStimmen.SmallImage = Global.Notenarchiv.My.Resources.Resources.bass_clef32
        Me.RibbonButtonStimmen.Text = "Stimmen"
        '
        'RibbonTabNotensatz
        '
        Me.RibbonTabNotensatz.Name = "RibbonTabNotensatz"
        Me.RibbonTabNotensatz.Text = "Notensatz"
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
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.LargeImage = CType(resources.GetObject("RibbonButton1.LargeImage"), System.Drawing.Image)
        Me.RibbonButton1.Name = "RibbonButton1"
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        '
        'Hauptfenster
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1601, 816)
        Me.Controls.Add(Me.Ribbon1)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "Hauptfenster"
        Me.Text = "Hauptfenster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ribbon1 As Ribbon
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
    Friend WithEvents RibbonButton1 As System.Windows.Forms.RibbonButton
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
End Class
