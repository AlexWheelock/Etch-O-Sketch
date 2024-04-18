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
        DrawingPictureBox.Refresh()
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

    Sub DrawGraticules()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.DarkGray)

        Const TOP = 0%, LEFT = 0%
        Dim Bottom As Integer = DrawingPictureBox.Height
        Dim Right As Integer = DrawingPictureBox.Width

        Dim xIncrement = DrawingPictureBox.Width \ 10
        Dim yIncrement = DrawingPictureBox.Height \ 10

        For x = xIncrement To Right Step xIncrement
            g.DrawLine(pen, x, TOP, x, Bottom)
        Next

        For y = yIncrement To Bottom - yIncrement Step yIncrement
            g.DrawLine(pen, LEFT, y, Right, y)
        Next

        pen.Dispose()
        g.Dispose()
    End Sub



    'vi = vp * sin(360 * f * t * theta) + DC
    Sub DrawSineWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        g.PageUnit = GraphicsUnit.Pixel
        Dim pen As New Pen(Color.Red)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim angle#, newX#, newY#, oldX#, oldY#

        Dim xMax As Single = 360 '360 made up units
        Dim xScale As Single = DrawingPictureBox.Width / xMax

        Dim yMax As Single = 100 '100 made up units
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1 'calculate the y scale factor

        'apply the scale
        g.ScaleTransform(xScale, yScale)

        'Set the origin to the y middle of the picture box
        g.TranslateTransform(0, yMax * -1)

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
        g.PageUnit = GraphicsUnit.Pixel
        Dim pen As New Pen(Color.Blue)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim angle#, newX#, newY#, oldX#, oldY#

        Dim xMax As Single = 360 '360 made up units
        Dim xScale As Single = DrawingPictureBox.Width / xMax

        Dim yMax As Single = 100 '100 made up units
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1 'calculate the y scale factor

        'apply the scale
        g.ScaleTransform(xScale, yScale)

        'Set the origin to the y middle of the picture box
        g.TranslateTransform(0, yMax * -1)

        For newX = 0 To 360 Step degree

            angle = (Math.PI / 180) * newX

            If newX = 0 Then
                newY = yMax - 10
                oldY = newY
            Else
                newY = (yMax - 10) * Math.Cos(angle)
            End If

            g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))

            oldX = newX
            oldY = newY

        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawTangentLine()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        g.PageUnit = GraphicsUnit.Pixel
        Dim pen As New Pen(Color.Green)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim angle#, newX#, newY#, oldX#, oldY#

        Dim xMax As Single = 360 '360 made up units
        Dim xScale As Single = DrawingPictureBox.Width / xMax

        Dim yMax As Single = 100 '100 made up units
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1 'calculate the y scale factor

        'apply the scale
        g.ScaleTransform(xScale, yScale)

        'Set the origin to the y middle of the picture box
        g.TranslateTransform(0, yMax * -1)

        For newX = 0 To 360 Step degree

            angle = (Math.PI / 180) * newX

            newY = (yMax - 10) * Math.Tan(angle)

            Try
                g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))
            Catch ex As Exception

            End Try

            oldX = newX
            oldY = newY

        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub ClearDrawing()
        Dim currentX As Integer = Me.DesktopLocation.X
        Dim currentY As Integer = Me.DesktopLocation.Y

        Try
            My.Computer.Audio.Play(My.Resources.Shaker, AudioPlayMode.Background)
        Catch ex As Exception

        End Try

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

        For i = 0 To 100
            currentX -= 2
            currentY -= 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 50
            currentX += 2
            currentY += 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

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
        SetDefaults()
        DrawGraticules()
        DrawSineWave()
        DrawCosineWave()
        DrawTangentLine()
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
        SetDefaults()
        DrawGraticules()
        DrawSineWave()
        DrawCosineWave()
        DrawTangentLine()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearDrawing()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub MainToolTip_Popup(sender As Object, e As PopupEventArgs) Handles MainToolTip.Popup

    End Sub

    Private Sub TopMenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles TopMenuStrip.ItemClicked

    End Sub

    Private Sub PictureBoxContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub PictureBoxContextMenuStrip_Opening_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PictureBoxContextMenuStrip.Opening

    End Sub

    Private Sub FileContextMenuButton_Click(sender As Object, e As EventArgs) Handles FileContextMenuButton.Click

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitContextMenuButton.Click

    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click

    End Sub

    Private Sub SelectColorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem1.Click

    End Sub

    Private Sub DrawWaveformsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DrawWaveformsToolStripMenuItem1.Click

    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click

    End Sub
End Class
