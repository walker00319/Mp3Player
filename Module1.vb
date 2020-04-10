Imports System.Globalization
Imports WMPLib
Imports VideoExtractor
Module Module1
    Function Addsongs(paths As String())

        For Each path In paths
            Form1.PlylistList.Items.Add(path)
            Dim songoa = System.IO.Path.GetFileName(path).ToString
            Form1.PlylistSong.Items.Add(songoa)


        Next
        Return (0)
    End Function
    Function Getinfo()
        If Form1.Player1.URL <> Nothing Then


            Form1.LblINFO.Text = Form1.Player1.currentMedia.name.ToString() + "" + TimeSpan.FromSeconds(Form1.Player1.Ctlcontrols.currentPosition).ToString("hh\:mm\:ss") + "/" + TimeSpan.FromSeconds(Form1.Player1.currentMedia.duration).ToString("hh\:mm\:ss")
            Form1.ProgPlayed.Maximum = Int(Form1.Player1.currentMedia.duration)
            Console.WriteLine(Int(Form1.Player1.currentMedia.duration).ToString)
            Form1.ProgPlayed.Value = Int(Form1.Player1.Ctlcontrols.currentPosition)
            Console.WriteLine(Int(Form1.Player1.Ctlcontrols.currentPosition).ToString)
        Else
            Form1.LblINFO.Text = "No Song Playing"
            Form1.ProgPlayed.Value = 0
        End If

        Form1.Text = "Media Player " + My.Application.Info.Version.ToString() + vbNewLine + Form1.Player1.status.ToString
        Return (0)




    End Function


    Function Addurl(url As String)

        Form1.PlylistList.Items.Add(url)
        Form1.PlylistSong.Items.Add(url)

        Return (0)
    End Function
    Function Nextsong()
        If Form1.PlylistList.SelectedIndex = Form1.PlylistList.Items.Count - 1 And Form1.PlylistSong.SelectedIndex = Form1.PlylistSong.Items.Count - 1 Then
            Form1.PlylistSong.SelectedIndex = 0
        Else
            Form1.PlylistSong.SelectedIndex += 1
        End If
        Return (0)
    End Function
    Function Prevsong()
        If Form1.PlylistList.SelectedIndex = 0 And Form1.PlylistSong.SelectedIndex = 0 Then
            Form1.PlylistSong.SelectedIndex = Form1.PlylistSong.Items.Count - 1
        Else
            Form1.PlylistSong.SelectedIndex -= 1
        End If
        Return (0)
    End Function
    Function Randsong()
        Form1.synth.SpeakAsyncCancelAll()
        Dim rand As New Random()
        Dim nextsong = rand.Next(0, Form1.PlylistSong.Items.Count)
        Form1.PlylistSong.SelectedIndex = nextsong

        Return (nextsong)
    End Function
    Function IsDonePlaying()
        Dim playerurl = Form1.Player1.URL
        If Form1.Player1.URL <> "" Then

            If Form1.Player1.Ctlcontrols.currentPosition = Form1.Player1.currentMedia.duration Then

                Return (True)
            Else
                Return (False)
            End If
        Else
            Return (False)
        End If



    End Function
End Module

