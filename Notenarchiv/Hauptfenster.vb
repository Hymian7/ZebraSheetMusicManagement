Imports System.Data.OleDb
Imports System.IO
Imports Notenarchiv.SQLInterface

Public Class Hauptfenster

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        AddHandler RibbonButtonNotensätze.Click, AddressOf ChangeMode
        AddHandler RibbonButtonBarcodes.Click, AddressOf ChangeMode
        AddHandler RibbonButtonImport.Click, AddressOf ChangeMode
        AddHandler RibbonButtonInhaltsverzeichnisse.Click, AddressOf ChangeMode
        AddHandler RibbonButtonStimmen.Click, AddressOf ChangeMode

        'ChangeMode(RibbonButtonNotensätze, EventArgs.Empty)

        'Notensätze.Show()
        'Barcodes.Show()
        'Importieren.Show()
        'Inhaltsverzeichnisse.Show()
        'Stimmen.Show()

        'Notensätze.Activate()

    End Sub

    Private Sub RibbonButtonNotensätze_Click(sender As Object, e As EventArgs) Handles RibbonButtonNotensätze.Click

    End Sub

    Private Sub ChangeMode(sender As Object, ByVal e As EventArgs)

        For Each rb As RibbonButton In RibbonPanelModus.Items

            If rb.Name = sender.name Then
                rb.Checked = True
            Else
                rb.Checked = False
            End If

        Next

        For Each mdichild In Me.MdiChildren
            If Not sender.text = mdichild.Name Then
                mdichild.Hide()

                'Lieber mit mdichild.Activate arbeiten, da sonst Backgroundworker beim Import verloren geht!
                'und eventuell auch die jeweils anderen Ansichten
            End If
        Next

        ShowFormByName(sender.text)

                'ActivateForm

    End Sub

    Public Sub ShowFormByName(ByVal FormName As String)
        ' Erzeugt eine neue Instanz einer Form auf Basis des
        ' Klassennamens der Form (z.B. "Form1") und zeigt
        ' diese neue Instanz an.

        Try

            ' Referenz auf die ausgeführte (diese) Assembly holen
            Dim myAssembly As System.Reflection.Assembly _
                            = System.Reflection.Assembly.GetExecutingAssembly()

            ' Den Namen der Assembly ermitteln:
            Dim strAssemblyName As String = myAssembly.GetName().Name.ToString

            ' Den kompletten Namen (inkl. Assemblynamen) des Form-Typs ermitteln
            ' (diese Zeile sorgt zudem für Toleranz bzgl. Groß-/Kleinschreibung):
            Dim FullName As String _
                         = myAssembly.GetType(strAssemblyName & "." & FormName, False, True).ToString

            ' Form instanzieren und Formvariable zuweisen
            Dim myForm As System.Windows.Forms.Form _
                       = CType(myAssembly.CreateInstance(FullName),
                               System.Windows.Forms.Form)
            myForm.WindowState = FormWindowState.Maximized

            ' Die erzeugte Instanz anzeigen
            myForm.MdiParent = Me
            myForm.Show()

        Catch ex As System.NullReferenceException

            ' Formname existiert nicht - Standard: Keine Reaktion zeigen.
            ' Natürlich können Sie hier auch andere Reaktionen vorsehen.

        Catch ex As Exception

            ' Anderer Fehler, Fehlermeldung anzeigen.
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub ActivateFormByName(FormName As String)



    End Sub

    Private Sub RibbonOrbMenuItemEinstellungen_Click(sender As Object, e As EventArgs) Handles RibbonOrbMenuItemEinstellungen.Click
        Einstellungen.Show()
    End Sub

    Private Sub RibbonButtonAddNotensatz_Click(sender As Object, e As EventArgs) Handles RibbonButtonAddNotensatz.Click
        NotensatzHinzufuegen.Show()
    End Sub
End Class