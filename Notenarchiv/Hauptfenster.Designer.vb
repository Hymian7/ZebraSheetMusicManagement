﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hauptfenster
    'Inherits System.Windows.Forms.Form
    Inherits System.Windows.Forms.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hauptfenster))
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.ribbontab_Importieren = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel_Importieren = New System.Windows.Forms.RibbonPanel()
        Me.RibbonPanelEinlesen = New System.Windows.Forms.RibbonPanel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataSet1 = New System.Data.DataSet()
        Me.RibbonOrbMenuItem1 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbMenuItem2 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbMenuItem3 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbOptionButton1 = New System.Windows.Forms.RibbonOrbOptionButton()
        Me.RibbonOrbOptionButton2 = New System.Windows.Forms.RibbonOrbOptionButton()
        Me.RibbonOrbRecentItem1 = New System.Windows.Forms.RibbonOrbRecentItem()
        Me.RibbonButton_Importieren = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonEinlesen = New System.Windows.Forms.RibbonButton()
        Me.btn_Einstellungen = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem1)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem2)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem3)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.OptionItems.Add(Me.RibbonOrbOptionButton1)
        Me.Ribbon1.OrbDropDown.OptionItems.Add(Me.RibbonOrbOptionButton2)
        Me.Ribbon1.OrbDropDown.RecentItems.Add(Me.RibbonOrbRecentItem1)
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 204)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(1400, 131)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.ribbontab_Importieren)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(5, 26, 20, 0)
        Me.Ribbon1.TabSpacing = 4
        Me.Ribbon1.Text = "Ribbon1"
        '
        'ribbontab_Importieren
        '
        Me.ribbontab_Importieren.Name = "ribbontab_Importieren"
        Me.ribbontab_Importieren.Panels.Add(Me.RibbonPanel_Importieren)
        Me.ribbontab_Importieren.Panels.Add(Me.RibbonPanelEinlesen)
        Me.ribbontab_Importieren.Text = "Importieren"
        '
        'RibbonPanel_Importieren
        '
        Me.RibbonPanel_Importieren.Items.Add(Me.RibbonButton_Importieren)
        Me.RibbonPanel_Importieren.Name = "RibbonPanel_Importieren"
        Me.RibbonPanel_Importieren.Text = "Daten Importieren"
        '
        'RibbonPanelEinlesen
        '
        Me.RibbonPanelEinlesen.Items.Add(Me.RibbonButtonEinlesen)
        Me.RibbonPanelEinlesen.Name = "RibbonPanelEinlesen"
        Me.RibbonPanelEinlesen.Text = "Einlesen"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(58, 182)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Aktualisieren"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(139, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.Size = New System.Drawing.Size(662, 325)
        Me.DataGridView1.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(58, 211)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Hinzufügen"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'RibbonOrbMenuItem1
        '
        Me.RibbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem1.Image = CType(resources.GetObject("RibbonOrbMenuItem1.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.LargeImage = CType(resources.GetObject("RibbonOrbMenuItem1.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Name = "RibbonOrbMenuItem1"
        Me.RibbonOrbMenuItem1.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Text = "RibbonOrbMenuItem1"
        '
        'RibbonOrbMenuItem2
        '
        Me.RibbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem2.Image = CType(resources.GetObject("RibbonOrbMenuItem2.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem2.LargeImage = CType(resources.GetObject("RibbonOrbMenuItem2.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem2.Name = "RibbonOrbMenuItem2"
        Me.RibbonOrbMenuItem2.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem2.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem2.Text = "RibbonOrbMenuItem2"
        '
        'RibbonOrbMenuItem3
        '
        Me.RibbonOrbMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem3.Image = CType(resources.GetObject("RibbonOrbMenuItem3.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem3.LargeImage = CType(resources.GetObject("RibbonOrbMenuItem3.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem3.Name = "RibbonOrbMenuItem3"
        Me.RibbonOrbMenuItem3.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem3.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem3.Text = "RibbonOrbMenuItem3"
        '
        'RibbonOrbOptionButton1
        '
        Me.RibbonOrbOptionButton1.Image = CType(resources.GetObject("RibbonOrbOptionButton1.Image"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.LargeImage = CType(resources.GetObject("RibbonOrbOptionButton1.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.Name = "RibbonOrbOptionButton1"
        Me.RibbonOrbOptionButton1.SmallImage = CType(resources.GetObject("RibbonOrbOptionButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.Text = "RibbonOrbOptionButton1"
        '
        'RibbonOrbOptionButton2
        '
        Me.RibbonOrbOptionButton2.Image = CType(resources.GetObject("RibbonOrbOptionButton2.Image"), System.Drawing.Image)
        Me.RibbonOrbOptionButton2.LargeImage = CType(resources.GetObject("RibbonOrbOptionButton2.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButton2.Name = "RibbonOrbOptionButton2"
        Me.RibbonOrbOptionButton2.SmallImage = CType(resources.GetObject("RibbonOrbOptionButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButton2.Text = "RibbonOrbOptionButton2"
        '
        'RibbonOrbRecentItem1
        '
        Me.RibbonOrbRecentItem1.Image = CType(resources.GetObject("RibbonOrbRecentItem1.Image"), System.Drawing.Image)
        Me.RibbonOrbRecentItem1.LargeImage = CType(resources.GetObject("RibbonOrbRecentItem1.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbRecentItem1.Name = "RibbonOrbRecentItem1"
        Me.RibbonOrbRecentItem1.SmallImage = CType(resources.GetObject("RibbonOrbRecentItem1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbRecentItem1.Text = "RibbonOrbRecentItem1"
        '
        'RibbonButton_Importieren
        '
        Me.RibbonButton_Importieren.Image = Global.Notenarchiv.My.Resources.Resources.insert
        Me.RibbonButton_Importieren.LargeImage = Global.Notenarchiv.My.Resources.Resources.insert
        Me.RibbonButton_Importieren.Name = "RibbonButton_Importieren"
        Me.RibbonButton_Importieren.SmallImage = Global.Notenarchiv.My.Resources.Resources.insert
        '
        'RibbonButtonEinlesen
        '
        Me.RibbonButtonEinlesen.Image = CType(resources.GetObject("RibbonButtonEinlesen.Image"), System.Drawing.Image)
        Me.RibbonButtonEinlesen.LargeImage = CType(resources.GetObject("RibbonButtonEinlesen.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonEinlesen.Name = "RibbonButtonEinlesen"
        Me.RibbonButtonEinlesen.SmallImage = CType(resources.GetObject("RibbonButtonEinlesen.SmallImage"), System.Drawing.Image)
        '
        'btn_Einstellungen
        '
        Me.btn_Einstellungen.Location = New System.Drawing.Point(999, 229)
        Me.btn_Einstellungen.Name = "btn_Einstellungen"
        Me.btn_Einstellungen.Size = New System.Drawing.Size(100, 23)
        Me.btn_Einstellungen.TabIndex = 5
        Me.btn_Einstellungen.Text = "Einstellungen"
        Me.btn_Einstellungen.UseVisualStyleBackColor = True
        '
        'Hauptfenster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 555)
        Me.Controls.Add(Me.btn_Einstellungen)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Ribbon1)
        Me.KeyPreview = True
        Me.Name = "Hauptfenster"
        Me.Text = "Hauptfenster"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents ribbontab_Importieren As RibbonTab
    Friend WithEvents RibbonPanel_Importieren As RibbonPanel
    Friend WithEvents RibbonButton_Importieren As RibbonButton
    Friend WithEvents RibbonOrbMenuItem1 As RibbonOrbMenuItem
    Friend WithEvents RibbonOrbMenuItem2 As RibbonOrbMenuItem
    Friend WithEvents RibbonOrbMenuItem3 As RibbonOrbMenuItem
    Friend WithEvents RibbonOrbOptionButton1 As RibbonOrbOptionButton
    Friend WithEvents RibbonOrbOptionButton2 As RibbonOrbOptionButton
    Friend WithEvents RibbonOrbRecentItem1 As RibbonOrbRecentItem
    Friend WithEvents RibbonContext1 As RibbonContext
    Friend WithEvents RibbonContext2 As RibbonContext
    Friend WithEvents RibbonContext3 As RibbonContext
    Friend WithEvents RibbonContext4 As RibbonContext
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonPanelEinlesen As RibbonPanel
    Friend WithEvents RibbonButtonEinlesen As RibbonButton
    Friend WithEvents btn_Einstellungen As Button
End Class
