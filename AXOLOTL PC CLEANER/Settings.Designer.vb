Namespace AXOLOTL_PC_CLEANER
	Partial Public Class Settings
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Settings))
			Me.Lbl1 = New System.Windows.Forms.Label()
			Me.minimized = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.startup = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.expandall = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.rescan = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.firefox = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.showadvanced = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.showwindows = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.showapps = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.msg1 = New Guna.UI2.WinForms.Guna2Button()
			Me.msg2 = New Guna.UI2.WinForms.Guna2Button()
			Me.msg3 = New Guna.UI2.WinForms.Guna2Button()
			Me.msg4 = New Guna.UI2.WinForms.Guna2Button()
			Me.msg11 = New Guna.UI2.WinForms.Guna2Button()
			Me.msg6 = New Guna.UI2.WinForms.Guna2Button()
			Me.msg5 = New Guna.UI2.WinForms.Guna2Button()
			Me.msg7 = New Guna.UI2.WinForms.Guna2Button()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.msg9 = New Guna.UI2.WinForms.Guna2Button()
			Me.edge = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.msg10 = New Guna.UI2.WinForms.Guna2Button()
			Me.chrome = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.msg8 = New Guna.UI2.WinForms.Guna2Button()
			Me.closeafter = New Guna.UI2.WinForms.Guna2CheckBox()
			Me.guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
			Me.guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
			Me.label1 = New System.Windows.Forms.Label()
			Me.guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
			Me.msg12 = New Guna.UI2.WinForms.Guna2Button()
			Me.guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
			Me.guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
			Me.guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
			Me.Sidx = New Guna.UI2.WinForms.Guna2Button()
			Me.Cpux = New Guna.UI2.WinForms.Guna2Button()
			Me.Systemx = New Guna.UI2.WinForms.Guna2Button()
			Me.Gpux = New Guna.UI2.WinForms.Guna2Button()
			Me.Ramx = New Guna.UI2.WinForms.Guna2Button()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' Lbl1
			' 
			Me.Lbl1.AutoSize = True
			Me.Lbl1.BackColor = System.Drawing.Color.Transparent
			Me.Lbl1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Lbl1.ForeColor = System.Drawing.Color.White
			Me.Lbl1.Location = New System.Drawing.Point(12, 9)
			Me.Lbl1.Name = "Lbl1"
			Me.Lbl1.Size = New System.Drawing.Size(248, 17)
			Me.Lbl1.TabIndex = 8
			Me.Lbl1.Text = "Please selected from the options below."
			' 
			' minimized
			' 
			Me.minimized.AutoSize = True
			Me.minimized.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.minimized.CheckedState.BorderRadius = 1
			Me.minimized.CheckedState.BorderThickness = 1
			Me.minimized.CheckedState.FillColor = System.Drawing.Color.White
			Me.minimized.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.minimized.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.minimized.Location = New System.Drawing.Point(275, 48)
			Me.minimized.Name = "minimized"
			Me.minimized.Size = New System.Drawing.Size(178, 19)
			Me.minimized.TabIndex = 11
			Me.minimized.Text = "Start application minimized?"
			Me.minimized.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.minimized.UncheckedState.BorderRadius = 1
			Me.minimized.UncheckedState.BorderThickness = 1
			Me.minimized.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' startup
			' 
			Me.startup.AutoSize = True
			Me.startup.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.startup.CheckedState.BorderRadius = 1
			Me.startup.CheckedState.BorderThickness = 1
			Me.startup.CheckedState.FillColor = System.Drawing.Color.White
			Me.startup.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.startup.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.startup.Location = New System.Drawing.Point(53, 48)
			Me.startup.Name = "startup"
			Me.startup.Size = New System.Drawing.Size(155, 19)
			Me.startup.TabIndex = 12
			Me.startup.Text = "Run at windows startup?"
			Me.startup.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.startup.UncheckedState.BorderRadius = 1
			Me.startup.UncheckedState.BorderThickness = 1
			Me.startup.UncheckedState.FillColor = System.Drawing.Color.White
