Public Class NotensatzHinzufuegen
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    Private Sub rbManuell_CheckedChanged(sender As Object, e As EventArgs) Handles rbManuell.CheckedChanged
        If rbManuell.Checked = True Then


            olvVerfuegbareStimmen.AddObjects(Stimme.GetAlleVerfuegbarenStimmen)
            olvVerfuegbareStimmen.AutoResizeColumns()
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
End Class