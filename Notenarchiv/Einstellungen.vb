Imports System.ComponentModel

Public Class Einstellungen
    Private Sub Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbArchivePath.Text = My.Settings.ArchivePath
        tbDBPath.Text = My.Settings.DBPath

    End Sub

    Private Sub btnChangeArchivePath_Click(sender As Object, e As EventArgs) Handles btnChangeArchivePath.Click
        If FolderBrowserDialogArchivePath.ShowDialog = DialogResult.OK Then
            tbArchivePath.Text = FolderBrowserDialogArchivePath.SelectedPath
        End If
    End Sub

    Private Sub btnChangeDBPath_Click(sender As Object, e As EventArgs) Handles btnChangeDBPath.Click
        If OpenFileDialogDBPath.ShowDialog = DialogResult.OK Then
            tbDBPath.Text = OpenFileDialogDBPath.FileName
        End If
    End Sub

    Private Sub Einstellungen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.ArchivePath = tbArchivePath.Text
        My.Settings.DBPath = tbDBPath.Text
        My.Settings.Save()
    End Sub
End Class