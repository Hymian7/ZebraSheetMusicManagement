Public Class NotensatzHinzufuegen

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    Private Sub rbManuell_CheckedChanged(sender As Object, e As EventArgs) Handles rbManuell.CheckedChanged
        If rbManuell.Checked = True Then

            panStimmenManuell.Show()

            olvVerfuegbareStimmen.ClearObjects()
            olvVerfuegbareStimmen.AddObjects(Stimme.GetAlleVerfuegbarenStimmen)
            olvVerfuegbareStimmen.AutoResizeColumns()
        ElseIf rbManuell.Checked = False Then
            panStimmenManuell.Hide()
        End If
    End Sub

    Private Sub btnAddStimme_Click(sender As Object, e As EventArgs) Handles btnAddStimme.Click
        olvAusgewaehlteStimmen.AddObjects(olvVerfuegbareStimmen.SelectedObjects)
        olvVerfuegbareStimmen.RemoveObjects(olvVerfuegbareStimmen.SelectedObjects)
        olvVerfuegbareStimmen.AutoResizeColumns()
        olvAusgewaehlteStimmen.AutoResizeColumns()
    End Sub

    Private Sub btnRemoveStimme_Click(sender As Object, e As EventArgs) Handles btnRemoveStimme.Click
        olvVerfuegbareStimmen.AddObjects(olvAusgewaehlteStimmen.SelectedObjects)
        olvAusgewaehlteStimmen.RemoveObjects(olvAusgewaehlteStimmen.SelectedObjects)
        olvVerfuegbareStimmen.AutoResizeColumns()
        olvAusgewaehlteStimmen.AutoResizeColumns()
    End Sub

    Private Sub olvVerfuegbareStimmen_DoubleClick(sender As Object, e As EventArgs) Handles olvVerfuegbareStimmen.DoubleClick
        olvAusgewaehlteStimmen.AddObjects(olvVerfuegbareStimmen.SelectedObjects)
        olvVerfuegbareStimmen.RemoveObjects(olvVerfuegbareStimmen.SelectedObjects)
        olvVerfuegbareStimmen.AutoResizeColumns()
        olvAusgewaehlteStimmen.AutoResizeColumns()
    End Sub

    Private Sub olvAusgewaehlteStimmen_DoubleClick(sender As Object, e As EventArgs) Handles olvAusgewaehlteStimmen.DoubleClick
        olvVerfuegbareStimmen.AddObjects(olvAusgewaehlteStimmen.SelectedObjects)
        olvAusgewaehlteStimmen.RemoveObjects(olvAusgewaehlteStimmen.SelectedObjects)
        olvVerfuegbareStimmen.AutoResizeColumns()
        olvAusgewaehlteStimmen.AutoResizeColumns()
    End Sub

    Private Sub NotensatzHinzufuegen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO nächsten freie Notensatz Nr finden und automatisch eintragen
    End Sub

    Private Sub btnHinzufuegen_Click(sender As Object, e As EventArgs) Handles btnHinzufuegen.Click

        If tbNotensatzNr.Text = String.Empty Then
            MsgBox("Es muss eine Notensatznummer angegeben sein!")
            Exit Sub
        End If


        If rbKeineNotenblaetter.Checked = True Then
            Dim ns As New Notensatz(tbNotensatzNr.Text, tbNotensatzName.Text, tbArrangeur.Text)
            ns.InDatenbankAnlegen()
            Me.Close()

        ElseIf rbManuell.Checked = True Then
            Dim ns As New Notensatz(tbNotensatzNr.Text, tbNotensatzName.Text, tbArrangeur.Text)
            ns.InDatenbankAnlegen()


            MsgBox(tbNotensatzNr.Text)

            For Each _stimme As Stimme In olvAusgewaehlteStimmen.Objects
                Dim _notenblatt As Notenblatt
                _notenblatt = New Notenblatt(tbNotensatzNr.Text, _stimme.StimmeNr)
                _notenblatt.InDatenbankAnlegen()
            Next


            Me.Close()
        End If
    End Sub
End Class