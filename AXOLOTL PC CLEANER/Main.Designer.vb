Namespace AXOLOTL_PC_CLEANER
	Partial Public Class Main
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Main))
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label1 = New System.Windows.Forms.Label()
			Me.Line2 = New System.Windows.Forms.Label()
			Me.Line1 = New System.Windows.Forms.Label()
			Me.TitleLogo = New System.Windows.Forms.PictureBox()
			Me.TitleTxt = New System.Windows.Forms.Label()
			Me.List = New DevComponents.DotNetBar.Controls.ListViewEx()
			Me.columnHeader1 = (CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader))
			Me.columnHeader2 = (CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader))
			Me.Options = New DevComponents.AdvTree.AdvTree()
			Me.images = New System.Windows.Forms.ImageList(Me.components)
			Me.node43 = New DevComponents.AdvTree.Node()
			Me.node44 = New DevComponents.AdvTree.Node()
			Me.node45 = New DevComponents.AdvTree.Node()
			Me.node46 = New DevComponents.AdvTree.Node()
			Me.node47 = New DevComponents.AdvTree.Node()
			Me.node48 = New DevComponents.AdvTree.Node()
			Me.node49 = New DevComponents.AdvTree.Node()
			Me.node50 = New DevComponents.AdvTree.Node()
			Me.node51 = New DevComponents.AdvTree.Node()
			Me.node52 = New DevComponents.AdvTree.Node()
			Me.node53 = New DevComponents.AdvTree.Node()
			Me.node54 = New DevComponents.AdvTree.Node()
			Me.node55 = New DevComponents.AdvTree.Node()
			Me.node56 = New DevComponents.AdvTree.Node()
			Me.node57 = New DevComponents.AdvTree.Node()
			Me.node58 = New DevComponents.AdvTree.Node()
			Me.node59 = New DevComponents.AdvTree.Node()
			Me.node60 = New DevComponents.AdvTree.Node()
			Me.node61 = New DevComponents.AdvTree.Node()
			Me.node62 = New DevComponents.AdvTree.Node()
			Me.node63 = New DevComponents.AdvTree.Node()
			Me.node64 = New DevComponents.AdvTree.Node()
			Me.node65 = New DevComponents.AdvTree.Node()
			Me.node1 = New DevComponents.AdvTree.Node()
			Me.node2 = New DevComponents.AdvTree.Node()
			Me.node3 = New DevComponents.AdvTree.Node()
			Me.node4 = New DevComponents.AdvTree.Node()
			Me.node15 = New DevComponents.AdvTree.Node()
			Me.node5 = New DevComponents.AdvTree.Node()
			Me.node6 = New DevComponents.AdvTree.Node()
			Me.node7 = New DevComponents.AdvTree.Node()
			Me.node8 = New DevComponents.AdvTree.Node()
			Me.node9 = New DevComponents.AdvTree.Node()
			Me.node10 = New DevComponents.AdvTree.Node()
			Me.node11 = New DevComponents.AdvTree.Node()
			Me.node12 = New DevComponents.AdvTree.Node()
			Me.node13 = New DevComponents.AdvTree.Node()
			Me.node14 = New DevComponents.AdvTree.Node()
			Me.node16 = New DevComponents.AdvTree.Node()
			Me.node17 = New DevComponents.AdvTree.Node()
			Me.node18 = New DevComponents.AdvTree.Node()
			Me.node19 = New DevComponents.AdvTree.Node()
			Me.node20 = New DevComponents.AdvTree.Node()
			Me.node21 = New DevComponents.AdvTree.Node()
			Me.node22 = New DevComponents.AdvTree.Node()
			Me.node23 = New DevComponents.AdvTree.Node()
			Me.node24 = New DevComponents.AdvTree.Node()
			Me.node25 = New DevComponents.AdvTree.Node()
			Me.node26 = New DevComponents.AdvTree.Node()
			Me.node27 = New DevComponents.AdvTree.Node()
			Me.node28 = New DevComponents.AdvTree.Node()
			Me.node29 = New DevComponents.AdvTree.Node()
			Me.node30 = New DevComponents.AdvTree.Node()
			Me.node31 = New DevComponents.AdvTree.Node()
			Me.node32 = New DevComponents.AdvTree.Node()
			Me.node33 = New DevComponents.AdvTree.Node()
			Me.node34 = New DevComponents.AdvTree.Node()
			Me.node35 = New DevComponents.AdvTree.Node()
			Me.node36 = New DevComponents.AdvTree.Node()
			Me.node37 = New DevComponents.AdvTree.Node()
			Me.node38 = New DevComponents.AdvTree.Node()
			Me.node39 = New DevComponents.AdvTree.Node()
			Me.node40 = New DevComponents.AdvTree.Node()
			Me.node41 = New DevComponents.AdvTree.Node()
			Me.node42 = New DevComponents.AdvTree.Node()
			Me.node66 = New DevComponents.AdvTree.Node()
			Me.nodeConnector1 = New DevComponents.AdvTree.NodeConnector()
			Me.elementStyle1 = New DevComponents.DotNetBar.ElementStyle()
			Me.style = New DevComponents.DotNetBar.StyleManager(Me.components)
			Me.Lbl1 = New System.Windows.Forms.Label()
			Me.Lbl2 = New System.Windows.Forms.Label()
			Me.Running = New DevComponents.DotNetBar.Controls.CircularProgress()
			Me.Cleaner = New Guna.UI2.WinForms.Guna2Button()
			Me.Analyze = New Guna.UI2.WinForms.Guna2Button()
			Me.Settings = New Guna.UI2.WinForms.Guna2Button()
			Me.Tray = New System.Windows.Forms.NotifyIcon(Me.components)
			Me.Menu = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
			Me.hideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.analyzeFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.aboutAxolotlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.checkForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.Scanner = New System.Windows.Forms.Timer(Me.components)
			Me.Deleter = New System.Windows.Forms.Timer(Me.components)
			Me.panel1.SuspendLayout()
			DirectCast(Me.TitleLogo, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.Options, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Menu.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.Line2)
			Me.panel1.Controls.Add(Me.Line1)
			Me.panel1.Controls.Add(Me.TitleLogo)
			Me.panel1.Controls.Add(Me.TitleTxt)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(864, 58)
			Me.panel1.TabIndex = 0
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.White
			Me.label1.Location = New System.Drawing.Point(458, 7)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(178, 12)
			Me.label1.TabIndex = 6
			Me.label1.Text = "COPYRIGHT © AXOLOTL SOFTWARE 2022"
			' 
			' Line2
			' 
			Me.Line2.AutoSize = True
			Me.Line2.BackColor = System.Drawing.Color.Transparent
			Me.Line2.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Line2.ForeColor = System.Drawing.Color.White
			Me.Line2.Location = New System.Drawing.Point(458, 38)
			Me.Line2.Name = "Line2"
			Me.Line2.Size = New System.Drawing.Size(11, 12)
			Me.Line2.TabIndex = 5
			Me.Line2.Text = "..."
			' 
			' Line1
			' 
			Me.Line1.AutoSize = True
			Me.Line1.BackColor = System.Drawing.Color.Transparent
			Me.Line1.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Line1.ForeColor = System.Drawing.Color.White
			Me.Line1.Location = New System.Drawing.Point(458, 23)
			Me.Line1.Name = "Line1"
			Me.Line1.Size = New System.Drawing.Size(11, 12)
			Me.Line1.TabIndex = 4
			Me.Line1.Text = "..."
			' 
			' TitleLogo
			' 
			Me.TitleLogo.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.TitleLogo.Image = (DirectCast(resources.GetObject("TitleLogo.Image"), System.Drawing.Image))
			Me.TitleLogo.Location = New System.Drawing.Point(310, 4)
			Me.TitleLogo.Name = "TitleLogo"
			Me.TitleLogo.Size = New System.Drawing.Size(50, 50)
			Me.TitleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.TitleLogo.TabIndex = 3
			Me.TitleLogo.TabStop = False
			' 
			' TitleTxt
			' 
			Me.TitleTxt.AutoSize = True
			Me.TitleTxt.BackColor = System.Drawing.Color.Transparent
			Me.TitleTxt.Font = New System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.TitleTxt.ForeColor = System.Drawing.Color.White
			Me.TitleTxt.Location = New System.Drawing.Point(3, 12)
			Me.TitleTxt.Name = "TitleTxt"
			Me.TitleTxt.Size = New System.Drawing.Size(306, 35)
			Me.TitleTxt.TabIndex = 3
			Me.TitleTxt.Text = "AXOLOTL PC CLEANER"
			' 
			' List
			' 
			Me.List.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.List.BackColor = System.Drawing.Color.White
			' 
			' 
			' 
			Me.List.Border.Class = "ListViewBorder"
			Me.List.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.List.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.columnHeader1, Me.columnHeader2})
			Me.List.ForeColor = System.Drawing.Color.Black
			Me.List.GridLines = True
			Me.List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
			Me.List.HideSelection = False
			Me.List.Location = New System.Drawing.Point(280, 97)
			Me.List.Name = "List"
			Me.List.Size = New System.Drawing.Size(568, 385)
			Me.List.TabIndex = 3
			Me.List.UseCompatibleStateImageBehavior = False
			Me.List.View = System.Windows.Forms.View.Details
