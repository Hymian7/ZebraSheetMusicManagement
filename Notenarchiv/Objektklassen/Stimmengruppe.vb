Imports System.Linq

Public Class Stimmengruppe
    Public Property StimmengruppenID As Integer
    Public Property StimmengruppenName As String

    Public Sub New(id As Integer)
        StimmengruppenID = id

        Try
            Dim dtr As New DataTableReader(GetSQL(String.Format("SELECT * FROM tbl_Stimmengruppen WHERE id_StimmengruppenID LIKE '{0}';", id)))
            dtr.Read()

            StimmengruppenName = dtr.GetString(dtr.GetOrdinal("dt_StimmengruppenName"))

        Catch e As Exception
            Exit Sub
        End Try

    End Sub

#Region "Shared Functions"

    Shared Function GetAlleStimmengruppen() As List(Of Stimmengruppe)
        Try

            Dim StGrList As New List(Of Stimmengruppe)

            Using dtr As New DataTableReader(GetSQL("SELECT * FROM tbl_Stimmengruppen"))
                While dtr.Read
                    StGrList.Add(New Stimmengruppe(dtr.GetInt32(dtr.GetOrdinal("id_StimmengruppenID"))))
                End While
            End Using

            Return StGrList


            'LINQ Beispiel
            'Dim StGrs = dt.AsEnumerable().Select(Function(StimGrup) New With {
            '                                        .StimmengruppenID = StimGrup.Field(Of Integer)("id_StimmengruppenID"),
            '                                        .StimengruppenName = StimGrup.Field(Of String)("dt_StimmengruppenName")
            '                                        }).ToList()





        Catch ex As Exception
            Return Nothing
        End Try


    End Function

#End Region

End Class
