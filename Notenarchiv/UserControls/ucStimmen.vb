Imports System.IO

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

    Private Function dlvStimmen_DoubleClick(sender As Object, e As EventArgs) Handles dlvStimmen.DoubleClick
        Dim frmDetail As New StimmeDetail(New Stimme(dlvStimmen.SelectedItem.Text))
        frmDetail.Show()
        Return Nothing
    End Function

    Private Sub btn_treeview_Click(sender As Object, e As EventArgs) Handles btn_treeview.Click
        'Alle verfügbaren Stimmen in DataTreeListView

        'tlvStimmenBaum.CanExpandGetter = Function(ByVal x) (TypeOf x Is Stimmengruppe)
        'tlvStimmenBaum.ChildrenGetter = Function(ByVal x)
        '                                    Dim StimList As New List(Of Stimme)
        '                                    Dim StimGrup = CType(x, Stimmengruppe)
        '                                    For Each stim As Stimme In Stimme.GetAlleVerfuegbarenStimmen
        '                                        If stim.StimmengruppenID = StimGrup.StimmengruppenID Then StimList.Add(stim)
        '                                    Next

        '                                    Return StimList

        '                                End Function

        'tlvStimmenBaum.Roots = Stimmengruppe.GetAlleStimmengruppen
        'tlvStimmenBaum.AutoResizeColumns()

        tlvStimmenBaum.CanExpandGetter = AddressOf tlv_canexpandgetter
        tlvStimmenBaum.ChildrenGetter = AddressOf tlv_childrengetter_delegate
        tlvStimmenBaum.SetObjects(Stimmengruppe.GetAlleStimmengruppen)
    End Sub

    Private Function tlv_canexpandgetter(ByVal tlv_root As Object) As Boolean
        If TypeOf tlv_root Is Stimmengruppe Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function tlv_childrengetter_delegate(ByVal tlv_root As Stimmengruppe) As List(Of Stimme)
        Dim StimList As New List(Of Stimme)
        For Each stim As Stimme In Stimme.GetAlleVerfuegbarenStimmen
            If stim.StimmengruppenID = tlv_root.StimmengruppenID Then StimList.Add(stim)
        Next

        Return StimList
    End Function
End Class
