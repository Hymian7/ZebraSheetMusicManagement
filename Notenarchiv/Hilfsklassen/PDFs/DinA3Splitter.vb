Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports Bytescout.PDF
Imports Bytescout.PDFExtractor

Module DinA3Splitter


    Sub Split(file As String)

        Dim filename As String = System.IO.Path.GetFileNameWithoutExtension(file)
        Dim filepath As String = System.IO.Path.GetDirectoryName(file)

        My.Computer.FileSystem.RenameFile(file, filename & "_witha3.pdf")

        Dim inputFile = filepath & "\" & filename & "_witha3.pdf"
        Dim outputFile = file
        Dim tempFolder = ".\temp"


        If Not Directory.Exists(tempFolder) Then
            Directory.CreateDirectory(tempFolder)
        End If

        ' Array of A3 page indices with corresponding A4 image slices in temp files
        Dim a3Pages = New Dictionary(Of Integer, String())()

        Try
            ' Create Bytescout.PDFExtractor.ImageExtractor object instance
            Using imageExtractor = New ImageExtractor("lukasmoeller1998+bytescoutnotforresale@gmail.com", "A4A8-9017-E1E7-CBF4-7E56-EF8E-E14")

                imageExtractor.LoadDocumentFromFile(inputFile)

                Dim pageCount = imageExtractor.GetPageCount()
                Dim pageIndex = 0

                ' Detect A3 pages and slice them to A4 pieces
                Do

                    Dim pageRectangle As RectangleF = imageExtractor.GetPageRectangle(pageIndex)

                    ' Detect A3 pages by width
                    If pageRectangle.Width > 600 Then

                        ' Make A4 slices from A3 page
                        Dim slicesPair1 = SliceImage(imageExtractor, pageIndex)

                        ' We expect the next page is also A3
                        If (pageIndex + 1 < pageCount) Then

                            pageRectangle = imageExtractor.GetPageRectangle(pageIndex + 1)

                            If pageRectangle.Width > 600 Then

                                ' Slice next A3 page
                                Dim slicesPair2 = SliceImage(imageExtractor, pageIndex + 1)

                                ' Keep A3 pages with slices ordered in required sequence
                                a3Pages.Add(pageIndex, New String(1) {slicesPair1(1), slicesPair2(0)})
                                a3Pages.Add(pageIndex + 1, New String(1) {slicesPair2(1), slicesPair1(0)})

                                pageIndex = pageIndex + 2

                            Else
                                Throw New Exception("Invalid page sequence.")
                            End If

                        Else
                            Throw New Exception("Invalid page sequence.")
                        End If

                    Else
                        pageIndex = pageIndex + 1
                    End If

                    If pageIndex >= pageCount Then Exit Do

                Loop

            End Using

            ' Open document in Bytescout.PDF.Document and replace A3 pages with new A4 pages created from image slices.
            Using pdfDocument As Document = New Document()
                pdfDocument.RegistrationName = "demo"
                pdfDocument.RegistrationKey = "demo"
                pdfDocument.Load(inputFile)

                For i = a3Pages.Count - 1 To 0 Step -1

                    Dim a3PageIndex As Integer = a3Pages.Keys(i)
                    pdfDocument.Pages.Remove(a3PageIndex)

                    For p = 1 To 0 Step -1
                        Dim newPage = New Page(PaperFormat.A4)
                        Dim pdfImage = New Bytescout.PDF.Image(a3Pages(a3PageIndex)(p))
                        newPage.Canvas.DrawImage(pdfImage, 0, 0, newPage.Width, newPage.Height)
                        pdfDocument.Pages.Insert(a3PageIndex, newPage)
                    Next
                Next

                ' Save modified document
                pdfDocument.Save(outputFile)

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        ' Cleanup
        Directory.Delete(tempFolder, True)


        'Console.WriteLine()
        'Console.WriteLine("Press any key...")
        'Console.ReadKey()

    End Sub


    Function SliceImage(imageExtractor As ImageExtractor, a3PageIndex As Integer) As String()
        Dim tempFolder = ".\temp"
        Dim result() As String = New String(1) {}

        ' Actually, A3 page is in portrait orientation in PDF file
        ' so we need to slice it horizontally and rotate slices at 270 deg.

        If imageExtractor.GetFirstPageImage(a3PageIndex) Then

            ' Save A3 image to memory
            Dim memoryStream = New MemoryStream()
            imageExtractor.SaveCurrentImageToStream(memoryStream, ImageFormat.Png)

            ' Create System.Drawing.Image object from image
            Using a3Image As Drawing.Image = Drawing.Image.FromStream(memoryStream)

                Dim sliceWidth As Integer = a3Image.Width
                Dim sliceHeight As Integer = a3Image.Height / 2

                ' Create image slices and save to temp files

                Using slice = New Bitmap(sliceWidth, sliceHeight)
                    Using g = Graphics.FromImage(slice)
                        g.DrawImage(a3Image, New Rectangle(0, 0, sliceWidth, sliceHeight), New Rectangle(0, 0, sliceWidth, sliceHeight), GraphicsUnit.Pixel)
                        slice.RotateFlip(RotateFlipType.Rotate270FlipNone)
                        Dim tempFileName = String.Format("{0}\slice-{1}-{2}.png", TempFolder, a3PageIndex, 0)
                        slice.Save(tempFileName, ImageFormat.Png)
                        result(0) = tempFileName
                    End Using
                End Using

                Using slice = New Bitmap(sliceWidth, sliceHeight)
                    Using g = Graphics.FromImage(slice)
                        g.DrawImage(a3Image, New Rectangle(0, 0, sliceWidth, sliceHeight), New Rectangle(0, sliceHeight, sliceWidth, sliceHeight), GraphicsUnit.Pixel)
                        slice.RotateFlip(RotateFlipType.Rotate270FlipNone)
                        Dim tempFileName = String.Format("{0}\slice-{1}-{2}.png", TempFolder, a3PageIndex, 1)
                        slice.Save(tempFileName, ImageFormat.Png)
                        result(1) = tempFileName
                    End Using
                End Using

                Return result

            End Using

        Else
            Throw New Exception(String.Format("Page {0} contains no images!", a3PageIndex))
        End If

    End Function

End Module
