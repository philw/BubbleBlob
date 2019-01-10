Public Class MainForm

    Dim Bubble1 As Bubble
    Dim Bubble2 As Bubble
    Dim Player As Blob

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Bubble1 = New Bubble()
        Bubble2 = New Bubble()
        Player = New Blob(200, 200, 20)

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

    Private Sub MainForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        Dim Key As Char

        Key = e.KeyChar.ToString.ToUpper

        Select Case Key
            Case "W"
                Player.ChangeDirection("N")
            Case "A"
                Player.ChangeDirection("W")
            Case "S"
                Player.ChangeDirection("S")
            Case "D"
                Player.ChangeDirection("E")
            Case "X"
                Player.ChangeDirection("X")

        End Select


    End Sub
End Class
