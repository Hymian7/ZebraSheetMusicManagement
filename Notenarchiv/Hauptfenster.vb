Imports System.Data.OleDb
Imports System.IO
Imports Notenarchiv.SQLInterface

Public Class Hauptfenster

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Detail.NotensatzAktualisiert, AddressOf TabelleAktualisieren
        AddHandler Me.Shown, AddressOf TabelleAktualisieren

    End Sub

    Private Sub RibbonButton_Importieren_Click(sender As Object, e As EventArgs) Handles RibbonButton_Importieren.Click
        Sortierer.Show()
    End Sub



    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        TabelleAktualisieren()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            For Each dir As String In Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

                'Jeden gefundenen Ordner in dem Arbeitsordner als Notensatz anlegen
                Dim ns As New Notensatz(Strings.Right(dir, 6))
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
        If e.Button = MouseButtons.Right Then MsgBox("Rechtsklick")
    End Sub

    Private Sub RibbonButtonEinlesen_Click(sender As Object, e As EventArgs) Handles RibbonButtonEinlesen.Click

        Einlesen.Show()

    End Sub

    Private Sub TabelleAktualisieren()
        DataGridView1.DataSource = GetSQL("SELECT * FROM tbl_Notensatz")
    End Sub

    Private Sub btn_Einstellungen_Click(sender As Object, e As EventArgs) Handles btn_Einstellungen.Click
        Einstellungen.Show()
    End Sub

End Class