Namespace AXOLOTL_PC_CLEANER
	Partial Public Class File_Explorer
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(File_Explorer))
			Me.Viewer = New DevComponents.DotNetBar.Controls.ListViewEx()
			Me.columnHeader1 = (CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader))
			Me.columnHeader2 = (CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader))
			Me.guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
			Me.deleteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.Lbl1 = New System.Windows.Forms.Label()
			Me.style = New DevComponents.DotNetBar.StyleManager(Me.components)
			Me.images = New System.Windows.Forms.ImageList(Me.components)
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.guna2ContextMenuStrip1.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' Viewer
			' 
			Me.Viewer.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.Viewer.BackColor = System.Drawing.Color.White
			' 
			' 
			' 
			Me.Viewer.Border.Class = "ListViewBorder"
			Me.Viewer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.Viewer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.columnHeader1, Me.columnHeader2})
			Me.Viewer.ContextMenuStrip = Me.guna2ContextMenuStrip1
			Me.Viewer.ForeColor = System.Drawing.Color.Black
			Me.Viewer.GridLines = True
			Me.Viewer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
			Me.Viewer.HideSelection = False
			Me.Viewer.Location = New System.Drawing.Point(13, 48)
			Me.Viewer.Name = "Viewer"
			Me.Viewer.Size = New System.Drawing.Size(753, 455)
			Me.Viewer.TabIndex = 4
			Me.Viewer.UseCompatibleStateImageBehavior = False
			Me.Viewer.View = System.Windows.Forms.View.Details
'			Me.Viewer.SelectedIndexChanged += New System.EventHandler(Me.Viewer_SelectedIndexChanged)
'			Me.Viewer.DoubleClick += New System.EventHandler(Me.Viewer_DoubleClick)
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Text = "File Name"
			Me.columnHeader1.Width = 658
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Text = "Size"
			Me.columnHeader2.Width = 94
			' 
			' guna2ContextMenuStrip1
			' 
			Me.guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.deleteFileToolStripMenuItem})
			Me.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1"
			Me.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb((CInt((CByte(151)))), (CInt((CByte(143)))), (CInt((CByte(255)))))
			Me.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
			Me.guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
			Me.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
			Me.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
			Me.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb((CInt((CByte(100)))), (CInt((CByte(88)))), (CInt((CByte(255)))))
			Me.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
			Me.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
			Me.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
			Me.guna2ContextMenuStrip1.Size = New System.Drawing.Size(129, 26)
			' 
			' deleteFileToolStripMenuItem
			' 
			Me.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem"
			Me.deleteFileToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
			Me.deleteFileToolStripMenuItem.Text = "Delete File"
'			Me.deleteFileToolStripMenuItem.Click += New System.EventHandler(Me.deleteFileToolStripMenuItem_Click)
			' 
			' Lbl1
			' 
			Me.Lbl1.AutoSize = True
			Me.Lbl1.BackColor = System.Drawing.Color.Transparent
			Me.Lbl1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Lbl1.ForeColor = System.Drawing.Color.White
			Me.Lbl1.Location = New System.Drawing.Point(12, 9)
			Me.Lbl1.Name = "Lbl1"
			Me.Lbl1.Size = New System.Drawing.Size(305, 17)
			Me.Lbl1.TabIndex = 8
			Me.Lbl1.Text = "These are the files that will be cleaned if selected."
			' 
			' style
			' 
			Me.style.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
			Me.style.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(87)))), (CInt((CByte(154))))))
			' 
			' images
			' 
			Me.images.ImageStream = (DirectCast(resources.GetObject("images.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.images.TransparentColor = System.Drawing.Color.Transparent
			Me.images.Images.SetKeyName(0, "Files.png")
			Me.images.Images.SetKeyName(1, "Folder.png")
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.panel1.Controls.Add(Me.Lbl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(780, 37)
			Me.panel1.TabIndex = 9
			' 
			' File_Explorer
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(780, 513)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.Viewer)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "File_Explorer"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "File Explorer"
'			Me.Load += New System.EventHandler(Me.File_Explorer_Load)
			Me.guna2ContextMenuStrip1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents Viewer As DevComponents.DotNetBar.Controls.ListViewEx
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private Lbl1 As System.Windows.Forms.Label
		Private style As DevComponents.DotNetBar.StyleManager
		Private images As System.Windows.Forms.ImageList
		Private panel1 As System.Windows.Forms.Panel
		Private guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
		Private WithEvents deleteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace