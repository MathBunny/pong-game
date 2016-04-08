Public Class Form2

    Private Sub Settings_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Settings.Tick


        If ComboBox1.Text = "Blue" Then
            Form1.ball.BackColor = Color.Blue


        End If


        If ComboBox1.Text = "Yellow" Then
            Form1.ball.BackColor = Color.Yellow


        End If

        If ComboBox1.Text = "Red" Then
            Form1.ball.BackColor = Color.Red


        End If

        If ComboBox1.Text = "Orange" Then
            Form1.ball.BackColor = Color.Orange

        End If

        If ComboBox1.Text = "Green" Then
            Form1.ball.BackColor = Color.Green



        End If

        If ComboBox1.Text = "Pink" Then
            Form1.ball.BackColor = Color.Pink


        End If


        'Blue
        'Red()
        'Orange()
        'Yellow()
        'Green()
        'Pink()

        If ComboBox2.Text = "Blue" Then
            Form1.Pin1.BackColor = Color.Blue
            Form1.Pin2.BackColor = Color.Blue

        End If


        If ComboBox2.Text = "Yellow" Then
            Form1.Pin1.BackColor = Color.Yellow
            Form1.Pin2.BackColor = Color.Yellow


        End If

        If ComboBox2.Text = "Red" Then
            Form1.Pin1.BackColor = Color.Red
            Form1.Pin2.BackColor = Color.Red

        End If

        If ComboBox2.Text = "Orange" Then
            Form1.Pin1.BackColor = Color.Orange
            Form1.Pin2.BackColor = Color.Orange

        End If

        If ComboBox2.Text = "Green" Then
            Form1.Pin1.BackColor = Color.Green
            Form1.Pin2.BackColor = Color.Green


        End If

        If ComboBox2.Text = "Pink" Then
            Form1.Pin1.BackColor = Color.Pink
            Form1.Pin2.BackColor = Color.Pink


        End If


        'Others


        If TextBox1.Text = "" Then

        Else
            Form1.Timer1.Interval = TextBox1.Text


        End If



        If ComboBox4.Text = "Blue" Then
            Form1.ForeColor = Color.Blue
            Form1.Button1.ForeColor = Color.Blue
            Form1.Button2.ForeColor = Color.Blue
            Form1.Button3.ForeColor = Color.Blue
            Form1.Button4.ForeColor = Color.Blue

        End If

        If ComboBox4.Text = "Red" Then
            Form1.ForeColor = Color.Red
            Form1.Button1.ForeColor = Color.Red
            Form1.Button2.ForeColor = Color.Red
            Form1.Button3.ForeColor = Color.Red
            Form1.Button4.ForeColor = Color.Red
        End If

        If ComboBox4.Text = "Orange" Then
            Form1.ForeColor = Color.Orange
            Form1.Button1.ForeColor = Color.Orange
            Form1.Button2.ForeColor = Color.Orange
            Form1.Button3.ForeColor = Color.Orange
            Form1.Button4.ForeColor = Color.Orange

        End If

        If ComboBox4.Text = "Yellow" Then
            Form1.ForeColor = Color.Yellow
            Form1.Button1.ForeColor = Color.Yellow
            Form1.Button2.ForeColor = Color.Yellow
            Form1.Button3.ForeColor = Color.Yellow
            Form1.Button4.ForeColor = Color.Yellow
        End If

        If ComboBox4.Text = "Green" Then
            Form1.ForeColor = Color.Green
            Form1.Button1.ForeColor = Color.Green
            Form1.Button2.ForeColor = Color.Green
            Form1.Button3.ForeColor = Color.Green
            Form1.Button4.ForeColor = Color.Green
        End If

        If ComboBox4.Text = "Pink" Then
            Form1.ForeColor = Color.Pink
            Form1.Button1.ForeColor = Color.Pink
            Form1.Button2.ForeColor = Color.Pink
            Form1.Button3.ForeColor = Color.Pink
            Form1.Button4.ForeColor = Color.Pink


        End If






        'Blue
        'Red()
        'Orange()
        'Yellow()
        'Green()
        'Pink()

        If ComboBox5.Text = "Blue" Then
            Form1.BackColor = Color.Blue

        End If
        If ComboBox5.Text = "Red" Then
            Form1.BackColor = Color.Red
            Form1.Button1.BackColor = Color.Red
            Form1.Button2.BackColor = Color.Red
            Form1.Button3.BackColor = Color.Red
            Form1.Button4.BackColor = Color.Red

        End If
        If ComboBox5.Text = "Orange" Then
            Form1.BackColor = Color.Orange
            Form1.Button1.BackColor = Color.Orange
            Form1.Button2.BackColor = Color.Orange
            Form1.Button3.BackColor = Color.Orange
            Form1.Button4.BackColor = Color.Orange

        End If
        If ComboBox5.Text = "Yellow" Then
            Form1.BackColor = Color.Yellow
            Form1.Button1.BackColor = Color.Green
            Form1.Button2.BackColor = Color.Green
            Form1.Button3.BackColor = Color.Green
            Form1.Button4.BackColor = Color.Green



        End If
        If ComboBox5.Text = "Green" Then
            Form1.BackColor = Color.Green
            Form1.Button1.BackColor = Color.Green
            Form1.Button2.BackColor = Color.Green
            Form1.Button3.BackColor = Color.Green
            Form1.Button4.BackColor = Color.Green

        End If
        If ComboBox5.Text = "Pink" Then
            Form1.BackColor = Color.Pink
            Form1.Button1.BackColor = Color.Pink
            Form1.Button2.BackColor = Color.Pink
            Form1.Button3.BackColor = Color.Pink
            Form1.Button4.BackColor = Color.Pink

        End If

        If ComboBox5.Text = "Black" Then
            Form1.BackColor = Color.Black
            Form1.Button1.BackColor = Color.Black
            Form1.Button2.BackColor = Color.Black
            Form1.Button3.BackColor = Color.Black
            Form1.Button4.BackColor = Color.Black


        End If



        RichTextBox1.Text = "System Information:" & vbCrLf & vbCrLf & "Computer RAM: " & My.Computer.Info.AvailablePhysicalMemory & vbCrLf & "Computer OS: " & My.Computer.Info.OSFullName & vbCrLf & "Time: " & TimeOfDay

      



    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Pong Wallpaper" Then
            MsgBox("Error: Fatal System Error. Could not find File. Please try again,", MsgBoxStyle.Critical, "Error: Could not Find File")



        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.pin3timer.Interval = 750
        Form1.pin1timer.Interval = 1




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Form1.pin3timer.Interval = 300
        Form1.pin1timer.Interval = 23



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.pin3timer.Interval = 53
        Form1.pin1timer.Interval = 53





    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Form1.pin3timer.Interval = 1
        Form1.pin1timer.Interval = 223



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1.pin3timer.Interval = 1
        Form1.pin1timer.Interval = 443



    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form1.pin3timer.Interval = 1
        Form1.pin1timer.Interval = 768




    End Sub
End Class