'			Me.List.DoubleClick += New System.EventHandler(Me.List_DoubleClick)
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Text = "File Name"
			Me.columnHeader1.Width = 473
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Text = "Size"
			Me.columnHeader2.Width = 94
			' 
			' Options
			' 
			Me.Options.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
			Me.Options.AllowDrop = True
			Me.Options.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.Options.BackColor = System.Drawing.SystemColors.Window
			' 
			' 
			' 
			Me.Options.BackgroundStyle.Class = "TreeBorderKey"
			Me.Options.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.Options.ImageList = Me.images
			Me.Options.Location = New System.Drawing.Point(12, 97)
			Me.Options.Name = "Options"
			Me.Options.Nodes.AddRange(New DevComponents.AdvTree.Node() { Me.node43, Me.node50, Me.node58, Me.node1, Me.node5, Me.node16, Me.node25, Me.node34})
			Me.Options.NodesConnector = Me.nodeConnector1
			Me.Options.NodeStyle = Me.elementStyle1
			Me.Options.PathSeparator = ";"
			Me.Options.Size = New System.Drawing.Size(248, 427)
			Me.Options.Styles.Add(Me.elementStyle1)
			Me.Options.TabIndex = 5
			Me.Options.Text = "advTree1"
			' 
			' images
			' 
			Me.images.ImageStream = (DirectCast(resources.GetObject("images.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.images.TransparentColor = System.Drawing.Color.Transparent
			Me.images.Images.SetKeyName(0, "Apps.png")
			Me.images.Images.SetKeyName(1, "Edge Chromium.png")
			Me.images.Images.SetKeyName(2, "Firefox.png")
			Me.images.Images.SetKeyName(3, "Google Chrome.png")
			Me.images.Images.SetKeyName(4, "Important.png")
			Me.images.Images.SetKeyName(5, "windows.png")
			Me.images.Images.SetKeyName(6, "Windows Explorer.png")
			Me.images.Images.SetKeyName(7, "microsoft.png")
			Me.images.Images.SetKeyName(8, "Icon.png")
			Me.images.Images.SetKeyName(9, "delete.png")
			' 
			' node43
			' 
			Me.node43.Expanded = True
			Me.node43.ImageIndex = 1
			Me.node43.Name = "node43"
			Me.node43.Nodes.AddRange(New DevComponents.AdvTree.Node() { Me.node44, Me.node45, Me.node46, Me.node47, Me.node48, Me.node49})
			Me.node43.Text = "Edge Chromium"
			' 
			' node44
			' 
			Me.node44.CheckBoxVisible = True
			Me.node44.Name = "node44"
			Me.node44.Text = "Internet Cache"
			' 
			' node45
			' 
			Me.node45.CheckBoxVisible = True
			Me.node45.Name = "node45"
			Me.node45.Text = "Cookies"
			' 
			' node46
			' 
			Me.node46.CheckBoxVisible = True
			Me.node46.Name = "node46"
			Me.node46.Text = "Internet History"
			' 
			' node47
			' 
			Me.node47.CheckBoxVisible = True
			Me.node47.Name = "node47"
			Me.node47.Text = "Session"
			' 
			' node48
			' 
			Me.node48.CheckBoxVisible = True
			Me.node48.Name = "node48"
			Me.node48.Text = "Saved Passwords"
			' 
			' node49
			' 
			Me.node49.CheckBoxVisible = True
			Me.node49.Name = "node49"
			Me.node49.Text = "Metrics Temp Files"
			' 
			' node50
			' 
			Me.node50.Expanded = True
			Me.node50.ImageIndex = 3
			Me.node50.Name = "node50"
			Me.node50.Nodes.AddRange(New DevComponents.AdvTree.Node() { Me.node51, Me.node52, Me.node53, Me.node54, Me.node55, Me.node56, Me.node57})
			Me.node50.Text = "Google Chrome"
			' 
			' node51
			' 
			Me.node51.CheckBoxVisible = True
			Me.node51.Name = "node51"
			Me.node51.Text = "Internet Cache"
			' 
			' node52
			' 
			Me.node52.CheckBoxVisible = True
			Me.node52.Name = "node52"
			Me.node52.Text = "Internet History"
			' 
			' node53
			' 
			Me.node53.CheckBoxVisible = True
			Me.node53.Name = "node53"
			Me.node53.Text = "Cookies"
			' 
			' node54
			' 
			Me.node54.CheckBoxVisible = True
			Me.node54.Name = "node54"
			Me.node54.Text = "Download History"
			' 
			' node55
			' 
			Me.node55.CheckBoxVisible = True
			Me.node55.Name = "node55"
			Me.node55.Text = "Metrics Temp Files"
			' 
			' node56
			' 
			Me.node56.CheckBoxVisible = True
			Me.node56.Name = "node56"
			Me.node56.Text = "Session"
			' 
			' node57
			' 
			Me.node57.CheckBoxVisible = True
			Me.node57.Name = "node57"
			Me.node57.Text = "Saved Passwords"
			' 
			' node58
			' 
			Me.node58.Expanded = True
			Me.node58.ImageIndex = 2
			Me.node58.Name = "node58"
			Me.node58.Nodes.AddRange(New DevComponents.AdvTree.Node() { Me.node59, Me.node60, Me.node61, Me.node62, Me.node63, Me.node64, Me.node65})
			Me.node58.Text = "Mozilla Firefox"
			' 
			' node59
			' 
			Me.node59.CheckBoxVisible = True
			Me.node59.Name = "node59"
			Me.node59.Text = "Internet Cache"
			' 
			' node60
			' 
			Me.node60.CheckBoxVisible = True
			Me.node60.Name = "node60"
			Me.node60.Text = "Internet History"
			' 
			' node61
			' 
			Me.node61.CheckBoxVisible = True
			Me.node61.Name = "node61"
			Me.node61.Text = "Cookies"
			' 
			' node62
			' 
			Me.node62.CheckBoxVisible = True
			Me.node62.Name = "node62"
			Me.node62.Text = "Session Data"
			' 
			' node63
			' 
			Me.node63.CheckBoxVisible = True
			Me.node63.Name = "node63"
			Me.node63.Text = "Site Preferences"
			' 
			' node64
			' 
			Me.node64.CheckBoxVisible = True
			Me.node64.Name = "node64"
			Me.node64.Text = "Saved Form Information"
			' 
			' node65
			' 
			Me.node65.CheckBoxVisible = True
			Me.node65.Name = "node65"
			Me.node65.Text = "Saved Passwords"
			' 
			' node1
			' 
			Me.node1.Expanded = True
			Me.node1.ImageIndex = 6
			Me.node1.Name = "node1"
			Me.node1.Nodes.AddRange(New DevComponents.AdvTree.Node() { Me.node2, Me.node3, Me.node4, Me.node15})
			Me.node1.Text = "Windows Explorer"
			' 
			' node2
			' 
			Me.node2.CheckBoxVisible = True
			Me.node2.Name = "node2"
			Me.node2.Text = "Recent Documents"
			' 
			' node3
			' 
			Me.node3.CheckBoxVisible = True
			Me.node3.Name = "node3"
			Me.node3.Text = "Thumbnail Cache"
			' 
			' node4
			' 
			Me.node4.CheckBoxVisible = True
			Me.node4.Name = "node4"
			Me.node4.Text = "Mini Dumps"
			' 
			' node15
			' 
			Me.node15.CheckBoxVisible = True
			Me.node15.Name = "node15"
			Me.node15.Text = "Temporary Files"
			' 
			' node5
			' 
			Me.node5.Expanded = True
			Me.node5.ImageIndex = 5
			Me.node5.Name = "node5"
			Me.node5.Nodes.AddRange(New DevComponents.AdvTree.Node() { Me.node6, Me.node7, Me.node8, Me.node9, Me.node10, Me.node11, Me.node12, Me.node13, Me.node14})
			Me.node5.Text = "System"
			' 
			' node6
			' 
			Me.node6.CheckBoxVisible = True
			Me.node6.Name = "node6"
			Me.node6.Text = "Empty Recycle Bin"
			' 
			' node7
			' 
			Me.node7.CheckBoxVisible = True
			Me.node7.Name = "node7"
			Me.node7.Text = "Temporary Files"
			' 
			' node8
			' 
			Me.node8.CheckBoxVisible = True
			Me.node8.Name = "node8"
			Me.node8.Text = "Memory Dumps"
			' 
			' node9
			' 
			Me.node9.CheckBoxVisible = True
			Me.node9.Name = "node9"
			Me.node9.Text = "Windows Log Files"
			' 
			' node10
			' 
			Me.node10.CheckBoxVisible = True
			Me.node10.Name = "node10"
			Me.node10.Text = "Windows Event Trace Logs"
			' 
			' node11
			' 
			Me.node11.CheckBoxVisible = True
			Me.node11.Name = "node11"
			Me.node11.Text = "Windows Error Reporting"
			' 
			' node12
			' 
			Me.node12.CheckBoxVisible = True
			Me.node12.Name = "node12"
			Me.node12.Text = "Driver Installation Log Files"
			' 
			' node13
			' 
			Me.node13.CheckBoxVisible = True
			Me.node13.Name = "node13"
			Me.node13.Text = "Windows Delivery Optimization Files"
			' 
			' node14
			' 
			Me.node14.CheckBoxVisible = True
			Me.node14.Name = "node14"
			Me.node14.Text = "Network Data Usage"
			' 
			' node16
			' 
			Me.node16.Expanded = True
			Me.node16.ImageIndex = 4
			Me.node16.Name = "node16"
			Me.node16.Nodes.AddRange(New DevComponents.AdvTree.Node() { Me.node17, Me.node18, Me.node19, Me.node20, Me.node21, Me.node22, Me.node23, Me.node24})
			Me.node16.Text = "Advanced"
			' 
			' node17
			' 
			Me.node17.CheckBoxVisible = True
			Me.node17.Name = "node17"
			Me.node17.Text = "Prefetch Data"
			' 
			' node18
			' 
			Me.node18.CheckBoxVisible = True
			Me.node18.Name = "node18"
			Me.node18.Text = "Store Install Service Cache"
			' 
			' node19
			' 
			Me.node19.CheckBoxVisible = True
			Me.node19.Name = "node19"
			Me.node19.Text = "Qt Framework"
			' 
			' node20
			' 
			Me.node20.CheckBoxVisible = True
			Me.node20.Name = "node20"
			Me.node20.Text = "Power Efficiency Diagnostics"
			' 
			' node21
			' 
			Me.node21.CheckBoxVisible = True
			Me.node21.Name = "node21"
			Me.node21.Text = "Notifications"
			' 
			' node22
			' 
			Me.node22.CheckBoxVisible = True
			Me.node22.Name = "node22"
			Me.node22.Text = "MS Search"
			' 
			' node23
			' 
			Me.node23.CheckBoxVisible = True
			Me.node23.Name = "node23"
			Me.node23.Text = "Jump List"
			' 
			' node24
			' 
			Me.node24.CheckBoxVisible = True
			Me.node24.Name = "node24"
			Me.node24.Text = "Font Cache"
			' 
			' node25
			' 
			Me.node25.Expanded = True
			Me.node25.ImageIndex = 0
			Me.node25.Name = "node25"
			Me.node25.Nodes.AddRange(New DevComponents.AdvTree.Node() { Me.node26, Me.node27, Me.node28, Me.node29, Me.node30, Me.node31, Me.node32, Me.node33})
			Me.node25.Text = "Applications"
			' 
			' node26
			' 
			Me.node26.CheckBoxVisible = True
			Me.node26.Name = "node26"
			Me.node26.Text = "Windows Defender"
			' 
			' node27
			' 
			Me.node27.CheckBoxVisible = True
			Me.node27.Name = "node27"
			Me.node27.Text = "Origin Installers"
			' 
			' node28
			' 
			Me.node28.CheckBoxVisible = True
			Me.node28.Name = "node28"
			Me.node28.Text = "Visual Studio Installation Packages"
			' 
			' node29
			' 
			Me.node29.CheckBoxVisible = True
			Me.node29.Name = "node29"
			Me.node29.Text = "One Drive"
			' 
			' node30
			' 
			Me.node30.CheckBoxVisible = True
			Me.node30.Name = "node30"
			Me.node30.Text = "Easy Anti-Cheat"
			' 
			' node31
			' 
			Me.node31.CheckBoxVisible = True
			Me.node31.Name = "node31"
			Me.node31.Text = "Battlenet"
			' 
			' node32
			' 
			Me.node32.CheckBoxVisible = True
			Me.node32.Name = "node32"
			Me.node32.Text = "Ccleaner"
			' 
			' node33
			' 
			Me.node33.CheckBoxVisible = True
			Me.node33.Name = "node33"
			Me.node33.Text = "Steam"
			' 
			' node34
			' 
			Me.node34.Expanded = True
			Me.node34.ImageIndex = 7
			Me.node34.Name = "node34"
			Me.node34.Nodes.AddRange(New DevComponents.AdvTree.Node() { Me.node35, Me.node36, Me.node37, Me.node38, Me.node39, Me.node40, Me.node41, Me.node42, Me.node66})
			Me.node34.Text = "Windows"
			' 
			' node35
			' 
			Me.node35.CheckBoxVisible = True
			Me.node35.Name = "node35"
			Me.node35.Text = "DirectXShader Cache"
			' 
			' node36
			' 
			Me.node36.CheckBoxVisible = True
			Me.node36.Name = "node36"
			Me.node36.Text = "Windows Update Files"
			' 
			' node37
			' 
			Me.node37.CheckBoxVisible = True
			Me.node37.Name = "node37"
			Me.node37.Text = "Windows Font Cache"
			' 
			' node38
			' 
			Me.node38.CheckBoxVisible = True
			Me.node38.Name = "node38"
			Me.node38.Text = "Windows Debug Files"
			' 
			' node39
			' 
			Me.node39.CheckBoxVisible = True
			Me.node39.Name = "node39"
			Me.node39.Text = "Windows Cache"
			' 
			' node40
			' 
			Me.node40.CheckBoxVisible = True
			Me.node40.Name = "node40"
			Me.node40.Text = "Windows Installer"
			' 
			' node41
			' 
			Me.node41.CheckBoxVisible = True
			Me.node41.Name = "node41"
			Me.node41.Text = "Windows Experience Index"
			' 
			' node42
			' 
			Me.node42.CheckBoxVisible = True
			Me.node42.Name = "node42"
			Me.node42.Text = "Windows Auto/Video Experience"
			' 
			' node66
			' 
			Me.node66.CheckBoxVisible = True
			Me.node66.Name = "node66"
			Me.node66.Text = "Internet Explorer Cache"
			' 
			' nodeConnector1
			' 
			Me.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
			' 
			' elementStyle1
			' 
			Me.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.elementStyle1.Name = "elementStyle1"
			Me.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText
			' 
			' style
			' 
			Me.style.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
			Me.style.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(87)))), (CInt((CByte(154))))))
			' 
			' Lbl1
			' 
			Me.Lbl1.AutoSize = True
			Me.Lbl1.BackColor = System.Drawing.Color.Transparent
			Me.Lbl1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Lbl1.Location = New System.Drawing.Point(11, 69)
			Me.Lbl1.Name = "Lbl1"
			Me.Lbl1.Size = New System.Drawing.Size(106, 17)
			Me.Lbl1.TabIndex = 6
			Me.Lbl1.Text = "Places to clean..."
			' 
			' Lbl2
			' 
			Me.Lbl2.AutoSize = True
			Me.Lbl2.BackColor = System.Drawing.Color.Transparent
			Me.Lbl2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Lbl2.Location = New System.Drawing.Point(279, 69)
			Me.Lbl2.Name = "Lbl2"
			Me.Lbl2.Size = New System.Drawing.Size(83, 17)
			Me.Lbl2.TabIndex = 7
			Me.Lbl2.Text = "Scan Results"
			' 
			' Running
			' 
			' 
			' 
			' 
			Me.Running.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.Running.Location = New System.Drawing.Point(815, 67)
			Me.Running.Name = "Running"
			Me.Running.Size = New System.Drawing.Size(33, 23)
			Me.Running.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
			Me.Running.TabIndex = 9
			Me.Running.Visible = False
			' 
			' Cleaner
			' 
			Me.Cleaner.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.Cleaner.Animated = True
			Me.Cleaner.BorderRadius = 3
			Me.Cleaner.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(74)))), (CInt((CByte(83)))), (CInt((CByte(110)))))
			Me.Cleaner.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(74)))), (CInt((CByte(83)))), (CInt((CByte(110)))))
			Me.Cleaner.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(74)))), (CInt((CByte(83)))), (CInt((CByte(110)))))
			Me.Cleaner.DisabledState.ForeColor = System.Drawing.Color.White
			Me.Cleaner.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Cleaner.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.Cleaner.ForeColor = System.Drawing.Color.White
			Me.Cleaner.Location = New System.Drawing.Point(755, 496)
			Me.Cleaner.Name = "Cleaner"
			Me.Cleaner.Size = New System.Drawing.Size(93, 27)
			Me.Cleaner.TabIndex = 10
			Me.Cleaner.Text = "Run Cleaner"
