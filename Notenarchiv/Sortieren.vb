Imports Bytescout.BarCodeReader
Imports System.IO
Imports Bytescout.PDFExtractor


Public Class Sortierer

    Public barcodes As FoundBarcode()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler OpenFileDialog1.FileOk, AddressOf btn_scan_Click
    End Sub

    Private Sub btn_Datei_Click(sender As Object, e As EventArgs) Handles btn_Datei.Click
        OpenFileDialog1.ShowDialog()
        tb_Datei.Text = OpenFileDialog1.FileName
        OpenFileDialog1.Dispose()
    End Sub

    Private Sub btn_Ordner_Click(sender As Object, e As EventArgs) Handles btn_Ordner.Click
        FolderBrowserDialog1.ShowDialog()
        tb_Ordner.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub btn_split_Click(sender As Object, e As EventArgs) Handles btn_split.Click
        Dim curBarcode As FoundBarcode
        Dim nextBarcode As FoundBarcode = New FoundBarcode

        Dim extractor As New InfoExtractor
        extractor.RegistrationName = "lukasmoeller1998+bytescoutnotforresale@gmail.com"
        extractor.RegistrationKey = "A4A8-9017-E1E7-CBF4-7E56-EF8E-E14"

        If cbSplitDINA3.Checked Then DinA3Splitter.Split(OpenFileDialog1.FileName)
        If cbRemoveEmptyPages.Checked Then RemoveEmptyPages.Remove(OpenFileDialog1.FileName)


        barcodes = BarcodesErkennen(OpenFileDialog1.FileName)
        extractor.LoadDocumentFromFile(OpenFileDialog1.FileName)

        Dim islastpage As Boolean = False

        Using splitter As New DocumentSplitter()

            splitter.OptimizeSplittedDocuments = True


            MsgBox(barcodes.Count)
            For i As Integer = 0 To barcodes.Count - 1
                MsgBox(Convert.ToString(barcodes.GetValue(i)) & "auf Seite " & barcodes(i).Page & " vom Typ" & barcodes(i).Type)
            Next

            For i As Integer = 0 To barcodes.Count - 1

                curBarcode = barcodes.GetValue(i)
                If i < barcodes.Count - 1 Then
                    nextBarcode = barcodes.GetValue(i + 1)

                Else
                    islastpage = True
                End If

                If Not Directory.Exists(tb_Ordner.Text & "/" & Strings.Left(curBarcode.Value, 6)) Then
                    Directory.CreateDirectory(tb_Ordner.Text & "/" & Strings.Left(curBarcode.Value, 6))
                End If

                If Not islastpage Then

                    splitter.ExtractPageRange(tb_Datei.Text, tb_Ordner.Text & "/" & Strings.Left(curBarcode.Value, My.Settings.NotensatzNrLength) & "/" & Strings.Right(Strings.Left(curBarcode.Value, My.Settings.StimmeNrLength + My.Settings.NotensatzNrLength), My.Settings.StimmeNrLength) & ".pdf", curBarcode.Page + 1, nextBarcode.Page)

                Else

                    splitter.ExtractPageRange(tb_Datei.Text, tb_Ordner.Text & "/" & Strings.Left(curBarcode.Value, 6) & "/" & Strings.Right(Strings.Left(curBarcode.Value, 9), My.Settings.StimmeNrLength) & ".pdf", curBarcode.Page + 1, extractor.GetPageCount)

                End If


            Next

        End Using

        MsgBox("Aufteilen und Sortieren erfolgreich!")

    End Sub

    Function BarcodesErkennen(ByVal file As String) As FoundBarcode()

        Dim barcodeReader As New Reader()
        barcodeReader.RegistrationName = "lukasmoeller1998+bytescoutnotforresale@gmail.com"
        barcodeReader.RegistrationKey = "FEC8-CA77-BB86-4DC4-2436-B5EB-474"

        ' Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
        ' Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
        ' or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
        barcodeReader.BarcodeTypesToFind.Reset()
        barcodeReader.BarcodeTypesToFind.Code128 = True
        barcodeReader.MinimalDataLength = 9
        barcodeReader.MaxNumberOfBarcodesPerPage = 1

        barcodes = barcodeReader.ReadFrom(file)

        barcodeReader.Dispose()

        Return barcodes

    End Function

    Private Sub FillListbox()
        lb_barcodes.Items.Clear()

        barcodes = BarcodesErkennen(OpenFileDialog1.FileName)

        For Each barcode As FoundBarcode In barcodes
            lb_barcodes.Items.Add(Strings.Left(barcode.Value, 9) & " auf Seite " & barcode.Page + 1)
            'Console.WriteLine("Found barcode with type '{0}' and value '{1}' at page {2} at {3}", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString())
        Next
    End Sub

End Class
