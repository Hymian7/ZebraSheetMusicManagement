Imports System.Data.OleDb
Imports System.IO
Imports Notenarchiv.SQLInterface

Public Class Hauptfenster

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        'Tab Header zur Laufzeit verstecken

        With TabControlFenster
            .SuspendLayout()
            'diese 3 Einstellungen verstecken die Reiter erst zur Laufzeit
            'bei Design-Arbeiten am Form sind die Reiter ja sehr nützlich 
            .SizeMode = TabSizeMode.Fixed
            .ItemSize = New Size(0, 1)
            .Appearance = TabAppearance.Buttons
            .ResumeLayout()
        End With

        AddHandler RibbonButtonNotensätze.Click, AddressOf tabPageNotensaetze.Select
        AddHandler RibbonButtonImport.Click, AddressOf tabPageImportieren.BringToFront
        AddHandler RibbonButtonBarcodes.Click, AddressOf tabPageBarcodes.Select
        AddHandler RibbonButtonStimmen.Click, AddressOf tabPageStimmen.Select
        AddHandler RibbonButtonInhaltsverzeichnisse.Click, AddressOf tabPageInhaltsverzeichnisse.Select

        AddHandler RibbonButtonNotensaetzeAktualisieren.Click, AddressOf ucNotensätze.TabelleAktualisieren


        AddHandler tabPageNotensaetze.Enter, AddressOf ucNotensätze.TabelleAktualisieren

    End Sub

    Private Sub RibbonOrbMenuItemEinstellungen_Click(sender As Object, e As EventArgs) Handles RibbonOrbMenuItemEinstellungen.Click
        Einstellungen.Show()
    End Sub

    Private Sub RibbonButtonAddNotensatz_Click(sender As Object, e As EventArgs) Handles RibbonButtonAddNotensatz.Click
        NotensatzHinzufuegen.Show()
    End Sub

#Region "Navigation"

    Private Sub RibbonButtonImport_Click(sender As Object, e As EventArgs) Handles RibbonButtonImport.Click
        TabControlFenster.SelectedTab = tabPageImportieren
        RibbonHauptfenster.ActiveTab = RibbonTabImport
    End Sub

    Private Sub RibbonButtonNotensätze_Click(sender As Object, e As EventArgs) Handles RibbonButtonNotensätze.Click
        TabControlFenster.SelectedTab() = tabPageNotensaetze
        RibbonHauptfenster.ActiveTab = RibbonTabNotensaetze
    End Sub

    Private Sub RibbonButtonBarcodes_Click(sender As Object, e As EventArgs) Handles RibbonButtonBarcodes.Click
        TabControlFenster.SelectedTab() = tabPageBarcodes
        RibbonHauptfenster.ActiveTab = RibbonTabBarcode
    End Sub

    Private Sub RibbonButtonInhaltsverzeichnisse_Click(sender As Object, e As EventArgs) Handles RibbonButtonInhaltsverzeichnisse.Click
        TabControlFenster.SelectedTab() = tabPageInhaltsverzeichnisse
        RibbonHauptfenster.ActiveTab = RibbonTabInhaltsverzeichnis
    End Sub

    Private Sub RibbonButtonStimmen_Click(sender As Object, e As EventArgs) Handles RibbonButtonStimmen.Click
        TabControlFenster.SelectedTab() = tabPageStimmen
        RibbonHauptfenster.ActiveTab = RibbonTabStimme
    End Sub

#End Region

End Class