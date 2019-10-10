Public Class StimmeDetail

    Public Sub New(curStimme As Stimme)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        tbStimmeNr.Text = curStimme.StimmeNr
        tbStimmeName.Text = curStimme.StimmeName

        If curStimme.Alternativen(0) Is Nothing Then tbAlternative1.Text = "<Leer>"

    End Sub
End Class