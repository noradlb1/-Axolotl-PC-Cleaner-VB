Imports System
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

Namespace AXOLOTL_PC_CLEANER
	Partial Public Class File_Explorer
		Inherits Form

		#Region "File Loading"
		Public Shared Viewing As String

		Private Sub Load_Files(ByVal Location As String, ByVal Name As String, ByVal folders As Boolean)
			Lbl1.Text = "Currently explorering: " & Name

			Try
				Dim files() As String = Directory.GetFiles(Location)
				Viewer.SmallImageList = Me.images

				For Each file As String In files
					Dim fileName As String = Path.GetFullPath(file)
					Dim fileSize As String = Calculations.Size.ConvertToString(file.Length)

					Dim row() As String = { fileName, fileSize }
					Dim listViewItem = New ListViewItem(row)
					listViewItem.ImageIndex = 0
					Viewer.Items.Add(listViewItem)
				Next file
			Catch
			End Try

			If folders Then
				Try
					Dim di As System.IO.DirectoryInfo = New DirectoryInfo(Location)

					For Each dir As DirectoryInfo In di.GetDirectories()
						Dim row() As String = { dir.FullName, Calculations.Size.ConvertToString(Calculations.Size.DirectorySize(dir, True)) }

						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 1
						Viewer.Items.Add(listViewItem)
					Next dir
				Catch
				End Try
			End If
		End Sub

		Private Sub Load_Single(ByVal Location As String, ByVal Name As String)
			Lbl1.Text = "Currently explorering: " & Name

			If File.Exists(Location) Then
				Dim file As String = Location

				Dim row() As String = { Location, Calculations.Size.ConvertToString(file.Length) }

				Dim listViewItem = New ListViewItem(row)
				listViewItem.ImageIndex = 0
				Viewer.Items.Add(listViewItem)
			End If
		End Sub

		Private Sub Load_Other(ByVal Location As String, ByVal Name As String, ByVal Exetension As String)
			Lbl1.Text = "Currently explorering: " & Name

			Viewer.SmallImageList = Me.images

			Try
				For Each file As String In Directory.GetFiles(Location, "*." & Exetension).Where(Function(item) item.EndsWith("." & Exetension))
					Dim fileName As String = Path.GetFullPath(file)
					Dim fileSize As String = Calculations.Size.ConvertToString(file.Length)

					Dim row() As String = { fileName, fileSize }
					Dim listViewItem = New ListViewItem(row)
					listViewItem.ImageIndex = 0
					Viewer.Items.Add(listViewItem)
				Next file
			Catch
			End Try
		End Sub
		#End Region

		Public Sub New()
			InitializeComponent()

			Me.ActiveControl = Lbl1
		End Sub

		Private Sub File_Explorer_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
'			#Region "Windows Explorer"
			If Viewing = "Recent Documents" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Recent_Documents, "Recent Documents", True)
			ElseIf Viewing = "Thumnail Cache" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Thumnail_Cache, "Thumbnail Cache", False)
			ElseIf Viewing = "Mini Dumps" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Mini_Dumps, "Mini Dumps", False)
			ElseIf Viewing = "WTemporary Files" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Win_Temp_Files, " Windows Temporary Files", True)
'			#End Region
'			#Region "System"
			ElseIf Viewing = "Recycle Bin" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Recyle_Bin, "Recycle Bin", True)
			ElseIf Viewing = "Temporary Files" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Temp_Files, "Temporary Files", True)
			ElseIf Viewing = "Memory Dumps" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Memory_Dumps, "Memory Dumps", True)
'			#Region "Windows Log Files"
			ElseIf Viewing = "Windows Log Files" Then
				Viewer.Items.Clear()
				Load_Other(Helper.Locations.WinLogs, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs1, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs2, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs3, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs4, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs5, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs6, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs7, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs8, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs9, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs10, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs11, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs12, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs13, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs14, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs15, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs16, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs17, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs18, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs19, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs20, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs21, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs22, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs23, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs24, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs25, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs26, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs27, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs28, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs29, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs30, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs31, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs32, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs33, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs34, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs35, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs36, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs37, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs38, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs39, "Windows Log Files", "log")
				Load_Other(Helper.Locations.WinLogs40, "Windows Log Files", "log")
