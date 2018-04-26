Public Class Stimme

    Protected StimmeNr As String

    Public Sub New(nr As String)
        StimmeNr = nr
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
            Dim dtr As New DataTableReader(GetSQL(String.Format("SELECT dt_StimmeName FROM tbl_Stimme WHERE id_StimmeNr LIKE '{0}'", Strings.Left(Strings.Right(datei, 7), 3))))
            dtr.Read()

            Return dtr.GetString(dtr.GetOrdinal("dt_StimmeName"))
        Catch ex As Exception

        End Try

        Return Nothing
    End Function


End Class
