﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbStimmen = New System.Windows.Forms.ListBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNotensatzNr
        '
        Me.tbNotensatzNr.Location = New System.Drawing.Point(45, 25)
        Me.tbNotensatzNr.Name = "tbNotensatzNr"
        Me.tbNotensatzNr.ReadOnly = True
        Me.tbNotensatzNr.Size = New System.Drawing.Size(283, 20)
        Me.tbNotensatzNr.TabIndex = 0
        '
        'tbNotensatzName
        '
        Me.tbNotensatzName.Location = New System.Drawing.Point(45, 51)
        Me.tbNotensatzName.Name = "tbNotensatzName"
        Me.tbNotensatzName.Size = New System.Drawing.Size(283, 20)
        Me.tbNotensatzName.TabIndex = 1
        '
        'tbArrangeur
        '
        Me.tbArrangeur.Location = New System.Drawing.Point(45, 77)
        Me.tbArrangeur.Name = "tbArrangeur"
        Me.tbArrangeur.Size = New System.Drawing.Size(283, 20)
        Me.tbArrangeur.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 246)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(304, 159)
        Me.DataGridView1.TabIndex = 4
        '
        'lbStimmen
        '
        Me.lbStimmen.FormattingEnabled = True
        Me.lbStimmen.Location = New System.Drawing.Point(380, 206)
        Me.lbStimmen.Name = "lbStimmen"
        Me.lbStimmen.Size = New System.Drawing.Size(218, 199)
        Me.lbStimmen.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(253, 103)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(646, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(380, 355)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(192, 74)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stimmen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(372, 329)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Verzeichnisse"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 456)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lbStimmen)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tbArrangeur)
        Me.Controls.Add(Me.tbNotensatzName)
        Me.Controls.Add(Me.tbNotensatzNr)
        Me.Name = "Detail"
        Me.Text = "Detail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNotensatzNr As TextBox
    Friend WithEvents tbNotensatzName As TextBox
    Friend WithEvents tbArrangeur As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbStimmen As ListBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