'			Me.Cleaner.Click += New System.EventHandler(Me.Cleaner_Click)
			' 
			' Analyze
			' 
			Me.Analyze.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.Analyze.Animated = True
			Me.Analyze.BorderRadius = 3
			Me.Analyze.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.Analyze.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.Analyze.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.Analyze.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.Analyze.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Analyze.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.Analyze.ForeColor = System.Drawing.Color.White
			Me.Analyze.Location = New System.Drawing.Point(656, 496)
			Me.Analyze.Name = "Analyze"
			Me.Analyze.Size = New System.Drawing.Size(93, 27)
			Me.Analyze.TabIndex = 11
			Me.Analyze.Text = "Analyze"
'			Me.Analyze.Click += New System.EventHandler(Me.Analyze_Click)
			' 
			' Settings
			' 
			Me.Settings.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.Settings.Animated = True
			Me.Settings.BorderRadius = 3
			Me.Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.Settings.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Settings.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.Settings.ForeColor = System.Drawing.Color.White
			Me.Settings.Location = New System.Drawing.Point(280, 496)
			Me.Settings.Name = "Settings"
			Me.Settings.Size = New System.Drawing.Size(93, 27)
			Me.Settings.TabIndex = 12
			Me.Settings.Text = "Settings"
'			Me.Settings.Click += New System.EventHandler(Me.Settings_Click)
			' 
			' Tray
			' 
			Me.Tray.ContextMenuStrip = Me.Menu
			Me.Tray.Icon = (DirectCast(resources.GetObject("Tray.Icon"), System.Drawing.Icon))
			Me.Tray.Text = "Axolotl PC Cleaner"
			Me.Tray.Visible = True
