Public Class Stimme

    Public StimmeNr As String
    Public StimmeName As String
    Public Alternativen(3) As String

    Public Sub New(nr As String)
        StimmeNr = nr
        StimmeName = GetStimmeNameFromStimmeNr(nr)
        Alternativen = GetAlternativstimmen()

    End Sub

    Public Function Refresh() As Boolean

        Try
            StimmeName = GetStimmeNameFromStimmeNr(Me.StimmeNr)
            Alternativen = GetAlternativstimmen()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


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

    Public Function AlternativeÄndern(_altNr As String, _altStimme As String) As Boolean

        Try
            If Not _altStimme = Nothing Then
                SQLInterface.SetSQL(String.Format("UPDATE tbl_Stimme SET tbl_Stimme.fk_Alternative{0} = '{1}' WHERE (((tbl_Stimme.id_StimmeNr)='{2}'));", _altNr, _altStimme, Me.StimmeNr))
            Else
                SQLInterface.SetSQL(String.Format("UPDATE tbl_Stimme SET tbl_Stimme.fk_Alternative{0} = NULL WHERE (((tbl_Stimme.id_StimmeNr)='{1}'));", _altNr, Me.StimmeNr))
            End If

            RaiseEvent HasChanged(Me, New StimmeEventArgs(StimmeEventArgs.EventResult.OK))
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

#Region "Events"


    Public Event HasChanged(ByVal Sender As Object, ByVal e As StimmeEventArgs)


#End Region

End Class

Public Class StimmeEventArgs
    Inherits EventArgs

    'das was man später unter e sehen kann
    Public Result As EventResult
    'hier - als Beispiel - einfach eine Enum
    Public Enum EventResult
        OK
        Failed
    End Enum
    'Zum übergeben der Parameter
    Public Sub New(ByVal r As EventResult)
        Me.Result = r
    End Sub

End Class
