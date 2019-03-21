Imports System.Data.OleDb
Imports System.IO
Imports Notenarchiv.SQLInterface

Public Class Notensätze

    Private bs As BindingSource = New BindingSource
    Private fbd As FolderBrowserDialog = New FolderBrowserDialog

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        AddHandler Detail.NotensatzAktualisiert, AddressOf TabelleAktualisieren
        'AddHandler RibbonButtonAktualisieren.Click, AddressOf TabelleAktualisieren
        AddHandler Me.Shown, AddressOf TabelleAktualisieren
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TabelleAktualisieren()

        'Daten aus tbl_Notensatz werden in die DataListView eingetragen

        dlvNotensaetze.DataSource = GetSQL("SELECT * FROM tbl_Notensatz")
        dlvNotensaetze.Columns(0).Text = "NotensatzNr"
        dlvNotensaetze.Columns(1).Text = "Notensatzname"
        dlvNotensaetze.Columns(2).Text = "Arrangeur"
        dlvNotensaetze.AutoResizeColumns()

    End Sub

    Private Sub tbFilter_TextChanged(sender As Object, e As EventArgs) Handles tbFilter.TextChanged
        'Filter aus tbFilter übernehmen
        'TODO: Modelfilter statt Textmatchfilter

        dlvNotensaetze.ModelFilter = New BrightIdeasSoftware.TextMatchFilter(dlvNotensaetze).Contains(dlvNotensaetze, tbFilter.Text)

    End Sub

    Private Sub dlvNotensaetze_DoubleClick(sender As Object, e As EventArgs) Handles dlvNotensaetze.DoubleClick
        Detail.ShowData(New Notensatz(dlvNotensaetze.SelectedItem.Text))
    End Sub
End Class