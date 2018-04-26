Public Class Detail

    Public Property CurrentNotensatz As Notensatz
    Public Event NotensatzAktualisiert(ns As Notensatz, e As EventArgs)

    Public Sub ShowData(curNS As Notensatz)

        Me.Show()
        CurrentNotensatz = curNS
        CurrentNotensatz.FillInformationByNotensatzNr()
        UpdateInformation()
        GetStimmen()

    End Sub

    Private Sub tbNotensatzName_TextChanged(sender As Object, e As EventArgs) Handles tbNotensatzName.TextChanged
        btnUpdate.Enabled = True

        'Überarbeiten, weil TextChange auch greift, wenn Felder aus Datenbank gefüllt werden!
    End Sub

    Private Sub tb_Arrangeur_TextChanged(sender As Object, e As EventArgs) Handles tbArrangeur.TextChanged
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        CurrentNotensatz.InDatenbankAktualisieren(tbNotensatzName.Text, tbArrangeur.Text)
        RaiseEvent NotensatzAktualisiert(CurrentNotensatz, EventArgs.Empty)
        UpdateInformation()

    End Sub

    Private Sub GetStimmen()

        Try

            Dim dt As New DataTable()

            dt = GetSQL(String.Format("SELECT tbl_Notensatz.id_NotensatzNr, tbl_Notensatz.dt_NotensatzName, tbl_Stimme.dt_StimmeName
FROM tbl_Stimme INNER JOIN (tbl_Notensatz INNER JOIN tbl_Notenblatt ON tbl_Notensatz.id_NotensatzNr = tbl_Notenblatt.fk_NotensatzNr) ON tbl_Stimme.id_StimmeNr = tbl_Notenblatt.fk_StimmeNr
WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", CurrentNotensatz.NotensatzNr))

            DataGridView1.DataSource = dt

            Dim dtr As New DataTableReader(dt)

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

End Class