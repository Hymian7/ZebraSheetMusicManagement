Imports System.Data.OleDb
Imports System.IO
Imports Notenarchiv.SQLInterface

Public Class Hauptfenster

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Detail.NotensatzAktualisiert, AddressOf TabelleAktualisieren
        AddHandler RibbonButtonAktualisieren.Click, AddressOf TabelleAktualisieren
        AddHandler Me.Shown, AddressOf TabelleAktualisieren

    End Sub

    Private Sub RibbonButton_Importieren_Click(sender As Object, e As EventArgs) Handles RibbonButton_Importieren.Click
        Sortierer.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Mit diesem Button werden alle Unterordner des im FolderBrowserDialog ausgewählten Pfades mit Standardwerten
        'für Titel und Arrangeur und dem Ordnernamen als ID in die Datenbank geschrieben

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            For Each dir As String In Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

                'Jeden gefundenen Ordner in dem Arbeitsordner als Notensatz anlegen
                Dim ns As New Notensatz(Strings.Right(dir, My.Settings.NotensatzNrLength))
                ns.InDatenbankAnlegen()

            Next

        End If

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        'MsgBox(DataGridView1.CurrentCell.Value)

        'Detail.ShowData(DataGridView1.CurrentCell.Value)
        Detail.ShowData(New Notensatz(DataGridView1.CurrentRow.Cells(0).Value))


    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        'Auswerten eines Rechtsklicks
        'TODO: Eventuell ContextMenu einfügen

        If e.Button = MouseButtons.Right Then MsgBox("Rechtsklick")
    End Sub

    Private Sub RibbonButtonEinlesen_Click(sender As Object, e As EventArgs) Handles RibbonButtonEinlesen.Click
        'Öffnet das Fenster Einlesen
        Einlesen.Show()

    End Sub

    Private Sub TabelleAktualisieren()

        'Daten aus tbl_Notensatz werden in die BindingSource gelesen und in der DataGridView angezeigt

        BindingSource1.DataSource = GetSQL("SELECT * FROM tbl_Notensatz")
        DataGridView1.DataSource = BindingSource1

    End Sub

    Private Sub RibbonButtonEinstellungen_Click(sender As Object, e As EventArgs) Handles RibbonButtonEinstellungen.Click

        'Einstellungsfenster öffnen
        Einstellungen.Show()
    End Sub

    Private Sub tbFilter_TextChanged(sender As Object, e As EventArgs) Handles tbFilter.TextChanged
        'Filter aus tbFilter übernehmen
        'Filter funktioniert bisher mit Wildcards

        BindingSource1.Filter = String.Format("dt_NotensatzName LIKE '*{0}*' OR id_NotensatzNr LIKE '*{0}*' OR dt_ArrangeurName LIKE '*{0}*'", tbFilter.Text)
    End Sub
End Class