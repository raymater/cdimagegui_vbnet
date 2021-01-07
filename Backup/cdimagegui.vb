Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class Form1
	Inherits System.Windows.Forms.Form
	Private Declare Function GetVolumeInformation Lib "kernel32.dll"  Alias "GetVolumeInformationA"(ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
	
	Private Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	
	Private Function isExist(ByRef letter As Object) As Boolean
		On Error GoTo noExist
		Dim d, driveExist, fso As Object
		
		isExist = False
		
		fso = CreateObject("Scripting.FileSystemObject")
		'UPGRADE_WARNING: Couldn't resolve default property of object fso.GetAbsolutePathName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object fso.GetDriveName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object fso.GetDrive. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d = fso.GetDrive(fso.GetDriveName(fso.GetAbsolutePathName(letter)))
		
		isExist = True
		
		On Error GoTo 0
		Exit Function
		
noExist: 
		isExist = False
		
	End Function
	
	Private Function FileExists(ByVal Fname As String) As Boolean
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileExists = IIf(Dir(Fname) <> "", True, False)
	End Function
	
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Short
		
		Dim letters As Object
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object letters. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		letters = New Object(){"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
		
		Dim existDisk As Object
		Dim letter As String
		Dim fso, d As Object
		For i = 0 To 25 Step 1
			
			'UPGRADE_WARNING: Couldn't resolve default property of object letters(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			letter = letters(i) & ":\"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object existDisk. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			existDisk = isExist(letter)
			
			
			'UPGRADE_WARNING: Couldn't resolve default property of object existDisk. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If (existDisk = True) Then
				
				
				fso = CreateObject("Scripting.FileSystemObject")
				'UPGRADE_WARNING: Couldn't resolve default property of object fso.GetAbsolutePathName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object fso.GetDriveName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object fso.GetDrive. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				d = fso.GetDrive(fso.GetDriveName(fso.GetAbsolutePathName(letter)))
				
				'UPGRADE_WARNING: Couldn't resolve default property of object d.DriveType. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (d.DriveType = 4) Then
					formListOpticalDisks.Items.Add((letter))
				End If
				
			End If
		Next 
		
		If (formListOpticalDisks.Items.Count > 0) Then
			formListOpticalDisks.SelectedIndex = 0
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Event formBoot_FileBoot.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formBoot_FileBoot_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formBoot_FileBoot.TextChanged
		Dim pos, rMes As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object pos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		pos = InStr(formBoot_FileBoot.Text, " ")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object pos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If (pos > 0) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object rMes. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rMes = MsgBox("Le chemin du fichier ne doit pas comporter d'espaces", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Erreur")
			formBoot_FileBoot.Text = ""
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formBoot_ID.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formBoot_ID_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formBoot_ID.CheckStateChanged
		If (formBoot_ID.CheckState = System.Windows.Forms.CheckState.Checked) Then
			formBoot_InputID.Enabled = True
		Else
			formBoot_InputID.Enabled = False
		End If
	End Sub
	
	Private Sub formBoot_Parcourir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formBoot_Parcourir.Click
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		CommonDialog2Open.Filter = "Boot sector file (*.bin;*.com)|*.bin;*.com"
		CommonDialog2Open.Title = "Ouvrir fichier Boot sector"
		CommonDialog2Open.ShowDialog()
		
		Dim f As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = CommonDialog2Open.FileName
		
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		formBoot_FileBoot.Text = f
	End Sub
	
	'UPGRADE_WARNING: Event formBoot_Secteur.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formBoot_Secteur_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formBoot_Secteur.CheckStateChanged
		If (formBoot_Secteur.CheckState = System.Windows.Forms.CheckState.Checked) Then
			formBoot_Parcourir.Enabled = True
		Else
			formBoot_Parcourir.Enabled = False
		End If
	End Sub
	
	'--------------------
	' BOUTON CREER IMAGE
	'--------------------
	Private Sub formCreateButton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formCreateButton.Click
		Dim commandOptions As String
		Dim rMes As Object
		Dim commandPath As Object
		commandOptions = ""
		
		Dim n1, y1, m1, d1, h1, s1 As Object
		Dim ess As Object
		Dim Options As Object
		Dim hwnd As Object
		Dim pathA As Object
		Dim folderFile As Object
		Dim fileSave As Object
		Dim i As Object
		'UPGRADE_NOTE: hour was upgraded to hour_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_NOTE: day was upgraded to day_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_NOTE: month was upgraded to month_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_NOTE: year was upgraded to year_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim min, year_Renamed, month_Renamed, day_Renamed, hour_Renamed, sec As Object
		If (formListOpticalDisks.Items.Count > 0) Then
			If (formSaveAs.Text <> "") Then
				If (formLabel.Text <> "") Then
					formLabel.Text = UCase(formLabel.Text)
					formLabel.Text = Replace(formLabel.Text, " ", "_")
					
					commandOptions = "-"
					
					If (formFileISO9660.Checked = True) Then
						If (formISO_Long.Checked = True) Then
							commandOptions = commandOptions & "n"
						End If
						If (formISO_LongNT.Checked = True) Then
							commandOptions = commandOptions & "nt"
						End If
						If (formISO_Maj.CheckState = System.Windows.Forms.CheckState.Checked) Then
							commandOptions = commandOptions & "d"
						End If
					End If
					
					If (formFileJoliet.Checked = True) Then
						If (formJoliet_ISO.Checked = True) Then
							commandOptions = commandOptions & "j1"
							
							If (formISO_Long.Checked = True) Then
								commandOptions = commandOptions & "n"
							End If
							If (formISO_LongNT.Checked = True) Then
								commandOptions = commandOptions & "nt"
							End If
							If (formISO_Maj.CheckState = System.Windows.Forms.CheckState.Checked) Then
								commandOptions = commandOptions & "d"
							End If
							
						End If
						If (formJoliet_Unicode.Checked = True) Then
							commandOptions = commandOptions & "j2"
						End If
					End If
					
					If (formFileUDF.Checked = True) Then
						If (formUDF_ISO.Checked = True) Then
							commandOptions = commandOptions & "u1"
							
							If (formISO_Long.Checked = True) Then
								commandOptions = commandOptions & "n"
							End If
							If (formISO_LongNT.Checked = True) Then
								commandOptions = commandOptions & "nt"
							End If
							If (formISO_Maj.CheckState = System.Windows.Forms.CheckState.Checked) Then
								commandOptions = commandOptions & "d"
							End If
						End If
						
						If (formUDF_UDF.Checked = True) Then
							commandOptions = commandOptions & "u2"
							
							If (formUDF_Clairseme.CheckState = System.Windows.Forms.CheckState.Checked) Then
								commandOptions = commandOptions & "us"
							End If
							If (formUDF_FID.CheckState = System.Windows.Forms.CheckState.Checked) Then
								commandOptions = commandOptions & "uf"
							End If
							If (formUDF_Input.CheckState = System.Windows.Forms.CheckState.Checked) Then
								commandOptions = commandOptions & "ue"
							End If
						End If
						
						
						If (formUDF_Allocation.CheckState = System.Windows.Forms.CheckState.Checked) Then
							commandOptions = commandOptions & "yl"
						End If
						If (formUDF_VideoZone.CheckState = System.Windows.Forms.CheckState.Checked) Then
							commandOptions = commandOptions & "uv"
						End If
					End If
					
					If (formGen_limit.CheckState = System.Windows.Forms.CheckState.Checked) Then
						commandOptions = commandOptions & "m"
					End If
					If (formGen_GMT.CheckState = System.Windows.Forms.CheckState.Checked) Then
						commandOptions = commandOptions & "g"
					End If
					If (formGen_Hide.CheckState = System.Windows.Forms.CheckState.Checked) Then
						commandOptions = commandOptions & "h"
					End If
					If (formGen_ANSI.CheckState = System.Windows.Forms.CheckState.Checked) Then
						commandOptions = commandOptions & "c"
					End If
					If (formGen_Force.CheckState = System.Windows.Forms.CheckState.Checked) Then
						commandOptions = commandOptions & "k"
					End If
					
					If (formBoot_Floppy.CheckState = System.Windows.Forms.CheckState.Checked) Then
						commandOptions = commandOptions & "e"
					End If
					If (formBoot_ID.CheckState = System.Windows.Forms.CheckState.Checked) Then
						commandOptions = commandOptions & "p" & formBoot_InputID.Text
					End If
					
					If (commandOptions = "-") Then
						commandOptions = ""
					End If
					commandOptions = commandOptions & " -l" & """" & formLabel.Text & """"
					
					If (formGen_DateCheck.CheckState = System.Windows.Forms.CheckState.Checked) Then
						
						'UPGRADE_WARNING: Couldn't resolve default property of object m1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						m1 = ""
						'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d1 = ""
						'UPGRADE_WARNING: Couldn't resolve default property of object y1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						y1 = ""
						'UPGRADE_WARNING: Couldn't resolve default property of object h1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						h1 = ""
						'UPGRADE_WARNING: Couldn't resolve default property of object n1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						n1 = ""
						'UPGRADE_WARNING: Couldn't resolve default property of object s1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						s1 = ""
						
						'UPGRADE_WARNING: Couldn't resolve default property of object formGen_Date.day. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object day_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        day_Renamed = formGen_Date.Value.Day
						'UPGRADE_WARNING: Couldn't resolve default property of object formGen_Date.month. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object month_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        month_Renamed = formGen_Date.Value.Month
						'UPGRADE_WARNING: Couldn't resolve default property of object formGen_Date.year. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object year_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        year_Renamed = formGen_Date.Value.Year
						'UPGRADE_WARNING: Couldn't resolve default property of object formGen_Hour.hour. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object hour_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        hour_Renamed = formGen_Date.Value.Hour
						'UPGRADE_WARNING: Couldn't resolve default property of object formGen_Hour.Minute. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object min. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        min = formGen_Date.Value.Minute
						'UPGRADE_WARNING: Couldn't resolve default property of object formGen_Hour.Second. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object sec. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sec = formGen_Date.Value.Second
						
						'UPGRADE_WARNING: Couldn't resolve default property of object day_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If (day_Renamed < 10) Then
							'UPGRADE_WARNING: Couldn't resolve default property of object day_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							d1 = "0" & CStr(day_Renamed)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object day_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							d1 = CStr(day_Renamed)
						End If
						'UPGRADE_WARNING: Couldn't resolve default property of object month_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If (month_Renamed < 10) Then
							'UPGRADE_WARNING: Couldn't resolve default property of object month_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object m1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							m1 = "0" & CStr(month_Renamed)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object month_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object m1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							m1 = CStr(month_Renamed)
						End If
						'UPGRADE_WARNING: Couldn't resolve default property of object year_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If (year_Renamed < 10) Then
							'UPGRADE_WARNING: Couldn't resolve default property of object year_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object y1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							y1 = "0" & CStr(year_Renamed)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object year_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object y1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							y1 = CStr(year_Renamed)
						End If
						'UPGRADE_WARNING: Couldn't resolve default property of object hour_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If (hour_Renamed < 10) Then
							'UPGRADE_WARNING: Couldn't resolve default property of object hour_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object h1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							h1 = "0" & CStr(hour_Renamed)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object hour_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object h1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							h1 = CStr(hour_Renamed)
						End If
						'UPGRADE_WARNING: Couldn't resolve default property of object min. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If (min < 10) Then
							'UPGRADE_WARNING: Couldn't resolve default property of object min. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object n1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							n1 = "0" & CStr(min)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object min. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object n1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							n1 = CStr(min)
						End If
						'UPGRADE_WARNING: Couldn't resolve default property of object sec. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If (sec < 10) Then
							'UPGRADE_WARNING: Couldn't resolve default property of object sec. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object s1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							s1 = "0" & CStr(sec)
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object sec. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object s1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							s1 = CStr(sec)
						End If
						
						'UPGRADE_WARNING: Couldn't resolve default property of object s1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object n1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object h1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object y1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object m1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						commandOptions = commandOptions & " -t" & m1 & "/" & d1 & "/" & y1 & "," & h1 & ":" & n1 & ":" & s1
					End If
					
					If (formBoot_Secteur.CheckState = System.Windows.Forms.CheckState.Checked) Then
						If (formBoot_FileBoot.Text <> "") Then
							commandOptions = commandOptions & " -b" & """" & formBoot_FileBoot.Text & """"
						End If
					End If
					
					'UPGRADE_WARNING: Couldn't resolve default property of object commandPath. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					commandPath = My.Application.Info.DirectoryPath & "\cdimage.exe"
					'UPGRADE_WARNING: Couldn't resolve default property of object commandPath. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object ess. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ess = FileExists(commandPath)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object ess. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If (ess = True) Then
						'UPGRADE_WARNING: Couldn't resolve default property of object folderFile. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						folderFile = ""
						'UPGRADE_WARNING: Couldn't resolve default property of object fileSave. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						fileSave = ""
						'UPGRADE_WARNING: Couldn't resolve default property of object hwnd. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						hwnd = Me.Handle.ToInt32
						
						'UPGRADE_WARNING: Couldn't resolve default property of object pathA. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pathA = Split(formSaveAs.Text, "\")
						
						For i = LBound(pathA) To (UBound(pathA) - 1) Step 1
							'UPGRADE_WARNING: Couldn't resolve default property of object pathA(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object folderFile. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							folderFile = folderFile & pathA(i) & "\"
						Next 
						
						'UPGRADE_WARNING: Couldn't resolve default property of object pathA(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object fileSave. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						fileSave = pathA(UBound(pathA))
						
						'MsgBox (fileSave)
						
						'UPGRADE_WARNING: Couldn't resolve default property of object fileSave. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object Options. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Options = commandOptions & " " & VB6.GetItemString(formListOpticalDisks, formListOpticalDisks.SelectedIndex) & " " & fileSave
						
						'MsgBox (LBound(pathA))
						'MsgBox (UBound(pathA))
						'MsgBox (folderFile)
						'MsgBox (Options)
						
						'UPGRADE_WARNING: Couldn't resolve default property of object folderFile. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object Options. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object commandPath. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object hwnd. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Call ShellExecute(hwnd, "open", commandPath, Options, folderFile, 1)
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object rMes. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						rMes = MsgBox("L'application CDIMAGE.EXE n'existe pas dans " & My.Application.Info.DirectoryPath, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Erreur")
					End If
					
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object rMes. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					rMes = MsgBox("Aucun label indiqué", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Erreur")
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object rMes. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				rMes = MsgBox("Aucun emplacement sélectionné", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Erreur")
			End If
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object rMes. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rMes = MsgBox("Aucun lecteur sélectionné", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Erreur")
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Event formFileISO9660.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formFileISO9660_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formFileISO9660.CheckedChanged
		If eventSender.Checked Then
			If (formFileISO9660.Checked = True) Then
				groupISO.Enabled = True
				groupJoliet.Enabled = False
				groupUDF.Enabled = False
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formFileJoliet.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formFileJoliet_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formFileJoliet.CheckedChanged
		If eventSender.Checked Then
			If (formFileJoliet.Checked = True) Then
				If (formJoliet_ISO.Checked = True) Then
					groupISO.Enabled = True
				Else
					groupISO.Enabled = False
				End If
				groupJoliet.Enabled = True
				groupUDF.Enabled = False
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formFileUDF.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formFileUDF_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formFileUDF.CheckedChanged
		If eventSender.Checked Then
			If (formFileUDF.Checked = True) Then
				If (formUDF_ISO.Checked = True) Then
					groupISO.Enabled = True
				Else
					groupISO.Enabled = False
				End If
				groupJoliet.Enabled = False
				groupUDF.Enabled = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formGen_DateCheck.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formGen_DateCheck_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formGen_DateCheck.CheckStateChanged
		If (formGen_DateCheck.CheckState = System.Windows.Forms.CheckState.Checked) Then
			formGen_Date.Enabled = True
		Else
			formGen_Date.Enabled = False
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formISO_DOS.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formISO_DOS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formISO_DOS.CheckedChanged
		If eventSender.Checked Then
			If (formISO_LongNT.Checked = True) Then
				formISO_Maj.Enabled = False
			Else
				formISO_Maj.Enabled = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formISO_Long.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formISO_Long_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formISO_Long.CheckedChanged
		If eventSender.Checked Then
			If (formISO_LongNT.Checked = True) Then
				formISO_Maj.Enabled = False
			Else
				formISO_Maj.Enabled = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formISO_LongNT.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formISO_LongNT_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formISO_LongNT.CheckedChanged
		If eventSender.Checked Then
			If (formISO_LongNT.Checked = True) Then
				formISO_Maj.Enabled = False
			Else
				formISO_Maj.Enabled = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formJoliet_ISO.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formJoliet_ISO_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formJoliet_ISO.CheckedChanged
		If eventSender.Checked Then
			If (formJoliet_ISO.Checked = True) Then
				groupISO.Enabled = True
			Else
				groupISO.Enabled = False
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formJoliet_Unicode.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formJoliet_Unicode_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formJoliet_Unicode.CheckedChanged
		If eventSender.Checked Then
			If (formJoliet_Unicode.Checked = True) Then
				groupISO.Enabled = False
			Else
				groupISO.Enabled = True
			End If
		End If
	End Sub
	
	Private Sub formLabel_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formLabel.Leave
		Dim t As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object t. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		t = UCase(formLabel.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object t. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		t = Replace(t, " ", "_")
		'UPGRADE_WARNING: Couldn't resolve default property of object t. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		formLabel.Text = t
	End Sub
	
	'UPGRADE_WARNING: Event formListOpticalDisks.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formListOpticalDisks_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formListOpticalDisks.SelectedIndexChanged
		
		Dim letter As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object letter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		letter = formListOpticalDisks.Text
		
		Dim volname As String ' receives volume name
		Dim sn As Integer ' receives serial number
		Dim snstr As String ' display form of serial number
		Dim maxcomplen As Integer ' receives maximum component length
		Dim sysflags As Integer ' receives file system flags
		Dim sysname As String ' receives the file system name
		Dim retval As Integer ' return value
		
		' Initialize string buffers.
		volname = Space(256)
		sysname = Space(256)
		
		' Get information about drive volume.
		'UPGRADE_WARNING: Couldn't resolve default property of object letter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		retval = GetVolumeInformation(letter, volname, Len(volname), sn, maxcomplen, sysflags, sysname, Len(sysname))
		
		If (retval = 1) Then
			' Remove the trailing nulls from the two strings.
			volname = VB.Left(volname, InStr(volname, vbNullChar) - 1)
			sysname = VB.Left(sysname, InStr(sysname, vbNullChar) - 1)
			
			' Format the serial number properly.
			snstr = Trim(Hex(sn))
			snstr = New String("0", 8 - Len(snstr)) & snstr
			snstr = VB.Left(snstr, 4) & "-" & VB.Right(snstr, 4)
			
			' Display the volume name, serial number, and file system name.
			'UPGRADE_WARNING: Couldn't resolve default property of object letter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			formInfos.Text = "Lecteur : " & letter & vbNewLine
			formInfos.Text = formInfos.Text & "Volume : " & volname & vbNewLine
			formInfos.Text = formInfos.Text & "Numéro de série : " & snstr & vbNewLine
			formInfos.Text = formInfos.Text & "Système de fichiers : " & sysname & vbNewLine
			
			formLabel.Text = UCase(volname)
			
		End If
	End Sub
	
	Private Sub formRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formRefresh.Click
		Dim i As Short
		
		Dim letters As Object
		'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object letters. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		letters = New Object(){"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
		
		formListOpticalDisks.Items.Clear()
		
		Dim existDisk As Object
		Dim letter As String
		Dim fso, d As Object
		For i = 0 To 25 Step 1
			
			'UPGRADE_WARNING: Couldn't resolve default property of object letters(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			letter = letters(i) & ":\"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object existDisk. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			existDisk = isExist(letter)
			
			
			'UPGRADE_WARNING: Couldn't resolve default property of object existDisk. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If (existDisk = True) Then
				
				
				fso = CreateObject("Scripting.FileSystemObject")
				'UPGRADE_WARNING: Couldn't resolve default property of object fso.GetAbsolutePathName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object fso.GetDriveName. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object fso.GetDrive. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				d = fso.GetDrive(fso.GetDriveName(fso.GetAbsolutePathName(letter)))
				
				'UPGRADE_WARNING: Couldn't resolve default property of object d.DriveType. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If (d.DriveType = 4) Then
					formListOpticalDisks.Items.Add((letter))
				End If
				
			End If
		Next 
		
		If (formListOpticalDisks.Items.Count > 0) Then
			formListOpticalDisks.SelectedIndex = 0
		End If
	End Sub
	
	Private Sub formSaveButton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formSaveButton.Click
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		CommonDialog1Save.Filter = "Image ISO (*.iso)|*.iso|Fichier image (*.img)|*.img"
		CommonDialog1Save.DefaultExt = "iso"
		CommonDialog1Save.Title = "Enregistrer sous..."
		CommonDialog1Save.ShowDialog()
		
		Dim f As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = CommonDialog1Save.FileName
		
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		formSaveAs.Text = f
		
	End Sub
	
	'UPGRADE_WARNING: Event formUDF_ISO.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formUDF_ISO_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formUDF_ISO.CheckedChanged
		If eventSender.Checked Then
			If (formUDF_ISO.Checked = True) Then
				formUDF_Input.Enabled = False
				formUDF_FID.Enabled = False
				formUDF_Clairseme.Enabled = False
				groupISO.Enabled = True
			Else
				formUDF_Input.Enabled = True
				formUDF_FID.Enabled = True
				formUDF_Clairseme.Enabled = True
				groupISO.Enabled = False
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event formUDF_UDF.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub formUDF_UDF_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles formUDF_UDF.CheckedChanged
		If eventSender.Checked Then
			If (formUDF_UDF.Checked = True) Then
				formUDF_Input.Enabled = True
				formUDF_FID.Enabled = True
				formUDF_Clairseme.Enabled = True
				groupISO.Enabled = False
			Else
				formUDF_Input.Enabled = False
				formUDF_FID.Enabled = False
				formUDF_Clairseme.Enabled = False
				groupISO.Enabled = True
			End If
		End If
	End Sub
End Class