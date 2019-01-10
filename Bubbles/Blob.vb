Public Class Blob

    Private PositionX As Integer
    Private PositionY As Integer
    Private DirectionX As Integer
    Private DirectionY As Integer
    Private Size As Integer

    Public Sub New(X As Integer, Y As Integer, S As Integer)
        PositionX = X
        PositionY = Y
        Size = S

        DirectionX = 0
        DirectionY = 0

    End Sub

    Public Sub ChangeDirection(Direction As Char)

        Select Case Direction
            Case "N"
                DirectionX = 0
                DirectionY = -1
            Case "E"
                DirectionX = 1
                DirectionY = 0
            Case "S"
                DirectionX = 0
                DirectionY = 1
            Case "W"
                DirectionX = -1
                DirectionY = 0
            Case "X"
                DirectionX = 0
                DirectionY = 0
        End Select


    End Sub


    Public Sub Move()

        PositionX += DirectionX
        If PositionX <= 0 Then
            DirectionX = 1
        ElseIf PositionX >= MainForm.PictureBox1.Width - Size Then
            DirectionX = -1
        End If

        PositionY += DirectionY
        If PositionY <= 0 Then
            DirectionY = 1
        ElseIf PositionY >= MainForm.PictureBox1.Height - Size Then
            DirectionY = -1
        End If

    End Sub

    Public Sub Draw(g As Graphics)

        Dim Pen As New Pen(Color.Red)
        Dim Brush As New SolidBrush(Color.Black)

        g.FillEllipse(Brush, PositionX, PositionY, Size, Size)

    End Sub

End Class
