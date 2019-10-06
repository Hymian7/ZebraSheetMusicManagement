Public Class Inhaltsverzeichnisse

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        AddHandler dlvVerzeichnisse.SelectionChanged, AddressOf ProgrammAktualisieren

        Try
            InhaltsverzeichnisseAktualisieren()
        Catch e As Exception
            MsgBox(e.Message)
        End Try


    End Sub

    Public Sub InhaltsverzeichnisseAktualisieren()
        'Daten aus tbl_Notensatz werden in die DataListView eingetragen

        dlvVerzeichnisse.DataSource = GetSQL("SELECT * FROM tbl_Verzeichnis")
        dlvVerzeichnisse.Columns(0).Text = "VerzeichnisNr"
        dlvVerzeichnisse.Columns(1).Text = "VerzeichnisName"
        dlvVerzeichnisse.Columns(2).Text = "Datum"
        dlvVerzeichnisse.AutoResizeColumns()
    End Sub

    Public Sub ProgrammAktualisieren()

        If dlvVerzeichnisse.SelectedIndex <> -1 Then

            Dim vz As New Verzeichnis(dlvVerzeichnisse.SelectedItem.Text)

            olvProgramm.Objects = vz.Programmliste
        Else
            olvProgramm.Clear()
        End If

    End Sub

    Private Sub olvProgramm_DoubleClick(sender As Object, e As EventArgs) Handles olvProgramm.DoubleClick
        Dim frmDetail As Detail = New Detail(olvProgramm.SelectedObject.Notensatz)

    End Sub
End Class