'			Me.Tray.MouseDoubleClick += New System.Windows.Forms.MouseEventHandler(Me.Tray_MouseDoubleClick)
			' 
			' Menu
			' 
			Me.Menu.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.hideToolStripMenuItem, Me.analyzeFilesToolStripMenuItem, Me.aboutAxolotlToolStripMenuItem, Me.checkForUpdatesToolStripMenuItem, Me.exitToolStripMenuItem})
			Me.Menu.Name = "Menu"
			Me.Menu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb((CInt((CByte(151)))), (CInt((CByte(143)))), (CInt((CByte(255)))))
			Me.Menu.RenderStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Menu.RenderStyle.ColorTable = Nothing
			Me.Menu.RenderStyle.RoundedEdges = True
			Me.Menu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
			Me.Menu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb((CInt((CByte(100)))), (CInt((CByte(88)))), (CInt((CByte(255)))))
			Me.Menu.RenderStyle.SelectionForeColor = System.Drawing.Color.White
			Me.Menu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
			Me.Menu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
			Me.Menu.Size = New System.Drawing.Size(174, 114)
			' 
			' hideToolStripMenuItem
			' 
			Me.hideToolStripMenuItem.ForeColor = System.Drawing.Color.White
			Me.hideToolStripMenuItem.Name = "hideToolStripMenuItem"
			Me.hideToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.hideToolStripMenuItem.Text = "Hide"