'			Me.startup.CheckedChanged += New System.EventHandler(Me.startup_CheckedChanged)
			' 
			' expandall
			' 
			Me.expandall.AutoSize = True
			Me.expandall.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.expandall.CheckedState.BorderRadius = 1
			Me.expandall.CheckedState.BorderThickness = 1
			Me.expandall.CheckedState.FillColor = System.Drawing.Color.White
			Me.expandall.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.expandall.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.expandall.Location = New System.Drawing.Point(53, 73)
			Me.expandall.Name = "expandall"
			Me.expandall.Size = New System.Drawing.Size(171, 19)
			Me.expandall.TabIndex = 13
			Me.expandall.Text = "Expand all options on load?" & ControlChars.CrLf
			Me.expandall.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.expandall.UncheckedState.BorderRadius = 1
			Me.expandall.UncheckedState.BorderThickness = 1
			Me.expandall.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' rescan
			' 
			Me.rescan.AutoSize = True
			Me.rescan.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.rescan.CheckedState.BorderRadius = 1
			Me.rescan.CheckedState.BorderThickness = 1
			Me.rescan.CheckedState.FillColor = System.Drawing.Color.White
			Me.rescan.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.rescan.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.rescan.Location = New System.Drawing.Point(275, 73)
			Me.rescan.Name = "rescan"
			Me.rescan.Size = New System.Drawing.Size(201, 19)
			Me.rescan.TabIndex = 14
			Me.rescan.Text = "Rescan after running the cleaner?"
			Me.rescan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.rescan.UncheckedState.BorderRadius = 1
			Me.rescan.UncheckedState.BorderThickness = 1
			Me.rescan.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' firefox
			' 
			Me.firefox.AutoSize = True
			Me.firefox.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.firefox.CheckedState.BorderRadius = 1
			Me.firefox.CheckedState.BorderThickness = 1
			Me.firefox.CheckedState.FillColor = System.Drawing.Color.White
			Me.firefox.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.firefox.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.firefox.Location = New System.Drawing.Point(53, 189)
			Me.firefox.Name = "firefox"
			Me.firefox.Size = New System.Drawing.Size(140, 19)
			Me.firefox.TabIndex = 15
			Me.firefox.Text = "Show Firefox Options"
			Me.firefox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.firefox.UncheckedState.BorderRadius = 1
			Me.firefox.UncheckedState.BorderThickness = 1
			Me.firefox.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' showadvanced
			' 
			Me.showadvanced.AutoSize = True
			Me.showadvanced.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.showadvanced.CheckedState.BorderRadius = 1
			Me.showadvanced.CheckedState.BorderThickness = 1
			Me.showadvanced.CheckedState.FillColor = System.Drawing.Color.White
			Me.showadvanced.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.showadvanced.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.showadvanced.Location = New System.Drawing.Point(275, 139)
			Me.showadvanced.Name = "showadvanced"
			Me.showadvanced.Size = New System.Drawing.Size(157, 19)
			Me.showadvanced.TabIndex = 16
			Me.showadvanced.Text = "Show Advanced Options"
			Me.showadvanced.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.showadvanced.UncheckedState.BorderRadius = 1
			Me.showadvanced.UncheckedState.BorderThickness = 1
			Me.showadvanced.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' showwindows
			' 
			Me.showwindows.AutoSize = True
			Me.showwindows.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.showwindows.CheckedState.BorderRadius = 1
			Me.showwindows.CheckedState.BorderThickness = 1
			Me.showwindows.CheckedState.FillColor = System.Drawing.Color.White
			Me.showwindows.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.showwindows.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.showwindows.Location = New System.Drawing.Point(53, 139)
			Me.showwindows.Name = "showwindows"
			Me.showwindows.Size = New System.Drawing.Size(154, 19)
			Me.showwindows.TabIndex = 17
			Me.showwindows.Text = "Show Windows Options"
			Me.showwindows.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.showwindows.UncheckedState.BorderRadius = 1
			Me.showwindows.UncheckedState.BorderThickness = 1
			Me.showwindows.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' showapps
			' 
			Me.showapps.AutoSize = True
			Me.showapps.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.showapps.CheckedState.BorderRadius = 1
			Me.showapps.CheckedState.BorderThickness = 1
			Me.showapps.CheckedState.FillColor = System.Drawing.Color.White
			Me.showapps.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.showapps.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.showapps.Location = New System.Drawing.Point(53, 164)
			Me.showapps.Name = "showapps"
			Me.showapps.Size = New System.Drawing.Size(125, 19)
			Me.showapps.TabIndex = 18
			Me.showapps.Text = "Show Applications"
			Me.showapps.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.showapps.UncheckedState.BorderRadius = 1
			Me.showapps.UncheckedState.BorderThickness = 1
			Me.showapps.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' msg1
			' 
			Me.msg1.Animated = True
			Me.msg1.BorderRadius = 3
			Me.msg1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg1.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg1.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg1.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg1.ForeColor = System.Drawing.Color.White
			Me.msg1.Location = New System.Drawing.Point(15, 48)
			Me.msg1.Name = "msg1"
			Me.msg1.Size = New System.Drawing.Size(28, 19)
			Me.msg1.TabIndex = 19
			Me.msg1.Text = "?"
