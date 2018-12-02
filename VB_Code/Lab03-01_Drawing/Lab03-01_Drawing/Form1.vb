﻿'Harris Ransom
'Lab03-01_Drawing
'Period 8


Public Class Form1
    'Scale is 1 plotted box = 20x20 pixels on the graph paper sheet 

    'Paint method, where the drawings will go
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim formYAxis As Integer = Me.Height 'Y-Axis length of the form
        Dim formXAxis As Integer = Me.Width 'X-Axis length of the form

        'Uses methods to draw the drawing
        DrawMouth(sender, e)
        DrawBack(sender, e)
        DrawEye(sender, e)
        DrawDots(sender, e)
        DrawName(sender, e)
    End Sub



    'Draws mouth
    Private Sub DrawMouth(ByVal sender As Object, ByVal e As Object)
        e.Graphics.DrawLine(New Pen(Color.Black, 3.5), 130, 20, 75, 75)
        e.Graphics.DrawLine(New Pen(Color.Black, 3.5), 75, 75, 130, 130)
    End Sub

    'Draws back
    Private Sub DrawBack(ByVal sender As Object, ByVal e As Object)
        e.Graphics.DrawCurve(New Pen(Color.Black, 3.5), {New Point(130, 20), New Point(115, 10), New Point(75, 5), New Point(50, 10), New Point(40, 15), New Point(25, 25), New Point(20, 30), New Point(10, 45), New Point(5, 55), New Point(0, 75), New Point(5, 95), New Point(10, 105), New Point(20, 120), New Point(35, 135), New Point(40, 140), New Point(50, 145), New Point(75, 150), New Point(115, 140), New Point(130, 130)})
    End Sub

    'Draws eye
    Private Sub DrawEye(ByVal sender As Object, ByVal e As Object)
        e.Graphics.FillEllipse(Brushes.Black, 65, 25, 20, 20)
    End Sub

    'Draws pac-dots
    Private Sub DrawDots(ByVal sender As Object, ByVal e As Object)
        e.Graphics.FillEllipse(Brushes.Black, 130, 65, 15, 15)
        e.Graphics.FillEllipse(Brushes.Black, 175, 65, 15, 15)
        e.Graphics.FillEllipse(Brushes.Black, 215, 65, 15, 15)
    End Sub

    'Draws name
    Private Sub DrawName(ByVal sender As Object, ByVal e As Object)
        e.Graphics.DrawString("HARRIS", New Font("Carmina BLK BT", 26), Brushes.DarkBlue, 250, 50)
    End Sub

End Class

