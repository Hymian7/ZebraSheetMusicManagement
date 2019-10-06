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
        IstVorhanden = CheckObVorhanden(My.Settings.ArchivePath + "\" + ns + "\" + stimme + ".pdf")
        StimmeName = Notenarchiv.Stimme.GetStimmeNameFromStimmeNr(stimme)
        Dateipfad = My.Settings.ArchivePath + "\" + NotensatzNr + "\" + StimmeNr + ".pdf"

    End Sub

    Private Function CheckObVorhanden(Optional AndererPfad As String = "") As Boolean

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

End Class