'			Me.hideToolStripMenuItem.Click += New System.EventHandler(Me.hideToolStripMenuItem_Click)
			' 
			' analyzeFilesToolStripMenuItem
			' 
			Me.analyzeFilesToolStripMenuItem.ForeColor = System.Drawing.Color.White
			Me.analyzeFilesToolStripMenuItem.Name = "analyzeFilesToolStripMenuItem"
			Me.analyzeFilesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.analyzeFilesToolStripMenuItem.Text = "Analyze Files"
'			Me.analyzeFilesToolStripMenuItem.Click += New System.EventHandler(Me.analyzeFilesToolStripMenuItem_Click)
			' 
			' aboutAxolotlToolStripMenuItem
			' 
			Me.aboutAxolotlToolStripMenuItem.ForeColor = System.Drawing.Color.White
			Me.aboutAxolotlToolStripMenuItem.Name = "aboutAxolotlToolStripMenuItem"
			Me.aboutAxolotlToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.aboutAxolotlToolStripMenuItem.Text = "About Axolotl"
'			Me.aboutAxolotlToolStripMenuItem.Click += New System.EventHandler(Me.aboutAxolotlToolStripMenuItem_Click)
			' 
			' checkForUpdatesToolStripMenuItem
			' 
			Me.checkForUpdatesToolStripMenuItem.ForeColor = System.Drawing.Color.White
			Me.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem"
			Me.checkForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.checkForUpdatesToolStripMenuItem.Text = "Check For Updates"
