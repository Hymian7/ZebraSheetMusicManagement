Public Class Stimme

    Public StimmeNr As String
    Public StimmeName As String
    Public Alternativen(3) As String

    Public Sub New(nr As String)
        StimmeNr = nr
        StimmeName = GetStimmeNameFromStimmeNr(nr)
        Alternativen = GetAlternativstimmen()

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

    Private Function GetAlternativstimmen() As String()


        Try
            Dim dtr As New DataTableReader(GetSQL(String.Format("SELECT tbl_Stimme.id_StimmeNr, tbl_Stimme.fk_Alternative1, tbl_Stimme.fk_Alternative2, tbl_Stimme.fk_Alternative3, tbl_Stimme.fk_Alternative4 FROM tbl_Stimme WHERE (((tbl_Stimme.id_StimmeNr)='{0}'));", Me.StimmeNr)))

            dtr.Read()

            Dim _alternativen(Me.Alternativen.Length - 1) As String

            For i As Byte = 0 To _alternativen.Length - 1


                If dtr.IsDBNull(dtr.GetOrdinal((String.Format("fk_Alternative{0}", i + 1)))) Then
                    Console.WriteLine("IsNull")
                    _alternativen(i) = Nothing
                Else
                    _alternativen(i) = dtr.GetString(dtr.GetOrdinal(String.Format("fk_Alternative{0}", i + 1)))
                End If

            Next


            Return _alternativen
        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Return Nothing
        End Try


    End Function

End Class
