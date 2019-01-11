Public Class Player

    Private PositionX As Integer
    Private PositionY As Integer
    Private MoveN As Integer
    Private MoveW As Integer
    Private MoveS As Integer
    Private MoveE As Integer
    Private Size As Integer

    Public Sub New(X As Integer, Y As Integer, S As Integer)
        PositionX = X
        PositionY = Y
        Size = S

        MoveN = 0
        MoveW = 0
        MoveS = 0
        MoveE = 0

    End Sub

    Public Sub StartMove(Direction As Char)

        Select Case Direction
            Case "N"
                MoveN = 1
            Case "S"
                MoveS = 1
            Case "W"
                MoveW = 1
            Case "E"
                MoveE = 1
        End Select

        MainForm.LabelN.Text = "MoveN = " & MoveN

    End Sub

    Public Sub StopMove(Direction As Char)

        Select Case Direction
            Case "N"
                MoveN = 0
            Case "S"
                MoveS = 0
            Case "W"
                MoveW = 0
            Case "E"
                MoveE = 0
        End Select

        MainForm.LabelN.Text = "MoveN = " & MoveN

    End Sub



    Public Sub Move()

        PositionX += (MoveE - MoveW)
        PositionY += (MoveS - MoveN)

    End Sub

    Public Sub Draw(g As Graphics)

        Dim Pen As New Pen(Color.Red)
        Dim Brush As New SolidBrush(Color.Black)

        g.FillEllipse(Brush, PositionX, PositionY, Size, Size)

    End Sub

End Class