'			Me.checkForUpdatesToolStripMenuItem.Click += New System.EventHandler(Me.checkForUpdatesToolStripMenuItem_Click)
			' 
			' exitToolStripMenuItem
			' 
			Me.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
			Me.exitToolStripMenuItem.Text = "Exit"
'			Me.exitToolStripMenuItem.Click += New System.EventHandler(Me.exitToolStripMenuItem_Click)
			' 
			' Scanner
			' 
			Me.Scanner.Interval = 1000
'			Me.Scanner.Tick += New System.EventHandler(Me.Scanner_Tick)
			' 
			' Deleter
			' 
			Me.Deleter.Interval = 1000
'			Me.Deleter.Tick += New System.EventHandler(Me.Deleter_Tick)
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(864, 536)
			Me.Controls.Add(Me.Settings)
			Me.Controls.Add(Me.Analyze)
			Me.Controls.Add(Me.Cleaner)
			Me.Controls.Add(Me.Running)
			Me.Controls.Add(Me.Lbl2)
			Me.Controls.Add(Me.Lbl1)
			Me.Controls.Add(Me.Options)
			Me.Controls.Add(Me.List)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Main"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "AXOLOTL PC CLEANER"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.Main_FormClosing)
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			DirectCast(Me.TitleLogo, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.Options, System.ComponentModel.ISupportInitialize).EndInit()
			Me.Menu.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private TitleTxt As System.Windows.Forms.Label
		Private TitleLogo As System.Windows.Forms.PictureBox
		Private WithEvents List As DevComponents.DotNetBar.Controls.ListViewEx
		Private Options As DevComponents.AdvTree.AdvTree
		Private node1 As DevComponents.AdvTree.Node
		Private nodeConnector1 As DevComponents.AdvTree.NodeConnector
		Private elementStyle1 As DevComponents.DotNetBar.ElementStyle
		Private style As DevComponents.DotNetBar.StyleManager
		Private Lbl1 As System.Windows.Forms.Label
		Private Lbl2 As System.Windows.Forms.Label
		Private images As System.Windows.Forms.ImageList
		Private node2 As DevComponents.AdvTree.Node
		Private node3 As DevComponents.AdvTree.Node
		Private node4 As DevComponents.AdvTree.Node
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private node5 As DevComponents.AdvTree.Node
		Private node6 As DevComponents.AdvTree.Node
		Private node7 As DevComponents.AdvTree.Node
		Private node8 As DevComponents.AdvTree.Node
		Private node9 As DevComponents.AdvTree.Node
		Private node10 As DevComponents.AdvTree.Node
		Private node11 As DevComponents.AdvTree.Node
		Private node12 As DevComponents.AdvTree.Node
		Private node13 As DevComponents.AdvTree.Node
		Private node14 As DevComponents.AdvTree.Node
		Private node15 As DevComponents.AdvTree.Node
		Private Running As DevComponents.DotNetBar.Controls.CircularProgress
		Private WithEvents Cleaner As Guna.UI2.WinForms.Guna2Button
		Private WithEvents Analyze As Guna.UI2.WinForms.Guna2Button
		Private WithEvents Settings As Guna.UI2.WinForms.Guna2Button
		Private node16 As DevComponents.AdvTree.Node
		Private node17 As DevComponents.AdvTree.Node
		Private node18 As DevComponents.AdvTree.Node
		Private node19 As DevComponents.AdvTree.Node
		Private node20 As DevComponents.AdvTree.Node
		Private node21 As DevComponents.AdvTree.Node
		Private node22 As DevComponents.AdvTree.Node
		Private node23 As DevComponents.AdvTree.Node
		Private node24 As DevComponents.AdvTree.Node
		Private node25 As DevComponents.AdvTree.Node
		Private node26 As DevComponents.AdvTree.Node
		Private node27 As DevComponents.AdvTree.Node
		Private node28 As DevComponents.AdvTree.Node
		Private node29 As DevComponents.AdvTree.Node
		Private node30 As DevComponents.AdvTree.Node
		Private node31 As DevComponents.AdvTree.Node
		Private node32 As DevComponents.AdvTree.Node
		Private node33 As DevComponents.AdvTree.Node
		Private node34 As DevComponents.AdvTree.Node
		Private node35 As DevComponents.AdvTree.Node
		Private node36 As DevComponents.AdvTree.Node
		Private node37 As DevComponents.AdvTree.Node
		Private node38 As DevComponents.AdvTree.Node
		Private node39 As DevComponents.AdvTree.Node
		Private node40 As DevComponents.AdvTree.Node
		Private node41 As DevComponents.AdvTree.Node
		Private node42 As DevComponents.AdvTree.Node
		Private node43 As DevComponents.AdvTree.Node
		Private node44 As DevComponents.AdvTree.Node
		Private node45 As DevComponents.AdvTree.Node
		Private node46 As DevComponents.AdvTree.Node
		Private node47 As DevComponents.AdvTree.Node
		Private node48 As DevComponents.AdvTree.Node
		Private node49 As DevComponents.AdvTree.Node
		Private node50 As DevComponents.AdvTree.Node
		Private node51 As DevComponents.AdvTree.Node
		Private node52 As DevComponents.AdvTree.Node
		Private node53 As DevComponents.AdvTree.Node
		Private node54 As DevComponents.AdvTree.Node
		Private node55 As DevComponents.AdvTree.Node
		Private node56 As DevComponents.AdvTree.Node
		Private node57 As DevComponents.AdvTree.Node
		Private node58 As DevComponents.AdvTree.Node
		Private node59 As DevComponents.AdvTree.Node
		Private node60 As DevComponents.AdvTree.Node
		Private node61 As DevComponents.AdvTree.Node
		Private node62 As DevComponents.AdvTree.Node
		Private node63 As DevComponents.AdvTree.Node
		Private node64 As DevComponents.AdvTree.Node
		Private node65 As DevComponents.AdvTree.Node
		Private Line2 As System.Windows.Forms.Label
		Private Line1 As System.Windows.Forms.Label
		Private node66 As DevComponents.AdvTree.Node
		Private WithEvents Tray As System.Windows.Forms.NotifyIcon
		Private Menu As Guna.UI2.WinForms.Guna2ContextMenuStrip
		Private WithEvents hideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents checkForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents Scanner As System.Windows.Forms.Timer
		Private label1 As System.Windows.Forms.Label
		Private WithEvents Deleter As System.Windows.Forms.Timer
		Private WithEvents analyzeFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents aboutAxolotlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace

