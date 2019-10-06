Imports System.IO
Imports Bytescout.PDFExtractor

Module RemoveEmptyPages

    Sub Remove(ByVal Document As String)

        ' The idea is to split document to spearate pages excluding empty ones, 
        ' then combine parts back to single document.

        Dim filename As String = Path.GetFileNameWithoutExtension(Document)
        Dim filepath As String = Path.GetDirectoryName(Document)

        My.Computer.FileSystem.RenameFile(Document, filename & "_withblanks.pdf")

        Dim inputFile = filepath & "\" & filename & "_withblanks.pdf"
        Dim outputFile = Document
        Dim tempFolder = ".\temp"

        ' Create and setup Bytescout.PDFExtractor.TextExtractor instance
        ' Enable Optical Character Recognition (OCR)
        ' Set the location of "tessdata" folder containing language data files
        ' Set OCR language
        ' Set PDF document rendering resolution
        Dim extractor As New TextExtractor("lukasmoeller1998+bytescoutnotforresale@gmail.com", "A4A8-9017-E1E7-CBF4-7E56-EF8E-E14") With {
            .OCRMode = OCRMode.TextFromImagesOnly,
            .OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\Redistributable\net4.00\tessdata",
            .OCRLanguage = "deu",
            .OCRResolution = 300
        }

            ' Load PDF document
        MsgBox(inputFile)
        extractor.LoadDocumentFromFile(inputFile)

        ' List to keep non-empty page numbers
        Dim nonEmptyPages = New List(Of String)()

        ' Recognize text from scanned document pages
        For pageIndex = 0 To extractor.GetPageCount() - 1
            ' Get recognized page text
            Dim pageText = extractor.GetTextFromPage(pageIndex)
            'MsgBox(extractor.GetTextFromPage(pageIndex) & "mit Länge " & pageText.Length & " auf Seite " & pageIndex + 1)
            ' If extracted text is not empty keep the page number
            If pageText.Length > 0 Then
                nonEmptyPages.Add((pageIndex + 1).ToString())
            End If
        Next

        ' Cleanup
        extractor.Dispose()


        ' Form comma-separated list of page numbers to split ("1,3,5")
        Dim ranges As String = String.Join(",", nonEmptyPages)

        ' Create Bytescout.PDFExtractor.DocumentSplitter instance
        Dim splitter = New DocumentSplitter("lukasmoeller1998+bytescoutnotforresale@gmail.com", "A4A8-9017-E1E7-CBF4-7E56-EF8E-E14") With {
            .OptimizeSplittedDocuments = True
        }

            ' Split document by non-empty in temp folder
        Dim parts = splitter.Split(inputFile, ranges, tempFolder)

        ' Cleanup
        splitter.Dispose()


        ' Create Bytescout.PDFExtractor.DocumentMerger instance
        Dim merger = New DocumentMerger("lukasmoeller1998+bytescoutnotforresale@gmail.com", "A4A8-9017-E1E7-CBF4-7E56-EF8E-E14")

        ' Merge parts
        merger.Merge(parts, outputFile)

        ' Cleanup
        merger.Dispose()

        ' Delete temp folder
        Directory.Delete(tempFolder, True)


        ' Open the result file in default PDF viewer (for demo purposes)
        'Process.Start(outputFile)

        MsgBox("Leere Seiten entfernen erfolgreich!")

    End Sub

End Module