'			#End Region
			ElseIf Viewing = "Event Trace Logs" Then
				Viewer.Items.Clear()
				Load_Other(Helper.Locations.WinLogs1, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs2, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs3, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs4, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs5, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs6, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs7, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs8, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs9, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs10, "Event Trace Logs", "etl")
				Load_Other(Helper.Locations.WinLogs11, "Event Trace Logs", "etl")
			ElseIf Viewing = "Error Reporting" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Error_Reports, "Error Reportings", False)
				Load_Files(Helper.Locations.Error_Reports & "\ReportArchive", "Error Reportings", False)
				Load_Files(Helper.Locations.Error_Reports & "\ReportQueue", "Error Reportings", False)
				Load_Files(Helper.Locations.Error_Reports & "\Temp", "Error Reportings", False)
			ElseIf Viewing = "Driver Installation Log Files" Then
				Viewer.Items.Clear()
				Load_Single(Helper.Locations.Error_Reports & "\setupapi.dev.log", "Driver Installation Log Files")
			ElseIf Viewing = "Windows Delivery Optimization Files" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Delivery_Optimization & "\Cache", "Windows Delivery Optimization Files", False)
				Load_Other(Helper.Locations.Delivery_Optimization & "\Logs", "Windows Delivery Optimization Files", "log")
			ElseIf Viewing = "Network Data Usage" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Network_Data, "Windows Delivery Optimization Files", False)
'			#End Region
'			#Region "Advanced"
			ElseIf Viewing = "Prefetch Data" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Prefetch, "Prefetch Data", True)
			ElseIf Viewing = "Store Install Service Cache" Then
				Viewer.Items.Clear()
				Load_Other(Helper.Locations.Store_Install_Service, "Store Install Service Cache", "catalogItem")
			ElseIf Viewing = "QT Framework" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.QtFramework, "QT Framework", True)
			ElseIf Viewing = "Power Efficiency Diagnostics" Then
				Viewer.Items.Clear()
				Load_Other(Helper.Locations.Power_Efficiency, "Power Efficiency Diagnostics", "xml")
			ElseIf Viewing = "Notifications" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Notifications, "Notifications", True)
			ElseIf Viewing = "MS Search" Then
				Viewer.Items.Clear()
				Load_Other(Helper.Locations.MS_Search, "MS Search", "edb")
				Load_Other(Helper.Locations.MS_Search2, "MS Search", "crwl")
				Load_Files(Helper.Locations.MS_Search3, "MS Search", False)
				Load_Files(Helper.Locations.MS_Search4, "MS Search", True)
				Load_Files(Helper.Locations.MS_Search5, "MS Search", True)
			ElseIf Viewing = "Jump List" Then
				Viewer.Items.Clear()
				Load_Other(Helper.Locations.Jump_List, "Jump List", "dat")
'			#End Region
'			#Region "Applications"
			ElseIf Viewing = "Windows Defender" Then
				Viewer.Items.Clear()
				Load_Files(Helper.Locations.Win_Defender, "Windows Defender", False)
				Load_Other(Helper.Locations.Win_Defender2, "Windows Defender", "log")
				Load_Files(Helper.Locations.Win_Defender3, "Windows Defender", True)
				Load_Files(Helper.Locations.Win_Defender4, "Windows Defender", False)
				Load_Files(Helper.Locations.Win_Defender5, "Windows Defender", False)
				Load_Files(Helper.Locations.Win_Defender6, "Windows Defender", False)
			ElseIf Viewing = "Origin Installers" Then
				Load_Files(Helper.Locations.Origin_Installers, "Origin Installers", True)
			ElseIf Viewing = "Visual Studio Installation" Then
				Load_Files(Helper.Locations.Visual_Studio, "Visual Studio Installation", True)
			ElseIf Viewing = "One Drive" Then
				Load_Files(Helper.Locations.One_Drive, "One Drive", False)
				Load_Other(Helper.Locations.One_Drive2, "One Drive", "log")
				Load_Files(Helper.Locations.One_Drive3, "One Drive", True)
			ElseIf Viewing = "Easy Anti-Cheat" Then
				Load_Other(Helper.Locations.Easy_AntiCheat, "Easy Anti-Cheat", "log")
			ElseIf Viewing = "Battlenet" Then
				Load_Files(Helper.Locations.Battlenet, "Battlenet", True)
				Load_Files(Helper.Locations.Battlenet2, "Battlenet", False)
				Load_Files(Helper.Locations.Battlenet3, "Battlenet", False)
				Load_Files(Helper.Locations.Battlenet4, "Battlenet", False)
				Load_Files(Helper.Locations.Battlenet5, "Battlenet", True)
			ElseIf Viewing = "Ccleaner" Then
				Load_Other(Helper.Locations.Ccleaner, "Ccleaner", "log")
			ElseIf Viewing = "Steam" Then
				Load_Other(Helper.Locations.Steam, "Steam", "log")
				Load_Files(Helper.Locations.Steam2, "Steam", False)
				Load_Files(Helper.Locations.Steam3, "Steam", False)
