Imports System.Speech
Imports System
Imports WMPLib
Imports AxWMPLib
Imports System.Math

Public Class Form1
    Public synth As New Synthesis.SpeechSynthesizer
    Dim files As New Collections.Specialized.StringCollection
    Dim playerurl = ""










    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        FileDiag.ShowReadOnly() = True
        FileDiag.Title = "Open Music"
        Dim result = FileDiag.ShowDialog
        If result = DialogResult.OK Then
            Dim filename = FileDiag.FileName
            Player1.URL = (filename)
            Player1.Ctlcontrols.play()


        End If
    End Sub

    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim answer = FolderBrowse.ShowDialog()
        If answer = DialogResult.OK Then
            Dim location = FolderBrowse.SelectedPath
        End If
    End Sub


    Private Sub UrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UrlToolStripMenuItem.Click
        If openurl.ShowDialog = DialogResult.OK Then

        End If
        Player1.URL = openurl.TxtURl.Text

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Player1.BeginInit()
        Notify1.Visible = True
        Me.Text = "Media Player " + My.Application.Info.Version.ToString() + vbNewLine + Player1.status.ToString

    End Sub

    Private Sub SongToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SongToolStripMenuItem.Click
        FileDiag.ShowReadOnly() = True
        FileDiag.Title = "Open Music"
        FileDiag.Multiselect = True
        FileDiag.Filter = "*.mp3|*.mp3"

        Dim result = FileDiag.ShowDialog
        If result = DialogResult.OK Then
            Dim filename = FileDiag.FileNames
            Console.WriteLine("Loaded: " + filename.Count.ToString + "songs!")
            addsongs(filename)



        End If
    End Sub





    Private Sub PlylistList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlylistList.SelectedIndexChanged
        PlylistList.SelectedItem() = PlylistList.SelectedIndex()
        Console.WriteLine("New Selected Song path is:" + PlylistList.SelectedItem().ToString)
        Player1.URL = (PlylistList.SelectedItem().ToString)
        playerurl = PlylistList.SelectedItem().ToString
        Player1.Ctlcontrols.play()
        Console.WriteLine("Now playing: " + Player1.currentMedia.name.ToString)
        synth.SpeakAsync("Now playing: " + Player1.currentMedia.name.ToString)
        Notify1.Visible = True

        Notify1.ShowBalloonTip(15000, "Media Player " + My.Application.Info.Version.ToString(), "Now playing: " + Player1.currentMedia.name.ToString, ToolTipIcon.Info)
    End Sub



    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        PlLoad.Title = "Load Playlist"
        PlLoad.Multiselect = False
        PlLoad.Filter = "*.txt|*.txt"
        If PlLoad.ShowDialog = DialogResult.OK Then

            Dim plfile = PlLoad.FileName.ToString
            Dim filecont = My.Computer.FileSystem.ReadAllText(plfile)
            Dim plfiles = filecont.Split("!")
            PlylistList.Items.Clear()
            'Console.WriteLine("Adding " + plfiles.Count.ToString + " paths to playlist!")
            For Each musfile In plfiles
                PlylistList.Items.Add(musfile)
                'Console.WriteLine(musfile)
                Dim musfilesool = System.IO.Path.GetFileName(musfile)
                PlylistSong.Items.Add(musfilesool)
            Next
        End If


    End Sub

    Private Sub ExportToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        PlSav.Title = "Save Playlist"
        PlSav.Filter = "*.txt|*.txt"
        Dim plfiles As String = Nothing
        If PlSav.ShowDialog = DialogResult.OK Then
            Dim plsavfile = PlSav.FileName.ToString
            'Console.WriteLine("Saving " + PlylistList.Items.Count.ToString + " paths to file!")
            For Each musfile In PlylistList.Items
                'Console.WriteLine(musfile.ToString)
                Dim confile = (musfile.ToString + "!").ToString
                'Console.WriteLine(confile)
                plfiles += confile



            Next
            'Console.WriteLine(plfiles)
            My.Computer.FileSystem.WriteAllText(plsavfile, plfiles, False)



        End If
    End Sub

    Private Sub PlylistSong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlylistSong.SelectedIndexChanged
        PlylistList.SelectedIndex = PlylistSong.SelectedIndex
    End Sub

    Private Sub FolderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem1.Click
        If FolderBrowse.ShowDialog = DialogResult.OK Then
            Dim folderpath = FolderBrowse.SelectedPath
            Dim scan = System.IO.Directory.GetFiles(folderpath.ToString, "*.mp3", IO.SearchOption.AllDirectories)
            addsongs(scan)
        Else


        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Player1.URL <> "" Then

        End If
        Getinfo()

    End Sub

    Private Sub URLToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles URLToolStripMenuItem1.Click
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
        MsgBox("Functions is not available at this time!", vbOKOnly, "Function not availalable!")

        openurl.Visible = False

    End Sub

    Private Sub bTNPLAY_Click(sender As Object, e As EventArgs) Handles bTNPLAY.Click
        Player1.Ctlcontrols.play()
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        Player1.Ctlcontrols.pause()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        Player1.Ctlcontrols.stop()
    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        synth.SpeakAsyncCancelAll()
        If Chkshuffle.Checked = True Then
            Randsong()

        Else
            Prevsong()
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        synth.SpeakAsyncCancelAll()
        If Chkshuffle.Checked = True Then
            Randsong()

        Else
            Nextsong()
        End If

    End Sub


    Private Sub Player1_StatusChange(sender As Object, e As EventArgs) Handles Player1.StatusChange
        LblStatus.Text = Player1.status.ToString
        'Console.WriteLine(Player1.status.ToString())
    End Sub
End Class
