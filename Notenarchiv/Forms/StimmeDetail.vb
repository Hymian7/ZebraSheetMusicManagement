Public Class StimmeDetail

    Public Sub New(curStimme As Stimme)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        tbStimmeNr.Text = curStimme.StimmeNr
        tbStimmeName.Text = curStimme.StimmeName

        If curStimme.Alternativen(0) Is Nothing Then tbAlternative1.Text = "<Leer>" Else tbAlternative1.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(0))
        If curStimme.Alternativen(1) Is Nothing Then tbAlternative2.Text = "<Leer>" Else tbAlternative2.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(1))
        If curStimme.Alternativen(2) Is Nothing Then tbAlternative3.Text = "<Leer>" Else tbAlternative3.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(2))
        If curStimme.Alternativen(3) Is Nothing Then tbAlternative4.Text = "<Leer>" Else tbAlternative4.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(3))

    End Sub
End Class