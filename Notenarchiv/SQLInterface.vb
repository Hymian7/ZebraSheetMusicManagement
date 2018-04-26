﻿Imports System.Data.OleDb
Imports System.IO


Module SQLInterface

    Public cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Dokumente\Visual Studio 2015\Projects\Notenarchiv\Notenarchiv\database\db.accdb'")
    Public cmd As New OleDbCommand

    Public Function GetSQL(ByVal SQLString As String) As DataTable

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Dim da As New OleDbDataAdapter(SQLString, cnn)

        Dim dt As New DataTable
        da.Fill(dt)

        cnn.Close()

        Return dt
    End Function

    Public Function SetSQL(ByVal SQLString As String) As Boolean

        Try
            Dim cmd As New OleDb.OleDbCommand(SQLString, cnn)

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

End Module