'			Me.msg1.Click += New System.EventHandler(Me.msg1_Click)
			' 
			' msg2
			' 
			Me.msg2.Animated = True
			Me.msg2.BorderRadius = 3
			Me.msg2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg2.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg2.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg2.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg2.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg2.ForeColor = System.Drawing.Color.White
			Me.msg2.Location = New System.Drawing.Point(236, 48)
			Me.msg2.Name = "msg2"
			Me.msg2.Size = New System.Drawing.Size(28, 19)
			Me.msg2.TabIndex = 20
			Me.msg2.Text = "?"
'			Me.msg2.Click += New System.EventHandler(Me.msg2_Click)
			' 
			' msg3
			' 
			Me.msg3.Animated = True
			Me.msg3.BorderRadius = 3
			Me.msg3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg3.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg3.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg3.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg3.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg3.ForeColor = System.Drawing.Color.White
			Me.msg3.Location = New System.Drawing.Point(15, 73)
			Me.msg3.Name = "msg3"
			Me.msg3.Size = New System.Drawing.Size(28, 19)
			Me.msg3.TabIndex = 21
			Me.msg3.Text = "?"
'			Me.msg3.Click += New System.EventHandler(Me.msg3_Click)
			' 
			' msg4
			' 
			Me.msg4.Animated = True
			Me.msg4.BorderRadius = 3
			Me.msg4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg4.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg4.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg4.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg4.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg4.ForeColor = System.Drawing.Color.White
			Me.msg4.Location = New System.Drawing.Point(236, 73)
			Me.msg4.Name = "msg4"
			Me.msg4.Size = New System.Drawing.Size(28, 19)
			Me.msg4.TabIndex = 22
			Me.msg4.Text = "?"
'			Me.msg4.Click += New System.EventHandler(Me.msg4_Click)
			' 
			' msg11
			' 
			Me.msg11.Animated = True
			Me.msg11.BorderRadius = 3
			Me.msg11.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg11.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg11.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg11.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg11.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg11.ForeColor = System.Drawing.Color.White
			Me.msg11.Location = New System.Drawing.Point(15, 189)
			Me.msg11.Name = "msg11"
			Me.msg11.Size = New System.Drawing.Size(28, 19)
			Me.msg11.TabIndex = 23
			Me.msg11.Text = "?"
'			Me.msg11.Click += New System.EventHandler(Me.msg11_Click)
			' 
			' msg6
			' 
			Me.msg6.Animated = True
			Me.msg6.BorderRadius = 3
			Me.msg6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg6.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg6.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg6.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg6.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg6.ForeColor = System.Drawing.Color.White
			Me.msg6.Location = New System.Drawing.Point(236, 139)
			Me.msg6.Name = "msg6"
			Me.msg6.Size = New System.Drawing.Size(28, 19)
			Me.msg6.TabIndex = 24
			Me.msg6.Text = "?"
'			Me.msg6.Click += New System.EventHandler(Me.msg6_Click)
			' 
			' msg5
			' 
			Me.msg5.Animated = True
			Me.msg5.BorderRadius = 3
			Me.msg5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg5.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg5.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg5.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg5.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg5.ForeColor = System.Drawing.Color.White
			Me.msg5.Location = New System.Drawing.Point(15, 139)
			Me.msg5.Name = "msg5"
			Me.msg5.Size = New System.Drawing.Size(28, 19)
			Me.msg5.TabIndex = 25
			Me.msg5.Text = "?"
