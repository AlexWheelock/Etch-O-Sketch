Option Explicit On
Option Strict On
'Alex Wheelock
'RCET 0265
'Spring 2024
'Etch-O-Sketch
'https://github.com/AlexWheelock/Etch-O-Sketch.git

Imports System.Media
Imports System.Net.Security

Public Class EtchOSketchForm

    Sub SetDefaults()
        ChooseColor(Color.Black, True)
        DrawingPictureBox.BackColor = Color.LightYellow
    End Sub

    Function ChooseColor(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        Static currentColor As Color

        If update Then
            currentColor = newColor
        End If

        Return currentColor
    End Function

    Sub MouseDraw(newX As Integer, newY As Integer, draw As Boolean)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ChooseColor())
        Static oldX As Integer
        Static oldY As Integer

        If draw Then
            g.DrawLine(pen, oldX, oldY, newX, newY)
        End If

        oldX = newX
        oldY = newY

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawSineWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        g.PageUnit = GraphicsUnit.Pixel
        Dim pen As New Pen(Color.Red)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim radians As Double
        Dim oldX As Double = 0
        Dim oldY As Double = DrawingPictureBox.Height \ 2
        Dim newX As Double
        Dim newY As Double
        Dim angle#
        Dim x As Double = 0

        Dim xMax As Single = 360 '360 made up units
        Dim xScale As Single = DrawingPictureBox.Width / xMax

        Dim yMax As Single = 100 '100 made up units
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1 'calculate the y scale factor

        'apply the scale
        g.ScaleTransform(xScale, yScale)

        'Set the origin to the y middle of the picture box
        g.TranslateTransform(0, yMax * -1)

        'vi = vp * sin(360 * f * t * theta) + DC

        For newX = 0 To 360 Step degree

            angle = (Math.PI / 180) * newX

            newY = (yMax - 10) * Math.Sin(angle)

            g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))

            oldX = newX
            oldY = newY

        Next



        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawCosineWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Blue)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim oldX As Integer = 0
        Dim oldY As Integer = (DrawingPictureBox.Height \ 2) + 150
        Dim newX As Integer
        Dim newY As Integer
        Dim radians As Double
        Dim x As Double = 0

        For x = 0 To 580 Step degree

            radians = (Math.PI / 180) * x * degree

            newX = CInt(x)
            newY = CInt(150 * Math.Cos(radians)) + DrawingPictureBox.Height \ 2
            'newY = CInt(150 * Math.Sin((Math.PI / 180) * x)) + DrawingPictureBox.Height \ 2
            If x = 90 Then
                Debug.Print(CStr(x))
            End If
            g.DrawLine(pen, oldX, oldY, newX, newY)
            oldX = newX
            oldY = newY
        Next



        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawTangentLine()

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Green)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim oldX As Integer = 0
        Dim oldY As Integer = DrawingPictureBox.Height \ 2
        Dim newX As Integer
        Dim newY As Integer
        Dim radians As Double
        Dim x As Double = 0

        For x = 200 To 560 Step degree

            radians = (Math.PI / 180) * x * degree

            newX = CInt(radians)
            newY = CInt(Math.Tan(radians))

            g.DrawLine(pen, oldX, oldY, newX, newY)
            oldX = newX
            oldY = newY
            newX += 1
        Next



        pen.Dispose()
        g.Dispose()
    End Sub

    Sub ClearDrawing()
        Dim currentX As Integer = Me.DesktopLocation.X
        Dim currentY As Integer = Me.DesktopLocation.Y

        'My.Computer.Audio.Play("clearsound.mp3")

        For i = 0 To 50
            currentX += 2
            currentY += 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 100
            currentX -= 2
            currentY -= 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 100
            currentX += 2
            currentY += 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 100
            currentX -= 2
            currentY -= 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 100
            currentX += 2
            currentY += 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 50
            currentX -= 2
            currentY -= 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        DrawingPictureBox.Refresh()
        SetDefaults()

    End Sub

    'Event Handlers Below



    Private Sub MainPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        If e.Button = MouseButtons.Left Then
            MouseDraw(e.X, e.Y, True)
        Else
            MouseDraw(e.X, e.Y, False)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ChooseColor(ColorDialog.Color, True)
        End If
    End Sub

    Private Sub WaveformsButton_Click(sender As Object, e As EventArgs) Handles WaveformsButton.Click
        DrawSineWave()
        'DrawCosineWave()
        'DrawTangentLine()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearDrawing()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ButtonGroupBox_Enter(sender As Object, e As EventArgs) Handles ButtonGroupBox.Enter

    End Sub

    Private Sub EtchOSketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    Private Sub DrawingPictureBox_Click(sender As Object, e As EventArgs) Handles DrawingPictureBox.Click

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub SelectColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ChooseColor(ColorDialog.Color, True)
        End If
    End Sub

    Private Sub DrawWaveformsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawWaveformsToolStripMenuItem.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub MainToolTip_Popup(sender As Object, e As PopupEventArgs) Handles MainToolTip.Popup

    End Sub

    Private Sub TopMenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles TopMenuStrip.ItemClicked

    End Sub

End Class
