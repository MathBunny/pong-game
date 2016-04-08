Public Class Form1
    Dim MoveUp As Boolean
    Dim MoveLeft As Boolean
    Dim SoundEffects As Boolean = False
    Dim Notification As Boolean = False






    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Notification = False

       

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' When Hits Edges: Console.Beep(900, 200)
        ' When Hits Pin Console.Beep(687, 200)



        If MoveLeft = True Then
            ball.Left += 7


        End If

        If MoveLeft = False Then
            ball.Left -= 7


        End If

        If MoveUp = True Then
            ball.Top += 7


        End If

        If MoveUp = False Then
            ball.Top -= 7

        End If

        If ball.Left <= ClientRectangle.Left Then
            MoveLeft = True
            comwin.Text += 1

            If Form2.ComboBox6.Text = "Enable" Then

                ' When Hits Edges: Console.Beep(900, 200)
                ' When Hits Pin Console.Beep(687, 200)
                Console.Beep(1111, 250)
                Console.Beep(900, 50)


            End If


        End If


        If ball.Right >= ClientRectangle.Right Then
            MoveLeft = False

            mewin.Text += 1

            If Form2.ComboBox6.Text = "Enable" Then

                ' When Hits Edges: Console.Beep(900, 200)
                ' When Hits Pin Console.Beep(687, 200)
                Console.Beep(1111, 250)
                Console.Beep(900, 50)


            End If


        End If

        If ball.Top <= ClientRectangle.Top Then
            MoveUp = True

            If Form2.ComboBox6.Text = "Enable" Then

                ' When Hits Edges: Console.Beep(900, 200)
                ' When Hits Pin Console.Beep(687, 200)
                Console.Beep(900, 50)


            End If

        End If

        If ball.Bottom >= ClientRectangle.Bottom Then
            MoveUp = False
            If Form2.ComboBox6.Text = "Enable" Then

                ' When Hits Edges: Console.Beep(1111, 200)
                ' When Hits Pin Console.Beep(900, 200)
                Console.Beep(900, 50)



            End If

        End If






        If ball.Bottom > Pin1.Top Then
            If ball.Top < Pin1.Bottom Then
                If ball.Left < Pin1.Right Then
                    MoveLeft = True

                    If Timer1.Interval = 1 Then

                    Else

                        Timer1.Interval -= 1


                    End If


                End If

            End If

        End If
        If ball.Bottom > Pin2.Top Then
            If ball.Top < Pin2.Bottom Then
                If ball.Right > Pin2.Left Then
                    MoveLeft = False

                    If Timer1.Interval = 1 Then

                    Else
                        Timer1.Interval -= 1

                    End If




                End If


            End If

        End If










    End Sub

    Private Sub pin1timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pin1timer.Tick
        Pin1.Top = MousePosition.Y - 188



    End Sub

    Private Sub pin3timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pin3timer.Tick
        If ball.Top > Pin2.Top Then
            Pin2.Top += 30
        End If
        If ball.Bottom < Pin2.Bottom Then
            Pin2.Top -= 30
        End If




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub Settings_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
       


    End Sub

    Private Sub Form1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        MsgBox("Thank You for Playing Pong Extreme Edition! Please Play Again some other Time!", MsgBoxStyle.Exclamation, "Thank You!")



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' When Hits Edges: Console.Beep(900, 200)
        ' When Hits Pin Console.Beep(687, 200)
        MsgBox("Welcome to Pong Extreme. I hope you have Fun!", MsgBoxStyle.Exclamation, "Welcome")







    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Enabled = False



    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If comwin.Text > mewin.Text Then
            MsgBox("The Computer Won!!! The Computer Won: " & comwin.Text & " : " & mewin.Text & " - Please Play Again!", MsgBoxStyle.Exclamation, "The Computer Won!")
            MsgBox("Did You Know that You can change the Difficulty in the Additional Settings Page?", MsgBoxStyle.Information, "Change the Difficulty")

        Else
            MsgBox("You Won!!! The Human Won: " & comwin.Text & " : " & mewin.Text & " - Please Play Again!", MsgBoxStyle.Exclamation, "The Human Won!")
            MsgBox("Did You Know that You can change the Difficulty in the Additional Settings Page?", MsgBoxStyle.Information, "Change the Difficulty")


        End If



    End Sub

    Private Sub Score_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Score.Tick

        

        


    End Sub
End Class
