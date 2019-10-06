﻿Public Class Notensatz

    Public Property NotensatzNr As String
    Public Property NotensatzName As String
    Public Property Arrangeur As String

    Private Const StandardName As String = "<Neuer Notensatz>"
    Private Const StandardArrangeur As String = "<Neuer Arrangeur>"

    Public Event NotensatzAktualisiert(sender As Notensatz, e As EventArgs)
    Public Event NotensatzAngelegt(sender As Notensatz, e As EventArgs)

    Public ReadOnly Property Notenblaetter As Notenblatt()
        Get
            'Stimmen aus Datenbank zu Notensatz auslesen und Notenblatt-Array zurückgeben
            Try
                Dim dt As New DataTable()

                dt = GetSQL(String.Format("SELECT tbl_Notensatz.id_NotensatzNr, tbl_Notensatz.dt_NotensatzName, tbl_Stimme.dt_StimmeName, tbl_Notenblatt.fk_StimmeNr
                                        FROM tbl_Stimme INNER JOIN (tbl_Notensatz INNER JOIN tbl_Notenblatt ON tbl_Notensatz.id_NotensatzNr = tbl_Notenblatt.fk_NotensatzNr) ON tbl_Stimme.id_StimmeNr = tbl_Notenblatt.fk_StimmeNr
                                        WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", NotensatzNr))


                Dim _Notenblaetter(dt.Rows.Count - 1) As Notenblatt
                Dim dtr As New DataTableReader(dt)

                For i As Integer = 0 To dt.Rows.Count - 1
                    dtr.Read()
                    _Notenblaetter(i) = New Notenblatt(dtr.GetValue(dtr.GetOrdinal("id_NotensatzNr")), dtr.GetValue(dtr.GetOrdinal("fk_StimmeNr")))
                Next

                Return _Notenblaetter

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Get
    End Property

    Public Sub New(id As String, Optional name As String = StandardName, Optional arr As String = StandardArrangeur)

        NotensatzNr = id

        If CheckObInDatenbankVorhanden() = False Then

            NotensatzName = name
            Arrangeur = arr

        ElseIf CheckObInDatenbankVorhanden() = True Then
            FillInformationByNotensatzNr()

        End If


    End Sub

    Public Function InDatenbankAnlegen() As Boolean

        Try
            SQLInterface.SetSQL(String.Format("INSERT INTO tbl_Notensatz (id_NotensatzNr, dt_NotensatzName, dt_ArrangeurName) VALUES ('{0}', '{1}', '{2}');", NotensatzNr, NotensatzName, Arrangeur))
            RaiseEvent NotensatzAngelegt(Me, EventArgs.Empty)
            'Bei erfolgreich True zurückgeben
            Return True
        Catch ex As Exception

        End Try

        'Falls nicht erfolgreich, False zurückgeben
        Return False
    End Function

    Public Function InDatenbankAktualisieren(newName As String, newArrangeur As String) As Boolean

        Try
            'Console.WriteLine(String.Format("UPDATE tbl_Notensatz SET tbl_Notensatz.dt_NotensatzName = '{1}', tbl_Notensatz.dt_ArrangeurName = '{2}' WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", NotensatzNr, newName, newArrangeur))
            SQLInterface.SetSQL(String.Format("UPDATE tbl_Notensatz SET tbl_Notensatz.dt_NotensatzName = '{1}', tbl_Notensatz.dt_ArrangeurName = '{2}' WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", NotensatzNr, newName, newArrangeur))

            RaiseEvent NotensatzAktualisiert(Me, EventArgs.Empty)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function FillInformationByNotensatzNr() As Boolean

        Try
            Dim dt As New DataTable
            dt = GetSQL(String.Format("SELECT tbl_Notensatz.dt_NotensatzName, tbl_Notensatz.dt_ArrangeurName FROM tbl_Notensatz WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", NotensatzNr))

            Dim dtr As New DataTableReader(dt)
            dtr.Read()

            NotensatzName = dtr.GetString(dtr.GetOrdinal("dt_NotensatzName"))
            Arrangeur = dtr.GetString(dtr.GetOrdinal("dt_ArrangeurName"))

            Return True
        Catch e As Exception
            Return False
        End Try
    End Function

    Private Function CheckObInDatenbankVorhanden() As Boolean
        Dim dt As New DataTable
        dt = GetSQL(String.Format("SELECT tbl_Notensatz.id_NotensatzNr FROM tbl_Notensatz WHERE (((tbl_Notensatz.id_NotensatzNr) Like '{0}'));", NotensatzNr))

        Dim dtr As New DataTableReader(dt)
        dtr.Read()


        If dtr.HasRows Then
            Return True
        Else Return False
        End If

    End Function

    Public Shared Function GetNotensatzNrFromDateipfad(ByVal pfad As String) As String
        Return Strings.Right(pfad, My.Settings.NotensatzNrLength)
    End Function

    Public Function Refresh() As Boolean
        Try
            If FillInformationByNotensatzNr() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Sub AusBarcodesAnlegen(barcodes As Bytescout.BarCodeReader.FoundBarcode())

        Dim newids As List(Of String) = New List(Of String)

        For Each bc In barcodes
            If Not newids.Contains(Left(bc.Value, My.Settings.NotensatzNrLength)) Then
                newids.Add(Left(bc.Value, My.Settings.NotensatzNrLength))
            End If
        Next

        For Each newid In newids
            Dim ns As New Notensatz(newid)
            If Not ns.CheckObInDatenbankVorhanden() Then ns.InDatenbankAnlegen()
        Next
    End Sub


End Class
