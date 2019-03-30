Public Class Detail

    Public CurrentNotensatz As Notensatz
    Public Event NotensatzAktualisiert(ns As Notensatz, e As EventArgs)

    Public Sub ShowData(curNS As Notensatz)

        'Der übergebene Notensatz wird in den Textboxen angezeigt, die vorhadnenen Stimmen werden aus Tabelle ausgelesen
        'TODO: Code aus diesem Sub in den Konstruktor schreiben und DetailForm mit New aufrufen
        Me.Show()
        CurrentNotensatz = curNS
        UpdateInformation()

    End Sub

    Private Sub tbNotensatzName_TextChanged(sender As Object, e As EventArgs) Handles tbNotensatzName.TextChanged
        btnUpdate.Enabled = True


    End Sub

    Private Sub tb_Arrangeur_TextChanged(sender As Object, e As EventArgs) Handles tbArrangeur.TextChanged
        btnUpdate.Enabled = True

        'TODO: Überarbeiten, weil TextChange auch greift, wenn Felder aus Datenbank gefüllt werden!
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'Veränderte Werte in Datenbank schreiben und Hauptfenster und Detailform aktualisieren
        CurrentNotensatz.InDatenbankAktualisieren(tbNotensatzName.Text, tbArrangeur.Text)
        RaiseEvent NotensatzAktualisiert(CurrentNotensatz, EventArgs.Empty)
        UpdateInformation()

    End Sub


    Sub UpdateInformation()

        tbNotensatzNr.Text = CurrentNotensatz.NotensatzNr
        tbNotensatzName.Text = CurrentNotensatz.NotensatzName
        tbArrangeur.Text = CurrentNotensatz.Arrangeur

        olvNotenblaetter.SetObjects(CurrentNotensatz.Notenblaetter)

    End Sub


    Private Sub olvNotenblaetter_DoubleClick(sender As Object, e As EventArgs) Handles olvNotenblaetter.DoubleClick


        Try
            Dim _nb As New Notenblatt(CurrentNotensatz.NotensatzNr, olvNotenblaetter.SelectedObject.StimmeNr)
            _nb.OpenPDF()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class