'			Me.msg5.Click += New System.EventHandler(Me.msg5_Click)
			' 
			' msg7
			' 
			Me.msg7.Animated = True
			Me.msg7.BorderRadius = 3
			Me.msg7.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg7.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg7.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg7.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg7.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg7.ForeColor = System.Drawing.Color.White
			Me.msg7.Location = New System.Drawing.Point(15, 164)
			Me.msg7.Name = "msg7"
			Me.msg7.Size = New System.Drawing.Size(28, 19)
			Me.msg7.TabIndex = 26
			Me.msg7.Text = "?"
'			Me.msg7.Click += New System.EventHandler(Me.msg7_Click)
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.panel1.Controls.Add(Me.Lbl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(485, 37)
			Me.panel1.TabIndex = 27
			' 
			' msg9
			' 
			Me.msg9.Animated = True
			Me.msg9.BorderRadius = 3
			Me.msg9.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg9.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg9.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg9.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg9.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg9.ForeColor = System.Drawing.Color.White
			Me.msg9.Location = New System.Drawing.Point(236, 164)
			Me.msg9.Name = "msg9"
			Me.msg9.Size = New System.Drawing.Size(28, 19)
			Me.msg9.TabIndex = 29
			Me.msg9.Text = "?"
'			Me.msg9.Click += New System.EventHandler(Me.msg9_Click)
			' 
			' edge
			' 
			Me.edge.AutoSize = True
			Me.edge.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.edge.CheckedState.BorderRadius = 1
			Me.edge.CheckedState.BorderThickness = 1
			Me.edge.CheckedState.FillColor = System.Drawing.Color.White
			Me.edge.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.edge.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.edge.Location = New System.Drawing.Point(274, 164)
			Me.edge.Name = "edge"
			Me.edge.Size = New System.Drawing.Size(130, 19)
			Me.edge.TabIndex = 28
			Me.edge.Text = "Show Edge Options"
			Me.edge.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.edge.UncheckedState.BorderRadius = 1
			Me.edge.UncheckedState.BorderThickness = 1
			Me.edge.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' msg10
			' 
			Me.msg10.Animated = True
			Me.msg10.BorderRadius = 3
			Me.msg10.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg10.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg10.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg10.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg10.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg10.ForeColor = System.Drawing.Color.White
			Me.msg10.Location = New System.Drawing.Point(236, 189)
			Me.msg10.Name = "msg10"
			Me.msg10.Size = New System.Drawing.Size(28, 19)
			Me.msg10.TabIndex = 31
			Me.msg10.Text = "?"
'			Me.msg10.Click += New System.EventHandler(Me.msg10_Click)
			' 
			' chrome
			' 
			Me.chrome.AutoSize = True
			Me.chrome.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.chrome.CheckedState.BorderRadius = 1
			Me.chrome.CheckedState.BorderThickness = 1
			Me.chrome.CheckedState.FillColor = System.Drawing.Color.White
			Me.chrome.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.chrome.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.chrome.Location = New System.Drawing.Point(275, 189)
			Me.chrome.Name = "chrome"
			Me.chrome.Size = New System.Drawing.Size(187, 19)
			Me.chrome.TabIndex = 30
			Me.chrome.Text = "Show Goolge Chrome Options"
			Me.chrome.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.chrome.UncheckedState.BorderRadius = 1
			Me.chrome.UncheckedState.BorderThickness = 1
			Me.chrome.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' msg8
			' 
			Me.msg8.Animated = True
			Me.msg8.BorderRadius = 3
			Me.msg8.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg8.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg8.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg8.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg8.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg8.ForeColor = System.Drawing.Color.White
			Me.msg8.Location = New System.Drawing.Point(15, 98)
			Me.msg8.Name = "msg8"
			Me.msg8.Size = New System.Drawing.Size(28, 19)
			Me.msg8.TabIndex = 33
			Me.msg8.Text = "?"
'			Me.msg8.Click += New System.EventHandler(Me.msg8_Click)
			' 
			' closeafter
			' 
			Me.closeafter.AutoSize = True
			Me.closeafter.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.closeafter.CheckedState.BorderRadius = 1
			Me.closeafter.CheckedState.BorderThickness = 1
			Me.closeafter.CheckedState.FillColor = System.Drawing.Color.White
			Me.closeafter.CheckMarkColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.closeafter.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
			Me.closeafter.Location = New System.Drawing.Point(54, 98)
			Me.closeafter.Name = "closeafter"
			Me.closeafter.Size = New System.Drawing.Size(132, 19)
			Me.closeafter.TabIndex = 32
			Me.closeafter.Text = "Close After Cleaning"
			Me.closeafter.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.closeafter.UncheckedState.BorderRadius = 1
			Me.closeafter.UncheckedState.BorderThickness = 1
			Me.closeafter.UncheckedState.FillColor = System.Drawing.Color.White
			' 
			' guna2Separator1
			' 
			Me.guna2Separator1.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.guna2Separator1.Location = New System.Drawing.Point(15, 123)
			Me.guna2Separator1.Name = "guna2Separator1"
			Me.guna2Separator1.Size = New System.Drawing.Size(453, 10)
			Me.guna2Separator1.TabIndex = 34
			' 
			' guna2Separator2
			' 
			Me.guna2Separator2.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.guna2Separator2.Location = New System.Drawing.Point(15, 214)
			Me.guna2Separator2.Name = "guna2Separator2"
			Me.guna2Separator2.Size = New System.Drawing.Size(453, 10)
			Me.guna2Separator2.TabIndex = 35
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.Black
			Me.label1.Location = New System.Drawing.Point(49, 231)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(129, 17)
			Me.label1.TabIndex = 36
			Me.label1.Text = "Firefox folder name:"
			' 
			' guna2TextBox1
			' 
			Me.guna2TextBox1.Animated = True
			Me.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.guna2TextBox1.BorderRadius = 3
			Me.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.guna2TextBox1.DefaultText = ""
			Me.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.guna2TextBox1.Location = New System.Drawing.Point(184, 230)
			Me.guna2TextBox1.Name = "guna2TextBox1"
			Me.guna2TextBox1.PasswordChar = ControlChars.NullChar
			Me.guna2TextBox1.PlaceholderText = ""
			Me.guna2TextBox1.SelectedText = ""
			Me.guna2TextBox1.Size = New System.Drawing.Size(125, 19)
			Me.guna2TextBox1.TabIndex = 37
			' 
			' msg12
			' 
			Me.msg12.Animated = True
			Me.msg12.BorderRadius = 3
			Me.msg12.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.msg12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.msg12.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.msg12.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.msg12.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.msg12.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.msg12.ForeColor = System.Drawing.Color.White
			Me.msg12.Location = New System.Drawing.Point(15, 230)
			Me.msg12.Name = "msg12"
			Me.msg12.Size = New System.Drawing.Size(28, 19)
			Me.msg12.TabIndex = 38
			Me.msg12.Text = "?"
'			Me.msg12.Click += New System.EventHandler(Me.msg12_Click)
			' 
			' guna2Button2
			' 
			Me.guna2Button2.Animated = True
			Me.guna2Button2.BorderRadius = 3
			Me.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.guna2Button2.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.guna2Button2.ForeColor = System.Drawing.Color.White
			Me.guna2Button2.Location = New System.Drawing.Point(382, 230)
			Me.guna2Button2.Name = "guna2Button2"
			Me.guna2Button2.Size = New System.Drawing.Size(86, 19)
			Me.guna2Button2.TabIndex = 39
			Me.guna2Button2.Text = "Go To Path"
'			Me.guna2Button2.Click += New System.EventHandler(Me.guna2Button2_Click)
			' 
			' guna2Button3
			' 
			Me.guna2Button3.Animated = True
			Me.guna2Button3.BorderRadius = 3
			Me.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.guna2Button3.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.guna2Button3.ForeColor = System.Drawing.Color.White
			Me.guna2Button3.Location = New System.Drawing.Point(315, 230)
			Me.guna2Button3.Name = "guna2Button3"
			Me.guna2Button3.Size = New System.Drawing.Size(61, 19)
			Me.guna2Button3.TabIndex = 40
			Me.guna2Button3.Text = "Save"
'			Me.guna2Button3.Click += New System.EventHandler(Me.guna2Button3_Click)
			' 
			' guna2Separator3
			' 
			Me.guna2Separator3.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.guna2Separator3.Location = New System.Drawing.Point(15, 255)
			Me.guna2Separator3.Name = "guna2Separator3"
			Me.guna2Separator3.Size = New System.Drawing.Size(453, 10)
			Me.guna2Separator3.TabIndex = 41
			' 
			' Sidx
			' 
			Me.Sidx.Animated = True
			Me.Sidx.BorderRadius = 3
			Me.Sidx.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.Sidx.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.Sidx.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.Sidx.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.Sidx.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Sidx.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.Sidx.ForeColor = System.Drawing.Color.White
			Me.Sidx.Location = New System.Drawing.Point(15, 271)
			Me.Sidx.Name = "Sidx"
			Me.Sidx.Size = New System.Drawing.Size(131, 19)
			Me.Sidx.TabIndex = 42
			Me.Sidx.Text = "Reset Username Sid"
'			Me.Sidx.Click += New System.EventHandler(Me.Sid_Click)
			' 
			' Cpux
			' 
			Me.Cpux.Animated = True
			Me.Cpux.BorderRadius = 3
			Me.Cpux.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.Cpux.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.Cpux.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.Cpux.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.Cpux.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Cpux.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.Cpux.ForeColor = System.Drawing.Color.White
			Me.Cpux.Location = New System.Drawing.Point(152, 271)
			Me.Cpux.Name = "Cpux"
			Me.Cpux.Size = New System.Drawing.Size(146, 19)
			Me.Cpux.TabIndex = 43
			Me.Cpux.Text = "Reset Cpu Information"
'			Me.Cpux.Click += New System.EventHandler(Me.Cpu_Click)
			' 
			' Systemx
			' 
			Me.Systemx.Animated = True
			Me.Systemx.BorderRadius = 3
			Me.Systemx.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.Systemx.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.Systemx.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.Systemx.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.Systemx.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Systemx.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.Systemx.ForeColor = System.Drawing.Color.White
			Me.Systemx.Location = New System.Drawing.Point(304, 271)
			Me.Systemx.Name = "Systemx"
			Me.Systemx.Size = New System.Drawing.Size(164, 19)
			Me.Systemx.TabIndex = 44
			Me.Systemx.Text = "Reset System Information"
'			Me.Systemx.Click += New System.EventHandler(Me.System_Click)
			' 
			' Gpux
			' 
			Me.Gpux.Animated = True
			Me.Gpux.BorderRadius = 3
			Me.Gpux.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.Gpux.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.Gpux.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.Gpux.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.Gpux.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Gpux.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.Gpux.ForeColor = System.Drawing.Color.White
			Me.Gpux.Location = New System.Drawing.Point(15, 296)
			Me.Gpux.Name = "Gpux"
			Me.Gpux.Size = New System.Drawing.Size(146, 19)
			Me.Gpux.TabIndex = 45
			Me.Gpux.Text = "Reset Gpu Information"
'			Me.Gpux.Click += New System.EventHandler(Me.Gpu_Click)
			' 
			' Ramx
			' 
			Me.Ramx.Animated = True
			Me.Ramx.BorderRadius = 3
			Me.Ramx.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.Ramx.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.Ramx.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.Ramx.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.Ramx.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(43)))), (CInt((CByte(53)))), (CInt((CByte(85)))))
			Me.Ramx.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.Ramx.ForeColor = System.Drawing.Color.White
			Me.Ramx.Location = New System.Drawing.Point(167, 296)
			Me.Ramx.Name = "Ramx"
			Me.Ramx.Size = New System.Drawing.Size(150, 19)
			Me.Ramx.TabIndex = 46
			Me.Ramx.Text = "Reset Ram Information"
