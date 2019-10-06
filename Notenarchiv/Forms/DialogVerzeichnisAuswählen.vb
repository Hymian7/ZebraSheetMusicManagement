Imports System.Windows.Forms

Public Class DialogVerzeichnisAuswählen

    Public Property SelectedVerzeichnis As Verzeichnis

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, dlvVerzeichnisse.DoubleClick
        If dlvVerzeichnisse.SelectedIndex <> -1 Then
            Me.DialogResult = DialogResult.OK
            Me.SelectedVerzeichnis = New Verzeichnis(dlvVerzeichnisse.SelectedItem.Text)
            Me.Close()
        Else
            MsgBox("Notensatz auswählen!!!")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogVerzeichnisAuswählen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dlvVerzeichnisse.DataSource = GetSQL("SELECT * FROM tbl_Verzeichnis")
        dlvVerzeichnisse.Columns(0).Text = "VerzeichnisNr"
        dlvVerzeichnisse.Columns(1).Text = "VerzeichnisName"
        dlvVerzeichnisse.Columns(2).Text = "Datum"
        dlvVerzeichnisse.AutoResizeColumns()
    End Sub

End Class
