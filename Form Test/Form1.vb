Imports System.Math
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form1

    ' http://www.create-games.com/article.asp?id=1761
    ' http://www.stellarpc.com/articles/board.aspx?id=46
    ' http://bytes.com/topic/javascript/answers/501873-distance-angle-between-2-xy-coordinates
    ' http://www-cs-students.stanford.edu/~amitp/gameprog.html
    ' http://www.logos.t.u-tokyo.ac.jp/~franck/research_sum.htm


    ''' <summary>
    ''' Determine angle and distance between mouse location and another point
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Dim angle As Double = GetAngle()

        DrawAngle(New Point(lblPlayer.Left, lblPlayer.Top), CInt(lblDistance.Text), angle, Me.CreateGraphics)
    End Sub

    Private Function GetAngle() As Double
        Dim A As Point = Nothing
        Dim B As Point = Nothing

        Dim MapCoordinates As Boolean = True

        Dim PlayerX As Int32 = lblPlayer.Left
        Dim PlayerY As Int32 = lblPlayer.Top

        ' Work out current screen bounds
        'Dim ScreenBounds As Rectangle = Screen.FromPoint(New Point(MouseX, MouseY)).Bounds

        ' Remove left and top as appropriate
        'MouseX -= ScreenBounds.Left
        'MouseY -= ScreenBounds.Top

        If MapCoordinates Then
            'A = PointToClient(New Point(PlayerY, PlayerX))
            A = New Point(PlayerY, PlayerX)
            B = New Point(lblEnemy.Left, lblEnemy.Top)
        Else
            'A = PointToClient(New Point(PlayerX, PlayerY))
            A = New Point(PlayerX, PlayerY)
            B = New Point(lblEnemy.Left, lblEnemy.Top)
        End If

        Dim Angle As Double = CalculatePointAngle(A, B, False)

        lblAngle1.Text = CInt(Angle).ToString
        lblDistance.Text = CInt(CalculatePointDistance(A, B)).ToString

        Return Angle
    End Function

    Public Shared Function CalculatePointAngle(ByVal pointStart As Point, ByVal pointEnd As Point, Optional ByVal AsRadians As Boolean = True) As Double
        Dim Dy As Double = -(pointEnd.Y - pointStart.Y)
        Dim Dx As Double = (pointEnd.X - pointStart.X)

        Dim AngleInRadians As Double = Math.Atan2(Dy, Dx)

        If (AngleInRadians < 0) Then
            AngleInRadians += 2 * Math.PI
        End If

        If AsRadians Then
            Return AngleInRadians
        Else
            Return RadiansToDegrees(AngleInRadians)
        End If

    End Function

    Public Shared Function CalculatePointDistance(ByVal pointStart As Point, ByVal pointEnd As Point) As Double
        Dim DySquared As Double = Math.Pow(pointEnd.Y - pointStart.Y, 2)
        Dim DxSquared As Double = Math.Pow(pointEnd.X - pointStart.X, 2)

        Dim Distance = Math.Sqrt(DySquared + DxSquared)

        Return Distance
    End Function

    Public Shared Function RadiansToDegrees(ByVal RadiansAngle As Double) As Double
        Return ((RadiansAngle * 180) / Math.PI)
    End Function

    Public Shared Function DegreesToRadians(ByVal DegreesAngle As Double) As Double
        Return ((DegreesAngle * Math.PI) / 180.0F)
    End Function

    Public Shared Function GetVectorByLengthAndAngle(ByVal length As Double, ByVal angle As Double)
        length = Math.Abs(length)
        Return New Point(length * Math.Cos(angle), (length * Math.Sin(angle)))
    End Function

    Public Shared Sub DrawAngle(ByVal pos As Point, ByVal length As Integer, ByVal angle As Double, ByVal g As Graphics)
        'g.DrawLine(New Pen(Brushes.RoyalBlue, 5.0F), pos, New Point(pos.X + length, pos.Y))
        Dim Vector As Point = GetVectorByLengthAndAngle(length, angle)
        g.DrawLine(New Pen(Brushes.RoyalBlue, 5.0F), pos, New Point(pos.X + Vector.X, pos.Y + Vector.Y))
    End Sub


End Class