'			Me.Ramx.Click += New System.EventHandler(Me.Ram_Click)
			' 
			' Settings
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(485, 326)
			Me.Controls.Add(Me.Ramx)
			Me.Controls.Add(Me.Gpux)
			Me.Controls.Add(Me.Systemx)
			Me.Controls.Add(Me.Cpux)
			Me.Controls.Add(Me.Sidx)
			Me.Controls.Add(Me.guna2Separator3)
			Me.Controls.Add(Me.guna2Button3)
			Me.Controls.Add(Me.guna2Button2)
			Me.Controls.Add(Me.msg12)
			Me.Controls.Add(Me.guna2TextBox1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.guna2Separator2)
			Me.Controls.Add(Me.guna2Separator1)
			Me.Controls.Add(Me.msg8)
			Me.Controls.Add(Me.closeafter)
			Me.Controls.Add(Me.msg10)
			Me.Controls.Add(Me.chrome)
			Me.Controls.Add(Me.msg9)
			Me.Controls.Add(Me.edge)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.msg7)
			Me.Controls.Add(Me.msg5)
			Me.Controls.Add(Me.msg6)
			Me.Controls.Add(Me.msg11)
			Me.Controls.Add(Me.msg4)
			Me.Controls.Add(Me.msg3)
			Me.Controls.Add(Me.msg2)
			Me.Controls.Add(Me.msg1)
			Me.Controls.Add(Me.showapps)
			Me.Controls.Add(Me.showwindows)
			Me.Controls.Add(Me.showadvanced)
			Me.Controls.Add(Me.firefox)
			Me.Controls.Add(Me.rescan)
			Me.Controls.Add(Me.expandall)
			Me.Controls.Add(Me.startup)
			Me.Controls.Add(Me.minimized)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Settings"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Settings"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.Settings_FormClosing)
