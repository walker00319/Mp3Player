<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ProgPlayed = New System.Windows.Forms.ProgressBar()
        Me.PlylistList = New System.Windows.Forms.ListBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.FileDiag = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UrlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaylistToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.URLToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlSav = New System.Windows.Forms.SaveFileDialog()
        Me.PlLoad = New System.Windows.Forms.OpenFileDialog()
        Me.PlylistSong = New System.Windows.Forms.ListBox()
        Me.LblINFO = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bTNPLAY = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.ChkRepeat = New System.Windows.Forms.CheckBox()
        Me.Chkshuffle = New System.Windows.Forms.CheckBox()
        Me.Notify1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.player2 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgPlayed
        '
        Me.ProgPlayed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgPlayed.Location = New System.Drawing.Point(13, 415)
        Me.ProgPlayed.Name = "ProgPlayed"
        Me.ProgPlayed.Size = New System.Drawing.Size(649, 23)
        Me.ProgPlayed.TabIndex = 0
        '
        'PlylistList
        '
        Me.PlylistList.FormattingEnabled = True
        Me.PlylistList.Location = New System.Drawing.Point(668, 31)
        Me.PlylistList.Name = "PlylistList"
        Me.PlylistList.ScrollAlwaysVisible = True
        Me.PlylistList.Size = New System.Drawing.Size(10, 407)
        Me.PlylistList.TabIndex = 1
        Me.PlylistList.Visible = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'FileDiag
        '
        Me.FileDiag.Title = "Open Music File"
        '
        'FolderBrowse
        '
        Me.FolderBrowse.RootFolder = System.Environment.SpecialFolder.MyMusic
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlaylistToolStripMenuItem1, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(162, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.PlaylistToolStripMenuItem, Me.UrlToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'PlaylistToolStripMenuItem
        '
        Me.PlaylistToolStripMenuItem.Name = "PlaylistToolStripMenuItem"
        Me.PlaylistToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.PlaylistToolStripMenuItem.Text = "Playlist"
        '
        'UrlToolStripMenuItem
        '
        Me.UrlToolStripMenuItem.Name = "UrlToolStripMenuItem"
        Me.UrlToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.UrlToolStripMenuItem.Text = "Url"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'PlaylistToolStripMenuItem1
        '
        Me.PlaylistToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem1, Me.ExportToolStripMenuItem, Me.AddToolStripMenuItem})
        Me.PlaylistToolStripMenuItem1.Name = "PlaylistToolStripMenuItem1"
        Me.PlaylistToolStripMenuItem1.Size = New System.Drawing.Size(56, 20)
        Me.PlaylistToolStripMenuItem1.Text = "Playlist"
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.OpenToolStripMenuItem1.Text = "Open"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SongToolStripMenuItem, Me.FolderToolStripMenuItem1, Me.URLToolStripMenuItem1})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'SongToolStripMenuItem
        '
        Me.SongToolStripMenuItem.Name = "SongToolStripMenuItem"
        Me.SongToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.SongToolStripMenuItem.Text = "Song"
        '
        'FolderToolStripMenuItem1
        '
        Me.FolderToolStripMenuItem1.Name = "FolderToolStripMenuItem1"
        Me.FolderToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.FolderToolStripMenuItem1.Text = "Folder"
        '
        'URLToolStripMenuItem1
        '
        Me.URLToolStripMenuItem1.Name = "URLToolStripMenuItem1"
        Me.URLToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.URLToolStripMenuItem1.Text = "URL"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolumeToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'VolumeToolStripMenuItem
        '
        Me.VolumeToolStripMenuItem.Name = "VolumeToolStripMenuItem"
        Me.VolumeToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.VolumeToolStripMenuItem.Text = "Volume"
        '
        'PlSav
        '
        Me.PlSav.Title = "Open Play List"
        '
        'PlLoad
        '
        Me.PlLoad.FileName = "OpenFileDialog1"
        '
        'PlylistSong
        '
        Me.PlylistSong.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlylistSong.FormattingEnabled = True
        Me.PlylistSong.Location = New System.Drawing.Point(668, 31)
        Me.PlylistSong.Name = "PlylistSong"
        Me.PlylistSong.ScrollAlwaysVisible = True
        Me.PlylistSong.Size = New System.Drawing.Size(448, 407)
        Me.PlylistSong.TabIndex = 1
        '
        'LblINFO
        '
        Me.LblINFO.AutoSize = True
        Me.LblINFO.Location = New System.Drawing.Point(680, 15)
        Me.LblINFO.Name = "LblINFO"
        Me.LblINFO.Size = New System.Drawing.Size(32, 13)
        Me.LblINFO.TabIndex = 11
        Me.LblINFO.Text = "Song"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'bTNPLAY
        '
        Me.bTNPLAY.Location = New System.Drawing.Point(13, 387)
        Me.bTNPLAY.Name = "bTNPLAY"
        Me.bTNPLAY.Size = New System.Drawing.Size(75, 23)
        Me.bTNPLAY.TabIndex = 12
        Me.bTNPLAY.Text = "Play"
        Me.bTNPLAY.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(265, 387)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(75, 23)
        Me.BtnStop.TabIndex = 12
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(576, 387)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 12
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Location = New System.Drawing.Point(429, 387)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrev.TabIndex = 12
        Me.BtnPrev.Text = "Last"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnPause
        '
        Me.BtnPause.Location = New System.Drawing.Point(147, 387)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(75, 23)
        Me.BtnPause.TabIndex = 12
        Me.BtnPause.Text = "Pause"
        Me.BtnPause.UseVisualStyleBackColor = True
        '
        'ChkRepeat
        '
        Me.ChkRepeat.AutoSize = True
        Me.ChkRepeat.Location = New System.Drawing.Point(165, 11)
        Me.ChkRepeat.Name = "ChkRepeat"
        Me.ChkRepeat.Size = New System.Drawing.Size(61, 17)
        Me.ChkRepeat.TabIndex = 13
        Me.ChkRepeat.Text = "Repeat"
        Me.ChkRepeat.UseVisualStyleBackColor = True
        '
        'Chkshuffle
        '
        Me.Chkshuffle.AutoSize = True
        Me.Chkshuffle.Location = New System.Drawing.Point(232, 12)
        Me.Chkshuffle.Name = "Chkshuffle"
        Me.Chkshuffle.Size = New System.Drawing.Size(59, 17)
        Me.Chkshuffle.TabIndex = 14
        Me.Chkshuffle.Text = "Shuffle"
        Me.Chkshuffle.UseVisualStyleBackColor = True
        '
        'Notify1
        '
        Me.Notify1.Icon = CType(resources.GetObject("Notify1.Icon"), System.Drawing.Icon)
        Me.Notify1.Text = "Notification"
        Me.Notify1.Visible = True
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(301, 12)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(39, 13)
        Me.LblStatus.TabIndex = 15
        Me.LblStatus.Text = "Label1"
        '
        'player2
        '
        Me.player2.Enabled = True
        Me.player2.Location = New System.Drawing.Point(13, 28)
        Me.player2.Name = "player2"
        Me.player2.OcxState = CType(resources.GetObject("player2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player2.Size = New System.Drawing.Size(638, 353)
        Me.player2.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 450)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.Chkshuffle)
        Me.Controls.Add(Me.ChkRepeat)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.bTNPLAY)
        Me.Controls.Add(Me.LblINFO)
        Me.Controls.Add(Me.PlylistSong)
        Me.Controls.Add(Me.PlylistList)
        Me.Controls.Add(Me.ProgPlayed)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1144, 489)
        Me.MinimumSize = New System.Drawing.Size(1144, 489)
        Me.Name = "Form1"
        Me.Text = "Media Player"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgPlayed As ProgressBar
    Friend WithEvents PlylistList As ListBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PlaylistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileDiag As OpenFileDialog
    Friend WithEvents FolderBrowse As FolderBrowserDialog
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaylistToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UrlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumeToolStripMenuItem As ToolStripMenuItem

    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SongToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents URLToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlSav As SaveFileDialog
    Friend WithEvents PlLoad As OpenFileDialog
    Friend WithEvents PlylistSong As ListBox
    Friend WithEvents LblINFO As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnPrev As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPause As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents bTNPLAY As Button
    Friend WithEvents Chkshuffle As CheckBox
    Friend WithEvents ChkRepeat As CheckBox
    Friend WithEvents Notify1 As NotifyIcon
    Friend WithEvents LblStatus As Label
    Friend WithEvents player2 As AxWMPLib.AxWindowsMediaPlayer
End Class