'			#End Region
'			#Region "Windows"
			ElseIf Viewing = "DirectX Shader Cache" Then
				Load_Files(Helper.Locations.DirectX, "DirectX Shader Cache", True)
				Load_Files(Helper.Locations.DirectX2, "DirectX Shader Cache", True)
			ElseIf Viewing = "Update Files" Then
				Load_Files(Helper.Locations.Windows_Update, "Update Files", True)
			ElseIf Viewing = "Font Cache" Then
				Load_Single(Helper.Locations.Font_Cache, "Font Cache")
			ElseIf Viewing = "Debug Files" Then
				Load_Other(Helper.Locations.Windows_Debug, "Debug Files", "log")
			ElseIf Viewing = "Cache Files" Then
				Load_Files(Helper.Locations.Windows_Cache, "Update Files", True)
				Load_Files(Helper.Locations.Windows_Cache2, "Update Files", True)
				Load_Files(Helper.Locations.Windows_Cache3, "Update Files", True)
				Load_Files(Helper.Locations.Windows_Cache4, "Update Files", True)
				Load_Files(Helper.Locations.Windows_Cache5, "Update Files", True)
			ElseIf Viewing = "Installers" Then
				Load_Files(Helper.Locations.Windows_Installer, "Installers", True)
			ElseIf Viewing = "Experience Index" Then
				Load_Other(Helper.Locations.Windows_Experience, "Experience Index", "log")
				Load_Files(Helper.Locations.Windows_Experience2, "Experience Index", True)
			ElseIf Viewing = "Auto/Video Quality Experience" Then
				Load_Other(Helper.Locations.Windows_Auto_Video_Experience, "Experience Index", "dat")
			ElseIf Viewing = "Internet Explorer" Then
				Load_Files(Helper.Locations.Windows_Internet_Cache, "Internet Explorer Cache", True)
'			#End Region
'			#Region "Edge Chromium"
			ElseIf Viewing = "Edge Cache" Then
				Load_Files(Helper.Locations.Edge_Cache, "Chromium Edge Cache", False)
				Load_Files(Helper.Locations.Edge_Cache2, "Chromium Edge Cache", False)
				Load_Files(Helper.Locations.Edge_Cache3, "Chromium Edge Cache", False)
				Load_Files(Helper.Locations.Edge_Cache4, "Chromium Edge Cache", False)
				Load_Files(Helper.Locations.Edge_Cache5, "Chromium Edge Cache", True)
				Load_Files(Helper.Locations.Edge_Cache6, "Chromium Edge Cache", False)
				Load_Files(Helper.Locations.Edge_Cache7, "Chromium Edge Cache", False)
				Load_Files(Helper.Locations.Edge_Cache8, "Chromium Edge Cache", False)
				Load_Files(Helper.Locations.Edge_Cache9, "Chromium Edge Cache", False)
				Load_Files(Helper.Locations.Edge_Cache10, "Chromium Edge Cache", False)

				Load_Single(Helper.Locations.Edge_Cache11, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache12, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache13, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache14, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache15, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache16, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache17, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache18, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache19, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache20, "Chromium Edge Cache")
				Load_Single(Helper.Locations.Edge_Cache21, "Chromium Edge Cache")
			ElseIf Viewing = "Edge Cookies" Then
				Load_Files(Helper.Locations.Edge_Cookies, "Chromium Edge History", True)
				Load_Single(Helper.Locations.Edge_Cookies, "Chromium Edge History")
			ElseIf Viewing = "Edge History" Then
				Load_Single(Helper.Locations.Edge_History, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History2, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History3, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History4, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History5, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History6, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History7, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History8, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History9, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History10, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History11, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History12, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History13, "Chromium Edge Cookies")
				Load_Single(Helper.Locations.Edge_History14, "Chromium Edge Cookies")
			ElseIf Viewing = "Edge Session" Then
				Load_Files(Helper.Locations.Edge_Session, "Chromium Edge Session Data", False)
				Load_Files(Helper.Locations.Edge_Session2, "Chromium Edge Session Data", False)
				Load_Files(Helper.Locations.Edge_Session3, "Chromium Edge Session Data", False)
			ElseIf Viewing = "Edge Passwords" Then
				Load_Single(Helper.Locations.Edge_Passwords, "Chromium Edge Passwords")
			ElseIf Viewing = "Edge Metrics" Then
				Load_Other(Helper.Locations.Edge_Metrics, "Chromium Edge Passwords", "pma")
				Load_Other(Helper.Locations.Edge_Metrics2, "Chromium Edge Passwords", "pma")
