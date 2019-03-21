<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotensatzHinzufuegen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnHinzufuegen = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbArrangeur = New System.Windows.Forms.TextBox()
        Me.tbNotensatzName = New System.Windows.Forms.TextBox()
        Me.tbNotensatzNr = New System.Windows.Forms.TextBox()
        Me.rbManuell = New System.Windows.Forms.RadioButton()
        Me.rbDateiname = New System.Windows.Forms.RadioButton()
        Me.rbBarcode = New System.Windows.Forms.RadioButton()
        Me.gbModus = New System.Windows.Forms.GroupBox()
        Me.rbKeineNotenblaetter = New System.Windows.Forms.RadioButton()
        Me.olvVerfuegbareStimmen = New BrightIdeasSoftware.ObjectListView()
        Me.btnAddStimme = New System.Windows.Forms.Button()
        Me.btnRemoveStimme = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OlvColStimmeNr = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColStimmeName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvAusgewaehlteStimmen = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Panel2.SuspendLayout()
        Me.gbModus.SuspendLayout()
        CType(Me.olvVerfuegbareStimmen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.olvAusgewaehlteStimmen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHinzufuegen
        '
        Me.btnHinzufuegen.Location = New System.Drawing.Point(3, 3)
        Me.btnHinzufuegen.Name = "btnHinzufuegen"
        Me.btnHinzufuegen.Size = New System.Drawing.Size(100, 30)
        Me.btnHinzufuegen.TabIndex = 3
        Me.btnHinzufuegen.Text = "Hinzufügen"
        Me.btnHinzufuegen.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(109, 3)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(88, 30)
        Me.btnAbbrechen.TabIndex = 4
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnAbbrechen)
        Me.Panel2.Controls.Add(Me.btnHinzufuegen)
        Me.Panel2.Location = New System.Drawing.Point(842, 492)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(201, 37)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Arrangeur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Notensatzname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NotensatzNr:"
        '
        'tbArrangeur
        '
        Me.tbArrangeur.Location = New System.Drawing.Point(144, 95)
        Me.tbArrangeur.Name = "tbArrangeur"
        Me.tbArrangeur.Size = New System.Drawing.Size(358, 22)
        Me.tbArrangeur.TabIndex = 8
        '
        'tbNotensatzName
        '
        Me.tbNotensatzName.Location = New System.Drawing.Point(144, 67)
        Me.tbNotensatzName.Name = "tbNotensatzName"
        Me.tbNotensatzName.Size = New System.Drawing.Size(358, 22)
        Me.tbNotensatzName.TabIndex = 7
        '
        'tbNotensatzNr
        '
        Me.tbNotensatzNr.Enabled = False
        Me.tbNotensatzNr.Location = New System.Drawing.Point(144, 39)
        Me.tbNotensatzNr.Name = "tbNotensatzNr"
        Me.tbNotensatzNr.Size = New System.Drawing.Size(358, 22)
        Me.tbNotensatzNr.TabIndex = 6
        '
        'rbManuell
        '
        Me.rbManuell.AutoSize = True
        Me.rbManuell.Location = New System.Drawing.Point(6, 26)
        Me.rbManuell.Name = "rbManuell"
        Me.rbManuell.Size = New System.Drawing.Size(140, 21)
        Me.rbManuell.TabIndex = 12
        Me.rbManuell.TabStop = True
        Me.rbManuell.Text = "Manuell zuweisen"
        Me.rbManuell.UseVisualStyleBackColor = True
        '
        'rbDateiname
        '
        Me.rbDateiname.AutoSize = True
        Me.rbDateiname.Location = New System.Drawing.Point(6, 53)
        Me.rbDateiname.Name = "rbDateiname"
        Me.rbDateiname.Size = New System.Drawing.Size(205, 21)
        Me.rbDateiname.TabIndex = 13
        Me.rbDateiname.TabStop = True
        Me.rbDateiname.Text = "Automatisch aus Dateiname"
        Me.rbDateiname.UseVisualStyleBackColor = True
        '
        'rbBarcode
        '
        Me.rbBarcode.AutoSize = True
        Me.rbBarcode.Location = New System.Drawing.Point(6, 80)
        Me.rbBarcode.Name = "rbBarcode"
        Me.rbBarcode.Size = New System.Drawing.Size(190, 21)
        Me.rbBarcode.TabIndex = 14
        Me.rbBarcode.TabStop = True
        Me.rbBarcode.Text = "Automatisch aus Barcode"
        Me.rbBarcode.UseVisualStyleBackColor = True
        '
        'gbModus
        '
        Me.gbModus.Controls.Add(Me.rbKeineNotenblaetter)
        Me.gbModus.Controls.Add(Me.rbBarcode)
        Me.gbModus.Controls.Add(Me.rbManuell)
        Me.gbModus.Controls.Add(Me.rbDateiname)
        Me.gbModus.Location = New System.Drawing.Point(117, 175)
        Me.gbModus.Name = "gbModus"
        Me.gbModus.Size = New System.Drawing.Size(290, 143)
        Me.gbModus.TabIndex = 15
        Me.gbModus.TabStop = False
        Me.gbModus.Text = "Sollen Notenblätter hinzugefügt werden?"
        '
        'rbKeineNotenblaetter
        '
        Me.rbKeineNotenblaetter.AutoSize = True
        Me.rbKeineNotenblaetter.Location = New System.Drawing.Point(6, 107)
        Me.rbKeineNotenblaetter.Name = "rbKeineNotenblaetter"
        Me.rbKeineNotenblaetter.Size = New System.Drawing.Size(221, 21)
        Me.rbKeineNotenblaetter.TabIndex = 15
        Me.rbKeineNotenblaetter.TabStop = True
        Me.rbKeineNotenblaetter.Text = "Keine Notenblätter hinzufügen"
        Me.rbKeineNotenblaetter.UseVisualStyleBackColor = True
        '
        'olvVerfuegbareStimmen
        '
        Me.olvVerfuegbareStimmen.AllColumns.Add(Me.OlvColStimmeNr)
        Me.olvVerfuegbareStimmen.AllColumns.Add(Me.OlvColStimmeName)
        Me.olvVerfuegbareStimmen.CellEditUseWholeCell = False
        Me.olvVerfuegbareStimmen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColStimmeNr, Me.OlvColStimmeName})
        Me.olvVerfuegbareStimmen.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvVerfuegbareStimmen.FullRowSelect = True
        Me.olvVerfuegbareStimmen.Location = New System.Drawing.Point(3, 3)
        Me.olvVerfuegbareStimmen.Name = "olvVerfuegbareStimmen"
        Me.olvVerfuegbareStimmen.ShowGroups = False
        Me.olvVerfuegbareStimmen.Size = New System.Drawing.Size(218, 362)
        Me.olvVerfuegbareStimmen.TabIndex = 16
        Me.olvVerfuegbareStimmen.UseCompatibleStateImageBehavior = False
        Me.olvVerfuegbareStimmen.View = System.Windows.Forms.View.Details
        '
        'btnAddStimme
        '
        Me.btnAddStimme.Location = New System.Drawing.Point(227, 94)
        Me.btnAddStimme.Name = "btnAddStimme"
        Me.btnAddStimme.Size = New System.Drawing.Size(50, 50)
        Me.btnAddStimme.TabIndex = 18
        Me.btnAddStimme.Text = ">>"
        Me.btnAddStimme.UseVisualStyleBackColor = True
        '
        'btnRemoveStimme
        '
        Me.btnRemoveStimme.Location = New System.Drawing.Point(227, 190)
        Me.btnRemoveStimme.Name = "btnRemoveStimme"
        Me.btnRemoveStimme.Size = New System.Drawing.Size(50, 50)
        Me.btnRemoveStimme.TabIndex = 19
        Me.btnRemoveStimme.Text = "<<"
        Me.btnRemoveStimme.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.olvAusgewaehlteStimmen)
        Me.Panel1.Controls.Add(Me.olvVerfuegbareStimmen)
        Me.Panel1.Controls.Add(Me.btnRemoveStimme)
        Me.Panel1.Controls.Add(Me.btnAddStimme)
        Me.Panel1.Location = New System.Drawing.Point(532, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 372)
        Me.Panel1.TabIndex = 20
        '
        'OlvColStimmeNr
        '
        Me.OlvColStimmeNr.AspectName = "StimmeNr"
        Me.OlvColStimmeNr.Text = "Nummer"
        '
        'OlvColStimmeName
        '
        Me.OlvColStimmeName.AspectName = "StimmeName"
        Me.OlvColStimmeName.Text = "Name"
        '
        'olvAusgewaehlteStimmen
        '
        Me.olvAusgewaehlteStimmen.AllColumns.Add(Me.OlvColumn1)
        Me.olvAusgewaehlteStimmen.AllColumns.Add(Me.OlvColumn2)
        Me.olvAusgewaehlteStimmen.CellEditUseWholeCell = False
        Me.olvAusgewaehlteStimmen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn2})
        Me.olvAusgewaehlteStimmen.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvAusgewaehlteStimmen.FullRowSelect = True
        Me.olvAusgewaehlteStimmen.Location = New System.Drawing.Point(283, 3)
        Me.olvAusgewaehlteStimmen.Name = "olvAusgewaehlteStimmen"
        Me.olvAusgewaehlteStimmen.ShowGroups = False
        Me.olvAusgewaehlteStimmen.Size = New System.Drawing.Size(218, 362)
        Me.olvAusgewaehlteStimmen.TabIndex = 20
        Me.olvAusgewaehlteStimmen.UseCompatibleStateImageBehavior = False
        Me.olvAusgewaehlteStimmen.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "StimmeNr"
        Me.OlvColumn1.Text = "Nummer"
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "StimmeName"
        Me.OlvColumn2.Text = "Name"
        '
        'NotensatzHinzufuegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 541)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbModus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbArrangeur)
        Me.Controls.Add(Me.tbNotensatzName)
        Me.Controls.Add(Me.tbNotensatzNr)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "NotensatzHinzufuegen"
        Me.Text = "Notensatz Hinzufügen"
        Me.Panel2.ResumeLayout(False)
        Me.gbModus.ResumeLayout(False)
        Me.gbModus.PerformLayout()
        CType(Me.olvVerfuegbareStimmen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.olvAusgewaehlteStimmen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHinzufuegen As Button
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbArrangeur As TextBox
    Friend WithEvents tbNotensatzName As TextBox
    Friend WithEvents tbNotensatzNr As TextBox
    Friend WithEvents rbManuell As RadioButton
    Friend WithEvents rbDateiname As RadioButton
    Friend WithEvents rbBarcode As RadioButton
    Friend WithEvents gbModus As GroupBox
    Friend WithEvents rbKeineNotenblaetter As RadioButton
    Friend WithEvents olvVerfuegbareStimmen As BrightIdeasSoftware.ObjectListView
    Friend WithEvents btnAddStimme As Button
    Friend WithEvents btnRemoveStimme As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OlvColStimmeNr As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColStimmeName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvAusgewaehlteStimmen As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
End Class
