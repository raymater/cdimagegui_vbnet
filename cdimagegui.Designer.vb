<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents formRefresh As System.Windows.Forms.Button
	Public CommonDialog2Open As System.Windows.Forms.OpenFileDialog
	Public WithEvents formInfos As System.Windows.Forms.TextBox
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Public WithEvents formCreateButton As System.Windows.Forms.Button
	Public WithEvents formBoot_Parcourir As System.Windows.Forms.Button
	Public WithEvents formBoot_InputID As System.Windows.Forms.TextBox
	Public WithEvents formBoot_ID As System.Windows.Forms.CheckBox
	Public WithEvents formBoot_Floppy As System.Windows.Forms.CheckBox
	Public WithEvents formBoot_FileBoot As System.Windows.Forms.TextBox
	Public WithEvents formBoot_Secteur As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents formUDF_VideoZone As System.Windows.Forms.CheckBox
	Public WithEvents formUDF_Allocation As System.Windows.Forms.CheckBox
	Public WithEvents formUDF_Clairseme As System.Windows.Forms.CheckBox
	Public WithEvents formUDF_FID As System.Windows.Forms.CheckBox
	Public WithEvents formUDF_Input As System.Windows.Forms.CheckBox
	Public WithEvents formUDF_UDF As System.Windows.Forms.RadioButton
	Public WithEvents formUDF_ISO As System.Windows.Forms.RadioButton
	Public WithEvents groupUDF As System.Windows.Forms.GroupBox
	Public WithEvents formJoliet_Unicode As System.Windows.Forms.RadioButton
	Public WithEvents formJoliet_ISO As System.Windows.Forms.RadioButton
	Public WithEvents groupJoliet As System.Windows.Forms.GroupBox
	Public WithEvents formISO_Maj As System.Windows.Forms.CheckBox
	Public WithEvents formISO_LongNT As System.Windows.Forms.RadioButton
	Public WithEvents formISO_Long As System.Windows.Forms.RadioButton
	Public WithEvents formISO_DOS As System.Windows.Forms.RadioButton
	Public WithEvents groupISO As System.Windows.Forms.GroupBox
	Public WithEvents formFileUDF As System.Windows.Forms.RadioButton
	Public WithEvents formFileJoliet As System.Windows.Forms.RadioButton
	Public WithEvents formFileISO9660 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents formLabel As System.Windows.Forms.TextBox
    Public CommonDialog1Save As System.Windows.Forms.SaveFileDialog
	Public WithEvents formGen_Force As System.Windows.Forms.CheckBox
	Public WithEvents formGen_ANSI As System.Windows.Forms.CheckBox
	Public WithEvents formGen_Hide As System.Windows.Forms.CheckBox
	Public WithEvents formGen_GMT As System.Windows.Forms.CheckBox
	Public WithEvents formGen_DateCheck As System.Windows.Forms.CheckBox
	Public WithEvents formGen_limit As System.Windows.Forms.CheckBox
    Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents formSaveButton As System.Windows.Forms.Button
	Public WithEvents formSaveAs As System.Windows.Forms.TextBox
	Public WithEvents formListOpticalDisks As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.formRefresh = New System.Windows.Forms.Button()
        Me.CommonDialog2Open = New System.Windows.Forms.OpenFileDialog()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.formInfos = New System.Windows.Forms.TextBox()
        Me.formCreateButton = New System.Windows.Forms.Button()
        Me.formBoot_Parcourir = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.formBoot_InputID = New System.Windows.Forms.TextBox()
        Me.formBoot_ID = New System.Windows.Forms.CheckBox()
        Me.formBoot_Floppy = New System.Windows.Forms.CheckBox()
        Me.formBoot_FileBoot = New System.Windows.Forms.TextBox()
        Me.formBoot_Secteur = New System.Windows.Forms.CheckBox()
        Me.groupUDF = New System.Windows.Forms.GroupBox()
        Me.formUDF_VideoZone = New System.Windows.Forms.CheckBox()
        Me.formUDF_Allocation = New System.Windows.Forms.CheckBox()
        Me.formUDF_Clairseme = New System.Windows.Forms.CheckBox()
        Me.formUDF_FID = New System.Windows.Forms.CheckBox()
        Me.formUDF_Input = New System.Windows.Forms.CheckBox()
        Me.formUDF_UDF = New System.Windows.Forms.RadioButton()
        Me.formUDF_ISO = New System.Windows.Forms.RadioButton()
        Me.groupJoliet = New System.Windows.Forms.GroupBox()
        Me.formJoliet_Unicode = New System.Windows.Forms.RadioButton()
        Me.formJoliet_ISO = New System.Windows.Forms.RadioButton()
        Me.groupISO = New System.Windows.Forms.GroupBox()
        Me.formISO_Maj = New System.Windows.Forms.CheckBox()
        Me.formISO_LongNT = New System.Windows.Forms.RadioButton()
        Me.formISO_Long = New System.Windows.Forms.RadioButton()
        Me.formISO_DOS = New System.Windows.Forms.RadioButton()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.formFileUDF = New System.Windows.Forms.RadioButton()
        Me.formFileJoliet = New System.Windows.Forms.RadioButton()
        Me.formFileISO9660 = New System.Windows.Forms.RadioButton()
        Me.formLabel = New System.Windows.Forms.TextBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.formGen_Date = New System.Windows.Forms.DateTimePicker()
        Me.formGen_Force = New System.Windows.Forms.CheckBox()
        Me.formGen_ANSI = New System.Windows.Forms.CheckBox()
        Me.formGen_Hide = New System.Windows.Forms.CheckBox()
        Me.formGen_GMT = New System.Windows.Forms.CheckBox()
        Me.formGen_DateCheck = New System.Windows.Forms.CheckBox()
        Me.formGen_limit = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CommonDialog1Save = New System.Windows.Forms.SaveFileDialog()
        Me.formSaveButton = New System.Windows.Forms.Button()
        Me.formSaveAs = New System.Windows.Forms.TextBox()
        Me.formListOpticalDisks = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame8.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.groupUDF.SuspendLayout()
        Me.groupJoliet.SuspendLayout()
        Me.groupISO.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.SuspendLayout()
        '
        'formRefresh
        '
        Me.formRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.formRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.formRefresh.Font = New System.Drawing.Font("Webdings", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.formRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formRefresh.Location = New System.Drawing.Point(776, 16)
        Me.formRefresh.Name = "formRefresh"
        Me.formRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formRefresh.Size = New System.Drawing.Size(57, 57)
        Me.formRefresh.TabIndex = 49
        Me.formRefresh.Text = "q"
        Me.formRefresh.UseVisualStyleBackColor = False
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me.formInfos)
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(774, 90)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(225, 453)
        Me.Frame8.TabIndex = 45
        Me.Frame8.TabStop = False
        Me.Frame8.Text = "Informations"
        '
        'formInfos
        '
        Me.formInfos.AcceptsReturn = True
        Me.formInfos.BackColor = System.Drawing.SystemColors.Window
        Me.formInfos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.formInfos.Enabled = False
        Me.formInfos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.formInfos.Location = New System.Drawing.Point(12, 24)
        Me.formInfos.MaxLength = 0
        Me.formInfos.Multiline = True
        Me.formInfos.Name = "formInfos"
        Me.formInfos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formInfos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.formInfos.Size = New System.Drawing.Size(201, 411)
        Me.formInfos.TabIndex = 46
        Me.formInfos.Text = "(Aucune information)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'formCreateButton
        '
        Me.formCreateButton.BackColor = System.Drawing.SystemColors.Control
        Me.formCreateButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.formCreateButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formCreateButton.Location = New System.Drawing.Point(844, 16)
        Me.formCreateButton.Name = "formCreateButton"
        Me.formCreateButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formCreateButton.Size = New System.Drawing.Size(153, 57)
        Me.formCreateButton.TabIndex = 44
        Me.formCreateButton.Text = "Créer l'image"
        Me.formCreateButton.UseVisualStyleBackColor = False
        '
        'formBoot_Parcourir
        '
        Me.formBoot_Parcourir.BackColor = System.Drawing.SystemColors.Control
        Me.formBoot_Parcourir.Cursor = System.Windows.Forms.Cursors.Default
        Me.formBoot_Parcourir.Enabled = False
        Me.formBoot_Parcourir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formBoot_Parcourir.Location = New System.Drawing.Point(636, 400)
        Me.formBoot_Parcourir.Name = "formBoot_Parcourir"
        Me.formBoot_Parcourir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formBoot_Parcourir.Size = New System.Drawing.Size(89, 25)
        Me.formBoot_Parcourir.TabIndex = 40
        Me.formBoot_Parcourir.Text = "Parcourir"
        Me.formBoot_Parcourir.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Frame7)
        Me.Frame1.Controls.Add(Me.groupUDF)
        Me.Frame1.Controls.Add(Me.groupJoliet)
        Me.Frame1.Controls.Add(Me.groupISO)
        Me.Frame1.Controls.Add(Me.Frame2)
        Me.Frame1.Controls.Add(Me.formLabel)
        Me.Frame1.Controls.Add(Me.Frame6)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 90)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(739, 453)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Paramètres"
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.SystemColors.Control
        Me.Frame7.Controls.Add(Me.formBoot_InputID)
        Me.Frame7.Controls.Add(Me.formBoot_ID)
        Me.Frame7.Controls.Add(Me.formBoot_Floppy)
        Me.Frame7.Controls.Add(Me.formBoot_FileBoot)
        Me.Frame7.Controls.Add(Me.formBoot_Secteur)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(376, 266)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(347, 169)
        Me.Frame7.TabIndex = 37
        Me.Frame7.TabStop = False
        Me.Frame7.Text = "Options de démarrage"
        '
        'formBoot_InputID
        '
        Me.formBoot_InputID.AcceptsReturn = True
        Me.formBoot_InputID.BackColor = System.Drawing.SystemColors.Window
        Me.formBoot_InputID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.formBoot_InputID.Enabled = False
        Me.formBoot_InputID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.formBoot_InputID.Location = New System.Drawing.Point(178, 104)
        Me.formBoot_InputID.MaxLength = 2
        Me.formBoot_InputID.Name = "formBoot_InputID"
        Me.formBoot_InputID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formBoot_InputID.Size = New System.Drawing.Size(29, 20)
        Me.formBoot_InputID.TabIndex = 43
        Me.formBoot_InputID.Text = "80"
        '
        'formBoot_ID
        '
        Me.formBoot_ID.BackColor = System.Drawing.SystemColors.Control
        Me.formBoot_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.formBoot_ID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formBoot_ID.Location = New System.Drawing.Point(16, 102)
        Me.formBoot_ID.Name = "formBoot_ID"
        Me.formBoot_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formBoot_ID.Size = New System.Drawing.Size(184, 25)
        Me.formBoot_ID.TabIndex = 42
        Me.formBoot_ID.Text = "Spécifier l'ID de plateforme :"
        Me.formBoot_ID.UseVisualStyleBackColor = False
        '
        'formBoot_Floppy
        '
        Me.formBoot_Floppy.BackColor = System.Drawing.SystemColors.Control
        Me.formBoot_Floppy.Cursor = System.Windows.Forms.Cursors.Default
        Me.formBoot_Floppy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formBoot_Floppy.Location = New System.Drawing.Point(16, 78)
        Me.formBoot_Floppy.Name = "formBoot_Floppy"
        Me.formBoot_Floppy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formBoot_Floppy.Size = New System.Drawing.Size(269, 27)
        Me.formBoot_Floppy.TabIndex = 41
        Me.formBoot_Floppy.Text = "Désactiver l'émulation disquette"
        Me.formBoot_Floppy.UseVisualStyleBackColor = False
        '
        'formBoot_FileBoot
        '
        Me.formBoot_FileBoot.AcceptsReturn = True
        Me.formBoot_FileBoot.BackColor = System.Drawing.SystemColors.Window
        Me.formBoot_FileBoot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.formBoot_FileBoot.Enabled = False
        Me.formBoot_FileBoot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.formBoot_FileBoot.Location = New System.Drawing.Point(36, 44)
        Me.formBoot_FileBoot.MaxLength = 0
        Me.formBoot_FileBoot.Name = "formBoot_FileBoot"
        Me.formBoot_FileBoot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formBoot_FileBoot.Size = New System.Drawing.Size(201, 20)
        Me.formBoot_FileBoot.TabIndex = 39
        '
        'formBoot_Secteur
        '
        Me.formBoot_Secteur.BackColor = System.Drawing.SystemColors.Control
        Me.formBoot_Secteur.Cursor = System.Windows.Forms.Cursors.Default
        Me.formBoot_Secteur.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formBoot_Secteur.Location = New System.Drawing.Point(16, 20)
        Me.formBoot_Secteur.Name = "formBoot_Secteur"
        Me.formBoot_Secteur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formBoot_Secteur.Size = New System.Drawing.Size(277, 21)
        Me.formBoot_Secteur.TabIndex = 38
        Me.formBoot_Secteur.Text = "Spécifier le fichier de secteur de démarrage"
        Me.formBoot_Secteur.UseVisualStyleBackColor = False
        '
        'groupUDF
        '
        Me.groupUDF.BackColor = System.Drawing.SystemColors.Control
        Me.groupUDF.Controls.Add(Me.formUDF_VideoZone)
        Me.groupUDF.Controls.Add(Me.formUDF_Allocation)
        Me.groupUDF.Controls.Add(Me.formUDF_Clairseme)
        Me.groupUDF.Controls.Add(Me.formUDF_FID)
        Me.groupUDF.Controls.Add(Me.formUDF_Input)
        Me.groupUDF.Controls.Add(Me.formUDF_UDF)
        Me.groupUDF.Controls.Add(Me.formUDF_ISO)
        Me.groupUDF.Enabled = False
        Me.groupUDF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.groupUDF.Location = New System.Drawing.Point(16, 266)
        Me.groupUDF.Name = "groupUDF"
        Me.groupUDF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupUDF.Size = New System.Drawing.Size(354, 169)
        Me.groupUDF.TabIndex = 20
        Me.groupUDF.TabStop = False
        Me.groupUDF.Text = "UDF Options"
        '
        'formUDF_VideoZone
        '
        Me.formUDF_VideoZone.BackColor = System.Drawing.SystemColors.Control
        Me.formUDF_VideoZone.Cursor = System.Windows.Forms.Cursors.Default
        Me.formUDF_VideoZone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formUDF_VideoZone.Location = New System.Drawing.Point(12, 136)
        Me.formUDF_VideoZone.Name = "formUDF_VideoZone"
        Me.formUDF_VideoZone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formUDF_VideoZone.Size = New System.Drawing.Size(321, 23)
        Me.formUDF_VideoZone.TabIndex = 27
        Me.formUDF_VideoZone.Text = "Compatibilité UDF Video Zone (DVD-Video et DVD-Audio)"
        Me.formUDF_VideoZone.UseVisualStyleBackColor = False
        '
        'formUDF_Allocation
        '
        Me.formUDF_Allocation.BackColor = System.Drawing.SystemColors.Control
        Me.formUDF_Allocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.formUDF_Allocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formUDF_Allocation.Location = New System.Drawing.Point(12, 110)
        Me.formUDF_Allocation.Name = "formUDF_Allocation"
        Me.formUDF_Allocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formUDF_Allocation.Size = New System.Drawing.Size(263, 29)
        Me.formUDF_Allocation.TabIndex = 26
        Me.formUDF_Allocation.Text = "Descripteurs d'allocation longs"
        Me.formUDF_Allocation.UseVisualStyleBackColor = False
        '
        'formUDF_Clairseme
        '
        Me.formUDF_Clairseme.BackColor = System.Drawing.SystemColors.Control
        Me.formUDF_Clairseme.Cursor = System.Windows.Forms.Cursors.Default
        Me.formUDF_Clairseme.Enabled = False
        Me.formUDF_Clairseme.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formUDF_Clairseme.Location = New System.Drawing.Point(12, 88)
        Me.formUDF_Clairseme.Name = "formUDF_Clairseme"
        Me.formUDF_Clairseme.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formUDF_Clairseme.Size = New System.Drawing.Size(207, 27)
        Me.formUDF_Clairseme.TabIndex = 25
        Me.formUDF_Clairseme.Text = "Fichiers UDF clairsemés"
        Me.formUDF_Clairseme.UseVisualStyleBackColor = False
        '
        'formUDF_FID
        '
        Me.formUDF_FID.BackColor = System.Drawing.SystemColors.Control
        Me.formUDF_FID.Cursor = System.Windows.Forms.Cursors.Default
        Me.formUDF_FID.Enabled = False
        Me.formUDF_FID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formUDF_FID.Location = New System.Drawing.Point(12, 66)
        Me.formUDF_FID.Name = "formUDF_FID"
        Me.formUDF_FID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formUDF_FID.Size = New System.Drawing.Size(321, 23)
        Me.formUDF_FID.TabIndex = 24
        Me.formUDF_FID.Text = "Incorporer les entrées FID UDF"
        Me.formUDF_FID.UseVisualStyleBackColor = False
        '
        'formUDF_Input
        '
        Me.formUDF_Input.BackColor = System.Drawing.SystemColors.Control
        Me.formUDF_Input.Cursor = System.Windows.Forms.Cursors.Default
        Me.formUDF_Input.Enabled = False
        Me.formUDF_Input.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formUDF_Input.Location = New System.Drawing.Point(12, 44)
        Me.formUDF_Input.Name = "formUDF_Input"
        Me.formUDF_Input.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formUDF_Input.Size = New System.Drawing.Size(335, 21)
        Me.formUDF_Input.TabIndex = 23
        Me.formUDF_Input.Text = "Incorporer les données de fichier dans l'entrée d'étendue UDF"
        Me.formUDF_Input.UseVisualStyleBackColor = False
        '
        'formUDF_UDF
        '
        Me.formUDF_UDF.BackColor = System.Drawing.SystemColors.Control
        Me.formUDF_UDF.Cursor = System.Windows.Forms.Cursors.Default
        Me.formUDF_UDF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formUDF_UDF.Location = New System.Drawing.Point(176, 22)
        Me.formUDF_UDF.Name = "formUDF_UDF"
        Me.formUDF_UDF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formUDF_UDF.Size = New System.Drawing.Size(147, 19)
        Me.formUDF_UDF.TabIndex = 22
        Me.formUDF_UDF.TabStop = True
        Me.formUDF_UDF.Text = "UDF Uniquement"
        Me.formUDF_UDF.UseVisualStyleBackColor = False
        '
        'formUDF_ISO
        '
        Me.formUDF_ISO.BackColor = System.Drawing.SystemColors.Control
        Me.formUDF_ISO.Checked = True
        Me.formUDF_ISO.Cursor = System.Windows.Forms.Cursors.Default
        Me.formUDF_ISO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formUDF_ISO.Location = New System.Drawing.Point(12, 22)
        Me.formUDF_ISO.Name = "formUDF_ISO"
        Me.formUDF_ISO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formUDF_ISO.Size = New System.Drawing.Size(157, 19)
        Me.formUDF_ISO.TabIndex = 21
        Me.formUDF_ISO.TabStop = True
        Me.formUDF_ISO.Text = "Compatibilité ISO 9660"
        Me.formUDF_ISO.UseVisualStyleBackColor = False
        '
        'groupJoliet
        '
        Me.groupJoliet.BackColor = System.Drawing.SystemColors.Control
        Me.groupJoliet.Controls.Add(Me.formJoliet_Unicode)
        Me.groupJoliet.Controls.Add(Me.formJoliet_ISO)
        Me.groupJoliet.Enabled = False
        Me.groupJoliet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.groupJoliet.Location = New System.Drawing.Point(16, 210)
        Me.groupJoliet.Name = "groupJoliet"
        Me.groupJoliet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupJoliet.Size = New System.Drawing.Size(354, 49)
        Me.groupJoliet.TabIndex = 17
        Me.groupJoliet.TabStop = False
        Me.groupJoliet.Text = "Options Joliet"
        '
        'formJoliet_Unicode
        '
        Me.formJoliet_Unicode.BackColor = System.Drawing.SystemColors.Control
        Me.formJoliet_Unicode.Cursor = System.Windows.Forms.Cursors.Default
        Me.formJoliet_Unicode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formJoliet_Unicode.Location = New System.Drawing.Point(176, 20)
        Me.formJoliet_Unicode.Name = "formJoliet_Unicode"
        Me.formJoliet_Unicode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formJoliet_Unicode.Size = New System.Drawing.Size(97, 21)
        Me.formJoliet_Unicode.TabIndex = 19
        Me.formJoliet_Unicode.TabStop = True
        Me.formJoliet_Unicode.Text = "Unicode"
        Me.formJoliet_Unicode.UseVisualStyleBackColor = False
        '
        'formJoliet_ISO
        '
        Me.formJoliet_ISO.BackColor = System.Drawing.SystemColors.Control
        Me.formJoliet_ISO.Checked = True
        Me.formJoliet_ISO.Cursor = System.Windows.Forms.Cursors.Default
        Me.formJoliet_ISO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formJoliet_ISO.Location = New System.Drawing.Point(12, 20)
        Me.formJoliet_ISO.Name = "formJoliet_ISO"
        Me.formJoliet_ISO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formJoliet_ISO.Size = New System.Drawing.Size(155, 21)
        Me.formJoliet_ISO.TabIndex = 18
        Me.formJoliet_ISO.TabStop = True
        Me.formJoliet_ISO.Text = "Compatibilité ISO 9660"
        Me.formJoliet_ISO.UseVisualStyleBackColor = False
        '
        'groupISO
        '
        Me.groupISO.BackColor = System.Drawing.SystemColors.Control
        Me.groupISO.Controls.Add(Me.formISO_Maj)
        Me.groupISO.Controls.Add(Me.formISO_LongNT)
        Me.groupISO.Controls.Add(Me.formISO_Long)
        Me.groupISO.Controls.Add(Me.formISO_DOS)
        Me.groupISO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.groupISO.Location = New System.Drawing.Point(16, 108)
        Me.groupISO.Name = "groupISO"
        Me.groupISO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupISO.Size = New System.Drawing.Size(354, 95)
        Me.groupISO.TabIndex = 12
        Me.groupISO.TabStop = False
        Me.groupISO.Text = "Options ISO 9660"
        '
        'formISO_Maj
        '
        Me.formISO_Maj.BackColor = System.Drawing.SystemColors.Control
        Me.formISO_Maj.Cursor = System.Windows.Forms.Cursors.Default
        Me.formISO_Maj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formISO_Maj.Location = New System.Drawing.Point(12, 66)
        Me.formISO_Maj.Name = "formISO_Maj"
        Me.formISO_Maj.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formISO_Maj.Size = New System.Drawing.Size(269, 21)
        Me.formISO_Maj.TabIndex = 16
        Me.formISO_Maj.Text = "Autoriser les noms de fichiers en minuscule"
        Me.formISO_Maj.UseVisualStyleBackColor = False
        '
        'formISO_LongNT
        '
        Me.formISO_LongNT.BackColor = System.Drawing.SystemColors.Control
        Me.formISO_LongNT.Cursor = System.Windows.Forms.Cursors.Default
        Me.formISO_LongNT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formISO_LongNT.Location = New System.Drawing.Point(12, 44)
        Me.formISO_LongNT.Name = "formISO_LongNT"
        Me.formISO_LongNT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formISO_LongNT.Size = New System.Drawing.Size(291, 19)
        Me.formISO_LongNT.TabIndex = 15
        Me.formISO_LongNT.TabStop = True
        Me.formISO_LongNT.Text = "Long (30) - compatibilité Windows NT 3.51"
        Me.formISO_LongNT.UseVisualStyleBackColor = False
        '
        'formISO_Long
        '
        Me.formISO_Long.BackColor = System.Drawing.SystemColors.Control
        Me.formISO_Long.Cursor = System.Windows.Forms.Cursors.Default
        Me.formISO_Long.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formISO_Long.Location = New System.Drawing.Point(134, 20)
        Me.formISO_Long.Name = "formISO_Long"
        Me.formISO_Long.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formISO_Long.Size = New System.Drawing.Size(115, 19)
        Me.formISO_Long.TabIndex = 14
        Me.formISO_Long.TabStop = True
        Me.formISO_Long.Text = "Long (30)"
        Me.formISO_Long.UseVisualStyleBackColor = False
        '
        'formISO_DOS
        '
        Me.formISO_DOS.BackColor = System.Drawing.SystemColors.Control
        Me.formISO_DOS.Checked = True
        Me.formISO_DOS.Cursor = System.Windows.Forms.Cursors.Default
        Me.formISO_DOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formISO_DOS.Location = New System.Drawing.Point(12, 20)
        Me.formISO_DOS.Name = "formISO_DOS"
        Me.formISO_DOS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formISO_DOS.Size = New System.Drawing.Size(93, 19)
        Me.formISO_DOS.TabIndex = 13
        Me.formISO_DOS.TabStop = True
        Me.formISO_DOS.Text = "DOS (8.3)"
        Me.formISO_DOS.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.formFileUDF)
        Me.Frame2.Controls.Add(Me.formFileJoliet)
        Me.Frame2.Controls.Add(Me.formFileISO9660)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(16, 54)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(354, 47)
        Me.Frame2.TabIndex = 8
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Système de fichiers"
        '
        'formFileUDF
        '
        Me.formFileUDF.BackColor = System.Drawing.SystemColors.Control
        Me.formFileUDF.Cursor = System.Windows.Forms.Cursors.Default
        Me.formFileUDF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formFileUDF.Location = New System.Drawing.Point(248, 18)
        Me.formFileUDF.Name = "formFileUDF"
        Me.formFileUDF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formFileUDF.Size = New System.Drawing.Size(81, 23)
        Me.formFileUDF.TabIndex = 11
        Me.formFileUDF.TabStop = True
        Me.formFileUDF.Text = "UDF"
        Me.formFileUDF.UseVisualStyleBackColor = False
        '
        'formFileJoliet
        '
        Me.formFileJoliet.BackColor = System.Drawing.SystemColors.Control
        Me.formFileJoliet.Cursor = System.Windows.Forms.Cursors.Default
        Me.formFileJoliet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formFileJoliet.Location = New System.Drawing.Point(134, 20)
        Me.formFileJoliet.Name = "formFileJoliet"
        Me.formFileJoliet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formFileJoliet.Size = New System.Drawing.Size(101, 19)
        Me.formFileJoliet.TabIndex = 10
        Me.formFileJoliet.TabStop = True
        Me.formFileJoliet.Text = "Joliet"
        Me.formFileJoliet.UseVisualStyleBackColor = False
        '
        'formFileISO9660
        '
        Me.formFileISO9660.BackColor = System.Drawing.SystemColors.Control
        Me.formFileISO9660.Checked = True
        Me.formFileISO9660.Cursor = System.Windows.Forms.Cursors.Default
        Me.formFileISO9660.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formFileISO9660.Location = New System.Drawing.Point(12, 20)
        Me.formFileISO9660.Name = "formFileISO9660"
        Me.formFileISO9660.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formFileISO9660.Size = New System.Drawing.Size(107, 19)
        Me.formFileISO9660.TabIndex = 9
        Me.formFileISO9660.TabStop = True
        Me.formFileISO9660.Text = "ISO 9660"
        Me.formFileISO9660.UseVisualStyleBackColor = False
        '
        'formLabel
        '
        Me.formLabel.AcceptsReturn = True
        Me.formLabel.BackColor = System.Drawing.SystemColors.Window
        Me.formLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.formLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.formLabel.Location = New System.Drawing.Point(58, 24)
        Me.formLabel.MaxLength = 0
        Me.formLabel.Name = "formLabel"
        Me.formLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formLabel.Size = New System.Drawing.Size(312, 20)
        Me.formLabel.TabIndex = 7
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.formGen_Date)
        Me.Frame6.Controls.Add(Me.formGen_Force)
        Me.Frame6.Controls.Add(Me.formGen_ANSI)
        Me.Frame6.Controls.Add(Me.formGen_Hide)
        Me.Frame6.Controls.Add(Me.formGen_GMT)
        Me.Frame6.Controls.Add(Me.formGen_DateCheck)
        Me.Frame6.Controls.Add(Me.formGen_limit)
        Me.Frame6.Controls.Add(Me.Label5)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(376, 18)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(347, 241)
        Me.Frame6.TabIndex = 28
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "Général"
        '
        'formGen_Date
        '
        Me.formGen_Date.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.formGen_Date.Enabled = False
        Me.formGen_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.formGen_Date.Location = New System.Drawing.Point(122, 82)
        Me.formGen_Date.Name = "formGen_Date"
        Me.formGen_Date.Size = New System.Drawing.Size(200, 20)
        Me.formGen_Date.TabIndex = 37
        '
        'formGen_Force
        '
        Me.formGen_Force.BackColor = System.Drawing.SystemColors.Control
        Me.formGen_Force.Cursor = System.Windows.Forms.Cursors.Default
        Me.formGen_Force.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formGen_Force.Location = New System.Drawing.Point(18, 206)
        Me.formGen_Force.Name = "formGen_Force"
        Me.formGen_Force.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formGen_Force.Size = New System.Drawing.Size(217, 23)
        Me.formGen_Force.TabIndex = 36
        Me.formGen_Force.Text = "Forcer la création de l'image"
        Me.formGen_Force.UseVisualStyleBackColor = False
        '
        'formGen_ANSI
        '
        Me.formGen_ANSI.BackColor = System.Drawing.SystemColors.Control
        Me.formGen_ANSI.Cursor = System.Windows.Forms.Cursors.Default
        Me.formGen_ANSI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formGen_ANSI.Location = New System.Drawing.Point(18, 184)
        Me.formGen_ANSI.Name = "formGen_ANSI"
        Me.formGen_ANSI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formGen_ANSI.Size = New System.Drawing.Size(255, 21)
        Me.formGen_ANSI.TabIndex = 35
        Me.formGen_ANSI.Text = "Utiliser ANSI pour les noms de fichiers"
        Me.formGen_ANSI.UseVisualStyleBackColor = False
        '
        'formGen_Hide
        '
        Me.formGen_Hide.BackColor = System.Drawing.SystemColors.Control
        Me.formGen_Hide.Cursor = System.Windows.Forms.Cursors.Default
        Me.formGen_Hide.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formGen_Hide.Location = New System.Drawing.Point(18, 160)
        Me.formGen_Hide.Name = "formGen_Hide"
        Me.formGen_Hide.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formGen_Hide.Size = New System.Drawing.Size(249, 21)
        Me.formGen_Hide.TabIndex = 34
        Me.formGen_Hide.Text = "Inclure les fichiers/dossiers cachés"
        Me.formGen_Hide.UseVisualStyleBackColor = False
        '
        'formGen_GMT
        '
        Me.formGen_GMT.BackColor = System.Drawing.SystemColors.Control
        Me.formGen_GMT.Cursor = System.Windows.Forms.Cursors.Default
        Me.formGen_GMT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formGen_GMT.Location = New System.Drawing.Point(18, 134)
        Me.formGen_GMT.Name = "formGen_GMT"
        Me.formGen_GMT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formGen_GMT.Size = New System.Drawing.Size(221, 23)
        Me.formGen_GMT.TabIndex = 33
        Me.formGen_GMT.Text = "Utiliser le fuseau horaire GMT"
        Me.formGen_GMT.UseVisualStyleBackColor = False
        '
        'formGen_DateCheck
        '
        Me.formGen_DateCheck.BackColor = System.Drawing.SystemColors.Control
        Me.formGen_DateCheck.Cursor = System.Windows.Forms.Cursors.Default
        Me.formGen_DateCheck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formGen_DateCheck.Location = New System.Drawing.Point(18, 52)
        Me.formGen_DateCheck.Name = "formGen_DateCheck"
        Me.formGen_DateCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formGen_DateCheck.Size = New System.Drawing.Size(305, 31)
        Me.formGen_DateCheck.TabIndex = 30
        Me.formGen_DateCheck.Text = "Définir date/heure pour les fichiers/dossiers :"
        Me.formGen_DateCheck.UseVisualStyleBackColor = False
        '
        'formGen_limit
        '
        Me.formGen_limit.BackColor = System.Drawing.SystemColors.Control
        Me.formGen_limit.Cursor = System.Windows.Forms.Cursors.Default
        Me.formGen_limit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formGen_limit.Location = New System.Drawing.Point(18, 22)
        Me.formGen_limit.Name = "formGen_limit"
        Me.formGen_limit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formGen_limit.Size = New System.Drawing.Size(309, 23)
        Me.formGen_limit.TabIndex = 29
        Me.formGen_limit.Text = "Ignorer la limitation à 650 Mio"
        Me.formGen_limit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(42, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Date/heure :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label"
        '
        'formSaveButton
        '
        Me.formSaveButton.BackColor = System.Drawing.SystemColors.Control
        Me.formSaveButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.formSaveButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.formSaveButton.Location = New System.Drawing.Point(666, 48)
        Me.formSaveButton.Name = "formSaveButton"
        Me.formSaveButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formSaveButton.Size = New System.Drawing.Size(89, 25)
        Me.formSaveButton.TabIndex = 4
        Me.formSaveButton.Text = "Parcourir"
        Me.formSaveButton.UseVisualStyleBackColor = False
        '
        'formSaveAs
        '
        Me.formSaveAs.AcceptsReturn = True
        Me.formSaveAs.BackColor = System.Drawing.SystemColors.Window
        Me.formSaveAs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.formSaveAs.Enabled = False
        Me.formSaveAs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.formSaveAs.Location = New System.Drawing.Point(102, 48)
        Me.formSaveAs.MaxLength = 0
        Me.formSaveAs.Name = "formSaveAs"
        Me.formSaveAs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formSaveAs.Size = New System.Drawing.Size(559, 20)
        Me.formSaveAs.TabIndex = 3
        '
        'formListOpticalDisks
        '
        Me.formListOpticalDisks.BackColor = System.Drawing.SystemColors.Window
        Me.formListOpticalDisks.Cursor = System.Windows.Forms.Cursors.Default
        Me.formListOpticalDisks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.formListOpticalDisks.ForeColor = System.Drawing.SystemColors.WindowText
        Me.formListOpticalDisks.Location = New System.Drawing.Point(102, 14)
        Me.formListOpticalDisks.Name = "formListOpticalDisks"
        Me.formListOpticalDisks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.formListOpticalDisks.Size = New System.Drawing.Size(653, 21)
        Me.formListOpticalDisks.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enregistrer sous :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lecteur optique :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1016, 559)
        Me.Controls.Add(Me.formRefresh)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.formCreateButton)
        Me.Controls.Add(Me.formBoot_Parcourir)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.formSaveButton)
        Me.Controls.Add(Me.formSaveAs)
        Me.Controls.Add(Me.formListOpticalDisks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(10, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "CDIMAGE (GUI)"
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame7.PerformLayout()
        Me.groupUDF.ResumeLayout(False)
        Me.groupJoliet.ResumeLayout(False)
        Me.groupISO.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents formGen_Date As System.Windows.Forms.DateTimePicker
#End Region 
End Class