Public Class Notenblatt

    Public Property NotenblattNr
    Public Property StimmeNr

    Public Sub New(nb, stimme)
        NotenblattNr = nb
        StimmeNr = stimme
    End Sub

    Public Sub OpenPDF()
        'TODO
        'Process.Start("Dateiname")
    End Sub

End Class
