Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace AXOLOTL_PC_CLEANER.Calculations
	Friend Class Size
		Public Shared Function DirectorySize(ByVal dInfo As DirectoryInfo, ByVal SubDir As Boolean) As Long
			Dim totalSize As Long = dInfo.EnumerateFiles().Sum(Function(file) file.Length)

			If SubDir Then
				totalSize += dInfo.EnumerateDirectories().Sum(Function(dir) DirectorySize(dir, True))
			End If
			Return totalSize
		End Function

		Public Shared Function ConvertToString(ByVal bytecount As Long) As String
'INSTANT VB NOTE: The variable size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim size_Renamed() As String = { "B", "KB", "MB", "GB", "TB" }

			If bytecount = 0 Then
				Return "0" & size_Renamed(0)
			End If

			Dim bytes As Long = Math.Abs(bytecount)
			Dim place As Integer = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)))

			Dim num As Double = Math.Round(bytes / Math.Pow(1024, place), 1)

			Return (Math.Sign(bytecount) * num).ToString() & " " & size_Renamed(place)
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function CheckSize(ByVal location As String, ByVal size_Renamed As Long, ByVal both As Boolean) As Long
			size_Renamed = 0
			Dim Dir = New DirectoryInfo(location)

			If Dir.Exists Then
				If both = True Then
					Try
'INSTANT VB NOTE: The variable dir was renamed since Visual Basic will not allow local variables with the same name as parameters or other local variables:
						For Each dir_Renamed As DirectoryInfo In Dir.GetDirectories()
							Try
								size_Renamed += DirectorySize(dir_Renamed, True)
							Catch
								Return 0
							End Try
						Next dir_Renamed
					Catch
					End Try
				End If

				Try
					For Each filez As FileInfo In Dir.GetFiles()
						Try
							If Helper.Utils.IsFileLocked(filez) = False Then
								If filez.IsReadOnly = False Then
									size_Renamed += filez.Length
								End If
							End If
						Catch

						End Try
					Next filez
				Catch
				End Try
			End If

			Return size_Renamed
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function LogFiles(ByVal location As String, ByVal size_Renamed As Long) As Long
			size_Renamed = 0

			Dim Dir = New DirectoryInfo(location)

			If Dir.Exists Then
				Try
					For Each Filez As FileInfo In Dir.GetFiles("*.log").Where(Function(p) p.Extension = ".log").ToArray()
						Try
							size_Renamed += Filez.Length
						Catch

						End Try
					Next Filez
				Catch

				End Try
			End If

			Return size_Renamed
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function EtlFiles(ByVal location As String, ByVal size_Renamed As Long) As Long
			size_Renamed = 0

			Dim Dir = New DirectoryInfo(location)

			If Dir.Exists Then
				Try
					For Each Filez As FileInfo In Dir.GetFiles("*.etl").Where(Function(p) p.Extension = ".etl").ToArray()
						Try
							size_Renamed += Filez.Length
						Catch

						End Try
					Next Filez
				Catch

				End Try
			End If

			Return size_Renamed
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function XmlFiles(ByVal location As String, ByVal size_Renamed As Long) As Long
			size_Renamed = 0

			Dim Dir = New DirectoryInfo(location)

			If Dir.Exists Then
				Try
					For Each Filez As FileInfo In Dir.GetFiles("*.xml").Where(Function(p) p.Extension = ".xml").ToArray()
						Try
							size_Renamed += Filez.Length
						Catch

						End Try
					Next Filez
				Catch

				End Try
			End If

			Return size_Renamed
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function EdbFiles(ByVal location As String, ByVal size_Renamed As Long) As Long
			size_Renamed = 0

			Dim Dir = New DirectoryInfo(location)

			If Dir.Exists Then
				Try
					For Each Filez As FileInfo In Dir.GetFiles("*.edb").Where(Function(p) p.Extension = ".edb").ToArray()
						Try
							size_Renamed += Filez.Length
						Catch

						End Try
					Next Filez
				Catch

				End Try
			End If

			Return size_Renamed
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function CrwlFiles(ByVal location As String, ByVal size_Renamed As Long) As Long
			size_Renamed = 0

			Dim Dir = New DirectoryInfo(location)

			If Dir.Exists Then
				Try
					For Each Filez As FileInfo In Dir.GetFiles("*.crwl").Where(Function(p) p.Extension = ".crwl").ToArray()
						Try
							size_Renamed += Filez.Length
						Catch

						End Try
					Next Filez
				Catch

				End Try
			End If

			Return size_Renamed
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function PmaFiles(ByVal location As String, ByVal size_Renamed As Long) As Long
			size_Renamed = 0

			Dim Dir = New DirectoryInfo(location)

			If Dir.Exists Then
				Try
					For Each Filez As FileInfo In Dir.GetFiles("*.pma").Where(Function(p) p.Extension = ".pma").ToArray()
						Try
							size_Renamed += Filez.Length
						Catch

						End Try
					Next Filez
				Catch

				End Try
			End If

			Return size_Renamed
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function DatFiles(ByVal location As String, ByVal size_Renamed As Long) As Long
			size_Renamed = 0

			Dim Dir = New DirectoryInfo(location)

			If Dir.Exists Then
				Try
					For Each Filez As FileInfo In Dir.GetFiles("*.dat").Where(Function(p) p.Extension = ".dat").ToArray()
						Try
							size_Renamed += Filez.Length
						Catch

						End Try
					Next Filez
				Catch

				End Try
			End If

			Return size_Renamed
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function CatalogFiles(ByVal location As String, ByVal size_Renamed As Long) As Long
			size_Renamed = 0

			Dim Dir = New DirectoryInfo(location)

			If Dir.Exists Then
				Try
					For Each Filez As FileInfo In Dir.GetFiles("*.catalogItem").Where(Function(p) p.Extension = ".catalogItem").ToArray()
						Try
							size_Renamed += Filez.Length
						Catch

						End Try
					Next Filez
				Catch

				End Try
			End If

			Return size_Renamed
		End Function

'INSTANT VB NOTE: The parameter size was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Public Shared Function CheckSingle(ByVal location As String, ByVal size_Renamed As Long) As Long
			size_Renamed = 0

			If File.Exists(location) Then
				Try
				Return (New FileInfo(location)).Length
			Catch
			End Try
			End If

			Return size_Renamed
		End Function
	End Class
End Namespace
