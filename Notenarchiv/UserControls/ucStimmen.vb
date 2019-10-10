Public Class ucStimmen

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        'AddHandler Detail.NotensatzAktualisiert, AddressOf TabelleAktualisieren
        'AddHandler RibbonButtonAktualisieren.Click, AddressOf TabelleAktualisieren
        'AddHandler Me.Shown, AddressOf TabelleAktualisieren
    End Sub

    Public Sub TabelleAktualisieren()

        'Daten aus tbl_Notensatz werden in die DataListView eingetragen

        dlvStimmen.DataSource = GetSQL("SELECT * FROM tbl_Stimme")
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
        Dim frmDetail As New StimmeDetail(New Stimme(dlvStimmen.SelectedItem.Text))
        frmDetail.Show()
    End Sub
End Class
