Public Class Detail

    Public Property CurrentNotensatz As Notensatz
    Public Event NotensatzAktualisiert(ns As Notensatz, e As EventArgs)

    Public Sub ShowData(curNS As Notensatz)

        'Der übergebene Notensatz wird in den Textboxen angezeigt, die vorhadnenen Stimmen werden aus Tabelle ausgelesen
        'TODO: Code aus diesem Sub in den Konstruktor schreiben und DetailForm mit New aufrufen
        Me.Show()
        CurrentNotensatz = curNS
        UpdateInformation()
        GetStimmen()

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

    Private Sub GetStimmen()

        'Stimmen aus Datenbank zu aktuellem Notensatz auslesen

        Try

            Dim dt As New DataTable()

            dt = GetSQL(String.Format("SELECT tbl_Notensatz.id_NotensatzNr, tbl_Notensatz.dt_NotensatzName, tbl_Stimme.dt_StimmeName, tbl_Notenblatt.fk_StimmeNr
FROM tbl_Stimme INNER JOIN (tbl_Notensatz INNER JOIN tbl_Notenblatt ON tbl_Notensatz.id_NotensatzNr = tbl_Notenblatt.fk_NotensatzNr) ON tbl_Stimme.id_StimmeNr = tbl_Notenblatt.fk_StimmeNr
WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", CurrentNotensatz.NotensatzNr))

            DataGridView1.DataSource = dt

            Dim dtr As New DataTableReader(dt)

            'Stimmen in Listbox auflisten
            Do While dtr.Read
                lbStimmen.Items.Add(dtr.GetValue(dtr.GetOrdinal("dt_StimmeName")))

            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub UpdateInformation()

        CurrentNotensatz.FillInformationByNotensatzNr()
        tbNotensatzNr.Text = CurrentNotensatz.NotensatzNr
        tbNotensatzName.Text = CurrentNotensatz.NotensatzName
        tbArrangeur.Text = CurrentNotensatz.Arrangeur


    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        'MsgBox(My.Settings.ArchivePath & "\" & CurrentNotensatz.NotensatzNr & "\" & DataGridView1.CurrentRow.Cells(3).Value & ".pdf")
        Try
            Process.Start(My.Settings.ArchivePath & "\" & CurrentNotensatz.NotensatzNr & "\" & DataGridView1.CurrentRow.Cells(3).Value & ".pdf")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class