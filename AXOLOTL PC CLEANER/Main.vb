Imports System
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Collections.Generic
Imports AXOLOTL_PC_CLEANER.Helper
Imports AXOLOTL_PC_CLEANER.Remover
Imports AXOLOTL_PC_CLEANER.Calculations
Imports AXOLOTL_PC_CLEANER.Calculations.Size
Imports System.IO
Imports System.Net
Imports DevComponents.DotNetBar
Imports Guna.UI2
Imports Guna.UI2.WinForms.Suite.Descriptions.Properties

Namespace AXOLOTL_PC_CLEANER
	Partial Public Class Main
		Inherits Form

#Region "Main"
		Public Sub New()
			InitializeComponent()

			Load_Settings()

			Utils.ReturnSystem()

			If My.Settings.Default.Startup = True Then
				Helper.Utils.SetStartup(True)
			End If

			If My.Settings.Default.Minimized = True Then
				Visible = False
				ShowInTaskbar = False
				Opacity = 0
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Line1.Text = My.Settings.Default.Windows.ToUpper() & " (" & Environment.UserName.ToUpper() & ")"

			Line2.Text = My.Settings.Default.Cpu.ToUpper() & ", " & My.Settings.Default.Ram & "GB RAM, " & My.Settings.Default.Gpu.ToUpper()

			Me.ActiveControl = TitleLogo

			If My.Settings.Default.ExpandAll Then
				Options.ExpandAll()
			Else
				Options.CollapseAll()
			End If

			If Not My.Settings.Default.ShowAdvanced Then
				node16.Visible = False
				node17.Visible = False
				node18.Visible = False
				node19.Visible = False
				node20.Visible = False
				node21.Visible = False
				node22.Visible = False
				node23.Visible = False
				node24.Visible = False

				node16.Checked = False
				node17.Checked = False
				node18.Checked = False
				node19.Checked = False
				node20.Checked = False
				node21.Checked = False
				node22.Checked = False
				node23.Checked = False
				node24.Checked = False
			End If

			If Not My.Settings.Default.ShowApps Then
				node25.Visible = False
				node26.Visible = False
				node27.Visible = False
				node28.Visible = False
				node29.Visible = False
				node30.Visible = False
				node31.Visible = False
				node32.Visible = False
				node33.Visible = False

				node25.Checked = False
				node26.Checked = False
				node27.Checked = False
				node28.Checked = False
				node29.Checked = False
				node30.Checked = False
				node31.Checked = False
				node32.Checked = False
				node33.Checked = False
			End If

			If Not My.Settings.Default.ShowWindows Then
				node34.Visible = False
				node35.Visible = False
				node36.Visible = False
				node37.Visible = False
				node38.Visible = False
				node39.Visible = False
				node40.Visible = False
				node41.Visible = False
				node42.Visible = False
				node66.Visible = False

				node34.Checked = False
				node35.Checked = False
				node36.Checked = False
				node37.Checked = False
				node38.Checked = False
				node39.Checked = False
				node40.Checked = False
				node41.Checked = False
				node42.Checked = False
				node66.Checked = False
			End If

			If Not My.Settings.Default.ShowEdge Then
				node43.Visible = False
				node44.Visible = False
				node45.Visible = False
				node46.Visible = False
				node47.Visible = False
				node48.Visible = False
				node49.Visible = False

				node43.Checked = False
				node44.Checked = False
				node45.Checked = False
				node46.Checked = False
				node47.Checked = False
				node48.Checked = False
				node49.Checked = False
			End If

			If Not My.Settings.Default.ShowChrome Then
				node50.Visible = False
				node51.Visible = False
				node52.Visible = False
				node53.Visible = False
				node54.Visible = False
				node55.Visible = False
				node56.Visible = False
				node57.Visible = False

				node50.Checked = False
				node51.Checked = False
				node52.Checked = False
				node53.Checked = False
				node54.Checked = False
				node55.Checked = False
				node56.Checked = False
				node57.Checked = False
			End If

			If Not My.Settings.Default.ShowFirefox Then
				node58.Visible = False
				node59.Visible = False
				node60.Visible = False
				node61.Visible = False
				node62.Visible = False
				node63.Visible = False
				node64.Visible = False
				node65.Visible = False

				node58.Checked = False
				node59.Checked = False
				node60.Checked = False
				node61.Checked = False
				node62.Checked = False
				node63.Checked = False
				node64.Checked = False
				node65.Checked = False
			End If

			If My.Settings.Default.Sid = "" Then
				Utils.UsernameSid()
			End If
		End Sub

		Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			Save_Settings()
		End Sub
#End Region

#Region "Settings"
		Private Sub Load_Settings()
			node59.Checked = My.Settings.Default.FirefoxCache
			node60.Checked = My.Settings.Default.FirefoxHistory
			node61.Checked = My.Settings.Default.FirefoxCookies
			node62.Checked = My.Settings.Default.FirefoxSession
			node63.Checked = My.Settings.Default.FirefoxSite
			node64.Checked = My.Settings.Default.FirefoxForm
			node65.Checked = My.Settings.Default.FirefoxPasswords

			node51.Checked = My.Settings.Default.ChromeCache
			node52.Checked = My.Settings.Default.ChromeHistroy
			node53.Checked = My.Settings.Default.ChromeCookies
			node54.Checked = My.Settings.Default.ChromeDownloadHistory
			node55.Checked = My.Settings.Default.ChromeMetrics
			node56.Checked = My.Settings.Default.ChromeSession
			node57.Checked = My.Settings.Default.ChromePasswords

			node44.Checked = My.Settings.Default.EdgeCache
			node45.Checked = My.Settings.Default.EdgeCookies
			node46.Checked = My.Settings.Default.EdgeHistory
			node47.Checked = My.Settings.Default.EdgeSession
			node48.Checked = My.Settings.Default.EdgePasswords
			node49.Checked = My.Settings.Default.EdgeMetrics

			node2.Checked = My.Settings.Default.RecentDocuments
			node3.Checked = My.Settings.Default.ThumbnailCache
			node4.Checked = My.Settings.Default.MiniDumps
			node15.Checked = My.Settings.Default.TemporaryFiles

			node6.Checked = My.Settings.Default.RecycleBin
			node7.Checked = My.Settings.Default.TempFiles
			node8.Checked = My.Settings.Default.MemoryDumps
			node9.Checked = My.Settings.Default.WindowsLogs
			node10.Checked = My.Settings.Default.EventTraceLogs
			node11.Checked = My.Settings.Default.ErrorReporting
			node12.Checked = My.Settings.Default.DriverInstallation
			node13.Checked = My.Settings.Default.DeliveryOpti
			node14.Checked = My.Settings.Default.NetworkData

			node17.Checked = My.Settings.Default.Prefetch
			node18.Checked = My.Settings.Default.StoreInstallServiceCache
			node19.Checked = My.Settings.Default.QtFramework
			node20.Checked = My.Settings.Default.PowerEfficencyDiagnostics
			node21.Checked = My.Settings.Default.Notfications
			node22.Checked = My.Settings.Default.MsSearch
			node23.Checked = My.Settings.Default.JumpList
			node24.Checked = My.Settings.Default.FontCache

			node26.Checked = My.Settings.Default.WinDefender
			node27.Checked = My.Settings.Default.OriginInstaller
			node28.Checked = My.Settings.Default.VisualStudio
			node29.Checked = My.Settings.Default.OneDrive
			node30.Checked = My.Settings.Default.EasyAntiCheat
			node31.Checked = My.Settings.Default.Battlenet
			node32.Checked = My.Settings.Default.Ccleaner
			node33.Checked = My.Settings.Default.Steam

			node35.Checked = My.Settings.Default.DirectX
			node36.Checked = My.Settings.Default.WinUpdateFiles
			node37.Checked = My.Settings.Default.WinFontCache
			node38.Checked = My.Settings.Default.WinDebug
			node39.Checked = My.Settings.Default.WinCache
			node40.Checked = My.Settings.Default.WinInstaller
			node41.Checked = My.Settings.Default.WinExpIndex
			node42.Checked = My.Settings.Default.WinAutoVideo

			node66.Checked = My.Settings.Default.InternetExplorer
		End Sub

		Private Sub Save_Settings()
			My.Settings.Default.FirefoxCache = node59.Checked
			My.Settings.Default.FirefoxHistory = node60.Checked
			My.Settings.Default.FirefoxCookies = node61.Checked
			My.Settings.Default.FirefoxSession = node62.Checked
			My.Settings.Default.FirefoxSite = node63.Checked
			My.Settings.Default.FirefoxForm = node64.Checked
			My.Settings.Default.FirefoxPasswords = node65.Checked

			My.Settings.Default.ChromeCache = node51.Checked
			My.Settings.Default.ChromeHistroy = node52.Checked
			My.Settings.Default.ChromeCookies = node53.Checked
			My.Settings.Default.ChromeDownloadHistory = node54.Checked
			My.Settings.Default.ChromeMetrics = node55.Checked
			My.Settings.Default.ChromeSession = node56.Checked
			My.Settings.Default.ChromePasswords = node57.Checked

			My.Settings.Default.EdgeCache = node44.Checked
			My.Settings.Default.EdgeCookies = node45.Checked
			My.Settings.Default.EdgeHistory = node46.Checked
			My.Settings.Default.EdgeSession = node47.Checked
			My.Settings.Default.EdgePasswords = node48.Checked
			My.Settings.Default.EdgeMetrics = node49.Checked

			My.Settings.Default.RecentDocuments = node2.Checked
			My.Settings.Default.ThumbnailCache = node3.Checked
			My.Settings.Default.MiniDumps = node4.Checked
			My.Settings.Default.TemporaryFiles = node15.Checked

			My.Settings.Default.RecycleBin = node6.Checked
			My.Settings.Default.TempFiles = node7.Checked
			My.Settings.Default.MemoryDumps = node8.Checked
			My.Settings.Default.WindowsLogs = node9.Checked
			My.Settings.Default.EventTraceLogs = node10.Checked
			My.Settings.Default.ErrorReporting = node11.Checked
			My.Settings.Default.DriverInstallation = node12.Checked
			My.Settings.Default.DeliveryOpti = node13.Checked
			My.Settings.Default.NetworkData = node14.Checked

			My.Settings.Default.Prefetch = node17.Checked
			My.Settings.Default.StoreInstallServiceCache = node18.Checked
			My.Settings.Default.QtFramework = node19.Checked
			My.Settings.Default.PowerEfficencyDiagnostics = node20.Checked
			My.Settings.Default.Notfications = node21.Checked
			My.Settings.Default.MsSearch = node22.Checked
			My.Settings.Default.JumpList = node23.Checked
			My.Settings.Default.FontCache = node24.Checked

			My.Settings.Default.WinDefender = node26.Checked
			My.Settings.Default.OriginInstaller = node27.Checked
			My.Settings.Default.VisualStudio = node28.Checked
			My.Settings.Default.OneDrive = node29.Checked
			My.Settings.Default.EasyAntiCheat = node30.Checked
			My.Settings.Default.Battlenet = node31.Checked
			My.Settings.Default.Ccleaner = node32.Checked
			My.Settings.Default.Steam = node33.Checked

			My.Settings.Default.DirectX = node35.Checked
			My.Settings.Default.WinUpdateFiles = node36.Checked
			My.Settings.Default.WinFontCache = node37.Checked
			My.Settings.Default.WinDebug = node38.Checked
			My.Settings.Default.WinCache = node39.Checked
			My.Settings.Default.WinInstaller = node40.Checked
			My.Settings.Default.WinExpIndex = node41.Checked
			My.Settings.Default.WinAutoVideo = node42.Checked

			My.Settings.Default.InternetExplorer = node66.Checked

			My.Settings.Default.Save()
		End Sub
#End Region

