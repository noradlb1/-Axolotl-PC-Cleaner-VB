Imports Microsoft.Win32
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace AXOLOTL_PC_CLEANER
	Partial Public Class Settings
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			startup.Checked = My.Settings.Default.Startup
			minimized.Checked = My.Settings.Default.Minimized
			expandall.Checked = My.Settings.Default.ExpandAll
			rescan.Checked = My.Settings.Default.ShowReadOnly
			showwindows.Checked = My.Settings.Default.ShowWindows
			showadvanced.Checked = My.Settings.Default.ShowAdvanced
			showapps.Checked = My.Settings.Default.ShowApps
			closeafter.Checked = My.Settings.Default.CloseAfterClean
			edge.Checked = My.Settings.Default.ShowEdge
			chrome.Checked = My.Settings.Default.ShowChrome
			firefox.Checked = My.Settings.Default.ShowFirefox
			guna2TextBox1.Text = My.Settings.Default.FirefoxPath
		End Sub

		Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			My.Settings.Default.Startup = startup.Checked
			My.Settings.Default.Minimized = minimized.Checked
			My.Settings.Default.ExpandAll = expandall.Checked
			My.Settings.Default.ShowReadOnly = rescan.Checked
			My.Settings.Default.ShowWindows = showwindows.Checked
			My.Settings.Default.ShowAdvanced = showadvanced.Checked
			My.Settings.Default.ShowApps = showapps.Checked
			My.Settings.Default.CloseAfterClean = closeafter.Checked
			My.Settings.Default.ShowEdge = edge.Checked
			My.Settings.Default.ShowChrome = chrome.Checked
			My.Settings.Default.ShowFirefox = firefox.Checked

			My.Settings.Default.Save()
		End Sub

		Private Sub msg1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg1.Click
			MessageBox.Show("This features enables Axolotl Cleaner to run and Winodws startup.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg2.Click
			MessageBox.Show("This features allows the cleaner to be minimized to tray on load.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg3.Click
			MessageBox.Show("Expand all options on application load.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg4.Click
			MessageBox.Show("If enabled after cleaning the rescan will appear displaying read only items, if not the cleaner will display a list of deleted items.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg5.Click
			MessageBox.Show("Enable Windows options on main form on load.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg6.Click
			MessageBox.Show("Enabled advanced options on main form on load.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg7.Click
			MessageBox.Show("Enable application options on main form on load.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg8.Click
			MessageBox.Show("When the cleaning process has been completed the Axolotl will close and a log file will be displayed.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg9.Click
			MessageBox.Show("Show Edge Chromium privacy options, on the main form.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg10.Click
			MessageBox.Show("Show Google Chrome privacy options, on the main form.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg11.Click
			MessageBox.Show("Show Firefox privacy options, on the main form.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub msg12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg12.Click
			MessageBox.Show("Click the go to path button on the right." & ControlChars.Lf & "Once you are there copy the folder name that ends with release." & ControlChars.Lf & "Paste the folder name into the textbox and click save!" & ControlChars.Lf & ControlChars.Lf & "If you don't do this you will have trouble cleaning and scanning Firefox information...", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub guna2Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles guna2Button3.Click
			My.Settings.Default.FirefoxPath = guna2TextBox1.Text
			My.Settings.Default.Save()

			MessageBox.Show("Firefox path has now been updated!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub guna2Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles guna2Button2.Click
			Process.Start("C:\Users\" & Environment.UserName & "\AppData\Local\Mozilla\Firefox\Profiles\")
		End Sub

		Private Sub startup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles startup.CheckedChanged
			If startup.Checked = True Then
				Helper.Utils.SetStartup(True)
			ElseIf startup.Checked = False Then
				Helper.Utils.SetStartup(False)
			End If
		End Sub

		Private Sub Sid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Sidx.Click
			My.Settings.Default.Sid = ""
			My.Settings.Default.Save()
		End Sub

		Private Sub Cpu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cpux.Click
			My.Settings.Default.Cpu = ""
			My.Settings.Default.Save()
		End Sub

		Private Sub System_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Systemx.Click
			My.Settings.Default.Windows = ""
			My.Settings.Default.Save()
		End Sub

		Private Sub Gpu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Gpux.Click
			My.Settings.Default.Gpu = ""
			My.Settings.Default.Save()
		End Sub

		Private Sub Ram_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Ramx.Click
			My.Settings.Default.Ram = ""
			My.Settings.Default.Save()
		End Sub
	End Class
End Namespace
