Imports System.IO

Public Class Einlesen
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        tbPfad.Clear()

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            tbPfad.Text = FolderBrowserDialog1.SelectedPath
        End If

        For Each dir As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

            lbNotensatz.Items.Add(dir)

        Next

    End Sub

    Private Sub lbNotensatz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbNotensatz.SelectedIndexChanged

        lbStimmen.Items.Clear()

        If Not lbNotensatz.SelectedItem = "" Then

            For Each datei As String In Directory.GetFiles(lbNotensatz.SelectedItem)
                lbStimmen.Items.Add(Stimme.GetStimmeNameFromDatei(datei))
            Next

        Else lbStimmen.Items.Clear
        End If

    End Sub

    Private Sub btnEinlesen_Click(sender As Object, e As EventArgs) Handles btnEinlesen.Click


        For Each dir As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

            Dim ns As New Notensatz(Notensatz.GetNotensatzNrFromDateiname(dir))
            ns.InDatenbankAnlegen()

        Next

    End Sub

End Class