'			Me.Load += New System.EventHandler(Me.Settings_Load)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private Lbl1 As System.Windows.Forms.Label
		Private minimized As Guna.UI2.WinForms.Guna2CheckBox
		Private WithEvents startup As Guna.UI2.WinForms.Guna2CheckBox
		Private expandall As Guna.UI2.WinForms.Guna2CheckBox
		Private rescan As Guna.UI2.WinForms.Guna2CheckBox
		Private firefox As Guna.UI2.WinForms.Guna2CheckBox
		Private showadvanced As Guna.UI2.WinForms.Guna2CheckBox
		Private showwindows As Guna.UI2.WinForms.Guna2CheckBox
		Private showapps As Guna.UI2.WinForms.Guna2CheckBox
		Private WithEvents msg1 As Guna.UI2.WinForms.Guna2Button
		Private WithEvents msg2 As Guna.UI2.WinForms.Guna2Button
		Private WithEvents msg3 As Guna.UI2.WinForms.Guna2Button
		Private WithEvents msg4 As Guna.UI2.WinForms.Guna2Button
		Private WithEvents msg11 As Guna.UI2.WinForms.Guna2Button
		Private WithEvents msg6 As Guna.UI2.WinForms.Guna2Button
		Private WithEvents msg5 As Guna.UI2.WinForms.Guna2Button
		Private WithEvents msg7 As Guna.UI2.WinForms.Guna2Button
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents msg9 As Guna.UI2.WinForms.Guna2Button
		Private edge As Guna.UI2.WinForms.Guna2CheckBox
		Private WithEvents msg10 As Guna.UI2.WinForms.Guna2Button
		Private chrome As Guna.UI2.WinForms.Guna2CheckBox
		Private WithEvents msg8 As Guna.UI2.WinForms.Guna2Button
		Private closeafter As Guna.UI2.WinForms.Guna2CheckBox
		Private guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
		Private guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
		Private label1 As System.Windows.Forms.Label
		Private guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
		Private WithEvents msg12 As Guna.UI2.WinForms.Guna2Button
		Private WithEvents guna2Button2 As Guna.UI2.WinForms.Guna2Button
		Private WithEvents guna2Button3 As Guna.UI2.WinForms.Guna2Button
		Private guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
		Private WithEvents Sidx As Guna.UI2.WinForms.Guna2Button
		Private WithEvents Cpux As Guna.UI2.WinForms.Guna2Button
		Private WithEvents Systemx As Guna.UI2.WinForms.Guna2Button
		Private WithEvents Gpux As Guna.UI2.WinForms.Guna2Button
		Private WithEvents Ramx As Guna.UI2.WinForms.Guna2Button
	End Class
End Namespace