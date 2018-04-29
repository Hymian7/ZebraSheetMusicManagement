Public Class Notensatz

    Public Property NotensatzNr As String
    Public Property NotensatzName As String
    Public Property Arrangeur As String


    Public Sub New(id As String, Optional name As String = Nothing, Optional arr As String = Nothing)

        NotensatzNr = id
        NotensatzName = name
        Arrangeur = arr

    End Sub

    Public Function InDatenbankAnlegen() As Boolean

        Try
            SQLInterface.SetSQL(String.Format("INSERT INTO tbl_Notensatz (id_NotensatzNr, dt_NotensatzName, dt_ArrangeurName) VALUES ('{0}', '{1}', '{2}');", NotensatzNr, NotensatzName, Arrangeur))

            'Bei erfolgreich True zurückgeben
            Return True
        Catch ex As Exception

        End Try

        'Falls nicht erfolgreich, False zurückgeben
        Return False
    End Function

    Public Function InDatenbankAktualisieren(newName As String, newArrangeur As String) As Boolean

        Try
            Console.WriteLine(String.Format("UPDATE tbl_Notensatz SET tbl_Notensatz.dt_NotensatzName = '{1}', tbl_Notensatz.dt_ArrangeurName = '{2}' WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", NotensatzNr, newName, newArrangeur))
            SQLInterface.SetSQL(String.Format("UPDATE tbl_Notensatz SET tbl_Notensatz.dt_NotensatzName = '{1}', tbl_Notensatz.dt_ArrangeurName = '{2}' WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", NotensatzNr, newName, newArrangeur))

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub FillInformationByNotensatzNr()

        Dim dt As New DataTable
        dt = GetSQL(String.Format("SELECT tbl_Notensatz.dt_NotensatzName, tbl_Notensatz.dt_ArrangeurName FROM tbl_Notensatz WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", NotensatzNr))

        Dim dtr As New DataTableReader(dt)
        dtr.Read()

        NotensatzName = dtr.GetString(dtr.GetOrdinal("dt_NotensatzName"))
        Arrangeur = dtr.GetString(dtr.GetOrdinal("dt_ArrangeurName"))

    End Sub

    Public Shared Function GetNotensatzNrFromDateiname(ByVal pfad As String) As String
        Return Strings.Right(pfad, My.Settings.NotensatzNrLength)
    End Function


End Class
