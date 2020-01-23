Imports System.Windows.Forms

Public Class DialogStimmeAuswählen

    Public AusgewählteStimme

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        TabelleAktualisieren()
        Me.AusgewählteStimme = Nothing

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.AusgewählteStimme = New Stimme(dlvStimmen.SelectedItem.Text)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub TabelleAktualisieren()

        'Daten aus tbl_Notensatz werden in die DataListView eingetragen

        dlvStimmen.DataSource = GetSQL("SELECT id_StimmeNr, dt_StimmeName FROM tbl_Stimme")
        dlvStimmen.Columns(0).Text = "StimmeID"
        dlvStimmen.Columns(1).Text = "Stimme"
        dlvStimmen.AutoResizeColumns()

    End Sub

    Private Sub tbFilter_TextChanged(sender As Object, e As EventArgs) Handles tbFilter.TextChanged
        'Filter aus tbFilter übernehmen
        'TODO: Modelfilter statt Textmatchfilter

        dlvStimmen.ModelFilter = New BrightIdeasSoftware.TextMatchFilter(dlvStimmen).Contains(dlvStimmen, tbFilter.Text)

    End Sub

    Private Sub dlvStimmen_DoubleClick(sender As Object, e As EventArgs) Handles dlvStimmen.DoubleClick
        Me.AusgewählteStimme = New Stimme(dlvStimmen.SelectedItem.Text)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class
