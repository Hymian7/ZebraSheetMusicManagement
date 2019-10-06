Public Class Notenblatt

    Public Property NotensatzNr
    Public Property StimmeNr
    Public Property IstVorhanden
    Public ReadOnly Property Dateipfad
    Public Property StimmeName
    'Public Property NotensatzName = Notensatz.GetNotensatzNameFromNr
    'TODO implementieren

    Public Sub New(ns, stimme)
        NotensatzNr = ns
        StimmeNr = stimme
        IstVorhanden = CheckObDateiVorhanden(My.Settings.ArchivePath + "\" + ns + "\" + stimme + ".pdf")
        StimmeName = Notenarchiv.Stimme.GetStimmeNameFromStimmeNr(stimme)
        Dateipfad = My.Settings.ArchivePath + "\" + NotensatzNr + "\" + StimmeNr + ".pdf"

    End Sub

    Private Function CheckObDateiVorhanden(Optional AndererPfad As String = "") As Boolean

        If AndererPfad <> "" Then
            If System.IO.File.Exists(AndererPfad) Then
                Return True
            Else
                Return False
            End If
        Else
            If System.IO.File.Exists(Dateipfad) Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

    Private Function CheckObInDatenbankVorhanden() As Boolean
        Dim dt As New DataTable
        dt = GetSQL(String.Format("SELECT tbl_Notenblatt.fk_NotensatzNr, tbl_Notenblatt.fk_StimmeNr FROM tbl_Notenblatt WHERE (((tbl_Notenblatt.fk_NotensatzNr) Like '{0}') AND ((tbl_Notenblatt.fk_StimmeNr) Like '{1}'));", NotensatzNr, StimmeNr))

        Dim dtr As New DataTableReader(dt)
        dtr.Read()


        If dtr.HasRows Then
            Return True
        Else Return False
        End If
    End Function

    Public Function InDatenbankAnlegen() As Boolean

        Try
            SQLInterface.SetSQL(String.Format("INSERT INTO tbl_Notenblatt (fk_NotensatzNr, fk_StimmeNr) VALUES ('{0}', '{1}');", NotensatzNr, StimmeNr))
            'Bei erfolgreich True zurückgeben
            Return True
        Catch ex As Exception
            Return False
        End Try

        'Falls nicht erfolgreich, False zurückgeben

    End Function

    Public Sub OpenPDF()
        Process.Start(Dateipfad)
    End Sub

    Public Shared Sub AusBarcodesAnlegen(barcodes As Bytescout.BarCodeReader.FoundBarcode())

        Dim newsheets As List(Of Notenblatt) = New List(Of Notenblatt)

        For Each bc In barcodes
            If Not newsheets.Contains(New Notenblatt(Left(bc.Value, My.Settings.NotensatzNrLength), Right(bc.Value, My.Settings.StimmeNrLength))) Then
                newsheets.Add(New Notenblatt(Left(bc.Value, My.Settings.NotensatzNrLength), Right(bc.Value, My.Settings.StimmeNrLength)))
            End If
        Next

        For Each newsheet In newsheets
            If Not newsheet.CheckObInDatenbankVorhanden Then newsheet.InDatenbankAnlegen()
        Next
    End Sub

End Class