'			#End Region
'			#Region "Google Chrome"
			ElseIf Viewing = "Chrome Cache" Then
				Load_Files(Helper.Locations.Chrome_Cache, "Google Chrome Cache", False)
				Load_Files(Helper.Locations.Chrome_Cache2, "Google Chrome Cache", False)
				Load_Files(Helper.Locations.Chrome_Cache3, "Google Chrome Cache", False)
				Load_Files(Helper.Locations.Chrome_Cache4, "Google Chrome Cache", False)
				Load_Files(Helper.Locations.Chrome_Cache5, "Google Chrome Cache", True)
				Load_Files(Helper.Locations.Chrome_Cache6, "Google Chrome Cache", False)
				Load_Files(Helper.Locations.Chrome_Cache7, "Google Chrome Cache", False)
				Load_Files(Helper.Locations.Chrome_Cache8, "Google Chrome Cache", True)
				Load_Files(Helper.Locations.Chrome_Cache9, "Google Chrome Cache", False)
				Load_Files(Helper.Locations.Chrome_Cache10, "Google Chrome Cache", False)
				Load_Files(Helper.Locations.Chrome_Cache11, "Google Chrome Cache", False)
				Load_Files(Helper.Locations.Chrome_Cache12, "Google Chrome Cache", False)

				Load_Single(Helper.Locations.Chrome_Cache13, "Google Chrome Cache")
				Load_Single(Helper.Locations.Chrome_Cache14, "Google Chrome Cache")
				Load_Single(Helper.Locations.Chrome_Cache15, "Google Chrome Cache")
				Load_Single(Helper.Locations.Chrome_Cache16, "Google Chrome Cache")
				Load_Single(Helper.Locations.Chrome_Cache17, "Google Chrome Cache")
				Load_Single(Helper.Locations.Chrome_Cache18, "Google Chrome Cache")
				Load_Single(Helper.Locations.Chrome_Cache19, "Google Chrome Cache")
				Load_Single(Helper.Locations.Chrome_Cache20, "Google Chrome Cache")
				Load_Single(Helper.Locations.Chrome_Cache21, "Google Chrome Cache")
				Load_Single(Helper.Locations.Chrome_Cache22, "Google Chrome Cache")
			ElseIf Viewing = "Chrome History" Then
				Load_Single(Helper.Locations.Chrome_History, "Google Chrome History")
				Load_Single(Helper.Locations.Chrome_History2, "Google Chrome History")
				Load_Single(Helper.Locations.Chrome_History3, "Google Chrome History")
				Load_Single(Helper.Locations.Chrome_History4, "Google Chrome History")
				Load_Single(Helper.Locations.Chrome_History5, "Google Chrome History")
				Load_Single(Helper.Locations.Chrome_History6, "Google Chrome History")
				Load_Single(Helper.Locations.Chrome_History7, "Google Chrome History")
				Load_Single(Helper.Locations.Chrome_History8, "Google Chrome History")
				Load_Files(Helper.Locations.Chrome_History9, "Google Chrome History", False)
			ElseIf Viewing = "Chrome Cookies" Then
				Load_Files(Helper.Locations.Chrome_Cookies, "Google Chrome Cookies", False)
				Load_Single(Helper.Locations.Chrome_Cookies2, "Google Chrome Cookies")
			ElseIf Viewing = "Chrome Download History" Then
				Load_Single(Helper.Locations.Chrome_Download, "Google Chrome Download History")
			ElseIf Viewing = "Chrome Metrics" Then
				Load_Other(Helper.Locations.Chrome_Metrics, "Google Chrome Metrics Temp Files", "pma")
			ElseIf Viewing = "Chrome Session" Then
				Load_Files(Helper.Locations.Chrome_Session, "Google Chrome Session Data", False)
				Load_Files(Helper.Locations.Chrome_Session2, "Google Chrome Session Data", False)
				Load_Files(Helper.Locations.Chrome_Session3, "Google Chrome Session Data", False)
			ElseIf Viewing = "Chrome Passwords" Then
				Load_Single(Helper.Locations.Chrome_Passwords, "Google Chrome Passwords")
