Public Class Notenblatt

    Public Property NotensatzNr
    Public Property StimmeNr
    Public Property IstVorhanden
    Public ReadOnly Property Dateipfad = My.Settings.ArchivePath + "\" + NotensatzNr + "\" + StimmeNr + ".pdf"
    Public Property StimmeName
    'Public Property NotensatzName = Notensatz.GetNotensatzNameFromNr
    'TODO implementieren

    Public Sub New(ns, stimme)
        NotensatzNr = ns
        StimmeNr = stimme
        IstVorhanden = CheckObVorhanden(My.Settings.ArchivePath + "\" + ns + "\" + stimme + ".pdf")
        StimmeName = Notenarchiv.Stimme.GetStimmeNameFromStimmeNr(stimme)

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

    Public Sub OpenPDF()
        'TODO
        'Process.Start("Dateiname")
    End Sub

End Class