#Region "Listview"
		Private Sub List_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles List.DoubleClick
			If List.SelectedIndices.Count <= 0 Then
				Return
			End If

			Dim intselectedindex As Integer = List.SelectedIndices(0)

			If intselectedindex >= 0 Then
				'INSTANT VB NOTE: The variable text was renamed since Visual Basic does not handle local variables named the same as class members well:
				Dim text_Renamed As String = List.Items(intselectedindex).Text

				'				#Region "Windows Explorer"
				If text_Renamed = " Windows Explorer - Recent Documents" Then
					File_Explorer.Viewing = "Recent Documents"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows Explorer - Thumnail Cache" Then
					File_Explorer.Viewing = "Thumnail Cache"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows Explorer - Mini Dumps" Then
					File_Explorer.Viewing = "Mini Dumps"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows Explorer - Temporary Files" Then
					File_Explorer.Viewing = "WTemporary Files"

					Dim file_ As New File_Explorer()
					file_.Show()
					'				#End Region
					'				#Region "System"
				ElseIf text_Renamed = " System - Recycle Bin" Then
					File_Explorer.Viewing = "Recycle Bin"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " System - Temporary Files" Then
					File_Explorer.Viewing = "Temporary Files"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " System - Memory Dumps" Then
					File_Explorer.Viewing = "Memory Dumps"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " System - Windows Log Files" Then
					File_Explorer.Viewing = "Windows Log Files"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " System - Event Trace Logs" Then
					File_Explorer.Viewing = "Event Trace Logs"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " System - Error Reporting" Then
					File_Explorer.Viewing = "Error Reporting"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " System - Driver Installation Log Files" Then
					File_Explorer.Viewing = "Driver Installation Log Files"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " System - Windows Delivery Optimization Files" Then
					File_Explorer.Viewing = "Windows Delivery Optimization Files"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " System - Network Data Usage" Then
					File_Explorer.Viewing = "Network Data Usage"

					Dim file_ As New File_Explorer()
					file_.Show()
					'				#End Region
					'				#Region "Advanced"
				ElseIf text_Renamed = " Advanced - Prefetch Data" Then
					File_Explorer.Viewing = "Prefetch Data"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Advanced - Store Install Service Cache" Then
					File_Explorer.Viewing = "Store Install Service Cache"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Advanced - QT Framework" Then
					File_Explorer.Viewing = "QT Framework"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Advanced - Power Efficiency Diagnostics" Then
					File_Explorer.Viewing = "Power Efficiency Diagnostics"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Advanced - Notifications" Then
					File_Explorer.Viewing = "Notifications"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Advanced - MS Search" Then
					File_Explorer.Viewing = "MS Search"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Advanced - Jump List" Then
					File_Explorer.Viewing = "Jump List"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Advanced - Font Cache" Then
					File_Explorer.Viewing = "Font Cache"

					Dim file_ As New File_Explorer()
					file_.Show()
					'				#End Region
					'				#Region "Applications"
				ElseIf text_Renamed = " Applications - Windows Defender" Then
					File_Explorer.Viewing = "Windows Defender"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Applications - Origin Installers" Then
					File_Explorer.Viewing = "Origin Installers"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Applications - Visual Studio Installation" Then
					File_Explorer.Viewing = "Visual Studio Installation"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Applications - One Drive" Then
					File_Explorer.Viewing = "One Drive"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Applications - Easy Anti-Cheat" Then
					File_Explorer.Viewing = "Easy Anti-Cheat"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Applications - Battlenet" Then
					File_Explorer.Viewing = "Battlenet"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Applications - Ccleaner" Then
					File_Explorer.Viewing = "Ccleaner"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Applications - Steam" Then
					File_Explorer.Viewing = "Steam"

					Dim file_ As New File_Explorer()
					file_.Show()
					'				#End Region
					'				#Region "Windows"
				ElseIf text_Renamed = " Windows - DirectX Shader Cache" Then
					File_Explorer.Viewing = "DirectX Shader Cache"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows - Update Files" Then
					File_Explorer.Viewing = "Update Files"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows - Font Cache" Then
					File_Explorer.Viewing = "Font Cache"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows - Debug Files" Then
					File_Explorer.Viewing = "Debug Files"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows - Cache Files" Then
					File_Explorer.Viewing = "Cache Files"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows - Installers" Then
					File_Explorer.Viewing = "Installers"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows - Experience Index" Then
					File_Explorer.Viewing = "Experience Index"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows - Auto/Video Quality Experience" Then
					File_Explorer.Viewing = "Auto/Video Quality Experience"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Windows - Internet Explorer Cache" Then
					File_Explorer.Viewing = "Internet Explorer"

					Dim file_ As New File_Explorer()
					file_.Show()
					'				#End Region
					'				#Region "Edge Chromium"
				ElseIf text_Renamed = " Edge Chromium - Cache" Then
					File_Explorer.Viewing = "Edge Cache"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Edge Chromium - Cookies" Then
					File_Explorer.Viewing = "Edge Cookies"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Edge Chromium - History" Then
					File_Explorer.Viewing = "Edge History"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Edge Chromium - Session Data" Then
					File_Explorer.Viewing = "Edge Session"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Edge Chromium - Passwords" Then
					File_Explorer.Viewing = "Edge Passwords"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Edge Chromium - Metrics Temp Files" Then
					File_Explorer.Viewing = "Edge Metrics"

					Dim file_ As New File_Explorer()
					file_.Show()
					'				#End Region
					'				#Region "Google Chrome"
				ElseIf text_Renamed = " Google Chrome - Cache" Then
					File_Explorer.Viewing = "Chrome Cache"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Google Chrome - History" Then
					File_Explorer.Viewing = "Chrome History"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Google Chrome - Cookies" Then
					File_Explorer.Viewing = "Chrome Cookies"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Google Chrome - Download History" Then
					File_Explorer.Viewing = "Chrome Download History"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Google Chrome - Metrics Temp Files" Then
					File_Explorer.Viewing = "Chrome Metrics"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Google Chrome - Session Data" Then
					File_Explorer.Viewing = "Chrome Session"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Google Chrome - Passwords" Then
					File_Explorer.Viewing = "Chrome Passwords"

					Dim file_ As New File_Explorer()
					file_.Show()
					'				#End Region
					'				#Region "Firefox"
				ElseIf text_Renamed = " Mozilla Firefox - Cache" Then
					File_Explorer.Viewing = "Firefox Cache"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Mozilla Firefox - History" Then
					File_Explorer.Viewing = "Firefox History"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Mozilla Firefox - Cookies" Then
					File_Explorer.Viewing = "Firefox Cookies"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Mozilla Firefox - Session Data" Then
					File_Explorer.Viewing = "Firefox Session"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Mozilla Firefox - Site Preferences" Then
					File_Explorer.Viewing = "Firefox Preferences"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Mozilla Firefox - Saved Form Information" Then
					File_Explorer.Viewing = "Firefox Form"

					Dim file_ As New File_Explorer()
					file_.Show()
				ElseIf text_Renamed = " Mozilla Firefox - Saved Passwords" Then
					File_Explorer.Viewing = "Firefox Passwords"

					Dim file_ As New File_Explorer()
					file_.Show()
				End If
				'				#End Region
			End If
		End Sub
#End Region

#Region "Loading Animation"
		Private Sub isRunning(ByVal Status As Boolean, ByVal Text As String)
			If Status Then
				Lbl2.Text = Text
				Running.IsRunning = True
				Running.Visible = True
			ElseIf Not Status Then
				Lbl2.Text = Text
				Running.IsRunning = False
				Running.Visible = False
			End If
		End Sub
#End Region

#Region "Subs"
		Public Shared total As Long
		Public Shared [step] As Integer
		Public Shared remove As Integer
#End Region

#Region "Form Buttons"
		Private Sub Analyze_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Analyze.Click
			List.Items.Clear()
			List.SmallImageList = Me.images

			total = 0

			isRunning(True, "Analying Files Please Wait...")

			Scanner.Enabled = True
			[step] = 1
		End Sub

		Private Sub Cleaner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cleaner.Click
			Remover.Delete.Total_Deleted = 0

			isRunning(True, "Cleaning Files Please Wait...")

			File.WriteAllText(Utils.path & "delete_logs.txt", "")

			Deleter.Enabled = True
			remove = 1
		End Sub

		Private Sub Settings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Settings.Click
			Dim set2 As New Settings()
			set2.ShowDialog()
		End Sub
#End Region

