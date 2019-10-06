Imports System.ComponentModel
Imports System.IO
Imports Bytescout.BarCodeReader
Imports Bytescout.PDFExtractor

Public Class Importieren
    Public barcodes As FoundBarcode()

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs)

        tbPfad.Clear()

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            tbPfad.Text = FolderBrowserDialog1.SelectedPath
        End If

        For Each dir As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

            lbNotensatz.Items.Add(dir)

        Next

    End Sub

    Private Sub lbNotensatz_SelectedIndexChanged(sender As Object, e As EventArgs)

        lbStimmen.Items.Clear()

        If Not lbNotensatz.SelectedItem = "" Then

            For Each datei As String In Directory.GetFiles(lbNotensatz.SelectedItem)
                lbStimmen.Items.Add(Stimme.GetStimmeNameFromDatei(datei))
            Next

        Else lbStimmen.Items.Clear()
        End If

    End Sub

    Private Sub btnEinlesen_Click(sender As Object, e As EventArgs)


        For Each dir As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

            Dim ns As New Notensatz(Notensatz.GetNotensatzNrFromDateipfad(dir))
            ns.InDatenbankAnlegen()

        Next

    End Sub

    Private Sub ButtonHinzufügen_Click(sender As Object, e As EventArgs) Handles ButtonHinzufügen.Click
        Dim ofd As New OpenFileDialog With {
            .Multiselect = True,
            .Filter = "PDF-Dokumente (*.pdf)|*.pdf"
        }

        If ofd.ShowDialog = DialogResult.OK Then

            For Each file In ofd.FileNames

                AddRow(file)

            Next


        End If

    End Sub

    Private Sub DataGridViewDateien_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewDateien.DoubleClick
        Try
            Process.Start(DataGridViewDateien.CurrentRow.Cells(0).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonEntfernen_Click(sender As Object, e As EventArgs) Handles ButtonEntfernen.Click

        For Each dgvc As DataGridViewCell In DataGridViewDateien.SelectedCells
            DataGridViewDateien.Rows.Remove(DataGridViewDateien.Rows(dgvc.RowIndex))
        Next

    End Sub

    Private Function Split(ByVal datei As DataGridViewRow) As Boolean

        BackgroundWorker1.ReportProgress(-1)

        Try
            Dim curBarcode As FoundBarcode
            Dim nextBarcode As FoundBarcode = New FoundBarcode

            Dim dateiname As String = datei.Cells(0).Value
            Dim removeEP As Boolean = datei.Cells(1).Value
            Dim splitA3 As Boolean = datei.Cells(2).Value

            Dim extractor As New InfoExtractor With {
                .RegistrationName = "lukasmoeller1998+bytescoutnotforresale@gmail.com",
                .RegistrationKey = "A4A8-9017-E1E7-CBF4-7E56-EF8E-E14"
            }

            If splitA3 Then DinA3Splitter.Split(dateiname)
            If removeEP Then RemoveEmptyPages.Remove(dateiname)


            barcodes = BarcodesErkennen(dateiname)
            extractor.LoadDocumentFromFile(dateiname)

            BackgroundWorker1.ReportProgress(1)

            Dim islastpage As Boolean = False

            Using splitter As New DocumentSplitter()

                splitter.OptimizeSplittedDocuments = True


                'For i As Integer = 0 To barcodes.Count - 1
                'MsgBox(Convert.ToString(barcodes.GetValue(i)) & "auf Seite " & barcodes(i).Page & " vom Typ" & barcodes(i).Type)
                'Next

                For i As Integer = 0 To barcodes.Count - 1

                    curBarcode = barcodes.GetValue(i)
                    If i < barcodes.Count - 1 Then
                        nextBarcode = barcodes.GetValue(i + 1)

                    Else
                        islastpage = True
                    End If

                    If Not Directory.Exists(My.Settings.ArchivePath & "/" & Strings.Left(curBarcode.Value, 6)) Then
                        Directory.CreateDirectory(My.Settings.ArchivePath & "/" & Strings.Left(curBarcode.Value, 6))
                    End If

                    If Not islastpage Then

                        splitter.ExtractPageRange(dateiname, My.Settings.ArchivePath & "/" & Strings.Left(curBarcode.Value, My.Settings.NotensatzNrLength) & "/" & Strings.Right(Strings.Left(curBarcode.Value, My.Settings.StimmeNrLength + My.Settings.NotensatzNrLength), My.Settings.StimmeNrLength) & ".pdf", curBarcode.Page + 1, nextBarcode.Page)

                    Else

                        splitter.ExtractPageRange(dateiname, My.Settings.ArchivePath & "/" & Strings.Left(curBarcode.Value, 6) & "/" & Strings.Right(Strings.Left(curBarcode.Value, 9), My.Settings.StimmeNrLength) & ".pdf", curBarcode.Page + 1, extractor.GetPageCount)

                    End If

                    BackgroundWorker1.ReportProgress(Convert.ToInt16((i + 1) / barcodes.Count * 100))

                Next

            End Using

            Notensatz.AusBarcodesAnlegen(barcodes)
            Notenblatt.AusBarcodesAnlegen(barcodes)
            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Function BarcodesErkennen(ByVal file As String) As FoundBarcode()
        Dim barcodeReader As New Reader With {
            .RegistrationName = "lukasmoeller1998+bytescoutnotforresale@gmail.com",
            .RegistrationKey = "FEC8-CA77-BB86-4DC4-2436-B5EB-474"
        }

        ' Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
        ' Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
        ' or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
        barcodeReader.BarcodeTypesToFind.Reset()
        'barcodeReader.BarcodeTypesToFind.Code128 = True
        barcodeReader.BarcodeTypesToFind.QRCode = True
        barcodeReader.BarcodeTypesToFind.Aztec = True
        barcodeReader.BarcodeTypesToFind.DataMatrix = True
        barcodeReader.MinimalDataLength = 9
        barcodeReader.Orientation = OrientationType.SearchAll
        barcodeReader.FastMode = True
        barcodeReader.MaxNumberOfBarcodesPerPage = 1

        barcodes = barcodeReader.ReadFrom(file)
        barcodeReader.Dispose()

        Return barcodes

    End Function

    Private Sub FillListbox()
        lb_barcodes.Items.Clear()

        barcodes = BarcodesErkennen(DataGridViewDateien.CurrentRow.Cells(0).Value)

        For Each barcode As FoundBarcode In barcodes
            lb_barcodes.Items.Add(Strings.Left(barcode.Value, 9) & " auf Seite " & barcode.Page + 1 & "an Position X:" & barcode.Rect.X & ", Y:" & barcode.Rect.Y)
            'Console.WriteLine("Found barcode with type '{0}' and value '{1}' at page {2} at {3}", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString())
        Next
    End Sub

    Private Sub btn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click

        FillListbox()

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        If Split(DataGridViewDateien.CurrentRow) Then RemoveEntry(DataGridViewDateien.CurrentRow)


    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If e.ProgressPercentage = -1 Then
            ProgressBar1.Style = ProgressBarStyle.Marquee
        Else
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = e.ProgressPercentage
        End If

        ShowProgressInDataGridView(DataGridViewDateien.CurrentRow, e.ProgressPercentage)
    End Sub

    Delegate Sub RemoveEntryDelegate(row As DataGridViewRow)

    Private Sub RemoveEntry(row As DataGridViewRow)

        If DataGridViewDateien.InvokeRequired Then
            DataGridViewDateien.Invoke(New RemoveEntryDelegate(AddressOf RemoveEntry), row)
        Else

            DataGridViewDateien.Rows.Remove(row)

        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar1.Value = 0
    End Sub

    Private Sub ShowProgressInDataGridView(row As DataGridViewRow, percent As Integer)

        row.Cells(3).Value = percent

    End Sub

    Private Sub DataGridViewDateien_DragEnter(sender As Object, e As DragEventArgs) Handles DataGridViewDateien.DragEnter
        DataGridViewDateien.BackgroundColor = Color.Blue

        If Not e.Data.GetDataPresent(DataFormats.FileDrop) Then ' Handelt es sich bei diesem Vorgang um Drag&Drop einer Datei?
            e.Effect = DragDropEffects.None 'Falls nicht, können die Daten nicht verarbeitet werden
            Return
        End If
        'Sonst überprüfe, ob es mindestens eine Datei gibt, die die Dateierweiterung .pdf hat
        For Each file As String In DirectCast(e.Data.GetData(DataFormats.FileDrop, False), IEnumerable(Of String))
            If System.IO.Path.GetExtension(file).Equals(".pdf", StringComparison.OrdinalIgnoreCase) Then 'Ignoriere Groß-und-Kleinschreibung
                e.Effect = DragDropEffects.Link
                Exit For
            End If
        Next

    End Sub

    Private Sub DataGridViewDateien_DragLeave(sender As Object, e As EventArgs) Handles DataGridViewDateien.DragLeave
        DataGridViewDateien.BackgroundColor = SystemColors.AppWorkspace
    End Sub

    Private Sub DataGridViewDateien_DragDrop(sender As Object, e As DragEventArgs) Handles DataGridViewDateien.DragDrop

        Dim files() = DirectCast(e.Data.GetData(DataFormats.FileDrop, False), String())

        For Each file As String In files
            AddRow(file)
        Next

        DataGridViewDateien.BackgroundColor = SystemColors.AppWorkspace
    End Sub

    Private Sub AddRow(file As String)

        Dim newrow As New DataGridViewRow
        newrow.CreateCells(DataGridViewDateien)

        newrow.Cells(0).Value = file
        newrow.Cells(1).Value = False
        newrow.Cells(2).Value = False
        DataGridViewDateien.Rows.Add(newrow)

    End Sub
End Class