'			#End Region
'			#Region "Firefox"
			ElseIf Viewing = "Firefox Cache" Then
				Load_Files(Helper.Locations.Firefox_Cache, "Mozilla Firefox Cache", False)
				Load_Files(Helper.Locations.Firefox_Cache2, "Mozilla Firefox Cache", False)
				Load_Files(Helper.Locations.Firefox_Cache3, "Mozilla Firefox Cache", False)
				Load_Files(Helper.Locations.Firefox_Cache4, "Mozilla Firefox Cache", False)
				Load_Files(Helper.Locations.Firefox_Cache5, "Mozilla Firefox Cache", False)
			ElseIf Viewing = "Firefox History" Then
				Load_Files(Helper.Locations.Firefox_History, "Mozilla Firefox History", False)
			ElseIf Viewing = "Firefox Cookies" Then
				Load_Files(Helper.Locations.Firefox_Cookies, "Mozilla Firefox Cookies", True)
			ElseIf Viewing = "Firefox Session" Then
				Load_Files(Helper.Locations.Firefox_Session, "Mozilla Firefox Session Data", False)
				Load_Single(Helper.Locations.Firefox_Session2, "Mozilla Firefox Session Data")
			ElseIf Viewing = "Firefox Preferences" Then
				Load_Single(Helper.Locations.Firefox_Site_Pref, "Mozilla Firefox Site Preferences")
			ElseIf Viewing = "Firefox Form" Then
				Load_Single(Helper.Locations.Firefox_Saved_Form, "Mozilla Firefox Saved Form Information")
			ElseIf Viewing = "Firefox Passwords" Then
				Load_Single(Helper.Locations.Firefox_Login, "Mozilla Firefox Saved Passwords")
				Load_Single(Helper.Locations.Firefox_Login2, "Mozilla Firefox Saved Passwords")
			End If
'			#End Region
		End Sub

		Private Sub Viewer_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles Viewer.DoubleClick
			If Viewer.SelectedIndices.Count <= 0 Then
				Return
			End If

			Dim intselectedindex As Integer = Viewer.SelectedIndices(0)

			If intselectedindex >= 0 Then
'INSTANT VB NOTE: The variable text was renamed since Visual Basic does not handle local variables named the same as class members well:
				Dim text_Renamed As String = Viewer.Items(intselectedindex).Text

				Try
					Process.Start(text_Renamed)
				Catch ex As Exception
					MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub

		Private Sub deleteFileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deleteFileToolStripMenuItem.Click
			If Viewer.SelectedIndices.Count <= 0 Then
				Return
			End If

			Dim intselectedindex As Integer = Viewer.SelectedIndices(0)

			If intselectedindex >= 0 Then
'INSTANT VB NOTE: The variable text was renamed since Visual Basic does not handle local variables named the same as class members well:
				Dim text_Renamed As String = Viewer.Items(intselectedindex).Text

				Try
					File.Delete(text_Renamed)
				Catch ex As Exception
					MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub

		Public selected As String

		Private Sub Viewer_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Viewer.SelectedIndexChanged
			If Viewer.SelectedIndices.Count <= 0 Then
				Return
			End If

			Dim intselectedindex As Integer = Viewer.SelectedIndices(0)

			If intselectedindex >= 0 Then
				selected = Viewer.Items(intselectedindex).Text
			End If
		End Sub
	End Class
End Namespace
