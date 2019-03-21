<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbNotensatzNr = New System.Windows.Forms.TextBox()
        Me.tbNotensatzName = New System.Windows.Forms.TextBox()
        Me.tbArrangeur = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.olvNotenblaetter = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColStimmeNr = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColStimmeName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColIstVorhanden = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TabControl1.SuspendLayout()
        CType(Me.olvNotenblaetter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbNotensatzNr
        '
        Me.tbNotensatzNr.Location = New System.Drawing.Point(60, 31)
        Me.tbNotensatzNr.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNotensatzNr.Name = "tbNotensatzNr"
        Me.tbNotensatzNr.ReadOnly = True
        Me.tbNotensatzNr.Size = New System.Drawing.Size(376, 22)
        Me.tbNotensatzNr.TabIndex = 0
        '
        'tbNotensatzName
        '
        Me.tbNotensatzName.Location = New System.Drawing.Point(60, 63)
        Me.tbNotensatzName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNotensatzName.Name = "tbNotensatzName"
        Me.tbNotensatzName.Size = New System.Drawing.Size(376, 22)
        Me.tbNotensatzName.TabIndex = 1
        '
        'tbArrangeur
        '
        Me.tbArrangeur.Location = New System.Drawing.Point(60, 95)
        Me.tbArrangeur.Margin = New System.Windows.Forms.Padding(4)
        Me.tbArrangeur.Name = "tbArrangeur"
        Me.tbArrangeur.Size = New System.Drawing.Size(376, 22)
        Me.tbArrangeur.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(337, 127)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(778, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(582, 464)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(574, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stimmen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(178, 408)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Verzeichnisse"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'olvNotenblaetter
        '
        Me.olvNotenblaetter.AllColumns.Add(Me.OlvColStimmeNr)
        Me.olvNotenblaetter.AllColumns.Add(Me.OlvColStimmeName)
        Me.olvNotenblaetter.AllColumns.Add(Me.OlvColIstVorhanden)
        Me.olvNotenblaetter.AllowColumnReorder = True
        Me.olvNotenblaetter.CellEditUseWholeCell = False
        Me.olvNotenblaetter.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColStimmeNr, Me.OlvColStimmeName, Me.OlvColIstVorhanden})
        Me.olvNotenblaetter.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvNotenblaetter.Location = New System.Drawing.Point(60, 233)
        Me.olvNotenblaetter.Name = "olvNotenblaetter"
        Me.olvNotenblaetter.ShowGroups = False
        Me.olvNotenblaetter.Size = New System.Drawing.Size(519, 244)
        Me.olvNotenblaetter.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.olvNotenblaetter.TabIndex = 9
        Me.olvNotenblaetter.UseCompatibleStateImageBehavior = False
        Me.olvNotenblaetter.View = System.Windows.Forms.View.Details
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
        'OlvColIstVorhanden
        '
        Me.OlvColIstVorhanden.AspectName = "IstVorhanden"
        Me.OlvColIstVorhanden.Text = "Vorhanden"
        '
        'Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1449, 561)
        Me.Controls.Add(Me.olvNotenblaetter)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.tbArrangeur)
        Me.Controls.Add(Me.tbNotensatzName)
        Me.Controls.Add(Me.tbNotensatzNr)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Detail"
        Me.Text = "Detail"
        Me.TabControl1.ResumeLayout(False)
        CType(Me.olvNotenblaetter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNotensatzNr As TextBox
    Friend WithEvents tbNotensatzName As TextBox
    Friend WithEvents tbArrangeur As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents olvNotenblaetter As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColStimmeNr As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColStimmeName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColIstVorhanden As BrightIdeasSoftware.OLVColumn
End Class
