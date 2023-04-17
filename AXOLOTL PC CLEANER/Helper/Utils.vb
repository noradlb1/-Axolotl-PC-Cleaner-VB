Imports Microsoft.Win32
Imports System
Imports System.Diagnostics
Imports System.DirectoryServices.AccountManagement
Imports System.IO
Imports System.Linq
Imports System.Management
Imports System.Runtime.ConstrainedExecution
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Windows.Forms

Namespace AXOLOTL_PC_CLEANER.Helper
	Friend Class Utils
		Public Shared Function IsFileLocked(ByVal file As FileInfo) As Boolean
			Dim stream As FileStream = Nothing

			Try
				stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None)
			Catch e1 As IOException
				Return True
			Finally
				If stream IsNot Nothing Then
					stream.Close()
				End If
			End Try

			Return False
		End Function

		Private Shared random As New Random()

		Public Shared Function RandomString(ByVal length As Integer) As String
			Const chars As String = "abcdefghijklmnopqrstuvwxyz0123456789"
			Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
		End Function

		Public Shared path As String = "C:\Users\" & Environment.UserName & "\AppData\Local\Axolotl_Software"

		Public Shared Sub Logger(ByVal lines As String)
			Try
				Dim file As New System.IO.StreamWriter(path & "delete" & "_logs.txt", True)

				file.WriteLine(lines)
				file.Close()
			Catch e1 As Exception
			End Try
		End Sub

		Public Shared Sub RemoveDeleteLogs()
			For Each file As String In Directory.GetFiles(path, "*.txt").Where(Function(item) item.EndsWith(".txt"))
				System.IO.File.Delete(file)
			Next file
		End Sub

		Public Shared Sub KillProcess(ByVal Proc As String)
			Dim workers() As Process = Process.GetProcessesByName(Proc)

			For Each worker As Process In workers
				Try
					worker.Kill()
				Catch
				End Try
			Next worker
		End Sub

		Public Shared Sub UsernameSid()
			My.Settings.Default.Sid = UserPrincipal.Current.Sid.ToString()
			My.Settings.Default.Save()
		End Sub

		Public Shared Sub ReturnSystem()
			If My.Settings.Default.Windows = "" Then
				Dim name = ( _
				    From x In (New ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem")).Get().Cast(Of ManagementObject)() _
				    Select x.GetPropertyValue("Caption")).FirstOrDefault()

				My.Settings.Default.Windows = name.ToString()

				My.Settings.Default.Save()
			End If

			If My.Settings.Default.Cpu = "" Then
				Dim mos As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")
				For Each mo As ManagementObject In mos.Get()
					My.Settings.Default.Cpu = mo("Name").ToString()

					My.Settings.Default.Save()
				Next mo
			End If

			If My.Settings.Default.Ram = "" Then
				Dim Query As String = "SELECT MaxCapacity FROM Win32_PhysicalMemoryArray"
				Dim searcher As New ManagementObjectSearcher(Query)
				For Each WniPART As ManagementObject In searcher.Get()
					Dim SizeinKB As UInt32 = Convert.ToUInt32(WniPART.Properties("MaxCapacity").Value)
					Dim SizeinMB As UInt32 = SizeinKB \ 1024
					Dim SizeinGB As UInt32 = SizeinMB \ 1024

					My.Settings.Default.Ram = SizeinGB.ToString()

					My.Settings.Default.Save()
				Next WniPART
			End If

			If My.Settings.Default.Gpu = "" Then
				Using searcher1 = New ManagementObjectSearcher("select * from Win32_VideoController")
					For Each obj As ManagementObject In searcher1.Get()
						My.Settings.Default.Gpu = obj("Name").ToString()
					Next obj
				End Using

				My.Settings.Default.Save()
			End If
		End Sub

		<ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail), DllImport("kernel32.dll", CharSet := CharSet.Auto, SetLastError := True)> _
		Private Shared Function GetModuleHandle(ByVal moduleName As String) As IntPtr
		End Function

		<DllImport("kernel32.dll", CharSet := CharSet.Auto, SetLastError := True)> _
		Friend Shared Function GetCurrentProcess() As IntPtr
		End Function

		<DllImport("kernel32.dll", CharSet := CharSet.Ansi, SetLastError := True, ExactSpelling := True)> _
		Private Shared Function GetProcAddress(ByVal hModule As IntPtr, ByVal methodName As String) As IntPtr
		End Function

		<DllImport("kernel32.dll", SetLastError:=True)>
		Friend Shared Function IsWow64Process(<[In]> ByVal hSourceProcessHandle As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByRef isWow64 As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Function

		<SecurityCritical> _
		Friend Shared Function DoesWin32MethodExist(ByVal moduleName As String, ByVal methodName As String) As Boolean
			Dim moduleHandle As IntPtr = GetModuleHandle(moduleName)
			If moduleHandle = IntPtr.Zero Then
				Return False
			End If
			Return (GetProcAddress(moduleHandle, methodName) <> IntPtr.Zero)
		End Function

		<SecuritySafeCritical> _
		Public Shared Function get_Is64BitOperatingSystem() As Boolean
			Dim flag As Boolean
			Return (IntPtr.Size = 8) OrElse ((DoesWin32MethodExist("kernel32.dll", "IsWow64Process") AndAlso IsWow64Process(GetCurrentProcess(), flag)) AndAlso flag)
		End Function

		Public Shared Sub SetStartup(ByVal enable As Boolean)
			Dim key As RegistryKey

			If enable Then
				If get_Is64BitOperatingSystem() Then
					Try
						key = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run", True)
						key.SetValue("Axolotl", """" & Application.ExecutablePath & """")
						key.Close()
					Catch
					End Try
				Else
					Try
						key = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
						key.SetValue("Axolotl", """" & Application.ExecutablePath & """")
						key.Close()
					Catch
					End Try
				End If
			ElseIf Not enable Then
				If get_Is64BitOperatingSystem() Then
					Try
						key = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run", True)
						key.DeleteValue("Axolotl", False)
						key.Close()
					Catch
					End Try
				Else
					key = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
					key.DeleteValue("Axolotl", False)
					key.Close()
				End If
			End If
		End Sub
	End Class
End Namespace
