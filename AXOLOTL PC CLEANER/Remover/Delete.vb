Imports AXOLOTL_PC_CLEANER.Calculations
Imports AXOLOTL_PC_CLEANER.Helper
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports AXOLOTL_PC_CLEANER.Remover
Imports AXOLOTL_PC_CLEANER.Calculations.Size

Namespace AXOLOTL_PC_CLEANER.Remover
	Friend Class Delete
		Public Shared Total_Deleted As Long
		Public Shared Files As Long


		Class SurroundingClass
			<Obsolete>
			Public Shared Sub Files(ByVal Location As String, ByVal both As Boolean)
				Dim di As System.IO.DirectoryInfo = New DirectoryInfo(Location)

				Try

					For Each file As FileInfo In di.GetFiles()

						Try
							file.Delete()
							Total_Deleted = Total_Deleted + file.Length
							Utils.Logger(file.FullName & "," + Size.ConvertToString(file.Length))
						Catch
							Total_Deleted = Total_Deleted + 0
						End Try
					Next

				Catch
				End Try

				If both = True Then

					Try

						For Each dir As DirectoryInfo In di.GetDirectories()

							Try
								dir.Delete(True)
								Total_Deleted = CSharpImpl.__Assign(Total_Deleted, Calculations.Size.DirectorySize(dir, True))
								Utils.Logger(dir.FullName & CLng(",") + Calculations.Size.DirectorySize(dir, True))
							Catch
								Total_Deleted = Total_Deleted + 0
							End Try
						Next

					Catch
					End Try
				End If
			End Sub

			Private Class CSharpImpl
				<Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
				Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
					target = value
					Return value
				End Function
			End Class
		End Class
		Public Shared Sub Single1(ByVal Location As String)
			If File.Exists(Location) Then

				Try
					System.IO.File.Delete(Location)
					Dim file As String = Location
					Total_Deleted = Total_Deleted + file.Length
					Utils.Logger(file & "," & Size.ConvertToString(file.Length))
				Catch
					Total_Deleted = Total_Deleted + 0
				End Try
			End If
		End Sub

		Public Shared Sub Logs(ByVal Location As String)
			Try
				For Each file As String In Directory.GetFiles(Location, "*.log").Where(Function(item) item.EndsWith(".log"))
					Try
						System.IO.File.Delete(file)
						Total_Deleted = Total_Deleted + file.Length
						Utils.Logger(file & "," & Size.ConvertToString(file.Length))
					Catch
						Total_Deleted = Total_Deleted + 0
					End Try
				Next file
			Catch

			End Try
		End Sub

		Public Shared Sub Etl(ByVal Location As String)
			Try
				For Each file As String In Directory.GetFiles(Location, "*.etl").Where(Function(item) item.EndsWith(".etl"))
					Try
						System.IO.File.Delete(file)
						Total_Deleted = Total_Deleted + file.Length
						Utils.Logger(file & "," & Size.ConvertToString(file.Length))
					Catch
						Total_Deleted = Total_Deleted + 0
					End Try
				Next file
			Catch

			End Try
		End Sub

		Public Shared Sub Xml(ByVal Location As String)
			Try
				For Each file As String In Directory.GetFiles(Location, "*.xml").Where(Function(item) item.EndsWith(".xml"))
					Try
						System.IO.File.Delete(file)
						Total_Deleted = Total_Deleted + file.Length
						Utils.Logger(file & "," & Size.ConvertToString(file.Length))
					Catch
						Total_Deleted = Total_Deleted + 0
					End Try
				Next file
			Catch

			End Try
		End Sub

		Public Shared Sub Edb(ByVal Location As String)
			Try
				For Each file As String In Directory.GetFiles(Location, "*.edb").Where(Function(item) item.EndsWith(".edb"))
					Try
						System.IO.File.Delete(file)
						Total_Deleted = Total_Deleted + file.Length
						Utils.Logger(file & "," & Size.ConvertToString(file.Length))
					Catch
						Total_Deleted = Total_Deleted + 0
					End Try
				Next file
			Catch

			End Try
		End Sub

		Public Shared Sub Crwl(ByVal Location As String)
			Try
				For Each file As String In Directory.GetFiles(Location, "*.crwl").Where(Function(item) item.EndsWith(".crwl"))
					Try
						System.IO.File.Delete(file)
						Total_Deleted = Total_Deleted + file.Length
						Utils.Logger(file & "," & Size.ConvertToString(file.Length))
					Catch
						Total_Deleted = Total_Deleted + 0
					End Try
				Next file
			Catch

			End Try
		End Sub

		Public Shared Sub Dat(ByVal Location As String)
			Try
				For Each file As String In Directory.GetFiles(Location, "*.dat").Where(Function(item) item.EndsWith(".dat"))
					Try
						System.IO.File.Delete(file)
						Total_Deleted = Total_Deleted + file.Length
						Utils.Logger(file & "," & Size.ConvertToString(file.Length))
					Catch
						Total_Deleted = Total_Deleted + 0
					End Try
				Next file
			Catch

			End Try
		End Sub

		Public Shared Sub Pma(ByVal Location As String)
			Try
				For Each file As String In Directory.GetFiles(Location, "*.pma").Where(Function(item) item.EndsWith(".pma"))
					Try
						System.IO.File.Delete(file)
						Total_Deleted = Total_Deleted + file.Length
						Utils.Logger(file & "," & Size.ConvertToString(file.Length))
					Catch
						Total_Deleted = Total_Deleted + 0
					End Try
				Next file
			Catch

			End Try
		End Sub
	End Class
End Namespace
