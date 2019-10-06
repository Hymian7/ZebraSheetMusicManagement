Public Class Detail

    Public CurrentNotensatz As Notensatz
    Public Property DataChanged As Boolean = False

    Public Sub New(curNS As Notensatz)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        CurrentNotensatz = curNS
        UpdateInformation()
        Me.Show()

    End Sub

    Private Sub tbNotensatzName_TextChanged(sender As Object, e As EventArgs) Handles tbNotensatzName.TextChanged
        RibbonButtonRefresh.Enabled = True
        Me.DataChanged = True
        'TODO: Überarbeiten, weil TextChange auch greift, wenn Felder aus Datenbank gefüllt werden!

    End Sub

    Private Sub tb_Arrangeur_TextChanged(sender As Object, e As EventArgs) Handles tbArrangeur.TextChanged
        RibbonButtonRefresh.Enabled = True
        Me.DataChanged = True

        'TODO: Überarbeiten, weil TextChange auch greift, wenn Felder aus Datenbank gefüllt werden!
    End Sub

    Sub UpdateInformation()

        tbNotensatzNr.Text = CurrentNotensatz.NotensatzNr
        tbNotensatzName.Text = CurrentNotensatz.NotensatzName
        tbArrangeur.Text = CurrentNotensatz.Arrangeur

        RibbonButtonRefresh.Enabled = False
        Me.DataChanged = False

        olvNotenblaetter.SetObjects(CurrentNotensatz.Notenblaetter)
        olvNotenblaetter.AutoResizeColumns()

        dlvVerzeichnisse.DataSource = GetSQL(String.Format("SELECT tbl_Programm.fk_VerzeichnisNr, tbl_Verzeichnis.dt_VerzeichnisName, tbl_Programm.id_ProgrammNr FROM (tbl_Notensatz INNER JOIN tbl_Programm ON tbl_Notensatz.id_NotensatzNr = tbl_Programm.fk_NotensatzNr) INNER JOIN tbl_Verzeichnis ON tbl_Programm.fk_VerzeichnisNr = tbl_Verzeichnis.id_VerzeichnisNr WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", CurrentNotensatz.NotensatzNr))
        dlvVerzeichnisse.Columns(0).Text = "VerzeichnisNr"
        dlvVerzeichnisse.Columns(1).Text = "VerzeichnisName"
        dlvVerzeichnisse.Columns(2).Text = "Programmpunkt"
        dlvVerzeichnisse.AutoResizeColumns()

        Me.Text = "Detail - " + CurrentNotensatz.NotensatzName

    End Sub


    Private Sub olvNotenblaetter_DoubleClick(sender As Object, e As EventArgs) Handles olvNotenblaetter.DoubleClick

        Try
            Dim _nb As New Notenblatt(CurrentNotensatz.NotensatzNr, olvNotenblaetter.SelectedObject.StimmeNr)
            _nb.OpenPDF()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RibbonButtonRefresh_Click(sender As Object, e As EventArgs) Handles RibbonButtonRefresh.Click
        'Veränderte Werte in Datenbank schreiben und Hauptfenster und Detailform aktualisieren
        If CurrentNotensatz.InDatenbankAktualisieren(tbNotensatzName.Text, tbArrangeur.Text) = True Then
            CurrentNotensatz.Refresh()
            UpdateInformation()
        End If

    End Sub

    Private Sub Detail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DataChanged = True Then

            Dim res As MsgBoxResult = MsgBox("Wollen Sie die Änderungen speichern?", MsgBoxStyle.YesNoCancel, "Änderungen speichern")

            If res = MsgBoxResult.Yes Then
                CurrentNotensatz.InDatenbankAktualisieren(tbNotensatzName.Text, tbArrangeur.Text)

            ElseIf res = MsgBoxResult.No Then
                e.Cancel = False

            ElseIf res = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If


        End If
    End Sub

    Private Sub RibbonButtonAddToVerzeichnis_Click(sender As Object, e As EventArgs) Handles RibbonButtonAddToVerzeichnis.Click
        Dim dia As New DialogVerzeichnisAuswählen

        If dia.ShowDialog(Me) <> DialogResult.Cancel Then
            'TODO Verzeichnis anfügen

            dia.SelectedVerzeichnis.AddNotensatz(CurrentNotensatz)
            Hauptfenster.ucInhaltsverzeichnisse.ProgrammAktualisieren()

        End If
    End Sub
End Class