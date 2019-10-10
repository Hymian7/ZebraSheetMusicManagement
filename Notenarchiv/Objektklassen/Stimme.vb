Public Class Stimme

    Public StimmeNr As String
    Public StimmeName As String
    Public Alternativen(4) As Stimme

    Public Sub New(nr As String)
        StimmeNr = nr
        StimmeName = GetStimmeNameFromStimmeNr(nr)

        For Each alt As Stimme In Alternativen
            alt = Nothing
        Next

    End Sub

    Shared Function GetStimmeNameFromStimmeNr(nr As String) As String

        Try
            Dim dtr As New DataTableReader(GetSQL(String.Format("SELECT dt_StimmeName FROM tbl_Stimme WHERE id_StimmeNr LIKE '{0}'", nr)))
            dtr.Read()

            Return dtr.GetString(dtr.GetOrdinal("dt_StimmeName"))
        Catch ex As Exception

        End Try

        Return Nothing
    End Function

    Shared Function GetStimmeNameFromDatei(datei As String) As String

        Try
            Dim dtr As New DataTableReader(GetSQL(String.Format("SELECT dt_StimmeName FROM tbl_Stimme WHERE id_StimmeNr LIKE '{0}'", Strings.Left(Strings.Right(datei, My.Settings.StimmeNrLength + 4), My.Settings.StimmeNrLength))))
            dtr.Read()

            Return dtr.GetString(dtr.GetOrdinal("dt_StimmeName"))
        Catch ex As Exception

        End Try

        Return Nothing
    End Function

    Public Shared Function GetAlleVerfuegbarenStimmen() As Stimme()

        Try
            Dim dt As New DataTable()
            dt = GetSQL("SELECT * FROM tbl_Stimme")

            Dim _AlleStimmen(dt.Rows.Count - 1) As Stimme

            Dim dtr As New DataTableReader(dt)


            For i As Integer = 0 To dt.Rows.Count - 1
                dtr.Read()
                _AlleStimmen(i) = New Stimme(dtr.GetString(dtr.GetOrdinal("id_StimmeNr")))
            Next

            Return _AlleStimmen
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Class
