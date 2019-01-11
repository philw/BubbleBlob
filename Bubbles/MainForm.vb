Public Class MainForm

    Dim Bubble1 As Bubble
    Dim Bubble2 As Bubble
    Dim Player As Player

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Bubble1 = New Bubble()
        Bubble2 = New Bubble()
        Player = New Player(200, 200, 20)

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        Bubble1.Draw(e.Graphics)
        Bubble2.Draw(e.Graphics)
        Player.Draw(e.Graphics)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Bubble1.Move()
        Bubble2.Move()
        Player.Move()
        PictureBox1.Refresh()

    End Sub


    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Dim Key As Char

        Key = e.KeyCode.ToString.ToUpper

        Select Case Key
            Case "W"
                Player.StartMove("N")
            Case "A"
                Player.StartMove("W")
            Case "S"
                Player.StartMove("S")
            Case "D"
                Player.StartMove("E")
        End Select

    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        Dim Key As Char

        Key = e.KeyCode.ToString.ToUpper

        Select Case Key
            Case "W"
                Player.StopMove("N")
            Case "A"
                Player.StopMove("W")
            Case "S"
                Player.StopMove("S")
            Case "D"
                Player.StopMove("E")
        End Select

    End Sub

End Class