#Region "Contex Menu"
		Private Sub Tray_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Tray.MouseDoubleClick
			Visible = True
			ShowInTaskbar = True
			Opacity = 100
		End Sub

		Private Sub hideToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles hideToolStripMenuItem.Click
			Visible = False
			ShowInTaskbar = False
			Opacity = 0
		End Sub

		Private Sub analyzeFilesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles analyzeFilesToolStripMenuItem.Click
			Visible = True
			ShowInTaskbar = True
			Opacity = 100

			Analyze.PerformClick()
		End Sub

		Private Sub checkForUpdatesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles checkForUpdatesToolStripMenuItem.Click
			Dim web As New WebClient()

			Dim x As String = web.DownloadString("https://raw.githubusercontent.com/alonelydev7932/Axolotl-PC-Cleaner/master/Latest%20Version")

			If x.Contains("1") Then
				MessageBox.Show("You are using the latest version!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				MessageBox.Show("The version you are using is outdated, please update!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

				Process.Start("https://github.com/alonelydev7932/Axolotl-PC-Cleaner/releases")
				Application.Exit()
			End If
		End Sub

		Private Sub aboutAxolotlToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutAxolotlToolStripMenuItem.Click
			MessageBox.Show("A advanced pc cleaner created in .Net" & ControlChars.Lf & "I decided to create this application due to the lack of examples found in C# on github..." & ControlChars.Lf & "For more information contact me on Discord!", ProductName, MessageBoxButtons.OK)
		End Sub

		Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
			Application.Exit()
		End Sub
#End Region

#Region "Scanner & Deleter"
		Private Sub Scanner_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Scanner.Tick
			'			#Region "Edge Chromium"
			If [step] = 1 Then
				If node44.Checked = True Then
					Lbl2.Text = "Scanning Edge Chromium Internet Cache..."

					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long
					Dim lon5 As Long
					Dim lon6 As Long
					Dim lon7 As Long
					Dim lon8 As Long
					Dim lon9 As Long
					Dim lon10 As Long
					Dim lon11 As Long
					Dim lon12 As Long
					Dim lon13 As Long
					Dim lon14 As Long
					Dim lon15 As Long
					Dim lon16 As Long
					Dim lon17 As Long
					Dim lon18 As Long
					Dim lon19 As Long
					Dim lon20 As Long
					Dim lon21 As Long

					lon1 = CheckSize(Locations.Edge_Cache, Temp.EdgeCache, False)
					lon2 = CheckSize(Locations.Edge_Cache2, Temp.EdgeCache, False)
					lon3 = CheckSize(Locations.Edge_Cache3, Temp.EdgeCache, False)
					lon4 = CheckSize(Locations.Edge_Cache4, Temp.EdgeCache, False)
					lon5 = CheckSize(Locations.Edge_Cache5, Temp.EdgeCache, True)
					lon6 = CheckSize(Locations.Edge_Cache6, Temp.EdgeCache, False)
					lon7 = CheckSize(Locations.Edge_Cache7, Temp.EdgeCache, False)
					lon8 = CheckSize(Locations.Edge_Cache8, Temp.EdgeCache, False)
					lon9 = CheckSize(Locations.Edge_Cache9, Temp.EdgeCache, False)
					lon10 = CheckSize(Locations.Edge_Cache10, Temp.EdgeCache, False)

					lon11 = CheckSingle(Locations.Edge_Cache11, Temp.EdgeCache)
					lon12 = CheckSingle(Locations.Edge_Cache12, Temp.EdgeCache)
					lon13 = CheckSingle(Locations.Edge_Cache13, Temp.EdgeCache)
					lon14 = CheckSingle(Locations.Edge_Cache14, Temp.EdgeCache)
					lon15 = CheckSingle(Locations.Edge_Cache15, Temp.EdgeCache)
					lon16 = CheckSingle(Locations.Edge_Cache16, Temp.EdgeCache)
					lon17 = CheckSingle(Locations.Edge_Cache17, Temp.EdgeCache)
					lon18 = CheckSingle(Locations.Edge_Cache18, Temp.EdgeCache)
					lon19 = CheckSingle(Locations.Edge_Cache19, Temp.EdgeCache)
					lon20 = CheckSingle(Locations.Edge_Cache20, Temp.EdgeCache)
					lon21 = CheckSingle(Locations.Edge_Cache21, Temp.EdgeCache)


					Dim result As String = ConvertToString(lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11 + lon12 + lon13 + lon14 + lon15 + lon16 + lon17 + lon18 + lon19 + lon20 + lon21)

					If result <> "0B" Then
						Dim row() As String = {" Edge Chromium - Cache", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 1
						List.Items.Add(listViewItem)

						total = lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11 + lon12 + lon13 + lon14 + lon15 + lon16 + lon17 + lon18 + lon19 + lon20 + lon21
					End If
				Else
					Lbl2.Text = "Skipping Edge Chromium Internet Cache..."
				End If

				[step] += 1
			End If

			If [step] = 2 Then
				If node45.Checked = True Then
					Lbl2.Text = "Scanning Edge Chromium Internet Cookies..."

					Dim lon1 As Long
					Dim lon2 As Long

					lon1 = CheckSize(Locations.Edge_Cookies, Temp.EdgeCookies, True)
					lon2 = CheckSingle(Locations.Edge_Cookies1, Temp.EdgeCookies)

					Dim result As String = ConvertToString(lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" Edge Chromium - Cookies", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 1
						List.Items.Add(listViewItem)

						total = lon1 + lon2
					End If
				Else
					Lbl2.Text = "Skipping Edge Chromium Internet Cookies..."
				End If

				[step] += 1
			End If

			If [step] = 3 Then
				If node46.Checked = True Then
					Lbl2.Text = "Scanning Edge Chromium Internet History..."

					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long
					Dim lon5 As Long
					Dim lon6 As Long
					Dim lon7 As Long
					Dim lon8 As Long
					Dim lon9 As Long
					Dim lon10 As Long
					Dim lon11 As Long
					Dim lon12 As Long
					Dim lon13 As Long
					Dim lon14 As Long

					lon1 = CheckSingle(Locations.Edge_History, Temp.EdgeHistory)
					lon2 = CheckSingle(Locations.Edge_History2, Temp.EdgeHistory)
					lon3 = CheckSingle(Locations.Edge_History3, Temp.EdgeHistory)
					lon4 = CheckSingle(Locations.Edge_History4, Temp.EdgeHistory)
					lon5 = CheckSingle(Locations.Edge_History5, Temp.EdgeHistory)
					lon6 = CheckSingle(Locations.Edge_History6, Temp.EdgeHistory)
					lon7 = CheckSingle(Locations.Edge_History7, Temp.EdgeHistory)
					lon8 = CheckSingle(Locations.Edge_History8, Temp.EdgeHistory)
					lon9 = CheckSingle(Locations.Edge_History9, Temp.EdgeHistory)
					lon10 = CheckSingle(Locations.Edge_History10, Temp.EdgeHistory)
					lon11 = CheckSingle(Locations.Edge_History11, Temp.EdgeHistory)
					lon12 = CheckSingle(Locations.Edge_History12, Temp.EdgeHistory)
					lon13 = CheckSingle(Locations.Edge_History13, Temp.EdgeHistory)
					lon14 = CheckSingle(Locations.Edge_History14, Temp.EdgeHistory)

					Dim result As String = ConvertToString(lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11 + lon12 + lon13 + lon14)

					If result <> "0B" Then
						Dim row() As String = {" Edge Chromium - History", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 1
						List.Items.Add(listViewItem)

						total = lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11 + lon12 + lon13 + lon14
					End If
				Else
					Lbl2.Text = "Skipping Edge Chromium Internet History..."
				End If

				[step] += 1
			End If

			If [step] = 4 Then
				If node47.Checked = True Then
					Lbl2.Text = "Scanning Edge Chromium Session Data..."

					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long

					lon1 = CheckSize(Locations.Edge_Session, Temp.EdgeSession, False)
					lon2 = CheckSize(Locations.Edge_Session2, Temp.EdgeSession, False)
					lon3 = CheckSize(Locations.Edge_Session3, Temp.EdgeSession, False)

					Dim result As String = ConvertToString(lon1 + lon2 + lon3)

					If result <> "0B" Then
						Dim row() As String = {" Edge Chromium - Session Data", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 1
						List.Items.Add(listViewItem)

						total = lon1 + lon2 + lon3
					End If
				Else
					Lbl2.Text = "Skipping Edge Chromium Session Data..."
				End If

				[step] += 1
			End If

			If [step] = 5 Then
				If node48.Checked = True Then
					Lbl2.Text = "Scanning Edge Chromium Saved Passwords..."

					Dim result As String = ConvertToString(CheckSingle(Locations.Edge_Passwords, Temp.EdgePasswords))

					If result <> "0B" Then
						Dim row() As String = {" Edge Chromium - Passwords", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 1
						List.Items.Add(listViewItem)

						total = total + CheckSingle(Locations.Edge_Passwords, Temp.EdgePasswords)
					End If
				Else
					Lbl2.Text = "Skipping Edge Chromium Saved Passwords..."
				End If

				[step] += 1
			End If

			If [step] = 6 Then
				If node49.Checked = True Then
					Lbl2.Text = "Scanning Edge Chromium Metrics Temp Files..."
					Dim lon1 As Long
					Dim lon2 As Long

					lon1 = PmaFiles(Locations.Edge_Metrics, Temp.EdgeMetrics)
					lon2 = PmaFiles(Locations.Edge_Metrics2, Temp.EdgeMetrics)

					Dim result As String = ConvertToString(lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" Edge Chromium - Metrics Temp Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 1
						List.Items.Add(listViewItem)

						total = lon1 + lon2
					End If
				Else
					Lbl2.Text = "Skipping Edge Chromium Metrics Temp Files..."
				End If

				[step] += 1
			End If
			'			#End Region

			'			#Region "Google Chrome"

			If [step] = 7 Then
				If node51.Checked = True Then
					Lbl2.Text = "Scanning Google Chrome Internet Cache..."

					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long
					Dim lon5 As Long
					Dim lon6 As Long
					Dim lon7 As Long
					Dim lon8 As Long
					Dim lon9 As Long
					Dim lon10 As Long
					Dim lon11 As Long
					Dim lon12 As Long
					Dim lon13 As Long
					Dim lon14 As Long
					Dim lon15 As Long
					Dim lon16 As Long
					Dim lon17 As Long
					Dim lon18 As Long
					Dim lon19 As Long
					Dim lon20 As Long
					Dim lon21 As Long
					Dim lon22 As Long

					lon1 = CheckSize(Locations.Chrome_Cache, Temp.ChromeCache, False)
					lon2 = CheckSize(Locations.Chrome_Cache2, Temp.ChromeCache, False)
					lon3 = CheckSize(Locations.Chrome_Cache3, Temp.ChromeCache, False)
					lon4 = CheckSize(Locations.Chrome_Cache4, Temp.ChromeCache, False)
					lon5 = CheckSize(Locations.Chrome_Cache5, Temp.ChromeCache, True)
					lon6 = CheckSize(Locations.Chrome_Cache6, Temp.ChromeCache, False)
					lon7 = CheckSize(Locations.Chrome_Cache7, Temp.ChromeCache, False)
					lon8 = CheckSize(Locations.Chrome_Cache8, Temp.ChromeCache, True)
					lon9 = CheckSize(Locations.Chrome_Cache9, Temp.ChromeCache, False)
					lon10 = CheckSize(Locations.Chrome_Cache10, Temp.ChromeCache, False)
					lon11 = CheckSize(Locations.Chrome_Cache11, Temp.ChromeCache, False)
					lon12 = CheckSize(Locations.Chrome_Cache12, Temp.ChromeCache, False)

					lon13 = CheckSingle(Locations.Chrome_Cache13, Temp.EdgeCache)
					lon14 = CheckSingle(Locations.Chrome_Cache14, Temp.EdgeCache)
					lon15 = CheckSingle(Locations.Chrome_Cache15, Temp.EdgeCache)
					lon16 = CheckSingle(Locations.Chrome_Cache16, Temp.EdgeCache)
					lon17 = CheckSingle(Locations.Chrome_Cache17, Temp.EdgeCache)
					lon18 = CheckSingle(Locations.Chrome_Cache18, Temp.EdgeCache)
					lon19 = CheckSingle(Locations.Chrome_Cache19, Temp.EdgeCache)
					lon20 = CheckSingle(Locations.Chrome_Cache20, Temp.EdgeCache)
					lon21 = CheckSingle(Locations.Chrome_Cache21, Temp.EdgeCache)
					lon22 = CheckSingle(Locations.Chrome_Cache22, Temp.EdgeCache)

					Dim result As String = ConvertToString(lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11 + lon12 + lon13 + lon14 + lon15 + lon16 + lon17 + lon18 + lon19 + lon20 + lon21 + lon22)

					If result <> "0B" Then
						Dim row() As String = {" Google Chrome - Cache", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 3
						List.Items.Add(listViewItem)

						total = lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11 + lon12 + lon13 + lon14 + lon15 + lon16 + lon17 + lon18 + lon19 + lon20 + lon21 + lon22
					End If
				Else
					Lbl2.Text = "Skipping Edge Chromium Internet Cache..."
				End If

				[step] += 1
			End If

			If [step] = 8 Then
				If node52.Checked = True Then
					Lbl2.Text = "Scanning Google Chrome Internet History..."

					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long
					Dim lon5 As Long
					Dim lon6 As Long
					Dim lon7 As Long
					Dim lon8 As Long
					Dim lon9 As Long

					lon1 = CheckSingle(Locations.Chrome_History, Temp.ChromeHistory)
					lon2 = CheckSingle(Locations.Chrome_History2, Temp.ChromeHistory)
					lon3 = CheckSingle(Locations.Chrome_History3, Temp.ChromeHistory)
					lon4 = CheckSingle(Locations.Chrome_History4, Temp.ChromeHistory)
					lon5 = CheckSingle(Locations.Chrome_History5, Temp.ChromeHistory)
					lon6 = CheckSingle(Locations.Chrome_History6, Temp.ChromeHistory)
					lon7 = CheckSingle(Locations.Chrome_History7, Temp.ChromeHistory)
					lon8 = CheckSingle(Locations.Chrome_History8, Temp.ChromeHistory)
					lon9 = CheckSize(Locations.Chrome_History9, Temp.ChromeHistory, False)

					Dim result As String = ConvertToString(lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9)

					If result <> "0B" Then
						Dim row() As String = {" Google Chrome - History", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 3
						List.Items.Add(listViewItem)

						total = lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9
					End If
				Else
					Lbl2.Text = "Skipping Google Chrome Internet History..."
				End If

				[step] += 1
			End If

			If [step] = 9 Then
				If node53.Checked = True Then
					Lbl2.Text = "Scanning Google Chrome Internet Cookies..."

					Dim lon1 As Long
					Dim lon2 As Long

					lon1 = CheckSize(Locations.Chrome_Cookies, Temp.ChromeCookies, False)
					lon2 = CheckSingle(Locations.Chrome_Cookies2, Temp.ChromeHistory)

					Dim result As String = ConvertToString(lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" Google Chrome - Cookies", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 3
						List.Items.Add(listViewItem)

						total = lon1 + lon2
					End If
				Else
					Lbl2.Text = "Skipping Google Chrome Internet Cookies..."
				End If

				[step] += 1
			End If

			If [step] = 10 Then
				If node54.Checked = True Then
					Lbl2.Text = "Scanning Google Chrome Download History..."

					Dim result As String = ConvertToString(CheckSingle(Locations.Chrome_Download, Temp.ChromeDownloadData))

					If result <> "0B" Then
						Dim row() As String = {" Google Chrome - Download History", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 3
						List.Items.Add(listViewItem)

						total = total + CheckSingle(Locations.Chrome_Download, Temp.ChromeDownloadData)
					End If
				Else
					Lbl2.Text = "Skipping Google Chrome Download History..."
				End If

				[step] += 1
			End If

			If [step] = 11 Then
				If node55.Checked = True Then
					Lbl2.Text = "Scanning Google Chrome Metrics Temp Files..."

					Dim result As String = ConvertToString(PmaFiles(Locations.Chrome_Metrics, Temp.ChromeHistory))

					If result <> "0B" Then
						Dim row() As String = {" Google Chrome - Metrics Temp Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 3
						List.Items.Add(listViewItem)

						total = total + CheckSingle(Locations.Chrome_Metrics, Temp.ChromeHistory)
					End If
				Else
					Lbl2.Text = "Skipping Google Chrome Metrics Temp Files..."
				End If

				[step] += 1
			End If

			If [step] = 12 Then
				If node56.Checked = True Then
					Lbl2.Text = "Scanning Google Chrome Session Data..."

					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long

					lon1 = CheckSize(Locations.Chrome_Session, Temp.ChromeSession, False)
					lon2 = CheckSize(Locations.Chrome_Session2, Temp.ChromeSession, False)
					lon3 = CheckSize(Locations.Chrome_Session3, Temp.ChromeSession, False)

					Dim result As String = ConvertToString(lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" Google Chrome - Session Data", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 3
						List.Items.Add(listViewItem)

						total = lon1 + lon2 + lon3
					End If
				Else
					Lbl2.Text = "Skipping Google Chrome Session Data..."
				End If

				[step] += 1
			End If

			If [step] = 13 Then
				If node57.Checked = True Then
					Lbl2.Text = "Scanning Google Chrome Saved Passwords..."

					Dim result As String = ConvertToString(CheckSingle(Locations.Chrome_Passwords, Temp.ChromePasswords))

					If result <> "0B" Then
						Dim row() As String = {" Google Chrome - Passwords", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 3
						List.Items.Add(listViewItem)

						total = total + CheckSingle(Locations.Chrome_Passwords, Temp.ChromePasswords)
					End If
				Else
					Lbl2.Text = "Skipping Google Chrome Saved Passwords..."
				End If

				[step] += 1
			End If
			'			#End Region

			'			#Region "Firefox"
			If [step] = 14 Then
				If node59.Checked = True Then
					Lbl2.Text = "Scanning Mozilla Firefox Internet Cache..."

					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long
					Dim lon5 As Long

					lon1 = CheckSize(Locations.Firefox_Cache, Temp.FirefoxCache, False)
					lon2 = CheckSize(Locations.Firefox_Cache2, Temp.FirefoxCache, False)
					lon3 = CheckSize(Locations.Firefox_Cache3, Temp.FirefoxCache, False)
					lon4 = CheckSize(Locations.Firefox_Cache4, Temp.FirefoxCache, False)
					lon5 = CheckSize(Locations.Firefox_Cache5, Temp.FirefoxCache, False)

					Dim result As String = ConvertToString(lon1 + lon2 + lon3 + lon4 + lon5)

					If result <> "0B" Then
						Dim row() As String = {" Mozilla Firefox - Cache", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 2
						List.Items.Add(listViewItem)

						total = lon1 + lon2 + lon3 + lon4 + lon5
					End If
				Else
					Lbl2.Text = "Skipping Mozilla Firefox Internet Cache..."
				End If

				[step] += 1
			End If

			If [step] = 15 Then
				If node60.Checked = True Then
					Lbl2.Text = "Scanning Mozilla Firefox Internet History..."

					Dim result As String = ConvertToString(CheckSize(Locations.Firefox_History, Temp.FirefoxHistory, False))

					If result <> "0B" Then
						Dim row() As String = {" Mozilla Firefox - History", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 2
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Firefox_History, Temp.FirefoxHistory, False)
					End If
				Else
					Lbl2.Text = "Skipping Mozilla Firefox Internet History..."
				End If

				[step] += 1
			End If

			If [step] = 16 Then
				If node61.Checked = True Then
					Lbl2.Text = "Scanning Mozilla Firefox Internet Cookies..."

					Dim result As String = ConvertToString(CheckSize(Locations.Firefox_Cookies, Temp.FirefoxCookies, True))

					If result <> "0B" Then
						Dim row() As String = {" Mozilla Firefox - Cookies", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 2
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Firefox_Cookies, Temp.FirefoxCookies, True)
					End If
				Else
					Lbl2.Text = "Skipping Mozilla Firefox Internet Cookies..."
				End If

				[step] += 1
			End If

			If [step] = 17 Then
				If node62.Checked = True Then
					Lbl2.Text = "Scanning Mozilla Firefox Session Data..."

					Dim lon1 As Long
					Dim lon2 As Long

					lon1 = CheckSize(Locations.Firefox_Session, Temp.FirefoxSession, False)
					lon2 = CheckSingle(Locations.Firefox_Session, Temp.FirefoxSession)

					Dim result As String = ConvertToString(lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" Mozilla Firefox - Session Data", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 2
						List.Items.Add(listViewItem)

						total = lon1 + lon2
					End If
				Else
					Lbl2.Text = "Skipping Mozilla Firefox Session Data..."
				End If

				[step] += 1
			End If

			If [step] = 18 Then
				If node63.Checked = True Then
					Lbl2.Text = "Scanning Mozilla Firefox Site Preferences..."

					Dim result As String = ConvertToString(CheckSingle(Locations.Firefox_Site_Pref, Temp.FirefoxSite))

					If result <> "0B" Then
						Dim row() As String = {" Mozilla Firefox - Site Preferences", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 2
						List.Items.Add(listViewItem)

						total = total + CheckSingle(Locations.Firefox_Site_Pref, Temp.FirefoxSite)
					End If
				Else
					Lbl2.Text = "Skipping Mozilla Firefox Site Preferences..."
				End If

				[step] += 1
			End If

			If [step] = 19 Then
				If node64.Checked = True Then
					Lbl2.Text = "Scanning Mozilla Firefox Saved Form Information..."

					Dim result As String = ConvertToString(CheckSingle(Locations.Firefox_Saved_Form, Temp.FirefoxForm))

					If result <> "0B" Then
						Dim row() As String = {" Mozilla Firefox - Saved Form Information", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 2
						List.Items.Add(listViewItem)

						total = total + CheckSingle(Locations.Firefox_Saved_Form, Temp.FirefoxForm)
					End If
				Else
					Lbl2.Text = "Skipping Mozilla Firefox Saved Form Information..."
				End If

				[step] += 1
			End If

			If [step] = 20 Then
				If node65.Checked = True Then
					Lbl2.Text = "Scanning Mozilla Firefox Saved Passowrds..."

					Dim lon1 As Long
					Dim lon2 As Long

					lon1 = CheckSingle(Locations.Firefox_Login, Temp.FirefoxPasswords)
					lon2 = CheckSingle(Locations.Firefox_Login2, Temp.FirefoxPasswords)

					Dim result As String = ConvertToString(lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" Mozilla Firefox - Saved Passwords", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 2
						List.Items.Add(listViewItem)

						total = lon1 + lon2
					End If
				Else
					Lbl2.Text = "Skipping Mozilla Firefox Saved Passowrds..."
				End If

				[step] += 1
			End If
			'			#End Region

			'			#Region "Windows Explorer"
			If [step] = 21 Then
				If node2.Checked = True Then
					Lbl2.Text = "Scanning Windows Temporary Files..."

					Dim result As String = ConvertToString(CheckSize(Locations.Recent_Documents, Temp.Recent_Documents, False))

					If result <> "0B" Then
						Dim row() As String = {" Windows Explorer - Recent Documents", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 6
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Recent_Documents, Temp.Recent_Documents, False)
					End If
				Else
					Lbl2.Text = "Skipping Recent Documents..."
				End If

				[step] += 1
			End If

			If [step] = 22 Then
				If node3.Checked = True Then
					Lbl2.Text = "Scanning Windows Temporary Files..."

					Dim result As String = ConvertToString(CheckSize(Locations.Thumnail_Cache, Temp.Thumnail_Cache, False))

					If result <> "0B" Then
						Dim row() As String = {" Windows Explorer - Thumnail Cache", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 6
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Thumnail_Cache, Temp.Thumnail_Cache, False)
					End If
				Else
					Lbl2.Text = "Skipping Thumbnail Cache..."
				End If

				[step] += 1
			End If

			If [step] = 23 Then
				If node4.Checked = True Then
					Lbl2.Text = "Scanning Windows Temporary Files..."

					Dim result As String = ConvertToString(CheckSize(Locations.Mini_Dumps, Temp.Mini_Dumps, False))

					If result <> "0B" Then
						Dim row() As String = {" Windows Explorer - Mini Dumps", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 6
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Mini_Dumps, Temp.Mini_Dumps, False)
					End If
				Else
					Lbl2.Text = "Skipping Mini Dumps..."
				End If

				[step] += 1
			End If

			If [step] = 24 Then
				If node15.Checked = True Then
					Lbl2.Text = "Scanning Windows Temporary Files..."

					Dim result As String = ConvertToString(CheckSize(Locations.Win_Temp_Files, Temp.WinTempFiles, True))

					If result <> "0B" Then
						Dim row() As String = {" Windows Explorer - Temporary Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 6
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Win_Temp_Files, Temp.WinTempFiles, True)
					End If
				Else
					Lbl2.Text = "Skipping Windows Temporary Files..."
				End If

				[step] += 1
			End If
			'			#End Region

			'			#Region "System"
			If [step] = 25 Then
				If node6.Checked = True Then
					Lbl2.Text = "Scanning Recycle Bin..."

					Dim result As String = ConvertToString(CheckSize(Locations.Recyle_Bin, Temp.Recylce_Bin, True))

					If result <> "0B" Then
						Dim row() As String = {" System - Recycle Bin", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 5
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Recyle_Bin, Temp.Recylce_Bin, True)
					End If
				Else
					Lbl2.Text = "Skipping Recycle Bin..."
				End If

				[step] += 1
			End If

			If [step] = 26 Then
				If node7.Checked = True Then
					Lbl2.Text = "Scanning System Temporary Files..."

					Dim result As String = ConvertToString(CheckSize(Locations.Temp_Files, Temp.TempFiles, True))

					If result <> "0B" Then
						Dim row() As String = {" System - Temporary Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 5
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Temp_Files, Temp.TempFiles, True)
					End If
				Else
					Lbl2.Text = "Skipping System Temporary Files..."
				End If

				[step] += 1
			End If

			If [step] = 27 Then
				If node8.Checked = True Then
					Lbl2.Text = "Scanning Memory Dumps..."

					Dim result As String = ConvertToString(CheckSize(Locations.Memory_Dumps, Temp.MemoryDumps, False))

					If result <> "0B" Then
						Dim row() As String = {" System - Memory Dumps", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 5
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Memory_Dumps, Temp.MemoryDumps, False)
					End If
				Else
					Lbl2.Text = "Skipping Memory Dumps..."
				End If

				[step] += 1
			End If

			If [step] = 28 Then
				If node9.Checked = True Then
					Lbl2.Text = "Scanning Windows Log Files..."

					Dim lon As Long
					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long
					Dim lon5 As Long
					Dim lon6 As Long
					Dim lon7 As Long
					Dim lon8 As Long
					Dim lon9 As Long
					Dim lon10 As Long
					Dim lon11 As Long
					Dim lon12 As Long
					Dim lon13 As Long
					Dim lon14 As Long
					Dim lon15 As Long
					Dim lon16 As Long
					Dim lon17 As Long
					Dim lon18 As Long
					Dim lon19 As Long
					Dim lon20 As Long
					Dim lon21 As Long
					Dim lon22 As Long
					Dim lon23 As Long
					Dim lon24 As Long
					Dim lon25 As Long
					Dim lon26 As Long
					Dim lon27 As Long
					Dim lon28 As Long
					Dim lon29 As Long
					Dim lon30 As Long
					Dim lon31 As Long
					Dim lon32 As Long
					Dim lon33 As Long
					Dim lon34 As Long
					Dim lon35 As Long
					Dim lon36 As Long
					Dim lon37 As Long
					Dim lon38 As Long
					Dim lon39 As Long
					Dim lon40 As Long

					lon = LogFiles(Locations.WinLogs, Temp.WindowsLogs)
					lon1 = LogFiles(Locations.WinLogs1, Temp.WindowsLogs)
					lon2 = LogFiles(Locations.WinLogs2, Temp.WindowsLogs)
					lon3 = LogFiles(Locations.WinLogs3, Temp.WindowsLogs)
					lon4 = LogFiles(Locations.WinLogs4, Temp.WindowsLogs)
					lon5 = LogFiles(Locations.WinLogs5, Temp.WindowsLogs)
					lon6 = LogFiles(Locations.WinLogs6, Temp.WindowsLogs)
					lon7 = LogFiles(Locations.WinLogs7, Temp.WindowsLogs)
					lon8 = LogFiles(Locations.WinLogs8, Temp.WindowsLogs)
					lon9 = LogFiles(Locations.WinLogs9, Temp.WindowsLogs)
					lon10 = LogFiles(Locations.WinLogs10, Temp.WindowsLogs)
					lon11 = LogFiles(Locations.WinLogs11, Temp.WindowsLogs)
					lon12 = LogFiles(Locations.WinLogs12, Temp.WindowsLogs)
					lon13 = LogFiles(Locations.WinLogs13, Temp.WindowsLogs)
					lon14 = LogFiles(Locations.WinLogs14, Temp.WindowsLogs)
					lon15 = LogFiles(Locations.WinLogs15, Temp.WindowsLogs)
					lon16 = LogFiles(Locations.WinLogs16, Temp.WindowsLogs)
					lon17 = LogFiles(Locations.WinLogs17, Temp.WindowsLogs)
					lon18 = LogFiles(Locations.WinLogs18, Temp.WindowsLogs)
					lon19 = LogFiles(Locations.WinLogs19, Temp.WindowsLogs)
					lon20 = LogFiles(Locations.WinLogs20, Temp.WindowsLogs)
					lon21 = LogFiles(Locations.WinLogs21, Temp.WindowsLogs)
					lon22 = LogFiles(Locations.WinLogs22, Temp.WindowsLogs)
					lon23 = LogFiles(Locations.WinLogs23, Temp.WindowsLogs)
					lon24 = LogFiles(Locations.WinLogs24, Temp.WindowsLogs)
					lon25 = LogFiles(Locations.WinLogs25, Temp.WindowsLogs)
					lon26 = LogFiles(Locations.WinLogs26, Temp.WindowsLogs)
					lon27 = LogFiles(Locations.WinLogs27, Temp.WindowsLogs)
					lon28 = LogFiles(Locations.WinLogs28, Temp.WindowsLogs)
					lon29 = LogFiles(Locations.WinLogs29, Temp.WindowsLogs)
					lon30 = LogFiles(Locations.WinLogs30, Temp.WindowsLogs)
					lon31 = LogFiles(Locations.WinLogs31, Temp.WindowsLogs)
					lon32 = LogFiles(Locations.WinLogs32, Temp.WindowsLogs)
					lon33 = LogFiles(Locations.WinLogs33, Temp.WindowsLogs)
					lon34 = LogFiles(Locations.WinLogs34, Temp.WindowsLogs)
					lon35 = LogFiles(Locations.WinLogs35, Temp.WindowsLogs)
					lon36 = LogFiles(Locations.WinLogs36, Temp.WindowsLogs)
					lon37 = LogFiles(Locations.WinLogs37, Temp.WindowsLogs)
					lon38 = LogFiles(Locations.WinLogs38, Temp.WindowsLogs)
					lon39 = LogFiles(Locations.WinLogs39, Temp.WindowsLogs)
					lon40 = LogFiles(Locations.WinLogs40, Temp.WindowsLogs)

					Dim result As String = ConvertToString(lon + lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11 + lon12 + lon13 + lon14 + lon15 + lon16 + lon17 + lon18 + lon19 + lon20 + lon21 + lon22 + lon23 + lon24 + lon25 + lon26 + lon27 + lon28 + lon29 + lon30 + lon30 + lon31 + lon32 + lon33 + lon34 + lon35 + lon36 + lon37 + lon38 + lon39 + lon40)

					If result <> "0B" Then
						Dim row() As String = {" System - Windows Log Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 5
						List.Items.Add(listViewItem)

						total = total + lon + lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11 + lon12 + lon13 + lon14 + lon15 + lon16 + lon17 + lon18 + lon19 + lon20 + lon21 + lon22 + lon23 + lon24 + lon25 + lon26 + lon27 + lon28 + lon29 + lon30 + lon30 + lon31 + lon32 + lon33 + lon34 + lon35 + lon36 + lon37 + lon38 + lon39 + lon40
					End If
				Else
					Lbl2.Text = "Skipping Windows Log Files..."
				End If

				[step] += 1
			End If

			If [step] = 29 Then
				If node10.Checked = True Then
					Lbl2.Text = "Scanning Event Trace Logs..."

					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long
					Dim lon5 As Long
					Dim lon6 As Long
					Dim lon7 As Long
					Dim lon8 As Long
					Dim lon9 As Long
					Dim lon10 As Long
					Dim lon11 As Long

					lon1 = EtlFiles(Locations.WinLogs1, Temp.EventTraces)
					lon2 = EtlFiles(Locations.WinLogs2, Temp.EventTraces)
					lon3 = EtlFiles(Locations.WinLogs3, Temp.EventTraces)
					lon4 = EtlFiles(Locations.WinLogs4, Temp.EventTraces)
					lon5 = EtlFiles(Locations.WinLogs5, Temp.EventTraces)
					lon6 = EtlFiles(Locations.WinLogs6, Temp.EventTraces)
					lon7 = EtlFiles(Locations.WinLogs7, Temp.EventTraces)
					lon8 = EtlFiles(Locations.WinLogs8, Temp.EventTraces)
					lon9 = EtlFiles(Locations.WinLogs9, Temp.EventTraces)
					lon10 = EtlFiles(Locations.WinLogs10, Temp.EventTraces)
					lon11 = EtlFiles(Locations.WinLogs11, Temp.EventTraces)

					Dim result As String = ConvertToString(lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11)

					If result <> "0B" Then
						Dim row() As String = {" System - Event Trace Logs", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 5
						List.Items.Add(listViewItem)

						total = total + lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7 + lon8 + lon9 + lon10 + lon11
					End If
				Else
					Lbl2.Text = "Skipping Event Trace Logs..."
				End If

				[step] += 1
			End If

			If [step] = 30 Then
				If node11.Checked = True Then
					Lbl2.Text = "Scanning Error Reports..."

					Dim result As String = ConvertToString(CheckSize(Locations.Error_Reports, Temp.ErrorReports, True))

					If result <> "0B" Then
						Dim row() As String = {" System - Error Reporting", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 5
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Error_Reports, Temp.ErrorReports, True)
					End If
				Else
					Lbl2.Text = "Skipping Error Reports..."
				End If

				[step] += 1
			End If

			If [step] = 31 Then
				If node12.Checked = True Then
					Lbl2.Text = "Scanning Driver Installation Log Files"

					Dim result As String = ConvertToString(CheckSingle(Locations.Driver_Installtion & "\setupapi.dev.log", Temp.InstallationLogs))

					If result <> "0B" Then
						Dim row() As String = {" System - Driver Installation Log Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 5
						List.Items.Add(listViewItem)

						total = total + CheckSingle(Locations.Driver_Installtion & "\setupapi.dev.log", Temp.InstallationLogs)
					End If
				Else
					Lbl2.Text = "Skipping Driver Installation Log Files"
				End If

				[step] += 1
			End If

			If [step] = 32 Then
				If node13.Checked = True Then
					Lbl2.Text = "Scanning Delivery Optimization Files..."

					Dim lon1 As Long
					Dim lon2 As Long

					lon1 = CheckSize(Locations.Delivery_Optimization & "\Cache", Temp.EventTraces, False)
					lon2 = LogFiles(Locations.Delivery_Optimization & "\Logs", Temp.EventTraces)

					Dim result As String = ConvertToString(lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" System - Windows Delivery Optimization Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 5
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Delivery_Optimization & "\Cache", Temp.EventTraces, False) + LogFiles(Locations.Delivery_Optimization & "\Logs", Temp.EventTraces)
					End If
				Else
					Lbl2.Text = "Skipping Delivery Optimization Files..."
				End If

				[step] += 1
			End If

			If [step] = 33 Then
				If node14.Checked = True Then
					Lbl2.Text = "Scanning Network Data Usage..."

					Dim result As String = ConvertToString(CheckSize(Locations.Network_Data, Temp.NetworkData, False))

					If result <> "0B" Then
						Dim row() As String = {" System - Network Data Usage", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 5
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Network_Data, Temp.NetworkData, False)
					End If
				Else
					Lbl2.Text = "Skipping Network Data Usage..."
				End If

				[step] += 1
			End If
			'			#End Region

			'			#Region "Advanced"
			If [step] = 34 Then
				If node17.Checked = True Then
					Lbl2.Text = "Scanning Prefetch Data..."

					Dim result As String = ConvertToString(CheckSize(Locations.Prefetch, Temp.Prefetch, False))

					If result <> "0B" Then
						Dim row() As String = {" Advanced - Prefetch Data", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 4
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Prefetch, Temp.Prefetch, False)
					End If
				Else
					Lbl2.Text = "Skipping Prefetch Data..."
				End If

				[step] += 1
			End If

			If [step] = 35 Then
				If node18.Checked = True Then
					Lbl2.Text = "Scanning Store Install Service Cache..."

					Dim result As String = ConvertToString(CatalogFiles(Locations.Store_Install_Service, Temp.StoreInstall))

					If result <> "0B" Then
						Dim row() As String = {" Advanced - Store Install Service Cache", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 4
						List.Items.Add(listViewItem)

						total = total + CatalogFiles(Locations.Store_Install_Service, Temp.StoreInstall)
					End If
				Else
					Lbl2.Text = "Skipping Store Install Service Cache..."
				End If

				[step] += 1
			End If

			If [step] = 36 Then
				If node19.Checked = True Then
					Lbl2.Text = "Scanning QT Framework..."

					Dim result As String = ConvertToString(CheckSize(Locations.QtFramework, Temp.QtFramework, True))

					If result <> "0B" Then
						Dim row() As String = {" Advanced - QT Framework", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 4
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.QtFramework, Temp.QtFramework, True)
					End If
				Else
					Lbl2.Text = "Skipping QT Framework..."
				End If

				[step] += 1
			End If

			If [step] = 37 Then
				If node20.Checked = True Then
					Lbl2.Text = "Scanning Power Efficiency Diagnostics..."

					Dim result As String = ConvertToString(XmlFiles(Locations.Power_Efficiency, Temp.PowerEfficiency))

					If result <> "0B" Then
						Dim row() As String = {" Advanced - Power Efficiency Diagnostics", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 4
						List.Items.Add(listViewItem)

						total = total + XmlFiles(Locations.Power_Efficiency, Temp.PowerEfficiency)
					End If
				Else
					Lbl2.Text = "Skipping Power Efficiency Diagnostics..."
				End If

				[step] += 1
			End If

			If [step] = 38 Then
				If node21.Checked = True Then
					Lbl2.Text = "Scanning Notifications..."

					Dim result As String = ConvertToString(CheckSize(Locations.Notifications, Temp.Notifications, True))

					If result <> "0B" Then
						Dim row() As String = {" Advanced - Notifications", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 4
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Notifications, Temp.Notifications, True)
					End If
				Else
					Lbl2.Text = "Skipping Notifications..."
				End If

				[step] += 1
			End If

			If [step] = 39 Then
				If node22.Checked = True Then
					Lbl2.Text = "Scanning MS Search..."

					Dim lon As Long
					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long

					lon = EdbFiles(Locations.MS_Search, Temp.MsSearch)
					lon1 = CrwlFiles(Locations.MS_Search2, Temp.MsSearch)
					lon2 = CheckSize(Locations.MS_Search3, Temp.MsSearch, False)
					lon3 = CheckSize(Locations.MS_Search4, Temp.MsSearch, True)
					lon4 = CheckSize(Locations.MS_Search5, Temp.MsSearch, True)

					Dim result As String = ConvertToString(lon + lon1 + lon2 + lon3 + lon4)

					If result <> "0B" Then
						Dim row() As String = {" Advanced - MS Search", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 4
						List.Items.Add(listViewItem)

						total = total + lon + lon1 + lon2 + lon3 + lon4
					End If
				Else
					Lbl2.Text = "Skipping MS Search..."
				End If

				[step] += 1
			End If

			If [step] = 40 Then
				If node23.Checked = True Then
					Lbl2.Text = "Scanning Jump List..."

					Dim result As String = ConvertToString(CheckSize(Locations.Jump_List, Temp.JumpList, False))

					If result <> "0B" Then
						Dim row() As String = {" Advanced - Jump List", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 4
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Jump_List, Temp.JumpList, False)
					End If
				Else
					Lbl2.Text = "Skipping Jump List..."
				End If

				[step] += 1
			End If

			If [step] = 41 Then
				If node24.Checked = True Then
					Lbl2.Text = "Scanning Font Cache..."

					Dim result As String = ConvertToString(DatFiles(Locations.Font_Cache, Temp.FontCache))

					If result <> "0B" Then
						Dim row() As String = {" Advanced - Font Cache", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 4
						List.Items.Add(listViewItem)

						total = total + DatFiles(Locations.Font_Cache, Temp.FontCache)
					End If
				Else
					Lbl2.Text = "Skipping Font Cache..."
				End If

				[step] += 1
			End If
			'			#End Region

			'			#Region "Applications"
			If [step] = 42 Then
				If node26.Checked = True Then
					Lbl2.Text = "Scanning Windows Defender..."

					Dim lon As Long
					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long
					Dim lon5 As Long

					lon = CheckSize(Locations.Win_Defender, Temp.WindowsDefender, False)
					lon1 = LogFiles(Locations.Win_Defender2, Temp.WindowsDefender)
					lon2 = CheckSize(Locations.Win_Defender3, Temp.WindowsDefender, True)
					lon3 = CheckSize(Locations.Win_Defender4, Temp.WindowsDefender, False)
					lon4 = CheckSize(Locations.Win_Defender5, Temp.WindowsDefender, False)
					lon4 = CheckSize(Locations.Win_Defender6, Temp.WindowsDefender, False)
					lon5 = CheckSize(Locations.Win_Defender7, Temp.WindowsDefender, True)

					Dim result As String = ConvertToString(lon + lon1 + lon2 + lon3 + lon4 + lon5)

					If result <> "0B" Then
						Dim row() As String = {" Applications - Windows Defender", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 0
						List.Items.Add(listViewItem)

						total = total + lon + lon1 + lon2 + lon3 + lon4 + lon5
					End If
				Else
					Lbl2.Text = "Skipping Windows Defender..."
				End If

				[step] += 1
			End If

			If [step] = 43 Then
				If node27.Checked = True Then
					Lbl2.Text = "Scanning Origin Installers..."

					Dim result As String = ConvertToString(CheckSize(Locations.Origin_Installers, Temp.OriginInstallers, True))

					If result <> "0B" Then
						Dim row() As String = {" Applications - Origin Installers", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 0
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Origin_Installers, Temp.OriginInstallers, True)
					End If
				Else
					Lbl2.Text = "Skipping Origin Installers..."
				End If

				[step] += 1
			End If

			If [step] = 44 Then
				If node28.Checked = True Then
					Lbl2.Text = "Scanning Visual Studio Installation..."

					Dim result As String = ConvertToString(CheckSize(Locations.Visual_Studio, Temp.VisualStudio, True))

					If result <> "0B" Then
						Dim row() As String = {" Applications - Visual Studio Installation", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 0
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Visual_Studio, Temp.VisualStudio, True)
					End If
				Else
					Lbl2.Text = "Skipping Visual Studio Installation..."
				End If

				[step] += 1
			End If

			If [step] = 45 Then
				If node29.Checked = True Then
					Lbl2.Text = "Scanning One Drive..."

					Dim lon As Long
					Dim lon1 As Long
					Dim lon2 As Long

					lon = CheckSize(Locations.One_Drive, Temp.OneDrive, False)
					lon1 = LogFiles(Locations.One_Drive2, Temp.OneDrive)
					lon2 = CheckSize(Locations.One_Drive3, Temp.OneDrive, True)

					Dim result As String = ConvertToString(lon + lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" Applications - One Drive", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 0
						List.Items.Add(listViewItem)

						total = total + lon + lon1 + lon2
					End If
				Else
					Lbl2.Text = "Skipping One Drive..."
				End If

				[step] += 1
			End If

			If [step] = 46 Then
				If node30.Checked = True Then
					Lbl2.Text = "Scanning Easy Anti-Cheat..."

					Dim result As String = ConvertToString(LogFiles(Locations.Easy_AntiCheat, Temp.EasyAntiCheat))

					If result <> "0B" Then
						Dim row() As String = {" Applications - Easy Anti-Cheat", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 0
						List.Items.Add(listViewItem)

						total = total + LogFiles(Locations.Easy_AntiCheat, Temp.EasyAntiCheat)
					End If
				Else
					Lbl2.Text = "Skipping Easy Anti-Cheat..."
				End If

				[step] += 1
			End If

			If [step] = 47 Then
				If node31.Checked = True Then
					Lbl2.Text = "Scanning Battlenet..."

					Dim lon As Long
					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long

					lon = CheckSize(Locations.Battlenet, Temp.Battlenet, True)
					lon1 = CheckSize(Locations.Battlenet2, Temp.Battlenet, False)
					lon2 = CheckSize(Locations.Battlenet3, Temp.Battlenet, False)
					lon3 = CheckSize(Locations.Battlenet4, Temp.Battlenet, False)
					lon4 = CheckSize(Locations.Battlenet5, Temp.Battlenet, True)

					Dim result As String = ConvertToString(lon + lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" Applications - Battlenet", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 0
						List.Items.Add(listViewItem)

						total = total + lon + lon1 + lon2
					End If
				Else
					Lbl2.Text = "Skipping Battlenet..."
				End If

				[step] += 1
			End If

			If [step] = 48 Then
				If node32.Checked = True Then
					Lbl2.Text = "Scanning Ccleaner..."

					Dim result As String = ConvertToString(LogFiles(Locations.Ccleaner, Temp.Ccleaner))

					If result <> "0B" Then
						Dim row() As String = {" Applications - Ccleaner", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 0
						List.Items.Add(listViewItem)

						total = total + LogFiles(Locations.Ccleaner, Temp.Ccleaner)
					End If
				Else
					Lbl2.Text = "Skipping Ccleaner..."
				End If

				[step] += 1
			End If

			If [step] = 49 Then
				If node33.Checked = True Then
					Lbl2.Text = "Scanning Steam..."

					Dim lon As Long
					Dim lon1 As Long
					Dim lon2 As Long

					lon = LogFiles(Locations.Steam, Temp.Steam)
					lon1 = CheckSize(Locations.Steam2, Temp.Steam, False)
					lon2 = CheckSize(Locations.Steam3, Temp.Steam, False)

					Dim result As String = ConvertToString(lon + lon1 + lon2)

					If result <> "0B" Then
						Dim row() As String = {" Applications - Steam", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 0
						List.Items.Add(listViewItem)

						total = total + lon + lon1 + lon2
					End If
				Else
					Lbl2.Text = "Skipping Steam..."
				End If

				[step] += 1
			End If
			'			#End Region

			'			#Region "Windows"
			If [step] = 50 Then
				If node35.Checked = True Then
					Lbl2.Text = "Scanning DirectX Shader Cache..."

					Dim lon As Long
					Dim lon1 As Long

					lon = CheckSize(Locations.DirectX, Temp.ShaderCache, True)
					lon1 = CheckSize(Locations.DirectX2, Temp.ShaderCache, True)

					Dim result As String = ConvertToString(lon + lon1)

					If result <> "0B" Then
						Dim row() As String = {" Windows - DirectX Shader Cache", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 7
						List.Items.Add(listViewItem)

						total = total + lon + lon1
					End If
				Else
					Lbl2.Text = "Skipping DirectX Shader Cache..."
				End If

				[step] += 1
			End If

			If [step] = 51 Then
				If node36.Checked = True Then
					Lbl2.Text = "Scanning Update Files..."

					Dim result As String = ConvertToString(CheckSize(Locations.Windows_Update, Temp.WindowsUpdate, True))

					If result <> "0B" Then
						Dim row() As String = {" Windows - Update Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 7
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Windows_Update, Temp.WindowsUpdate, True)
					End If
				Else
					Lbl2.Text = "Skipping Update Files..."
				End If

				[step] += 1
			End If

			If [step] = 52 Then
				If node37.Checked = True Then
					Lbl2.Text = "Scanning Font Cache..."

					Dim result As String = ConvertToString(CheckSingle(Locations.Windows_Font_Cache, Temp.WindowsFontCache))

					If result <> "0B" Then
						Dim row() As String = {" Windows - Font Cache", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 7
						List.Items.Add(listViewItem)

						total = total + CheckSingle(Locations.Windows_Font_Cache, Temp.WindowsFontCache)
					End If
				Else
					Lbl2.Text = "Skipping Font Cache..."
				End If

				[step] += 1
			End If

			If [step] = 53 Then
				If node38.Checked = True Then
					Lbl2.Text = "Scanning Debug Files..."

					Dim result As String = ConvertToString(LogFiles(Locations.Windows_Debug, Temp.WindowsDebug))

					If result <> "0B" Then
						Dim row() As String = {" Windows - Debug Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 7
						List.Items.Add(listViewItem)

						total = total + LogFiles(Locations.Windows_Debug, Temp.WindowsDebug)
					End If
				Else
					Lbl2.Text = "Skipping Debug Files..."
				End If

				[step] += 1
			End If

			If [step] = 54 Then
				If node39.Checked = True Then
					Lbl2.Text = "Scanning Cache Files..."

					Dim lon As Long
					Dim lon1 As Long
					Dim lon2 As Long
					Dim lon3 As Long
					Dim lon4 As Long

					lon = CheckSize(Locations.Windows_Cache, Temp.WindowsCache, True)
					lon1 = CheckSize(Locations.Windows_Cache2, Temp.WindowsCache, True)
					lon2 = CheckSize(Locations.Windows_Cache3, Temp.WindowsCache, True)
					lon3 = CheckSize(Locations.Windows_Cache4, Temp.WindowsCache, True)
					lon4 = CheckSize(Locations.Windows_Cache5, Temp.WindowsCache, True)

					Dim result As String = ConvertToString(lon + lon1 + lon2 + lon3 + lon4)

					If result <> "0B" Then
						Dim row() As String = {" Windows - Cache Files", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 7
						List.Items.Add(listViewItem)

						total = total + lon + lon1 + lon2 + lon3 + lon4
					End If
				Else
					Lbl2.Text = "Skipping Cache Files..."
				End If

				[step] += 1
			End If

			If [step] = 55 Then
				If node40.Checked = True Then
					Lbl2.Text = "Scanning Installers..."

					Dim result As String = ConvertToString(CheckSize(Locations.Windows_Installer, Temp.WindowsInstaller, True))

					If result <> "0B" Then
						Dim row() As String = {" Windows - Installers", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 7
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Windows_Installer, Temp.WindowsInstaller, True)
					End If
				Else
					Lbl2.Text = "Skipping Installers..."
				End If

				[step] += 1
			End If

			If [step] = 56 Then
				If node41.Checked = True Then
					Lbl2.Text = "Scanning Experience Index..."

					Dim lon As Long
					Dim lon1 As Long

					lon = LogFiles(Locations.Windows_Experience, Temp.WindowsExperience)
					lon1 = CheckSize(Locations.Windows_Experience2, Temp.WindowsExperience, True)

					Dim result As String = ConvertToString(lon + lon1)

					If result <> "0B" Then
						Dim row() As String = {" Windows - Experience Index", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 7
						List.Items.Add(listViewItem)

						total = total + lon + lon1
					End If
				Else
					Lbl2.Text = "Skipping Experience Index..."
				End If

				[step] += 1
			End If

			If [step] = 57 Then
				If node42.Checked = True Then
					Lbl2.Text = "Scanning Auto/Video Quality Experience..."

					Dim result As String = ConvertToString(DatFiles(Locations.Windows_Auto_Video_Experience, Temp.AutoVideoExperience))

					If result <> "0B" Then
						Dim row() As String = {" Windows - Auto/Video Quality Experience", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 7
						List.Items.Add(listViewItem)

						total = total + DatFiles(Locations.Windows_Auto_Video_Experience, Temp.AutoVideoExperience)
					End If
				Else
					Lbl2.Text = "Skipping Auto/Video Quality Experience..."
				End If

				[step] += 1
			End If

			If [step] = 58 Then
				If node66.Checked = True Then
					Lbl2.Text = "Scanning Internet Explorer Cache..."

					Dim result As String = ConvertToString(CheckSize(Locations.Windows_Internet_Cache, Temp.WindowsInternetCache, True))

					If result <> "0B" Then
						Dim row() As String = {" Windows - Internet Explorer Cache", result}
						Dim listViewItem = New ListViewItem(row)
						listViewItem.ImageIndex = 7
						List.Items.Add(listViewItem)

						total = total + CheckSize(Locations.Windows_Auto_Video_Experience, Temp.WindowsInternetCache, True)
					End If
				Else
					Lbl2.Text = "Skipping Internet Explorer Cache..."
				End If

				[step] += 1
				'			#End Region

			Else
				Scanner.Enabled = False
				[step] = 0

				isRunning(False, "Total Clutter Found: " & ConvertToString(total))
			End If
		End Sub

		Private Sub Deleter_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Deleter.Tick
			'			#Region "Windows Explorer"
			If remove = 1 Then
				If node2.Checked = True Then
					Lbl2.Text = "Removing Recent Documents..."
					Delete.Files.ToString(Locations.Recent_Documents)
				End If

				remove += 1
			End If

			If remove = 2 Then
				If node3.Checked = True Then
					Lbl2.Text = "Removing Thumnail Cache..."
					Delete.Files.ToString(Locations.Thumnail_Cache)
				End If

				remove += 1
			End If

			If remove = 3 Then
				If node4.Checked = True Then
					Lbl2.Text = "Removing Mini Dumps..."
					Delete.Files.ToString(Locations.Mini_Dumps)
				End If

				remove += 1
			End If

			If remove = 4 Then
				If node15.Checked = True Then
					Lbl2.Text = "Removing Windows Temporary Files......"
					Delete.Files.ToString(Locations.Win_Temp_Files)
				End If

				remove += 1
			End If
			'			#End Region

			'			#Region "System"
			If remove = 5 Then
				If node6.Checked = True Then
					Lbl2.Text = "Emptying Recylce Bin..."
					Delete.Files.ToString(Locations.Recyle_Bin)
				End If

				remove += 1
			End If

			If remove = 6 Then
				If node7.Checked = True Then
					Lbl2.Text = "Removing System Temporary Files..."
					Delete.Files.ToString(Locations.Temp_Files)
				End If

				remove += 1
			End If

			If remove = 7 Then
				If node8.Checked = True Then
					Lbl2.Text = "Removing Memory Dumps..."
					Delete.Files.ToString(Locations.Memory_Dumps)
				End If

				remove += 1
			End If

			If remove = 8 Then
				If node9.Checked = True Then
					Lbl2.Text = "Removing Windows Log Files..."
					Delete.Logs(Locations.WinLogs)
					Delete.Files.ToString(Locations.WinLogs1)
					Delete.Files.ToString(Locations.WinLogs2)
					Delete.Files.ToString(Locations.WinLogs3)
					Delete.Files.ToString(Locations.WinLogs4)
					Delete.Files.ToString(Locations.WinLogs5)
					Delete.Files.ToString(Locations.WinLogs6)
					Delete.Files.ToString(Locations.WinLogs7)
					Delete.Files.ToString(Locations.WinLogs8)
					Delete.Files.ToString(Locations.WinLogs9)
					Delete.Logs(Locations.WinLogs10)
					Delete.Files.ToString(Locations.WinLogs11)
					Delete.Logs(Locations.WinLogs12)
					Delete.Logs(Locations.WinLogs13)
					Delete.Logs(Locations.WinLogs14)
					Delete.Logs(Locations.WinLogs15)
					Delete.Logs(Locations.WinLogs16)
					Delete.Logs(Locations.WinLogs17)
					Delete.Logs(Locations.WinLogs18)
					Delete.Logs(Locations.WinLogs19)
					Delete.Logs(Locations.WinLogs20)
					Delete.Logs(Locations.WinLogs21)
					Delete.Logs(Locations.WinLogs22)
					Delete.Logs(Locations.WinLogs23)
					Delete.Logs(Locations.WinLogs24)
					Delete.Logs(Locations.WinLogs25)
					Delete.Logs(Locations.WinLogs26)
					Delete.Logs(Locations.WinLogs27)
					Delete.Logs(Locations.WinLogs28)
					Delete.Logs(Locations.WinLogs29)
					Delete.Logs(Locations.WinLogs30)
					Delete.Logs(Locations.WinLogs31)
					Delete.Logs(Locations.WinLogs32)
					Delete.Logs(Locations.WinLogs33)
					Delete.Files.ToString(Locations.WinLogs34)
					Delete.Files.ToString(Locations.WinLogs35)
					Delete.Files.ToString(Locations.WinLogs36)
					Delete.Files.ToString(Locations.WinLogs37)
					Delete.Files.ToString(Locations.WinLogs38)
					Delete.Files.ToString(Locations.WinLogs39)
					Delete.Files.ToString(Locations.WinLogs40)
				End If

				remove += 1
			End If

			If remove = 9 Then
				If node10.Checked = True Then
					Lbl2.Text = "Removing Event Trace Logs..."
					Delete.Etl(Locations.WinLogs1)
					Delete.Etl(Locations.WinLogs2)
					Delete.Etl(Locations.WinLogs3)
					Delete.Etl(Locations.WinLogs4)
					Delete.Etl(Locations.WinLogs5)
					Delete.Etl(Locations.WinLogs6)
					Delete.Etl(Locations.WinLogs7)
					Delete.Etl(Locations.WinLogs8)
					Delete.Etl(Locations.WinLogs9)
					Delete.Etl(Locations.WinLogs10)
					Delete.Etl(Locations.WinLogs11)
				End If

				remove += 1
			End If

			If remove = 10 Then
				If node11.Checked = True Then
					Lbl2.Text = "Removing Error Reports..."
					Delete.Files.ToString(Locations.Error_Reports)
					Delete.Files.ToString(Locations.Error_Reports & "\ReportArchive")
					Delete.Files.ToString(Locations.Error_Reports & "\ReportQueue")
					Delete.Files.ToString(Locations.Error_Reports & "\Temp")
				End If

				remove += 1
			End If

			If remove = 11 Then
				If node12.Checked = True Then
					Lbl2.Text = "Removing Driver Installation Log Files..."
					Delete.Single1(Locations.Driver_Installtion & "\setupapi.dev.log")
				End If

				remove += 1
			End If

			If remove = 12 Then
				If node13.Checked = True Then
					Lbl2.Text = "Removing Delivery Optimization Filess..."
					Delete.Files.ToString(Locations.Delivery_Optimization & "\Cache")
					Delete.Logs(Locations.Delivery_Optimization & "\Logs")
				End If

				remove += 1
			End If

			If remove = 13 Then
				If node14.Checked = True Then
					Lbl2.Text = "Removing Network Data..."
					Delete.Files.ToString(Locations.Network_Data & "\Cache")
				End If

				remove += 1
			End If
			'			#End Region

			'			#Region "Advnaced"
			If remove = 14 Then
				If node17.Checked = True Then
					Lbl2.Text = "Removing Prefetch Data..."
					Delete.Files.ToString(Locations.Prefetch)
				End If

				remove += 1
			End If

			If remove = 15 Then
				If node18.Checked = True Then
					Lbl2.Text = "Removing Store Install Service Files..."
					Delete.Files.ToString(Locations.Store_Install_Service)
				End If

				remove += 1
			End If

			If remove = 16 Then
				If node19.Checked = True Then
					Lbl2.Text = "Removing QT Framework..."
					Delete.Files.ToString(Locations.QtFramework)
				End If

				remove += 1
			End If

			If remove = 17 Then
				If node20.Checked = True Then
					Lbl2.Text = "Removing Store Installation Services..."
					Delete.Xml(Locations.Store_Install_Service)
				End If

				remove += 1
			End If

			If remove = 18 Then
				If node21.Checked = True Then
					Lbl2.Text = "Removing Notifications..."
					Delete.Files.ToString(Locations.Notifications)
				End If

				remove += 1
			End If

			If remove = 19 Then
				If node22.Checked = True Then
					Lbl2.Text = "Removing History..."
					Delete.Edb(Locations.MS_Search)
					Delete.Crwl(Locations.MS_Search2)
					Delete.Files.ToString(Locations.MS_Search)
					Delete.Files.ToString(Locations.MS_Search2)
					Delete.Files.ToString(Locations.MS_Search3)
					Delete.Files.ToString(Locations.MS_Search4)
					Delete.Files.ToString(Locations.MS_Search5)
				End If

				remove += 1
			End If

			If remove = 20 Then
				If node23.Checked = True Then
					Lbl2.Text = "Removing Jump List Data..."
					Delete.Files.ToString(Locations.Jump_List)
				End If

				remove += 1
			End If

			If remove = 21 Then
				If node24.Checked = True Then
					Lbl2.Text = "Removing Font Cache..."
					Delete.Dat(Locations.Font_Cache)
				End If

				remove += 1
			End If

			'			#End Region

			'			#Region "Applications"
			If remove = 22 Then
				If node26.Checked = True Then
					Lbl2.Text = "Removing Windows Defender Files..."

					Delete.Files.ToString(Locations.Win_Defender)
					Delete.Logs(Locations.Win_Defender2)
					Delete.Files.ToString(Locations.Win_Defender3)
					Delete.Files.ToString(Locations.Win_Defender4)
					Delete.Files.ToString(Locations.Win_Defender5)
					Delete.Files.ToString(Locations.Win_Defender6)
					Delete.Files.ToString(Locations.Win_Defender7 & "\Quick")
					Delete.Files.ToString(Locations.Win_Defender7 & "\Resource")
				End If

				remove += 1
			End If

			If remove = 23 Then
				If node27.Checked = True Then
					Lbl2.Text = "Removing Origin Installation Files..."
					Delete.Files.ToString(Locations.Origin_Installers)
				End If

				remove += 1
			End If

			If remove = 24 Then
				If node28.Checked = True Then
					Lbl2.Text = "Removing Visual Studio Installations..."
					Delete.Files.ToString(Locations.Visual_Studio)
				End If

				remove += 1
			End If

			If remove = 25 Then
				If node29.Checked = True Then
					Lbl2.Text = "Removing One Drive Logs..."
					Delete.Files.ToString(Locations.One_Drive)
					Delete.Logs(Locations.One_Drive2)
					Delete.Files.ToString(Locations.One_Drive3)
				End If

				remove += 1
			End If

			If remove = 26 Then
				If node30.Checked = True Then
					Lbl2.Text = "Removing Easy Anti Cheat Logs..."
					Delete.Logs(Locations.Easy_AntiCheat)
				End If

				remove += 1
			End If

			If remove = 27 Then
				If node31.Checked = True Then
					Lbl2.Text = "Removing Battlenet Files..."
					Delete.Files.ToString(Locations.Battlenet)
					Delete.Files.ToString(Locations.Battlenet2)
					Delete.Files.ToString(Locations.Battlenet3)
					Delete.Files.ToString(Locations.Battlenet4)
					Delete.Files.ToString(Locations.Battlenet5)
				End If

				remove += 1
			End If

			If remove = 28 Then
				If node32.Checked = True Then
					Lbl2.Text = "Removing CCleaner Logs..."
					Delete.Logs(Locations.Ccleaner)
				End If

				remove += 1
			End If

			If remove = 29 Then
				If node33.Checked = True Then
					Lbl2.Text = "Removing Steam Logs..."
					Delete.Logs(Locations.Steam)
					Delete.Files.ToString(Locations.Steam2)
					Delete.Files.ToString(Locations.Steam3)
				End If

				remove += 1
			End If
			'			#End Region

			'			#Region "Windows"
			If remove = 30 Then
				If node35.Checked = True Then
					Lbl2.Text = "Removing DirectX Shader Cache..."
					Delete.Files.ToString(Locations.DirectX)
					Delete.Files.ToString(Locations.DirectX2)
				End If

				remove += 1
			End If

			If remove = 31 Then
				If node36.Checked = True Then
					Lbl2.Text = "Removing Windows Update Files..."
					Delete.Files.ToString(Locations.Windows_Update)
				End If

				remove += 1
			End If

			If remove = 32 Then
				If node37.Checked = True Then
					Lbl2.Text = "Removing Windows Font Cache..."
					Delete.Single1(Locations.Windows_Font_Cache)
				End If

				remove += 1
			End If

			If remove = 33 Then
				If node38.Checked = True Then
					Lbl2.Text = "Removing Windows Debug Files..."
					Delete.Logs(Locations.Windows_Debug)
				End If

				remove += 1
			End If

			If remove = 34 Then
				If node39.Checked = True Then
					Lbl2.Text = "Removing Windows Cache..."
					Delete.Files.ToString(Locations.Windows_Cache)
					Delete.Files.ToString(Locations.Windows_Cache2)
					Delete.Files.ToString(Locations.Windows_Cache3)
					Delete.Files.ToString(Locations.Windows_Cache4)
					Delete.Files.ToString(Locations.Windows_Cache5)
				End If

				remove += 1
			End If

			If remove = 35 Then
				If node40.Checked = True Then
					Lbl2.Text = "Removing Windows Installation Data..."
					Delete.Files.ToString(Locations.Windows_Installer)
				End If

				remove += 1
			End If

			If remove = 36 Then
				If node41.Checked = True Then
					Lbl2.Text = "Removing Windows Experience Files..."
					Delete.Logs(Locations.Windows_Experience)
					Delete.Files.ToString(Locations.Windows_Experience2)
				End If

				remove += 1
			End If

			If remove = 37 Then
				If node42.Checked = True Then
					Lbl2.Text = "Removing Auto and Video Experience..."
					Delete.Dat(Locations.Windows_Auto_Video_Experience)
				End If

				remove += 1
			End If

			If remove = 38 Then
				If node66.Checked = True Then
					Lbl2.Text = "Removing Internet Explorer Cache..."
					Delete.Files.ToString(Locations.Windows_Internet_Cache)
				End If

				remove += 1
			End If
			'			#End Region

			'			#Region "Edge Chromium"
			If remove = 39 Then
				If node44.Checked = True Then
					Lbl2.Text = "Removing Edge Chromium Internet Cache..."
					Utils.KillProcess("msedge")

					Delete.Files.ToString(Locations.Edge_Cache)
					Delete.Files.ToString(Locations.Edge_Cache2)
					Delete.Files.ToString(Locations.Edge_Cache3)
					Delete.Files.ToString(Locations.Edge_Cache4)
					Delete.Files.ToString(Locations.Edge_Cache5)
					Delete.Files.ToString(Locations.Edge_Cache6)
					Delete.Files.ToString(Locations.Edge_Cache7)
					Delete.Files.ToString(Locations.Edge_Cache8)
					Delete.Files.ToString(Locations.Edge_Cache9)
					Delete.Files.ToString(Locations.Edge_Cache10)

					Delete.Single1(Locations.Edge_Cache11)
					Delete.Single1(Locations.Edge_Cache12)
					Delete.Single1(Locations.Edge_Cache13)
					Delete.Single1(Locations.Edge_Cache14)
					Delete.Single1(Locations.Edge_Cache15)
					Delete.Single1(Locations.Edge_Cache16)
					Delete.Single1(Locations.Edge_Cache17)
					Delete.Single1(Locations.Edge_Cache18)
					Delete.Single1(Locations.Edge_Cache19)
					Delete.Single1(Locations.Edge_Cache20)
					Delete.Single1(Locations.Edge_Cache21)
				End If

				remove += 1
			End If

			If remove = 40 Then
				If node45.Checked = True Then
					Lbl2.Text = "Removing Edge Chromium Internet Cookies..."
					Utils.KillProcess("msedge")

					Delete.Files.ToString(Locations.Edge_Cookies)
					Delete.Single1(Locations.Edge_Cookies1)
				End If

				remove += 1
			End If

			If remove = 41 Then
				If node46.Checked = True Then
					Lbl2.Text = "Removing Edge Chromium Internet History..."
					Utils.KillProcess("msedge")

					Delete.Single1(Locations.Edge_History)
					Delete.Single1(Locations.Edge_History2)
					Delete.Single1(Locations.Edge_History3)
					Delete.Single1(Locations.Edge_History4)
					Delete.Single1(Locations.Edge_History5)
					Delete.Single1(Locations.Edge_History6)
					Delete.Single1(Locations.Edge_History7)
					Delete.Single1(Locations.Edge_History8)
					Delete.Single1(Locations.Edge_History9)
					Delete.Single1(Locations.Edge_History10)
					Delete.Single1(Locations.Edge_History11)
					Delete.Single1(Locations.Edge_History12)
					Delete.Single1(Locations.Edge_History13)
					Delete.Single1(Locations.Edge_History14)
				End If

				remove += 1
			End If

			If remove = 42 Then
				If node47.Checked = True Then
					Lbl2.Text = "Removing Edge Chromium Session Data..."
					Utils.KillProcess("msedge")
					'Delete.Total_Deleted()
					Delete.Files.ToString(Locations.Edge_Session)
					Delete.Files.ToString(Locations.Edge_Session2)
					Delete.Files.ToString(Locations.Edge_Session3)
				End If

				remove += 1
			End If

			If remove = 43 Then
				If node48.Checked = True Then
					Lbl2.Text = "Removing Edge Chromium Saved Passwords..."
					Utils.KillProcess("msedge")

					Delete.Single1(Locations.Edge_Passwords)
				End If

				remove += 1
			End If

			If remove = 44 Then
				If node49.Checked = True Then
					Lbl2.Text = "Removing Edge Chromium Metrics Temp Data..."
					Utils.KillProcess("msedge")

					Delete.Pma(Locations.Edge_Metrics)
					Delete.Pma(Locations.Edge_Metrics2)
				End If

				remove += 1
			End If
			'			#End Region

			'			#Region "Google Chrome"
			If remove = 45 Then
				If node51.Checked = True Then
					Lbl2.Text = "Removing Google Chrome Internet Cache..."
					Utils.KillProcess("chrome")

					Delete.Files.ToString(Locations.Chrome_Cache)
					Delete.Files.ToString(Locations.Chrome_Cache2)
					Delete.Files.ToString(Locations.Chrome_Cache3)
					Delete.Files.ToString(Locations.Chrome_Cache4)
					Delete.Files.ToString(Locations.Chrome_Cache5)
					Delete.Files.ToString(Locations.Chrome_Cache6)
					Delete.Files.ToString(Locations.Chrome_Cache7)
					Delete.Files.ToString(Locations.Chrome_Cache8)
					Delete.Files.ToString(Locations.Chrome_Cache9)
					Delete.Files.ToString(Locations.Chrome_Cache10)
					Delete.Files.ToString(Locations.Chrome_Cache11)
					Delete.Files.ToString(Locations.Chrome_Cache12)

					Delete.Single1(Locations.Chrome_Cache13)
					Delete.Single1(Locations.Chrome_Cache14)
					Delete.Single1(Locations.Chrome_Cache15)
					Delete.Single1(Locations.Chrome_Cache16)
					Delete.Single1(Locations.Chrome_Cache17)
					Delete.Single1(Locations.Chrome_Cache18)
					Delete.Single1(Locations.Chrome_Cache19)
					Delete.Single1(Locations.Chrome_Cache20)
					Delete.Single1(Locations.Chrome_Cache21)
					Delete.Single1(Locations.Chrome_Cache22)
				End If

				remove += 1
			End If

			If remove = 46 Then
				If node52.Checked = True Then
					Lbl2.Text = "Removing Google Chrome Internet History..."
					Utils.KillProcess("chrome")

					Delete.Single1(Locations.Chrome_History)
					Delete.Single1(Locations.Chrome_History2)
					Delete.Single1(Locations.Chrome_History3)
					Delete.Single1(Locations.Chrome_History4)
					Delete.Single1(Locations.Chrome_History5)
					Delete.Single1(Locations.Chrome_History6)
					Delete.Single1(Locations.Chrome_History7)
					Delete.Single1(Locations.Chrome_History8)
					Delete.Files.ToString(Locations.Chrome_History9)
				End If

				remove += 1
			End If

			If remove = 47 Then
				If node53.Checked = True Then
					Lbl2.Text = "Removing Google Chrome Internet Cookies..."
					Utils.KillProcess("chrome")

					Delete.Files.ToString(Locations.Chrome_Cookies)
					Delete.Single1(Locations.Chrome_Cookies2)
				End If

				remove += 1
			End If

			If remove = 48 Then
				If node54.Checked = True Then
					Lbl2.Text = "Removing Google Chrome Internet Download Data..."
					Utils.KillProcess("chrome")

					Delete.Single1(Locations.Chrome_Download)
				End If

				remove += 1
			End If

			If remove = 49 Then
				If node55.Checked = True Then
					Lbl2.Text = "Removing Google Chrome Metrics Temp Data..."
					Utils.KillProcess("chrome")

					Delete.Pma(Locations.Chrome_Metrics)
				End If

				remove += 1
			End If

			If remove = 50 Then
				If node56.Checked = True Then
					Lbl2.Text = "Removing Google Chrome Session Data..."
					Utils.KillProcess("chrome")

					Delete.Files.ToString(Locations.Chrome_Session)
					Delete.Files.ToString(Locations.Chrome_Session2)
					Delete.Files.ToString(Locations.Chrome_Session3)
				End If

				remove += 1
			End If

			If remove = 51 Then
				If node57.Checked = True Then
					Lbl2.Text = "Removing Google Chrome Saved Passwords..."
					Utils.KillProcess("chrome")

					Delete.Single1(Locations.Chrome_Passwords)
				End If

				remove += 1
			End If
			'			#End Region

			'			#Region "Firefox"
			If remove = 52 Then
				If node59.Checked = True Then
					Lbl2.Text = "Removing Firefox Internet Cache..."
					Utils.KillProcess("firefox")

					Delete.Files.ToString(Locations.Firefox_Cache)
					Delete.Files.ToString(Locations.Firefox_Cache2)
					Delete.Files.ToString(Locations.Firefox_Cache3)
					Delete.Files.ToString(Locations.Firefox_Cache4)
					Delete.Files.ToString(Locations.Firefox_Cache5)
				End If

				remove += 1
			End If

			If remove = 53 Then
				If node60.Checked = True Then
					Lbl2.Text = "Removing Firefox Internet History..."
					Utils.KillProcess("firefox")

					Delete.Files.ToString(Locations.Firefox_History)
				End If

				remove += 1
			End If

			If remove = 54 Then
				If node61.Checked = True Then
					Lbl2.Text = "Removing Firefox Internet Cookies..."
					Utils.KillProcess("firefox")

					Delete.Files.ToString(Locations.Firefox_Cookies)
				End If

				remove += 1
			End If

			If remove = 55 Then
				If node62.Checked = True Then
					Lbl2.Text = "Removing Firefox Session Data..."
					Utils.KillProcess("firefox")

					Delete.Files.ToString(Locations.Firefox_Session)
					Delete.Single1(Locations.Firefox_Session2)
				End If

				remove += 1
			End If

			If remove = 56 Then
				If node63.Checked = True Then
					Lbl2.Text = "Removing Firefox Site Preferences..."
					Utils.KillProcess("firefox")

					Delete.Single1(Locations.Firefox_Site_Pref)
				End If

				remove += 1
			End If

			If remove = 57 Then
				If node64.Checked = True Then
					Lbl2.Text = "Removing Firefox Saved Passwords..."
					Utils.KillProcess("firefox")

					Delete.Single1(Locations.Firefox_Saved_Form)
				End If

				remove += 1
			End If

			If remove = 58 Then
				If node65.Checked = True Then
					Lbl2.Text = "Removing Firefox Saved Passwords..."
					Utils.KillProcess("firefox")

					Delete.Single1(Locations.Firefox_Login)
					Delete.Single1(Locations.Firefox_Login2)
				End If

				remove += 1
				'			#End Region

			Else
				Deleter.Enabled = False
				remove = 0

#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
				If My.Settings.Default.CloseAfterClean Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
					Process.Start(Utils.path & "delete_logs.txt")
					Application.Exit()
				ElseIf My.Settings.Default.ShowReadOnly Then
					Analyze.PerformClick()
				ElseIf Not My.Settings.Default.ShowReadOnly Then
					List.Items.Clear()

					Dim data As List(Of String) = File.ReadAllLines(Utils.path & "delete_logs.txt").ToList()

					For Each d As String In data
						Dim items() As String = d.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)

						Dim listViewItem = New ListViewItem(items)
						listViewItem.ImageIndex = 9
						List.Items.Add(listViewItem)
					Next d
				End If

				isRunning(False, "Total Clutter Removed: " & ConvertToString(Remover.Delete.Total_Deleted))
			End If
		End Sub
#End Region
	End Class
End Namespace
