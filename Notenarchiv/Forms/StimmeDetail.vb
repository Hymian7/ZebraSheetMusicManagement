Public Class StimmeDetail

    Private curStimme As Stimme

    Public Sub New(_curStimme As Stimme)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        Me.curStimme = _curStimme
        Me.Reload()

    End Sub

    Private Sub btnChangeAlt1_Click(sender As Object, e As EventArgs) Handles btnChangeAlt1.Click
        Dim _picker As New DialogStimmeAuswählen
        _picker.ShowDialog(Me)

        If _picker.DialogResult <> DialogResult.OK Then Exit Sub

        If curStimme.AlternativeÄndern(1, _picker.AusgewählteStimme.StimmeNr) Then
            curStimme.Refresh
            Me.Reload()
        Else
            MsgBox("Error")
        End If

    End Sub

    Private Sub btnChangeAlt2_Click(sender As Object, e As EventArgs) Handles btnChangeAlt2.Click
        Dim _picker As New DialogStimmeAuswählen
        _picker.ShowDialog(Me)

        If _picker.DialogResult <> DialogResult.OK Then Exit Sub

        If curStimme.AlternativeÄndern(2, _picker.AusgewählteStimme.StimmeNr) Then
            curStimme.Refresh()
            Me.Reload()
        Else
            MsgBox("Error")
        End If

    End Sub

    Private Sub btnChangeAlt3_Click(sender As Object, e As EventArgs) Handles btnChangeAlt3.Click
        Dim _picker As New DialogStimmeAuswählen
        _picker.ShowDialog(Me)

        If _picker.DialogResult <> DialogResult.OK Then Exit Sub

        If curStimme.AlternativeÄndern(3, _picker.AusgewählteStimme.StimmeNr) Then
            curStimme.Refresh()
            Me.Reload()
        Else
            MsgBox("Error")
        End If

    End Sub

    Private Sub btnChangeAlt4_Click(sender As Object, e As EventArgs) Handles btnChangeAlt4.Click
        Dim _picker As New DialogStimmeAuswählen
        _picker.ShowDialog(Me)

        If _picker.DialogResult <> DialogResult.OK Then Exit Sub

        If curStimme.AlternativeÄndern(4, _picker.AusgewählteStimme.StimmeNr) Then
            curStimme.Refresh()
            Me.Reload()
        Else
            MsgBox("Error")
        End If

    End Sub

    Private Sub Reload()

        tbStimmeNr.Text = Me.curStimme.StimmeNr
        tbStimmeName.Text = Me.curStimme.StimmeName

        If curStimme.Alternativen(0) Is Nothing Then tbAlternative1.Text = "<Leer>" Else tbAlternative1.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(0))
        If curStimme.Alternativen(1) Is Nothing Then tbAlternative2.Text = "<Leer>" Else tbAlternative2.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(1))
        If curStimme.Alternativen(2) Is Nothing Then tbAlternative3.Text = "<Leer>" Else tbAlternative3.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(2))
        If curStimme.Alternativen(3) Is Nothing Then tbAlternative4.Text = "<Leer>" Else tbAlternative4.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(3))

    End Sub
End Class