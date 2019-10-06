Public Class Verzeichnis

    Public Property VerzeichnisNr As String
    Public Property VerzeichnisName As String
    Public Property VerzeichnisDatum As DateTime

    Public Property Programmliste As List(Of Programmpunkt)
        Get
            'Stimmen aus Datenbank zu Verzeichnis auslesen und Programm-Dictionary zurückgeben
            Try
                Dim dt As New DataTable()

                dt = GetSQL(String.Format("SELECT * from tbl_Programm WHERE (((tbl_Programm.fk_VerzeichnisNr) Like '{0}'));", VerzeichnisNr))

                Dim dtr As New DataTableReader(dt)
                Dim _Programmliste As List(Of Programmpunkt) = New List(Of Programmpunkt)

                While dtr.Read

                    _Programmliste.Add(New Programmpunkt(New Notensatz(dtr.GetValue(dtr.GetOrdinal("fk_NotensatzNr"))), dtr.GetValue(dtr.GetOrdinal("id_ProgrammNr"))))

                End While

                '_Programmliste.Sort()
                Return _Programmliste

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Get
        Set

        End Set
    End Property

    Public Sub New(id As String, Optional name As String = Nothing, Optional datum As DateTime = Nothing)

        VerzeichnisNr = id

        If CheckObVorhanden() = False Then

            VerzeichnisName = name
            VerzeichnisDatum = Now.Date

        ElseIf CheckObVorhanden() = True Then
            FillInformationByVerzeichnisNr()
        End If

    End Sub

    Private Function CheckObVorhanden() As Boolean

        Dim dt As New DataTable
        dt = GetSQL(String.Format("SELECT tbl_Verzeichnis.id_VerzeichnisNr FROM tbl_Verzeichnis WHERE (((tbl_Verzeichnis.id_VerzeichnisNr) Like '{0}'));", VerzeichnisNr))

        Dim dtr As New DataTableReader(dt)
        dtr.Read()

        If dtr.HasRows Then
            Return True
        Else Return False
        End If

    End Function

    Private Function FillInformationByVerzeichnisNr() As Boolean

        Try
            Dim dt As New DataTable
            dt = GetSQL(String.Format("SELECT tbl_Verzeichnis.dt_VerzeichnisName, tbl_Verzeichnis.dt_VerzeichnisDatum FROM tbl_Verzeichnis WHERE (((tbl_Verzeichnis.id_VerzeichnisNr) Like '{0}'));", VerzeichnisNr))

            Dim dtr As New DataTableReader(dt)
            dtr.Read()

            VerzeichnisName = dtr.GetString(dtr.GetOrdinal("dt_VerzeichnisName"))
            VerzeichnisDatum = dtr.GetString(dtr.GetOrdinal("dt_VerzeichnisDatum"))

            Return True
        Catch e As Exception
            Return False
        End Try
    End Function

    Public Function InDatenbankAnlegen() As Boolean

        Try
            SQLInterface.SetSQL(String.Format("INSERT INTO tbl_Verzeichnis (id_VerzeichnisNr, dt_VerzeichnisName, dt_VerzeichnisDatum) VALUES ('{0}', '{1}', '{2}');", VerzeichnisNr, VerzeichnisName, VerzeichnisDatum))

            'Bei erfolgreich True zurückgeben
            Return True
        Catch ex As Exception

        End Try

        'Falls nicht erfolgreich, False zurückgeben
        Return False
    End Function

    Public Function InDatenbankAktualisieren(newName As String, newDate As String) As Boolean

        Try
            'Console.WriteLine(String.Format("UPDATE tbl_Notensatz SET tbl_Notensatz.dt_NotensatzName = '{1}', tbl_Notensatz.dt_ArrangeurName = '{2}' WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", NotensatzNr, newName, newArrangeur))
            SQLInterface.SetSQL(String.Format("UPDATE tbl_Verzeichnis SET tbl_Verzeichnis.dt_VerzeichnisName = '{1}', tbl_Verzeichnis.dt_VerzeichnisDatum = '{2}' WHERE (((tbl_Verzeichnis.id_VerzeichnisNr) Like '{0}'));", VerzeichnisNr, newName, newDate))
            FillInformationByVerzeichnisNr()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            FillInformationByVerzeichnisNr()
            Return False
        End Try
    End Function

    Public Sub AddNotensatz(ns As Notensatz)

        Dim nextProgrammNummer As Integer

        If Not Programmliste.Count = 0 Then
            nextProgrammNummer = Programmliste.Max(Function(p As Programmpunkt) p.ProgrammNr) + 1
        Else
            nextProgrammNummer = 1
        End If

        Try
            SQLInterface.SetSQL(String.Format("INSERT INTO  tbl_Programm ( fk_VerzeichnisNr, id_ProgrammNr, fk_NotensatzNr ) VALUES ('{0}', '{1}', '{2}');", VerzeichnisNr, nextProgrammNummer, ns.NotensatzNr))

        Catch ex As Exception

        End Try

        'TODO

    End Sub

End Class
