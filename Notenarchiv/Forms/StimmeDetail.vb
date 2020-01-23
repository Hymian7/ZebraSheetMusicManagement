Public Class StimmeDetail

    Private curStimme As Stimme

    Public Sub New(_curStimme As Stimme)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        Me.curStimme = _curStimme
        Me.Reload()

        AddHandler Me.curStimme.HasChanged, AddressOf Me.Reload

    End Sub

    Private Sub btnChangeAlt1_Click(sender As Object, e As EventArgs) Handles btnChangeAlt1.Click
        Dim _picker As New DialogStimmeAuswählen
        _picker.ShowDialog(Me)

        If _picker.DialogResult <> DialogResult.OK Then Exit Sub

        curStimme.AlternativeÄndern(1, _picker.AusgewählteStimme.StimmeNr)

    End Sub

    Private Sub btnChangeAlt2_Click(sender As Object, e As EventArgs) Handles btnChangeAlt2.Click
        Dim _picker As New DialogStimmeAuswählen
        _picker.ShowDialog(Me)

        If _picker.DialogResult <> DialogResult.OK Then Exit Sub

        curStimme.AlternativeÄndern(2, _picker.AusgewählteStimme.StimmeNr)


    End Sub

    Private Sub btnChangeAlt3_Click(sender As Object, e As EventArgs) Handles btnChangeAlt3.Click
        Dim _picker As New DialogStimmeAuswählen
        _picker.ShowDialog(Me)

        If _picker.DialogResult <> DialogResult.OK Then Exit Sub

        curStimme.AlternativeÄndern(3, _picker.AusgewählteStimme.StimmeNr)


    End Sub

    Private Sub btnChangeAlt4_Click(sender As Object, e As EventArgs) Handles btnChangeAlt4.Click
        Dim _picker As New DialogStimmeAuswählen
        _picker.ShowDialog(Me)

        If _picker.DialogResult <> DialogResult.OK Then Exit Sub

        curStimme.AlternativeÄndern(4, _picker.AusgewählteStimme.StimmeNr)

    End Sub

    Private Sub Reload()

        curStimme.Refresh()

        tbStimmeNr.Text = Me.curStimme.StimmeNr
        tbStimmeName.Text = Me.curStimme.StimmeName

        If curStimme.Alternativen(0) Is Nothing Then tbAlternative1.Text = "<Leer>" Else tbAlternative1.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(0))
        If curStimme.Alternativen(1) Is Nothing Then tbAlternative2.Text = "<Leer>" Else tbAlternative2.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(1))
        If curStimme.Alternativen(2) Is Nothing Then tbAlternative3.Text = "<Leer>" Else tbAlternative3.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(2))
        If curStimme.Alternativen(3) Is Nothing Then tbAlternative4.Text = "<Leer>" Else tbAlternative4.Text = Stimme.GetStimmeNameFromStimmeNr(curStimme.Alternativen(3))

    End Sub

    Private Sub btnResetAlt1_Click(sender As Object, e As EventArgs) Handles btnResetAlt1.Click
        If Not curStimme.Alternativen(0) Is Nothing Then
            curStimme.AlternativeÄndern(1, Nothing)
        End If
    End Sub

    Private Sub btnResetAlt2_Click(sender As Object, e As EventArgs) Handles btnResetAlt2.Click
        If Not curStimme.Alternativen(1) Is Nothing Then
            curStimme.AlternativeÄndern(2, Nothing)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnResetAlt3.Click
        If Not curStimme.Alternativen(2) Is Nothing Then
            curStimme.AlternativeÄndern(3, Nothing)
        End If
    End Sub

    Private Sub btnResetAlt4_Click(sender As Object, e As EventArgs) Handles btnResetAlt4.Click
        If Not curStimme.Alternativen(3) Is Nothing Then
            curStimme.AlternativeÄndern(4, Nothing)
        End If
    End Sub
End Class