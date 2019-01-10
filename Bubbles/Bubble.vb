Public Class Bubble

    Private PositionX As Integer
    Private PositionY As Integer
    Private Size As Integer
    Shared Rnd As New Random

    Public Sub New(X As Integer, Y As Integer, S As Integer)
        PositionX = X
        PositionY = Y
        Size = S
    End Sub

    Public Sub New()
        Size = Rnd.Next(10, 40)
        PositionX = Rnd.Next(0, MainForm.PictureBox1.Width - Size - 1)
        PositionY = -Size

    End Sub

    Public Sub Move()
        PositionY += Size / 10
        If PositionY > MainForm.PictureBox1.Height Then
            Size = Rnd.Next(10, 40)
            PositionY = -Size
            PositionX = Rnd.Next(0, MainForm.PictureBox1.Width - Size - 1)
        End If
    End Sub

    Public Sub Draw(g As Graphics)
        Dim Pen As New Pen(Color.Red)
        g.DrawEllipse(Pen, PositionX, PositionY, Size, Size)
    End Sub

End Class
